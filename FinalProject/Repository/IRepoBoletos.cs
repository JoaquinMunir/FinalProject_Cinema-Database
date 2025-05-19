using FinalProject.Data;

namespace FinalProject.Repository
{
    public interface IRepoBoletos
    {
        Task<List<Boleto>> GetAll();
        Task<Boleto?> Get(int id);
        Task<Boleto> Add(Boleto boleto);
        Task Update(Boleto boleto);
        Task Delete(int id);
    }
}
