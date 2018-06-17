using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL1
{
    class BookingInfo
    {
        #region   BookingInfo Field
        private int bookingId;
        private string source;
        private string destination;
        private DateTime dateTime;
        private int seatNo;
        private float fare;
        private string status;
        #endregion

        #region    BookingInfo Constructor
        public BookingInfo()
        {

        }
        #endregion

        #region  BookingInfo Properties

        public int BookingId { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public DateTime DateTime { get; set; }
        public int SeatNo { get; set; }
        public float Fare { get; set; }
        public string Status { get; set; }
        #endregion

        #region  ToString method
        public override string ToString()
        {
            return string.Format(@"BookingId:{0},Source:{1},Destination:{2},DateTime: {3}, Seat No: {4},Fare : {5}
           ,Status:{6}", bookingId,source,destination,dateTime,seatNo,fare,status);
        }
        #endregion

    }
}
