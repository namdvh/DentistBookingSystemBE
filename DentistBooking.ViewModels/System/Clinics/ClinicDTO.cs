﻿using DentisBooking.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBooking.ViewModels.System.Clinics
{
    public class ClinicDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }

        public Status Status { get; set; }
        public DateTime Created_at { get; set; }
  
    }
}
