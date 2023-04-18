using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WRM.Models;
using WRM.Repositories;

namespace WRM.Services
{
    public class PassengerService : IPassengerService
    {
        readonly IPassengerRepo _passengerRepo;
        public PassengerService(IPassengerRepo passengerRepo)
        {
            _passengerRepo = passengerRepo;
        }
        public async Task<string> AddPassenger(Passenger passenger)
        {
            var passengerExists = await _passengerRepo.GetPassengerByPNR(passenger.PNRNo);
            if (passengerExists == null)
            {
                int a = _passengerRepo.AddPassenger(passenger);
                if (a == 1)
                {
                    return $"added successfully";
                }
                else
                {
                    return $"unsuccess";
                }
            }
            else
            {
                return $"unsuccess";
            }
        }

        public Passenger CheckByPNR(string PNRNo)
        {
            Passenger passenger=_passengerRepo.CheckByPNR(PNRNo);
            return passenger;
        }

        public List<Passenger> GetAllPassengers()
        {
            List<Passenger> passengers = _passengerRepo.GetAllPassengers();
            return passengers;
        }
    }
}

