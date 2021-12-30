using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GymBookingSystem.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
