using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WRM.Models;

namespace WRM.Repositories
{
    public interface IStaffRepo
    {
        Task<object> GetStaffByEmail(string email);
        
        List<Staff> GetAllStaff();
        Staff logIn(LoginStaff loginStaff);
        List<Staff> StaffStatusAvailable();
        //Staff AddStaff(Staff staff);
        
        Staff StaffUpdate(string email, Staff staff);
        int AddStaff(Staff staff);
    }
}
