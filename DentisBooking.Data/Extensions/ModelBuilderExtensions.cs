//using DentisBooking.Data.Entities;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DentisBooking.Data.Extensions
//{
//    public static class ModelBuilderExtensions
//    {

//        public static void Seed(this ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<User>.HasData(
//                new User() {
//                    Email = "test@gmail.com",
//                    Password = "1",
//                    FirstName = "Huynh",
//                    LastName = "Anh Khoa",
//                    Role = Data.Enum.AllCode.ADMIN,
//                    Status = Data.Enum.AllCode.ACTIVE,
//                    Phone = 0868644651,
//                    Gender = "Male",
//                    DOB = DateTime.Parse("01/01/2002"),
//                    Token = "xxx",
//                    Created_at = DateTime.Now,



//                }
//                );
//        }
//    }
//}
