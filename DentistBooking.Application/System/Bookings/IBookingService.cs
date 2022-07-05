using DentisBooking.Data.Enum;
using DentistBooking.ViewModels.Pagination;
using DentistBooking.ViewModels.System.Bookings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DentistBooking.ViewModels.System.Dentists;

namespace DentistBooking.Application.System.Bookings
{
    public interface IBookingService
    {
        Task<BookingResponse> CreateBooking(CreateBookingRequest request);
        Task<ListBookingResponse> GetBookingList(PaginationFilter filter);
        Task<BookingResponse> UpdateBooking(BookingRequest request);
        Task<BookingResponse> DeleteBooking(int bookingId, Guid userId);
        Task<BookingDetailResponse> GetBookingDetail(int bookingId);
        Task<ListBookingDTOResponse> GetBookingListForDentist(PaginationFilter filter, int dentistId,string _where);
        Task<List<KeyTime>> GetAvailableKeyTime(int dentistId, DateTime date);
        
        Task<BookingResponse> UpdateBookingStatus(BookingStatusRequest request);
        Task<BookingResponse> UpdateBookingDetailStatus(BookingDetailStatusRequest request);
    }
}
