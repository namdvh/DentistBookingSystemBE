﻿using System;
using DentistBooking.Application.System.Dentists;
using DentistBooking.ViewModels.Pagination;
using DentistBooking.ViewModels.System.Dentists;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DentisBooking.Data.Entities;

namespace DentisBooking.Api.Controllers
{
    [Route("api/dentists")]
    [ApiController]
    //[TypeFilter(typeof(AuthorizeMiddleWare))]
    //[Authorize]
    public class DentistsController : ControllerBase
    {
        private readonly IDentistService _dentistService;

        public DentistsController(IDentistService dentistService)
        {
            _dentistService = dentistService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDentist([FromQuery] PaginationFilter filter)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize, filter._by, filter._order,
                filter._all);
            var result = await _dentistService.GetDentistList(validFilter);
            return Ok(result);
        }
        
        [HttpGet("user")]
        public async Task<IActionResult> GetAllDentistUser([FromQuery] PaginationFilter filter)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize, filter._by, filter._order,
                filter._all);
            var result = await _dentistService.GetDentistListForUser(validFilter);
            return Ok(result);
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchDentist([FromQuery] PaginationFilter filter, string keyword)
        {
            DentistResponse result = new();
            if (keyword != null)
            {
                var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize, filter._by, filter._order);
                result = await _dentistService.SearchDentist(validFilter, keyword);
            }

            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> AddNewDentist([FromBody] AddDentistRequest newDentist)
        {
            var result = await _dentistService.CreateDentist(newDentist);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDentist([FromBody] UpdateDentistRequest newDentist)
        {
            var result = await _dentistService.UpdateDentist(newDentist);
            return Ok(result);
        }

        [HttpDelete]
        [Route("{dentistID}")]
        public async Task<IActionResult> RemoveDentist([FromRoute] int dentistID)
        {
            var result = await _dentistService.DeleteDentist(dentistID);
            return Ok(result);
        }
        [HttpGet]
        [Route("{dentistID}")]
        public async Task<IActionResult> GetDentist([FromRoute] Guid dentistID)
        {
            DentistClinicResponse result = await _dentistService.GetDentist(dentistID);
            return Ok(result);
        }
                

    }
}
