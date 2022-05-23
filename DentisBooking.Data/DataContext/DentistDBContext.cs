using DentisBooking.Data.Configurations;
using DentisBooking.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DentisBooking.Data.DataContext
{
    public class DentistDBContext : DbContext
    {
        public DentistDBContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new BookingConfiguration());
            modelBuilder.ApplyConfiguration(new BookingDetailConfiguration());
            modelBuilder.ApplyConfiguration(new DiscountConfiguration());
            modelBuilder.ApplyConfiguration(new ClinicConfiguration());
            modelBuilder.ApplyConfiguration(new ServiceConfiguration());
            modelBuilder.ApplyConfiguration(new DentistConfiguration());
            modelBuilder.ApplyConfiguration(new ServiceDentistConfiguration());

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookingDetail> BookingDetails { get; set; }
        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Dentist> Dentists { get; set; }
        public DbSet<ServiceDentist> ServiceDentists { get; set; }


    }
}

