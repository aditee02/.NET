using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System.IdentityModel.Tokens.Jwt;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Security.Claims;
using System.Text;
using VehicalRentalSystem1.Models;
using VehicalRentalSystem1.Services;
using VehicalRentalSystem1.ViewModel;
using WebMatrix.WebData;

namespace VehicalRentalSystem1.Controllers
{
    public class UserController : Controller
    {

        private readonly ValidationService _userService;
        private readonly RegistrationService _registrationService;
        private readonly IConfiguration _configuration;
        private readonly IEmailService _emailService;
        private readonly VehicalRentalSystemContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public UserController(ValidationService userService, RegistrationService registrationService, IConfiguration config, VehicalRentalSystemContext context, IWebHostEnvironment webHostEnvironment)
        {
            _userService = userService;
            _registrationService = registrationService;
            _configuration = config;
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Login()
        {

            if (HttpContext.Session.GetString("UserSession") != null)
            {
                return RedirectToAction("Dashboard");
            }
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login(User user)
        {
            // Encrypt the password before comparing
            user.Password1 = _registrationService.EncryptPassword(user.Password1);

            var authenticatedUser = _userService.Authenticate(user.Email, user.Password1);

            if (authenticatedUser != null)
            {
                // Set user session
                var jwtToken = GenerateJwtToken(user.Email);

                // Set user session (if needed)
                HttpContext.Session.SetString("UserSession", authenticatedUser.Email);

                Response.Cookies.Append("jwt", jwtToken, new CookieOptions
                {
                    HttpOnly = true,
                    Secure = true, // Enable this if using HTTPS
                    SameSite = SameSiteMode.Strict // Adjust as per your requirements
                });

                // Redirect to the dashboard
                return RedirectToAction("Dashboard");
            }

            ViewBag.Message = "Login Failed..";
            return View();
        }

        [AllowAnonymous]
        [Authorize]
        public IActionResult Dashboard()
        {
            var userEmail = HttpContext.Items["User"] as string;
            if (HttpContext.Session.GetString("UserSession") != null)//&& userEmail != null)
            {
                // Both JWT token and session are present, proceed with dashboard logic
                ViewBag.MySession = HttpContext.Session.GetString("UserSession");
                return View();
            }
            else
            {
                // Either JWT token or session is missing, redirect to login
                return RedirectToAction("Login");
            }

            return View();

        }


        [HttpGet]
        public IActionResult ProfileAsync()
        {

            var userEmail = HttpContext.Session.GetString("UserSession"); // Get the logged-in user's email from session

            // Retrieve the user details from the database based on the email
            var user = _userService.GetUserByEmail(userEmail);

            if (user != null)
            {
                // User found, create a ViewModel containing user details and pass it to the view
                var userProfileViewModel = new User
                {
                    Name = user.Name,
                    Email = user.Email,
                    Age = user.Age,
                    Username = user.Username,
                    UserId = user.UserId,
                    PhoneNo = user.PhoneNo,
                    Address = user.Address
                    // Add other user properties as needed
                };

                return View(userProfileViewModel);
            }
            else
            {
                // User not found, handle accordingly
                return RedirectToAction("Login");
            }
        }

        public IActionResult MyTrips()
        {
            return View();
        }

        public IActionResult RentEarn()
        {
            return View();
        }
        public async Task<IActionResult> Logout()
        {

            if (HttpContext.Session.GetString("UserSession") != null)
            {
                HttpContext.Session.Remove("UserSession");
                return RedirectToAction("Login");
            }

            //await HttpContext.SignOutAsync();
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register(User user, UserViewModel model)
        {
          
            if (ModelState.IsValid)
            {
                var imagePath = Path.Combine(_webHostEnvironment.WebRootPath, "UserImages", model.GovernmentDocImage.FileName);
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    await model.GovernmentDocImage.CopyToAsync(stream);
                }

                // Save the image path to the database
                // Assuming you have a database context named ApplicationDbContext
                // and a User entity with properties including UserName and ImagePath
                var newUser = new User
                {
                    Email = model.Email,
                    GovernmentDoc = imagePath // Save the path to the database
                };
                if (_userService.EmailExists(user.Email))
                {
                    string messege = "Email address is already registered.";
                    ModelState.AddModelError("Email", messege);
                    return View(user);
                }
                if (!_userService.IsEmailValid(user.Email))
                {
                    string messege = "Please Provide Valid Email Address";
                    ModelState.AddModelError("Email", messege);
                    return View(user);
                }
                if (!_userService.BothPassword(user.Password1, user.Password2))
                {
                    string messege = "Both Passwords are not same.";
                    ModelState.AddModelError("Password1", messege);
                    return View(user);
                }
                if (!_userService.Age(user.Age))
                {
                    string messege = "Age Should be Greater than 18";
                    ModelState.AddModelError("Age", messege);
                    return View(user);
                }
                if (!_userService.IsValidPhoneNumber(user.PhoneNo))
                {
                    string messege = "Phone no is not valid";
                    ModelState.AddModelError("Phone No", messege);
                    return View(user);
                }
                if (!_userService.IsPasswordValid(user.Password1))
                {
                    string messege = "Password must be at least 6 characters long and contain at least one capital letter and one number.";
                    ModelState.AddModelError("Password1", messege);
                    return View(user);
                }
                //string imagePath = await UploadImage(Image);

                // Set the image path in the user object
                user.GovernmentDoc = imagePath;

                // Save to database
                _context.Users.Add(user);
                await _context.SaveChangesAsync();


                // Encrypt the password before storing it
                user.Password1 = _registrationService.EncryptPassword(user.Password1);
                user.Password2 = _registrationService.EncryptPassword(user.Password2);

                _userService.RegisterUser(user);

                TempData["Success"] = "Registered Successfully";
                return RedirectToAction("Login");
            }
            return View(user);
        }
        private string GenerateJwtToken(string userEmail)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("ythguritjghtyurfgtedwsujikoltgyh"));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
        new Claim(ClaimTypes.Email, userEmail)
    };

            var token = new JwtSecurityToken(
                issuer: "AditeeKhedekar",
                audience: "your_audience",
                claims: claims,
                notBefore: DateTime.UtcNow,
                expires: DateTime.UtcNow.AddMinutes(30), // Set expiration time 30 minutes from now
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        //public async Task<string> UploadImage(IFormFile imageFile)
        //{
        //    if (imageFile != null && imageFile.Length > 0)
        //    {
        //        try
        //        {

        //            var uploadsFolder = "C:\\vs code\\C#\\VehicalRentalSystem1\\VehicalRentalSystem1\\wwwroot\\UserImages";


        //            var uniqueFileName = Guid.NewGuid().ToString() + "_" + imageFile.FileName;

        //            var filePath = Path.Combine(uploadsFolder, uniqueFileName);
        //            Directory.CreateDirectory(uploadsFolder);

        //            using (var fileStream = new FileStream(filePath, FileMode.Create))
        //            {
        //                await imageFile.CopyToAsync(fileStream);
        //            }
        //            return "/UserImages/" + uniqueFileName;
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);

        //            return "/UserImages/logo.jpg";
        //        }
        //    }
        //    else
        //    {

        //        return "/UserImages/logo.jpg";
        //    }
        //}

    }
}