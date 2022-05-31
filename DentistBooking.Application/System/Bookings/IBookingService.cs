using DentistBooking.ViewModels.System.Bookings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBooking.Application.System.Bookings
{
    public interface IBookingService
    {
        Task<BookingResponse> CreateBooking(BookingRequest request);
    }
}
