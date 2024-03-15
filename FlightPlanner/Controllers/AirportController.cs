using BLL;
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

        [HttpPost]
        public IActionResult AddAirport([FromBody] Airport airportFormData)
        {
            var response = airportService.AddAirportService(airportFormData);
            return Json(response);
        }
    }
}
