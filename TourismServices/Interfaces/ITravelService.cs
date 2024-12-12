using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismServices.Models;

namespace TourismServices.Interfaces
{
    public interface ITravelService : IGenericService<pfTravel>
    {
        public Task<List<pfTravel>> GetAllAsync(string? filtro);
        public Task<List<pfTravel>?> GetAllDeletedAsync(string? filtro);

    }
}
