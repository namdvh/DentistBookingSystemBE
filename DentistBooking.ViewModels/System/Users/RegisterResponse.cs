using DentisBooking.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBooking.ViewModels.System.Users
{
    public class RegisterResponse
    {
        public User Content { get; set; }

        public string Code { get; set; }

        public List<string> Messages { get; set; }

    }
}