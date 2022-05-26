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
        public string OrderBy { get; set; }
        public int SortBy { get; set; }
        public PaginationFilter()
        {
            PageNumber = 1;
            PageSize = 10;
            OrderBy = "Created_at";
            SortBy = 1;
        }
        public PaginationFilter(int pageNumber, int pageSize, string orderBy, int sortBy)
        {
            PageNumber = pageNumber < 1 ? 1 : pageNumber;
            PageSize = pageSize > 10 ? 10 : pageSize;
            OrderBy = String.IsNullOrEmpty(orderBy) ? "Created_at" : orderBy;
            SortBy = sortBy > 0 ? 1 : sortBy;
        }
    }
}
