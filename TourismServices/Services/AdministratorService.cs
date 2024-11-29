using System.Text.Json;
using TourismServices.Interfaces;
using TourismServices.Models;

namespace TourismServices.Services
{
    public class AdministratorService : GenericService<pfAdministrator>, IAdministratorService
    {
        public async Task<List<pfAdministrator>?> GetAllAsync(string? filtro)
        {
            var response = await client.GetAsync($"{_endpoint}?filtro={filtro}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<pfAdministrator>>(content, options); ;
        }

        public async Task<List<pfAdministrator>?> GetAllDeletedAsync(string? filtro)
        {
            var response = await client.GetAsync($"{_endpoint}?filtro={filtro}");
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }

            //Deserializamos las actividades
            var administrators = JsonSerializer.Deserialize<List<pfAdministrator>>(content, options);

            //Filtramos las actividades eliminadas (IsDeleted = true)
            return administrators?.Where(a => a.IsDeleted).ToList();
        }
    }
}
