using DentisBooking.Data.Configurations;
using DentisBooking.Data.Entities;
using DentisBooking.Data.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace DentisBooking.Data.DataContext
{
    public class DentistDBContext : IdentityDbContext<User,Role,Guid>
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
            modelBuilder.ApplyConfiguration(new RoleConfiguration());

            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("UserLogins").HasKey(x => x.UserId);
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("UserRoles").HasKey(x => new {x.UserId,x.RoleId});
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("UserTokens").HasKey(x => x.UserId);


            modelBuilder.Seed();

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

