namespace FlightPlanner.Models
{
    public class FlightVM
    {
        public int FlightId { get; set; }
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
    }
}
