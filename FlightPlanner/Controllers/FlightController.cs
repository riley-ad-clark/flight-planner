using Microsoft.AspNetCore.Mvc;

namespace FlightPlanner.Controllers
{
    public class FlightController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
