using Microsoft.AspNetCore.Mvc;
using MvcDemo.Models;

namespace MvcDemo.Controllers
{
    public class StudController : Controller
    {
        public IActionResult AddStud()
        {
            return View();
        }
        public IActionResult AddStud( Stud std)
        {
            return View();
        }
    }
}
