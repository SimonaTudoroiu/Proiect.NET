using Microsoft.EntityFrameworkCore;
using Project_Tudoroiu_Simona_251.Data;
using Project_Tudoroiu_Simona_251.Models;
using Project_Tudoroiu_Simona_251.Repositories.GenericRepository;

namespace Project_Tudoroiu_Simona_251.Repositories.AdressRepository
{
    public class AddressRepository : GenericRepository<Address>, IAddressRepository 
    {
        public AddressRepository(ProjectContext context) : base(context) { }
        public async Task<List<Address>> GetAddressesWithUsers()
        {
            return await _table.Include(x => x.User).ToListAsync();
        }
        public async Task<List<Address>> GetAddressesWithOrders()
        {
            return await _table.Include(x => x.Orders).ToListAsync();   
        }
        public Address FindByCity(string city)
        {
            return _table.FirstOrDefault(x => x.City == city);
        }
    }
}
