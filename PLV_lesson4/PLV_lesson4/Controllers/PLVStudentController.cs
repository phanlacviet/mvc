using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PLV_lesson4.Controllers
{
    public class PLVStudentController : Controller
    {
        //Author: Phan Lạc Việt
        //Class: K22CNT2
        // GET: PLVStudent
        public ActionResult Index()
        {
            ViewBag.fullname = "Phan Lạc Việt";
            ViewData["Brithday"] = "17/06/2004";
            TempData["phone"] = "0989930824";
            return View();
        }
        public ActionResult Details()
        {
            string plvstr = "";
            plvstr += "<h3>Họ và tên: Phan Lạc Việt<h3/>";
            plvstr += "<p>Mã số:2210900079";
            plvstr += "<p>Địa chỉ email: lacvietphan578@gmail.com";
            ViewBag.details = "";
            return View("chitiet");
        }
        public ActionResult NgonnguRazor()
        {
            string[] names = { "Phan Văn A", "Đỗ Văn B", "Nguyễn Thị C", "Cao Bá D" };
            ViewBag.names = names;
            return View();
        }
        public ActionResult addnewstudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult addnewstudent(FormCollection form)
        {
            string fullname = form["Fullname"];
            string masv = form["masv"];
            string Taikhoan = form["taikhoan"];
            string Matkhau = form["matkhau"];
            string plvstr = "<h3>" + fullname + "<h3/>";
            plvstr += "<p>" + masv;
            plvstr += "<p>" + Taikhoan;
            plvstr += "<p>" + Matkhau;
            ViewBag.info = plvstr;
            return View("ketqua");
        }
    }
}