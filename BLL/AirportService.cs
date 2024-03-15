using DAL;
using Entities.Context;
using Entities.Entities;
using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    public class AirportService
    {
        AirportRepository airportRepository = new AirportRepository();

        public List<Airport> GetAirportService()
        {
            return airportRepository.GetAirportsRepository();
        }

        /// <summary>
        /// Takes the airportRepository method to add the user input from the form and add it into the database
        /// </summary>
        public bool AddAirportService(Airport airportFormData)
        {
            return airportRepository.AddAirportRepository(airportFormData);
        }

        public bool DeleteAirportService(int locationId)
        {
            return airportRepository.DeleteAirportRepository(locationId);
        }
    }
}
