using Project_Tudoroiu_Simona_251.Models;
using Project_Tudoroiu_Simona_251.Repositories.GenericRepository;

namespace Project_Tudoroiu_Simona_251.Repositories.UserRepository
{
    public interface IUserRepository : IGenericRepository<User>
    {
        public Task<List<User>> GetUsersWithAddresses();
        public Task<List<User>> GetUsersWithOrders();
        public User FindByUsername(string username);
        public string FindPhoneByUsername(string username);
    }
}
