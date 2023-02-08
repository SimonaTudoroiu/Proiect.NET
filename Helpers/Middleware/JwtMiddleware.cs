using Project_Tudoroiu_Simona_251.Helpers.JwtToken;
using Project_Tudoroiu_Simona_251.Services.UserService;
using System.Runtime.CompilerServices;

namespace Project_Tudoroiu_Simona_251.Helpers.Middleware
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _nextRequestDelegate;

        public JwtMiddleware(RequestDelegate requestDelegate)
        {
            _nextRequestDelegate = requestDelegate;
        }

        public async Task Invoke(HttpContext httpContext, IUserService userService, IJwtUtils jwtUtils)
        {
            var token = httpContext.Request.Headers["Authorization"].FirstOrDefault()?.Split("").Last();
            var userId = jwtUtils.ValidateJwtToken(token);
            if(userId != Guid.Empty)
            {
                httpContext.Items["User"] = userService.GetById(userId);
            }

            await _nextRequestDelegate(httpContext);
        }

        
    }
}
