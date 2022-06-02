using DentisBooking.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBooking.ViewModels.System.Bookings
{
    public class BookingRequest
    {
        public int? Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }


        public Guid UserId { get; set; }
    }
}
