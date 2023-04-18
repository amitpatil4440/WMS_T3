using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WRM.Context;
using WRM.ExceptionHandling;
using WRM.Models;

namespace WRM.Repositories
{
    public class SupervisorRepo : ISupervisorRepo
    {
        readonly WrmDbContext _wrmDbContext;
        public SupervisorRepo(WrmDbContext wrmDbContext)
        {
            _wrmDbContext = wrmDbContext;

        }

        public int AddSupervisor(Supervisor supervisor)
        {
            _wrmDbContext.SupervisorTbl.Add(supervisor);
            return _wrmDbContext.SaveChanges();
        }

        //public Supervisor AddSupervisor(Supervisor supervisor)
        //{
        //    _wrmDbContext.SupervisorTbl.Add(supervisor);
        //    _wrmDbContext.SaveChanges();
        //    return supervisor;
        //}



        public List<Supervisor> GetAllSupervisors()
        {
            List<Supervisor> supervisors = _wrmDbContext.SupervisorTbl.ToList();
            return supervisors;
        }

        public async Task<Supervisor> GetSupervisorByEmail(string email)
        {
            return await _wrmDbContext.SupervisorTbl.Where(s => s.Email == email).FirstOrDefaultAsync();
        }

        //public object GetSupervisorByEmail(string Email)
        //{
        //    return _wrmDbContext.SupervisorTbl.Where(s => s.Email == Email).FirstOrDefault();
        //}

        public Supervisor logIn(LoginSupervisor loginSupervisor)
        {
            //return _wrmDbContext.SupervisorTbl.Where(s => s.Email == loginSupervisor.Email && s.Password == loginSupervisor.Password).FirstOrDefault();

            Supervisor login = _wrmDbContext.SupervisorTbl.Where(s => s.Email == loginSupervisor.Email || s.Password == loginSupervisor.Password).FirstOrDefault();
            
            if (login != null)
            {
                if (login.Email == loginSupervisor.Email)
                {
                    return login;
                }
                else
                {
                    throw new SupervisorEmailInvalidException($"Invalid email");
                }
            }
            else
            {
                throw new SupervisorInvalidCredentialsException($"Invalid Credentials");
            }
        }

        //Task<object> ISupervisorRepo.GetSupervisorByEmail(string email)
        //{
        //    return _wrmDbContext.SupervisorTbl.Where(s => s.Email == email).FirstOrDefault();
        //}
    }
}
