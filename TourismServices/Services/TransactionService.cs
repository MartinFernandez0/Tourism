using System.Text.Json;
using TourismServices.Interfaces;
using TourismServices.Models;

namespace TourismServices.Services
{
    public class TransactionService : GenericService<pfTransaction>, ITransactionService
    {
        public async Task<List<pfTransaction>?> GetAllAsync(string? filtro)
        {
            var response = await client.GetAsync($"{_endpoint}?filtro={filtro}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<pfTransaction>>(content, options); ;
        }
        public async Task<List<pfTransaction>?> GetAllDeletedAsync(string? filtro)
        {
            var response = await client.GetAsync($"{_endpoint}?filtro={filtro}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            //Deserializamos las actividades
            var transactions = JsonSerializer.Deserialize<List<pfTransaction>>(content, options);
            //Filtramos las actividades eliminadas (IsDeleted = true)
            return transactions?.Where(a => a.IsDeleted).ToList();
        }
    }
}
