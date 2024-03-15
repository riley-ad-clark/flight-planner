using System.ComponentModel.DataAnnotations;

namespace FlightPlanner.Models
{
    public class AirportVM
    {
        public int LocationId { get; set; }
        public string CityName { get; set; }
        public string AirportName { get; set; }

    }
}
