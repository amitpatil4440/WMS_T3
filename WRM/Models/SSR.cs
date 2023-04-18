using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WRM.Models
{
    public class SSR
    {

        [Key]
        public int SSRId { get; set; }

        [Required(ErrorMessage = "Enter PNR No")]
        public string PNRNo { get; set; }

        [Required(ErrorMessage = "Enter Gate No")]
        public int GateNo { get; set; }

        
       
    }
}
