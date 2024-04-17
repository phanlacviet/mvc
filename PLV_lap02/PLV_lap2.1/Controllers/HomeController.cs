﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using System.Text;
using System.IO;

namespace WebApplication1.Controllers
{
    public class Student
    {
        public int id { get; set; }
        public string Name { get; set; }
        public String Classname { get; set; }
    }
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
        public ViewResult TestViewResult()
        {
            return View();
        }
        public PartialViewResult TestPartialViewResult()
        {
            return PartialView();
        }
        public EmptyResult TestEmptyResult()
        {
            return new EmptyResult();
        }
        public RedirectResult TestRedirectResult()
        {
            return Redirect("Index");

        }
        public JsonResult TestJsonResult()
        {
            List<Student> listStudent = new List<Student>();
            listStudent.Add(new Student(){id = 001,Name = "Nguyễn Quang Huy", Classname = "C1311L" });
            listStudent.Add(new Student() { id = 001, Name = "Nguyễn Quang Huy", Classname = "C1311J" });
            listStudent.Add(new Student() { id = 001, Name = "Nguyễn Quang Hiển", Classname = "C1311H" });
            listStudent.Add(new Student() { id = 001, Name = "Nguyễn Duy Huân", Classname = "C1311T" });
            listStudent.Add(new Student() { id = 001, Name = "Vũ Quang Huy", Classname = "C1311C" });
            listStudent.Add(new Student() { id = 001, Name = "Trần Quang Huy", Classname = "C1311L" });
            listStudent.Add(new Student() { id = 001, Name = "Phạm Quang Huy", Classname = "C1311L" });
            listStudent.Add(new Student() { id = 001, Name = "Trịnh Quang Huy", Classname = "C1311B" });
            listStudent.Add(new Student() { id = 001, Name = "Vũ Quang Huy", Classname = "C1311L" });
            listStudent.Add(new Student() { id = 001, Name = "Vũ Minh Trịnh", Classname = "C1311M" });
            return Json(listStudent, JsonRequestBehavior.AllowGet);
        }
    public JavaScriptResult TestJavaScriptResult()
        {
            string js = @"function checkEMail() {
                    var btloc = /^([w-]+(?:.[w-]+)*)@((?:[w-]+.) *w[w-]{0,66}).([a-z]{2,6}(?:.[a-z]{2})?)$/i;
                    var mail = 'example@example.com';
                    var kq = false;
                    if (btloc.test(mail)) { 
                        kq = true; 
                    } else {
                        alert('Email address invalid');
                        kq = false;
                    }
                    return kq;
                }";
            return JavaScript(js);
        }
        public ContentResult TestContentResult()
        {
            XElement contentXML = new XElement("Students",
            new XElement("Student",
            new XElement("ID", "001"),
            new XElement("FullName", "Nguyễn Viết Nam"),
            new XElement("ClassName", "C1308H")),
            new XElement("Student",
            new XElement("ID", "002"),
            new XElement("FullName", "Nguyễn Hoàng Anh"),
            new XElement("ClassName", "C1411P")),
            new XElement("Student",
            new XElement("ID", "003"),
            new XElement("FullName", "Phạm Ngọc Anh"),
            new XElement("ClassName", "C1411L")),
            new XElement("Student",
            new XElement("ID", "004"),
            new XElement("FullName", "Trần Ngọc Linh"),
            new XElement("ClassName", "C1411H")),
            new XElement("Student",
            new XElement("ID", "005"),
            new XElement("FullName", "Nguyễn Hồng Anh"),
            new XElement("ClassName", "C1411L")));
            return Content(contentXML.ToString(), "text/xml",
            Encoding.UTF8);
        }
        public FileContentResult TestFileContenReslut()
        {
            byte[] filebytes = System.IO.File.ReadAllBytes(Server.MapPath("~/Content/demo.mp3"));
            string filename = "demo mp3";
            return File(filebytes, "nhac/mp3", filename);
        }
        public FileStreamResult TestFileStreamResult()
        {
            string pathFile = Server.MapPath("~/Content/bt.docx");
            string filename = "bt.docx";
            return File(new FileStream(pathFile, FileMode.Open), "text/docx", filename);
        }
        public FilePathResult TestFilePathResult()
        {
            string pathfile = Server.MapPath("~/Content/bt.docx");
            string filename = "bt.docx";
            return File(pathfile, "text/docx", filename);
        }
    }
}