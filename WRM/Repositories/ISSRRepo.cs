using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WRM.Models;

namespace WRM.Repositories
{
    public interface ISSRRepo
    {
        SSR SSRRequest(SSR ssr);
        List<SSR> GetAllSSRRequest();
    }
}


