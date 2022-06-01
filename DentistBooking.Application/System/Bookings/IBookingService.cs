using DentistBooking.ViewModels.Pagination;
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
        Task<BookingResponse> CreateBooking(CreateBookingRequest request);
        Task<ListBookingResponse> GetBookingList(PaginationFilter filter);
        Task<BookingResponse> UpdateBooking(BookingRequest request);
        Task<BookingResponse> DeleteBooking(string bookingId, Guid userId);
        Task<BookingDetailResponse> GetBookingDetail(string bookingId);
    }
}
