using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBooking.ViewModels.Pagination
{
    public class PaginationFilter
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int _by { get; set; }
        public string _order { get; set; }
        public PaginationFilter()
        {
            PageNumber = 1;
            PageSize = 10;
            _order = "Created_at";
            _by = 1;
        }
        public PaginationFilter(int pageNumber, int pageSize, string orderBy, int sortBy)
        {
            PageNumber = pageNumber < 1 ? 1 : pageNumber;
            PageSize = pageSize > 10 ? 10 : pageSize;
            _order = String.IsNullOrEmpty(orderBy) ? "Created_at" : orderBy;
            _by = sortBy > 0 ? 1 : sortBy;
        }
    }
}
