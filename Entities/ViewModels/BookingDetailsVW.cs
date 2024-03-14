using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ViewModels
{
    public class BookingDetailsVW
    {
        public int FlightId { get; set; }
        public string LocationName { get; set; }
        public string DestinationName {  get; set; }
        public int NumberOfPassengers { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Email {  get; set; }
        public string PhoneNumber { get; set; }
    }
}
