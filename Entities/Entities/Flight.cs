using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Flight
    {
        [Key]
        public int FlightId { get; set; }

        public int DestinationId { get; set; }

        [ForeignKey("Airport")]
        public int LocationId { get; set; }

        [ForeignKey("AspNetUsers")]
        public string Id { get; set; }

        public int NumberOfPassengers { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
