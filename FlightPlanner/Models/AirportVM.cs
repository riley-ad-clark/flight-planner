using System.ComponentModel.DataAnnotations;
using FlightPlanner.Models;

namespace FlightPlanner.Models
{
    public class AirportVM
    {
        [Key]
        public int LocationId { get; set; }
        public string CityName { get; set; }
        public string AirportName { get; set; }
    }
}
