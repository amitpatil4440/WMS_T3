using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WRM.Models;

namespace WRM.Repositories
{
    public interface ISupervisorRepo
    {
        //int AddSupervisor(Supervisor supervisor);
        //Task<object> GetSupervisorByEmail(string email);
        List<Supervisor> GetAllSupervisors();
        Supervisor logIn(LoginSupervisor loginSupervisor);
        int AddSupervisor(Supervisor supervisor);
        Task<Supervisor> GetSupervisorByEmail(string email);
        //Supervisor AddSupervisor(Supervisor supervisor);
    }
}
