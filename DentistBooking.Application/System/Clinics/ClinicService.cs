using AutoMapper;
using DentisBooking.Data.DataContext;
using DentisBooking.Data.Entities;
using DentistBooking.ViewModels.Pagination;
using DentistBooking.ViewModels.System.Clinics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;


namespace DentistBooking.Application.System.Clinics
{
    public class ClinicService : IClinicService
    {
        private readonly DentistDBContext _context;
        private readonly IMapper _mapper;

        public ClinicService(DentistDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ListClinicResponse> GetClinicList(PaginationFilter filter)
        {
            ListClinicResponse response = new();
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
            List<Clinic> pagedData;
            if (filter._all)
            {
                pagedData = await _context.Clinics
                   .OrderBy(filter._by + " " + orderBy)
                   .ToListAsync();
            }
            else
            {
                pagedData = await _context.Clinics
                   .OrderBy(filter._by + " " + orderBy)
                   .Skip((filter.PageNumber - 1) * filter.PageSize)
                   .Take(filter.PageSize)
                   .ToListAsync();
            }


            var totalRecords = await _context.Clinics.CountAsync(x => x.Status != DentisBooking.Data.Enum.Status.INACTIVE);

            if (!pagedData.Any())
            {
                response.Content = null;
                response.Code = "200";
                response.Message = "There aren't any clinics in DB";
            }
            else
            {
                List<ClinicDTO> result = new List<ClinicDTO>();
                foreach (Clinic x in pagedData)
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

            paginationDTO.CurrentPage = filter.PageNumber;

            paginationDTO.PageSize = filter._all == false ? filter.PageSize : totalRecords;

            paginationDTO.TotalPages = roundedTotalPages;
            paginationDTO.TotalRecords = totalRecords;

            response.Pagination = paginationDTO;



            return response;

        }


        public ClinicDTO MapToDTO(Clinic clinic)
        {
            ClinicDTO clinicDTO = new ClinicDTO()
            {
                Id = clinic.Id,
                Address = clinic.Address,
                Description = clinic.Description,
                Name = clinic.Name,
                Phone = clinic.Phone,
                Status = clinic.Status,
                ImageUrl = clinic.ImageUrl,
                Created_at = clinic.Created_at,
                Updated_at = (DateTime)clinic.Updated_at,
                Deleted_at = (DateTime)clinic.Deleted_at,
                Created_by = (Guid)clinic.Created_by,
                Deleted_by = (Guid)clinic.Deleted_by,
                Updated_by = (Guid)clinic.Updated_by,

            };
            return clinicDTO;
        }

        public async Task<ClinicResponse> CreateClinic(ClinicRequest request)
        {
            ClinicResponse response = new ClinicResponse();
            try
            {
                Clinic clinic = new Clinic()
                {
                    Name = request.Name,
                    Address = request.Address,
                    Phone = request.Phone,
                    Description = request.Description,
                    Status = DentisBooking.Data.Enum.Status.ACTIVE,
                    ImageUrl = null,
                    Created_at = DateTime.Parse(DateTime.Now.ToString("yyyy/MMM/dd")),
                    Created_by = request.UserId
                };

                _context.Clinics.Add(clinic);
                await _context.SaveChangesAsync();

                response.Code = "200";
                response.Message = "Create clinic successfully";

                return response;
            }
            catch (DbUpdateException)
            {
                response.Code = "200";
                response.Message = "Create clinic failed";

                return response;
            }

        }
        public async Task<ClinicResponse> UpdateClinic(ClinicRequest request)
        {
            ClinicResponse response = new ClinicResponse();

            try
            {
                Clinic obj = await _context.Clinics.Where(g => g.Id == request.Id).SingleOrDefaultAsync();
                if (obj != null)
                {
                    string images ="";
                    if(request.ImageUrl.Count != 1)
                    {
                        for (int i = 0; i < request.ImageUrl.Count; i++)
                        {
                            if (i == 0)
                            {
                                images = request.ImageUrl[0];
                            }
                            else
                            {
                                images = String.Concat(images, ";", request.ImageUrl[i]);

                            }
                        }
                    }
                    else
                    {
                        images = request.ImageUrl[0];
                    }
                    
                    obj.Name = request.Name;
                    obj.Address = request.Address;
                    obj.Phone = request.Phone;
                    obj.Description = request.Description;
                    obj.ImageUrl = images;
                    obj.Updated_at = DateTime.Parse(DateTime.Now.ToString("yyyy/MMM/dd"));
                    obj.Updated_by = request.UserId;

                    await _context.SaveChangesAsync();
                    response.Code = "200";
                    response.Message = "Update clinic successfully";

                    return response;

                }
                else
                {
                    response.Code = "200";
                    response.Message = "Can not find that clinic";

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

        public async Task<ClinicResponse> DeleteClinic(int clinicId, Guid userId)
        {
            ClinicResponse response = new ClinicResponse();

            try
            {
                Clinic obj = await _context.Clinics.FindAsync(clinicId);
                if (obj != null)
                {
                    obj.Deleted_by = userId;
                    obj.Deleted_at = DateTime.Parse(DateTime.Now.ToString("yyyy/MMM/dd"));
                    obj.Status = DentisBooking.Data.Enum.Status.INACTIVE;

                    await _context.SaveChangesAsync();

                    response.Code = "200";
                    response.Message = "Delete clinic successfully";

                    return response;
                }
                else
                {
                    response.Code = "200";
                    response.Message = "Can not find that clinic";

                    return response;
                }

            }
            catch (DbUpdateException)
            {

                response.Code = "200";
                response.Message = "Delete clinic failed";

                return response;
            }
        }


    }
}
