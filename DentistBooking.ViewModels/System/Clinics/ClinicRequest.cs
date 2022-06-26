using DentisBooking.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBooking.ViewModels.System.Clinics
{
    public class ClinicRequest
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public Guid UserId { get; set; }
        public List<string>? ImageUrl { get; set; }


    }
}
