using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;

namespace project02.Contllorer
{
    public class ViewContllorer : Controller
    {
        public string GetView()
        {
            return "Hello In View";
        }
    }
}
