using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismServices.Models;

namespace TourismServices.Interfaces
{
    public interface ITransactionService : IGenericService<pfTransaction>
    {
        public Task<List<pfTransaction>?> GetAllAsync(string? filtro);
        public Task<List<pfTransaction>?> GetAllDeletedAsync(string? filtro);
    }
}
