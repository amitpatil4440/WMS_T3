using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WRM.Models;
using WRM.Services;

namespace WRM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengerController : ControllerBase
    {
        readonly IPassengerService _passengerService;
        public PassengerController(IPassengerService passengerService)
        {
            this._passengerService = passengerService;
        }
        [Route("AddPassenger")]
        [HttpPost]
        public async Task<ActionResult> AddPassenger(Passenger passenger)
        {
            var status = await _passengerService.AddPassenger(passenger);
            return Ok(status);
        }
        [Route("GetAllPassengers")]
        [HttpGet]
        public ActionResult GetAllPassengers()
        {
            List<Passenger> passenger = _passengerService.GetAllPassengers();
            return Ok(passenger);
        }
        [Route("CheckByPNR")]
        [HttpGet]
        public ActionResult CheckByPNR(string PNRNo)
        {
            Passenger passenger = _passengerService.CheckByPNR(PNRNo);
            return Ok(passenger);
            
        }

    }

        
    
}
