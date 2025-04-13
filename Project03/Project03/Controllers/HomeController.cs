using Microsoft.AspNetCore.Mvc;

namespace Project03.Controllers
{
    public class HomeController : Controller
    {
        public string ReturnResul(int id)
        {
            if (id == 0)
                return $"Id {id}";
            else
                return $"Id {id}";
        }
       
    }
}
