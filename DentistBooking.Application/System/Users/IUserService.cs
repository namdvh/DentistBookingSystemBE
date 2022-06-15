using DentistBooking.Application.ClaimTokens;
using DentistBooking.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DentistBooking.ViewModels.Pagination;
using DentistBooking.ViewModels.System.Dentists;

namespace DentistBooking.Application.System.Users
{
    public interface IUserService
    {
        Task<Token> Authenticate(LoginRequest request);
        Task<RefreshTokenResponse> RefreshToken(RefreshToken refreshToken);
        Task<RegisterResponse> Register(RegisterRequest request);
        Task<ProfileResponse> GetProfile(RefreshToken refreshToken);
        
        Task<ListUserResponse> GetUserList(PaginationFilter filter);
        Task<DentistCodeResponse> UpdateUser(UpdateUserRequest request);
        Task<DentistCodeResponse> DeleteUser(Guid userId);
        Task<UserDTO> GetUser(Guid userId);
    }
}
