using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVCProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Message Sent from view data";
            ViewData["CurrentDate"] = DateTime.Now.ToLongTimeString();

            string[] cars = {"Ford", "Ferrari", "Volvo"};
            ViewData["Cars"] = cars;

            // ViewBag 
            ViewBag.Message = "Message Sent from Viewbag";
            ViewBag.CurrentDateTime = DateTime.Now.ToLongDateString();
            string[] car = {"BMW", "Audi", "Ferrari"};
            ViewBag.CarList = car;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}