using GymBookingSystem.Data;
using GymBookingSystem.Data.Models;
using GymBookingSystem.Logic.Interfaces.Service;
using System.Collections.Generic;
using System.Linq;

namespace GymBookingSystem.Logic.Features.Service
{
    public class MachineService : IMachineService
    {
        private readonly ApplicationDbContext _dbContext;
        public MachineService(ApplicationDbContext context)
        {
            _dbContext = context;
        }



        public void DeleteMachine(int id)
        {
            var machine = _dbContext.Machine.FirstOrDefault(x => x.Id == id);
            if (machine != null)
            {
                _dbContext.Machine.Remove(machine);
                _dbContext.SaveChanges();
            }
        }
        public Machine GetMachineById(int id)
        {
            var machine = _dbContext.Machine.SingleOrDefault(x => x.Id == id);
            return machine;
        }
        public List<Machine> GetMachines()
        {
            return _dbContext.Machine.ToList();
        }
        public void SaveMachine(Machine machine)
        {
            if (machine.Id == 0) _dbContext.Machine.Add(machine);
            else _dbContext.Machine.Update(machine);
            _dbContext.SaveChanges();
        }
    }
}
