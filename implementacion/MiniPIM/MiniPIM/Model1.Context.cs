﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiniPIM
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class grupo07DBEntities : DbContext
    {
        public grupo07DBEntities()
            : base("name=grupo07DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<AtributoPersonalizado> AtributoPersonalizado { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Cuenta> Cuenta { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<ProductoAtributo> ProductoAtributo { get; set; }
        public DbSet<Relacion> Relacion { get; set; }
        public DbSet<RelacionProducto> RelacionProducto { get; set; }
    }
}
