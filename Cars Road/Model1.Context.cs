﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cars_Road
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Cars_RoadEntities : DbContext
    {
        public Cars_RoadEntities()
            : base("name=Cars_RoadEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Города> Города { get; set; }
        public virtual DbSet<Дороги> Дороги { get; set; }
        public virtual DbSet<СервисныеПункты> СервисныеПункты { get; set; }
    }
}
