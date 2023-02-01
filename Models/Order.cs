using Project_Tudoroiu_Simona_251.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_Tudoroiu_Simona_251.Models
{
    public class Order : BaseEntity
    {
        public DateTime PlacingDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public ICollection<ProductInOrder>? ProductInOrders { get; set; }
        public User? User { get; set; }
        public Guid? UserId { get; set; }
        public Address? Address { get; set; }
        public Guid? AddressId { get; set; }
    }
}
