using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PlvLesson11.Models;
using PlvLesson11.ModelView;

namespace PlvLesson11.Controllers
{
    public class PlvTaiKhoansController : Controller
    {
        private PlvLesson11DbEntities db = new PlvLesson11DbEntities();

        // GET: PlvTaiKhoans
        public ActionResult Index()
        {
            return View(db.PlvTaiKhoans.ToList());
        }

        // GET: PlvTaiKhoans/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlvTaiKhoan plvTaiKhoan = db.PlvTaiKhoans.Find(id);
            if (plvTaiKhoan == null)
            {
                return HttpNotFound();
            }
            return View(plvTaiKhoan);
        }

        // GET: PlvTaiKhoans/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlvTaiKhoans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Plvid,PlvUserName,PlvPassWord,PlvFullName,PlvAge,PlvEmail,PlvPhone,PlvStatus")] PlvTaiKhoan plvTaiKhoan)
        {
            if (ModelState.IsValid)
            {
                db.PlvTaiKhoans.Add(plvTaiKhoan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(plvTaiKhoan);
        }

        // GET: PlvTaiKhoans/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlvTaiKhoan plvTaiKhoan = db.PlvTaiKhoans.Find(id);
            if (plvTaiKhoan == null)
            {
                return HttpNotFound();
            }
            return View(plvTaiKhoan);
        }

        // POST: PlvTaiKhoans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Plvid,PlvUserName,PlvPassWord,PlvFullName,PlvAge,PlvEmail,PlvPhone,PlvStatus")] PlvTaiKhoan plvTaiKhoan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(plvTaiKhoan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(plvTaiKhoan);
        }

        // GET: PlvTaiKhoans/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlvTaiKhoan plvTaiKhoan = db.PlvTaiKhoans.Find(id);
            if (plvTaiKhoan == null)
            {
                return HttpNotFound();
            }
            return View(plvTaiKhoan);
        }

        // POST: PlvTaiKhoans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PlvTaiKhoan plvTaiKhoan = db.PlvTaiKhoans.Find(id);
            db.PlvTaiKhoans.Remove(plvTaiKhoan);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult PlvLogin()
        {
            var plvModel = new PlvLoginModel();
            return View(plvModel);
        }

        [HttpPost]
        public ActionResult TvcLogin(PlvLoginModel plvModel)
        {
            // khi người dùng nhấn nút đăng nhập; xử lý và tìm kiến, so sanh trong db

            var tvcCheckLogin = db.PlvTaiKhoan.Where(x => x.PlvTaikhoan.Equals(plvModel.PlvUserName) && x.PlvPassword.Equals(plvModel.PlvPassword)).FirstOrDefault();
            if (tvcCheckLogin != null)
            {
                //Lưu trữ session
                Session["PlvMember"] = tvcCheckLogin;

                return Redirect("/");
            }
            return View(plvModel);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
