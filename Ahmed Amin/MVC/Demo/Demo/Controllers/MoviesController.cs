using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class MoviesController : Controller
    {
        //public string GetMovie(int Id )
        //{
        //    return $"Welcome To Movie {Id}";
        //}

        //public string AddMovie(int Id )
        //{
        //    return $"Welcome To Movie {Id}";
        //}

        public ContentResult AddMovie(int Id)
        {
            return Content($"Welcome To Movie {Id}", "text/html");
        }



        public ActionResult GetMovie(int Id)
        {
           if (Id == 1)
            {
                return Content($"Welcome To Movie {Id}", "text/html");
            }
            else if (Id == 2)
            {
                return Redirect("https://chatgpt.com/");
            }
            else
            {
                return RedirectToAction("AddMovie", "Movies");
            }
        }
    }
}
