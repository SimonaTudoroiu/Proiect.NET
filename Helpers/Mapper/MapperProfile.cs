using AutoMapper;
using Project_Tudoroiu_Simona_251.Models;
using Project_Tudoroiu_Simona_251.Models.DTOs.Address;
using Project_Tudoroiu_Simona_251.Models.DTOs.Order;

namespace Project_Tudoroiu_Simona_251.Helpers.Mapper
{
    public class MapperProfile :Profile
    {
        public  MapperProfile()
        {
            CreateMap<AddressDTO, Address>().ReverseMap();

            CreateMap<OrderDTO, Order>().ReverseMap();

        }
    }
}
