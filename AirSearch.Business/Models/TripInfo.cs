using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSearch.Business.Models
{
    public class TripInfo : BaseModel
    {
        /// <summary>
        /// TripId
        /// </summary>
        public int TripId { get; set; }

        /// <summary>
        /// FlightId
        /// </summary>
        public int FlightId { get; set; }

        /// <summary>
        ///  Source
        /// </summary>
        public string Source { get; set; }
        /// <summary>
        ///  Destination
        /// </summary>
        public string Destination { get; set; }
        /// <summary>
        ///  ArrivalDateTime 
        /// </summary>
        public DateTime ArrivalDateTime { get; set; }
        /// <summary>
        /// DepartureDateTime 
        /// </summary>
        public DateTime DepartureDateTime { get; set; }
        /// <summary>
        /// AvailableSeats
        /// </summary>
        public int AvailableSeats { get; set; }
        /// <summary>
        /// Fare 
        /// </summary>
        public decimal Fare { get; set; }
    }
}
