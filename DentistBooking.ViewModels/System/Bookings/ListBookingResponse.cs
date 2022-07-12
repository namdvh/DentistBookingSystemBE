using DentisBooking.Data.Entities;
using DentistBooking.ViewModels.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBooking.ViewModels.System.Bookings
{
    public class ListBookingResponse
    {
        public IEnumerable<BookingDTO> Content { get; set; }

        public string Code { get; set; }

        public string Message { get; set; }

        public PaginationDTO Pagination { get; set; }
    }
}
