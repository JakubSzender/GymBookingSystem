using GymBookingSystem.Data.Models;
using System.Collections.Generic;

namespace GymBookingSystem.Logic.Interfaces.Service
{
    public interface IReservationService
    {
        List<Reservation> GetReservations();
        Reservation GetReservationById(int id);
        void SaveReservation(Reservation reservation);
        void DeleteReservation(int id);
    }
}
