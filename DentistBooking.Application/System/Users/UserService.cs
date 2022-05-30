using DentisBooking.Data.Entities;
using DentisBooking.Data.Enum;
using DentistBooking.Application.ClaimTokens;
using DentistBooking.ViewModels.System.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using FluentValidation.Results;
using System.Threading.Tasks;
using DentisBooking.Data.DataContext;

namespace DentistBooking.Application.System.Users
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userService;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly IConfiguration _config;
        private readonly DentistDBContext _context;

        public UserService(UserManager<User> userService, SignInManager<User> signInService,
            RoleManager<Role> roleManager, IConfiguration config, DentistDBContext context)
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
            var id = user.Id;
            
            
            if (user == null)
            {
                return null;
            }

            var rs = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, true);
            if (!rs.Succeeded)
            {
                return null;
            }

            string roleName;
            
            try
            {
            roleName = (from usr in _context.Users
                join userRole in _context.UserRoles on user.Id equals userRole.UserId
                join role in _context.Roles on userRole.RoleId equals role.Id
                select role.Name).FirstOrDefault ();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            



            var roles = await _userService.GetRolesAsync(user);
            var claims = new[]
            {
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Name, user.FirstName),
                new Claim(ClaimTypes.Role, string.Join(";", roles))
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

            var returnAccessToken = new JwtSecurityTokenHandler().WriteToken(accesstoken);
            var returnRefreshToken = new JwtSecurityTokenHandler().WriteToken(refreshtoken);
            var userDto = MapToDto(user, roleName);

            Token token = new(returnAccessToken, returnRefreshToken, userDto);

            return token;
        }

        public async Task<RefreshTokenResponse> RefreshToken(Token token)
        {
            RefreshTokenResponse response = new RefreshTokenResponse();
            var tokenHandler = new JwtSecurityTokenHandler();

            string refreshToken = token.RefreshToken;
            var encodedJWT = tokenHandler.ReadJwtToken(refreshToken);

            if (token is null)
            {
                response.Code = "403";
                response.Message = "Invalid token";
            }

            if ((encodedJWT.ValidFrom > DateTime.UtcNow) || (encodedJWT.ValidTo < DateTime.UtcNow))
            {
                response.Code = "403";
                response.Message = "Expired token";
            }
            else
            {
                var principal = GetPrincipalFromExpiredToken(refreshToken);

                //False information from token
                //if (principal == null)
                //{
                //    //
                //}

                string username = principal.Identity.Name;

                var user = await _userService.FindByNameAsync(username);

                if (user == null)
                {
                    //also need to validate with refresh token from cookie and accesstoken
                }

                var roles = await _userService.GetRolesAsync(user);
                var claims = new[]
                {
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(ClaimTypes.Name, user.FirstName),
                    new Claim(ClaimTypes.Role, string.Join(";", roles))
                };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);


                var accesstoken = new JwtSecurityToken(_config["Tokens:Issuer"],
                    _config["Tokens:Issuer"],
                    claims,
                    expires: DateTime.Now.AddHours(1),
                    signingCredentials: creds);

                //var refreshtoken = new JwtSecurityToken(_config["Tokens:Issuer"],
                //    _config["Tokens:Issuer"],
                //    claims,
                //    expires: DateTime.Now.AddDays(7),
                //    signingCredentials: creds);

                var newAccessToken = new JwtSecurityTokenHandler().WriteToken(accesstoken);
                response.Token = newAccessToken;
                response.Code = "200";
                response.Message = "Generate new token successfully";
            }

            return response;
        }

        private ClaimsPrincipal GetPrincipalFromExpiredToken(string? token)

        {
            string issuer = _config.GetValue<string>("Tokens:Issuer");
            string signingKey = _config.GetValue<string>("Tokens:Key");
            byte[] signingKeyBytes = Encoding.UTF8.GetBytes(signingKey);

            var tokenHandler = new JwtSecurityTokenHandler();

            //TokenValidationParameters validationParameters = new TokenValidationParameters();
            //validationParameters.IssuerSigningKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));


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

            var principal =
                tokenHandler.ValidateToken(token, tokenValidationParameters, out SecurityToken securityToken);


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
                response.Messages.Add("Register successfully");

                return response;
            }

            response.Content = null;
            response.Code = "200";
            response.Messages.Add("Register failed");

            return response;
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
                Token = user.Token,
                Status = user.Status,
                Created_at = user.Created_at,
                role = roleName
            };
            return userDto;
        }
    }
}