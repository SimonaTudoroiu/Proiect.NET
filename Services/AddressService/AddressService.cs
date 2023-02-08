using AutoMapper;
using Project_Tudoroiu_Simona_251.Models;
using Project_Tudoroiu_Simona_251.Models.DTOs.Address;
using Project_Tudoroiu_Simona_251.Repositories.AdressRepository;

namespace Project_Tudoroiu_Simona_251.Services.AddressService
{
    public class AddressService : IAddressService
    {
        public IAddressRepository _addressRepository;

        public IMapper _mapper;

        public AddressService(IAddressRepository addressRepository, IMapper mapper)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
        }

        public async Task AddAddress(AddressDTO newAddress)
        {
            var newDbAddress = _mapper.Map<Address>(newAddress);
            await _addressRepository.CreateAsync(newDbAddress);
            await _addressRepository.SaveAsync();
        }

        public async Task DeleteAddress(Guid addressID)
        {
            var addressToDelete = await _addressRepository.FindByIdAsync(addressID);
            _addressRepository.Delete(addressToDelete);
            await _addressRepository.SaveAsync();
        }

        public async Task<List<AddressDTO>> GetAll()
        {
            var addresses = await _addressRepository.GetAll();
            return _mapper.Map<List<AddressDTO>>(addresses);
        }
        public async Task<List<AddressWithUsersDTO>> GetAllWithUsers()
        {
            var addresses = await _addressRepository.GetAddressesWithUsers();
            return _mapper.Map<List<AddressWithUsersDTO>>(addresses);
        }
        public async Task<List<AddressWithOrdersDTO>> GetAllWithOrders()
        {
            var addresses = await _addressRepository.GetAddressesWithOrders();
            return _mapper.Map<List<AddressWithOrdersDTO>>(addresses);
        }
        public async Task UpdateByUsername(string username, AddressDTO address)
        {
            var addressToUpdate = _addressRepository.FindByUsername(username);
            addressToUpdate = _mapper.Map<Address>(address);
            _addressRepository.Update(addressToUpdate);
            await _addressRepository.SaveAsync();

        }
    }
}
