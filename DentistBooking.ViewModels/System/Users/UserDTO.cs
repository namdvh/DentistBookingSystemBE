using System;
using DentisBooking.Data.Enum;

namespace DentistBooking.ViewModels.System.Users
{
    public class UserDTO
    {
        public string Id { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Token { get; set; }


        public DateTime Created_at { get; set; }
       
        public string role { get; set; }

        public Status Status { get; set; }
    }
}