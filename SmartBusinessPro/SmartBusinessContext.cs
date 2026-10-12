using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace SmartBusinessPro
{
    /// <summary>
    /// Contexto de datos centralizado. Es el único lugar donde se configura
    /// la conexión a SQL Server; los formularios solo crean una instancia.
    /// </summary>
    public class SmartBusinessContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured) return;

            // La cadena de conexión se lee de App.config (no está escrita en el código)
            string cadena = ConfigurationManager.ConnectionStrings["SmartBusinessConnection"]?.ConnectionString;

            if (string.IsNullOrWhiteSpace(cadena))
                throw new InvalidOperationException(
                    "No se encontró la cadena de conexión 'SmartBusinessConnection' en App.config.");

            optionsBuilder.UseSqlServer(cadena);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>()
                .HasOne(p => p.Categoria)
                .WithMany(c => c.Productos)
                .HasForeignKey(p => p.CategoriaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
