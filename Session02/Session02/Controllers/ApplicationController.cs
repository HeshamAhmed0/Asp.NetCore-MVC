using Microsoft.AspNetCore.Mvc;

namespace Session02.Controllers
{
    public class ApplicationController :Controller
    {
        public string GetAction(int? Id ,string Name)
        {
            return $"Id : {Id} , Name : {Name}";
        }
    }
}
