using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSearch.Business
{
   public class Flights
    {
            #region Flight Fields
            private int flightId;
            private string flightName;
            private int capacity;
            #endregion

            #region Constroctor
            public Flights()
            {

            }
            
            #endregion

            #region Flights Properties 
            public int FlightId { get; set; }
            public string FlightName { get; set; }
            public int Capacity { get; set; }

        #endregion

        #region Tostring Method
        public override string ToString()
            {
                return string.Format(@"FlightId:{0},FlightName: {1}, Capacity: {2}", flightId, flightName, capacity);
            }
            #endregion        
    }
}
