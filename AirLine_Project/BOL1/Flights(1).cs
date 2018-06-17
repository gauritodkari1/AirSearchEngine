using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL1
{
    class Flights
    {
            #region Flight Fields
            private int flightId;
            private string airlineName;
            private int seats;
            #endregion

            #region Constroctor
            public Flights()
            {

            }
            
            #endregion

            #region Flights Properties 
            public int FlightId { get; set; }
            public string AirlineName { get; set; }
            public int Seats { get; set; }

        #endregion

        #region Tostring Method
        public override string ToString()
            {
                return string.Format(@"FlightId:{0},AirlineName: {1}, Seats: {2}", flightId, airlineName, seats);
            }
            #endregion

        }
    }
}
