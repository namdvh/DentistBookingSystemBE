using DentistBooking.Application.System.Discounts;
using DentistBooking.ViewModels.Pagination;
using DentistBooking.ViewModels.System.Discounts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DentisBooking.Api.Controllers
{
    [Route("api/discounts")]
    [ApiController]
    [Authorize]
    public class DiscountsController : ControllerBase
    {
        private readonly IDiscountService _discountService;
        public DiscountsController(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDiscounts([FromQuery] PaginationFilter filter)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize, filter._by, filter._order);
            ListDiscountResponse result = await _discountService.GetDiscountList(validFilter);
            return Ok(result);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CreateDiscount([FromBody] DiscountRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            DiscountResponse result = await _discountService.CreateDiscount(request);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDiscount([FromBody] DiscountRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            DiscountResponse result = await _discountService.UpdateDiscount(request);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteDiscount([FromQuery] int discountId, Guid userId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            DiscountResponse result = await _discountService.DeleteDiscount(discountId, userId);
            return Ok(result);
        }
    }
}
