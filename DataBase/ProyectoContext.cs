using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ProyectoProgramcionIV.Models;

namespace ProyectoProgramcionIV.DataBase
{
    public class ProyectoContext : DbContext
    {
        public ProyectoContext():base("name=Proyecto")
        {
            
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            // Configuración de la relación entre Cliente y CondicionPag
            modelBuilder.Entity<Cliente>()
                .HasRequired(c => c.CondicionPago)
                .WithMany()
                .HasForeignKey(c => c.CondicionPagoId);
        }

        public DbSet<Categoría> Categoria { get; set; }
        public DbSet<UnidadMedida> UnidadMedida { get; set; }
        public DbSet<GrupoDescuento> GrupoDescuento { get; set; }
        public DbSet<CondicionPag> CondicionPag { get; set; }
        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Factura> Factura { get; set; }
    }
}