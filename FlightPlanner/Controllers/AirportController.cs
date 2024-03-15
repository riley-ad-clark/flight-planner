using BLL;
using DAL;
using FlightPlanner.Models;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;


namespace FlightPlanner.Controllers
{
    public class AirportController : Controller
    {
        AirportService airportService = new AirportService();
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAirports()
        {
            var apService = airportService.GetAirportService();

            List<Airport> airportVMs = new List<Airport>();

            foreach (Airport ap in apService)
            {
                airportVMs.Add(new Airport
                {
                    LocationId = ap.LocationId,
                    CityName = ap.CityName,
                    AirportName = ap.AirportName
                });
            }

            return Json(airportVMs);
        }

        [HttpPost]
        public IActionResult AddAirport([FromBody] Airport airportFormData)
        {
            var response = airportService.AddAirportService(airportFormData);
            return Json(response);
        }
    }
}
