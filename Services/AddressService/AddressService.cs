using AutoMapper;
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

        public Task AddAddress(AddressDTO newAddress)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAddress(Guid addressID)
        {
            throw new NotImplementedException();
        }

        public Task<List<AddressDTO>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
