using Microsoft.EntityFrameworkCore;
using Project_Tudoroiu_Simona_251.Data;
using Project_Tudoroiu_Simona_251.Models;
using Project_Tudoroiu_Simona_251.Repositories.GenericRepository;

namespace Project_Tudoroiu_Simona_251.Repositories.UserRepository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ProjectContext context) : base(context) { }
        public async Task<List<User>> GetUsersWithAddresses()
        {
            return await _table.Include(x => x.Address).ToListAsync();
        }
        public async Task<List<User>> GetUsersWithOrders()
        {
            return await _table.Include(x => x.Orders).ToListAsync();
        }
        public User FindByUsername(string username)
        {
            return _table.FirstOrDefault(x => x.UserName == username);
        }
        public string FindPhoneByUsername(string username)
        {
            return _table.FirstOrDefault(x => x.UserName == username).Phone;
        }
    }
}
