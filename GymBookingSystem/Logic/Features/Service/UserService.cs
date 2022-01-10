using GymBookingSystem.Data;
using GymBookingSystem.Data.Models;
using GymBookingSystem.Logic.Interfaces.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;

namespace GymBookingSystem.Logic.Features.Service
{
    public class UserService : IUserService

    {
        private readonly IHttpContextAccessor _httpContext;
        private readonly ApplicationDbContext _dbContext;


        public UserService(IHttpContextAccessor httpContext, ApplicationDbContext dbContext)
        {
            _httpContext = httpContext;
            _dbContext = dbContext;
        }


        public string GetUserId()
        {
            return _httpContext.HttpContext.User?.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        public List<ApplicationUser> GetUsers()
        {
            return _dbContext.ApplicationUser.ToList();

        }

        public ApplicationUser GetUserById(string id)
        {
            var user = _dbContext.Users.SingleOrDefault(x => x.Id == id);
            return (ApplicationUser)user;
        }
        public void DeleteUser(string id)
        {
            var user = _dbContext.Users.FirstOrDefault(x => x.Id == id);
            if (user != null)
            {
                _dbContext.Users.Remove(user);
                _dbContext.SaveChanges();
            }
        }
        
       
        public void SaveUser(ApplicationUser user)
        {
            if (user.Id == "") _dbContext.Users.Add(user);
            else _dbContext.Users.Update(user);
            _dbContext.SaveChanges();
        }



    }


}

