using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Project_Tudoroiu_Simona_251.Models;
using Project_Tudoroiu_Simona_251.Models.Enums;

namespace Project_Tudoroiu_Simona_251.Helpers.Attributes
{
    public class Authorization : Attribute, IAuthorizationFilter
    {
        private readonly ICollection<Role> _roles;

        public Authorization(params Role[] roles)
        {
            _roles = roles;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var unauthorizedStatusObject = new JsonResult(new { Message = "Unauthorizes" }){ StatusCode = StatusCodes.Status401Unauthorized};

            if(_roles == null)
            {
                context.Result = unauthorizedStatusObject;
            }
            

            var user = (User)context.HttpContext.Items["User"];
            if(user == null || !_roles.Contains(user.Role))
            {
                context.Result = unauthorizedStatusObject;
            }


        }
    }
}
