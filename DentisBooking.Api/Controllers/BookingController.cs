using DentistBooking.Application.System.Bookings;
using DentistBooking.ViewModels.System.Bookings;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DentisBooking.Api.Controllers
{
    [Route("api/[bookings]")]
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
        public async Task<IActionResult> CreateBooking([FromBody] BookingRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            BookingResponse rs = await _bookingService.CreateBooking(request);
            return Ok(rs);
        }
    }
}
