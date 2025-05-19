using FinalProject.Data;

namespace FinalProject.Repository
{
    public interface IRepoPeliculas
    {
        Task<List<Pelicula>> GetAll();
        Task<Pelicula?> Get(int id);
        Task<Pelicula> Add(Pelicula pelicula);
        Task Update(Pelicula pelicula);
        Task Delete(int id);
    }
}
