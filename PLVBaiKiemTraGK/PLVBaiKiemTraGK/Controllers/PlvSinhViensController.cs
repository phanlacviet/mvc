using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PLVBaiKiemTraGK.Models;

namespace PLVBaiKiemTraGK.Controllers
{
    public class PlvSinhViensController : Controller
    {
        private PlvK22CNT2Lesson07DbEntities db = new PlvK22CNT2Lesson07DbEntities();

        // GET: PlvSinhViens
        public ActionResult PLVIndex()
        {
            var plvSinhViens = db.PlvSinhViens.Include(p => p.plvKhoa);
            return View(plvSinhViens.ToList());
        }

        // GET: PlvSinhViens/Details/5
        public ActionResult PLVDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlvSinhVien plvSinhVien = db.PlvSinhViens.Find(id);
            if (plvSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(plvSinhVien);
        }

        // GET: PlvSinhViens/Create
        public ActionResult PLVCreate()
        {
            ViewBag.PlvMaKh = new SelectList(db.plvKhoas, "PlvMaKh", "PlvTenKh");
            return View();
        }

        // POST: PlvSinhViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PLVCreate([Bind(Include = "PlvMaSv,PlvHoSv,PlvTenSv,PlvNgaySinh,PlvPhai,PlvPhone,PlvEmail,PlvMaKh")] PlvSinhVien plvSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.PlvSinhViens.Add(plvSinhVien);
                db.SaveChanges();
                return RedirectToAction("PLVIndex");
            }

            ViewBag.PlvMaKh = new SelectList(db.plvKhoas, "PlvMaKh", "PlvTenKh", plvSinhVien.PlvMaKh);
            return View(plvSinhVien);
        }

        // GET: PlvSinhViens/Edit/5
        public ActionResult PLVEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlvSinhVien plvSinhVien = db.PlvSinhViens.Find(id);
            if (plvSinhVien == null)
            {
                return HttpNotFound();
            }
            ViewBag.PlvMaKh = new SelectList(db.plvKhoas, "PlvMaKh", "PlvTenKh", plvSinhVien.PlvMaKh);
            return View(plvSinhVien);
        }

        // POST: PlvSinhViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PLVEdit([Bind(Include = "PlvMaSv,PlvHoSv,PlvTenSv,PlvNgaySinh,PlvPhai,PlvPhone,PlvEmail,PlvMaKh")] PlvSinhVien plvSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(plvSinhVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("PLVIndex");
            }
            ViewBag.PlvMaKh = new SelectList(db.plvKhoas, "PlvMaKh", "PlvTenKh", plvSinhVien.PlvMaKh);
            return View(plvSinhVien);
        }

        // GET: PlvSinhViens/Delete/5
        public ActionResult PLVDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlvSinhVien plvSinhVien = db.PlvSinhViens.Find(id);
            if (plvSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(plvSinhVien);
        }

        // POST: PlvSinhViens/Delete/5
        [HttpPost, ActionName("PLVDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PlvSinhVien plvSinhVien = db.PlvSinhViens.Find(id);
            db.PlvSinhViens.Remove(plvSinhVien);
            db.SaveChanges();
            return RedirectToAction("PLVIndex");
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
