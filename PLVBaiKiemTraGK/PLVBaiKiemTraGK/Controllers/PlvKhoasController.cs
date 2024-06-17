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
    public class PlvKhoasController : Controller
    {
        private PlvK22CNT2Lesson07DbEntities db = new PlvK22CNT2Lesson07DbEntities();

        // GET: PlvKhoas
        public ActionResult PLVIndex()
        {
            return View(db.plvKhoas.ToList());
        }

        // GET: PlvKhoas/Details/5
        public ActionResult PLVDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            plvKhoa plvKhoa = db.plvKhoas.Find(id);
            if (plvKhoa == null)
            {
                return HttpNotFound();
            }
            return View(plvKhoa);
        }

        // GET: PlvKhoas/Create
        public ActionResult PLVCreate()
        {
            return View();
        }

        // POST: PlvKhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PLVCreate([Bind(Include = "PlvMaKh,PlvTenKh,PlvTrangThai")] plvKhoa plvKhoa)
        {
            if (ModelState.IsValid)
            {
                db.plvKhoas.Add(plvKhoa);
                db.SaveChanges();
                return RedirectToAction("PLVIndex");
            }

            return View(plvKhoa);
        }

        // GET: PlvKhoas/Edit/5
        public ActionResult PLVEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            plvKhoa plvKhoa = db.plvKhoas.Find(id);
            if (plvKhoa == null)
            {
                return HttpNotFound();
            }
            return View(plvKhoa);
        }

        // POST: PlvKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PLVEdit([Bind(Include = "PlvMaKh,PlvTenKh,PlvTrangThai")] plvKhoa plvKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(plvKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("PLVIndex");
            }
            return View(plvKhoa);
        }

        // GET: PlvKhoas/Delete/5
        public ActionResult PLVDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            plvKhoa plvKhoa = db.plvKhoas.Find(id);
            if (plvKhoa == null)
            {
                return HttpNotFound();
            }
            return View(plvKhoa);
        }

        // POST: PlvKhoas/Delete/5
        [HttpPost, ActionName("PLVDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            plvKhoa plvKhoa = db.plvKhoas.Find(id);
            db.plvKhoas.Remove(plvKhoa);
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
