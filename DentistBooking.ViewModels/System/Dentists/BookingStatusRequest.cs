using DentisBooking.Data.Enum;

namespace DentistBooking.ViewModels.System.Dentists
{
    public class BookingStatusRequest
    {
        public int bookingID { get; set; }
        public Status status { get; set; }
    }
}