using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WRM.Models;

namespace WRM.Services
{
    public interface IPassengerService
    {
        Task <string>AddPassenger(Passenger passenger);
        List<Passenger> GetAllPassengers();
        Passenger CheckByPNR(string PNRNo);
    }
}
