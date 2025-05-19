using FinalProject.Data;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Repository
{
    public class RepoFunciones : IRepoFunciones
    {
        private readonly FinalProjectDbContext _context;
        public RepoFunciones(FinalProjectDbContext context)
        {
            _context = context;
        }
        public async Task<Funcion> Add(Funcion funcion)
        {
            await _context.Funciones.AddAsync(funcion);
            await _context.SaveChangesAsync();
            return funcion;
        }

        public async Task Delete(int id)
        {
            var funcion = await _context.Funciones.FindAsync(id);
            if (funcion != null)
            {
                _context.Funciones.Remove(funcion);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Funcion?> Get(int id)
        {
            return await _context.Funciones.FindAsync(id);
        }

        public async Task<List<Funcion>> GetAll()
        {
            return await _context.Funciones.Include(f => f.Pelicula).Include(f => f.Sala).AsNoTracking().ToListAsync();
        }

        public async Task Update(Funcion funcion)
        {
            _context.Funciones.Update(funcion);
            await _context.SaveChangesAsync();
        }
    }
}
