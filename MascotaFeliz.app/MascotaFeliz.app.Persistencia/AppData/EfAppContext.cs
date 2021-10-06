using System;
using Microsoft.EntityFrameworkCore;
using MascotaFeliz.app.Dominio.Entidades;

namespace MascotaFeliz.app.Persistencia.AppData{
    public class EfAppContext:DbContext
    {
        public DbSet<Persona> Personas {get; set;}
        public DbSet<Propietario> Propietarios {get; set;}
        public DbSet<Medico> Medicos {get; set;}
        public DbSet<Mascota> Mascotas {get; set;}       
        public DbSet<CentroVeterinario> CentrosVeterinarios {get; set;}
        public DbSet<VisitaProgramada> VisitasProgramadas {get; set;}
        public DbSet<RegistroVisita> RegistrosVisitas {get; set;}
        public DbSet<TipoAnimal> TiposAnimales {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            
            //cadena de conexión
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-3JED4U8\\SQLEXPRESS;Initial Catalog=MascotaFeliz;integrated security = true");
            }
        }
        public EfAppContext(){}
    }
}