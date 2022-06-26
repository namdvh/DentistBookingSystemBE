using DentisBooking.Data.Enum;

namespace DentistBooking.ViewModels.System.Dentists
{
    public class DentistServiceDto
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
        
        public string Procedure { get; set; }
        
        public Status Status { get; set; }
        public decimal Price { get; set; }
    }
}