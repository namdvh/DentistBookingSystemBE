using DentisBooking.Data.Entities;
using DentisBooking.Data.Enum;
using DentistBooking.Application.NewFolder;
using DentistBooking.ViewModels.System.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
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
                new Claim(ClaimTypes.Name,user.FirstName),
                new Claim(ClaimTypes.Role,string.Join(";",roles))
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(_config["Tokens:Issuer"],
                _config["Tokens:Issuer"],
                claims,
                expires: DateTime.Now.AddHours(3),
                signingCredentials: creds);
            var accesstoken = new JwtSecurityToken(_config["Tokens:Issuer"],
                _config["Tokens:Issuer"],
                claims,
                expires: DateTime.Now.AddHours(4),
                signingCredentials: creds);
            var ReturnToken=new JwtSecurityTokenHandler().WriteToken(token);
            var ReturnAccessToken=new JwtSecurityTokenHandler().WriteToken(accesstoken);
            return new Token(ReturnToken, ReturnAccessToken);
        }


        public async Task<bool> Register(RegisterRequest request)
        {
            var user = new User()
            {
                DOB=request.DOB,
                Email=request.Email,
                FirstName=request.FirstName,
                LastName=request.LastName,
                UserName=request.UserName,
                PhoneNumber=request.PhoneNumber,
                Status=Status.ACTIVE,
                Gender=request.Gender,
            };
            var rs=await _userService.CreateAsync(user,request.Password);
            if (rs.Succeeded)
            {
                return true;
            }
            return false;
        }
    }
}
