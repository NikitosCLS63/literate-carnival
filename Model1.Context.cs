﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PRR5AVTOsalon
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AvtosalonVipDataBaseEntities : DbContext
    {
        public AvtosalonVipDataBaseEntities()
            : base("name=AvtosalonVipDataBaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Avtomobili> Avtomobili { get; set; }
        public virtual DbSet<Chek> Chek { get; set; }
        public virtual DbSet<Info> Info { get; set; }
        public virtual DbSet<Klients> Klients { get; set; }
        public virtual DbSet<MarkaAvtomobila> MarkaAvtomobila { get; set; }
        public virtual DbSet<ModeliAvtomobila> ModeliAvtomobila { get; set; }
        public virtual DbSet<Rolu> Rolu { get; set; }
        public virtual DbSet<Satrudniki> Satrudniki { get; set; }
        public virtual DbSet<ServiseRecords> ServiseRecords { get; set; }
        public virtual DbSet<Tovar> Tovar { get; set; }
    }
}