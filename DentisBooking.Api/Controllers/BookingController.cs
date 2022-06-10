using DentistBooking.Application.System.Bookings;
using DentistBooking.ViewModels.Pagination;
using DentistBooking.ViewModels.System.Bookings;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DentisBooking.Api.Controllers
{
    [Route("api/bookings")]
    [ApiController]
    [Authorize]
    public class BookingController : ControllerBase
    {

        private readonly IBookingService _bookingService;
        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        [HttpPost()]
        [AllowAnonymous]
        public async Task<IActionResult> CreateBooking([FromBody] CreateBookingRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            BookingResponse rs = await _bookingService.CreateBooking(request);
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
    }
}
