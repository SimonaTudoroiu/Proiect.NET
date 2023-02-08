using Project_Tudoroiu_Simona_251.Models;

namespace Project_Tudoroiu_Simona_251.Helpers.JwtToken
{
    public interface IJwtUtils
    {
        public string GenerateJwtToken(User user);
        public Guid ValidateJwtToken(string token);
    }
}
