using AutoMapper;
using DentisBooking.Data.Entities;
using DentistBooking.ViewModels.System.Clinics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBooking.ViewModels.Profiles
{
    public class ClinicResponseProfile : Profile
    {
        public ClinicResponseProfile()
        {
            CreateMap<Clinic, ListClinicResponse>();
        }
    }
}
