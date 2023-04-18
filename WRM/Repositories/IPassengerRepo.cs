using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WRM.Models;

namespace WRM.Repositories
{
    public interface IPassengerRepo
    {
        Task<Passenger> GetPassengerByPNR(string PNRNo);
        int AddPassenger(Passenger passenger);
        List<Passenger> GetAllPassengers();
        Passenger CheckByPNR(string pNRNo);
    }
}
