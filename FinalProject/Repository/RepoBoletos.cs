using FinalProject.Data;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Repository
{
    public class RepoBoletos : IRepoBoletos
    {
        private readonly FinalProjectDbContext _context;
        public RepoBoletos(FinalProjectDbContext context)
        {
            _context = context;
        }
        public async Task<Boleto> Add(Boleto boleto)
        {
            await _context.Boletos.AddAsync(boleto);
            await _context.SaveChangesAsync();
            return boleto;
        }

        public async Task Delete(int id)
        {
            var boleto = await _context.Boletos.FindAsync(id);
            if (boleto != null)
            {
                _context.Boletos.Remove(boleto);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Boleto?> Get(int id)
        {
            return await _context.Boletos.FindAsync(id);
        }

        public async Task<List<Boleto>> GetAll()
        {
            return await _context.Boletos.Include(b => b.Funcion).AsNoTracking().ToListAsync();
        }
        public async Task Update(Boleto boleto)
        {
            _context.Boletos.Update(boleto);
            await _context.SaveChangesAsync();
        }
    }
}
