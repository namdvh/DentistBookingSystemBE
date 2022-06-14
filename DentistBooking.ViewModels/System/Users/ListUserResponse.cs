using System.Collections.Generic;
using DentistBooking.ViewModels.Pagination;

namespace DentistBooking.ViewModels.System.Users
{
    public class ListUserResponse
    {
        public IEnumerable<UserDTO> Content { get; set; }

        public string Code { get; set; }
        public string Message { get; set; }

        public PaginationDTO Pagination { get; set; }    
    }
}