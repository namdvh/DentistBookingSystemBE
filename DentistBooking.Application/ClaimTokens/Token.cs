﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DentistBooking.ViewModels.System.Users;

namespace DentistBooking.Application.ClaimTokens
{
    public class Token
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        
        public UserDTO User { get; set; }
        
        public Token(string accessToken, string refreshToken)
        {
            AccessToken = accessToken;
            RefreshToken = refreshToken;
        }
        public Token()
        {

        }
        public Token(string accessToken, string refreshToken, UserDTO user)
        {
            AccessToken = accessToken;
            RefreshToken = refreshToken;
            User = user;
        }
    }
}
