using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Casgem_CodefirstProject.DAL.Entities
{
    public class Booking
    {
        public int BoookingID { get; set; }
        public string  CustomerName { get; set; }
        public string  Destinatiion { get; set; }
        public string  Duration { get; set; }
        public string  Mail { get; set; }
        public DateTime  BookingDate { get; set; }
        public string  BookingStatus{ get; set; }
    }
}