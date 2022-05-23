using DentisBooking.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DentisBooking.Data.Configurations
{
    public class BookingDetailConfiguration : IEntityTypeConfiguration<BookingDetail>
    {
        public void Configure(EntityTypeBuilder<BookingDetail> builder)
        {
            builder.ToTable("Booking_Details");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Note).HasMaxLength(300);

            builder.HasOne(x => x.Booking)
                   .WithMany(x => x.BookingDetail)
                   .HasForeignKey(x => x.BookingId);

            builder.HasOne(x => x.Service)
                   .WithOne(x => x.BookingDetail)
                   .HasForeignKey<BookingDetail>(x => x.ServiceId);

            builder.Property(x => x.Created_at).HasDefaultValueSql("getutcdate()");

        }
    }
}
