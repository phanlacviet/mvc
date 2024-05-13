using PLV_lesson5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PLV_lesson5.Controllers
{
    public class PLVCustomerScaffdingController : Controller
    {
        // GET: PLVCustomerScaffding
        private static List<PlvCustomer> listcustomer = new List<PlvCustomer>()
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
        public ActionResult Index()
        {

            return View(listcustomer);
        }
        [HttpGet]
        public ActionResult Plvcreate()
        {
            var model = new PlvCustomer();
            return View(model);
        }
        [HttpPost]
        public ActionResult Plvcreate(PlvCustomer moldel)
        {
            listcustomer.Add(moldel);
            return RedirectToAction("Index");
        }
        public ActionResult PLVEdit(int id)
        {
            var customer = listcustomer.FirstOrDefault(x => x.customerid == id);
            return View(customer);
        }
        [HttpPost]
        public ActionResult PLVEdit(PlvCustomer cus)
        {
            var customer = listcustomer.FirstOrDefault(x => x.customerid == cus.customerid);
            customer.firstname = cus.firstname;
            customer.lastname = cus.lastname;
            customer.address = cus.address;
            customer.yearofbirth = cus.yearofbirth;
            return RedirectToAction("Index");
        }
    }
}