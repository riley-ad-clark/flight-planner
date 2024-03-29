﻿using Entities.Entities;
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
    public class BookingDetailsVW
    {
        [Key]
        public int BookingId { get; set; }
        public int FlightId { get; set; }
        
        public string UserId { get; set; }
        //public AspNetUsers UserInfo { get; set; }
        //public Flight FlightInfo { get; set; }
        
        public string UserName { get; set; }
        public string Email {  get; set; }
        public string? PhoneNumber { get; set; }
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public int NumberOfPassengers { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        
    }
}
