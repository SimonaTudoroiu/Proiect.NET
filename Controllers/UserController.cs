using BCrypt.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project_Tudoroiu_Simona_251.Helpers.Attributes;
using Project_Tudoroiu_Simona_251.Models;
using Project_Tudoroiu_Simona_251.Models.DTOs.User;
using Project_Tudoroiu_Simona_251.Models.Enums;
using Project_Tudoroiu_Simona_251.Services.UserService;
using BCryptNet = BCrypt.Net.BCrypt;

namespace Project_Tudoroiu_Simona_251.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("create-user")]
        public async Task<IActionResult> CreateUser(UserRequestDTO user)
        {
            var userToCreate = new User
            {
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Age = user.Age,
                Phone = user.Phone,
                Role = Role.User,
                PasswordHash = BCryptNet.HashPassword(user.Password)
            };

            await _userService.Create(userToCreate);
            return Ok();
        }
        [HttpPost("create-admin")]
        public async Task<IActionResult> CreateAdmin(UserRequestDTO user)
        {
            var userToCreate = new User
            {
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Age = user.Age,
                Phone = user.Phone,
                Role = Role.Admin,
                PasswordHash = BCryptNet.HashPassword(user.Password)
            };

            await _userService.Create(userToCreate);
            return Ok();
        }
        [HttpPost("authentificate")]
        public async Task<IActionResult> Authentificate(UserRequestDTO user)
        {
            var response = _userService.Authentificate(user);
            if (response == null)
            {
                return BadRequest("Username or password is invalid!");
            }
            return Ok();
        }
        [Authorization(Role.Admin)]
        [HttpGet("admin")]
        public async Task<IActionResult> GetAllAdmin()
        {
            var users = _userService.GetAllUsers();
            return Ok(users);
        }
        [Authorization(Role.User)]
        [HttpGet("user")]
        public IActionResult GetAllUser()
        {
            return Ok("User");
        }
    }
}
