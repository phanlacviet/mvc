using PLV_lesson5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PLV_lesson5.Controllers
{
    public class PlvCustomerController : Controller
    {
        // GET: PlvCustomer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PLVCustomerDetails()
        {
            var customer = new PlvCustomer()
            {
                customerid = 1,
                firstname = "Phan Lạc",
                lastname = "Việt",
                address = "K22-CNT2",
                yearofbirth = 2004
            };
            ViewBag.customer = customer;
            return View();
        }
        public ActionResult PLVlistCustomer()
        {
            var list = new List<PlvCustomer>
            {
                    new PlvCustomer()
                {
                    customerid = 1,
                    firstname = "Phan Lạc",
                    lastname = "Việt",
                    address = "K22-CNT2",
                    yearofbirth = 2004
                },
                    new PlvCustomer()
                {
                    customerid = 2,
                    firstname = "Nguyên Văn ",
                    lastname = "A",
                    address = "K22-CNT2",
                    yearofbirth = 1992
                },
                    new PlvCustomer()
                {
                    customerid = 3,
                    firstname = "Nguyên Văn ",
                    lastname = "B",
                    address = "K22-CNT2",
                    yearofbirth = 1999
                },
                    new PlvCustomer()
                {
                    customerid = 4,
                    firstname = "Nguyên Văn ",
                    lastname = "C",
                    address = "K22-CNT2",
                    yearofbirth = 1993
                }
            };
            ViewBag.list = list;
            return View();
        }
    }
}