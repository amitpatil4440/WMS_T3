using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WRM.Models
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; }

        [Required(ErrorMessage = "Enter Email")]
        [DataType(DataType.EmailAddress)]
        [Key]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Password")]

        [DataType(DataType.Password)]
        public string Password { get; set; }

        //[DataType(DataType.Password)]
        //public string CPassword { get; set; }
        public string Availability{ get; set; }
        public string WorkingStatus{ get; set; }
        public string ContactNo { get; set; }
        public int gateNo { get; set; }
        public string pnrNo { get; set; }

    }
}
