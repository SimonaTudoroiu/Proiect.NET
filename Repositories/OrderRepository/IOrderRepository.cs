using Project_Tudoroiu_Simona_251.Models;
using Project_Tudoroiu_Simona_251.Repositories.GenericRepository;

namespace Project_Tudoroiu_Simona_251.Repositories.OrderRepository
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        public Task<List<Order>> GetOrdersWithUsers();
        public Task<List<Order>> GetOrdersWithAddresses();
        Order FindByPlacingDate(DateTime placingDate);
        public Task<List<Order>> GetOrdersWithProducts();
    }
}
