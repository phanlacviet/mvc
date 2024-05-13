using PLVLap04._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PLVLap04._1.Controllers
{
    public class PLVCustomerController : Controller
    {
        // GET: PLVCustomer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CustomerDetail()
        {
            PLVCustomer cus = new PLVCustomer()
            {
                CustomerId = "KH001",
                FullName = "Phan Lạc Việt",
                Address = "Hà Nội",
                Email = "lacvietphan578@gamil.com",
                Phone = "0989930824",
                Balance = 1000000
            };
            return View(cus);
        }
        public ActionResult CustomerList()
        {
            //tạo một danh sách khách hàng
            List<PLVCustomer> listcustomer = new List<PLVCustomer>(){
            new PLVCustomer(){ CustomerId = "KH001",
            FullName = "Phan Lạc Việt",
            Address = "Hà Nội",Email = "lacvietphan578@gamil.com",
            Phone = "0989930824",Balance = 1000000},
            new PLVCustomer(){ CustomerId = "KH002", FullName = "Đỗ Thị Cúc",
            Address = "Hà Nội",Email = "cucdt@gmail.com",
            Phone = "0986.767.444",Balance = 2200000},
            new PLVCustomer(){ CustomerId = "KH003",
            FullName = "Nguyễn Tuấn Thắng",
            Address = "Nam Định",Email = "thangnt@gmail.com",
            Phone = "0924.656.542",Balance = 1200000},
            new PLVCustomer(){ CustomerId = "KH004", FullName = "Lê Ngọc Hải",
            Address = "Hà Nội",Email = "hailn@gmail.com",
            Phone = "0996.555.267",Balance = 6200000 }
            };
            //gán dữ liệu vào ViewBag để chuyển qua View
            ViewBag.listcustomer = listcustomer;
            return View();
        }
    }
}