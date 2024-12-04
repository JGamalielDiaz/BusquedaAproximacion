using Repositories.Models;

namespace Services.ListasInterface
{
    public interface IListas
    {
        Task<IEnumerable<ListaRiesgo>> GetAllNames();
        Task<IEnumerable<ApproximationResult>> GetNameByAproximation(string nombre);

    }
}
