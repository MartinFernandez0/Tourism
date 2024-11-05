using Microsoft.Extensions.Options;
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
            return await GetAllDeletedAsync();
        }
    }
}
