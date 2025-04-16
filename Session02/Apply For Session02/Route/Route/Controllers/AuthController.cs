using Microsoft.AspNetCore.Mvc;

namespace Route.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult SignIn()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
