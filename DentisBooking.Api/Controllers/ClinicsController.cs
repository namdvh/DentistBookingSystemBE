using DentistBooking.Application.System.Clinics;
using DentistBooking.ViewModels.Pagination;
using DentistBooking.ViewModels.System.Clinics;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DentisBooking.Api.Controllers
{
    [Route("api/clinics")]
    [ApiController]
    public class ClinicsController : ControllerBase
    {
        private readonly IClinicService _clinicService;
        public ClinicsController(IClinicService clinicService)
        {
            _clinicService = clinicService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllClinics([FromQuery] PaginationFilter filter)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize,filter.OrderBy,filter.SortBy);
            ClinicResponse result = await _clinicService.GetClinicList(validFilter);
            return Ok(result);
        }
    }
}
