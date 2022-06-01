using DentisBooking.Data.DataContext;
using DentisBooking.Data.Entities;
using DentistBooking.ViewModels.Pagination;
using DentistBooking.ViewModels.System.Bookings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;

namespace DentistBooking.Application.System.Bookings
{
    public class BookingService : IBookingService
    {
        private readonly DentistDBContext _context;

        public BookingService(DentistDBContext context)
        {
            _context = context;
        }

        public async Task<BookingResponse> CreateBooking(CreateBookingRequest request)
        {
            BookingResponse response = new BookingResponse(); 
            try
            {
                for (int i = 0; i < request.DentistIds.Count; i++)
                {
                    //check keyTime
                    BookingDetail existedDetail = _context.BookingDetails
                                                  .Where(g => g.DentistId == request.DentistIds[i]
                                                  && g.ServiceId == request.ServiceIds[i]
                                                  && g.Created_at == DateTime.Parse(DateTime.Now.ToString("yyyy/MMM/dd")))
                                                  .SingleOrDefault();
                    if (existedDetail.KeyTime == request.KeyTimes[i])
                    {
                        response.Code = "700";
                        response.Message = "KeyTime is already chosen!";
                        return response;
                    }
                }
                Booking booking = new Booking()
                {
                    Status = 0,
                    Date = DateTime.Parse(DateTime.Now.ToString("yyyy/MMM/dd")),
                    Total = request.Total,
                    UserId = request.UserId,
                    Created_at = DateTime.Now
                };

                _context.Bookings.Add(booking);
                await _context.SaveChangesAsync();

                for (int i = 0; i < request.DentistIds.Count; i++)
                {
                    BookingDetail detail = new BookingDetail()
                    {
                        BookingId = booking.Id,
                        Created_at = DateTime.Now,
                        KeyTime = request.KeyTimes[i],
                        Note = request.Note,
                        Created_by = request.UserId,
                        Status = 0,
                        ServiceId = request.ServiceIds[i]
                    };
                    _context.BookingDetails.Add(detail);
                    await _context.SaveChangesAsync();
                }

                response.Code = "200";
                response.Message = "Booking successfully";

                return response;

            }
            catch (DbUpdateException)
            {
                response.Code = "200";
                response.Message = "Booking failed, try it again!";

                return response;
            }




        }

        public async Task<BookingResponse> DeleteClinic(string bookingId, Guid userId)
        {
            BookingResponse response = new BookingResponse();

            try
            {
                Booking obj = _context.Bookings.Find(bookingId);
                if (obj != null)
                {
                    obj.Deleted_by = userId;
                    obj.Deleted_at = DateTime.Parse(DateTime.Now.ToString("yyyy/MMM/dd"));
                    obj.Status = DentisBooking.Data.Enum.Status.INACTIVE;

                    await _context.SaveChangesAsync();

                    response.Code = "200";
                    response.Message = "Delete booking successfully";

                    return response;
                }
                else
                {
                    response.Code = "200";
                    response.Message = "Can not find that booking";

                    return response;
                }

            }
            catch (DbUpdateException)
            {

                response.Code = "200";
                response.Message = "Delete booking failed";

                return response;
            }
        }

        public Task<BookingDetailResponse> GetBookingDetail(string bookingId)
        {
            throw new NotImplementedException();
        }

        public async Task<ListBookingResponse> GetBookingList(PaginationFilter filter)
        {
            ListBookingResponse response = new();
            PaginationDTO paginationDTO = new();

            string orderBy = filter._order.ToString();

            if (orderBy.Equals("1"))
            {
                orderBy = "descending";
            }
            else if (orderBy.Equals("-1"))
            {
                orderBy = "ascending";
            }
            var pagedData = await _context.Bookings
                    .OrderBy(filter._by + " " + orderBy)
                    .Skip((filter.PageNumber - 1) * filter.PageSize)
                    .Take(filter.PageSize)
                    .ToListAsync();

            var totalRecords = await _context.Bookings.CountAsync();

            if (!pagedData.Any())
            {
                response.Content = null;
                response.Code = "200";
                response.Message = "There aren't any bookings in DB";
            }
            else
            {
                response.Content = pagedData;
                response.Message = "SUCCESS";
                response.Code = "200";

            }
            var totalPages = ((double)totalRecords / (double)filter.PageSize);
            int roundedTotalPages = Convert.ToInt32(Math.Ceiling(totalPages));

            paginationDTO.CurrentPage = filter.PageNumber;
            paginationDTO.PageSize = filter.PageSize;
            paginationDTO.TotalPages = roundedTotalPages;
            paginationDTO.TotalRecords = totalRecords;

            response.Pagination = paginationDTO;



            return response;
        }

        public async Task<BookingResponse> UpdateBooking(BookingRequest request)
        {
            BookingResponse response = new BookingResponse();

            try
            {
                Booking obj = _context.Bookings.Where(g => g.Id == request.Id).SingleOrDefault();
                if (obj != null)
                {
                    obj.Total = request.Total;
                    obj.Date = request.Date;
                    obj.Status = request.Status;
                    obj.Updated_at = DateTime.Parse(DateTime.Now.ToString("yyyy/MMM/dd"));
                    obj.Updated_by = request.UserId;

                    await _context.SaveChangesAsync();
                    response.Code = "200";
                    response.Message = "Update booking successfully";

                    return response;

                }
                else
                {
                    response.Code = "200";
                    response.Message = "Can not find that booking";

                    return response;
                }

            }
            catch (DbUpdateException)
            {

                response.Code = "200";
                response.Message = "Update booking failed";

                return response;
            }
        }
    }
}
