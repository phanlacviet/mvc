//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PLVBaiKiemTraGK.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PlvSinhVien
    {
        public string PlvMaSv { get; set; }
        public string PlvHoSv { get; set; }
        public string PlvTenSv { get; set; }
        public Nullable<System.DateTime> PlvNgaySinh { get; set; }
        public Nullable<bool> PlvPhai { get; set; }
        public string PlvPhone { get; set; }
        public string PlvEmail { get; set; }
        public string PlvMaKh { get; set; }
    
        public virtual plvKhoa plvKhoa { get; set; }
    }
}
