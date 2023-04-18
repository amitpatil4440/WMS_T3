using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WRM.Context;
using WRM.Models;

namespace WRM.Repositories
{
    public class SSRRepo: ISSRRepo
    {
       private readonly WrmDbContext _wrmDbContext;
        public SSRRepo(WrmDbContext wrmDbContext)
        {
            this._wrmDbContext = wrmDbContext;
        }

        public List<SSR> GetAllSSRRequest()
        {
            List<SSR> ssr = _wrmDbContext.WRequestTbl.ToList();
            return ssr;
        }

        public SSR SSRRequest(SSR ssr)
        {
            _wrmDbContext.WRequestTbl.Add(ssr);
            _wrmDbContext.SaveChanges();
            return ssr;

        }
    }
}
