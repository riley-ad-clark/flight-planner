using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities.Entities;

namespace BLL
{
    /// <summary>
    /// Takes the airportRepository method to add the user input from the form and add it into the database
    /// </summary>
    public class AirportService
    {
        AirportRepository airportRepository = new AirportRepository();

        public string AddAirportService(Airport airportFormData)
        {
            return airportRepository.AddAirportRepository(airportFormData);
        }
    }
}
