using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WRM.Models;
using WRM.Services;
using WRM.SRP;

namespace WRM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ExceptionHandler]
    [LogFilter]
    public class SupervisorController : ControllerBase
    {
        readonly ISupervisorService _supervisorService;
        public SupervisorController(ISupervisorService supervisorService)
        {
            this._supervisorService = supervisorService;

        }
        
        [Route("GetAllSupervisors")]
        [HttpGet]
        public ActionResult GetAllSupervisors()
        {
            List<Supervisor> supervisors = _supervisorService.GetAllSupervisors();
            return Ok(supervisors);
         }
        [Route("login")]
        [HttpPost]
        public ActionResult LogIn(LoginSupervisor loginSupervisor)
        {
            Supervisor supervisor =  _supervisorService.LogIn(loginSupervisor);
            
            return Ok(supervisor);

        }

        [Route("AddSupervisor")]
        [HttpPost]
        public async Task<ActionResult> AddSupervisor(Supervisor supervisor)
        {
            var status = await _supervisorService.AddSupervisor(supervisor);
            return Ok(status);
        }
    }
}
