using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WRM.Models;

namespace WRM.Services
{
    public interface ISSRService
    {
       SSR SSRRequest(SSR ssr);
        List<SSR> GetAllSSRRequest();
    }
}
