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
    
    public partial class tblXuong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblXuong()
        {
            this.tblHoaDonDX = new HashSet<tblHoaDonDX>();
        }
    
        public string Maxuong { get; set; }
        public string Tenxuong { get; set; }
        public string Diachi { get; set; }
        public string Dienthoai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblHoaDonDX> tblHoaDonDX { get; set; }
    }
}