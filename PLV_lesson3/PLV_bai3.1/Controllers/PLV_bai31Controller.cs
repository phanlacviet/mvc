using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PLV_bai3._1.Controllers
{
    public class PLV_bai31Controller : Controller
    {
        // GET: PLV_bai31
        public ActionResult insonguyento()
        {
            return View();
        }
        public ActionResult ingiaithua()
        {
            return View();
        }
        public ActionResult inbangcuuchuong()
        {
            ViewBag.bang = "Bảng cửu chương của";
            return View();
        }
    }
}