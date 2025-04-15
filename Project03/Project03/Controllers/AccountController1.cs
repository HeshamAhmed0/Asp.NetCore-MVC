using Microsoft.AspNetCore.Mvc;

namespace Project03.Controllers
{
    public class AccountController1 : Controller
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
