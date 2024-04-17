using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PLV_lap02.Controllers
{
    public class PLV_productsController : Controller
    {
        // GET: PLV_products
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Musiclist()
        {
            return View();
        }
        public ActionResult PlayMusic(string songName)
        {
            string filePath = Url.Content("~/Content/" + songName + ".mp3");
            ViewBag.SongUrl = filePath;

            return View("MusicList");
        }
        public FileResult DownloadMusic(string id)
        {
            string filePath = Server.MapPath("~/Content/" + id + ".mp3");
            string contentType = "audio/mpeg";

            return File(filePath, contentType, id + ".mp3");
        }
    }
    

}
