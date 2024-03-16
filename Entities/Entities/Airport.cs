using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Airport
    {
        [Key]
        public int LocationId { get; set; }

        [MaxLength(100)]
        public string CityName { get; set; }

        [MaxLength(100)]
        public string AirportName { get; set; }
    }
}
