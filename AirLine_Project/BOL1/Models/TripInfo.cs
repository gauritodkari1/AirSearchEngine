using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirSearch.Business.Models;

namespace AirSearch.Business
{
    public class TripInfo : BaseModel
    {
        public int TripId { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public DateTime ArrivalDateTime { get; set; }
        public DateTime DepartureDateTime { get; set; }
        public int AvailableSeats { get; set; }
        public decimal Fare { get; set; }
    }
}
