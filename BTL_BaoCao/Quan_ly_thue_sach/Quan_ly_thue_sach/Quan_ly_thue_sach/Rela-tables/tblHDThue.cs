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
    
    public partial class tblHDThue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblHDThue()
        {
            this.tblCTHDThue = new HashSet<tblCTHDThue>();
            this.tblHDTra = new HashSet<tblHDTra>();
        }
    
        public string Mathue { get; set; }
        public string Makhach { get; set; }
        public string MaNV { get; set; }
        public System.DateTime Ngaythue { get; set; }
        public double Tiendatcoc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCTHDThue> tblCTHDThue { get; set; }
        public virtual tblKhach tblKhach { get; set; }
        public virtual tblNV tblNV { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblHDTra> tblHDTra { get; set; }
    }
}
