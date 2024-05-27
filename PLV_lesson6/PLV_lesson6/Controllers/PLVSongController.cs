using PLV_lesson6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PLV_lesson6.Controllers
{
    public class PLVSongController : Controller
    {
        // GET: PLVSong
        private static List<PlvSong> plvSongs = new List<PlvSong>()
        {
            new PlvSong{ID=2210,PLVTittle="Phan Lạc Việt",PLVAuthor="K22CNT2",PLVArtist="Việt",PLVYearRelease=2020},
            new PlvSong{ID=22130,PLVTittle="Nguyễn Văn C",PLVAuthor="K22CNT2",PLVArtist="Việt",PLVYearRelease=2020}
        };
        public ActionResult PLVIndex()
        {
            return View(plvSongs);
        }
        public ActionResult PLVCreate()
        {
            var plvsong = new PlvSong();
            return View(plvsong);
        }
        [HttpPost]
        public ActionResult PLVCreate(PlvSong plvSong)
        {
            if (!ModelState.IsValid)
            {
                return View(plvSong);
            }
            plvSongs.Add(plvSong);
            return RedirectToAction("PLVIndex");
        }
    }
}