using DentisBooking.Data.Enum;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace DentisBooking.Data.Entities
{
    public class Dentist: IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        
        public DateTime? RefreshTokenExpiryTime { get; set; }
        public Status Status { get; set; }
        public Position Position { get; set; }
        public string Description { get; set; }

        public DateTime Created_at { get; set; }
        public DateTime? Updated_at { get; set; }
        public DateTime? Deleted_at { get; set; }
        public Guid? Created_by { get; set; }
        public Guid? Deleted_by { get; set; }
        public Guid? Updated_by { get; set; }

        //Relationship

        //public int ImageId { get; set; }
        //public Image Image { get; set; }

        public ICollection<BookingDetail> BookingDetails { get; set; }
        public ICollection<ServiceDentist> ServiceDentists { get; set; }
        public int ClinicId { get; set; }
        public Clinic Clinic { get; set; }
    }
}
