using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WRM.ExceptionHandling
{
    public class StaffEmailInvalidException:ApplicationException
    {
        public StaffEmailInvalidException()
        {

        }
        public StaffEmailInvalidException(string msg): base(msg)
        {

        }
    }
}
