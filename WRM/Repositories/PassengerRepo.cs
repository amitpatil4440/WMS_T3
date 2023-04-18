using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WRM.Context;
using WRM.Models;

namespace WRM.Repositories
{
    public class PassengerRepo : IPassengerRepo
    {
        readonly WrmDbContext _wrmDbContext;
        public PassengerRepo(WrmDbContext wrmDbContext)
        {
            _wrmDbContext = wrmDbContext;
        }
        public int AddPassenger(Passenger passenger)
        {
            _wrmDbContext.PassengerTbl.Add(passenger);
            return _wrmDbContext.SaveChanges();
        }

        public Passenger CheckByPNR(string PNRNo)
        {
            return _wrmDbContext.PassengerTbl.Where(P => P.PNRNo == PNRNo).FirstOrDefault();
        }

        public List<Passenger> GetAllPassengers()
        {
            List<Passenger> passenger = _wrmDbContext.PassengerTbl.ToList();
            return passenger;
        }

        public async Task<Passenger> GetPassengerByPNR(string PNRNo)
        {
            return await _wrmDbContext.PassengerTbl.Where(p => p.PNRNo == PNRNo).FirstOrDefaultAsync();
        }
    }
}
