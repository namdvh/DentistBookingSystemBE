using System.Collections.Generic;
using DentisBooking.Data.Entities;
using DentistBooking.ViewModels.Pagination;

namespace DentistBooking.ViewModels.System.Bookings
{
    public class ListBookingDTOResponse
    {
        public IEnumerable<BookingDTO> Content { get; set; }

        public string Code { get; set; }

        public string Message { get; set; }

        public PaginationDTO Pagination { get; set; }
    }
}