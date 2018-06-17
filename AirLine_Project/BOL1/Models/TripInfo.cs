using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSearch.Business
{
    public class TripInfo
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
