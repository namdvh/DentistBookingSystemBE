using DentisBooking.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBooking.ViewModels.System.Users
{
    public class ProfileResponse
    {
        public ProfileDTO ProfileDTO { get; set; }

        public string Role { get; set; }

        public string Message { get; set; }

        public string Code { get; set; }

    }
}