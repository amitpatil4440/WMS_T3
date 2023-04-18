using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WRM.ExceptionHandling
{
    public class SupervisorEmailInvalidException:ApplicationException
    {
        public SupervisorEmailInvalidException()
        {

        }
        public SupervisorEmailInvalidException(string msg):base (msg)
        {

        }
    }
}
