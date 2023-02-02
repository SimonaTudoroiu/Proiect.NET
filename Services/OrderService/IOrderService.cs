using Project_Tudoroiu_Simona_251.Models.DTOs.Order;

namespace Project_Tudoroiu_Simona_251.Services.OrderService
{
    public interface IOrderService
    {
        public Task<List<OrderDTO>> GetAll();
        public Task AddOrder(OrderDTO orderDTO);
        public Task DeleteOrderByPlacingDate(DateTime placingDate);
        public Task<List<OrderWithProductsDTO>> GetAllWithProducts();
    }
}
