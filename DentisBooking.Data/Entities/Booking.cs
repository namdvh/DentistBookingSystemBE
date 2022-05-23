using DentisBooking.Data.Enum;
using System;
using System.Collections.Generic;

namespace DentisBooking.Data.Entities
{
    public class Booking 
    {
        public int Id { get; set; } 
        public DateTime Date { get; set; }
        public string KeyTime { get; set; }
        public int Total { get; set; }

        public Status Status { get; set; } 


        public DateTime Created_at { get; set; }
        public DateTime? Updated_at { get; set; }
        public DateTime? Deleted_at { get; set; }
        public Guid? Deleted_by { get; set; }
        public Guid? Updated_by { get; set; }

        //Relationship

        public List<BookingDetail> BookingDetails { get; set; }
        public Guid UserId { get; set; }
        public User Created_by { get; set; }

    }
}
