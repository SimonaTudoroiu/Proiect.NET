using System.ComponentModel.DataAnnotations;

namespace Project_Tudoroiu_Simona_251.Models.DTOs.User
{
    public class UserRequestDTO
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
    }
}
