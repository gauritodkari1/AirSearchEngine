﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirSearch.Business.Models;

namespace AirSearch.Business.Models
{
    public class BookingInfo 
    {
        /// <summary>
        /// BookingId
        /// </summary>
        public int BookingId { get; set; }

        /// <summary>
        /// BookingDate
        /// </summary>
        public DateTime BookingDate { get; set; }

        /// <summary>
        /// TripId
        /// </summary>
        public int TripId { get; set; }

        /// <summary>
        /// UserId
        /// </summary>
        public int UserId { get; set; }
    }
}
