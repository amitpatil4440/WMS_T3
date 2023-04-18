using System.Collections.Generic;
using System.Threading.Tasks;
using WRM.Models;
using WRM.Repositories;

namespace WRM.Services
{
    public class StaffService:IStaffService
    {
        readonly IStaffRepo _staffRepo;
        public StaffService(IStaffRepo staffRepo)
        {
            _staffRepo = staffRepo;

        }

        public async Task<string> AddStaff(Staff staff)
        {
            var staffExists = await _staffRepo.GetStaffByEmail(staff.Email);
            if (staffExists == null)
            {
                int a = _staffRepo.AddStaff(staff);
                if (a == 1)
                {
                    return $"added successfully";
                }
                else
                {
                    return $"unsuccessful";
                }
            }
            else
            {
                return $"unsuccess";
            }
        }

        

        public List<Staff> GetAllStaff()
        {
            List<Staff> staff = _staffRepo.GetAllStaff();
            return staff;
        }

        public Staff LogIn(LoginStaff loginStaff)
        {
            Staff staff = _staffRepo.logIn(loginStaff);
            return staff;
             
                //if (staff != null)
                //{
                //    return staff;
                //}
                //else throw new StaffEmailInvalidException($"UserEmail/Password are invalid");
            
            
        }

        public List<Staff> StaffStatusAvailable()
        {
            List<Staff> staff = _staffRepo.StaffStatusAvailable();
            return staff;
        }

        public Staff StaffUpdate(string Email, Staff staff)
        {
            Staff staff1 = _staffRepo.StaffUpdate(Email, staff);
            return staff1;
        }
    }
}
