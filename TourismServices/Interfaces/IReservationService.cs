using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismServices.Models;

namespace TourismServices.Interfaces
{
    public interface IReservationService : IGenericService<pfReservation>
    {
        public Task<List<pfReservation>?> GetAllAsync(string? filtro);
        public Task<List<pfReservation>?> GetAllDeletedAsync(string? filtro);
    }
}
