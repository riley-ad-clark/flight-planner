using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entities.ViewModels;
using Entities.Context;
using Entities.Entities;

namespace DAL
{
    public class BookingDetailVWRepository
    {
        FlightPlannerContext flightPlannerContext = new FlightPlannerContext();
        public List<BookingDetailsVW> GetBookingDetails()
        {
            List<BookingDetailsVW> bookingDetails = new List<BookingDetailsVW>();
            List<Airport> airports = new List<Airport>();
            airports = flightPlannerContext.Airports.ToList();
            return bookingDetails;
        }
    }
}
