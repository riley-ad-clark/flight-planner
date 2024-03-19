using BLL;
using Entities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FlightPlanner.Controllers
{
    public class FlightController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        [HttpGet]
        public IActionResult getFlightById(int id)
        {
            FlightService flightService = new FlightService();
            var result = flightService.GetFlightByIdService(id);
            return Json(result);
        }

        [Authorize]
        [HttpPost]
        public IActionResult UpdateFlight([FromBody] Flight flightFormData)
        {
            FlightService flightService = new FlightService();
            var update = flightService.UpdateFlight(flightFormData);
            return Json(update);
        }
        [Authorize]
        [HttpPost]
        public IActionResult DeleteFlight(int id)
        {
            FlightService flightService = new FlightService();
            var update = flightService.DeleteFlight(id);
            return Json(update);
        }
    }
}
