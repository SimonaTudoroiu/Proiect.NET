using Microsoft.AspNetCore.Mvc.Infrastructure;
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
            var result = _table.Join(_context.Users, a => a.UserId, u => u.Id, (a, u) => new { a, u }).Select(obj => obj.a);
            return result.ToList();
        }
        public async Task<List<Address>> GetAddressesWithOrders()
        {
            return await _table.Include(x => x.Orders).ToListAsync();   
        }
        public Address FindByCity(string city)
        {
            return _table.FirstOrDefault(x => x.City == city);
        }
        public Address FindByUsername(string username)
        {
            var result = _table.Where(x => x.User.UserName == username);
            return result.FirstOrDefault();
        }
    }
}
