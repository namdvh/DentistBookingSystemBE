﻿using DentistBooking.Application.NewFolder;
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
        Task<RegisterResponse> Register(RegisterRequest request);

    }
}
