using Microsoft.Data.SqlClient;
using Repositories.Models;

namespace Repositories
{
    public class ListRepositories : IListRepositories
    {
        private readonly string _connectionString;
        public ListRepositories(String connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<IEnumerable<ListaRiesgo>> GetAllNamenAsync()
        {
            var lista = new List<ListaRiesgo>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("SELECT * FROM MiTabla", connection))
                {
                    SqlDataReader reader = await command.ExecuteReaderAsync();
                    while (await reader.ReadAsync())
                    {
                        lista.Add(new ListaRiesgo
                        {
                            nombre = reader.GetString(0),
                            lista = reader.GetString(1)

                        });
                    }
                }
            }

            return lista;
        }

    }
}
