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
            var refreshtoken = new JwtSecurityToken(_config["Tokens:Issuer"],
                _config["Tokens:Issuer"],
                claims,
                expires: DateTime.Now.AddMinutes(2),
                signingCredentials: creds);
            var ReturnToken = new JwtSecurityTokenHandler().WriteToken(accesstoken);
            var ReturnRFToken = new JwtSecurityTokenHandler().WriteToken(refreshtoken);
            //save rf token to db
            user.Token = ReturnRFToken;
            user.RefreshTokenExpiryTime = refreshtoken.ValidTo;
            await _userService.UpdateAsync(user);
            return new Token(ReturnToken, ReturnRFToken);
        }


        public async Task<RefreshTokenResponse> RefreshToken(Token token)
        {
            RefreshTokenResponse response = new RefreshTokenResponse();
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);


            string refreshToken = token.RefreshToken;
            var encodedJWT = tokenHandler.ReadJwtToken(refreshToken);

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

            if (GetPrincipalFromToken(refreshToken) == null)
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
                response.Message = "Expired Token";
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
