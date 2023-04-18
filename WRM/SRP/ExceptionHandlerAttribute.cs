using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WRM.ExceptionHandling;
//using WRM.ExceptionHandler;

namespace WRM.SRP
{
    public class ExceptionHandlerAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            if (context.Exception.GetType() == typeof(StaffEmailInvalidException))
            {
                context.Result = new OkObjectResult(context.Exception.Message);
            }
            else if (context.Exception.GetType() == typeof(StaffInvalidException))
            {
                context.Result = new OkObjectResult(context.Exception.Message);
            }
            else if (context.Exception.GetType() == typeof(SupervisorEmailInvalidException))
            {
                context.Result = new OkObjectResult(context.Exception.Message);
            }
            else if (context.Exception.GetType() == typeof(SupervisorInvalidCredentialsException))
            {
                context.Result = new OkObjectResult(context.Exception.Message);
            }
            else
            {
                context.Result = new StatusCodeResult(500);
            }
        }
    }
}
