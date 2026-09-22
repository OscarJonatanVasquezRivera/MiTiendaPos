using Microsoft.EntityFrameworkCore;

using MiTiendaPos.Models;
using MiTiendaPOS.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiTiendaPos.Data
{
    public class MiTiendaPosContext : DbContext
    {
        public MiTiendaPosContext() { }

        public MiTiendaPosContext(DbContextOptions<MiTiendaPosContext> options)
            : base(options)
        {
        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<DetalleVenta> DetalleVentas { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Solo se configura aquí si nadie envió opciones por el constructor
            if (!options.IsConfigured)
            {
                options.UseSqlServer(ConfiguracionApp.ObtenerCadenaConexion());
            }
        }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>()
                 .HasOne(p => p.Categoria)
                 .WithMany(c => c.Productos)
                 .HasForeignKey(p => p.CategoriaId)
                 .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Venta>()
                .HasOne(v => v.Cliente)
                .WithMany(c => c.Ventas)
                .HasForeignKey(v => v.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Venta>()
                .HasOne(v => v.Usuario)
                .WithMany(u => u.Ventas)
                .HasForeignKey(v => v.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DetalleVenta>()
                .HasOne(dv => dv.Producto)
                .WithMany()
                .HasForeignKey(dv => dv.ProductoId)
                .OnDelete(DeleteBehavior.Restrict);

            // Datos semilla (seed data) - definir una sola vez para evitar duplicados
            modelBuilder.Entity<Categoria>().HasData(
                new Categoria { Id = 1, Nombre = "Bebidas" },
                new Categoria { Id = 2, Nombre = "Abarrotes" },
                new Categoria { Id = 3, Nombre = "Limpieza" }
            );

            modelBuilder.Entity<Usuario>().HasData(
                new Usuario { Id = 1, NombreUsuario = "admin", Rol = "Administrador" }
            );





        }
    }
}