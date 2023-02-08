using AutoMapper;
using Project_Tudoroiu_Simona_251.Models;
using Project_Tudoroiu_Simona_251.Models.DTOs.Order;
using Project_Tudoroiu_Simona_251.Repositories.OrderRepository;

namespace Project_Tudoroiu_Simona_251.Services.OrderService
{
    public class OrderService : IOrderService
    {
        public IOrderRepository _orderRepository;
        public IMapper _mapper;

        public OrderService(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }
        
        public async Task AddOrder(OrderDTO newOrder)
        {
            var newDbOrder = _mapper.Map<Models.Order>(newOrder);
            await _orderRepository.CreateAsync(newDbOrder);
            await _orderRepository.SaveAsync();
        }

        public async Task DeleteOrderByPlacingDate(DateTime placingDate)
        {
            var orderToDelete = _orderRepository.FindByPlacingDate(placingDate);
            _orderRepository.Delete(orderToDelete);
            await _orderRepository.SaveAsync();
        }

        public async Task<List<OrderDTO>> GetAll()
        {
            var orders = await _orderRepository.GetAll();
            return _mapper.Map<List<OrderDTO>>(orders);
        }

        public async Task<List<OrderWithProductsDTO>> GetAllWithProducts()
        {
            var orders = await _orderRepository.GetOrdersWithProducts();
            return _mapper.Map<List<OrderWithProductsDTO>>(orders);
        }

        public async Task UpdateByPlacingDate(DateTime placingDate, OrderDTO order)
        {
            var orderToUpdate = _orderRepository.FindByPlacingDate(placingDate);
            orderToUpdate = _mapper.Map<Order>(order);
            _orderRepository.Update(orderToUpdate);
            await _orderRepository.SaveAsync();
        }
    }
}
