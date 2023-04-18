using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WRM.Models;

namespace WRM.Services
{
    public interface IStaffService
    {
        
        List<Staff> GetAllStaff();
        Staff LogIn(LoginStaff loginStaff);
        List<Staff> StaffStatusAvailable();
        //Staff AddStaff(Staff staff);
        
        Staff StaffUpdate(string email, Staff staff);
        Task<string> AddStaff(Staff staff);
    }
}
