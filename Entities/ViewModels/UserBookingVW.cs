using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ViewModels
{
    public class UserBookingVW
    {
        [Key]
        public int BookingId { get; set; }
        public int FlightId { get; set; }

        public string UserId { get; set; }
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public int NumberOfPassengers { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
