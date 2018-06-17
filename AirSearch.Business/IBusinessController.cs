using AirSearch.Business.Models;

namespace AirSearch.Business
{
    public interface IBusinessController
    {
        BookingInfo GetBookingInfo(string bookingId);
    }
}