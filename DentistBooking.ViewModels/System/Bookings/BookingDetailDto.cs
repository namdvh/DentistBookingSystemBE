using System.Collections.Generic;
using DentisBooking.Data.Enum;
using DentistBooking.ViewModels.System.Dentists;

namespace DentistBooking.ViewModels.System.Bookings
{
    public class BookingDetailDto
    {
        public int Id { get; set; }

        public KeyTime KeyTime { get; set; }
        public string? Note { get; set; }

        public Status Status { get; set; }
        public List<DentistServiceDto> Services { get; set; }

    }
}