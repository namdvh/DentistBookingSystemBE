using DentistBooking.Application.System.Users;
using DentistBooking.ViewModels.System.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DentisBooking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost("authenticate")]
        [AllowAnonymous]
        public async Task<IActionResult> Authenticate([FromForm]LoginRequest request)
        {
            if (ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var rsToken=await _userService.Authenticate(request);
            if(string.IsNullOrEmpty(rsToken)) {
                return BadRequest("Username or Password is Incorrect");
            }
            return Ok(new { token =rsToken });
        }
        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromForm] RegisterRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var rs = await _userService.Register(request);
            if (!rs)
            {
                return BadRequest("Register unsuccessfull");
            }
            return Ok();
        }
    }
}
