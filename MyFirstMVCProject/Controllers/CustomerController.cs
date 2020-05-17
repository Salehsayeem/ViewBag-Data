using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFirstMVCProject.Models;

namespace MyFirstMVCProject.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            List<Customer> cus = new List<Customer>
            {
                new Customer
                {
                    Id = 1,
                    Name = "Sayeem",
                    Address = "Dhaka"
                }
            };
            ViewBag.Customer = cus;
            return View();
        }
    }
}