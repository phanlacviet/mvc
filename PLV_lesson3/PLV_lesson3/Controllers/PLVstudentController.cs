using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PLV_lesson3.Controllers
{
    public class PLVstudentController : Controller
    {
        // GET: PLVstudent
        public ActionResult Index()
        {
            ViewData["msg"] = "Phan Lạc Việt";
            ViewData["time"] = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy tt");
            return View();
        }
        public ActionResult studenlist() 
        {
            ViewBag.title1 = "Danh sách học viên - Phan Lạc Việt";
            string[] names = { "Nguyễn Văn A", "Phan Văn B", "Trần Văn C", "Đinh Quốc D" };
            ViewBag.list = names;
            var obj = new
            {
                ID = 100,
                Name = "Phan Lac Việt",
                Age = 20
            };
            ViewBag.student = obj;
            return View();
        }
        public ActionResult Insert()
        {
            return View("AddStudent");
        }
    }
}