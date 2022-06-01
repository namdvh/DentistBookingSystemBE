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
        Task<ServiceResponse> CreateService(ServiceRequest request);
        Task<ServiceResponse> UpdateService(ServiceRequest request);
        Task<ServiceResponse> DeleteService(string clinicId, Guid userId);
    }
}