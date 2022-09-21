using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TallerMecanica.App.Dominio.Entidades;

namespace TallerMecanica.App.Persistencia.AppRepositorios
{
    public class ApplicationContext:DbContext
    {
        // public DbSet<Persona> Personas {get;set;}
        public DbSet<Tecnico> Tecnicos {get;set;}
        public DbSet<Cliente> Clientes {get;set;}
        public DbSet<Vehiculo> Vehiculos {get;set;}
        public DbSet<Revision> Revisiones {get;set;}
        public DbSet<Repuesto> Repuestos {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-PCDN2RJ\\SQLEXPRESS01; Initial Catalog = TallerMecanica");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Revision>()
            .HasKey(b=>b.MatenimientoId);
            // modelBuilder.Entity<Persona>()
            // .HasKey(b=>b.PersonaId);
            modelBuilder.Entity<Tecnico>()
            .HasKey(b=>b.TecnicoId);
            modelBuilder.Entity<Cliente>()
            .HasKey(b=>b.ClienteId);
            modelBuilder.Entity<Vehiculo>()
            .HasKey(b=>b.VehiculoId);
            modelBuilder.Entity<Repuesto>()
            .HasKey(b=>b.RepuestoId);
            // Relacion uno a uno
            modelBuilder.Entity<Tecnico>()
            .HasMany(b=>b.SusRevisiones)
            .WithOne(b=>b.SuTecnico);
        }   
    }
}