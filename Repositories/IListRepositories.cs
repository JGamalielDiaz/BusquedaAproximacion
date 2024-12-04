using Repositories.Models;

namespace Repositories
{
    public interface IListRepositories
    {
        Task<IEnumerable<ListaRiesgo>> GetAllNamenAsync();
    }
}
