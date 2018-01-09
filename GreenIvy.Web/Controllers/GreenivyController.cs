using GreenIvy.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GreenIvy.Web.Controllers
{
    public class GreenivyController : Controller
    {
        private MyModel db = new MyModel();
        public string str()
        {
            return "returned string ";
        }

        public JsonResult studentsJson()
        {
            var tmp = db.Students.ToList();
            return Json(tmp, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index()
        {
            return View();
        }


    }
}