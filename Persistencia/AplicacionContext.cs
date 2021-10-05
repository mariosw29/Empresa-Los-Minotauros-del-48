using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Persistencia
{
    public class AplicacionContext : DbContext
    {
        private const string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog = Empresa;Integrated Security = True";
        public DbSet<Empleado>  Empleados { get; set; }
        public DbSet<Persona>   Personas { get; set; }
        public DbSet<Cliente>   Clientes { get; set; }
        public DbSet<Cargo>     Cargos { get; set; }
        public DbSet<Empresa>   Empresas { get; set; }
        public DbSet<Proveedor> Proveedors { get; set; }
        public DbSet<Productos> Productos { get; set; }

        public AplicacionContext() { }

            public AplicacionContext(DbContextOptions<AplicacionContext> options)
            :base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder
                .UseSqlServer(connectionString);
            }
        }
    }
}