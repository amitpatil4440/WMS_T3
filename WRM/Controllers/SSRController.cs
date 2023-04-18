using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WRM.Models;
using WRM.Services;

namespace WRM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SSRController : ControllerBase
    {
        private readonly ISSRService _SSRServices;
        public SSRController(ISSRService SSRServices)
        {
            this._SSRServices = SSRServices;
        }
        [HttpPost]
        [Route("SSRRequest")]
        public ActionResult SSRReqest(SSR ssr)
        {
            SSR ssr1 = _SSRServices.SSRRequest(ssr);
            return Ok(ssr1);
        }
        [Route("GetAllSSRRequest")]
        [HttpGet]
        public ActionResult GetAllSSRRequest()
        {
            List<SSR> ssrrequest= _SSRServices.GetAllSSRRequest();
            return Ok(ssrrequest);
        }
    }
}
