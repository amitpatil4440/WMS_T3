using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace WRM.Models
{
    public class Passenger
    {
        [Key]
        public int PId { get; set; }
        public string PName { get; set; }

        
        [Required(ErrorMessage ="Enter PNR No")]
        public string  PNRNo { get; set; }

        [Required(ErrorMessage = "Enter Gate No")]
        public int GateNo { get; set; }
        public  string ContactNo { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime  EndDate{ get; set; }
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public int SeatNo { get; set; }
        public string FlightClass { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

    }
}
