﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EtiquetasProduccion.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EtiquetasProduccionContext : DbContext
    {
        public EtiquetasProduccionContext()
            : base("name=EtiquetasProduccionContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Evidence> Evidence { get; set; }
        public virtual DbSet<Folio> Folio { get; set; }
        public virtual DbSet<Line_Made> Line_Made { get; set; }
        public virtual DbSet<Order_> Order_ { get; set; }
        public virtual DbSet<Order_Evidence> Order_Evidence { get; set; }
    }
}