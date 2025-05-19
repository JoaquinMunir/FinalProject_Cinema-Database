using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data
{
    public class FinalProjectDbContext : DbContext
    {
        public FinalProjectDbContext(DbContextOptions<FinalProjectDbContext> options) : base(options)
        {
        }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Funcion> Funciones { get; set; }
        public DbSet<Sala> Salas { get; set; }
        public DbSet<Boleto> Boletos { get; set; }

    }
}
