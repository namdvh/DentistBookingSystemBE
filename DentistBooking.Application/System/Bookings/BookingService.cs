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
using DentisBooking.Data.Enum;
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

        public BookingResponse CreateBooking(CreateBookingRequest request)
        {
            BookingResponse response = new BookingResponse();
            try
            {
                for (int i = 0; i < request.ServiceIds.Count; i++)
                {
                    var existed = (from bookingDetail in _context.BookingDetails
                                         join bookings in _context.Bookings
                                         on bookingDetail.BookingId equals bookings.Id
                                         where bookings.Date.Equals(request.Date) && bookingDetail.DentistId == request.DentistIds[0]
                                         && bookingDetail.KeyTime == request.KeyTimes[i]
                                         select new { bookingDetail }).FirstOrDefault();
                    if(existed != null)
                    {
                        response.Code = "204";
                        response.Message = "Dentist is busy at that time";

                        return response;
                    }
                }


                Booking booking = new Booking()
                {
                    Status = Status.PENDING,
                    Date = DateTime.Parse(request.Date.ToShortDateString()),
                    Total = request.Total,
                    UserId = request.UserId,
                    Created_at = DateTime.Now
                };

                _context.Bookings.Add(booking);
                _context.SaveChanges();

                for (int i = 0; i < request.ServiceIds.Count; i++)
                {
                    BookingDetail detail = new BookingDetail()
                    {
                        BookingId = booking.Id,
                        DentistId = request.DentistIds[0],
                        Created_at = DateTime.Now,
                        KeyTime = request.KeyTimes[i],
                        Note = request.Note,
                        Created_by = request.UserId,
                        Status = 0,
                        ServiceId = request.ServiceIds[i]
                    };
                    _context.BookingDetails.Add(detail);
                    _context.SaveChanges();
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
            List<BookingDTO> listDto = new();
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
                foreach (var x in pagedData)
                {
                    listDto.Add(mapToBookingDto(x));
                }
                response.Content = listDto;
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
                        listDto.Add(MapToBookingDetailDto(x));
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

        public async Task<ListBookingDTOResponse> GetBookingListForDentist(PaginationFilter filter, int dentistId,
            string where)
        {
            if (String.IsNullOrEmpty(where))
            {
                where = "";
            }

            ListBookingDTOResponse response = new();
            PaginationDTO paginationDto = new();
            List<BookingDTO> listDto = new();
            string condition = "";

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
            }
            else if (filter._by.Equals("month"))
            {
                createdAt += ".Month";
            }
            else
            {
                createdAt += ".Year";
            }

            dynamic pagedData = null;
            int totalRecords = 0;


            if (where.Contains("day"))
            {
                int day = int.Parse(where.Split('.')[1]);
                int month = int.Parse(where.Split('.')[2]);
                int year = int.Parse(where.Split('.')[3]);

                pagedData = await (from booking in _context.Bookings
                                   join bookingDetail in _context.BookingDetails on booking.Id equals bookingDetail.BookingId
                                   where bookingDetail.DentistId == dentistId &&
                                         booking.Status == Status.CONFIRMED && booking.Date.Day == day &&
                                         booking.Date.Month == month && booking.Date.Year == year
                                   select new { booking })
                    .OrderBy("booking." + createdAt + " " + orderBy)
                    .Skip((filter.PageNumber - 1) * filter.PageSize)
                    .Distinct()
                    .Take(filter.PageSize)
                    .ToListAsync();

                totalRecords = await (from booking in _context.Bookings
                                      join bookingDetail in _context.BookingDetails on booking.Id equals bookingDetail.BookingId
                                      where bookingDetail.DentistId == dentistId &&
                                            booking.Status == Status.CONFIRMED && booking.Date.Day == day &&
                                            booking.Date.Month == month && booking.Date.Year == year
                                      select new { booking })
                    .Distinct()
                    .CountAsync();
            }

            if (where.Contains("month"))
            {
                int month = int.Parse(where.Split('.')[1]);
                int year = int.Parse(where.Split('.')[2]);

                pagedData = await (from booking in _context.Bookings
                                   join bookingDetail in _context.BookingDetails on booking.Id equals bookingDetail.BookingId
                                   where bookingDetail.DentistId == dentistId &&
                                        booking.Status == Status.CONFIRMED && booking.Date.Month == month &&
                                         booking.Date.Year == year
                                   select new { booking })
                    .OrderBy("booking." + createdAt + " " + orderBy)
                    .Skip((filter.PageNumber - 1) * filter.PageSize)
                    .Distinct()
                    .Take(filter.PageSize)
                    .ToListAsync();

                totalRecords = await (from booking in _context.Bookings
                                      join bookingDetail in _context.BookingDetails on booking.Id equals bookingDetail.BookingId
                                      where bookingDetail.DentistId == dentistId &&
                                           booking.Status == Status.CONFIRMED && booking.Date.Month == month &&
                                            booking.Date.Year == year
                                      select new { booking })
                    .Distinct()
                    .CountAsync();
            }

            if (where.Contains("year"))
            {
                int year = int.Parse(where.Split('.')[1]);

                pagedData = await (from booking in _context.Bookings
                                   join bookingDetail in _context.BookingDetails on booking.Id equals bookingDetail.BookingId
                                   where bookingDetail.DentistId == dentistId &&
                                         booking.Status == Status.CONFIRMED && booking.Date.Year == year
                                   select new { booking })
                    .OrderBy("booking." + createdAt + " " + orderBy)
                    .Skip((filter.PageNumber - 1) * filter.PageSize)
                    .Distinct()
                    .Take(filter.PageSize)
                    .ToListAsync();

                totalRecords = await (from booking in _context.Bookings
                                      join bookingDetail in _context.BookingDetails on booking.Id equals bookingDetail.BookingId
                                      where bookingDetail.DentistId == dentistId &&
                                            booking.Status == Status.CONFIRMED && booking.Date.Year == year
                                      select new { booking })
                    .Distinct()
                    .CountAsync();
            }

            if (where.Contains("between"))
            {
                var startDate = DateTime.Parse(where.Split('.')[1]);
                var endDate = DateTime.Parse(where.Split('.')[2]);

                pagedData = await (from booking in _context.Bookings
                                   join bookingDetail in _context.BookingDetails on booking.Id equals bookingDetail.BookingId
                                   where bookingDetail.DentistId == dentistId &&
                                         booking.Status == Status.CONFIRMED && booking.Date >= startDate && booking.Date <= endDate
                                   select new { booking })
                    .OrderBy("booking." + createdAt + " " + orderBy)
                    .Skip((filter.PageNumber - 1) * filter.PageSize)
                    .Distinct()
                    .Take(filter.PageSize)
                    .ToListAsync();

                totalRecords = await (from booking in _context.Bookings
                                      join bookingDetail in _context.BookingDetails on booking.Id equals bookingDetail.BookingId
                                      where bookingDetail.DentistId == dentistId &&
                                            booking.Status == Status.CONFIRMED && booking.Date >= startDate && booking.Date <= endDate
                                      select new { booking })
                    .Distinct()
                    .CountAsync();
            }


            if (filter._all)
            {
                pagedData = await (from booking in _context.Bookings
                                   join bookingDetail in _context.BookingDetails on booking.Id equals bookingDetail.BookingId
                                   where bookingDetail.DentistId == dentistId &&
                                         booking.Status == Status.CONFIRMED
                                   select new { booking })
                    .OrderBy("booking." + createdAt + " " + orderBy)
                    .Skip((filter.PageNumber - 1) * filter.PageSize)
                    .Distinct()
                    .Take(filter.PageSize)
                    .ToListAsync();
                totalRecords = await (from booking in _context.Bookings
                                      join bookingDetail in _context.BookingDetails on booking.Id equals bookingDetail.BookingId
                                      where bookingDetail.DentistId == dentistId &&
                                            booking.Status == Status.CONFIRMED
                                      select new { booking })
                    .Distinct()
                    .CountAsync();
            }


            if (pagedData == null)
            {
                response.Content = null;
                response.Code = "200";
                response.Message = "There aren't any bookings in DB";
            }
            else
            {
                foreach (var x in pagedData)
                {
                    listDto.Add(mapToBookingDto(x.booking, dentistId));
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


        private BookingDTO mapToBookingDto(Booking booking, int dentistId)
        {
            BookingDTO bookingDto = new BookingDTO()
            {
                Date = booking.Date,
                Id = booking.Id,
                Status = booking.Status,
                Total = booking.Total,
                UserId = booking.UserId,
                User = MapToDTO(booking.UserId),
                Detail = GetDetailFromBooking(booking.Id, booking.Date, booking.Status, MapToDTO(booking.UserId), dentistId)
            };
            return bookingDto;
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
            };
            return bookingDto;
        }

        private BookingDetailDto MapToBookingDetailDto(BookingDetail bookingDetail)
        {
            var detailDto = new BookingDetailDto()
            {
                Id = bookingDetail.Id,
                Note = bookingDetail.Note,
                Services = GetService(bookingDetail.ServiceId),
                Status = bookingDetail.Status,
                KeyTime = bookingDetail.KeyTime,
                Dentist = MapToDentistDTO((int)bookingDetail.DentistId)
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
                Email = user.Email,
                ImageUrl = user.ImageUrl
            };

            return userDto;
        }

        private DentistDTO MapToDentistDTO(int dentistId)
        {
            var data = (from user in _context.Users
                        join dentist in _context.Dentists on user.DentistId equals dentist.Id
                        where user.DentistId == dentistId
                        select new { user, dentist }).FirstOrDefault();

            DentistDTO dto = new();
            if (data != null)
            {
                dto.Description = data.dentist?.Description;
                dto.Email = data.user.Email;
                dto.Gender = data.user.Gender;
                dto.Id = data.user.Id;
                dto.Dob = data.user.DOB;
                dto.Phone = data.user.PhoneNumber;
                dto.Status = data.user.Status;
                dto.FirstName = data.user.FirstName;
                dto.LastName = data.user.LastName;
                dto.ImageUrl = data.user.ImageUrl;
                dto.ClinicID = data.dentist.ClinicId;
                dto.DentistID = data.dentist.Id;
            }

            return dto;
        }




        private DentistServiceDto GetService(int serviceId)
        {
            var result = _context.Services.FirstOrDefault(x => x.Id == serviceId);

            DentistServiceDto dto = new();
            dto.Id = result.Id;
            dto.ServiceName = result.Name;

            return dto;
        }

        private List<BookingDtoDetail> GetDetailFromBooking(int bookingId, DateTime date, Status status,
            UserDTO userDto, int dentistId)
        {
            List<BookingDtoDetail> list = new();


            var data = _context.BookingDetails.Where(x => x.BookingId == bookingId && x.DentistId == dentistId).ToList();


            foreach (var x in data)
            {
                var serviceName = _context.Services.FirstOrDefault(y => y.Id == x.ServiceId)?.Name;
                if (serviceName != null)
                {
                    BookingDtoDetail detail = new()
                    {
                        Id = x.Id,
                        KeyTime = x.KeyTime,
                        Date = date,
                        Status = status,
                        User = userDto,
                        ServiceName = serviceName
                    };
                    list.Add(detail);
                }
            }

            return list;
        }

        public async Task<List<KeyTime>> GetAvailableKeyTime(int dentistId, DateTime date)
        {
            List<KeyTime> list = new();

            var details = await (from t1 in _context.Bookings
                                 join t2 in _context.BookingDetails
                                 on t1.Id equals t2.BookingId
                                 where t1.Date.Equals(date) && t2.DentistId == dentistId
                                 select t2).ToListAsync();
            list = Enum.GetValues(typeof(KeyTime)).Cast<KeyTime>().ToList();
            foreach (var item in details)
            {
                list.Remove(item.KeyTime);
            }
            return list;

        }

        public async Task<BookingResponse> UpdateBookingStatus(BookingStatusRequest request)
        {
            BookingResponse response = null;
            try
            {
                var booking = _context.Bookings.FirstOrDefault(x => x.Id == request.bookingID);
                if (booking != null)
                {
                    booking.Status = request.status;
                    response = new()
                    {

                        Code = "200",
                        Message = "Update status succesfull"
                    };

                    await _context.SaveChangesAsync();
                }
                else
                {
                    response = new()
                    {

                        Code = "203",
                        Message = "Not found "
                    };
                }
            }
            catch (Exception e)
            {
                response = new()
                {

                    Code = "203",
                    Message = "Update failed"
                };
            }

            return response;
        }

        public async Task<BookingResponse> UpdateBookingDetailStatus(BookingDetailStatusRequest request)
        {
            BookingResponse response = new();
            try
            {
                var detail = await _context.BookingDetails.FirstOrDefaultAsync(x => x.Id == request.bookingDetailID);
                var bookingId = detail.BookingId;
                var booking = await _context.Bookings.Where(x => x.Id == bookingId).FirstOrDefaultAsync();

                detail.Status = request.status;
                _context.SaveChanges();
                var count = _context.BookingDetails.Where(x => x.BookingId == bookingId && x.Status == Status.INACTIVE).Count();
                if (count == 0)
                {
                    booking.Status = Status.DONE;
                }


                response.Code = "200";
                response.Message = "Update successfully";
                await _context.SaveChangesAsync();
                return response;


            }
            catch (Exception e)
            {
                response = new()
                {

                    Code = "203",
                    Message = "Update failed"
                };
            }

            return response;
        }
    }
}