using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WRM.Models;

namespace WRM.Services
{
    public interface ISupervisorService
    {
        //Supervisor object AddSupervisor(Supervisor supervisor);
        List<Supervisor> GetAllSupervisors();
        Supervisor LogIn(LoginSupervisor loginSupervisor);
        Task<string> AddSupervisor(Supervisor supervisor);
        //Supervisor AddSupervisor(Supervisor supervisor);
    }
}
