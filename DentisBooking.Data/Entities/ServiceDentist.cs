using System;

namespace DentisBooking.Data.Entities
{
    public class ServiceDentist
    {

        public int DentistId { get; set; }

        public Dentist Dentist { get; set; }

        public int ServiceId { get; set; }

        public Service Service { get; set; }
        public ServiceDentist()
        {
        }
        public ServiceDentist(int dentistId, int serviceId)
        {
            DentistId = dentistId;
            ServiceId = serviceId;
        }


    }
}
