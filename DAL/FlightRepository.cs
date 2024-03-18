using Entities.Context;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FlightRepository
    {
        FlightPlannerContext fpc = new FlightPlannerContext();
        public List<Airport> GetAirportsRepo()
        {
            List<Airport> airports = new List<Airport>();
            var airportsAccess = fpc.Airports;
            foreach (var airport in airportsAccess)
            {
                airports.Add(airport);
            }
            return airports;
        }

        public string BookFlightRepo(Flight flightFormData)
        {
            if (flightFormData != null)
            {
                fpc.Flights.Add(flightFormData);
                fpc.SaveChanges();
                var newFlightKey = flightFormData.FlightId;
                fpc.BookingDetails.Add(new BookingDetails
                {
                    Id= flightFormData.Id,
                    FlightId= newFlightKey
                });
                fpc.SaveChanges() ;
                return "success";
            }

            return "error";
        }

        public List<Flight> GetFlightsRepo()
        {
            List<Flight> flights = new List<Flight>();
            var flightAccess = fpc.Flights;
            foreach (var flight in flightAccess)
            {
                flights.Add(flight);
            }
            return flights;
        }

        public Airport GetAirportByIdRepo(int givenId)
        {
            return fpc.Airports.FirstOrDefault(x => x.LocationId == givenId);
        }

    }
}
