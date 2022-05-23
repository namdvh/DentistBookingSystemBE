using DentisBooking.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DentisBooking.Data.Configurations
{
    public class DentistConfiguration : IEntityTypeConfiguration<Dentist>
    {
        public void Configure(EntityTypeBuilder<Dentist> builder)
        {
            builder.ToTable("Dentists");
            builder.HasKey(x=> x.Id);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Password).IsRequired();
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.Position).IsRequired();
            builder.Property(x => x.Description).IsRequired().HasMaxLength(1000);
            builder.Property(x => x.Phone).IsRequired().HasMaxLength(15);
            builder.Property(x => x.Gender).IsRequired();
            builder.Property(x => x.Token).IsRequired();
            builder.HasOne(x => x.Clinic).WithMany(x => x.Dentists).HasForeignKey(x=>x.ClinicId);
            //builder.HasOne(x => x.Image).WithOne(x => x.Dentist).HasForeignKey<Image>(x=>x.DentistId); 
            builder.Property(x=>x.Created_at).HasDefaultValueSql("getutcdate()");
        }

    }
}
