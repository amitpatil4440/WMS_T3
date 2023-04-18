using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WRM.Models;
using WRM.Repositories;

namespace WRM.Services
{
    public class SSRService: ISSRService
    {
        private readonly ISSRRepo _SSRRepo;

        public SSRService(ISSRRepo SSRRepo)
        {
            this._SSRRepo = SSRRepo;
        }

        public List<SSR> GetAllSSRRequest()
        {
            List<SSR> ssr = _SSRRepo.GetAllSSRRequest();
            return ssr;
        }

        public SSR SSRRequest(SSR ssr)
        {
            SSR ssr1 = _SSRRepo.SSRRequest(ssr);
            return ssr1;
        }
    }
}
