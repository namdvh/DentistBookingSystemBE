using DentisBooking.Data.Enum;
using System;
using System.Collections.Generic;

namespace DentisBooking.Data.Entities
{
    public class Discount
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public float? Percent { get; set; }
        public decimal? Amount { get; set; }
        public bool ApplyForAll { get; set; }
        
        public Status status { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime? Updated_at { get; set; }
        public DateTime? Deleted_at { get; set; }
        public Guid? Created_by { get; set; }
        public Guid? Deleted_by { get; set; }
        public Guid? Updated_by { get; set; }

        //Relationship
        public ICollection<Service> Services { get; set; }
    }
}
