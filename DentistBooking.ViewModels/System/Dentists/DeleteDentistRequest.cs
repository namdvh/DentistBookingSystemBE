using System;

namespace DentistBooking.ViewModels.System.Dentists
{
    public class DeleteDentistRequest
    {
        public Guid DentistId { get; set; }
        public Guid DeletedBy { get; set; }
    }
}