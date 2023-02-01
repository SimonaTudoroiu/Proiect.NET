using Project_Tudoroiu_Simona_251.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_Tudoroiu_Simona_251.Models
{
    public class User : BaseEntity
    {
        
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; }   
        public string Password { get; set; }
        public int Age { get; set; }
        public int Birthday { get; set;}
        public string Phone { get; set; }
        public ICollection<Order>? Orders { get; set; }
        public Address? Address { get; set; }
        public Guid? AddressId { get; set; }

    }
}
