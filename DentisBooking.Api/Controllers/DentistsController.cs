using DentistBooking.Application.System.Dentists;
using DentistBooking.ViewModels.Pagination;
using DentistBooking.ViewModels.System.Dentists;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
        public async Task<IActionResult> GetAllDentitst([FromQuery] PaginationFilter filter)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize,filter.OrderBy,filter.SortBy);
            DentistResponse result = await _dentistService.GetDentistList(validFilter);
            return Ok(result);
        }
    }
}
