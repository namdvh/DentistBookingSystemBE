using DentistBooking.Application.System.Clinics;
using DentistBooking.ViewModels.Pagination;
using DentistBooking.ViewModels.System.Clinics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DentisBooking.Api.Controllers
{
    [Route("api/clinics")]
    [ApiController]
    [Authorize]
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
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize, filter._by, filter._order);
            ListClinicResponse result = await _clinicService.GetClinicList(validFilter);
            return Ok(result);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CreateClinic([FromBody] ClinicRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            ClinicResponse result = await _clinicService.CreateClinic(request);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateClinic([FromBody] ClinicRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            ClinicResponse result = await _clinicService.UpdateClinic(request);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteClinic([FromQuery] string clinicId, Guid userId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            ClinicResponse result = await _clinicService.DeleteClinic(clinicId, userId);
            return Ok(result);
        }
    }
}
