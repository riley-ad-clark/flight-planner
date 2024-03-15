using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ViewModels
{
    public class AirportVM
    {
        [Key]
        public int LocationId { get; set; }
        public string CityName { get; set; }
        public string AirportName { get; set; }
    }
}
