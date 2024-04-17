using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PLV_lap2._2.Controllers
{
    public class PLV_productController : Controller
    {
        // GET: PLV_product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowProduct()
        {
            return View();
        }
        public ActionResult EditProduct(int? productId)
        {
            ViewBag.id = productId;
            return View();
        }
        public ActionResult DetailsProduct(string productName, int? productId)
        {
            ViewBag.name = productName;
            ViewBag.id = productId;
            return View();
        }
    }
}