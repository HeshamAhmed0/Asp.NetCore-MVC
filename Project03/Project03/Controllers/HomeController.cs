using Microsoft.AspNetCore.Mvc;

namespace Project03.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
        public IActionResult Privacy()
        {
            return View();
        } 
        public IActionResult About()
        {
            return View();
        }
    }
}
