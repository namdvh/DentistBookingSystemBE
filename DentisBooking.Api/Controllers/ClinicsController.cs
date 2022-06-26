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
    //[Authorize]
    public class ClinicsController : ControllerBase
    {
        private readonly IClinicService _clinicService;
        public ClinicsController(IClinicService clinicService)
        {
            _clinicService = clinicService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllClinics([FromQuery] PaginationFilter filter)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize, filter._by, filter._order, filter._all);
            ListClinicResponse result = await _clinicService.GetClinicList(validFilter);
            return Ok(result);
        }
        [HttpGet("dentist")]
        public async Task<IActionResult> GetClinicsForUpdateDentist([FromQuery] int dentistId)
        {
            ListClinicResponse result = await _clinicService.GetClinicListForUpdateDentist(dentistId);
            return Ok(result);
        }
        
        [HttpGet("booking")]
        public async Task<IActionResult> GetClinicsForBooking([FromQuery] PaginationFilter filter)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize, filter._by, filter._order, filter._all);
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
        
        [HttpGet]
        [Route("{clinicID}")]
        public async Task<IActionResult> GetClinic([FromRoute] int clinicID)
        {
            var result = await _clinicService.GetClinic(clinicID);
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
        public async Task<IActionResult> DeleteClinic([FromQuery] int clinicId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            ClinicResponse result = await _clinicService.DeleteClinic(clinicId);
            return Ok(result);
        }
    }
}
