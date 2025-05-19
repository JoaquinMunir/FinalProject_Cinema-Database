using FinalProject.Data;

namespace FinalProject.Repository
{
    public interface IRepoSalas
    {
        Task<List<Sala>> GetAll();
        Task<Sala?> Get(int id);
        Task<Sala> Add(Sala sala);
        Task Update(Sala sala);
        Task Delete(int id);
    }
}
