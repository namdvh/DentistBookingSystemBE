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
            var ReturnToken = new JwtSecurityTokenHandler().WriteToken(accesstoken);
            var ReturnRFToken = new JwtSecurityTokenHandler().WriteToken(refreshtoken);
            //save rf token to db
            user.Token = ReturnRFToken;
            user.RefreshTokenExpiryTime = refreshtoken.ValidTo;
            await _userService.UpdateAsync(user);
            
            var userDto = MapToDto(user, roleName);

            Token token = new(ReturnToken, ReturnRFToken, userDto);
            
            
            return token;
        }

        public async Task<RefreshTokenResponse> RefreshToken(Token token)
        {
            RefreshTokenResponse response = new RefreshTokenResponse();
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            string refreshToken = token.RefreshToken;

            if (token is null)
            {
                response.Code = "403";
                response.Message = "Invalid token";
            }

            //if ((encodedJWT.ValidFrom > DateTime.UtcNow) || (encodedJWT.ValidTo < DateTime.UtcNow))
            //{
            //    response.Code = "403";
            //    response.Message = "Expired token";
            //}



            var principal = GetPrincipalFromToken(refreshToken);

            if (principal == null)
            {
                response.Code = "903";
                response.Message = "Expired or Invalid Token";
                return response;
            }

            string username = principal.Identity.Name;
            var user = await _userService.FindByNameAsync(username);

            if (user == null || user.Token != refreshToken)
            {
                response.Code = "903";
                response.Message = "Invalid Token";
                response.AccessToken = "";
                response.RefreshToken = "";
                return response;
            }
            else if (user.RefreshTokenExpiryTime <= DateTime.UtcNow)
            {
                //Both field refresh and access
                var roles = await _userService.GetRolesAsync(user);
                var claims = new[]
                {
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.Name,user.UserName),
                new Claim(ClaimTypes.Name,user.FirstName),
                new Claim(ClaimTypes.Role,string.Join(";",roles))
                };


                var accesstoken = new JwtSecurityToken(_config["Tokens:Issuer"],
                    _config["Tokens:Issuer"],
                    claims,
                    expires: DateTime.Now.AddMinutes(1),
                    signingCredentials: creds);

                var rftoken = new JwtSecurityToken(_config["Tokens:Issuer"],
                    _config["Tokens:Issuer"],
                    claims,
                    expires: DateTime.Now.AddHours(7),
                    signingCredentials: creds);

                var newAccessToken = new JwtSecurityTokenHandler().WriteToken(accesstoken);
                var newRefreshToken = new JwtSecurityTokenHandler().WriteToken(rftoken);
                response.AccessToken = newAccessToken;
                response.RefreshToken = newRefreshToken;
                response.Code = "902";
                response.Message = "Generate both token successfully";
            }
            else
            {
                var roles = await _userService.GetRolesAsync(user);
                var claims = new[]
                {
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.Name,user.UserName),
                new Claim(ClaimTypes.Name,user.FirstName),
                new Claim(ClaimTypes.Role,string.Join(";",roles))
                };


                var accesstoken = new JwtSecurityToken(_config["Tokens:Issuer"],
                    _config["Tokens:Issuer"],
                    claims,
                    expires: DateTime.Now.AddMinutes(1),
                    signingCredentials: creds);

                var newAccessToken = new JwtSecurityTokenHandler().WriteToken(accesstoken);
                response.AccessToken = newAccessToken;
                response.Code = "900";
                response.Message = "Generate new access token successfully";
            }
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
                principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out SecurityToken securityToken);
            }
            catch (SecurityTokenExpiredException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (SecurityTokenInvalidSignatureException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
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
