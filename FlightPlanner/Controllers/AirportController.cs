using BLL;
using Entities.Entities;
using Entities.ViewModels;
using FlightPlanner.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using System.Security.Claims;


namespace FlightPlanner.Controllers
{
    public class AirportController : Controller
    {
        AirportService airportService = new AirportService();
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        [HttpGet]
        public IActionResult GetAirports()
        {
            var airportList = airportService.GetAirportService();

            List<AirportVM> airportVMs = new List<AirportVM>();

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

        [Authorize]
        [HttpGet]
        public IActionResult GetAirportById(int locationId)
        {
            var airport = airportService.GetAirportByIdService(locationId);
            return Json(airport);
        }

        [Authorize]
        [HttpPost]
        public IActionResult UpdateAirport([FromBody] Airport airportFormData)
        {
            var update = airportService.UpdateAirportService(airportFormData);
            return Json(update);
        }

        [Authorize]
        [HttpPost]
        public IActionResult AddAirport([FromBody] Airport airportFormData)
        {
            var response = airportService.AddAirportService(airportFormData);
            return Json(response);
        }

        [Authorize]
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
