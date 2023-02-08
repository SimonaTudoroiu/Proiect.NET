using Project_Tudoroiu_Simona_251.Models;
using Project_Tudoroiu_Simona_251.Models.DTOs.User;

namespace Project_Tudoroiu_Simona_251.Services.UserService
{
    public interface IUserService
    {
        public Task<List<User>> GetAllUsers();
        public UserDTO FindByUsername(string username);
        //autentificare
        UserResponseDTO Authentificate(UserRequestDTO model);
        User GetById(Guid id);
        Task Create(User newUser);
    }
}
