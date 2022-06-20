using DentisBooking.Data.Enum;
using System;
using System.Collections.Generic;

namespace DentisBooking.Data.Entities
{
    public class Clinic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }

        public Status Status { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime? Updated_at { get; set; }
        public DateTime? Deleted_at { get; set; }
        public Guid? Created_by { get; set; }
        public Guid? Deleted_by { get; set; }
        public Guid? Updated_by { get; set; }


        //Relationship 
        public ICollection<Dentist> Dentists { get; set; }
        //public ICollection<Image> Images { get; set; }
    }
}
