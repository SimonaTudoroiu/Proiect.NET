namespace Project_Tudoroiu_Simona_251.Models.DTOs.Address
{
    public class AddressWithOrdersDTO
    {
        Guid Id { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public ICollection<Models.Order>? Orders { get; set; }
    }
}
