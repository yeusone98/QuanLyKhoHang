//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_ChungTu> tb_ChungTu { get; set; }
        public virtual DbSet<tb_ChungTu_ChiTiet> tb_ChungTu_ChiTiet { get; set; }
        public virtual DbSet<tb_CongTy> tb_CongTy { get; set; }
        public virtual DbSet<tb_DonViTinh> tb_DonViTinh { get; set; }
        public virtual DbSet<tb_NhaCungCap> tb_NhaCungCap { get; set; }
        public virtual DbSet<tb_SYS_Function> tb_SYS_Function { get; set; }
        public virtual DbSet<tb_SYS_GROUP> tb_SYS_GROUP { get; set; }
        public virtual DbSet<tb_SYS_REPORT> tb_SYS_REPORT { get; set; }
        public virtual DbSet<tb_SYS_RIGHT> tb_SYS_RIGHT { get; set; }
        public virtual DbSet<tb_SYS_RIGHT_REP> tb_SYS_RIGHT_REP { get; set; }
        public virtual DbSet<tb_SYS_USER> tb_SYS_USER { get; set; }
        public virtual DbSet<tb_TonKho> tb_TonKho { get; set; }
    }
}
