using DentistBooking.ViewModels.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBooking.ViewModels.System.Services
{
    public class ListServiceResponse
    {
        public IEnumerable<ServiceDto> Content { get; set; }

        public string Code { get; set; }
        
        public string Message { get; set; }

        public PaginationDTO Pagination { get; set; }
    }
}
