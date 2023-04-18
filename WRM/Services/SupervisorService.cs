using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WRM.Models;
using WRM.Repositories;

namespace WRM.Services
{
    public class SupervisorService:ISupervisorService
    {
        readonly ISupervisorRepo _supervisorRepo;
        public SupervisorService(ISupervisorRepo supervisorRepo)
        {
            _supervisorRepo = supervisorRepo;

        }

        public async Task<string> AddSupervisor(Supervisor supervisor)
        {
            var supervisorExists = await _supervisorRepo.GetSupervisorByEmail(supervisor.Email);
            if (supervisorExists == null)
            {
                int a = _supervisorRepo.AddSupervisor(supervisor);
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
                return $"unsuccessful";
            }
        }

        //public Supervisor AddSupervisor(Supervisor supervisor)
        //{
        //    Supervisor supervisor1 = _supervisorRepo.AddSupervisor(supervisor);
        //    return supervisor1;

        //}

        public List<Supervisor> GetAllSupervisors()
        {
            List<Supervisor> supervisors = _supervisorRepo.GetAllSupervisors();
            return supervisors;
        }

        public Supervisor LogIn(LoginSupervisor loginSupervisor)
        {
            Supervisor supervisor =  _supervisorRepo.logIn(loginSupervisor);
            return supervisor;
        }

        //Supervisor object ISupervisorService.AddSupervisor(Supervisor supervisor)
        //{
        //    //throw new NotImplementedException();
        //    var supervisorExists = _supervisorRepo.GetSupervisorByEmail(supervisor.Email);
        //    if (supervisorExists == null)
        //    {
        //        int a = _supervisorRepo.AddSupervisor(supervisor);
        //        if (a == 1)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        
    }
}
