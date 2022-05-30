using AutoMapper;
using DentisBooking.Data.DataContext;
using DentisBooking.Data.Entities;
using DentistBooking.ViewModels.Pagination;
using DentistBooking.ViewModels.System.Dentists;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;

namespace DentistBooking.Application.System.Dentists
{
    public class DentistService : IDentistService
    {
        private readonly DentistDBContext _context;
        private readonly IMapper _mapper;

        public DentistService(DentistDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<DentistResponse> GetDentistList(PaginationFilter filter)
        {
            DentistResponse response = new();
            PaginationDTO paginationDto = new(); 

            var orderBy = filter._order.ToString();

            orderBy = orderBy switch
            {
                "1" => "descending",
                "-1" => "ascending",
                _ => orderBy
            };
            
            
            var pagedData = await _context.Dentists
                    .OrderBy(filter._by + " " + orderBy)
                    .Skip((filter.PageNumber - 1) * filter.PageSize)
                    .Take(filter.PageSize)
                    .Where(x => x.Deleted_by != null)
                    .ToListAsync();

            var totalRecords = await _context.Dentists.CountAsync();

            if (!pagedData.Any())
            {
                response.Content = null;
                response.Code = "200";
                response.Message = "There aren't any dentists in DB";
            }
            else
            {
                var result = pagedData.Select(MapToDto).ToList();
                response.Content = result;
                response.Message = "SUCCESS";
                response.Code = "200";

            }
            var totalPages = ((double)totalRecords / (double)filter.PageSize);
            var roundedTotalPages = Convert.ToInt32(Math.Ceiling(totalPages));

            paginationDto.CurrentPage = filter.PageNumber;
            paginationDto.PageSize = filter.PageSize;
            paginationDto.TotalPages = roundedTotalPages;
            paginationDto.TotalRecords = totalRecords;

            response.Pagination = paginationDto;



            return response;

        }


        private DentistDTO MapToDto(Dentist dentist)
        {
            var dentistDto = new DentistDTO()
            {
                Id = dentist.Id,
                Email = dentist.Email,
                FirstName = dentist.FirstName,
                LastName = dentist.LastName,
                Gender = dentist.Gender,
                Phone = dentist.PhoneNumber,
                Token = dentist.Token,
                Status = dentist.Status,
                Position = dentist.Position,
                Description = dentist.Description,
                Created_at = dentist.Created_at,
                Updated_at = (DateTime)dentist.Updated_at,
                Deleted_at = (DateTime)dentist.Deleted_at,
                Created_by = (Guid)dentist.Created_by,
                Deleted_by = (Guid)dentist.Deleted_by,
                Updated_by = (Guid)dentist.Updated_by,

            };
            return dentistDto;
        }


    }
}
