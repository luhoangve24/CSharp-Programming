//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quan_ly_thue_sach.Rela_tables
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCTHDTra
    {
        public string Matra { get; set; }
        public string Masach { get; set; }
        public string MaVP { get; set; }
        public double Thanhtien { get; set; }
    
        public virtual tblSach tblSach { get; set; }
        public virtual tblHDTra tblHDTra { get; set; }
        public virtual tblVipham tblVipham { get; set; }
    }
}
