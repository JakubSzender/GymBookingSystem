using GymBookingSystem.Data.Models;
using System.Collections.Generic;

namespace GymBookingSystem.Logic.Interfaces.Service
{
    public interface IReservationService
    {
        List<Reservation> GetReservations();
        List<Reservation> GetReservationsForCurrentUser(string userId);
        Reservation GetReservationById(int id);
        void SaveReservation(Reservation reservation);
        void DeleteReservation(int id);
    }
}
