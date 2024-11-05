using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismServices.Models;

namespace TourismServices.Interfaces
{
    public interface IItineraryService : IGenericService<pfItinerary>
    {
        public Task<List<pfItinerary>?> GetAllAsync(string? filtro);
        public Task<List<pfItinerary>?> GetAllDeletedAsync(string? filtro);
    }


}
