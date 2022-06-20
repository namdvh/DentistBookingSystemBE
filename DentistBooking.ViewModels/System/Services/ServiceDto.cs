using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DentisBooking.Data.Enum;

namespace DentistBooking.ViewModels.System.Services
{
    public class ServiceDto
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
        
        public string Procedure { get; set; }
        
        public Status Status { get; set; }
        public decimal Price { get; set; }
    }
}
