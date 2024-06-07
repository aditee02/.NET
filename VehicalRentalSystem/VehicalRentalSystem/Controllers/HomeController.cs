using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VehicalRentalSystem.Models;
using Microsoft.AspNetCore.Http;

namespace VehicalRentalSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly VehicalRentalSystemContext context;

        public HomeController(VehicalRentalSystemContext context) 
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("UserSession") != null)
            {
                return RedirectToAction("Dashboard");

            }
            return View();
        }

        [HttpPost]
        public IActionResult Login(User Luser)
        {
            var myUser = context.Logins.Where(x => x.Email == Luser.Email && x.Password == Luser.Password1).FirstOrDefault();
            if (myUser != null) {
                HttpContext.Session.SetString("UserSession",myUser.Email);
                return RedirectToAction("Dashboard");
            }
            if (myUser == null)
            {
                ViewBag.Message = "Login Failed";
            }
            return View();
        }

        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetString("UserSession") != null)
            {
                ViewBag.MySesssion = HttpContext.Session.GetString("UserSession").ToString();

            }
            else
            {
                return RedirectToAction("Login");
            }
            return View();
        }
        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("UserSession") != null)
            {
                HttpContext.Session.Remove("UserSession");
                return RedirectToAction("Login");
            }
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Login Luser)
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
    }
}
