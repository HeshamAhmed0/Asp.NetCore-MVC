using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Project01.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ContentResult ShowContest()
        {
            ContentResult result = new ContentResult();
            result.Content = "Hello Hesham";
            return result;
        }
        public ViewResult viewResult()
        {
            ViewResult result = new ViewResult();
            result.ViewName = "View1";
            return result;
        }

        public JsonResult ShowwJson()
        {
            JsonResult jsonResult = new JsonResult(new {Id =20 , Name = "hassan"});
            return jsonResult;  
            
        }
        public IStatusCodeActionResult ShowRE(int id)
        {
            if (id % 2 == 0)
            {
                ViewResult result = new ViewResult();
                result.ViewName = "View1";
                return result;
            }
            else
            {
                JsonResult jsonResult = new JsonResult(new { Id = 20, Name = "hassan" });
                return jsonResult;
            }
        }
    }

}
