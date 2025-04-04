using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;

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
    }
}
