using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PLV_lesson6.Models
{
    public class PlvSong
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage ="PLV: Hãy nhập tiêu đề bài hát")]
        [DisplayName("Tiêu đề")]
        public string PLVTittle { get; set; }

        [Required(ErrorMessage = "PLV: Hãy nhập tên tác giả")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Độ dài trong khoảng từ [2-50]")]
        [DisplayName("Tác giả")]
        public string PLVAuthor { get; set; }

        [Required(ErrorMessage = "PLV: Hãy nhập tên nghệ sĩ")]
        [StringLength(50,MinimumLength =2,ErrorMessage ="Độ dài trong khoảng từ [2-50]")]
        [DisplayName("Nghệ sĩ")]
        public string PLVArtist { get; set; }

        [Required(ErrorMessage = "PLV: Hãy nhập năm xuất bản")]
        [RegularExpression(@"[0-9]{4}",ErrorMessage ="Hãy nhập 4 kí tự là số")]
        [Range(1900,2016,ErrorMessage ="Hãy nhập giá trị trong khoảng: [1900-2016]")]
        [DisplayName("Năm xuất bản")]
        public int PLVYearRelease { get; set; }

    }
}