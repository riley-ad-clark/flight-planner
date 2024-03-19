using DAL;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public  class FlightService
    {
        FlightRepository fr = new FlightRepository();
        public List<Airport> GetAirportsService()
        {
            return fr.GetAirportsRepo();
        }

        public string BookFlightService(Flight flightFormData)
        {
            return fr.BookFlightRepo(flightFormData);
        }

        public List<Flight> GetFlightService()
        {
            return fr.GetFlightsRepo();
        }

        public Airport GetAirportByIdService(int givenId)
        {
            return fr.GetAirportByIdRepo(givenId);
        }
        public Flight GetFlightByIdService(int givenId)
        {
            return fr.GetFlightByIdRepo(givenId);
        }
        public bool UpdateFlight(Flight flight)
        {
            return fr.UpdateFlight(flight);
        }

        public bool DeleteFlight(int id) 
        {
            return fr.DeleteFlight(id);
        }
    }
}
