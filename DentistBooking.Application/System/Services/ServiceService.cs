using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using DentisBooking.Data.DataContext;
using DentisBooking.Data.Entities;
using DentisBooking.Data.Enum;
using DentistBooking.ViewModels.Pagination;
using DentistBooking.ViewModels.System.Clinics;
using DentistBooking.ViewModels.System.Services;
using Microsoft.EntityFrameworkCore;

namespace DentistBooking.Application.System.Services
{
    public class ServiceService : IServiceService
    {
        private readonly DentistDBContext _context;

        public ServiceService(DentistDBContext context)
        {
            _context = context;
        }


        public async Task<ListServiceResponse> GetServiceList(PaginationFilter filter)
        {
            ListServiceResponse response = new();
            PaginationDTO paginationDto = new();

            var orderBy = filter._order.ToString();

            orderBy = orderBy switch
            {
                "1" => "descending",
                "-1" => "ascending",
                _ => orderBy
            };

            List<Service> pagedData;

            if (filter._all)
            {
                pagedData = await _context.Services
                    .OrderBy(filter._by + " " + orderBy)
                    .ToListAsync();
            }
            else
            {
                pagedData = await _context.Services
                    .OrderBy(filter._by + " " + orderBy)
                    .Skip((filter.PageNumber - 1) * filter.PageSize)
                    .Take(filter.PageSize)
                    .ToListAsync();
            }

            var totalRecords =
                await _context.Services.CountAsync(x => x.Status != Status.INACTIVE && x.Deleted_by == null);

            if (!pagedData.Any())
            {
                response.Content = null;
                response.Code = "200";
                response.Message = "There aren't any clinics in DB";
            }
            else
            {
                var result = new List<ServiceDto>();
                foreach (var x in pagedData)
                {
                    result.Add(MapToDTO(x));
                }

                response.Content = result;
                response.Message = "SUCCESS";
                response.Code = "200";
            }

            double totalPages;

            if (filter._all == false)
            {
                totalPages = ((double)totalRecords / (double)filter.PageSize);
            }
            else
            {
                totalPages = 1;
            }

            var roundedTotalPages = Convert.ToInt32(Math.Ceiling(totalPages));

            paginationDto.CurrentPage = filter.PageNumber;

            paginationDto.PageSize = filter._all == false ? filter.PageSize : totalRecords;

            paginationDto.TotalPages = roundedTotalPages;
            paginationDto.TotalRecords = totalRecords;

            response.Pagination = paginationDto;


            return response;
        }

        public async Task<ListServiceResponse> GetServiceListForUser(PaginationFilter filter)
        {
            ListServiceResponse response = new();
            PaginationDTO paginationDto = new();

            var orderBy = filter._order.ToString();

            orderBy = orderBy switch
            {
                "1" => "descending",
                "-1" => "ascending",
                _ => orderBy
            };

            List<Service> pagedData;

            if (filter._all)
            {
                pagedData = await _context.Services
                    .OrderBy(filter._by + " " + orderBy)
                    .Where(x => x.Status != Status.INACTIVE)
                    .ToListAsync();
            }
            else
            {
                pagedData = await _context.Services
                    .OrderBy(filter._by + " " + orderBy)
                    .Where(x => x.Status != Status.INACTIVE)
                    .Skip((filter.PageNumber - 1) * filter.PageSize)
                    .Take(filter.PageSize)
                    .ToListAsync();
            }

            var totalRecords =
                await _context.Services.CountAsync(x => x.Status != Status.INACTIVE && x.Deleted_by == null);

            if (!pagedData.Any())
            {
                response.Content = null;
                response.Code = "200";
                response.Message = "There aren't any clinics in DB";
            }
            else
            {
                var result = new List<ServiceDto>();
                foreach (var x in pagedData)
                {
                    result.Add(MapToDTO(x));
                }

                response.Content = result;
                response.Message = "SUCCESS";
                response.Code = "200";
            }

            double totalPages;

            if (filter._all == false)
            {
                totalPages = ((double)totalRecords / (double)filter.PageSize);
            }
            else
            {
                totalPages = 1;
            }

            var roundedTotalPages = Convert.ToInt32(Math.Ceiling(totalPages));

            paginationDto.CurrentPage = filter.PageNumber;

            paginationDto.PageSize = filter._all == false ? filter.PageSize : totalRecords;

            paginationDto.TotalPages = roundedTotalPages;
            paginationDto.TotalRecords = totalRecords;

            response.Pagination = paginationDto;


            return response;
        }

