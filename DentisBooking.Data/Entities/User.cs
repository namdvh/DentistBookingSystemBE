using DentisBooking.Data.Enum;
using Microsoft.AspNetCore.Identity;
using System;

namespace DentisBooking.Data.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Phone { get; set; }
        public DateTime DOB { get; set; }
        public string Token { get; set; }


        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
        public DateTime Deleted_at { get; set; }
        public Guid Created_by { get; set; }
        public Guid Deleted_by { get; set; }
        public Guid Updated_by { get; set; }

        public AllCode Role { get; set; }
        public AllCode Status { get; set; }

        //Realtionship

        //public int ImageId { get; set; }
        //public Image Image { get; set; }

        //public int BookingId { get; set; }
        public Booking Booking { get; set; }

    }
}
