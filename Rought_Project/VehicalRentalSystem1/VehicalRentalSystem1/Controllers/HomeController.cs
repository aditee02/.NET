using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VehicalRentalSystem1.Models;
using Microsoft.AspNetCore.Http;
using VehicalRentalSystem1.Services;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using BCrypt.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace VehicalRentalSystem1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ValidationService _userService;

        public HomeController(ValidationService userService, RegistrationService registrationService)
        {
            _userService = userService;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
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
            var authenticatedUser = _userService.Authenticate(user.Email, user.Password1);
            if (authenticatedUser != null)
            {
                HttpContext.Session.SetString("UserSession", authenticatedUser.Email);
                return RedirectToAction("Dashboard");
            }
            ViewBag.Message = "Login Failed..";
            return View();
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            if (HttpContext.Session.GetString("UserSession") != null)
            {
                HttpContext.Session.Remove("UserSession");
                return RedirectToAction("Login");
            }
            return View();
        }
    }
}