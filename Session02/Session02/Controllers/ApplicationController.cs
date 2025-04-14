using Microsoft.AspNetCore.Mvc;

namespace Session02.Controllers
{
    public class ApplicationController :Controller
    {
        [HttpPost]
        public string GetAction([FromBody]int? Id ,[FromHeader]string Name)
        {
            return $"Id : {Id} , Name : {Name}";
        }
    }
}
