using DentisBooking.Data.Entities;
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
        }
    }
}
