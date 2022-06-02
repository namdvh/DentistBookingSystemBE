using DentisBooking.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBooking.ViewModels.System.Discounts
{
    public class DiscountRequest
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public float? Percent { get; set; }
        public decimal? Amount { get; set; }
        public bool ApplyForAll { get; set; }
        public Guid UserId { get; set; }


    }
}
