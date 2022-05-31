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

        Task<DentistResponse> CreateDentist(AddDentistRequest newDentist);
        Task<DentistResponse> UpdateDentist(Dentist updatedDentist);
        Task<DentistResponse> DeleteDentist(Guid dentistId, Guid deletedBy);
    }
}
