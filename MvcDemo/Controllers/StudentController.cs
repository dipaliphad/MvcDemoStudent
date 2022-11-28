using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;
using MvcDemo.Models;
namespace MvcDemo.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult List()
        {
            List<Student> Student = new List<Student>()
            {
                new Student{Id=1, Name="Tushar",std="8th",Percentage=56.12},
                new Student{Id=2, Name="Ajay",std="9th",Percentage=84.09},
                new Student{Id=3, Name="Rohan",std="7th",Percentage=80.00},
                new Student{Id=4, Name="Amol",std="10th",Percentage=78.78},
                new Student{Id=5, Name="Suraj",std="5th",Percentage=73.08},
            };
            ViewData["studlist"] = Student;
            ViewBag.StudList = Student;
            return View();
        }
       
     
    }
}
