using System.Text.Json;
using TourismServices.Interfaces;
using TourismServices.Models;

namespace TourismServices.Services
{
    public class ActivityService : GenericService<pfActivity>, IActivityService
    {
        public async Task<List<pfActivity>?> GetAllAsync(string? filtro)
        {
            var response = await client.GetAsync($"{_endpoint}?filtro={filtro}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<pfActivity>>(content, options); ;
        }

        public async Task<List<pfActivity>?> GetAllDeletedAsync(string? filtro)
        {
            var response = await client.GetAsync($"{_endpoint}?filtro={filtro}");
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }

            //Deserializamos las actividades
            var activities = JsonSerializer.Deserialize<List<pfActivity>>(content, options);

            //Filtramos las actividades eliminadas (IsDeleted = true)
            return activities?.Where(a => a.IsDeleted).ToList();
        }
    }
}
