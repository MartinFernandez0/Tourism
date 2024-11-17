using TourismServices.Interfaces;
using TourismServices.Models;
using System.Text.Json;

namespace TourismServices.Services
{
    public class ClientService : GenericService<pfClient>, IClientService
    {
        public async Task<List<pfClient>?> GetAllAsync(string? filtro)
        {
            var response = await client.GetAsync($"{_endpoint}?filtro={filtro}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<pfClient>>(content, options);
        }

        public async Task<List<pfClient>?> GetAllDeletedAsync(string? filtro)
        {
            var response = await client.GetAsync($"{_endpoint}?filtro={filtro}");
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }

            //Deserializamos los clientes
            var clients = JsonSerializer.Deserialize<List<pfClient>>(content, options);

            //Filtramos los clientes eliminados (IsDeleted = true)
            return clients?.Where(c => c.IsDeleted).ToList();
        }
    }
}
