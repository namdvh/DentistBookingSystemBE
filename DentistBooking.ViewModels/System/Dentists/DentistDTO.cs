﻿using DentisBooking.Data.Enum;
using DentistBooking.ViewModels.System.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBooking.ViewModels.System.Dentists
{
    public class DentistDTO
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string Phone { get; set; }
        public DateTime Dob { get; set; }
        public string Token { get; set; }
        public Status Status { get; set; }
        public Position Position { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int DentistID { get; set; }

        public int ClinicID { get; set; }


        public List<DentistServiceDto> Services { get; set; }


    }
}
