using Azure.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project_Tudoroiu_Simona_251.Models.DTOs.Address;
using Project_Tudoroiu_Simona_251.Services.AddressService;

namespace Project_Tudoroiu_Simona_251.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        public readonly IAddressService _addressService;
        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAddresses()
        {
            return Ok(await _addressService.GetAll());
        }
        [HttpGet("withUsers")]
        public async Task<IActionResult> GetAllAddressesWithUsers()
        {
            return Ok(await _addressService.GetAllWithUsers());
        }
        [HttpGet("withOrders")]
        public async Task<IActionResult> GetAllAddressesWithOrders()
        {
            return Ok(await _addressService.GetAllWithOrders());
        }
        [HttpPost]
        public async Task<IActionResult> AddAddress(AddressDTO newAddress)
        {
            await this._addressService.AddAddress(newAddress);
            return Ok();
        }

        [HttpPut("{username}")]
        public async Task<IActionResult> UpdateAddress([FromRoute] string username, [FromBody] AddressDTO newAddress)
        {
            await this._addressService.UpdateByUsername(username, newAddress);
            return Ok();
        }
        [HttpDelete("{addressId}")]
        public async Task<IActionResult> DeleteAddress([FromRoute] Guid addressId)
        {
            await this._addressService.DeleteAddress(addressId);
            return Ok();
        }
    }
}
