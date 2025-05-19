using FinalProject.Data;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Repository
{
    public class RepoPeliculas : IRepoPeliculas
    {
        private readonly FinalProjectDbContext _context;
        public RepoPeliculas(FinalProjectDbContext context)
        {
            _context = context;
        }
        public async Task<Pelicula> Add(Pelicula pelicula)
        {
            await _context.Peliculas.AddAsync(pelicula);
            await _context.SaveChangesAsync();
            return pelicula;
        }

        public async Task Delete(int id)
        {
            var pelicula = await _context.Peliculas.FindAsync(id);
            if (pelicula != null)
            {
                _context.Peliculas.Remove(pelicula);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Pelicula?> Get(int id)
        {
            return await _context.Peliculas.FindAsync(id);
        }

        public async Task<List<Pelicula>> GetAll()
        {
            return await _context.Peliculas.AsNoTracking().ToListAsync();
        }

        public async Task Update(Pelicula pelicula)
        {
            _context.Peliculas.Update(pelicula);
            await _context.SaveChangesAsync();
        }
    }
}
