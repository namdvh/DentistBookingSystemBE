using DentisBooking.Data.Entities;
using DentistBooking.Application.ClaimTokens;
using DentistBooking.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBooking.Application.System.Users
{
    public interface IUserService
    {
        Task<Token> Authenticate(LoginRequest request);
        Task<RefreshTokenResponse> RefreshToken(Token token);
        Task<PrivateRouteResponse> GetProfile(Token token);
        Task<RegisterResponse> Register(RegisterRequest request);
    }
}
