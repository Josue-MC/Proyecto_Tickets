﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Poyecto_Tickets_DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class sgticketsEntities : DbContext
    {
        public sgticketsEntities()
            : base("name=sgticketsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Nivel_Soporte> Nivel_Soporte { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Ticket> Ticket { get; set; }
        public virtual DbSet<Tipo> Tipo { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}
