using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GymBookingSystem.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Key]
        override public string Id { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
