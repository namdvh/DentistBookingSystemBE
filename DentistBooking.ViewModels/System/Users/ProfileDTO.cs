using DentisBooking.Data.Entities;
using DentisBooking.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBooking.ViewModels.System.Users
{
    public class ProfileDTO
    {
        public Guid Id { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }
        public string? ImageUrl { get; set; }
        public int? DentistId { get; set; }
        public Position Position { get; set; }
        public string Description { get; set; }



    }
}
