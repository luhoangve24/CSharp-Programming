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
    
    public partial class tblSanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSanPham()
        {
            this.tblChiTietHDDX = new HashSet<tblChiTietHDDX>();
            this.tblChiTietHDNH = new HashSet<tblChiTietHDNH>();
        }
    
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public double Soluong { get; set; }
        public double Gianhap { get; set; }
        public double Giaban { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblChiTietHDDX> tblChiTietHDDX { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblChiTietHDNH> tblChiTietHDNH { get; set; }
    }
}