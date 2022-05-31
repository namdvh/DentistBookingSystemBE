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
<<<<<<< HEAD

        public ICollection<BookingDetail> BookingDetails { get; set; }
=======
        
        public User User { get; set; }
        
>>>>>>> 8f9165f7cc2f2dc9a94d5480f07f5c64d4cd94fc
        public ICollection<ServiceDentist> ServiceDentists { get; set; }
        public int ClinicId { get; set; }
        public Clinic Clinic { get; set; }
    }
}
