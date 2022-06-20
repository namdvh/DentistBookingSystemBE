using DentisBooking.Data.DataContext;
using DentistBooking.ViewModels.Pagination;
using DentistBooking.ViewModels.System.Discounts;
using DentisBooking.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;
using DentisBooking.Data.Enum;
using Microsoft.EntityFrameworkCore;
using DentistBooking.Application.System.Discounts;

namespace DentistBooking.Application.System.Discounts
{
    public class DiscountService : IDiscountService
    {
        private readonly DentistDBContext _context;

        public DiscountService(DentistDBContext context)
        {
            _context = context;
        }
        public async Task<ListDiscountResponse> GetDiscountList(PaginationFilter filter)
        {
            ListDiscountResponse response = new();
            PaginationDTO paginationDTO = new();

            string orderBy = filter._order.ToString();

            if (orderBy.Equals("1"))
            {
                orderBy = "descending";
            }
            else if (orderBy.Equals("-1"))
            {
                orderBy = "ascending";
            }
            var pagedData = await _context.Discounts
                    .OrderBy(filter._by + " " + orderBy)
                    .Skip((filter.PageNumber - 1) * filter.PageSize)
                    .Take(filter.PageSize)
                    .ToListAsync();

            var totalRecords = await _context.Discounts.CountAsync();

            if (!pagedData.Any())
            {
                response.Content = null;
                response.Code = "200";
                response.Message = "There aren't any discount in DB";
            }
            else
            {
   
                response.Content = pagedData;
                response.Message = "SUCCESS";
                response.Code = "200";

            }
            var totalPages = ((double)totalRecords / (double)filter.PageSize);
            int roundedTotalPages = Convert.ToInt32(Math.Ceiling(totalPages));

            paginationDTO.CurrentPage = filter.PageNumber;
            paginationDTO.PageSize = filter.PageSize;
            paginationDTO.TotalPages = roundedTotalPages;
            paginationDTO.TotalRecords = totalRecords;

            response.Pagination = paginationDTO;



            return response;

        }

        public async Task<DiscountResponse> CreateDiscount(DiscountRequest request)
        {
            DiscountResponse response = new DiscountResponse();
            try
            {
                Discount discount = new Discount()
                {
                    Title = request.Title,
                    StartDate = request.StartDate,
                    EndDate = request.EndDate,
                    Description = request.Description,
                    Percent = request.Percent,
                    Amount = request.Amount,
                    status = DentisBooking.Data.Enum.Status.ACTIVE,
                    ApplyForAll = request.ApplyForAll,
                    Created_at = DateTime.Parse(DateTime.Now.ToString("yyyy/MMM/dd")),
                    Created_by = request.UserId
                };

                _context.Discounts.Add(discount);
                await _context.SaveChangesAsync();

                response.Code = "200";
                response.Message = "Create discount successfully";

                return response;
            }
            catch (DbUpdateException)
            {
                response.Code = "200";
                response.Message = "Create discount failed";

                return response;
            }

        }
        public async Task<DiscountResponse> UpdateDiscount(DiscountRequest request)
        {
            DiscountResponse response = new DiscountResponse();

            try
            {
                Discount obj = await _context.Discounts.Where(g => g.Id == request.Id).SingleOrDefaultAsync();
                if (obj != null)
                {
                    obj.Title = request.Title;
                    obj.StartDate = request.StartDate;
                    obj.EndDate = request.EndDate;
                    obj.Description = request.Description;
                    obj.Percent = request.Percent;
                    obj.Amount = request.Amount;
                    obj.ApplyForAll = request.ApplyForAll;
                    obj.Updated_at = DateTime.Parse(DateTime.Now.ToString("yyyy/MMM/dd"));
                    obj.Updated_by = request.UserId;

                    await _context.SaveChangesAsync();
                    response.Code = "200";
                    response.Message = "Update discount successfully";

                    return response;

                }
                else
                {
                    response.Code = "200";
                    response.Message = "Can not find that discount";

                    return response;
                }

            }
            catch (DbUpdateException)
            {

                response.Code = "200";
                response.Message = "Update discount failed";

                return response;
            }

        }

        public async Task<DiscountResponse> DeleteDiscount(int discountId)
        {
            var response = new DiscountResponse();
            var discount = _context.Discounts.FirstOrDefault(x => x.Id == discountId);

            if (discount == null)
            {
                response.Code = "404";
                response.Message = "Error";
                return response;
            }

            if (discount.status == Status.INACTIVE)
            {
                discount.Deleted_at = null;
                discount.status = Status.ACTIVE;
            }
            else
            {
                discount.Deleted_at = DateTime.Parse(DateTime.Now.ToString("yyyy/MMM/dd"));
                discount.status = Status.INACTIVE;
            }

            await _context.SaveChangesAsync();
            response.Code = "200";
            response.Message = "Delete successfully";


            return response;
        }
    }
}
