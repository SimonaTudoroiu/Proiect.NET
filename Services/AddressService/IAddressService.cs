using Project_Tudoroiu_Simona_251.Models;
using Project_Tudoroiu_Simona_251.Models.DTOs.Address;

namespace Project_Tudoroiu_Simona_251.Services.AddressService
{
    public interface IAddressService
    {
        public Task<List<AddressDTO>> GetAll();
        public Task AddAddress(AddressDTO newAddress);
        public Task DeleteAddress(Guid addressID);
        public Task<List<AddressWithUsersDTO>> GetAllWithUsers();
        public Task<List<AddressWithOrdersDTO>> GetAllWithOrders();
        public Task UpdateByUsername(string username, AddressDTO address);
    }
}
