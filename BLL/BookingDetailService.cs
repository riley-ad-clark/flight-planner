using DAL;
using Entities.Context;
using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BookingDetailService
    {
        BookingDetailVWRepository bookingDetailRep = new BookingDetailVWRepository();
        public List<BookingDetailsVW> GetBookingDetails()
        {
            return bookingDetailRep.GetBookingDetails();
        }
        public List<UserBookingVW> GetMyBookings(string UserId)
        {
            var result = bookingDetailRep.GetMyBookings(UserId);
            return result;
        }
        public bool DeleteBooking(int id)
        {
            return bookingDetailRep.DeleteBooking(id);
        }
    }
}
