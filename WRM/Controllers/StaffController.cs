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
    [ExceptionHandler]
    [Route("api/[controller]")]
    [ApiController]
    [LogFilter]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;
        public StaffController(IStaffService staffService)
        {
            this._staffService = staffService;


        }
        [Route("AddStaff")]
        [HttpPost]
        public async Task<ActionResult> AddStaff(Staff staff)
        {
            var status = await _staffService.AddStaff(staff);
            return Ok(status);
        }



        [Route("GetAllStaff")]
        [HttpGet]
        public ActionResult GetAllStaff()
        {
            List<Staff> staff = _staffService.GetAllStaff();
            return Ok(staff);
        }
        [Route("login")]
        [HttpPost]
        public ActionResult LogIn(LoginStaff loginStaff)
        {
            Staff staff = _staffService.LogIn(loginStaff);

            return Ok(staff);

        }
        [Route("StaffStatusAvailable")]
        [HttpGet]
        public ActionResult StaffStatusAvailabale()
        {
            List<Staff> StaffStatusAvailable = _staffService.StaffStatusAvailable();
            return Ok(StaffStatusAvailable);
        }
        [Route("StaffUpdate")]
        [HttpPut]
        public ActionResult StaffUpdate(string Email,Staff staff)
        {
            Staff staff1 = _staffService.StaffUpdate(Email, staff);
            return Ok(staff1);
           
        }
    }
}
