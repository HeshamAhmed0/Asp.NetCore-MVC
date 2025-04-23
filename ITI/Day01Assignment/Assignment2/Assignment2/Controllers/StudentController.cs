using Assignment2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            StudentData studentData = new StudentData();
            Student student = studentData.getStudents(10);
            return View("Index",student);
        }
        public IActionResult GetAll()
        {
            StudentData studentData=new StudentData();
            List<Student> students =studentData.GETALLSTUDENTS();
            return View("GetAllStudents", students);
        }
    }
}
