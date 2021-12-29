using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GymBookingSystem.Data.Models
{
    public class Machine
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }


       
    }
}
