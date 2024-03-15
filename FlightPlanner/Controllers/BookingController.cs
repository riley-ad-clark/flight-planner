using Microsoft.AspNetCore.Mvc;
using DAL;
using BLL;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace FlightPlanner.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
        [Authorize]
        public IActionResult MyBooking()
        {

            return View();
        }
        public IActionResult GetBookingList()
        {
            BookingDetailService bookingDetailService = new BookingDetailService();
            var result = bookingDetailService.GetBookingDetails();
            return Json(result);
        }
        [Authorize]
        public IActionResult GetMyBooking()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            
            if (userId != null)
            {
                BookingDetailService bookingDetailService = new BookingDetailService();
                var result = bookingDetailService.GetMyBookings(userId);
                return Json(result);
            }
            else {
                var result = "must be login in";
                return Json(result);
            }
            
            
        }
        [Authorize]
        [HttpPost]
        public IActionResult CancelBooking(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId != null)
            {
                BookingDetailService bookingDetailService = new BookingDetailService();
                var result = bookingDetailService.DeleteBooking(id);
                return Json(result);
            }
            else
            {
                var result = "must be login in";
                return Json(result);
            }
        }
    }
}
