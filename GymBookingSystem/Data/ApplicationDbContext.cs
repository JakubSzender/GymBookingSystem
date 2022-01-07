using GymBookingSystem.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymBookingSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }

        public DbSet<Machine> Machine { get; set; }

        public DbSet<Reservation> Reservations { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //machine data seeding
            modelBuilder.Entity<Machine>().HasData(
                new Machine { Id =1 ,Name = "Machine1"  },
                new Machine { Id =2 ,Name = "Machine2"  },
                new Machine { Id =3 ,Name = "Machine3"  },
                new Machine { Id =4 ,Name = "Machine4"  },
                new Machine { Id =5 ,Name = "Machine5"  },
                new Machine { Id =6 ,Name = "Machine6"  }
                                                        );

            //Reservation -> User
            modelBuilder.Entity<Reservation>()
             .HasOne(pt => pt.ApplicationUser)
             .WithMany(p => p.Reservations)
             .HasForeignKey(pt => pt.UserId);

            //Reservation -> Machine
            modelBuilder.Entity<Reservation>()
              .HasOne(pt => pt.Machine)
              .WithMany(t => t.Reservations)
              .HasForeignKey(pt => pt.MachineId);
        }
    }
}
