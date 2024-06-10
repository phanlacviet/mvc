using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PLVLesson08.Models;

namespace PLVLesson08.Controllers
{
    public class PlvBooksController : Controller
    {
        private PlvBookstore db = new PlvBookstore();

        // GET: PlvBooks
        public ActionResult PlvIndex()
        {
            return View(db.plvBooks.ToList());
        }

        // GET: PlvBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlvBook plvBook = db.plvBooks.Find(id);
            if (plvBook == null)
            {
                return HttpNotFound();
            }
            return View(plvBook);
        }

        // GET: PlvBooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlvBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PlvBookId,PlvTitle,PlvAuthor,Plvyear,PlvPublisher,PlvPicture,PlvCategoryId")] PlvBook plvBook)
        {
            if (ModelState.IsValid)
            {
                db.plvBooks.Add(plvBook);
                db.SaveChanges();
                return RedirectToAction("PlvIndex");
            }

            return View(plvBook);
        }

        // GET: PlvBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlvBook plvBook = db.plvBooks.Find(id);
            if (plvBook == null)
            {
                return HttpNotFound();
            }
            return View(plvBook);
        }

        // POST: PlvBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PlvBookId,PlvTitle,PlvAuthor,Plvyear,PlvPublisher,PlvPicture,PlvCategoryId")] PlvBook plvBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(plvBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("PlvIndex");
            }
            return View(plvBook);
        }

        // GET: PlvBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlvBook plvBook = db.plvBooks.Find(id);
            if (plvBook == null)
            {
                return HttpNotFound();
            }
            return View(plvBook);
        }

        // POST: PlvBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PlvBook plvBook = db.plvBooks.Find(id);
            db.plvBooks.Remove(plvBook);
            db.SaveChanges();
            return RedirectToAction("PlvIndex");
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
