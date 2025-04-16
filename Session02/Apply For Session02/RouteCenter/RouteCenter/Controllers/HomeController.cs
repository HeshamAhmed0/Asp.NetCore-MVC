using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RouteCenter.Models;

namespace RouteCenter.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}
