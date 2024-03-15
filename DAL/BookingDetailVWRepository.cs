using Entities.Context;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entities.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System.Data;


namespace DAL
{
    public class BookingDetailVWRepository
    {
        FlightPlannerContext flightPlannerContext = new FlightPlannerContext();
        public List<BookingDetailsVW> GetBookingDetails()
        {
            var result = flightPlannerContext.Set<BookingDetailsVW>().FromSqlRaw("Exec usp_GetBookingINfo").ToList();
            return result;
        }

        public List<UserBookingVW> GetMyBookings(string UserId)
        {
            var courseIdparam = new SqlParameter("@UserId", UserId);
            var result = flightPlannerContext.Set<UserBookingVW>().FromSqlRaw("Exec usp_GetMyBooking @UserId", courseIdparam).ToList();
            return result;
        }
    }
}
