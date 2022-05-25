using DentistBooking.ViewModels.Pagination;
using DentistBooking.ViewModels.System.Clinics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBooking.Application.System.Clinics
{
    public interface IClinicService
    {
        Task<ClinicResponse> GetClinicList(PaginationFilter filter);
    }
}
