using DentisBooking.Data.Enum;
using System;
using System.Collections.Generic;

namespace DentisBooking.Data.Entities
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Procedure { get; set; }
        public Status Status { get; set; }
        public decimal Price { get; set; }

        public DateTime Created_at { get; set; }
        public DateTime? Updated_at { get; set; }
        public DateTime? Deleted_at { get; set; }
        public Guid? Created_by { get; set; }
        public Guid? Deleted_by { get; set; }
        public Guid? Updated_by { get; set; }

        //Realtionship

        //public ICollection<Image> Images { get; set; }
        public ICollection<ServiceDentist> ServiceDentists { get; set; }

        //public int BookingDetailId { get; set; }
        public ICollection<BookingDetail> BookingDetails { get; set; }

        public int DiscountId { get; set; }
        public Discount Discount { get; set; }

    }
}
