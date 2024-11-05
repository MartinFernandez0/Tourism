using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismServices.Models;

namespace TourismServices.Interfaces
{
    public interface IActivityService : IGenericService<pfActivity>
    {
        public Task<List<pfActivity>?> GetAllAsync(string? filtro);
        public Task<List<pfActivity>?> GetAllDeletedAsync(string? filtro);

    }
}
