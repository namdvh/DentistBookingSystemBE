using System;
using DentisBooking.Data.Enum;
using DentistBooking.ViewModels.System.Users;

namespace DentistBooking.ViewModels.System.Bookings
{
    public class BookingDtoDetail
    {
        public int Id { get; set; }

        public KeyTime KeyTime { get; set; }
        
        public DateTime Date { get; set; }
        
        public Status Status { get; set; } 
        
        public UserDTO User { get; set; }
        
        public string ServiceName { get; set; }


    }
}