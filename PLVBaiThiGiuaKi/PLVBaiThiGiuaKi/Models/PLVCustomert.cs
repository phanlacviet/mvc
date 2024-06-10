using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PLVBaiThiGiuaKi.Models
{
    public class PLVCustomert
    {
        [DisplayName("PLV:Mã Khách hàng")]
        [Required(ErrorMessage ="PLV:Mã Khách hàng không được để trống")]
        [Key]
        public int PLVID { get; set; }

        [DisplayName("PLV:Họ và tên")]
        [Required(ErrorMessage ="PLV: Họ và tên không được để trống")]
        [StringLength(30,MinimumLength =2,ErrorMessage ="PLV:Họ và tên có độ dài từ 2-30")]
        [RegularExpression(@"^[a-zA-Z ]+$")]
        public string PLVFullName { get; set; }

        [DisplayName("PLV: Địa chỉ Email")]
        [Required(ErrorMessage ="PLV: Địa chỉ Email không được để trống")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$",ErrorMessage ="PLV:Địa chỉ Email chưa đúng định dạng, ví dụ: vidu@gmail.vidu")]
        public string PLVEmail { get; set; }
        
        [DisplayName("PLV: Số điện thoại")]
        [Required(ErrorMessage ="PLV: số điện thoại không được để trống")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "PLV: Số điện thoại phải có đúng 10 ký tự số")]
        public int PLVPhone { get; set; }

        internal static void add(PLVCustomert plvcustomer)
        {
            throw new NotImplementedException();
        }

        [DisplayName("PLV:Tuổi")]
        [Required(ErrorMessage ="PLV:Tuôi không được để trống")]
        [Range(18,65,ErrorMessage ="Hãy nhập giá trị trong khoảng [18-65]")]
        public int PLVAge { get; set; }

        [DisplayName("PLV:Giới tính")]
        [Required(ErrorMessage ="PLV:Giới tính không được để trống")]
        [RegularExpression(@"[01]{1}",ErrorMessage ="PLV:Giới tính chỉ được điền 1 hoặc 0")]
        public int PLVGender { get; set; }


    }
}