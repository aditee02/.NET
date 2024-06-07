//using Microsoft.AspNetCore.Mvc;
//using VehicalRentalSystem1.Services;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Threading.Tasks;
//using VehicalRentalSystem1.Services;

//namespace VehicalRentalSystem1.Controllers
//    {
//        public class ForgotPasswordController : Controller
//        {
//            private readonly IUserService _userService;
//            private readonly IEmailService _emailService;
//        private readonly RegistrationService _registrationService;
//            public ForgotPasswordController(IUserService userService, IEmailService emailService,RegistrationService registrationService)
//            {
//                _userService = userService;
//                _emailService = emailService;
//            _registrationService = registrationService;
//            }

//            [HttpGet]
//            public IActionResult ForgotPassword()
//            {
//                return View();
//            }

//            [HttpPost]
//            public async Task<IActionResult> ForgotPassword(string email)
//            {
//                var user = await _userService.GetUserByEmail(email);
//                if (user == null)
//                {
//                    ViewBag.Message = "User not found with this email.";
//                    return View();
//                }

//                var otp = GenerateOTP();
//                user.ResetToken = otp;
//                await _userService.UpdateUser(user);

//                await _emailService.SendEmailAsync(email, "Password Reset OTP", $"Your OTP is: {otp}");

//                ViewBag.Email = email;
//                return RedirectToAction("VerifyOTP");
//            }

//            [HttpGet]
//            public IActionResult VerifyOTP()
//            {
//                return View();
//            }

//            [HttpPost]
//            public async Task<IActionResult> VerifyOTP(string email, string otp)
//            {
//                var user = await _userService.GetUserByEmail(email);
//                if (user == null || user.ResetToken != otp)
//                {
//                    ViewBag.Message = "Invalid OTP.";
//                    return View();
//                }

//                ViewBag.Email = email;
//                ViewBag.OTP = otp;
//                return RedirectToAction("ResetPassword");
//            }

//            [HttpGet]
//            public IActionResult ResetPassword()
//            {
//                return View();
//            }

//            [HttpPost]
//            public async Task<IActionResult> ResetPassword(string email, string otp, string newPassword)
//            {
//                var user = await _userService.GetUserByEmail(email);
//                if (user == null || user.ResetToken != otp)
//                {
//                    ViewBag.Message = "Invalid OTP.";
//                    return View();
//                }

//                // Update user's password and clear reset token
//                user.Password1 = _registrationService.EncryptPassword(newPassword);
//                user.ResetToken = null;
//                await _userService.UpdateUser(user);

//                TempData["Success"] = "Password reset successful.";
//                return RedirectToAction("Login", "Home"); // Redirect to login page
//            }

//            private string GenerateOTP()
//            {
//                // Generate random OTP
//                return new Random().Next(100000, 999999).ToString();
//            }
//        }
//    }
