﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityProje
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProjeEntityEntities : DbContext
    {
        public ProjeEntityEntities()
            : base("name=ProjeEntityEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TblKategori> TblKategori { get; set; }
        public virtual DbSet<TblMusteri> TblMusteri { get; set; }
        public virtual DbSet<TblSatıs> TblSatıs { get; set; }
        public virtual DbSet<TblUrun> TblUrun { get; set; }
    }
}