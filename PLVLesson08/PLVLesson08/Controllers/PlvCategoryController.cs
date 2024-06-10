using PLVLesson08.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PLVLesson08.Controllers
{
    public class PlvCategoryController : Controller
    {
        private static PlvBookstore _PlvBookstore;
        public PlvCategoryController()
        {
            _PlvBookstore = new PlvBookstore(); 
        }
        // GET: PlvCategory
        public ActionResult PlvIndex()
        {
            var plvcategory = _PlvBookstore.plvCategories.ToList();
            return View(plvcategory);
        }
        [HttpGet]
        public ActionResult PlvCreate()
        {
            var plvcategory = new PlvCategory();
            return View();
        }
        [HttpPost]
        public ActionResult PlvCreate(PlvCategory plvCategory)
        {
            _PlvBookstore.plvCategories.Add(plvCategory);
            _PlvBookstore.SaveChanges();
            return RedirectToAction("PlvIndex");
        }
    }
}