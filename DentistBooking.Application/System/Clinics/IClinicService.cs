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
        Task<ListClinicResponse> GetClinicListForUpdateDentist(int dentistId);

        Task<ListClinicResponse> GetClinicListForBooking(PaginationFilter filter);


        Task<ClinicDTOResponse> GetClinic(int id);

        Task<ClinicResponse> CreateClinic(ClinicRequest request);
        Task<ClinicResponse> UpdateClinic(ClinicRequest request);
        Task<ClinicResponse> DeleteClinic(int clinicId);

    }
}
