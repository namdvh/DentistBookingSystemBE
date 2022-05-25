using DentistBooking.Application.System.Dentists;
using DentistBooking.ViewModels.Pagination;
using DentistBooking.ViewModels.System.Dentists;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Web.Http.Description;

namespace DentisBooking.Api.Controllers
{
    [Route("api/dentists")]
    [ApiController]
    [Authorize]
    public class DentistsController : ControllerBase
    {
        private readonly IDentistService _dentistService;
        public DentistsController(IDentistService dentistService)
        {
            _dentistService = dentistService;
        }

        [HttpGet]
        [ResponseType(typeof(DentistResponse))]
        public async Task<IActionResult> GetAllDentitst([FromQuery] PaginationFilter filter)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            DentistResponse result = await _dentistService.GetDentistList(validFilter);
            return Ok(result);
        }
    }
}
