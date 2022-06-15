using DentisBooking.Data.Entities;
using DentisBooking.Data.Enum;
using DentistBooking.Application.ClaimTokens;
using DentistBooking.ViewModels.System.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Security.Claims;
using System.Text;
using FluentValidation.Results;
using System.Threading.Tasks;
using DentisBooking.Data.DataContext;
using DentistBooking.ViewModels.Pagination;
using DentistBooking.ViewModels.System.Dentists;
using Microsoft.EntityFrameworkCore;

namespace DentistBooking.Application.System.Users
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userService;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly IConfiguration _config;
        private readonly DentistDBContext _context;
        public UserService(UserManager<User> userService, SignInManager<User> signInService, RoleManager<Role> roleManager, IConfiguration config, DentistDBContext context)
        {
            _userService = userService;
            _signInManager = signInService;
            _roleManager = roleManager;
            _config = config;
            _context = context;
        }
        public async Task<Token> Authenticate(LoginRequest request)
        {
            var user = await _userService.FindByNameAsync(request.UserName);
            if (user == null)
            {
                return null;
            }
            var rs = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, true);
            if (!rs.Succeeded)
            {
                return null;
            }

            var roleName = (from usr in _context.Users
                            join userRole in _context.UserRoles on user.Id equals userRole.UserId
                            join role in _context.Roles on userRole.RoleId equals role.Id
                            select role.Name).FirstOrDefault();

            var roles = await _userService.GetRolesAsync(user);
            var claims = new[]
            {
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.Name,user.UserName),
                new Claim(ClaimTypes.Name,user.FirstName),
                new Claim(ClaimTypes.Role,string.Join(";",roles))
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var accesstoken = new JwtSecurityToken(_config["Tokens:Issuer"],
                _config["Tokens:Issuer"],
                claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: creds);
            var refreshtoken = new JwtSecurityToken(_config["Tokens:Issuer"],
                _config["Tokens:Issuer"],
                claims,
                expires: DateTime.Now.AddDays(7),
                signingCredentials: creds);
            var ReturnToken = new JwtSecurityTokenHandler().WriteToken(accesstoken);
            var ReturnRFToken = new JwtSecurityTokenHandler().WriteToken(refreshtoken);
            //save rf token to db
            user.Token = ReturnRFToken;
            user.RefreshTokenExpiryTime = refreshtoken.ValidTo;
            await _userService.UpdateAsync(user);

            var userDto = MapToDto(user, roleName);

            var token = new Token(ReturnToken, ReturnRFToken, userDto);

            return token;
        }


        public async Task<RefreshTokenResponse> RefreshToken(RefreshToken refreshToken)
        {
            RefreshTokenResponse response = new RefreshTokenResponse();
            var tokenHandler = new JwtSecurityTokenHandler();


            var principal = GetPrincipalFromToken(refreshToken.refreshToken);

            try
            {

            if (GetPrincipalFromToken(refreshToken.refreshToken) == null)
            {
                response.Code = "900";
                response.Message = "Invalid Token";
                return response;
            }
            }
            catch (SecurityTokenExpiredException)
            {

                response.Code = "901";
                response.Message = "Expired Token";
                return response;
            }
            catch(SecurityTokenInvalidSignatureException)
            {
                response.Code = "900";
                response.Message = "Invalid Token";
                return response;
            }
            catch(ArgumentException)
            {
                response.Code = "900";
                response.Message = "Arugment invalid Token";
                return response;
            }


            string username = principal.Identity.Name;
            var user = await _userService.FindByNameAsync(username);

            if (user == null || user.Token != refreshToken.refreshToken || user.RefreshTokenExpiryTime <= DateTime.UtcNow)
            {
                response.Code = "901";
                response.Message = "Expired Token";
                response.AccessToken = "";
                response.RefreshToken = "";
                return response;
            }
            var roles = await _userService.GetRolesAsync(user);
            var claims = new[]
            {
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.Name,user.UserName),
                new Claim(ClaimTypes.Name,user.FirstName),
                new Claim(ClaimTypes.Role,string.Join(";",roles))
                };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);


            var accesstoken = new JwtSecurityToken(_config["Tokens:Issuer"],
                _config["Tokens:Issuer"],
                claims,
                expires: DateTime.Now.AddMinutes(1),
                signingCredentials: creds);
            var newAccessToken = new JwtSecurityTokenHandler().WriteToken(accesstoken);
            response.AccessToken = newAccessToken;
            response.Code = "200";
            response.Message = "Generate new token successfully";
            return response;
        }

        private ClaimsPrincipal GetPrincipalFromToken(string? token)

        {
            var principal = (dynamic)null;
            try
            {
                string issuer = _config.GetValue<string>("Tokens:Issuer");
                string signingKey = _config.GetValue<string>("Tokens:Key");
                byte[] signingKeyBytes = Encoding.UTF8.GetBytes(signingKey);

                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidIssuer = issuer,
                    ValidateAudience = true,
                    ValidAudience = issuer,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ClockSkew = TimeSpan.Zero,
                    IssuerSigningKey = new SymmetricSecurityKey(signingKeyBytes),
                };
                principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out SecurityToken securityToken);
            }
            catch (SecurityTokenExpiredException ex)
            {
                throw new SecurityTokenExpiredException();
            }
            catch (SecurityTokenInvalidSignatureException e)
            {
                throw new SecurityTokenInvalidSignatureException();
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException();
            }
            return principal;
        }
        public async Task<RegisterResponse> Register(RegisterRequest request)
        {
            RegisterResponse response = new RegisterResponse();
            response.Messages = new();
            RegisterRequestValidator validator = new RegisterRequestValidator();
            ValidationResult results = validator.Validate(request);

            var defaultRole = _roleManager.FindByIdAsync("20efd516-f16c-41b3-b11d-bc908cd2056b").Result;

            if (!results.IsValid)
            {

                response.Content = null;
                response.Code = "200";
                foreach (var failure in results.Errors)
                {
                    response.Messages.Add(failure.ErrorMessage.ToString());
                }
                return response;
            }
            else
            {
                var user = new User()
                {
                    DOB = request.DOB,
                    Email = request.Email,
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    UserName = request.UserName,
                    PhoneNumber = request.PhoneNumber,
                    Status = Status.ACTIVE,
                    Gender = request.Gender,
                };

                var rs = await _userService.CreateAsync(user, request.Password);
                if (rs.Succeeded)
                {

                    await _userService.AddToRoleAsync(user, defaultRole.Name);
                    response.Content = user;
                    response.Code = "200";
                    response.Messages.Add("Regist successfully");

                    return response;
                }
                response.Content = null;
                response.Code = "200";
                response.Messages.Add("Username already exists ");

                return response;
            }
        }

        private UserDTO MapToDto(User user, string roleName)
        {
            var userDto = new UserDTO()
            {
                Id = user.Id.ToString(),
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Gender = user.Gender,
                Phone = user.PhoneNumber,
                Status = user.Status,
                Created_at = user.Created_at,
                role = roleName
            };
            return userDto;
        }

        public async Task<ProfileResponse> GetProfile(RefreshToken refreshToken)
        {
            ProfileResponse response = new ProfileResponse();
            var tokenHandler = new JwtSecurityTokenHandler();


            var principal = GetPrincipalFromToken(refreshToken.refreshToken);

            if (principal == null)
            {
               response.Code = "800";
               response.Message = "Invalid Token";
               return response;
            }
            string username = principal.Identity.Name;
            var user = await _userService.FindByNameAsync(username);

            if (user == null || user.Token != refreshToken.refreshToken || user.RefreshTokenExpiryTime <= DateTime.UtcNow)
            {
                response.Code = "801";
                response.Message = "Expired Refresh Token in getProfile";
                return response;
            }
            ProfileDTO profile = new ProfileDTO()
            {
                Id = user.Id,
                UserName = username,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Phone = user.PhoneNumber,
                DentistId = user.DentistId,
                DOB = user.DOB,
                Gender = user.Gender,
                ImageUrl = user.ImageUrl

            };

            if (profile.DentistId != null)
            {
                var getDentist = (from dentist in _context.Dentists
                                    where dentist.Id == profile.DentistId
                                    select dentist).FirstOrDefault();
                profile.Position = getDentist.Position;
                profile.Description = getDentist?.Description;
            }

     

            var role = await _userService.GetRolesAsync(user);
            response.ProfileDTO = profile;
            response.Role = role[0];
            response.Code = "200";
            response.Message = "msg";
            return response;
        }

        public async Task<ListUserResponse> GetUserList(PaginationFilter filter)
        {
             ListUserResponse response = new();
            PaginationDTO paginationDto = new();

            var orderBy = filter._order.ToString();

            orderBy = orderBy switch
            {
                "1" => "descending",
                "-1" => "ascending",
                _ => orderBy
            };

            dynamic usersInUserRole = null;

            if (filter._all)
            {
                 usersInUserRole = await (from user in _context.Users
                        join userRole in _context.UserRoles
                            on user.Id equals userRole.UserId
                        join role in _context.Roles
                            on userRole.RoleId equals role.Id
                        where role.Name.Equals("User") && user.Status != Status.INACTIVE
                        select user
                    )
                    .OrderBy(filter._by + " " + orderBy)
                    .ToListAsync();

            }
            else
            {
                 usersInUserRole = await (from user in _context.Users
                        join userRole in _context.UserRoles
                            on user.Id equals userRole.UserId
                        join role in _context.Roles
                            on userRole.RoleId equals role.Id
                        where role.Name.Equals("User") && user.Status != Status.INACTIVE
                        select user
                    )
                    .OrderBy(filter._by + " " + orderBy)
                    .Skip((filter.PageNumber - 1) * filter.PageSize)
                    .Take(filter.PageSize)
                    .ToListAsync();

            }
        


            List<UserDTO> userDtoList = new();


            var totalRecords = (from user in _context.Users
                    join userRole in _context.UserRoles
                        on user.Id equals userRole.UserId
                    join role in _context.Roles
                        on userRole.RoleId equals role.Id
                    where role.Name.Equals("User") && user.Status != Status.INACTIVE
                    select user
                ).Count();

            if (usersInUserRole == null)
            {
                response.Content = null;
                response.Code = "200";
                response.Message = "There aren't any users in DB";
            }
            else
            {
                foreach (var item in usersInUserRole)
                {
                    userDtoList.Add(MapToDto(item));
                }

                response.Content = userDtoList;
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

        public async Task<DentistCodeResponse> UpdateUser(UpdateUserRequest request)
        {
            var response = new DentistCodeResponse();

            var user = _context.Users.FirstOrDefault(x => x.Id == request.UserId);


            if (user != null)
            {
                user.DOB = (DateTime)request.DOB;
                user.Email = request.Email;
                user.FirstName = request.FirstName;
                user.LastName = request.LastName;
                user.PhoneNumber = request.PhoneNumber;
                user.Gender = (Gender)request.Gender;
                user.ImageUrl = request.ImageUrl;
            }

            await _userService.UpdateAsync(user);


            await _context.SaveChangesAsync();
            response.Code = "200";
            response.Message = "Updated successfully";

            return response;
        }

        public async Task<DentistCodeResponse> DeleteUser(Guid userId)
        {
            var response = new DentistCodeResponse();
            var user = _context.Users.FirstOrDefault(x => x.Id == userId);

            if (user == null)
            {
                response.Code = "404";
                response.Message = "Error";
                return response;
            }

            if (user.Status == Status.INACTIVE)
            {
                user.Deleted_at = null;
                user.Status = Status.ACTIVE;
            }
            else
            {
                user.Deleted_at = DateTime.Parse(DateTime.Now.ToString("yyyy/MMM/dd"));
                user.Status = Status.INACTIVE;
            }

            var rs = await _context.SaveChangesAsync();
            response.Code = "200";
            response.Message = "Delete successfully";


            return response;
        }

        public async Task<UserDTO> GetUser(Guid userId)
        {
            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == userId);
                return MapToDto(user);
            }
            catch (DbUpdateException e)
            {
                return null;
            }
        }
        
        private UserDTO MapToDto(User user)
        {
            UserDTO dto = new();
            dto.Email = user.Email;
            dto.Gender = user.Gender;
            dto.Id = user.Id.ToString();
            dto.Phone = user.PhoneNumber;
            dto.DOB = user.DOB;
            dto.Status = user.Status;
            dto.FirstName = user.FirstName;
            dto.LastName = user.LastName;
            dto.role = "User";
            dto.ImageUrl = user.ImageUrl;
            return dto;
        }
    }

}

