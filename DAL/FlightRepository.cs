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

        public Flight GetFlightByIdRepo(int givenId)
        {
            return fpc.Flights.Where(x => x.FlightId == givenId).FirstOrDefault();
        }

        public bool UpdateFlight(Flight flight)
        {
            if(flight != null)
            {
                Flight result = fpc.Flights.Where(x => x.FlightId == flight.FlightId).FirstOrDefault();
                if(result != null) 
                {
                    result.DestinationId = flight.DestinationId;
                    result.LocationId = flight.LocationId;
                    result.StartDate = flight.StartDate;
                    result.EndDate= flight.EndDate;
                    fpc.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public bool DeleteFlight(int id)
        {
            var flight = fpc.Flights.Where(x => x.FlightId == id).FirstOrDefault();
            var booking = fpc.BookingDetails.Where(x => x.Id == flight.Id);
            if (flight != null)
            {
                fpc.Flights.RemoveRange(flight);
                if (booking != null)
                {
                    fpc.BookingDetails.RemoveRange(booking);
                }
                fpc.SaveChanges();
                return true;
            }
            return false;
        }

    }
}
