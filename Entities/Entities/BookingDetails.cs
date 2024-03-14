using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class BookingDetails
    {
        [Key]
        public int BookingId { get; set; }

        [ForeignKey("Flight")]
        public int FlightId { get; set; }

        [ForeignKey("AspNetUsers")]
        public string Id { get; set; }
    }
}
