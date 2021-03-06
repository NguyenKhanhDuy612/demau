//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace demau.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;


    public partial class SINHVIEN
    {
        [DisplayName("Mã sinh viên")]
        public string MaSV { get; set; }
        [DisplayName("Họ sinh viên")]
        public string HoSV { get; set; }
        [DisplayName("Tên sinh viên")]
        public string TenSV { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DisplayName("Ngày sinh")]
        public System.DateTime NgaySinh { get; set; }
        [DisplayName("Giới tính")]
        public Nullable<bool> GioiTinh { get; set; }
        [DisplayName("ẢNh sinh viên")]
        public string AnhNV { get; set; }
        [DisplayName("Địa chỉ")]
        public string DiaChi { get; set; }
        [DisplayName("Mã lớp")]
        public string MaLop { get; set; }
        [DisplayName("Lớp")]

        public virtual LOP LOP { get; set; }
    }
}
