using Entities.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FlightPlanner.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=FlightPlanner;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
        }

        public DbSet<Flight> Flights { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<BookingDetails> BookingDetails{ get; set; }
    }
}
