using System.Security.Cryptography;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using project02.Models;

namespace project02.Contllorer
{
    public class ViewContllorer : Controller
    {
        public string GetView(int Id )
        {
            return "Hello In View";
        }
        [HttpGet]
        public string GetAction(int? Id , string Name)
        {
           return $"Hello {Name}";
        }
        public IActionResult GetREquest(int? Id, string Name)
        {
            if (Id == 0 || Id is null)
                return BadRequest();
            else if (Id < 10)
                return NotFound();
            else
                return Content($"Name ={Name} Id ={Id}");
        }

        [HttpPost]
        public IActionResult TestModelBinding(int? Id ,string Name)
        {
            return Content($"Hello {Name} Youir Id is {Id}");
        }

        #region Test Redirection
        //public IActionResult TestRedirectio()
        //{
        //    return RedirectToRoute("First", new { Controller = "ViewContllorer", action = "GetREquest", Id = 30 });
        //    //return Redirect("https://www.facebook.com/");
        //    //return RedirectToAction(nameof(GetAction), new { Id = 10, Name = "hesham" });
        //}

        //public IActionResult Test()
        //{
        //    //return Redirect("https://www.aucegypt.edu/academics/free-english-courses");
        //    //return RedirectToAction(nameof(GetREquest), new { Id =50});
        //    //return RedirectToRoute("First", new { Controller = "ViewContllorer", action= "GetREquest" ,Id =50});
        //} 
        #endregion

        [HttpGet]
        public IActionResult AddMovie(string Title ,Movie movie, int? Id )
        {
            return Content($"Movie Name : {movie.Title} , Movie Id : {movie.Id} , Id : {Id} , Title : {Title}");
        }
    }
}
