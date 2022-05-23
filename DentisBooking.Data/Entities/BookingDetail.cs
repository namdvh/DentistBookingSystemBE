using System;
using System.Collections.Generic;

namespace DentisBooking.Data.Entities
{
    public class BookingDetail
    {
        public int Id { get; set; }


        public string? Note { get; set; }

        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
        public DateTime Deleted_at { get; set; }
        public Guid Created_by { get; set; }
        public Guid Deleted_by { get; set; }
        public Guid Updated_by { get; set; }


        //Relationship

        public int BookingId { get; set; }
        public Booking Booking { get; set; }

        public int ServiceId { get; set; }
        public Service Service { get; set; }
    }

}
