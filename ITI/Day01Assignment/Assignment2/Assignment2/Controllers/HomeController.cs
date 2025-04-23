using System.Diagnostics;
using Assignment2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Details()
        {
            return View();
        }
        
    }
}
