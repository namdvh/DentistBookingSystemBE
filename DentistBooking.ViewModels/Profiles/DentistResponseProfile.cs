using AutoMapper;
using DentisBooking.Data.Entities;
using DentistBooking.ViewModels.System.Dentists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBooking.ViewModels.Profiles
{
    public class DentistResponseProfile :Profile
    {
        public DentistResponseProfile()
        {
            CreateMap<Dentist, DentistResponse>();
        }
    }
}
