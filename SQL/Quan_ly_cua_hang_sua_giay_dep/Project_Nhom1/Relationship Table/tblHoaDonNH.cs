//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_Nhom1.Relationship_Table
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblHoaDonNH
    {
        public string MaHDN { get; set; }
        public string Manhanvien { get; set; }
        public string Makhach { get; set; }
        public System.DateTime Ngaynhan { get; set; }
        public double Tongtien { get; set; }
    
        public virtual tblChiTietHDNH tblChiTietHDNH { get; set; }
        public virtual tblKhachHang tblKhachHang { get; set; }
        public virtual tblNhanVien tblNhanVien { get; set; }
    }
}