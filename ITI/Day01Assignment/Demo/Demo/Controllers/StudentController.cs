using Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class StudentController : Controller
    {
       public IActionResult details(int Id)
        {
            StudentList studentList = new StudentList();
           Student student= studentList.GetById(Id);

            return View("GetStudent",student);
        }

        public IActionResult AllStudents()
        {
            StudentList studentList = new StudentList();
            List<Student> students =studentList.GetStudents();
            return View("GetAllStudents", students);
        }
         
    }
}
