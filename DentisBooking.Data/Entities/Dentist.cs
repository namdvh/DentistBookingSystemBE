using DentisBooking.Data.Enum;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace DentisBooking.Data.Entities
{
    public class Dentist
    {
        public int Id { get; set; }
        public Position Position { get; set; }
        public string Description { get; set; }
        //Relationship

        //public int ImageId { get; set; }
        //public Image Image { get; set; }
        
        public User User { get; set; }
        
        public ICollection<ServiceDentist> ServiceDentists { get; set; }
        public int ClinicId { get; set; }
        public Clinic Clinic { get; set; }
    }
}
