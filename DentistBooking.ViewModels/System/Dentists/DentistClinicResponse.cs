using DentistBooking.ViewModels.System.Clinics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBooking.ViewModels.System.Dentists
{
    public class DentistClinicResponse
    {
        public DentistDTO DentistDTO { get; set; }
        public ClinicDTO ClinicDTO { get; set; }
        public string Message { get; set; }
        public string Code { get; set; }
    }
}
