using DentisBooking.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentisBooking.Data.Extensions
{
    public static class ModelBuilderExtensions
    {

        public static void Seed(this ModelBuilder modelBuilder)
        {

            var hasher = new PasswordHasher<User>();

            //discount
            for (int i = 1; i <= 5; i++)
            {
                modelBuilder.Entity<Discount>().HasData(
                     new Discount()
                     {
                         Id = i,
                         Title = "TestTitle" + i,
                         StartDate = DateTime.Now,
                         EndDate = DateTime.Now,
                         Description = "TestDescirption" + i,
                         Percent = 5,
                         Amount = 10,
                         ApplyForAll = true,
                         Created_at = DateTime.Now,
                         Updated_at = DateTime.Now,
                         Deleted_at = DateTime.Now,
                         Created_by = Guid.Parse("4bc632aa-7765-4040-9fbf-f2bb408d8e5" + i),
                         Updated_by = Guid.Parse("4bc632aa-7765-4040-9fbf-f2bb408d8e5" + i),
                         Deleted_by = Guid.Parse("4bc632aa-7765-4040-9fbf-f2bb408d8e5" + i),
                     });

            }

            //clinic
            for (int i = 1; i <= 5; i++)
            {
                modelBuilder.Entity<Clinic>().HasData(
                     new Clinic()
                     {
                         Id = i,
                         Name = "TestClinic" + i,
                         Description = "TestDescirption" + i,
                         Address = "TestAddress" + i,
                         Phone = "0868644651",
                         Created_at = DateTime.Now,
                         Updated_at = DateTime.Now,
                         Deleted_at = DateTime.Now,
                         Created_by = Guid.Parse("4bc632aa-7765-4040-9fbf-f2bb408d8e5" + i),
                         Updated_by = Guid.Parse("4bc632aa-7765-4040-9fbf-f2bb408d8e5" + i),
                         Deleted_by = Guid.Parse("4bc632aa-7765-4040-9fbf-f2bb408d8e5" + i),
                     }); ;

            }

            //dentist

            for (int i = 10; i < 20; i++)
            {
                modelBuilder.Entity<Dentist>().HasData(
                new Dentist()
                {
                    Id = i,
                    Position = Enum.Position.HEAD,
                    Description = "TestDescirption" + i,
                    ClinicId = 1

                });
            }

            for (int i = 20; i < 72; i++)
            {
                modelBuilder.Entity<Dentist>().HasData(
                new Dentist()
                {
                    Id = i,
                    Position = Enum.Position.HEAD,
                    Description = "TestDescirption" + i,
                    ClinicId = 1

                });
            }

            //service
            for (int i = 1; i < 6; i++)
            {

                modelBuilder.Entity<Service>().HasData(
                    new Service()
                    {
                        Id = i,
                        Name = "testService@gmail.com" + i,
                        Procedure = "testProcedure" + i,
                        Status = Enum.Status.ACTIVE,
                        Price = i,
                        Created_at = DateTime.Now,
                        Updated_at = DateTime.Now,
                        Deleted_at = DateTime.Now,
                        Created_by = Guid.Parse("74965f04-3baa-44ef-878a-50862a6fe9a" + i),
                        Updated_by = Guid.Parse("74965f04-3baa-44ef-878a-50862a6fe9a" + i),
                        Deleted_by = Guid.Parse("74965f04-3baa-44ef-878a-50862a6fe9a" + i),
                        DiscountId = i
                    });
            }

            //dentist-service
            for (int i = 20; i < 31; i++)
            {

                modelBuilder.Entity<ServiceDentist>().HasData(
                    new ServiceDentist()
                    {
                        DentistId = i,
                        ServiceId = 1
                    });
            }

            for (int i = 31; i < 41; i++)
            {

                modelBuilder.Entity<ServiceDentist>().HasData(
                    new ServiceDentist()
                    {
                        DentistId = i,
                        ServiceId = 2
                    });
            }

            for (int i = 41; i < 51; i++)
            {

                modelBuilder.Entity<ServiceDentist>().HasData(
                    new ServiceDentist()
                    {
                        DentistId = i,
                        ServiceId = 3
                    });
            }

            for (int i = 51; i < 61; i++)
            {

                modelBuilder.Entity<ServiceDentist>().HasData(
                    new ServiceDentist()
                    {
                        DentistId = i,
                        ServiceId = 4
                    });
            }

            for (int i = 61; i < 71; i++)
            {

                modelBuilder.Entity<ServiceDentist>().HasData(
                    new ServiceDentist()
                    {
                        DentistId = i,
                        ServiceId = 5
                    });
            }

            modelBuilder.Entity<Role>().HasData(new Role
            {
                Id = Guid.Parse("20EFD516-F16C-41B3-B11D-BC908CD2056C"),
                Description = "Admin",
                Name = "Admin",
                NormalizedName = "ADMIN"
            },
            new Role
            {
                Id = Guid.Parse("20EFD516-F16C-41B3-B11D-BC908CD2056B"),
                Description = "User",
                Name = "User",
                NormalizedName = "USER"
            },
            new Role
            {
                Id = Guid.Parse("20EFD516-F16C-41B3-B11D-BC908CD2056D"),
                Description = "Docter",
                Name = "Docter",
                NormalizedName = "DOCTER"
            });

            for (int i = 20; i < 51; i++)
            {
                modelBuilder.Entity<User>().HasData(new User
                {
                    Id = Guid.Parse("D5A918C6-5ED4-43EB-BCDF-042594AE26" + i),
                    Email = "anhkhoahuynh90@gmail.com",
                    PasswordHash = hasher.HashPassword(null, "1"),
                    SecurityStamp = string.Empty,
                    FirstName = "Huynh",
                    LastName = "Anh Khoa",
                    DOB = new DateTime(2021, 07, 12),
                    PhoneNumber = "0868644651",
                    Gender = Enum.Gender.MALE,
                    Token = "xxx",
                    Status = Enum.Status.ACTIVE,
                    Created_at = DateTime.UtcNow,
                    Updated_at = DateTime.UtcNow,
                    Deleted_at = DateTime.UtcNow,
                    Created_by = Guid.Parse("D5A918C6-5ED4-43EB-BCDF-042594AE26" + i),
                    Updated_by = Guid.Parse("D5A918C6-5ED4-43EB-BCDF-042594AE26" + i),
                    Deleted_by = Guid.Parse("D5A918C6-5ED4-43EB-BCDF-042594AE26" + i)
                });

                modelBuilder.Entity<Booking>().HasData(new Booking
                {
                    Id = i - 19,
                    Date = DateTime.UtcNow,
                    Total = 100,
                    Status = Enum.Status.ACTIVE,
                    Created_at = DateTime.UtcNow,
                    Updated_at = DateTime.UtcNow,
                    Deleted_at = DateTime.UtcNow,
                    UserId = Guid.Parse("D5A918C6-5ED4-43EB-BCDF-042594AE26" + i),
                    Updated_by = Guid.Parse("D5A918C6-5ED4-43EB-BCDF-042594AE26" + i),
                    Deleted_by = Guid.Parse("D5A918C6-5ED4-43EB-BCDF-042594AE26" + i)

                });

                modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
                {
                    RoleId = Guid.Parse("20EFD516-F16C-41B3-B11D-BC908CD2056C"),
                    UserId = Guid.Parse("D5A918C6-5ED4-43EB-BCDF-042594AE26" + i),
                });

            }

            for (int i = 51; i < 72; i++)
            {
                modelBuilder.Entity<User>().HasData(new User
                {
                    Id = Guid.Parse("D5A918C6-5ED4-43EB-BCDF-042594AE33" + i),
                    Email = "ducsama90@gmail.com",
                    PasswordHash = hasher.HashPassword(null, "1"),
                    SecurityStamp = string.Empty,
                    FirstName = "Nguyen",
                    LastName = "Duong Minh Duc",
                    DOB = new DateTime(2021, 07, 12),
                    PhoneNumber = "0868644651",
                    Gender = Enum.Gender.FEMALE,
                    Token = "xxx",
                    Status = Enum.Status.ACTIVE,
                    Created_at = DateTime.UtcNow,
                    Updated_at = DateTime.UtcNow,
                    Deleted_at = DateTime.UtcNow,
                    Created_by = Guid.Parse("D5A918C6-5ED4-43EB-BCDF-042594AE33" + i),
                    Updated_by = Guid.Parse("D5A918C6-5ED4-43EB-BCDF-042594AE33" + i),
                    Deleted_by = Guid.Parse("D5A918C6-5ED4-43EB-BCDF-042594AE33" + i),

                    DentistId = i
                });

                modelBuilder.Entity<Booking>().HasData(new Booking
                {
                    Id = i - 19,
                    Date = DateTime.UtcNow,
                    Total = 200,
                    Status = Enum.Status.ACTIVE,
                    Created_at = DateTime.UtcNow,
                    Updated_at = DateTime.UtcNow,
                    Deleted_at = DateTime.UtcNow,
                    UserId = Guid.Parse("D5A918C6-5ED4-43EB-BCDF-042594AE33" + i),
                    Updated_by = Guid.Parse("D5A918C6-5ED4-43EB-BCDF-042594AE33" + i),
                    Deleted_by = Guid.Parse("D5A918C6-5ED4-43EB-BCDF-042594AE33" + i)

                });


                modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
                {
                    RoleId = Guid.Parse("20EFD516-F16C-41B3-B11D-BC908CD2056B"),
                    UserId = Guid.Parse("D5A918C6-5ED4-43EB-BCDF-042594AE33" + i),
                });
            }

            int start = 1;
            int end = 4;
            int k;
            for (int i = 10; i < 61; i++)
            {
                k = 1;
                for (int j = start; j < end; j++)
                {
                    modelBuilder.Entity<BookingDetail>().HasData(new BookingDetail
                    {
                        Id = j,
                        DentistId = i,
                        KeyTime = Enum.KeyTime._7h_7h30,
                        Note = "nhe nhang thoi nha bac si",
                        Status = Enum.Status.ACTIVE,
                        BookingId = i - 9,
                        ServiceId = 1,
                        Created_at = DateTime.UtcNow,
                        Updated_at = DateTime.UtcNow,
                        Deleted_at = DateTime.UtcNow,
                        Created_by = Guid.Parse("D5A918C6-5ED4-43EB-BCDF-042594AE33" + i),
                        Updated_by = Guid.Parse("D5A918C6-5ED4-43EB-BCDF-042594AE33" + i),
                        Deleted_by = Guid.Parse("D5A918C6-5ED4-43EB-BCDF-042594AE33" + i)
                    });
                    k++;
                }
                start = start + 3;
                end = end + 3;
            }
        }
    }
}





