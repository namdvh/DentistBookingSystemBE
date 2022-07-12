using DentisBooking.Data.Enum;

namespace DentistBooking.ViewModels.System.Dentists
{
    public class BookingDetailStatusRequest
    {
        public int bookingDetailID { get; set; }
        public Status status { get; set; }
    }
}