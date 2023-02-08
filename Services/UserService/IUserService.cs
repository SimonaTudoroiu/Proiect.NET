using Project_Tudoroiu_Simona_251.Models.DTOs.User;

namespace Project_Tudoroiu_Simona_251.Services.UserService
{
    public interface IUserService
    {
        public Task<List<UserDTO>> GetAll();
        public UserDTO FindByUsername(string username);
    }
}
