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
        /// <summary>
        /// Method to fetch the airports data from user input and convert to a list
        /// </summary>
        /// <returns></returns>
        public List<Airport> GetAirportsRepository()
        {
            FlightPlannerContext flightPlannerContext = new FlightPlannerContext();
            return flightPlannerContext.Airports.ToList();
        }

        public Airport GetAirportByIdRepository(int locationId)
        {
            FlightPlannerContext flightPlannerContext = new FlightPlannerContext();
            return flightPlannerContext.Airports.FirstOrDefault(x => x.LocationId == locationId);
        }

        public bool UpdateAirportRepository(Airport airportFormData)
        {
            FlightPlannerContext flightPlannerContext = new FlightPlannerContext();

            Airport airportToBeUpdated = flightPlannerContext.Airports.FirstOrDefault(x => x.LocationId == airportFormData.LocationId);
            if (airportToBeUpdated != null)
            {
                airportToBeUpdated.AirportName = airportFormData.AirportName;
                airportToBeUpdated.CityName = airportFormData.CityName;

                flightPlannerContext.SaveChanges();
                return true;
            }
            return false;
        }


        /// <summary>
        /// Method if successful adds the user input into our database from the form
        /// </summary>
        /// <param name="airportFormData"></param>
        /// <returns></returns>
        public bool AddAirportRepository(Airport airportFormData)
        {
            FlightPlannerContext flightPlannerContext = new FlightPlannerContext();

            if (airportFormData != null)
            {
                flightPlannerContext.Airports.Add(airportFormData);
                flightPlannerContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool DeleteAirportRepository(int locationId)
        {
            FlightPlannerContext flightPlannerContext = new FlightPlannerContext();

            var airport = flightPlannerContext.Airports.Where(x => x.LocationId == locationId).FirstOrDefault();
            if (airport != null)
            {
                flightPlannerContext.Airports.Remove(airport);
                flightPlannerContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}

