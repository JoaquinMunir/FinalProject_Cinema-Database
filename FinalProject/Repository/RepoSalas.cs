using FinalProject.Data;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Repository
{
    public class RepoSalas : IRepoSalas
    {
        private readonly FinalProjectDbContext _context;
        public RepoSalas(FinalProjectDbContext context)
        {
            _context = context;
        }
        public async Task<Sala> Add(Sala sala)
        {
            await _context.Salas.AddAsync(sala);
            await _context.SaveChangesAsync();
            return sala;
        }

        public async Task Delete(int id)
        {
            var sala = await _context.Salas.FindAsync(id);
            if (sala != null)
            {
                _context.Salas.Remove(sala);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Sala?> Get(int id)
        {
            return await _context.Salas.FindAsync(id);
        }

        public async Task<List<Sala>> GetAll()
        {
            return await _context.Salas.AsNoTracking().ToListAsync();
        }

        public async Task Update(Sala sala)
        {
            _context.Salas.Update(sala);
            await _context.SaveChangesAsync();
        }
    }
}
