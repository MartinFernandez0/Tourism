using System.Text.Json;
using TourismServices.Interfaces;
using TourismServices.Models;

namespace TourismServices.Services
{
    public class DestinationService : GenericService<pfDestination>, IDestinationService
    {
        public async Task<List<pfDestination>?> GetAllAsync(string? filtro)
        {
            var response = await client.GetAsync($"{_endpoint}?filtro={filtro}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<pfDestination>>(content, options);
        }

        public async Task<List<pfDestination>?> GetAllDeletedAsync(string? filtro)
        {
            return await GetAllDeletedAsync();
        }
    }
}
