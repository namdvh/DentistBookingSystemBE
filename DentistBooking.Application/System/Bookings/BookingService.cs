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
using DentistBooking.ViewModels.System.Dentists;
using DentistBooking.ViewModels.System.Users;

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
                    var existedDetail = await (from detail in _context.BookingDetails
                        join book in _context.Bookings on detail.BookingId equals book.Id
                        where detail.DentistId == request.DentistIds[i]
                              && detail.ServiceId == request.ServiceIds[i]
                              && book.Date.Equals(request.Date)
                        select detail).ToListAsync();

                    foreach (var item in existedDetail)
                    {
                        if (item.KeyTime == request.KeyTimes[i])
                        {
                            response.Code = "700";
                            response.Message = "KeyTime is already chosen!";
                            return response;
                        }
                    }
                }

                Booking booking = new Booking()
                {
                    Status = DentisBooking.Data.Enum.Status.ACTIVE,
                    Date = request.Date,
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

        public async Task<BookingResponse> DeleteBooking(int bookingId, Guid userId)
        {
            BookingResponse response = new BookingResponse();

            try
            {
                Booking obj = await _context.Bookings.FindAsync(bookingId);
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
                Booking obj = await _context.Bookings.Where(g => g.Id == request.Id).SingleOrDefaultAsync();
                if (obj != null)
                {
                    obj.Total = request.Total;
                    obj.Date = request.Date;
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

        public async Task<BookingDetailResponse> GetBookingDetail(int bookingId)
        {
            BookingDetailResponse response = new BookingDetailResponse();
            List<BookingDetailDto> listDto = new();
            
            try
            {
                List<BookingDetail> details =
                    await _context.BookingDetails.Where(g => g.BookingId.Equals(bookingId)).ToListAsync();

                if (details != null)
                {
                    foreach (var x in details)
                    {
                        listDto.Add( MapToBookingDetailDto(x));
                    }
                    
                    response.Details = listDto;
                    response.Code = "200";
                    response.Message = "GetBookingDetail successfully";

                    return response;
                }
                else
                {
                    response.Details = null;
                    response.Code = "200";
                    response.Message = "Can not find any booking detail of that booking";

                    return response;
                }
            }
            catch (DbUpdateException)
            {
                response.Details = null;
                response.Code = "200";
                response.Message = "GetBookingDetail failed";

                return response;
            }
        }

        public async Task<ListBookingDTOResponse> GetBookingListForDentist(PaginationFilter filter, int dentistId)
        {
            ListBookingDTOResponse response = new();
            PaginationDTO paginationDto = new();
            List<BookingDTO> listDto = new();


            var orderBy = filter._order.ToString();

            if (orderBy.Equals("1"))
            {
                orderBy = "descending";
            }
            else if (orderBy.Equals("-1"))
            {
                orderBy = "ascending";
            }

            var createdAt = "Date";

            if (filter._by.Equals("day"))
            {
                createdAt += ".Day";
            }else if (filter._by.Equals("month"))
            {
                createdAt += ".Month";
            }
            else
            {
                createdAt += ".Year";
            }
            dynamic pagedData=null;

            if (filter._all)
            {
                pagedData = await (from booking in _context.Bookings
                    join bookingDetail in _context.BookingDetails on booking.Id equals bookingDetail.BookingId
                    where bookingDetail.DentistId == dentistId && ( booking.Status == DentisBooking.Data.Enum.Status.CONFIRMED || booking.Status == DentisBooking.Data.Enum.Status.DONE )
                    select new { booking, bookingDetail })
                    .OrderBy("booking."+createdAt + " " + orderBy)
                    .ToListAsync();
            
            }
            else
            {
                pagedData = await (from booking in _context.Bookings
                        join bookingDetail in _context.BookingDetails on booking.Id equals bookingDetail.BookingId
                        where bookingDetail.DentistId == dentistId && (booking.Status == DentisBooking.Data.Enum.Status.CONFIRMED || booking.Status == DentisBooking.Data.Enum.Status.DONE)
                                   select new { booking, bookingDetail })
                    .OrderBy("booking."+createdAt + " " + orderBy)
                    .Skip((filter.PageNumber - 1) * filter.PageSize)
                    .Take(filter.PageSize)
                    .ToListAsync();
            }


            var totalRecords = await (from booking in _context.Bookings
                join bookingDetail in _context.BookingDetails on booking.Id equals bookingDetail.BookingId
                where bookingDetail.DentistId == dentistId
                select new { booking, bookingDetail }).CountAsync();

            if (pagedData==null)
            {
                response.Content = null;
                response.Code = "200";
                response.Message = "There aren't any bookings in DB";
            }
            else
            {
                foreach (var x in pagedData)
                {
                    listDto.Add(mapToBookingDto(x.booking));
                }
                
                
                response.Content = listDto;
                response.Message = "SUCCESS";
                response.Code = "200";
            }

            var totalPages = ((double)totalRecords / (double)filter.PageSize);
            int roundedTotalPages = Convert.ToInt32(Math.Ceiling(totalPages));
            
            paginationDto.CurrentPage = filter.PageNumber;
            paginationDto.PageSize = filter.PageSize;
            paginationDto.TotalPages = roundedTotalPages;
            paginationDto.TotalRecords = totalRecords;

            response.Pagination = paginationDto;


            return response;
        }


        private BookingDTO mapToBookingDto(Booking booking)
        {
            BookingDTO bookingDto = new BookingDTO()
            {
                Date = booking.Date,
                Id = booking.Id,
                Status = booking.Status,
                Total = booking.Total,
                UserId = booking.UserId,
                User = MapToDTO(booking.UserId),
                Detail = GetDetailFromBooking(booking.Id)
            };
            return bookingDto;
        }

        private BookingDetailDto MapToBookingDetailDto(BookingDetail bookingDetail)
        {
            var detailDto = new BookingDetailDto()
            {
                Id = bookingDetail.Id,
                Note = bookingDetail.Note,
                Services =  GetService(bookingDetail.ServiceId),
                Status = bookingDetail.Status,
                KeyTime = bookingDetail.KeyTime

            };

            return detailDto;
        }
        
   
        

        private UserDTO MapToDTO(Guid userID)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == userID);
            
            var userDto = new UserDTO()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Phone = user.PhoneNumber,
                Id = user.Id.ToString(),
                Email = user.Email
            };

            return userDto;
        }
        
        private  DentistServiceDto GetService(int serviceId)
        {
            var result = _context.Services.FirstOrDefault(x => x.Id == serviceId);

                DentistServiceDto dto = new();
                dto.Id = result.Id;
                dto.ServiceName = result.Name;

            return dto;
        }

        private List<BookingDtoDetail> GetDetailFromBooking(int bookingId)
        {
            List<BookingDtoDetail> list = new();


            var data =  _context.BookingDetails.Where(x => x.BookingId == bookingId).ToList();


            foreach (var x in data)
            {
                BookingDtoDetail detail = new()
                {
                    Id = x.Id,
                    KeyTime = x.KeyTime
                };
                list.Add(detail);

            }

            return list;
        }
    }
}