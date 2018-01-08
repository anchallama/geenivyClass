using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GreenIvy.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult Test()
        {
            return View("Contact");
        }

        public ActionResult Test2(string name)
        {
            ViewBag.Name = name;
            return View();
        }

        public ActionResult Test3()
        {
            return RedirectToAction("Index");
        }
    }
}