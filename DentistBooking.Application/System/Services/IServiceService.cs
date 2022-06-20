using System;
using System.Threading.Tasks;
using DentistBooking.ViewModels.Pagination;
using DentistBooking.ViewModels.System.Clinics;
using DentistBooking.ViewModels.System.Services;

namespace DentistBooking.Application.System.Services
{
    public interface IServiceService
    {
        Task<ListServiceResponse> GetServiceList(PaginationFilter filter);
        Task<ServiceDtoResponse> GetService(int id);
        Task<ServiceResponse> CreateService(AddServiceRequest request);
        Task<ServiceResponse> UpdateService(ServiceRequest request);
        Task<ServiceResponse> DeleteService(int clinicId, Guid userId);
    }
}