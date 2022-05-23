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
            //modelBuilder.Entity<User>().HasData(
            //    new User() {
            //        Id = Guid.Parse("854b84b1-9f37-4c78-acf8-4cdeaa8a1b72"),
            //        Email = "test@gmail.com",
            //        Password = "1",
            //        FirstName = "Huynh",
            //        LastName = "Anh Khoa",
            //        Role = Data.Enum.AllCode.ADMIN,
            //        Status = Data.Enum.AllCode.ACTIVE,
            //        Phone = 0868644651,
            //        Gender = "Male",
            //        DOB = DateTime.Parse("01/01/2002"),
            //        Token = "xxx",
            //        Created_at = DateTime.Now,
            //        Updated_at = DateTime.Now,
            //        Deleted_at = DateTime.Now,
            //        Created_by = Guid.Parse("854b84b1-9f37-4c78-acf8-4cdeaa8a1b72"),
            //        Updated_by = Guid.Parse("854b84b1-9f37-4c78-acf8-4cdeaa8a1b72"),
            //        Deleted_by = Guid.Parse("854b84b1-9f37-4c78-acf8-4cdeaa8a1b72")
            //    });
            var adminId = new Guid("D5A918C6-5ED4-43EB-BCDF-042594AE26CF");
            var roleId = new Guid("20EFD516-F16C-41B3-B11D-BC908CD20565");
            var hasher = new PasswordHasher<User>();
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = adminId,
                NormalizedUserName = "admin",
                Email = "doanvuhoainam15@gmail.com",
                NormalizedEmail = "doanvuhoainam15@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "abcd1234$"),
                SecurityStamp = string.Empty,
                FirstName = "Toan",
                LastName = "Bach",
                DOB = new DateTime(2021, 07, 12),
                Gender="male"
            });
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId,
            });
        }
    }
}
