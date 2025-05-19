using FinalProject.Data;

namespace FinalProject.Repository
{
    public interface IRepoFunciones
    {
        Task<List<Funcion>> GetAll();
        Task<Funcion?> Get(int id);
        Task<Funcion> Add(Funcion pelicula);
        Task Update(Funcion pelicula);
        Task Delete(int id);
    }
}
