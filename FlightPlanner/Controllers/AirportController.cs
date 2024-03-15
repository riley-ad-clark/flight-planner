using BLL;
using DAL;
using Microsoft.AspNetCore.Mvc;
using FlightPlanner.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Entities.Entities;
using Entities.ViewModels; 
using System.Collections.Generic; 


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
            var airportList = airportService.GetAirportService();
            var airportVMs = new List<AirportVM>();

            foreach (var airport in airportList)
            {
                airportVMs.Add(new AirportVM
                {
                    LocationId = airport.LocationId,
                    CityName = airport.CityName,
                    AirportName = airport.AirportName
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

        [HttpPost]
        public IActionResult DeleteAirport(int locationId)
        {
            var response = airportService.DeleteAirportService(locationId);

            if (response)
            {
                return Json(response);
            }
            else
            {
                var errorMessage = "Failed to delete airport.";
                return Json(errorMessage);
            }
        }
    }
}
