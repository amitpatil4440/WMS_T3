using log4net;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WRM
{
    public class LogFilterAttribute:ExceptionFilterAttribute
    {
        
        ILog logger;
        public LogFilterAttribute()
        {
            logger = LogManager.GetLogger(typeof(LogFilterAttribute));
        }
        public override void OnException(ExceptionContext context)
        {
            logger.Error(context.Exception.Message);
        }
    }
}
