﻿using DentistBooking.Application.System.Bookings;
using DentistBooking.ViewModels.Pagination;
using DentistBooking.ViewModels.System.Bookings;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing;
using System.Collections.Generic;
using DentisBooking.Data.Enum;
using DentistBooking.ViewModels.System.Dentists;

namespace DentisBooking.Api.Controllers
{
    [Route("api/bookings")]
    [ApiController]
    //[Authorize]
    public class BookingController : ControllerBase
    {

        private readonly IBookingService _bookingService;
        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        [HttpPost()]
        [AllowAnonymous]
        public IActionResult CreateBooking([FromBody] CreateBookingRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            BookingResponse rs = _bookingService.CreateBooking(request);
            return Ok(rs);
        }

        [HttpGet("getallbooking")]
        public async Task<IActionResult> GetAllBooking([FromQuery] PaginationFilter filter)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize, filter._by, filter._order);
            ListBookingResponse result = await _bookingService.GetBookingList(validFilter);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBooking([FromBody] BookingRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            BookingResponse result = await _bookingService.UpdateBooking(request);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBooking([FromQuery] int bookingId, Guid userId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            BookingResponse result = await _bookingService.DeleteBooking(bookingId, userId);
            return Ok(result);
        }
        
        [HttpPut]
        [Route("status")]
        public async Task<IActionResult> UpdateBookingStatus([FromBody] BookingStatusRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            BookingResponse result = await _bookingService.UpdateBookingStatus(request);
            return Ok(result);
        }
        
        [HttpPut]
        [Route("detail/status")]
        public async Task<IActionResult> UpdateBookingDetailStatus([FromBody] BookingDetailStatusRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            BookingResponse result = await _bookingService.UpdateBookingDetailStatus(request);
            return Ok(result);
        }

        [HttpGet("getbookingdetail")]
        public async Task<IActionResult> GetBookingDetail([FromQuery] int bookingId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            BookingDetailResponse result = await _bookingService.GetBookingDetail(bookingId);
            return Ok(result);
        }
        
        [HttpGet]
        [Route("{userId}")]
        public async Task<IActionResult> GetAllBookingForUser([FromQuery] PaginationFilter filter, [FromRoute] Guid userId)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize, filter._by, filter._order);
            ListBookingResponse result = await _bookingService.GetBookingListForUser(validFilter, userId);
            return Ok(result);
        }
        
        [HttpGet("dentist/{dentistId}")]
        public async Task<IActionResult> GetBookingListDentist([FromQuery] PaginationFilter filter,int dentistId,string where)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize, filter._by, filter._order,filter._all);
            
            var result = await _bookingService.GetBookingListForDentist(validFilter,dentistId,where);
        
            return Ok(result);
        }

        [HttpGet("available")]
        public async Task<IActionResult> GetBookingDetail([FromQuery] int dentistId, DateTime date)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            List<KeyTime> result = await _bookingService.GetAvailableKeyTime(dentistId, date);
            return Ok(result);
        }
    }
}
