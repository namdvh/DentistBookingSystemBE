using DentisBooking.Data.Entities;
using DentistBooking.ViewModels.Pagination;
using DentistBooking.ViewModels.System.Dentists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBooking.Application.System.Dentists
{
    public interface IDentistService
    {
        Task<DentistResponse> GetDentistList(PaginationFilter filter);
        Task<DentistResponse> GetDentistListForUser(PaginationFilter filter);

        Task<DentistResponse> SearchDentist(PaginationFilter filter,string keyword);

        Task<DentistResponse> CreateDentist(AddDentistRequest request);
        Task<DentistCodeResponse> UpdateDentist(UpdateDentistRequest request);
        Task<DentistCodeResponse> DeleteDentist(int dentistId);
        
        Task<DentistDTO> GetDentist(Guid userId);
    }
}
