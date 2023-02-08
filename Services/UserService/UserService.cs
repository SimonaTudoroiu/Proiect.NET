using AutoMapper;
using Project_Tudoroiu_Simona_251.Models.DTOs.User;
using Project_Tudoroiu_Simona_251.Repositories.UserRepository;

namespace Project_Tudoroiu_Simona_251.Services.UserService
{
    public class UserService : IUserService
    {
        public IUserRepository _userRepository;

        public IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public UserDTO FindByUsername(string username)
        {
            var user = _userRepository.FindByUsername(username);
            return _mapper.Map<UserDTO>(user);
        }

        public async Task<List<UserDTO>> GetAll()
        {
            var users = _userRepository.GetAll();
            return _mapper.Map<List<UserDTO>>(users);
        }
    }
}
