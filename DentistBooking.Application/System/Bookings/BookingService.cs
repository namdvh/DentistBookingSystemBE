﻿using DentisBooking.Data.DataContext;
using DentisBooking.Data.Entities;
using DentistBooking.ViewModels.System.Bookings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBooking.Application.System.Bookings
{
    public class BookingService : IBookingService
    {
        private readonly DentistDBContext _context;

        public BookingService(DentistDBContext context)
        {
            _context = context;
        }

        public async Task<BookingResponse> CreateBooking(BookingRequest request)
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
    }
}