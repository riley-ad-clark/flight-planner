using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Context;
using Entities.Entities;

namespace DAL
{

    public class AirportRepository
    {
        FlightPlannerContext flightPlannerContext = new FlightPlannerContext();

        /// <summary>
        /// Method if successful adds the user input into our database from the form
        /// </summary>
        /// <param name="airportFormData"></param>
        /// <returns></returns>
        public string AddAirportRepository(Airport airportFormData)
        {
            if (airportFormData != null)
            {
                flightPlannerContext.Airports.Add(airportFormData);
                flightPlannerContext.SaveChanges();
                return "Success";
            }
            return "error";
        }
    }
}
