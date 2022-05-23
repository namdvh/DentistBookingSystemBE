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
                         Created_by = Guid.Parse("4bc632aa-7765-4040-9fbf-f2bb408d8e" + i),
                         Updated_by = Guid.Parse("4bc632aa-7765-4040-9fbf-f2bb408d8e" + i),
                         Deleted_by = Guid.Parse("4bc632aa-7765-4040-9fbf-f2bb408d8e" + i),
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
                         Phone = 0868644651,
                         Created_at = DateTime.Now,
                         Updated_at = DateTime.Now,
                         Deleted_at = DateTime.Now,
                         Created_by = Guid.Parse("4bc632aa-7765-4040-9fbf-f2bb408d8e" + i),
                         Updated_by = Guid.Parse("4bc632aa-7765-4040-9fbf-f2bb408d8e" + i),
                         Deleted_by = Guid.Parse("4bc632aa-7765-4040-9fbf-f2bb408d8e" + i),
                     }); ;

            }

            //dentist
            for (int i = 20; i < 71; i++)
            {
                modelBuilder.Entity<Dentist>().HasData(
                    new Dentist()
                    {
                        Id = Guid.Parse("4bc632aa-7765-4040-9fbf-f2bb408d8e" + i),
                        Email = "testDentist@gmail.com" + i,
                        PasswordHash = "1",
                        FirstName = "Nguyen",
                        LastName = "Anh Thinh",
                        Gender = "Male",
                        PhoneNumber = "113",
                        Token = "xxx",
                        Status = Enum.Status.ACTIVE,
                        Position = Enum.Position.HEAD,
                        Description = "TestDescirption" + i,
                        Created_at = DateTime.Now,
                        Updated_at = DateTime.Now,
                        Deleted_at = DateTime.Now,
                        Created_by = Guid.Parse("4bc632aa-7765-4040-9fbf-f2bb408d8e" + i),
                        Updated_by = Guid.Parse("4bc632aa-7765-4040-9fbf-f2bb408d8e" + i),
                        Deleted_by = Guid.Parse("4bc632aa-7765-4040-9fbf-f2bb408d8e" + i),
                        ClinicId = i
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
                        Created_by = Guid.Parse("74965f04-3baa-44ef-878a-50862a6fe9" + i),
                        Updated_by = Guid.Parse("74965f04-3baa-44ef-878a-50862a6fe9" + i),
                        Deleted_by = Guid.Parse("74965f04-3baa-44ef-878a-50862a6fe9" + i),
                        DiscountId = i
                    });
            }

            //dentist-service
            for (int i = 20; i < 31; i++)
            {

                modelBuilder.Entity<ServiceDentist>().HasData(
                    new ServiceDentist()
                    {
                        DentistId = Guid.Parse("4bc632aa-7765-4040-9fbf-f2bb408d8e" + i),
                        ServiceId = 1
                    });
            }

            for (int i = 31; i < 41; i++)
            {

                modelBuilder.Entity<ServiceDentist>().HasData(
                    new ServiceDentist()
                    {
                        DentistId = Guid.Parse("4bc632aa-7765-4040-9fbf-f2bb408d8e" + i),
                        ServiceId = 2
                    });
            }

            for (int i = 41; i < 51; i++)
            {

                modelBuilder.Entity<ServiceDentist>().HasData(
                    new ServiceDentist()
                    {
                        DentistId = Guid.Parse("4bc632aa-7765-4040-9fbf-f2bb408d8e" + i),
                        ServiceId = 3
                    });
            }

            for (int i = 51; i < 61; i++)
            {

                modelBuilder.Entity<ServiceDentist>().HasData(
                    new ServiceDentist()
                    {
                        DentistId = Guid.Parse("4bc632aa-7765-4040-9fbf-f2bb408d8e" + i),
                        ServiceId = 4
                    });
            }

            for (int i = 61; i < 71; i++)
            {

                modelBuilder.Entity<ServiceDentist>().HasData(
                    new ServiceDentist()
                    {
                        DentistId = Guid.Parse("4bc632aa-7765-4040-9fbf-f2bb408d8e" + i),
                        ServiceId = 5
                    });
            }

            modelBuilder.Entity<Role>().HasData(new Role
            {
                Id = Guid.Parse("20EFD516-F16C-41B3-B11D-BC908CD2056C"),
                Description = "Admin"
            },
            new Role
            {
                Id = Guid.Parse("20EFD516-F16C-41B3-B11D-BC908CD2056B"),
                Description = "User"
            });

            for (int i = 20; i < 51; i++)
            {
                modelBuilder.Entity<User>().HasData(new User
                {
                    Id = Guid.Parse("D5A918C6-5ED4-43EB-BCDF-042594AE26"+i),
                    Email = "anhkhoahuynh90@gmail.com",
                    PasswordHash = hasher.HashPassword(null, "1"),
                    SecurityStamp = string.Empty,
                    FirstName = "Huynh",
                    LastName = "Anh Khoa",
                    DOB = new DateTime(2021, 07, 12),
                    PhoneNumber = "0868644651",
                    Gender = "Male",
                    Token = "xxx",
                    Status = Enum.Status.ACTIVE,
                    Created_at = DateTime.UtcNow,
                    Updated_at = DateTime.UtcNow,
                    Deleted_at = DateTime.UtcNow,
                    Created_by = Guid.Parse("D5A918C6-5ED4-43EB-BCDF-042594AE26" + i),
                    Updated_by = Guid.Parse("D5A918C6-5ED4-43EB-BCDF-042594AE26" + i),
                    Deleted_by = Guid.Parse("D5A918C6-5ED4-43EB-BCDF-042594AE26" + i)
                });

                modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
                {
                    RoleId = Guid.Parse("20EFD516-F16C-41B3-B11D-BC908CD2056C"),
                    UserId = Guid.Parse("D5A918C6-5ED4-43EB-BCDF-042594AE26" + i),
                });

                modelBuilder.Entity<Booking>.Has
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
                    Gender = "Male",
                    Token = "xxx",
                    Status = Enum.Status.ACTIVE,
                    Created_at = DateTime.UtcNow,
                    Updated_at = DateTime.UtcNow,
                    Deleted_at = DateTime.UtcNow,
                    Created_by = Guid.Parse("D5A918C6-5ED4-43EB-BCDF-042594AE33" + i),
                    Updated_by = Guid.Parse("D5A918C6-5ED4-43EB-BCDF-042594AE33" + i),
                    Deleted_by = Guid.Parse("D5A918C6-5ED4-43EB-BCDF-042594AE33" + i)
                });

                modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
                {
                    RoleId = Guid.Parse("20EFD516-F16C-41B3-B11D-BC908CD2056B"),
                    UserId = Guid.Parse("D5A918C6-5ED4-43EB-BCDF-042594AE33" + i),
                });
            }





        }
    }
}
