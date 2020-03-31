using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcPractical.Models
{
    public class InsuranceQuote
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public string Coverage { get; set; }
        public string DateOfBirth { get; set; }
        public int CarYear { get; set; }
        public int DUI { get; set; }
        public int SpeedingTickets { get; set; }
        public int QuotePrice { get; set; }
    }
}