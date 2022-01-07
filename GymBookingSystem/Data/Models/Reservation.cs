
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymBookingSystem.Data.Models
{
    public class Reservation 
    {
        
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int Id { get; set; }
        public DateTime? ReservationDate { get; set; }
        public TimeSpan? StartHour { get; set; }
        public TimeSpan? EndHour { get; set; }

        public string UserId{ get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        public int MachineId { get; set; }
        public virtual Machine Machine { get; set; }
    }
}
