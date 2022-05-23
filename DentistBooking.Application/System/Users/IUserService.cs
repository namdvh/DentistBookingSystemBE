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
        Task<string> Authenticate(LoginRequest request);
        Task<bool> Register(RegisterRequest request);

    }
}
