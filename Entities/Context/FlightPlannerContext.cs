using Entities.Entities;
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
            optionsBuilder.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=FlightPlanner;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Flight> Flights { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<BookingDetails> BookingDetails { get; set; }
    }
}
