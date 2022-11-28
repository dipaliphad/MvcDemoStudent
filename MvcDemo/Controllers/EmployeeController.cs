using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MvcDemo.Models;
namespace MvcDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult List()
        {
            List<Employee> employee = new List<Employee>()
            {
                new Employee{Id=1, Name="Tushar",Designation="Manager",Salary=56000},
                new Employee{Id=2, Name="Ajay",Designation="Development",Salary=44000}, 
                new Employee{Id=3, Name="Rohan",Designation="Development",Salary=54000},
                new Employee{Id=4, Name="Amol",Designation="Tester",Salary=50000},
                new Employee{Id=5, Name="Suraj",Designation="Tester",Salary=46000},
            };
            ViewData["emplist"]=employee;
            ViewBag.EmpList = employee;
            return View();
        }
    }
}
