﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AAAA.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OOORulEntities : DbContext
    {
        public OOORulEntities()
            : base("name=OOORulEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Datas> Datas { get; set; }
        public virtual DbSet<ItemList> ItemList { get; set; }
        public virtual DbSet<Merch> Merch { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Permisions> Permisions { get; set; }
        public virtual DbSet<Points> Points { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
