﻿using GymBookingSystem.Data;
using GymBookingSystem.Data.Models;
using GymBookingSystem.Logic.Interfaces.Service;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymBookingSystem.Logic.Features.Service
{
    public class ReservationService : IReservationService
    {
        private readonly ApplicationDbContext _dbContext;

        public ReservationService(ApplicationDbContext context)
        {
            _dbContext = context;
        }
        public void DeleteReservation(int id)
        {
            var reservation = _dbContext.Reservations.FirstOrDefault(x => x.Id == id);
            if (reservation != null)
            {
                _dbContext.Reservations.Remove(reservation);
                _dbContext.SaveChanges();
            }
        }
        public Reservation GetReservationById(int id)
        {
            var reservation = _dbContext.Reservations.SingleOrDefault(x => x.Id == id);
            return reservation;
        }
        public List<Reservation> GetReservations()
        {
            return _dbContext.Reservations.ToList();
        }

        public List<Reservation> GetReservationsForCurrentUser(string userId)
        {
            var reservations = _dbContext.Reservations.Where(x => x.UserId == userId);
            return reservations.ToList();
            

        }

        public void SaveReservation(Reservation reservation)
        {
            if (reservation.Id == 0) _dbContext.Reservations.Add(reservation);
            else _dbContext.Reservations.Update(reservation);
            
            _dbContext.SaveChanges();

        }
    }
}
