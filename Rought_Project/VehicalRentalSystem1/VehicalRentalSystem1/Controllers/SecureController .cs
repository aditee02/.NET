using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace VehicalRentalSystem1.Controllers
{
    [Authorize] // Apply the [Authorize] attribute to the entire controller
    public class SecureController : Controller
    {
        // This action method requires authentication to access
        public IActionResult Index()
        {
            return View();
        }

        // You can also apply [AllowAnonymous] attribute to allow anonymous access to specific action methods
        [AllowAnonymous] // Allow anonymous access to this action method
        public IActionResult PublicAction()
        {
            return View();
        }
    }
}
