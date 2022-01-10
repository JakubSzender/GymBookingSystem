using GymBookingSystem.Data.Models;
using System.Collections.Generic;

namespace GymBookingSystem.Logic.Interfaces.Service
{
    public interface IUserService
    {
        string GetUserId();
        List<ApplicationUser> GetUsers();
        ApplicationUser GetUserById(string id);
        void SaveUser(ApplicationUser User);
        void DeleteUser(string id);
    }
}
