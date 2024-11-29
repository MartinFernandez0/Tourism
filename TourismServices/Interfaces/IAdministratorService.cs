using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismServices.Models;

namespace TourismServices.Interfaces
{
    public interface IAdministratorService : IGenericService<pfAdministrator>
    {
        public Task<List<pfAdministrator>?> GetAllAsync(string? filtro);
        public Task<List<pfAdministrator>?> GetAllDeletedAsync(string? filtro);

    }
}
