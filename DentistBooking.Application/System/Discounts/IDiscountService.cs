using DentistBooking.ViewModels.Pagination;
using DentistBooking.ViewModels.System.Discounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBooking.Application.System.Discounts
{
    public interface IDiscountService
    {
        Task<ListDiscountResponse> GetDiscountList(PaginationFilter filter);
        Task<DiscountResponse> CreateDiscount(DiscountRequest request);
        Task<DiscountResponse> UpdateDiscount(DiscountRequest request);
        Task<DiscountResponse> DeleteDiscount(int discountId, Guid userId);
    }
}
