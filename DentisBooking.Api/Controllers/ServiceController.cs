﻿using System;
using System.Threading.Tasks;
using DentistBooking.Application.System.Services;
using DentistBooking.ViewModels.Pagination;
using DentistBooking.ViewModels.System.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DentisBooking.Api.Controllers
{
    [Route("api/services")]
    [ApiController]
    [Authorize]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;
        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllServices([FromQuery] PaginationFilter filter)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize, filter._by, filter._order, filter._all);
            var result = await _serviceService.GetServiceList(validFilter);
            return Ok(result);
        }
        [HttpGet("user")]
        public async Task<IActionResult> GetAllServicesForUser([FromQuery] PaginationFilter filter)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize, filter._by, filter._order, filter._all);
            var result = await _serviceService.GetServiceListForUser(validFilter);
            return Ok(result);
        }
        

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CreateService([FromBody] AddServiceRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _serviceService.CreateService(request);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateService([FromBody] ServiceRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _serviceService.UpdateService(request);
            return Ok(result);
        }
        
        [HttpGet]
        [Route("{serviceId}")]
        public async Task<IActionResult> GetService([FromRoute] int serviceId)
        {
            var result = await _serviceService.GetService(serviceId);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteService([FromQuery] int serviceId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _serviceService.DeleteService(serviceId);
            return Ok(result);
        }
    }
}
