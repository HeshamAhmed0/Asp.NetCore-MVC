using Microsoft.AspNetCore.Mvc;

namespace Route.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
