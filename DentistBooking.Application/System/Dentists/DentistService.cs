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
using DentistBooking.ViewModels.System;
using DentistBooking.ViewModels.System.Users;
using FluentValidation.Results;
using Microsoft.AspNetCore.Identity;
using DentistBooking.ViewModels.System.Services;

namespace DentistBooking.Application.System.Dentists
{
    public class DentistService : IDentistService
    {
        private readonly DentistDBContext _context;
        private readonly UserManager<User> _userService;

        public DentistService(DentistDBContext context, UserManager<User> userService)
        {
            _context = context;
            _userService = userService;
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

            dynamic data;

            if (filter._all)
            {
                data = await (from user in _context.Users
                        join dentist in _context.Dentists on user.DentistId equals dentist.Id into dentistsUser
                        from dentistAttribute in dentistsUser.DefaultIfEmpty()
                        where user.Deleted_by != null
                        select new { user, dentistAttribute })
                    .Where(x => x.user.DentistId != null)
                    .OrderByDescending(x => x.user.Created_at)
                    .ToListAsync();
            }
            else
            {
                data = (from user in _context.Users
                        join dentist in _context.Dentists on user.DentistId equals dentist.Id into dentistsUser
                        from dentistAttribute in dentistsUser.DefaultIfEmpty()
                        where user.Deleted_by != null
                        select new { user, dentistAttribute })
                    .Where(x => x.user.DentistId != null)
                    .OrderByDescending(x => x.user.Created_at)
                    .Skip((filter.PageNumber - 1) * filter.PageSize)
                    .Take(filter.PageSize)
                    .ToList();
            }


            List<DentistDTO> dentistList = new();


            var totalRecords = _context.Users.Count(x => x.DentistId != null);

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
                    List<ServiceDto> services = new();

                    ServiceDto serviceDto = new();

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

                    dto.Services = await GetServiceFromDentist(item.dentistAttribute.Id);

                    dentistList.Add(dto);
                }

                response.Content = dentistList;
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


        public async Task<DentistResponse> CreateDentist(AddDentistRequest request)
        {
            var response = new DentistResponse();
            var validator = new AddDentistRequestValidator();
            response.Errors = new List<string>();
            var results = await validator.ValidateAsync(request);

            var clinic = _context.Clinics.FirstOrDefault(x => x.Id == request.ClinicId);


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
                Clinic = clinic,
                Description = request.Description,
                Position = request.Position,
            };

            var rs = _context.Dentists.Add(newDentist);
            await _context.SaveChangesAsync();

            var newUser = new User()
            {
                DOB = request.DOB,
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                UserName = request.UserName,
                PhoneNumber = request.PhoneNumber,
                Status = Status.ACTIVE,
                Gender = request.Gender,
                Dentist = newDentist
            };

            var result = await _userService.CreateAsync(newUser, request.Password);

            if (result.Succeeded)
            {
                var dentistService = new ServiceDentist();

                if (request.ServiceId != null && request.ServiceId.Any())
                {
                    foreach (var x in request.ServiceId)
                    {
                        dentistService.DentistId = newDentist.Id;
                        dentistService.ServiceId = x;

                        _context.ServiceDentists.Add(dentistService);
                        await _context.SaveChangesAsync();
                    }
                }

                response.Code = "200";
                response.Message = "Register successfully";

                return response;
            }

            response.Content = null;
            response.Code = "200";
            response.Message = "Register failed";

            return response;
        }

        public async Task<DentistCodeResponse> UpdateDentist(UpdateDentistRequest request)
        {
            var response = new DentistCodeResponse();
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

        public async Task<DentistCodeResponse> DeleteDentist(DeleteDentistRequest request)
        {
            var response = new DentistCodeResponse();
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

        public async Task<DentistResponse> SearchDentist(PaginationFilter filter,string keyword)
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


            var data = (from user in _context.Users
                    join dentist in _context.Dentists on user.DentistId equals dentist.Id into dentistsUser
                    from dentistAttribute in dentistsUser.DefaultIfEmpty()
                    where user.Deleted_by != null
                    select new { user, dentistAttribute })
                .Where(x => x.user.DentistId != null && (x.user.FirstName.Contains(keyword)|| x.user.LastName.Contains(keyword)))
                .Skip((filter.PageNumber - 1) * filter.PageSize)
                .Take(filter.PageSize)
                .OrderByDescending(x => x.user.Created_at)
                .ToList();


            List<DentistDTO> dentistList = new();


            var totalRecords = _context.Users.Count(x=>(x.FirstName.Contains(keyword)|| x.LastName.Contains(keyword)));

            if (!data.Any())
            {
                response.Content = null;
                response.Code = "200";
                response.Message = "There aren't any dentists in DB";
            }
            else
            {
                foreach (var item in data)
                {
                    List<ServiceDto> services = new();

                    ServiceDto serviceDto = new();

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

                    dto.Services = await GetServiceFromDentist(item.dentistAttribute.Id);

                    dentistList.Add(dto);
                }

                response.Content = dentistList;
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


        private async Task<List<DentistServiceDto>> GetServiceFromDentist(int dentistId)
        {
            var results = await (from t1 in _context.ServiceDentists
                join t2 in _context.Services
                    on t1.ServiceId equals t2.Id
                where t1.DentistId == dentistId
                select t2).ToListAsync();

            var final = new List<DentistServiceDto>();

            foreach (var service in results)
            {
                DentistServiceDto dto = new();
                dto.Id = service.Id;
                dto.ServiceName = service.Name;
                final.Add(dto);
            }

            return final;
        }
    }
}