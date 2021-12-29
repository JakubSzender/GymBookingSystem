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

            modelBuilder.Entity<Reservation>()
            .HasKey(t => new { t.Id, t.UserId, t.MachineId });

            modelBuilder.Entity<Reservation>()
           .HasOne(pt => pt.ApplicationUser)
           .WithMany(p => p.Reservations)
           .HasForeignKey(pt => pt.UserId);

            modelBuilder.Entity<Reservation>()
                .HasOne(pt => pt.Machine)
                .WithMany(t => t.Reservations)
                .HasForeignKey(pt => pt.MachineId);
        }
    }
}
