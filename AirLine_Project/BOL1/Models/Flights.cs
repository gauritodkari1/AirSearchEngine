using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirSearch.Business.Models;

namespace AirSearch.Business.Models
{
   public class Flights : BaseModel
    {
        /// <summary>
        /// FlightId
        /// </summary>
        public int FlightId { set; get; }
        /// <summary>
        /// FlightName
        /// </summary>
        public string FlightName { set; get; }
        /// <summary>
        /// Capacity
        /// </summary>
        public int Capacity { set; get; }

    }
}
