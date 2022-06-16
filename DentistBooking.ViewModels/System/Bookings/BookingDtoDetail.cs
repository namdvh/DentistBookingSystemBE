using System;
using DentisBooking.Data.Enum;

namespace DentistBooking.ViewModels.System.Bookings
{
    public class BookingDtoDetail
    {
        public int Id { get; set; }

        public KeyTime KeyTime { get; set; }
        
        public DateTime Date { get; set; }
        
        public Status Status { get; set; } 

    }
}