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
using DentisBooking.Data.Enum;
using FluentValidation.Results;
using Microsoft.AspNetCore.Identity;

namespace DentistBooking.Application.System.Dentists
{
    public class DentistService : IDentistService
    {
        private readonly DentistDBContext _context;
        private readonly UserManager<User> _dentistService;

        public DentistService(DentistDBContext context, UserManager<User> dentistService)
        {
            _context = context;
            _dentistService = dentistService;
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

        public async Task<DentistResponse> CreateDentist(AddDentistRequest request)
        {
            var response = new DentistResponse();
            var validator = new AddDentistRequestValidator();
            response.Errors = new();
            var results = await validator.ValidateAsync(request);

            if (!results.IsValid)
            {
                response.Content = null;
                response.Code = "200";
                foreach (var failure in results.Errors)
                {
                    response.Errors.Add(failure.ErrorMessage.ToString());
                }

                return response;
            }

            var newDentist = new Dentist()
            {
                ClinicId = request.ClinicId,
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                UserName = request.UserName,
                PhoneNumber = request.PhoneNumber,
                Status = request.Status,
                Gender = request.Gender,
                Description = request.Description,
                Position = request.Position,
            };

            //var rs = await _dentistService.CreateAsync(newDentist, request.Password);
            // if (rs.Succeeded)
            // {
            //         
            //     response.Code = "200";
            //     response.Message= "Register successfully";
            //
            //     return response;
            // }
            response.Content = null;
            response.Code = "200";
            response.Message = "Register failed";

            return response;
        }

        public async Task<DentistResponse> UpdateDentist(UpdateDentistRequest request)
        {
            var response = new DentistResponse();
            var dentist = _context.Dentists.FirstOrDefault(x => x.Id == request.Id);
            var clinic = _context.Clinics.FirstOrDefault(x => x.Id == request.ClinicId);
            if (dentist != null)
            {
                if (clinic != null) dentist.Clinic = clinic;
                dentist.UserName = request.UserName;
                dentist.Email = request.Email;
                dentist.PhoneNumber = request.PhoneNumber;
                dentist.FirstName = request.FirstName;
                dentist.LastName = request.LastName;
                if (request.Gender != null) dentist.Gender = (Gender)request.Gender;
                if (request.Status != null) dentist.Status = (Status)request.Status;
                if (request.Position != null) dentist.Position = (Position)request.Position;
                dentist.Updated_by = request.Updated_By;
                dentist.Description = request.Description;
            }

            await _context.SaveChangesAsync();
            response.Code = "200";
            response.Message = "Updated successfully";

            return response;
        }

        public async Task<DentistResponse> DeleteDentist(Guid dentistId, Guid deletedBy)
        {
            var response = new DentistResponse();
            var dentist = _context.Dentists.FirstOrDefault(x => x.Id == dentistId);

            if (dentist == null)
            {
                return response;
            }

            dentist.Deleted_by = deletedBy;
            _context.Dentists.Update(dentist);
            await _context.SaveChangesAsync();
            response.Code = "200";
            //response.Message = "Delete successfully";


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