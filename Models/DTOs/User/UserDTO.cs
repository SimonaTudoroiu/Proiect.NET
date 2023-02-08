namespace Project_Tudoroiu_Simona_251.Models.DTOs.User
{
    public class UserDTO
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; }
        public int Age { get; set; }
        public int Birthday { get; set; }
        public string Phone { get; set; }
    }
}
