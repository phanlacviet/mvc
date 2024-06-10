using PLVBaiThiGiuaKi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PLVBaiThiGiuaKi.Controllers
{
    public class PLVCustomersController : Controller
    {
        //AUthor: Phan Lạc Việt
        // GET: PLVCustomers
        private static List<PLVCustomert> PLVCustomerts = new List<PLVCustomert>()
        {
            new PLVCustomert{PLVID=1,PLVFullName="Phan Lạc Việt 1",PLVEmail="phanlacviet1@gmail.com",PLVPhone=1234567890,PLVAge=20,PLVGender=0},
            new PLVCustomert{PLVID=2,PLVFullName="Phan Lạc Việt 2",PLVEmail="phanlacviet2@gmail.com",PLVPhone=1234567891,PLVAge=25,PLVGender=1}
        };
        public ActionResult PLVIndex()
        {
            return View(PLVCustomerts);
        }
        public ActionResult PLVCreate()
        {
            var plvcustomer = new PLVCustomert();
            return View();
        }
        [HttpPost]
        public ActionResult PLVCreate(PLVCustomert plvcustomer)
        {
            if (!ModelState.IsValid)
            {
                return View(plvcustomer);
            }
            PLVCustomert.add(plvcustomer);
            return RedirectToAction("PLVIndex");
        }
        public ActionResult PLVEdit()
        {
            var plvcustomer = new PLVCustomert();
            return View(plvcustomer);
        }
        [HttpPost]
        public ActionResult PLVEdit(PLVCustomert pLVCustomert)
        {
            if (!ModelState.IsValid)
            {
                return View(pLVCustomert);
            }
            PLVCustomert.add(pLVCustomert);
            return RedirectToAction("PLVIndex");
        }
    }
}