//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quanlybanhang
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblChitietHDBan
    {
        public string MaHDBan { get; set; }
        public string Mahang { get; set; }
        public Nullable<double> Soluong { get; set; }
        public Nullable<double> Dongia { get; set; }
        public Nullable<double> Giamgia { get; set; }
        public Nullable<double> Thanhtien { get; set; }
    
        public virtual tblHang tblHang { get; set; }
        public virtual tblHDBan tblHDBan { get; set; }
    }
}
