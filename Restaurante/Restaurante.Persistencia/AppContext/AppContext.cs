using System;
using Restaurante.Dominio;
//using Restaurante.Persistencia;
using Microsoft.EntityFrameworkCore;

namespace Restaurante.Persistencia
{
    // Herencia del Entety Framework. Db Context clase del Entety Frame que tiene la herencia del Entity
    public class AppContext : DbContext
    { 
        // Creación de las tablas de la base de datos, que se migran a SQLSERVER
        public DbSet<Asignacion> Asignaciones {get; set;}
        public DbSet<Comanda> Comandas {get; set;}
        public DbSet<Deta_Fact> Deta_Facts {get; set;}
        public DbSet<Detal_Asignacion> Detal_Asignaciones {get; set;}
        public DbSet<Detal_comanda> Detal_comandas {get; set;}
        public DbSet<Factura> Facturas {get; set;}
        public DbSet<Login> Logins {get; set;}
        public DbSet<Menu> Menus {get; set;}
        public DbSet<Mesa> Mesas {get; set;}
        public DbSet<Persona> Personas {get; set;}
        public DbSet<Rol> Roles {get; set;}
        public DbSet<TipoPersona> TipoPersonas {get; set;}
        // Metodo que permite guardar la configuración 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            { 
               // Esta es la cadena de conexión al servidor
                optionsBuilder.UseSqlServer("Server=SOPORTE; Database=Restaurante; Integrated Security=True;");
            }
        }
    }  

}
