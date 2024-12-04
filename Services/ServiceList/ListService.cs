using FuzzySharp;
using Repositories;
using Repositories.Models;
using Services.ListasInterface;

namespace Services.ServiceList
{
    public class ListService : IListas
    {
        private readonly IListRepositories _listasRepo;
        public ListService(IListRepositories listasRepo)
        {
            _listasRepo = listasRepo;
        }

        public async Task<IEnumerable<ListaRiesgo>> GetAllNames()
        {
            return await _listasRepo.GetAllNamenAsync();
        }

        public async Task<IEnumerable<ApproximationResult>> GetNameByAproximation(string nombre)
        {
            var listNames = await _listasRepo.GetAllNamenAsync();
            List<ApproximationResult> results = new List<ApproximationResult>();

            foreach (var name in listNames)
            {

                results.Add(new ApproximationResult
                {
                    Nombre = name.nombre,
                    Lista = name.lista,
                    Porcentaje = Fuzz.TokenSetRatio(nombre.ToUpper(), name.nombre.ToUpper()),
                });
            }
            return results;
        }
    }
}