        public async Task<ServiceDtoResponse> GetService(int id)
        {
            ServiceDtoResponse response = new();
            try
            {
                var service = await _context.Services.FirstOrDefaultAsync(x => x.Id == id);
                if (service == null)
                {
                    response.Message = "Not found";
                    response.Code = "404";
                }

                response.Service = MapToDTO(service);
                response.Code = "200";
                response.Message = "SUCCESS";

                return response;
            }
            catch (Exception e)
            {
                response.Code = "500";
                response.Message = e.Message;
                return response;
            }
        }

        public async Task<ServiceResponse> CreateService(AddServiceRequest request)
        {
            var response = new ServiceResponse();

            Discount discount = null;

            if (request.DiscountId != null)
            {
                discount = _context.Discounts.FirstOrDefault(x => x.Id == request.DiscountId);
            }

            try
            {
                var service = new Service();

                if (discount != null)
                {
                    service.Discount = discount;
                }

                service.Name = request.Name;
                service.Created_by = request.UserId;
                service.Status = Status.ACTIVE;
                service.Price = request.Price;
                service.Procedure = request.Procedure;
                service.Price = request.Price;

                _context.Services.Add(service);
                await _context.SaveChangesAsync();

                response.Code = "200";
                response.Message = "Create Service successfully";

                return response;
            }
            catch (DbUpdateException)
            {
                response.Code = "200";
                response.Message = "Create Service failed";

                return response;
            }
        }

        public async Task<ServiceResponse> UpdateService(ServiceRequest request)
        {
            var response = new ServiceResponse();

            Discount discount = null;

            if (request.DiscountId != null)
            {
                discount = _context.Discounts.FirstOrDefault(x => x.Id == request.DiscountId);
            }

            try
            {
                var obj = _context.Services.Where(g => g.Id == request.Id).SingleOrDefault();
                if (obj != null)
                {
                    obj.Name = request.Name;
                    obj.Status = request.Status;
                    obj.Updated_at = DateTime.Parse(DateTime.Now.ToString("yyyy/MMM/dd"));
                    if (discount != null)
                    {
                        obj.Discount = discount;
                    }

                    obj.Updated_by = request.UserId;
                    obj.Price = request.Price;
                    obj.Procedure = request.Procedure;

                    await _context.SaveChangesAsync();
                    response.Code = "200";
                    response.Message = "Update services successfully";

                    return response;
                }
                else
                {
                    response.Code = "200";
                    response.Message = "Can not find that service";

                    return response;
                }
            }
            catch (DbUpdateException)
            {
                response.Code = "200";
                response.Message = "Update clinic failed";

                return response;
            }
        }

        public async Task<ServiceResponse> DeleteService(int serviceID, Guid userId)
        {
            var response = new ServiceResponse();

            try
            {
                Service obj = _context.Services.FirstOrDefault(x => x.Id == serviceID);
                if (obj != null)
                {
                    obj.Deleted_by = userId;
                    obj.Deleted_at = DateTime.Parse(DateTime.Now.ToString("yyyy/MMM/dd"));
                    obj.Status = Status.INACTIVE;

                    await _context.SaveChangesAsync();

                    response.Code = "200";
                    response.Message = "Delete service successfully";

                    return response;
                }
                else
                {
                    response.Code = "200";
                    response.Message = "Can not find that service";

                    return response;
                }
            }
            catch (DbUpdateException)
            {
                response.Code = "200";
                response.Message = "Delete service failed";

                return response;
            }
        }

        private ServiceDto MapToDTO(Service service)
        {
            var serviceDto = new ServiceDto()
            {
                Id = service.Id,
                Procedure = service.Procedure,      
                ServiceName = service.Name,
                Price = service.Price,
                Status = service.Status
            };
            return serviceDto;
        }
    }
}