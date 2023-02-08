namespace Project_Tudoroiu_Simona_251.Models.DTOs.User
{
    public class UserResponseDTO
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Token { get; set; }

        public UserResponseDTO(Models.User user, string token)
        {
            Id = user.Id;
            UserName = user.UserName;
            Email = user.Email;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Age = user.Age;
            Phone = user.Phone;
            Token = token;
        }
    }
}
