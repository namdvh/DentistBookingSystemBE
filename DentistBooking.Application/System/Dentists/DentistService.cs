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
using DentistBooking.ViewModels.System.Users;
using FluentValidation.Results;
using Microsoft.AspNetCore.Identity;

namespace DentistBooking.Application.System.Dentists
{
    public class DentistService : IDentistService
    {
        private readonly DentistDBContext _context;
        // private readonly UserManager<Dentist> _dentistService;

        public DentistService(DentistDBContext context)
        {
            _context = context;
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


            // var pagedData = await _context.Users
            //     .OrderBy(filter._by + " " + orderBy)
            //     .Skip((filter.PageNumber - 1) * filter.PageSize)
            //     .Take(filter.PageSize)
            //     .Where(x => x.Deleted_by != null )
            //     .Join(_context.Dentists,
            //         user=>user.DentistId,
            //         dentist=>dentist.Id ,
            //         (user,dentist)=>new
            //         {
            //             UserDTO user = new UserDTO{
            //             
            //         }
            //         })
            //     .ToListAsync();
            //         


            var data = await (from user in _context.Users
                    join dentist in _context.Dentists on user.DentistId equals dentist.Id into dentistsUser
                    from dentistAttribute in dentistsUser.DefaultIfEmpty()
                    where user.Deleted_by != null
                    select new { user, dentistAttribute })
                .OrderByDescending(x => x.user.Created_at)
                .Skip((filter.PageNumber - 1) * filter.PageSize)
                .Take(filter.PageSize).ToListAsync();
            

            List<DentistDTO> dentistList = new();


            var totalRecords = await _context.Dentists.CountAsync();

            if (data == null)
            {
                response.Content = null;
                response.Code = "200";
                response.Message = "There aren't any dentists in DB";
            }
            else
            {
                foreach (var item in data)
                {
                    DentistDTO dto = new();
                    dto.Description = item.dentistAttribute?.Description;
                    dto.Email = item.user.Email;
                    dto.Gender = item.user.Gender;
                    dto.Id = item.user.Id;
                    dto.Phone = item.user.PhoneNumber;
                    dto.Position = item.dentistAttribute.Position;
                    dto.Status = item.user.Status;
                    dto.FirstName = item.user.FirstName;
                    dto.LastName = item.user.LastName;

                    dentistList.Add(dto);
                }

                response.Content = dentistList;
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
            DentistResponse response = new();
            return response;

        }

        public async Task<DentistResponse> UpdateDentist(UpdateDentistRequest request)
        {
            var response = new DentistResponse();
            var dentist = _context.Dentists.FirstOrDefault(x => x.Id == request.Id);
            var clinic = _context.Clinics.FirstOrDefault(x => x.Id == request.ClinicId);
            var dentistService = new ServiceDentist();
            if (dentist != null)
            {
                if (clinic != null) dentist.Clinic = clinic;
                dentist.Description = request.Description;
                if (request.Position != null) dentist.Position = (Position)request.Position;

                if (request.ServiceId.Any())
                {
                    foreach (var x in request.ServiceId)
                    {
                        dentistService.DentistId = dentist.Id;
                        dentistService.ServiceId = x;

                        _context.ServiceDentists.Add(dentistService);
                        await _context.SaveChangesAsync();
                    }
                }

                var user = _context.Users.FirstOrDefault(x => x.DentistId == dentist.Id);
                if (user != null)
                {
                    if (request.Dob != null) user.DOB = (DateTime)request.Dob;
                    user.Email = request.Email;
                    user.FirstName = request.FirstName;
                    user.LastName = request.LastName;
                    user.UserName = request.UserName;
                    user.PhoneNumber = request.PhoneNumber;
                    if (request.Status != null) user.Status = (Status)request.Status;
                    if (request.Gender != null) user.Gender = (Gender)request.Gender;
                    user.Updated_by = request.UpdatedBy;
                }

                await _userService.UpdateAsync(user);
            }


            await _context.SaveChangesAsync();
            response.Code = "200";
            response.Message = "Updated successfully";

            return response;
        }

        public async Task<DentistResponse> DeleteDentist(DeleteDentistRequest request)
        {
            var response = new DentistResponse();
            var dentist = _context.Dentists.FirstOrDefault(x => x.Id == request.DentistId);
             
            if (dentist == null)
            {
                response.Code = "404";
                response.Message = "Not found dentist";
                return response;
            }

            var user = _context.Users.FirstOrDefault(x => x.DentistId == dentist.Id);

            if (user == null)
            {
                response.Code = "404";
                response.Message = "Error";
                return response;
            }
            
             
            user.Deleted_by = request.DeletedBy;
            await _userService.UpdateAsync(user);
            response.Code = "200";
            response.Message = "Delete successfully";
             
             
            return response;
        }
        
    }
}