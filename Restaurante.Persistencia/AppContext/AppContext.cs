using System;
using Restaurante.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Restaurante.Persistencia
{
    
    public class AppContext : DbContext
    { 
        public DbSet<Asignacion> Asignaciones {get; set;}
        public DbSet<Comanda> Comandas {get; set;}
        public DbSet<Detal_Asignacion> Deta_Asignaciones {get; set;}
        public DbSet<Deta_Fact> Deta_Facts {get; set;}
        public DbSet<Detal_comanda> Detal_comandas {get; set;}
        public DbSet<Factura> Facturas {get; set;}
        public DbSet<Menu> Menus {get; set;}
        public DbSet<Mesa> Mesas {get; set;}
        public DbSet<Persona> Personas {get; set;}
        public DbSet<TipoPersona> TipoPersonas {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            { 
                optionsBuilder.UseSqlServer("Server=SOPORTE; Database=Restaurante; Integrated Security=True;");
            }
        }
    }  

}
