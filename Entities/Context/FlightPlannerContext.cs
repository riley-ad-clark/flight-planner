using Entities.Entities;
using Entities.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Context
{
    public class FlightPlannerContext:DbContext
    {
        public FlightPlannerContext():base()
        { 

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=FlightPlanner;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
        }

        public DbSet<Flight> Flights { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<AirportVM> AirportVM { get; set; }
        public DbSet<BookingDetails> BookingDetails { get; set; }
        public DbSet<AspNetUsers> AspNetUsers { get; set;}
        public DbSet<BookingDetailsVW> BookingDetailsVW { get; set; }
        public DbSet<UserBookingVW> UserBookingVW { get; set; }
    }
}
