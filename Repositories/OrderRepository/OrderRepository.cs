using Microsoft.EntityFrameworkCore;
using Project_Tudoroiu_Simona_251.Data;
using Project_Tudoroiu_Simona_251.Models;
using Project_Tudoroiu_Simona_251.Repositories.GenericRepository;

namespace Project_Tudoroiu_Simona_251.Repositories.OrderRepository
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(ProjectContext context) : base(context) { }  

        public async Task<List<Order>> GetOrdersWithUsers()
        {
            return await _table.Include(x => x.User).ToListAsync();
        }
        public async Task<List<Order>> GetOrdersWithAddresses()
        {
            return await _table.Include(x => x.Address).ToListAsync();
        }
        public Order FindByPlacingDate(DateTime placingDate)
        {
            return _table.FirstOrDefault(x => x.PlacingDate == placingDate);
        }
        public async Task<List<Order>> GetOrdersWithProducts()
        {
            return await _table.Include(x => x.ProductInOrders).ThenInclude(x => x.Product).ToListAsync();
        }
    }
}
