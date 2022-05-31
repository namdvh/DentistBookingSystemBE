using System;

namespace DentistBooking.ViewModels.System.Dentists
{
    public class DeleteDentistRequest
    {
        public int DentistId { get; set; }
        public Guid DeletedBy { get; set; }
    }
}