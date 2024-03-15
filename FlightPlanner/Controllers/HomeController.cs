using BLL;
using Entities.Entities;
using FlightPlanner.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using System.Security.Claims;

namespace FlightPlanner.Controllers
{
    public class HomeController : Controller
    {
        FlightService fs = new FlightService();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Authorize]
        public IActionResult Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // userID after login in
            if(userId != null) { 
                ViewBag.UserId = userId;
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult GetAirports()
        {
            List<Airport> airports = fs.GetAirportsService();
            var dropdownItems = airports.Select(item => new SelectListItem { Value = item.LocationId.ToString(), Text = $"{item.CityName} | {item.AirportName}" });
            return Json(dropdownItems);
        }

        [HttpPost]
        public IActionResult BookFlight([FromBody] Flight flightFormData)
        {
            var response = fs.BookFlightService(flightFormData);
            return Json(response);
        }

        [HttpGet]
        public IActionResult GetFlights()
        {
            List<FlightVM> flights = new List<FlightVM>();

            List<Flight> flightsAccess = fs.GetFlightService();
            foreach (Flight flight in flightsAccess) 
            {
                var departure = fs.GetAirportByIdService(flight.LocationId);
                var arrival = fs.GetAirportByIdService(flight.DestinationId);

                FlightVM listedFlight = new FlightVM
                {
                    FlightId = flight.FlightId,
                    Departure = departure.CityName + " | " + departure.AirportName,
                    Arrival = arrival.CityName + " | " + departure.AirportName,
                    DepartureDate = flight.StartDate,
                    ArrivalDate = flight.EndDate
                };

                flights.Add(listedFlight);
            }

            return Json(flights);
        }
    }
}
