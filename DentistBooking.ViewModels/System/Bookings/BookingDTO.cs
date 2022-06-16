using System;
using System.Collections.Generic;
using DentisBooking.Data.Entities;
using DentisBooking.Data.Enum;
using DentistBooking.ViewModels.System.Users;

namespace DentistBooking.ViewModels.System.Bookings
{
    public class BookingDTO
    {
        public int Id { get; set; } 
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public Status Status { get; set; } 
        public Guid UserId { get; set; }
        
        public UserDTO User { get; set; }
        
        public List<BookingDtoDetail> Detail { get; set; }
    }
}