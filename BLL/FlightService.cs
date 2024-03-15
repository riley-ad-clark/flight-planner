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
    }
}
