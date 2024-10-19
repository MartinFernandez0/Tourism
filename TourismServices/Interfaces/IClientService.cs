using TourismServices.Models;

namespace TourismServices.Interfaces
{
    public interface IClientService : IGenericService<pfClient>
    {
        public Task<List<pfClient>> GetAllAsync(string? filtro);
    }
}
