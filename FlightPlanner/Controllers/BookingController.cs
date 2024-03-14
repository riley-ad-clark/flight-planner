using Microsoft.AspNetCore.Mvc;
using DAL;

namespace FlightPlanner.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            BookingDetailVWRepository bookingDetailVWRepository = new BookingDetailVWRepository();
            bookingDetailVWRepository.GetBookingDetails();
            return View();
        }
    }
}
