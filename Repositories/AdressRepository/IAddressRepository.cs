using Project_Tudoroiu_Simona_251.Models;
using Project_Tudoroiu_Simona_251.Repositories.GenericRepository;

namespace Project_Tudoroiu_Simona_251.Repositories.AdressRepository
{
    public interface IAddressRepository : IGenericRepository<Address>
    {
        public Task<List<Address>> GetAddressesWithUsers();
        public Task<List<Address>> GetAddressesWithOrders();
        public Address FindByCity(string city);
    }
}
