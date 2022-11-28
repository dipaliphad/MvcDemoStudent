using Microsoft.AspNetCore.Mvc;
using MvcDemo.Models;
using System;

namespace MvcDemo.Controllers
{
    public class CustomersController : Controller
    {
       
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Register(Customers cust)
        {
            try
            {
                int res = CustomersDAL.CustomerRegister(cust);
                if(res == 1)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    return View();
                }
            }
            catch(Exception ex)
            {
                return View();
            }
           
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Login(Customers cust)
        {
            return View();
        }
    }
}
