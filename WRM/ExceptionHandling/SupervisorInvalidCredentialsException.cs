using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WRM.ExceptionHandling
{
    public class SupervisorInvalidCredentialsException:ApplicationException
    {
        public SupervisorInvalidCredentialsException()
        {

        }
        public SupervisorInvalidCredentialsException(string msg):base (msg)
        {

        }
    }
}
