using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlvLesson11.Controllers
{
    public class PlvHomeController : Controller
    {
        public ActionResult PlvIndex()
        {
            return View();
        }

        public ActionResult PlvAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult PlvContact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}