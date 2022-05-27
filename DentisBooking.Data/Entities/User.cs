using DentisBooking.Data.Enum;
using Microsoft.AspNetCore.Identity;
using System;

namespace DentisBooking.Data.Entities
{
    public class User:IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Token { get; set; }


        public DateTime Created_at { get; set; }
        public DateTime? Updated_at { get; set; }
        public DateTime? Deleted_at { get; set; }
        public Guid? Created_by { get; set; }
        public Guid? Deleted_by { get; set; }
        public Guid? Updated_by { get; set; }

        public Status Status { get; set; }

        //Realtionship

        //public int ImageId { get; set; }
        //public Image Image { get; set; }

        //public int BookingId { get; set; }
        public Booking Booking { get; set; }

    }
}
