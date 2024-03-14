using Microsoft.AspNetCore.Mvc;

namespace FlightPlanner.Controllers
{
    public class AirportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
