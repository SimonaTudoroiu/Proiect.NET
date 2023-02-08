using AutoMapper;
using Project_Tudoroiu_Simona_251.Helpers.JwtToken;
using Project_Tudoroiu_Simona_251.Models;
using Project_Tudoroiu_Simona_251.Models.DTOs.User;
using Project_Tudoroiu_Simona_251.Repositories.UserRepository;
using BCryptNet = BCrypt.Net.BCrypt;

namespace Project_Tudoroiu_Simona_251.Services.UserService
{
    public class UserService : IUserService
    {
        public IUserRepository _userRepository;
        public IJwtUtils _jwtUtils;

        public IMapper _mapper;

        public UserService(IUserRepository userRepository, IJwtUtils jwtUtils, IMapper mapper)
        {
            _userRepository = userRepository;
            _jwtUtils= jwtUtils;
            _mapper = mapper;
        }

        public UserDTO FindByUsername(string username)
        {
            var user = _userRepository.FindByUsername(username);
            return _mapper.Map<UserDTO>(user);
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _userRepository.GetAll();
            
        }

       
        //autentificare
        public UserResponseDTO Authentificate(UserRequestDTO model)
        {
            var user = _userRepository.FindByUsername(model.UserName);
            if (user == null || !BCryptNet.Verify(model.Password, user.PasswordHash))
            {
                return null;
            }

            var jwtToken = _jwtUtils.GenerateJwtToken(user);
            return new UserResponseDTO(user, jwtToken);
        }

        public async Task Create(User newUser)
        {
            await _userRepository.CreateAsync(newUser);
            await _userRepository.SaveAsync();
        }

        public User GetById(Guid id)
        {
            return _userRepository.FindById(id);
        }
    }
}
