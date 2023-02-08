using Project_Tudoroiu_Simona_251.Models.Base;
using Project_Tudoroiu_Simona_251.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Project_Tudoroiu_Simona_251.Models
{
    public class User : BaseEntity
    {
        
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; }
        [JsonIgnore]
        public string PasswordHash { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public Role Role { get; set; }
        public ICollection<Order>? Orders { get; set; }
        public Address? Address { get; set; }
        public Guid? AddressId { get; set; }

    }
}
