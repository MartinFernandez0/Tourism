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
    }
}
