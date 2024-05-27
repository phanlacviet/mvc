using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PLVLap05.Controllers
{
    public class Member
    {
        [Required(ErrorMessage ="Hãy nhập mã số")]
        [DataType(DataType.Currency)]
        public int? Id { get; set; }

        [Required(ErrorMessage = "Hãy nhập tên đăng nhập")]
        public string PLVUsername { get; set; }

        [Required(ErrorMessage = "Hãy nhập họ và tên")]
        public string PLVFullname { get; set; }

        [Required(ErrorMessage = "Hãy nhập mật khẩu")]
        [DataType(DataType.Password)]
        public string PLVPassword { get; set; }

        [Required(ErrorMessage = "Hãy nhập tuổi")]
        [Range(18,50,ErrorMessage ="Hãy nhập tuổi từ 18 đến 50")]
        public int? PLVAge { get; set; }

        [Required(ErrorMessage = "Hãy nhập emails")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",ErrorMessage ="Emails phải đúng định dạng")]
        public string PLVEmails { get; set; }

    }
    public class PLVMemberController : Controller
    {
        // GET: PLVMember
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PLVCreateOne()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PLVCreateOne(Member m)
        {
            return View("PLVDetails",m);
        }
        public ActionResult PLVCreateTwo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PLVCreateTwo(Member m)
        {
            if (m.Id == null)
            {
                ViewBag.error = "Hãy nhập mã số";
                return View();
            }
            if (m.PLVFullname == null)
            {
                ViewBag.error = "Hãy nhập họ và tên";
                return View();
            }
            if (m.PLVPassword == null)
            {
                ViewBag.error = "Hãy nhập mật khẩu";
                return View();
            }
            if (m.PLVUsername == null)
            {
                ViewBag.error = "Hãy nhập tên đăng nhập";
                return View();
            }
            if (m.PLVAge == null)
            {
                ViewBag.error = "Hãy nhập tuổi";
                return View();
            }
            if (m.PLVEmails== null)
            {
                ViewBag.error = "Hãy nhập Emails";
                return View();
            }
            string regexPattern = @"[A-Za-z0-9._%+-]+[A-Za-z0-9.-]+\.[A-Za-z]{2,4}";
            if (!System.Text.RegularExpressions.Regex.IsMatch(m.PLVEmails, regexPattern))
            {
                ViewBag.error = "Hãy nhập đúng định dạng";
                return View();
            }
            return View("PLVDetails",m);
        }
        public ActionResult PLVCreateThree()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PLVCreateThree(Member m)
        {
            if (ModelState.IsValid)
                return View("PLVDetails", m);
            else
                return View();
        }
        public ActionResult PLVDetails()
        {
            return View();
        }
    }
}