using DentisBooking.Data.Entities;
using DentisBooking.Data.Enum;
using DentistBooking.Application.ClaimTokens;
using DentistBooking.ViewModels.System.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using FluentValidation.Results;
using System.Threading.Tasks;

namespace DentistBooking.Application.System.Users
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userService;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly IConfiguration _config;
        public UserService(UserManager<User> userService, SignInManager<User> signInService, RoleManager<Role> roleManager, IConfiguration config)
        {
            _userService = userService;
            _signInManager = signInService;
            _roleManager = roleManager;
            _config = config;
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
            var roles = await _userService.GetRolesAsync(user);
            var claims = new[]
            {
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.Name,user.Email),
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
            var ReturnToken=new JwtSecurityTokenHandler().WriteToken(accesstoken);
            var ReturnAccessToken=new JwtSecurityTokenHandler().WriteToken(refreshtoken);
            return new Token(ReturnToken, ReturnAccessToken);
        }


        public async Task<RegisterResponse> Register(RegisterRequest request)
        {
            RegisterResponse response = new RegisterResponse();
            response.Messages = new();
            RegisterRequestValidator validator = new RegisterRequestValidator();
            ValidationResult results = validator.Validate(request);
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
                    response.Content = user;
                    response.Code = "200";
                    response.Messages.Add("Regist successfully");

                    return response;
                }
                response.Content = null;
                response.Code = "200";
                response.Messages.Add("Regist failed");

                return response;
            }

        }
    }
}
