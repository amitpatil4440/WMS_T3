using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WRM.Models
{
    public class Supervisor
    {
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter Email")]
        [DataType(DataType.EmailAddress)]
        [Key]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Password")]

        [DataType(DataType.Password)]
        public string Password { get; set; }


        //[DataType(DataType.Password)]
        //public string CPassword { get; set; }
    }
}
