using DentisBooking.Data.Entities;
using DentistBooking.ViewModels.System.Users;
using System;
using System.Threading.Tasks;

namespace DentistBooking.Application.System.Users
{
    public class UserService : IUserService
    {
        private readonly User _userService;
        private readonly User _signInManager;
        public UserService(User userService,User signInService)
        {
            _userService = userService;
            _signInManager = signInService;
        }
        public Task<bool> Authenticate(LoginRequest request)
        {
            throw new NotImplementedException();
            //var result=_signInManager.Pass
        }

        public Task<bool> Register(RegisterRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
