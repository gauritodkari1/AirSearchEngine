using System;
using System.Collections.Generic;
using System.Text;

namespace BOL
{
    class Flights
    {
        #region Flight Fields
        private int flightId;
        private string airlineName;
        private int seats;
        #endregion 

        #region Constroctors
        public Flights()
        {
          
        }
        public Flights(int flightId, string airlineName)
        {
            
            this.flightId = flightId;
            this.airlineName = airlineName;
        }


        public Flights(int flightId, string airlineName, int seats)
        {
           
            this.flightId = flightId;
            this.airlineName = airlineName;
            this.seats = seats;
        }
        #endregion

        #region Flights Properties 
        public int FlightId
        {
            get { return flightId; }
            set { flightId = value; }
        }

        public string AirlineName
        {
            get { return airlineName; }
            set { airlineName = value; }
        }

        public int Seats
        {
            get { return seats; }
            set { seats = value; }
        }
        #endregion

        #region Tostring Method
        public override string ToString()
        {
            return string.Format(@"FlightId:{0},AirlineName: {1}, Seats: {2}", flightId,airlineName, seats);
        }
        #endregion

    }
}
