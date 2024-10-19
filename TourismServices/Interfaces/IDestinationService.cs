using TourismServices.Models;

namespace TourismServices.Interfaces
{
    public interface IDestinationService : IGenericService<pfDestination>
    {
        public Task<List<pfDestination>> GetAllAsync(string? filtro);
    }
}
