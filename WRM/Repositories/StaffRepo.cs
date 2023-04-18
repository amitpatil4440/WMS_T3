using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WRM.Context;
using WRM.ExceptionHandling;
using WRM.Models;

namespace WRM.Repositories
{
    public class StaffRepo : IStaffRepo
    {
        readonly WrmDbContext _wrmDbContext;
        public StaffRepo(WrmDbContext wrmDbContext)
        {
            _wrmDbContext = wrmDbContext;
        }

        public int AddStaff(Staff staff)
        {
            _wrmDbContext.StaffTbl.Add(staff);
            return _wrmDbContext.SaveChanges();
        }

        

        public List<Staff> GetAllStaff()
        {
            List<Staff> staff = _wrmDbContext.StaffTbl.ToList();
            return staff;
        }

        public async Task<object> GetStaffByEmail(string Email)
        {
            return await _wrmDbContext.StaffTbl.Where(s => s.Email == Email).FirstOrDefaultAsync();
        }

        public Staff logIn(LoginStaff loginStaff)
        {
            Staff login= _wrmDbContext.StaffTbl.Where(s => s.Email == loginStaff.Email || s.Password == loginStaff.Password).FirstOrDefault();
           // Staff login = _wrmDbContext.StaffTbl.Where(s => s.Email == loginStaff.Email).FirstOrDefault();
            if (login != null)
            {
                if (login.Email== loginStaff.Email)
                {
                    return login;
                }
                else
                {
                    throw new StaffEmailInvalidException($"Invalid email");
                }
            }
            else
            {
                throw new StaffInvalidException($"Invalid Credentials");
            }


        }

        public List<Staff> StaffStatusAvailable()
        {
            List<Staff> staff = _wrmDbContext.StaffTbl.Where(s => s.Availability == "Available").ToList();
            return staff;
        }

        public Staff StaffUpdate(string Email, Staff staff)
        {
            staff.Email = Email;
            _wrmDbContext.Entry(staff).State = EntityState.Modified;
            _wrmDbContext.SaveChanges();
            return staff;
           
        }
    }
}
