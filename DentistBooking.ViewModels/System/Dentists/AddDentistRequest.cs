using DentisBooking.Data.Enum;
using System;
using System.Collections.Generic;

namespace DentistBooking.ViewModels.System.Dentists
{
    public class AddDentistRequest
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public DateTime DOB { get; set; }

        public string Phone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public Status Status { get; set; }
        public Position Position { get; set; }
        public string Description { get; set; }
        public int ClinicId { get; set; }
        public string? Image { get; set; }

        public List<int>? ServiceId { get; set; }
    }
}