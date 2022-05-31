using DentistBooking.Application.ClaimTokens;
using DentistBooking.Application.System.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DentisBooking.Api.Controllers
{
    [Route("api/getProfile")]
    [ApiController]
    [Authorize]
    public class ProfileController : ControllerBase
    {
        private readonly IUserService _userService;
        public ProfileController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost()]
        [AllowAnonymous]
        public async Task<IActionResult> GetProfile([FromBody] RefreshToken refreshToken)
        {
            var rs = await _userService.GetProfile(refreshToken);

            return Ok(rs);
        }
    }
}
