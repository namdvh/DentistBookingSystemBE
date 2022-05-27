using DentistBooking.Application.ClaimTokens;
using DentistBooking.Application.System.Users;
using DentistBooking.ViewModels.System.Users;
using Microsoft.AspNetCore.Authorization;
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
        public async Task<IActionResult> Authenticate([FromBody]LoginRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var token=await _userService.Authenticate(request);
            if(token==null){
                return Ok(new
                {
                    code = 400,
                    Message = "Username or Password is Incorrect"
                });
            }
            return Ok(token);
        }
        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            RegisterResponse rs = await _userService.Register(request);
            return Ok(rs);
        }

        [HttpPost("refresh")]
        [AllowAnonymous]
        public async Task<IActionResult> RefreshToken([FromBody] Token tokenModel)
        {
            var rs = await _userService.RefreshToken(tokenModel);

            return Ok(rs);
        }
    }
}
