﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BTL_TTCMWeb.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HAWContextEntities1 : DbContext
    {
        public HAWContextEntities1()
            : base("name=HAWContextEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_admin> tbl_admin { get; set; }
        public virtual DbSet<tbl_cart> tbl_cart { get; set; }
        public virtual DbSet<tbl_cartDetail> tbl_cartDetail { get; set; }
        public virtual DbSet<tbl_category> tbl_category { get; set; }
        public virtual DbSet<tbl_color> tbl_color { get; set; }
        public virtual DbSet<tbl_contact> tbl_contact { get; set; }
        public virtual DbSet<tbl_Order> tbl_Order { get; set; }
        public virtual DbSet<tbl_orderDetail> tbl_orderDetail { get; set; }
        public virtual DbSet<tbl_producer> tbl_producer { get; set; }
        public virtual DbSet<tbl_product> tbl_product { get; set; }
        public virtual DbSet<tbl_productColor> tbl_productColor { get; set; }
        public virtual DbSet<tbl_question> tbl_question { get; set; }
        public virtual DbSet<tbl_state> tbl_state { get; set; }
        public virtual DbSet<tbl_user> tbl_user { get; set; }
    }
}
