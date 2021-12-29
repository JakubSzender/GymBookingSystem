using GymBookingSystem.Data.Models;
using System.Collections.Generic;

namespace GymBookingSystem.Logic.Interfaces.Service
{
    public interface IMachineService
    {
        List<Machine> GetMachines();
        Machine GetMachineById(int id);
        void SaveMachine(Machine Machine);
        void DeleteMachine(int id);
    }
}
