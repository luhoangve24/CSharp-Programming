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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QL_ThueSachEntities : DbContext
    {
        public QL_ThueSachEntities()
            : base("name=QL_ThueSachEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblCalam> tblCalam { get; set; }
        public virtual DbSet<tblCTHDThue> tblCTHDThue { get; set; }
        public virtual DbSet<tblCTHDTra> tblCTHDTra { get; set; }
        public virtual DbSet<tblHDThue> tblHDThue { get; set; }
        public virtual DbSet<tblHDTra> tblHDTra { get; set; }
        public virtual DbSet<tblKhach> tblKhach { get; set; }
        public virtual DbSet<tblLinhvuc> tblLinhvuc { get; set; }
        public virtual DbSet<tblLoaisach> tblLoaisach { get; set; }
        public virtual DbSet<tblNV> tblNV { get; set; }
        public virtual DbSet<tblNXB> tblNXB { get; set; }
        public virtual DbSet<tblNgonngu> tblNgonngu { get; set; }
        public virtual DbSet<tblSach> tblSach { get; set; }
        public virtual DbSet<tblTacgia> tblTacgia { get; set; }
        public virtual DbSet<tblTinhtrang> tblTinhtrang { get; set; }
        public virtual DbSet<tblVipham> tblVipham { get; set; }
    }
}
