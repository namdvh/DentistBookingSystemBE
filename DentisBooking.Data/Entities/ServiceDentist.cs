using System;

namespace DentisBooking.Data.Entities
{
    public class ServiceDentist
    {
        public Guid DentistId { get; set; }

        public Dentist Dentist { get; set; }

        public int ServiceId { get; set; }

        public Service Service { get; set; }


    }
}
