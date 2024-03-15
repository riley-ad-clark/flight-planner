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
                return "success";
            }

            return "error";
        }
    }
}
