using DentisBooking.Data.Entities;
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
        Task<ListClinicResponse> GetClinicList(PaginationFilter filter);
        Task<ClinicResponse> CreateClinic(ClinicRequest request);
        Task<ClinicResponse> UpdateClinic(ClinicRequest request);
        Task<ClinicResponse> DeleteClinic(string clinicId, Guid userId);

    }
}
