using GymBookingSystem.Data;
using GymBookingSystem.Data.Models;
using GymBookingSystem.Logic.Interfaces.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Security.Principal;

namespace GymBookingSystem.Logic.Features.Service
{
    public class UserService : IUserService

    {
        private readonly IHttpContextAccessor _httpContext;

        public UserService(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }

        public string GetUserId()
        {
            return _httpContext.HttpContext.User?.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
