using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project_Tudoroiu_Simona_251.Models.DTOs.Order;
using Project_Tudoroiu_Simona_251.Services.OrderService;

namespace Project_Tudoroiu_Simona_251.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        public readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {
            return Ok(await _orderService.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> AddOrder(OrderDTO newOrder)
        {
            await this._orderService.AddOrder(newOrder);
            return Ok();
        }
        [HttpPut("{placingDate}")]
        public async Task<IActionResult> UpdateOrder([FromRoute] DateTime placingDate, [FromBody] OrderDTO newAddress)
        {
            await this._orderService.UpdateByPlacingDate(placingDate, newAddress);
            return Ok();
        }

        [HttpDelete("{placingDate}")]
        public async Task<IActionResult> DeleteAddressByPlacingDate([FromRoute] DateTime placingDate)
        {
            await this._orderService.DeleteOrderByPlacingDate(placingDate);
            return Ok();
        }
    }
}
