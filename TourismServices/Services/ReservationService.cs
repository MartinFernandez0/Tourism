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
    public class ReservationService : GenericService<pfReservation>, IReservationService
    {
        public async Task<List<pfReservation>?> GetAllAsync(string? filtro)
        {
            var response = await client.GetAsync($"{_endpoint}?filtro={filtro}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<pfReservation>>(content, options); ;
        }
        public async Task<List<pfReservation>?> GetAllDeletedAsync(string? filtro)
        {
            var response = await client.GetAsync($"{_endpoint}?filtro={filtro}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            //Deserializamos las actividades
            var reservations = JsonSerializer.Deserialize<List<pfReservation>>(content, options);
            //Filtramos las actividades eliminadas (IsDeleted = true)
            return reservations?.Where(a => a.IsDeleted).ToList();
        }
    }
}