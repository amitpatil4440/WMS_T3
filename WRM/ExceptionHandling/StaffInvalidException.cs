using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WRM.ExceptionHandling
{
    public class StaffInvalidException:ApplicationException
    {
        public StaffInvalidException()
        {

        }
        public StaffInvalidException(string msg):base (msg)
        {

        }
    }
}
