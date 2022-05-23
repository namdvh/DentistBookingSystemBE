using DentisBooking.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DentisBooking.Data.Configurations
{
    public class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.ToTable("Services");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();


            builder.Property(x => x.Procedure).IsRequired().HasMaxLength(500);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(300);
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.Price).IsRequired();

            //builder.HasOne(x => x.BookingDetail)
            //       .WithOne(x => x.Service)
            //       .HasForeignKey<BookingDetail>(x => x.ServiceId);

            //builder.HasMany(x => x.Images)
            //       .WithOne(x => x.Service)
            //       .HasForeignKey(x => x.ServiceId);

            builder.Property(x => x.Created_at).HasDefaultValueSql("getutcdate()");
        }
    }
}
