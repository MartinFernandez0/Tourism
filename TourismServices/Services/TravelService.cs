using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TourismServices.Interfaces;
using TourismServices.Models;

namespace TourismServices.Services
{
    public class TravelService : GenericService<pfTravel>, ITravelService
    {
        public async Task<List<pfTravel>?> GetAllAsync(string? filtro)
        {
            var response = await client.GetAsync($"{_endpoint}?filtro={filtro}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<pfTravel>>(content, options); ;
        }

        public async Task<List<pfTravel>?> GetAllDeletedAsync(string? filtro)
        {
            var response = await client.GetAsync($"{_endpoint}?filtro={filtro}");
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }

            //Deserializamos los viajes
            var travels = JsonSerializer.Deserialize<List<pfTravel>>(content, options);

            //Filtramos los viajes eliminadas (IsDeleted = true)
            return travels?.Where(a => a.IsDeleted).ToList();
        }
    }
}
