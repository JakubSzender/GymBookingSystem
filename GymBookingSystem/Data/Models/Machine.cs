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


        List<Machine> machines = new()
        {
            new Machine { Name = "Machine1" },
            new Machine { Name = "Machine2" },
            new Machine { Name = "Machine3" },
            new Machine { Name = "Machine4" },
            new Machine { Name = "Machine5" }

        };
    }
}
