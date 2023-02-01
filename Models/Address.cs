using Project_Tudoroiu_Simona_251.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_Tudoroiu_Simona_251.Models
{
    public class Address : BaseEntity
    {
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public ICollection<Order>? Orders { get; set; }
        public User? User { get; set; }
        public Guid? UserId { get; set; }
    }
}
