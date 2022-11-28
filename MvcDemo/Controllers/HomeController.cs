using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcDemo.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MvcDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult index()
        {
            ViewBag["message"] = "This is Viewdata example";
            ViewData["name"] = "sam";
            ViewData["per"] = 80.80;
            List<string> colors = new List<string>()
            {
                "Red", "Green","Blue","White","Pink"
            };

            ViewData["colors"]=colors;

            ViewBag.UserName = "Tushar";
            ViewBag.Email = "tushar@gmail.com";
            ViewBag.Colors=colors;
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
