using DentisBooking.Data.Enum;
using System;
using System.Collections.Generic;

namespace DentisBooking.Data.Entities
{
    public class Dentist
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Phone { get; set; }
        public string Token { get; set; }
        public AllCode Status { get; set; }
        public AllCode Position { get; set; }
        public string Description { get; set; }

        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
        public DateTime Deleted_at { get; set; }
        public Guid Created_by { get; set; }
        public Guid Deleted_by { get; set; }
        public Guid Updated_by { get; set; }

        //Relationship

        //public int ImageId { get; set; }
        //public Image Image { get; set; }
        public ICollection<ServiceDentist> ServiceDentists { get; set; }
        public int ClinicId { get; set; }
        public Clinic Clinic { get; set; }
    }
}
