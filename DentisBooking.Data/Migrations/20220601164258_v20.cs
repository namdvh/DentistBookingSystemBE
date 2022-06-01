using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DentisBooking.Data.Migrations
{
    public partial class v20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Discounts_DiscountId",
                table: "Services");

            migrationBuilder.AlterColumn<int>(
                name: "DiscountId",
                table: "Services",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(301), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(2531), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(1379) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7265), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7277), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7274) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7345), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7349), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7347) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7392), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7397), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7395) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7435), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7440), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7438) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7485), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7489), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7487) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7527), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7531), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7568), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7573), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7608), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7612), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7807), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7811), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7809) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7852), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7856), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7854) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7893), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7898), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7895) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7934), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7939), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7937) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7975), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7979), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8015), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8019), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8017) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8055), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8059), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8057) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8095), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8099), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8097) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8286), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8290), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8288) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8338), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8342), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8379), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8384), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8382) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8420), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8424), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8422) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8461), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8466), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8463) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8501), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8506), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8504) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8542), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8546), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8544) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8583), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8587), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8585) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8623), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8627), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8625) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8766), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8771), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8768) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8813), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8817), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8815) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8853), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8857), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8894), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8898), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8934), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8939), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8937) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8975), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8979), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(8977) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9014), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9019), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9017) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9057), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9062), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9059) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9195), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9200), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9198) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9242), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9247), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9245) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9283), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9287), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9285) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9323), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9327), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9325) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9362), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9366), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9402), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9406), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9404) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9442), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9446), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9444) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9482), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9486), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9523), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9527), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9525) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9660), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9665), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9662) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9704), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9708), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9706) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9745), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9749), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9747) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9785), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9789), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9787) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9825), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9829), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9827) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9865), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9870), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9867) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9905), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9909), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9907) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9945), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9949), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9947) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9985), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9989), new DateTime(2022, 6, 1, 16, 42, 54, 838, DateTimeKind.Utc).AddTicks(9987) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(128), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(132), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(130) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(170), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(175), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(173) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(211), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(216), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(252), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(256), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(254) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(292), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(297), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(295) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(333), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(337), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(335) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(372), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(377), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(375) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(413), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(417), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(453), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(458), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(679), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(683), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(681) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(720), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(724), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(722) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(760), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(764), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(762) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(800), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(804), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(802) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(844), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(848), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(846) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(885), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(889), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(887) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(924), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(928), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(926) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1067), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1071), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1069) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1114), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1118), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1116) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1154), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1158), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1156) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1194), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1199), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1197) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1472), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1477), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1514), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1518), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1516) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1553), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1558), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1556) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1594), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1598), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1634), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1638), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1779), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1783), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1781) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1828), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1832), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1830) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1868), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1873), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1870) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1909), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1913), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1911) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1950), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1954), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1991), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1995), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(1993) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2030), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2035), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2032) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2070), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2075), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2073) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2110), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2114), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2112) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2253), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2258), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2255) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2295), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2299), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2297) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2336), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2341), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2338) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2378), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2382), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2419), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2423), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2421) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2459), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2464), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2461) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2499), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2504), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2501) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2540), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2544), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2580), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2584), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2582) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2722), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2726), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2724) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2763), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2768), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2765) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2804), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2808), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2806) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2843), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2848), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2846) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2884), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2888), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2886) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2923), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2928), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2926) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2963), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2967), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(2965) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3003), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3007), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3005) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3138), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3142), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3140) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3184), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3188), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3224), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3229), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3227) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3265), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3269), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3267) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3305), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3309), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3345), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3349), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3386), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3390), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3388) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3426), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3430), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3428) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3465), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3470), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3467) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3602), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3608), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3605) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3650), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3654), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3652) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3691), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3696), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3694) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3732), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3737), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3735) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3773), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3777), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3775) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3814), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3818), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3816) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3853), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3858), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3856) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3894), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3898), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3896) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3933), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3937), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(3935) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4071), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4076), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4074) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4116), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4121), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4118) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4158), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4163), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4160) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4200), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4204), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4202) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4240), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4244), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4242) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4281), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4285), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4321), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4325), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4323) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4440), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4445), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4443) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4678), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4683), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4681) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4722), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4726), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4724) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4762), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4767), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4765) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4803), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4807), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4842), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4846), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4844) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4881), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4885), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4883) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4922), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4926), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(4924) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5063), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5068), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5065) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5110), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5115), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5112) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5151), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5155), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5153) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5192), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5197), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5194) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5232), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5236), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5234) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5272), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5276), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5274) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5311), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5315), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5313) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5350), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5355), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5390), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5394), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5392) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5526), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5532), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5529) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5573), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5578), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5575) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5614), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5618), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5616) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5655), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5659), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5695), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5699), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5697) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5735), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5739), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5737) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5773), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5778), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5776) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5813), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5817), new DateTime(2022, 6, 1, 16, 42, 54, 839, DateTimeKind.Utc).AddTicks(5815) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 53, 901, DateTimeKind.Utc).AddTicks(5020), new DateTime(2022, 6, 1, 16, 42, 53, 901, DateTimeKind.Utc).AddTicks(2720), new DateTime(2022, 6, 1, 16, 42, 53, 901, DateTimeKind.Utc).AddTicks(6558), new DateTime(2022, 6, 1, 16, 42, 53, 901, DateTimeKind.Utc).AddTicks(5754) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 53, 921, DateTimeKind.Utc).AddTicks(5174), new DateTime(2022, 6, 1, 16, 42, 53, 921, DateTimeKind.Utc).AddTicks(5168), new DateTime(2022, 6, 1, 16, 42, 53, 921, DateTimeKind.Utc).AddTicks(5181), new DateTime(2022, 6, 1, 16, 42, 53, 921, DateTimeKind.Utc).AddTicks(5177) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 53, 939, DateTimeKind.Utc).AddTicks(9185), new DateTime(2022, 6, 1, 16, 42, 53, 939, DateTimeKind.Utc).AddTicks(9178), new DateTime(2022, 6, 1, 16, 42, 53, 939, DateTimeKind.Utc).AddTicks(9192), new DateTime(2022, 6, 1, 16, 42, 53, 939, DateTimeKind.Utc).AddTicks(9188) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 53, 958, DateTimeKind.Utc).AddTicks(4086), new DateTime(2022, 6, 1, 16, 42, 53, 958, DateTimeKind.Utc).AddTicks(4079), new DateTime(2022, 6, 1, 16, 42, 53, 958, DateTimeKind.Utc).AddTicks(4092), new DateTime(2022, 6, 1, 16, 42, 53, 958, DateTimeKind.Utc).AddTicks(4088) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 53, 976, DateTimeKind.Utc).AddTicks(4492), new DateTime(2022, 6, 1, 16, 42, 53, 976, DateTimeKind.Utc).AddTicks(4483), new DateTime(2022, 6, 1, 16, 42, 53, 976, DateTimeKind.Utc).AddTicks(4498), new DateTime(2022, 6, 1, 16, 42, 53, 976, DateTimeKind.Utc).AddTicks(4494) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 53, 994, DateTimeKind.Utc).AddTicks(3791), new DateTime(2022, 6, 1, 16, 42, 53, 994, DateTimeKind.Utc).AddTicks(3787), new DateTime(2022, 6, 1, 16, 42, 53, 994, DateTimeKind.Utc).AddTicks(3797), new DateTime(2022, 6, 1, 16, 42, 53, 994, DateTimeKind.Utc).AddTicks(3794) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 12, DateTimeKind.Utc).AddTicks(5181), new DateTime(2022, 6, 1, 16, 42, 54, 12, DateTimeKind.Utc).AddTicks(5175), new DateTime(2022, 6, 1, 16, 42, 54, 12, DateTimeKind.Utc).AddTicks(5187), new DateTime(2022, 6, 1, 16, 42, 54, 12, DateTimeKind.Utc).AddTicks(5183) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 30, DateTimeKind.Utc).AddTicks(6671), new DateTime(2022, 6, 1, 16, 42, 54, 30, DateTimeKind.Utc).AddTicks(6665), new DateTime(2022, 6, 1, 16, 42, 54, 30, DateTimeKind.Utc).AddTicks(6679), new DateTime(2022, 6, 1, 16, 42, 54, 30, DateTimeKind.Utc).AddTicks(6674) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 48, DateTimeKind.Utc).AddTicks(9876), new DateTime(2022, 6, 1, 16, 42, 54, 48, DateTimeKind.Utc).AddTicks(9869), new DateTime(2022, 6, 1, 16, 42, 54, 48, DateTimeKind.Utc).AddTicks(9883), new DateTime(2022, 6, 1, 16, 42, 54, 48, DateTimeKind.Utc).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 67, DateTimeKind.Utc).AddTicks(825), new DateTime(2022, 6, 1, 16, 42, 54, 67, DateTimeKind.Utc).AddTicks(819), new DateTime(2022, 6, 1, 16, 42, 54, 67, DateTimeKind.Utc).AddTicks(831), new DateTime(2022, 6, 1, 16, 42, 54, 67, DateTimeKind.Utc).AddTicks(828) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 85, DateTimeKind.Utc).AddTicks(950), new DateTime(2022, 6, 1, 16, 42, 54, 85, DateTimeKind.Utc).AddTicks(944), new DateTime(2022, 6, 1, 16, 42, 54, 85, DateTimeKind.Utc).AddTicks(955), new DateTime(2022, 6, 1, 16, 42, 54, 85, DateTimeKind.Utc).AddTicks(952) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 103, DateTimeKind.Utc).AddTicks(1858), new DateTime(2022, 6, 1, 16, 42, 54, 103, DateTimeKind.Utc).AddTicks(1850), new DateTime(2022, 6, 1, 16, 42, 54, 103, DateTimeKind.Utc).AddTicks(1864), new DateTime(2022, 6, 1, 16, 42, 54, 103, DateTimeKind.Utc).AddTicks(1861) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 121, DateTimeKind.Utc).AddTicks(5360), new DateTime(2022, 6, 1, 16, 42, 54, 121, DateTimeKind.Utc).AddTicks(5353), new DateTime(2022, 6, 1, 16, 42, 54, 121, DateTimeKind.Utc).AddTicks(5366), new DateTime(2022, 6, 1, 16, 42, 54, 121, DateTimeKind.Utc).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 139, DateTimeKind.Utc).AddTicks(9991), new DateTime(2022, 6, 1, 16, 42, 54, 139, DateTimeKind.Utc).AddTicks(9985), new DateTime(2022, 6, 1, 16, 42, 54, 139, DateTimeKind.Utc).AddTicks(9997), new DateTime(2022, 6, 1, 16, 42, 54, 139, DateTimeKind.Utc).AddTicks(9994) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 158, DateTimeKind.Utc).AddTicks(3295), new DateTime(2022, 6, 1, 16, 42, 54, 158, DateTimeKind.Utc).AddTicks(3288), new DateTime(2022, 6, 1, 16, 42, 54, 158, DateTimeKind.Utc).AddTicks(3301), new DateTime(2022, 6, 1, 16, 42, 54, 158, DateTimeKind.Utc).AddTicks(3297) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 176, DateTimeKind.Utc).AddTicks(5485), new DateTime(2022, 6, 1, 16, 42, 54, 176, DateTimeKind.Utc).AddTicks(5478), new DateTime(2022, 6, 1, 16, 42, 54, 176, DateTimeKind.Utc).AddTicks(5491), new DateTime(2022, 6, 1, 16, 42, 54, 176, DateTimeKind.Utc).AddTicks(5488) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 198, DateTimeKind.Utc).AddTicks(6203), new DateTime(2022, 6, 1, 16, 42, 54, 198, DateTimeKind.Utc).AddTicks(6196), new DateTime(2022, 6, 1, 16, 42, 54, 198, DateTimeKind.Utc).AddTicks(6209), new DateTime(2022, 6, 1, 16, 42, 54, 198, DateTimeKind.Utc).AddTicks(6206) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 216, DateTimeKind.Utc).AddTicks(8138), new DateTime(2022, 6, 1, 16, 42, 54, 216, DateTimeKind.Utc).AddTicks(8132), new DateTime(2022, 6, 1, 16, 42, 54, 216, DateTimeKind.Utc).AddTicks(8144), new DateTime(2022, 6, 1, 16, 42, 54, 216, DateTimeKind.Utc).AddTicks(8140) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 235, DateTimeKind.Utc).AddTicks(1971), new DateTime(2022, 6, 1, 16, 42, 54, 235, DateTimeKind.Utc).AddTicks(1964), new DateTime(2022, 6, 1, 16, 42, 54, 235, DateTimeKind.Utc).AddTicks(1977), new DateTime(2022, 6, 1, 16, 42, 54, 235, DateTimeKind.Utc).AddTicks(1973) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 253, DateTimeKind.Utc).AddTicks(8255), new DateTime(2022, 6, 1, 16, 42, 54, 253, DateTimeKind.Utc).AddTicks(8247), new DateTime(2022, 6, 1, 16, 42, 54, 253, DateTimeKind.Utc).AddTicks(8261), new DateTime(2022, 6, 1, 16, 42, 54, 253, DateTimeKind.Utc).AddTicks(8258) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 272, DateTimeKind.Utc).AddTicks(1268), new DateTime(2022, 6, 1, 16, 42, 54, 272, DateTimeKind.Utc).AddTicks(1260), new DateTime(2022, 6, 1, 16, 42, 54, 272, DateTimeKind.Utc).AddTicks(1274), new DateTime(2022, 6, 1, 16, 42, 54, 272, DateTimeKind.Utc).AddTicks(1271) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 290, DateTimeKind.Utc).AddTicks(2954), new DateTime(2022, 6, 1, 16, 42, 54, 290, DateTimeKind.Utc).AddTicks(2943), new DateTime(2022, 6, 1, 16, 42, 54, 290, DateTimeKind.Utc).AddTicks(2960), new DateTime(2022, 6, 1, 16, 42, 54, 290, DateTimeKind.Utc).AddTicks(2956) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 308, DateTimeKind.Utc).AddTicks(5166), new DateTime(2022, 6, 1, 16, 42, 54, 308, DateTimeKind.Utc).AddTicks(5155), new DateTime(2022, 6, 1, 16, 42, 54, 308, DateTimeKind.Utc).AddTicks(5175), new DateTime(2022, 6, 1, 16, 42, 54, 308, DateTimeKind.Utc).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 327, DateTimeKind.Utc).AddTicks(4650), new DateTime(2022, 6, 1, 16, 42, 54, 327, DateTimeKind.Utc).AddTicks(4641), new DateTime(2022, 6, 1, 16, 42, 54, 327, DateTimeKind.Utc).AddTicks(4656), new DateTime(2022, 6, 1, 16, 42, 54, 327, DateTimeKind.Utc).AddTicks(4653) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 345, DateTimeKind.Utc).AddTicks(6392), new DateTime(2022, 6, 1, 16, 42, 54, 345, DateTimeKind.Utc).AddTicks(6384), new DateTime(2022, 6, 1, 16, 42, 54, 345, DateTimeKind.Utc).AddTicks(6398), new DateTime(2022, 6, 1, 16, 42, 54, 345, DateTimeKind.Utc).AddTicks(6395) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 363, DateTimeKind.Utc).AddTicks(7059), new DateTime(2022, 6, 1, 16, 42, 54, 363, DateTimeKind.Utc).AddTicks(7051), new DateTime(2022, 6, 1, 16, 42, 54, 363, DateTimeKind.Utc).AddTicks(7065), new DateTime(2022, 6, 1, 16, 42, 54, 363, DateTimeKind.Utc).AddTicks(7061) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 381, DateTimeKind.Utc).AddTicks(7355), new DateTime(2022, 6, 1, 16, 42, 54, 381, DateTimeKind.Utc).AddTicks(7349), new DateTime(2022, 6, 1, 16, 42, 54, 381, DateTimeKind.Utc).AddTicks(7361), new DateTime(2022, 6, 1, 16, 42, 54, 381, DateTimeKind.Utc).AddTicks(7358) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 399, DateTimeKind.Utc).AddTicks(8416), new DateTime(2022, 6, 1, 16, 42, 54, 399, DateTimeKind.Utc).AddTicks(8407), new DateTime(2022, 6, 1, 16, 42, 54, 399, DateTimeKind.Utc).AddTicks(8421), new DateTime(2022, 6, 1, 16, 42, 54, 399, DateTimeKind.Utc).AddTicks(8418) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 417, DateTimeKind.Utc).AddTicks(8438), new DateTime(2022, 6, 1, 16, 42, 54, 417, DateTimeKind.Utc).AddTicks(8431), new DateTime(2022, 6, 1, 16, 42, 54, 417, DateTimeKind.Utc).AddTicks(8444), new DateTime(2022, 6, 1, 16, 42, 54, 417, DateTimeKind.Utc).AddTicks(8441) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 435, DateTimeKind.Utc).AddTicks(8688), new DateTime(2022, 6, 1, 16, 42, 54, 435, DateTimeKind.Utc).AddTicks(8682), new DateTime(2022, 6, 1, 16, 42, 54, 435, DateTimeKind.Utc).AddTicks(8694), new DateTime(2022, 6, 1, 16, 42, 54, 435, DateTimeKind.Utc).AddTicks(8691) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 453, DateTimeKind.Utc).AddTicks(9356), new DateTime(2022, 6, 1, 16, 42, 54, 453, DateTimeKind.Utc).AddTicks(9345), new DateTime(2022, 6, 1, 16, 42, 54, 453, DateTimeKind.Utc).AddTicks(9361), new DateTime(2022, 6, 1, 16, 42, 54, 453, DateTimeKind.Utc).AddTicks(9358) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 472, DateTimeKind.Utc).AddTicks(1262), new DateTime(2022, 6, 1, 16, 42, 54, 472, DateTimeKind.Utc).AddTicks(1254), new DateTime(2022, 6, 1, 16, 42, 54, 472, DateTimeKind.Utc).AddTicks(1268), new DateTime(2022, 6, 1, 16, 42, 54, 472, DateTimeKind.Utc).AddTicks(1265) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 490, DateTimeKind.Utc).AddTicks(5442), new DateTime(2022, 6, 1, 16, 42, 54, 490, DateTimeKind.Utc).AddTicks(5434), new DateTime(2022, 6, 1, 16, 42, 54, 490, DateTimeKind.Utc).AddTicks(5447), new DateTime(2022, 6, 1, 16, 42, 54, 490, DateTimeKind.Utc).AddTicks(5445) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 508, DateTimeKind.Utc).AddTicks(7049), new DateTime(2022, 6, 1, 16, 42, 54, 508, DateTimeKind.Utc).AddTicks(7040), new DateTime(2022, 6, 1, 16, 42, 54, 508, DateTimeKind.Utc).AddTicks(7055), new DateTime(2022, 6, 1, 16, 42, 54, 508, DateTimeKind.Utc).AddTicks(7052) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 527, DateTimeKind.Utc).AddTicks(8817), new DateTime(2022, 6, 1, 16, 42, 54, 527, DateTimeKind.Utc).AddTicks(8809), new DateTime(2022, 6, 1, 16, 42, 54, 527, DateTimeKind.Utc).AddTicks(8823), new DateTime(2022, 6, 1, 16, 42, 54, 527, DateTimeKind.Utc).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 546, DateTimeKind.Utc).AddTicks(516), new DateTime(2022, 6, 1, 16, 42, 54, 546, DateTimeKind.Utc).AddTicks(507), new DateTime(2022, 6, 1, 16, 42, 54, 546, DateTimeKind.Utc).AddTicks(522), new DateTime(2022, 6, 1, 16, 42, 54, 546, DateTimeKind.Utc).AddTicks(518) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 564, DateTimeKind.Utc).AddTicks(6297), new DateTime(2022, 6, 1, 16, 42, 54, 564, DateTimeKind.Utc).AddTicks(6288), new DateTime(2022, 6, 1, 16, 42, 54, 564, DateTimeKind.Utc).AddTicks(6302), new DateTime(2022, 6, 1, 16, 42, 54, 564, DateTimeKind.Utc).AddTicks(6300) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 583, DateTimeKind.Utc).AddTicks(2936), new DateTime(2022, 6, 1, 16, 42, 54, 583, DateTimeKind.Utc).AddTicks(2928), new DateTime(2022, 6, 1, 16, 42, 54, 583, DateTimeKind.Utc).AddTicks(2941), new DateTime(2022, 6, 1, 16, 42, 54, 583, DateTimeKind.Utc).AddTicks(2939) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 601, DateTimeKind.Utc).AddTicks(2165), new DateTime(2022, 6, 1, 16, 42, 54, 601, DateTimeKind.Utc).AddTicks(2152), new DateTime(2022, 6, 1, 16, 42, 54, 601, DateTimeKind.Utc).AddTicks(2171), new DateTime(2022, 6, 1, 16, 42, 54, 601, DateTimeKind.Utc).AddTicks(2168) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 619, DateTimeKind.Utc).AddTicks(5775), new DateTime(2022, 6, 1, 16, 42, 54, 619, DateTimeKind.Utc).AddTicks(5769), new DateTime(2022, 6, 1, 16, 42, 54, 619, DateTimeKind.Utc).AddTicks(5781), new DateTime(2022, 6, 1, 16, 42, 54, 619, DateTimeKind.Utc).AddTicks(5778) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 637, DateTimeKind.Utc).AddTicks(7472), new DateTime(2022, 6, 1, 16, 42, 54, 637, DateTimeKind.Utc).AddTicks(7466), new DateTime(2022, 6, 1, 16, 42, 54, 637, DateTimeKind.Utc).AddTicks(7477), new DateTime(2022, 6, 1, 16, 42, 54, 637, DateTimeKind.Utc).AddTicks(7474) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 655, DateTimeKind.Utc).AddTicks(8599), new DateTime(2022, 6, 1, 16, 42, 54, 655, DateTimeKind.Utc).AddTicks(8595), new DateTime(2022, 6, 1, 16, 42, 54, 655, DateTimeKind.Utc).AddTicks(8605), new DateTime(2022, 6, 1, 16, 42, 54, 655, DateTimeKind.Utc).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 674, DateTimeKind.Utc).AddTicks(438), new DateTime(2022, 6, 1, 16, 42, 54, 674, DateTimeKind.Utc).AddTicks(432), new DateTime(2022, 6, 1, 16, 42, 54, 674, DateTimeKind.Utc).AddTicks(443), new DateTime(2022, 6, 1, 16, 42, 54, 674, DateTimeKind.Utc).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 692, DateTimeKind.Utc).AddTicks(3215), new DateTime(2022, 6, 1, 16, 42, 54, 692, DateTimeKind.Utc).AddTicks(3210), new DateTime(2022, 6, 1, 16, 42, 54, 692, DateTimeKind.Utc).AddTicks(3221), new DateTime(2022, 6, 1, 16, 42, 54, 692, DateTimeKind.Utc).AddTicks(3218) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 710, DateTimeKind.Utc).AddTicks(4991), new DateTime(2022, 6, 1, 16, 42, 54, 710, DateTimeKind.Utc).AddTicks(4985), new DateTime(2022, 6, 1, 16, 42, 54, 710, DateTimeKind.Utc).AddTicks(4997), new DateTime(2022, 6, 1, 16, 42, 54, 710, DateTimeKind.Utc).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 729, DateTimeKind.Utc).AddTicks(2018), new DateTime(2022, 6, 1, 16, 42, 54, 729, DateTimeKind.Utc).AddTicks(2013), new DateTime(2022, 6, 1, 16, 42, 54, 729, DateTimeKind.Utc).AddTicks(2024), new DateTime(2022, 6, 1, 16, 42, 54, 729, DateTimeKind.Utc).AddTicks(2020) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 747, DateTimeKind.Utc).AddTicks(3353), new DateTime(2022, 6, 1, 16, 42, 54, 747, DateTimeKind.Utc).AddTicks(3347), new DateTime(2022, 6, 1, 16, 42, 54, 747, DateTimeKind.Utc).AddTicks(3358), new DateTime(2022, 6, 1, 16, 42, 54, 747, DateTimeKind.Utc).AddTicks(3355) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 765, DateTimeKind.Utc).AddTicks(3694), new DateTime(2022, 6, 1, 16, 42, 54, 765, DateTimeKind.Utc).AddTicks(3689), new DateTime(2022, 6, 1, 16, 42, 54, 765, DateTimeKind.Utc).AddTicks(3699), new DateTime(2022, 6, 1, 16, 42, 54, 765, DateTimeKind.Utc).AddTicks(3696) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 783, DateTimeKind.Utc).AddTicks(3910), new DateTime(2022, 6, 1, 16, 42, 54, 783, DateTimeKind.Utc).AddTicks(3903), new DateTime(2022, 6, 1, 16, 42, 54, 783, DateTimeKind.Utc).AddTicks(3915), new DateTime(2022, 6, 1, 16, 42, 54, 783, DateTimeKind.Utc).AddTicks(3912) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 801, DateTimeKind.Utc).AddTicks(3797), new DateTime(2022, 6, 1, 16, 42, 54, 801, DateTimeKind.Utc).AddTicks(3792), new DateTime(2022, 6, 1, 16, 42, 54, 801, DateTimeKind.Utc).AddTicks(3802), new DateTime(2022, 6, 1, 16, 42, 54, 801, DateTimeKind.Utc).AddTicks(3800) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 819, DateTimeKind.Utc).AddTicks(2761), new DateTime(2022, 6, 1, 16, 42, 54, 819, DateTimeKind.Utc).AddTicks(2757), new DateTime(2022, 6, 1, 16, 42, 54, 819, DateTimeKind.Utc).AddTicks(2766), new DateTime(2022, 6, 1, 16, 42, 54, 819, DateTimeKind.Utc).AddTicks(2764) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 42, 54, 837, DateTimeKind.Utc).AddTicks(1921), new DateTime(2022, 6, 1, 16, 42, 54, 837, DateTimeKind.Utc).AddTicks(1916), new DateTime(2022, 6, 1, 16, 42, 54, 837, DateTimeKind.Utc).AddTicks(1926), new DateTime(2022, 6, 1, 16, 42, 54, 837, DateTimeKind.Utc).AddTicks(1924) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 23, 42, 53, 868, DateTimeKind.Local).AddTicks(7353), new DateTime(2022, 6, 1, 23, 42, 53, 868, DateTimeKind.Local).AddTicks(9108), new DateTime(2022, 6, 1, 23, 42, 53, 868, DateTimeKind.Local).AddTicks(8188) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 23, 42, 53, 869, DateTimeKind.Local).AddTicks(3373), new DateTime(2022, 6, 1, 23, 42, 53, 869, DateTimeKind.Local).AddTicks(3392), new DateTime(2022, 6, 1, 23, 42, 53, 869, DateTimeKind.Local).AddTicks(3387) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 23, 42, 53, 869, DateTimeKind.Local).AddTicks(3498), new DateTime(2022, 6, 1, 23, 42, 53, 869, DateTimeKind.Local).AddTicks(3505), new DateTime(2022, 6, 1, 23, 42, 53, 869, DateTimeKind.Local).AddTicks(3502) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 23, 42, 53, 869, DateTimeKind.Local).AddTicks(3566), new DateTime(2022, 6, 1, 23, 42, 53, 869, DateTimeKind.Local).AddTicks(3572), new DateTime(2022, 6, 1, 23, 42, 53, 869, DateTimeKind.Local).AddTicks(3569) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 23, 42, 53, 869, DateTimeKind.Local).AddTicks(3649), new DateTime(2022, 6, 1, 23, 42, 53, 869, DateTimeKind.Local).AddTicks(3655), new DateTime(2022, 6, 1, 23, 42, 53, 869, DateTimeKind.Local).AddTicks(3652) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Deleted_at", "EndDate", "StartDate", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 23, 42, 53, 864, DateTimeKind.Local).AddTicks(8736), new DateTime(2022, 6, 1, 23, 42, 53, 865, DateTimeKind.Local).AddTicks(1213), new DateTime(2022, 6, 1, 23, 42, 53, 864, DateTimeKind.Local).AddTicks(1496), new DateTime(2022, 6, 1, 23, 42, 53, 862, DateTimeKind.Local).AddTicks(7708), new DateTime(2022, 6, 1, 23, 42, 53, 864, DateTimeKind.Local).AddTicks(9546) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "Deleted_at", "EndDate", "StartDate", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 23, 42, 53, 868, DateTimeKind.Local).AddTicks(1092), new DateTime(2022, 6, 1, 23, 42, 53, 868, DateTimeKind.Local).AddTicks(1099), new DateTime(2022, 6, 1, 23, 42, 53, 868, DateTimeKind.Local).AddTicks(1080), new DateTime(2022, 6, 1, 23, 42, 53, 868, DateTimeKind.Local).AddTicks(1059), new DateTime(2022, 6, 1, 23, 42, 53, 868, DateTimeKind.Local).AddTicks(1095) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "Deleted_at", "EndDate", "StartDate", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 23, 42, 53, 868, DateTimeKind.Local).AddTicks(1435), new DateTime(2022, 6, 1, 23, 42, 53, 868, DateTimeKind.Local).AddTicks(1441), new DateTime(2022, 6, 1, 23, 42, 53, 868, DateTimeKind.Local).AddTicks(1429), new DateTime(2022, 6, 1, 23, 42, 53, 868, DateTimeKind.Local).AddTicks(1424), new DateTime(2022, 6, 1, 23, 42, 53, 868, DateTimeKind.Local).AddTicks(1438) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "Deleted_at", "EndDate", "StartDate", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 23, 42, 53, 868, DateTimeKind.Local).AddTicks(1533), new DateTime(2022, 6, 1, 23, 42, 53, 868, DateTimeKind.Local).AddTicks(1539), new DateTime(2022, 6, 1, 23, 42, 53, 868, DateTimeKind.Local).AddTicks(1528), new DateTime(2022, 6, 1, 23, 42, 53, 868, DateTimeKind.Local).AddTicks(1525), new DateTime(2022, 6, 1, 23, 42, 53, 868, DateTimeKind.Local).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_at", "Deleted_at", "EndDate", "StartDate", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 23, 42, 53, 868, DateTimeKind.Local).AddTicks(1603), new DateTime(2022, 6, 1, 23, 42, 53, 868, DateTimeKind.Local).AddTicks(1609), new DateTime(2022, 6, 1, 23, 42, 53, 868, DateTimeKind.Local).AddTicks(1599), new DateTime(2022, 6, 1, 23, 42, 53, 868, DateTimeKind.Local).AddTicks(1596), new DateTime(2022, 6, 1, 23, 42, 53, 868, DateTimeKind.Local).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "9f984d18-9930-477f-b488-fbbb27d8dd86");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"),
                column: "ConcurrencyStamp",
                value: "1d4effe3-f5b1-4024-9945-48f6506f2487");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 23, 42, 53, 870, DateTimeKind.Local).AddTicks(6026), new DateTime(2022, 6, 1, 23, 42, 53, 870, DateTimeKind.Local).AddTicks(7653), new DateTime(2022, 6, 1, 23, 42, 53, 870, DateTimeKind.Local).AddTicks(6818) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 23, 42, 53, 871, DateTimeKind.Local).AddTicks(2276), new DateTime(2022, 6, 1, 23, 42, 53, 871, DateTimeKind.Local).AddTicks(2296), new DateTime(2022, 6, 1, 23, 42, 53, 871, DateTimeKind.Local).AddTicks(2291) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 23, 42, 53, 871, DateTimeKind.Local).AddTicks(2396), new DateTime(2022, 6, 1, 23, 42, 53, 871, DateTimeKind.Local).AddTicks(2403), new DateTime(2022, 6, 1, 23, 42, 53, 871, DateTimeKind.Local).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 23, 42, 53, 871, DateTimeKind.Local).AddTicks(2467), new DateTime(2022, 6, 1, 23, 42, 53, 871, DateTimeKind.Local).AddTicks(2473), new DateTime(2022, 6, 1, 23, 42, 53, 871, DateTimeKind.Local).AddTicks(2471) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 23, 42, 53, 871, DateTimeKind.Local).AddTicks(2683), new DateTime(2022, 6, 1, 23, 42, 53, 871, DateTimeKind.Local).AddTicks(2689), new DateTime(2022, 6, 1, 23, 42, 53, 871, DateTimeKind.Local).AddTicks(2686) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2620"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "e836e203-3a97-4268-9689-10b67a111ad4", new DateTime(2022, 6, 1, 16, 42, 53, 900, DateTimeKind.Utc).AddTicks(4205), new DateTime(2022, 6, 1, 16, 42, 53, 900, DateTimeKind.Utc).AddTicks(6084), "AQAAAAEAACcQAAAAEKIADewU46Bx9b50JYagAQYH1RaOqWPY8CsZ7hB4SPFNypzrg7s5M6OWcC5EH5rZwA==", new DateTime(2022, 6, 1, 16, 42, 53, 900, DateTimeKind.Utc).AddTicks(4980) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2621"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "60861101-895c-4047-bf24-f710572f48a9", new DateTime(2022, 6, 1, 16, 42, 53, 921, DateTimeKind.Utc).AddTicks(4366), new DateTime(2022, 6, 1, 16, 42, 53, 921, DateTimeKind.Utc).AddTicks(4387), "AQAAAAEAACcQAAAAEN41yYDrtjL/b0RQSPguxgBCUtMfitXiyuQfNLIK0ktzMf95nrP7FBlb/9MrURmtSw==", new DateTime(2022, 6, 1, 16, 42, 53, 921, DateTimeKind.Utc).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2622"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "293af74c-42d6-4bb0-b5dd-221a832bcf5e", new DateTime(2022, 6, 1, 16, 42, 53, 939, DateTimeKind.Utc).AddTicks(8582), new DateTime(2022, 6, 1, 16, 42, 53, 939, DateTimeKind.Utc).AddTicks(8602), "AQAAAAEAACcQAAAAEBfhPeUEqfAo2PnzBOev3p9NAs+jSDtrhLxVSEbqPDwPIYgiZ+uLkuIuW+12i4OXvw==", new DateTime(2022, 6, 1, 16, 42, 53, 939, DateTimeKind.Utc).AddTicks(8598) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2623"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "1997f1e4-3953-4e07-90fe-0f3b546f8553", new DateTime(2022, 6, 1, 16, 42, 53, 958, DateTimeKind.Utc).AddTicks(3381), new DateTime(2022, 6, 1, 16, 42, 53, 958, DateTimeKind.Utc).AddTicks(3402), "AQAAAAEAACcQAAAAEMMFp6kgZiNVSKSRXaxA5JM3DofbXLCZWKeFku9LOuVeAamEq8xb4F6MuhU4lWo/Fg==", new DateTime(2022, 6, 1, 16, 42, 53, 958, DateTimeKind.Utc).AddTicks(3396) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2624"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "74a89a37-5d8d-43fa-a41e-043001a0bdd0", new DateTime(2022, 6, 1, 16, 42, 53, 976, DateTimeKind.Utc).AddTicks(4004), new DateTime(2022, 6, 1, 16, 42, 53, 976, DateTimeKind.Utc).AddTicks(4022), "AQAAAAEAACcQAAAAEN31yzTKjNTflIka11Fgf6wD5FUooSbQo3+rSIKvlILU/lTswEr7tqdBhDWf8N+N6A==", new DateTime(2022, 6, 1, 16, 42, 53, 976, DateTimeKind.Utc).AddTicks(4015) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2625"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "f328ce64-0b76-4d84-a6c2-b2b9a7defb24", new DateTime(2022, 6, 1, 16, 42, 53, 994, DateTimeKind.Utc).AddTicks(3465), new DateTime(2022, 6, 1, 16, 42, 53, 994, DateTimeKind.Utc).AddTicks(3477), "AQAAAAEAACcQAAAAEMjcA7pxnUvpjRCf/RNd90TxKpvNSbZ9QvZcRgTq4cavyrfphvBBPtQmBMNYj0kxGQ==", new DateTime(2022, 6, 1, 16, 42, 53, 994, DateTimeKind.Utc).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2626"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "16b4f083-3ce1-4875-bd58-f6c531bb6877", new DateTime(2022, 6, 1, 16, 42, 54, 12, DateTimeKind.Utc).AddTicks(4559), new DateTime(2022, 6, 1, 16, 42, 54, 12, DateTimeKind.Utc).AddTicks(4575), "AQAAAAEAACcQAAAAEGBloGR07fXvUVrBMv7G1PbtT4B+Ayd9EJsEMdf9wxoWdRwxR9Il5aGDhMYVdouLHw==", new DateTime(2022, 6, 1, 16, 42, 54, 12, DateTimeKind.Utc).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2627"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "c5175fc1-9bdc-4627-900b-d118746baed0", new DateTime(2022, 6, 1, 16, 42, 54, 30, DateTimeKind.Utc).AddTicks(5795), new DateTime(2022, 6, 1, 16, 42, 54, 30, DateTimeKind.Utc).AddTicks(5814), "AQAAAAEAACcQAAAAEC3pjAaRdGliHKVVzw45m6DXS1+8h1UpDHPQD/iCl3WU2q8+IOWe3e8TBMZ22gBVMQ==", new DateTime(2022, 6, 1, 16, 42, 54, 30, DateTimeKind.Utc).AddTicks(5809) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2628"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "84766c90-1623-4b4e-96e9-4072c6b6d962", new DateTime(2022, 6, 1, 16, 42, 54, 48, DateTimeKind.Utc).AddTicks(9161), new DateTime(2022, 6, 1, 16, 42, 54, 48, DateTimeKind.Utc).AddTicks(9183), "AQAAAAEAACcQAAAAEPyvP1I2x/WA/spVS9zEXWzwDeGx7oFv5rzZX0ZM4qcfqCfykPd6ndgRU2pPXp40dA==", new DateTime(2022, 6, 1, 16, 42, 54, 48, DateTimeKind.Utc).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2629"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "ff9aaa01-acb5-4c9d-a658-418b239f023d", new DateTime(2022, 6, 1, 16, 42, 54, 67, DateTimeKind.Utc).AddTicks(247), new DateTime(2022, 6, 1, 16, 42, 54, 67, DateTimeKind.Utc).AddTicks(262), "AQAAAAEAACcQAAAAELwTWggo8RKOvJjPfim0Lkf3htv5AqrH5y8x4ySa/pD/gzNYyj7+lFwTTuaL1XWwZA==", new DateTime(2022, 6, 1, 16, 42, 54, 67, DateTimeKind.Utc).AddTicks(255) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2630"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "a2a4f2d7-2253-40e7-ad1c-4168821a1a1e", new DateTime(2022, 6, 1, 16, 42, 54, 85, DateTimeKind.Utc).AddTicks(372), new DateTime(2022, 6, 1, 16, 42, 54, 85, DateTimeKind.Utc).AddTicks(391), "AQAAAAEAACcQAAAAEGpQjtKXSY7BOO/NxqqsQCpGbjjo7c5O93Vj1PS5ID5NbQgyN5PyCiwJu98/1BiMXA==", new DateTime(2022, 6, 1, 16, 42, 54, 85, DateTimeKind.Utc).AddTicks(385) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2631"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "92019709-9ca3-45eb-8e9a-c275d9278177", new DateTime(2022, 6, 1, 16, 42, 54, 103, DateTimeKind.Utc).AddTicks(1225), new DateTime(2022, 6, 1, 16, 42, 54, 103, DateTimeKind.Utc).AddTicks(1246), "AQAAAAEAACcQAAAAEB/lnQTOg5lgBxirBsuDzCB8QlYZGOrgf5sqzasQ2PgQtTPWxhYGsMPsfrHMXhQzEw==", new DateTime(2022, 6, 1, 16, 42, 54, 103, DateTimeKind.Utc).AddTicks(1239) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2632"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "c14aa575-12d3-4a6b-9a9c-215964662aca", new DateTime(2022, 6, 1, 16, 42, 54, 121, DateTimeKind.Utc).AddTicks(4692), new DateTime(2022, 6, 1, 16, 42, 54, 121, DateTimeKind.Utc).AddTicks(4712), "AQAAAAEAACcQAAAAEMYX87NWzIsM6crMOfOJck11rzXAI+vjNOHDqtb5GFyfawsVXTtKmwpAeM72sXJ0Qg==", new DateTime(2022, 6, 1, 16, 42, 54, 121, DateTimeKind.Utc).AddTicks(4707) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2633"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "c9990780-4f74-45c2-992a-b5106213b7e5", new DateTime(2022, 6, 1, 16, 42, 54, 139, DateTimeKind.Utc).AddTicks(9471), new DateTime(2022, 6, 1, 16, 42, 54, 139, DateTimeKind.Utc).AddTicks(9502), "AQAAAAEAACcQAAAAEHblRA4hOnRIT7+XAzA3oCVK8QsQRDb/yAMBU6AWVUigQQF361QmtIuPwkJK6jCOBQ==", new DateTime(2022, 6, 1, 16, 42, 54, 139, DateTimeKind.Utc).AddTicks(9492) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2634"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "19d6c6c1-6347-4999-b1ce-cccfafba1b60", new DateTime(2022, 6, 1, 16, 42, 54, 158, DateTimeKind.Utc).AddTicks(2688), new DateTime(2022, 6, 1, 16, 42, 54, 158, DateTimeKind.Utc).AddTicks(2709), "AQAAAAEAACcQAAAAEHSiwRZMb7uzR6EpvIWn8gYqiQuVeZCTTtBiXdFDa1JtyLLwKp23Og1WNE2yUlHoGA==", new DateTime(2022, 6, 1, 16, 42, 54, 158, DateTimeKind.Utc).AddTicks(2702) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2635"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "96057f32-8bbb-4433-a9e1-a497e2a27a04", new DateTime(2022, 6, 1, 16, 42, 54, 176, DateTimeKind.Utc).AddTicks(4788), new DateTime(2022, 6, 1, 16, 42, 54, 176, DateTimeKind.Utc).AddTicks(4808), "AQAAAAEAACcQAAAAEHsIPlaTBkGTvQb+o2udNOEPJL8h9NOEF3Q6ld754vj5aqLs5EDHpSj8kxNLfUK3qw==", new DateTime(2022, 6, 1, 16, 42, 54, 176, DateTimeKind.Utc).AddTicks(4801) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2636"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "1d0c6716-536a-40a1-aff9-cc0e757eb293", new DateTime(2022, 6, 1, 16, 42, 54, 198, DateTimeKind.Utc).AddTicks(5479), new DateTime(2022, 6, 1, 16, 42, 54, 198, DateTimeKind.Utc).AddTicks(5501), "AQAAAAEAACcQAAAAEDRSdYDYxlaOvZIHahPgr0BfnxUhyRaz/eUKtpewKKkvKnNrbvZFpaMeliSiB73olw==", new DateTime(2022, 6, 1, 16, 42, 54, 198, DateTimeKind.Utc).AddTicks(5494) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2637"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "7e69925e-8091-4778-84a0-28dad6e373cc", new DateTime(2022, 6, 1, 16, 42, 54, 216, DateTimeKind.Utc).AddTicks(7609), new DateTime(2022, 6, 1, 16, 42, 54, 216, DateTimeKind.Utc).AddTicks(7624), "AQAAAAEAACcQAAAAEGoc4JJapEkD8X5vzgMvG7gUXugcUVN4DOPigjlA141O2x+ONzccOBTsA+to0+V4+Q==", new DateTime(2022, 6, 1, 16, 42, 54, 216, DateTimeKind.Utc).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2638"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "14437751-26c8-45f8-93dd-e3698121c4cd", new DateTime(2022, 6, 1, 16, 42, 54, 235, DateTimeKind.Utc).AddTicks(1375), new DateTime(2022, 6, 1, 16, 42, 54, 235, DateTimeKind.Utc).AddTicks(1392), "AQAAAAEAACcQAAAAEHbqrkvvtg95fOVKx2S94Jr3RLEKB8UORwssw21h0nSQBLnUkXsOkDWcWhmp94iuig==", new DateTime(2022, 6, 1, 16, 42, 54, 235, DateTimeKind.Utc).AddTicks(1386) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2639"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "bbd6495b-2e12-4ea7-8887-8dcc2dc37858", new DateTime(2022, 6, 1, 16, 42, 54, 253, DateTimeKind.Utc).AddTicks(7635), new DateTime(2022, 6, 1, 16, 42, 54, 253, DateTimeKind.Utc).AddTicks(7654), "AQAAAAEAACcQAAAAEB0YvH4nw/R+qlvPMxzln9zbaj2I6lolRyfR1WXUIt5q1iYJXog9YdNkcs8+v9q5Bw==", new DateTime(2022, 6, 1, 16, 42, 54, 253, DateTimeKind.Utc).AddTicks(7648) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2640"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "00a74fbf-f39c-4091-88a6-d7bf7cc57722", new DateTime(2022, 6, 1, 16, 42, 54, 272, DateTimeKind.Utc).AddTicks(584), new DateTime(2022, 6, 1, 16, 42, 54, 272, DateTimeKind.Utc).AddTicks(600), "AQAAAAEAACcQAAAAEHmctMtSJoPeYkbaUPNSzkxFLBi8KWYnsCMvI/hPgsIjOCuL5hS5ErVx6NVUHNuF+w==", new DateTime(2022, 6, 1, 16, 42, 54, 272, DateTimeKind.Utc).AddTicks(596) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2641"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "216ca092-fded-4a6c-9078-acf22ce5d72d", new DateTime(2022, 6, 1, 16, 42, 54, 290, DateTimeKind.Utc).AddTicks(1950), new DateTime(2022, 6, 1, 16, 42, 54, 290, DateTimeKind.Utc).AddTicks(1971), "AQAAAAEAACcQAAAAEEhC8B5n8PXDIy3kxOXF/gd29/zGg85zc2ZcCXau4eNXqr9qHOE7GYsFw6wNW2RqcA==", new DateTime(2022, 6, 1, 16, 42, 54, 290, DateTimeKind.Utc).AddTicks(1966) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2642"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "1f98c61e-7a2e-4b69-bb8e-4ad208edf7c1", new DateTime(2022, 6, 1, 16, 42, 54, 308, DateTimeKind.Utc).AddTicks(4504), new DateTime(2022, 6, 1, 16, 42, 54, 308, DateTimeKind.Utc).AddTicks(4528), "AQAAAAEAACcQAAAAENgH6zW7sTQedtMaDxqcinc2K596AVAVYh1YmiosGaR46KmCv9FMv9eYWmmtpuRCTQ==", new DateTime(2022, 6, 1, 16, 42, 54, 308, DateTimeKind.Utc).AddTicks(4522) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2643"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "5cc8f02b-d864-45f6-85b7-06f00006c79a", new DateTime(2022, 6, 1, 16, 42, 54, 327, DateTimeKind.Utc).AddTicks(4042), new DateTime(2022, 6, 1, 16, 42, 54, 327, DateTimeKind.Utc).AddTicks(4062), "AQAAAAEAACcQAAAAEHT5DGL0Fy5Au+3HOHUZp2tywkWyeOj34d5vTKPc4B+FcUBkClBWzsY5fCaAtEOdEg==", new DateTime(2022, 6, 1, 16, 42, 54, 327, DateTimeKind.Utc).AddTicks(4057) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2644"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "e183c1e2-9590-443a-adb8-03f5341dfe68", new DateTime(2022, 6, 1, 16, 42, 54, 345, DateTimeKind.Utc).AddTicks(5786), new DateTime(2022, 6, 1, 16, 42, 54, 345, DateTimeKind.Utc).AddTicks(5800), "AQAAAAEAACcQAAAAENgp74t3gPsFhuf/DNjaFqPBSFeT2Z+4pkJIIfUNEIkpWzls+gTVdB5jXEWxNrC9Qw==", new DateTime(2022, 6, 1, 16, 42, 54, 345, DateTimeKind.Utc).AddTicks(5795) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2645"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "373b94ab-30f6-477c-9c02-b0a9f2c15faf", new DateTime(2022, 6, 1, 16, 42, 54, 363, DateTimeKind.Utc).AddTicks(6600), new DateTime(2022, 6, 1, 16, 42, 54, 363, DateTimeKind.Utc).AddTicks(6616), "AQAAAAEAACcQAAAAELmuZBgdB/Hvnu6T1heXSEEISUH/MhgXkv9WaTmol9iiQvyko+EN5LGZr83L+LzwyQ==", new DateTime(2022, 6, 1, 16, 42, 54, 363, DateTimeKind.Utc).AddTicks(6611) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2646"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "7f7553e5-3edf-435b-9ef0-f76f3ce92c83", new DateTime(2022, 6, 1, 16, 42, 54, 381, DateTimeKind.Utc).AddTicks(6909), new DateTime(2022, 6, 1, 16, 42, 54, 381, DateTimeKind.Utc).AddTicks(6925), "AQAAAAEAACcQAAAAEFqXr9BNj7d2lH3GDCwdzSs8OBe/8hU8b2bwhwHjum4D25YUKyjD7y0HCNMpCNzDfA==", new DateTime(2022, 6, 1, 16, 42, 54, 381, DateTimeKind.Utc).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2647"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "7e1fe024-1bff-4cf4-bcbb-841f033fedc0", new DateTime(2022, 6, 1, 16, 42, 54, 399, DateTimeKind.Utc).AddTicks(7871), new DateTime(2022, 6, 1, 16, 42, 54, 399, DateTimeKind.Utc).AddTicks(7891), "AQAAAAEAACcQAAAAECcjRx8bAd8/rW8om8VRAmhM3h67HZ5lrrNkD5KRDGUofUaTf7h/fDAKtNJM0ZiaUA==", new DateTime(2022, 6, 1, 16, 42, 54, 399, DateTimeKind.Utc).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2648"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "ab913d2f-ec69-4363-808e-a06fce38391c", new DateTime(2022, 6, 1, 16, 42, 54, 417, DateTimeKind.Utc).AddTicks(7547), new DateTime(2022, 6, 1, 16, 42, 54, 417, DateTimeKind.Utc).AddTicks(7557), "AQAAAAEAACcQAAAAEAtsCbHmiBWhnAuWGyjHkd92pCSbQgG0RWKUXTztXwswAr6R4HxQst7vwnD2urlP4Q==", new DateTime(2022, 6, 1, 16, 42, 54, 417, DateTimeKind.Utc).AddTicks(7554) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2649"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "fdf78147-4d3d-432f-b436-3655bb582e76", new DateTime(2022, 6, 1, 16, 42, 54, 435, DateTimeKind.Utc).AddTicks(8116), new DateTime(2022, 6, 1, 16, 42, 54, 435, DateTimeKind.Utc).AddTicks(8132), "AQAAAAEAACcQAAAAEGQ7t9BFMxEJvgVN36OFgU+c+OQdmBdUdCY3fwP6HDKn0Kty+8jgLVbiNNMjfXq4bQ==", new DateTime(2022, 6, 1, 16, 42, 54, 435, DateTimeKind.Utc).AddTicks(8128) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2650"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "a372eba2-c5a8-4673-854c-bffc48ed3793", new DateTime(2022, 6, 1, 16, 42, 54, 453, DateTimeKind.Utc).AddTicks(8890), new DateTime(2022, 6, 1, 16, 42, 54, 453, DateTimeKind.Utc).AddTicks(8906), "AQAAAAEAACcQAAAAELQhQ+hX0Yj+SfG4F6uWGYak2jzq+Xg4RYxWzDbwcOYHU/XdGpUBZikwXpaiqyeIjA==", new DateTime(2022, 6, 1, 16, 42, 54, 453, DateTimeKind.Utc).AddTicks(8902) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "cac600ad-bf19-449b-9b4f-00186a4fbfb1", new DateTime(2022, 6, 1, 16, 42, 54, 471, DateTimeKind.Utc).AddTicks(8857), new DateTime(2022, 6, 1, 16, 42, 54, 471, DateTimeKind.Utc).AddTicks(8869), "AQAAAAEAACcQAAAAEAwrS3eOazTW27qzT7ytWPOE4jJAWns49B8snP2o9tJb0UpaOIisbSzi8++oUTjWog==", new DateTime(2022, 6, 1, 16, 42, 54, 471, DateTimeKind.Utc).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "c413d3c0-46a4-4af5-accb-1a161045a1cd", new DateTime(2022, 6, 1, 16, 42, 54, 490, DateTimeKind.Utc).AddTicks(4958), new DateTime(2022, 6, 1, 16, 42, 54, 490, DateTimeKind.Utc).AddTicks(4975), "AQAAAAEAACcQAAAAELhmz+U8fgwH+Ms67E0TiZNx72pfMk8gYOPcFnF7jqm5K283bktlDpVI9Xl/GcW8ow==", new DateTime(2022, 6, 1, 16, 42, 54, 490, DateTimeKind.Utc).AddTicks(4971) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "3bf1d28b-d688-4b31-a904-1f7c684153ea", new DateTime(2022, 6, 1, 16, 42, 54, 508, DateTimeKind.Utc).AddTicks(6614), new DateTime(2022, 6, 1, 16, 42, 54, 508, DateTimeKind.Utc).AddTicks(6633), "AQAAAAEAACcQAAAAEOmUHYBXh3y8WBvaD3A6V4pUDA48y0cxU2PnBh5KWQdgGij0Tz2Ox2B+0k2X/2ovkA==", new DateTime(2022, 6, 1, 16, 42, 54, 508, DateTimeKind.Utc).AddTicks(6629) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "c0017a9c-677d-40ab-bea1-4e67e929b5ca", new DateTime(2022, 6, 1, 16, 42, 54, 527, DateTimeKind.Utc).AddTicks(8448), new DateTime(2022, 6, 1, 16, 42, 54, 527, DateTimeKind.Utc).AddTicks(8463), "AQAAAAEAACcQAAAAEMhjkkTTCXc9AUkx4yrxseFV0DQdeHTRkf3oF56uWcfcrMS45982TZJv3icNaSt3WQ==", new DateTime(2022, 6, 1, 16, 42, 54, 527, DateTimeKind.Utc).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "66d78035-6da1-4a35-93bd-fb8d9f2d9470", new DateTime(2022, 6, 1, 16, 42, 54, 546, DateTimeKind.Utc).AddTicks(157), new DateTime(2022, 6, 1, 16, 42, 54, 546, DateTimeKind.Utc).AddTicks(172), "AQAAAAEAACcQAAAAEOhX8ujQy+WrLHSg/2M+aV5p9JovcQxhCQY4ZPlHTOt5Efkr0mrAVJOVqSikxVOZ9Q==", new DateTime(2022, 6, 1, 16, 42, 54, 546, DateTimeKind.Utc).AddTicks(169) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "11d2193d-0ce4-4c9a-8c1e-a8690143e759", new DateTime(2022, 6, 1, 16, 42, 54, 564, DateTimeKind.Utc).AddTicks(5844), new DateTime(2022, 6, 1, 16, 42, 54, 564, DateTimeKind.Utc).AddTicks(5860), "AQAAAAEAACcQAAAAELecWlzC5DhUreWrMsJOJzX+tsPBoc1QtJfTa2sZLjp7FzTBzKMQ2r0TVEqoqEJnrg==", new DateTime(2022, 6, 1, 16, 42, 54, 564, DateTimeKind.Utc).AddTicks(5857) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "366cc135-c4b2-43e9-a805-403b8983e6b7", new DateTime(2022, 6, 1, 16, 42, 54, 583, DateTimeKind.Utc).AddTicks(2540), new DateTime(2022, 6, 1, 16, 42, 54, 583, DateTimeKind.Utc).AddTicks(2560), "AQAAAAEAACcQAAAAEGNi1JYrhjSwTwh8DE2ySjVjBnIrGsI9k0AQnTtExcy16Wx2lAyBIH944o80PgmvoQ==", new DateTime(2022, 6, 1, 16, 42, 54, 583, DateTimeKind.Utc).AddTicks(2557) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "48a872ea-d934-457b-8b03-60265714a208", new DateTime(2022, 6, 1, 16, 42, 54, 601, DateTimeKind.Utc).AddTicks(1905), new DateTime(2022, 6, 1, 16, 42, 54, 601, DateTimeKind.Utc).AddTicks(1916), "AQAAAAEAACcQAAAAEMUPpN4HUpk2P8fOdZEuw1crbriwtpQjzp+06BebOp79v9ulHAy921fhtJcMEqIuoQ==", new DateTime(2022, 6, 1, 16, 42, 54, 601, DateTimeKind.Utc).AddTicks(1912) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "810839b1-ff85-4e6c-b6b8-8a40a9c239bd", new DateTime(2022, 6, 1, 16, 42, 54, 619, DateTimeKind.Utc).AddTicks(5239), new DateTime(2022, 6, 1, 16, 42, 54, 619, DateTimeKind.Utc).AddTicks(5254), "AQAAAAEAACcQAAAAEKh/f9SV/ncIvSseGeXwLwCX/pBIrswRnolQwL06vLPeJM5Z/+5NU2FhlWQ65sAq8A==", new DateTime(2022, 6, 1, 16, 42, 54, 619, DateTimeKind.Utc).AddTicks(5251) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "b06d37ec-c9db-4f85-a103-dd964952336b", new DateTime(2022, 6, 1, 16, 42, 54, 637, DateTimeKind.Utc).AddTicks(7143), new DateTime(2022, 6, 1, 16, 42, 54, 637, DateTimeKind.Utc).AddTicks(7158), "AQAAAAEAACcQAAAAEH8L2wL9/lsqIh/JWyCqjTWrB/N03LIVPcOehcTaZN/d3L2jGw2hMtt71RR2f5uu7Q==", new DateTime(2022, 6, 1, 16, 42, 54, 637, DateTimeKind.Utc).AddTicks(7155) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3361"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "7cb7d808-563a-46b0-aeca-d7c8705e53c5", new DateTime(2022, 6, 1, 16, 42, 54, 655, DateTimeKind.Utc).AddTicks(8283), new DateTime(2022, 6, 1, 16, 42, 54, 655, DateTimeKind.Utc).AddTicks(8296), "AQAAAAEAACcQAAAAENg3hd2i/8/hGYFoY89ixaNRXJyn+O46aNGh5UGta0Wn6EJrfz+qSSwwRm582FKzDQ==", new DateTime(2022, 6, 1, 16, 42, 54, 655, DateTimeKind.Utc).AddTicks(8293) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3362"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "e850d584-050d-444c-8004-1f3a04a788f1", new DateTime(2022, 6, 1, 16, 42, 54, 674, DateTimeKind.Utc).AddTicks(37), new DateTime(2022, 6, 1, 16, 42, 54, 674, DateTimeKind.Utc).AddTicks(54), "AQAAAAEAACcQAAAAEOE7txg4CEaKv43RZoEBWxUrb4K7ivE4LHMr2oMS/7zPGGam/e5yTrORxm/F84vG5g==", new DateTime(2022, 6, 1, 16, 42, 54, 674, DateTimeKind.Utc).AddTicks(50) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3363"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "34fa8794-9f63-44da-ab78-9282dfdb6ad3", new DateTime(2022, 6, 1, 16, 42, 54, 692, DateTimeKind.Utc).AddTicks(2824), new DateTime(2022, 6, 1, 16, 42, 54, 692, DateTimeKind.Utc).AddTicks(2840), "AQAAAAEAACcQAAAAEPAfEqqTVEL/6ovDB+J7zc8OOeAqnTaRkqaFQUA9m0eaPAJ6LFkG2VIZ2N0T7L9ibw==", new DateTime(2022, 6, 1, 16, 42, 54, 692, DateTimeKind.Utc).AddTicks(2837) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3364"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "70378f0a-4a27-409a-b9c7-6f3a737075c3", new DateTime(2022, 6, 1, 16, 42, 54, 710, DateTimeKind.Utc).AddTicks(4586), new DateTime(2022, 6, 1, 16, 42, 54, 710, DateTimeKind.Utc).AddTicks(4603), "AQAAAAEAACcQAAAAEPKjgTJl4i/gjZpsx5goSE3629poxiuiQwJ02StRJDvMLy7nX7nGb91VBdtsqXsDsg==", new DateTime(2022, 6, 1, 16, 42, 54, 710, DateTimeKind.Utc).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3365"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "6d2c3680-dce2-49c1-83f6-81f8b1d83c2a", new DateTime(2022, 6, 1, 16, 42, 54, 729, DateTimeKind.Utc).AddTicks(1659), new DateTime(2022, 6, 1, 16, 42, 54, 729, DateTimeKind.Utc).AddTicks(1675), "AQAAAAEAACcQAAAAEJfV69WckClc2WAaM3rBHbvMynA5r6J+NjmcDMJ0TrWnxjX0xv2+ry/Jg26amX96vg==", new DateTime(2022, 6, 1, 16, 42, 54, 729, DateTimeKind.Utc).AddTicks(1672) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3366"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "b90caba1-e33d-4587-85ff-bbca0c41005a", new DateTime(2022, 6, 1, 16, 42, 54, 747, DateTimeKind.Utc).AddTicks(3036), new DateTime(2022, 6, 1, 16, 42, 54, 747, DateTimeKind.Utc).AddTicks(3050), "AQAAAAEAACcQAAAAEOr8O60zPsmew93jzhzGqW8R0YFfTaWFrfbUwVC5cfwFjqXnzjdK1EQRuz5mxM4wjA==", new DateTime(2022, 6, 1, 16, 42, 54, 747, DateTimeKind.Utc).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3367"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "eac90bd9-9207-4c06-9cb3-0169ca072f2f", new DateTime(2022, 6, 1, 16, 42, 54, 765, DateTimeKind.Utc).AddTicks(3477), new DateTime(2022, 6, 1, 16, 42, 54, 765, DateTimeKind.Utc).AddTicks(3486), "AQAAAAEAACcQAAAAEO41PHhU6ueAYnv+wnNBQFODnBRU2kazdQRE2SwxA/l8ptVlkOsRUBXcEcQhSElDqw==", new DateTime(2022, 6, 1, 16, 42, 54, 765, DateTimeKind.Utc).AddTicks(3483) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3368"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "b4db4074-814b-41c8-b043-5c672c1d5049", new DateTime(2022, 6, 1, 16, 42, 54, 783, DateTimeKind.Utc).AddTicks(3376), new DateTime(2022, 6, 1, 16, 42, 54, 783, DateTimeKind.Utc).AddTicks(3392), "AQAAAAEAACcQAAAAEJdQNKfdgjUfjZZLkWVk43/+27crEk7OrHnxiixHgWfIEk+IReqlSmN58GqXSWH23Q==", new DateTime(2022, 6, 1, 16, 42, 54, 783, DateTimeKind.Utc).AddTicks(3389) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3369"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "3103c214-4623-4a35-9983-f4ba87f70f5b", new DateTime(2022, 6, 1, 16, 42, 54, 801, DateTimeKind.Utc).AddTicks(3233), new DateTime(2022, 6, 1, 16, 42, 54, 801, DateTimeKind.Utc).AddTicks(3243), "AQAAAAEAACcQAAAAEEFpG+ApoeYI0pPao+LWJ1iAfy2v8nWIliLbh1mU2uPB2fqTsV6L+bHguMm0QlSLiw==", new DateTime(2022, 6, 1, 16, 42, 54, 801, DateTimeKind.Utc).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3370"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "1f1b7ea7-653d-46a3-affd-e69295fb0102", new DateTime(2022, 6, 1, 16, 42, 54, 819, DateTimeKind.Utc).AddTicks(2497), new DateTime(2022, 6, 1, 16, 42, 54, 819, DateTimeKind.Utc).AddTicks(2508), "AQAAAAEAACcQAAAAEJRLtu/qHx6NDO9oSHrz7asy8ga4FSVvm1Q3fj03LcUQ0ONa+o5vjl85zdoJCE78Aw==", new DateTime(2022, 6, 1, 16, 42, 54, 819, DateTimeKind.Utc).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3371"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "41d7c8fd-daca-4cbd-96cb-18ebaf304327", new DateTime(2022, 6, 1, 16, 42, 54, 837, DateTimeKind.Utc).AddTicks(1642), new DateTime(2022, 6, 1, 16, 42, 54, 837, DateTimeKind.Utc).AddTicks(1657), "AQAAAAEAACcQAAAAEFYv3q0OAiqCh02KT6juSKGvVDK+zSlX/4UZHXWMh0FuAX6PLmvCctreimu7I77nxQ==", new DateTime(2022, 6, 1, 16, 42, 54, 837, DateTimeKind.Utc).AddTicks(1654) });

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Discounts_DiscountId",
                table: "Services",
                column: "DiscountId",
                principalTable: "Discounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Discounts_DiscountId",
                table: "Services");

            migrationBuilder.AlterColumn<int>(
                name: "DiscountId",
                table: "Services",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(6578), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(7097), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(6815) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8365), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8369), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8391), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8392), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8391) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8404), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8406), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8405) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8417), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8419), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8418) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8437), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8438), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8438) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8450), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8452), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8451) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8462), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8464), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8463) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8517), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8518), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8517) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8534), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8535), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8535) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8546), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8548), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8547) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8558), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8560), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8559) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8570), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8572), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8571) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8582), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8584), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8583) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8594), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8595), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8595) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8606), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8608), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8607) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8618), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8620), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8619) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8662), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8663), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8663) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8675), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8677), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8676) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8687), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8689), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8688) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8699), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8701), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8712), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8713), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8724), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8725), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8724) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8736), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8737), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8747), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8749), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8759), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8760), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8804), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8805), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8805) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8816), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8818), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8817) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8828), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8830), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8840), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8842), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8841) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8852), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8854), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8864), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8865), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8876), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8877), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8889), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8890), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8933), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8934), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8934) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8945), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8946), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8946) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8957), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8959), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8958) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8969), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8971), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8981), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8982), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8982) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8993), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8994), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9005), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9006), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9005) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9016), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9018), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9017) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9028), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9030), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9106), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9108), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9119), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9120), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9132), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9133), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9132) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9144), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9145), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9144) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9156), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9157), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9156) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9168), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9169), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9180), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9181), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9191), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9193), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9192) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9233), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9235), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9234) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9247), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9249), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9248) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9259), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9261), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9272), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9273), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9272) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9284), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9285), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9284) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9296), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9297), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9296) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9308), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9309), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9309) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9320), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9321), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9320) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9332), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9333), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9332) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9374), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9375), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9375) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9388), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9389), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9400), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9401), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9400) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9412), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9413), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9424), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9425), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9425) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9438), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9439), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9439) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9470), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9471), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9471) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9482), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9484), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9483) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9526), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9528), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9527) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9539), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9541), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9540) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9552), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9553), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9552) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9564), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9565), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9565) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9577), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9578), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9577) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9588), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9590), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9589) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9600), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9602), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9612), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9613), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9613) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9624), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9625), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9624) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9668), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9669), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9680), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9682), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9693), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9694), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9693) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9705), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9706), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9705) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9717), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9719), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9718) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9729), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9731), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9741), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9742), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9742) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9753), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9755), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9754) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9765), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9766), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9810), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9812), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9811) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9822), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9824), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9823) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9835), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9836), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9835) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9846), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9848), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9847) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9858), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9860), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9859) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9870), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9871), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9871) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9882), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9883), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9882) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9893), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9895), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9935), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9936), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9935) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9948), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9950), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9949) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9961), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9962), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9961) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9973), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9974), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9973) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9984), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9986), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9985) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9997), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9998), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9997) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(8), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(10), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(9) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(20), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(22), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(32), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(34), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(33) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(75), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(77), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(76) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(89), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(90), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(89) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(101), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(102), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(102) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(114), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(115), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(114) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(126), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(127), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(126) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(138), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(139), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(139) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(150), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(151), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(162), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(163), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(162) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(174), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(175), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(175) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(229), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(231), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(242), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(244), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(243) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(255), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(256), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(256) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(267), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(269), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(279), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(281), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(292), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(293), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(292) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(303), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(305), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(315), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(317), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(316) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(327), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(328), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(328) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(373), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(374), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(373) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(385), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(386), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(386) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(397), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(399), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(409), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(411), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(421), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(422), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(433), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(434), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(434) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(445), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(446), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(457), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(458), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(457) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(503), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(504), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(515), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(517), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(516) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(527), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(529), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(528) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(540), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(541), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(541) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(552), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(553), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(553) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(564), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(565), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(565) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(576), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(577), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(576) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(618), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(619), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(619) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(631), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(633), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(632) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(644), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(645), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(644) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(656), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(657), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(657) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(668), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(670), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(669) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(680), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(682), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(681) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(692), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(693), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(693) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(704), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(705), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(705) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(716), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(717), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(716) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(760), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(761), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(761) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(772), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(774), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(773) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(785), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(786), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(786) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(797), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(798), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(809), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(810), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(810) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(821), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(822), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(821) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(833), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(834), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(833) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(844), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(846), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(845) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 280, DateTimeKind.Utc).AddTicks(7952), new DateTime(2022, 6, 1, 5, 35, 47, 280, DateTimeKind.Utc).AddTicks(7225), new DateTime(2022, 6, 1, 5, 35, 47, 280, DateTimeKind.Utc).AddTicks(8411), new DateTime(2022, 6, 1, 5, 35, 47, 280, DateTimeKind.Utc).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 286, DateTimeKind.Utc).AddTicks(9586), new DateTime(2022, 6, 1, 5, 35, 47, 286, DateTimeKind.Utc).AddTicks(9585), new DateTime(2022, 6, 1, 5, 35, 47, 286, DateTimeKind.Utc).AddTicks(9588), new DateTime(2022, 6, 1, 5, 35, 47, 286, DateTimeKind.Utc).AddTicks(9587) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 292, DateTimeKind.Utc).AddTicks(7795), new DateTime(2022, 6, 1, 5, 35, 47, 292, DateTimeKind.Utc).AddTicks(7794), new DateTime(2022, 6, 1, 5, 35, 47, 292, DateTimeKind.Utc).AddTicks(7797), new DateTime(2022, 6, 1, 5, 35, 47, 292, DateTimeKind.Utc).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 298, DateTimeKind.Utc).AddTicks(4530), new DateTime(2022, 6, 1, 5, 35, 47, 298, DateTimeKind.Utc).AddTicks(4529), new DateTime(2022, 6, 1, 5, 35, 47, 298, DateTimeKind.Utc).AddTicks(4531), new DateTime(2022, 6, 1, 5, 35, 47, 298, DateTimeKind.Utc).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 304, DateTimeKind.Utc).AddTicks(1166), new DateTime(2022, 6, 1, 5, 35, 47, 304, DateTimeKind.Utc).AddTicks(1165), new DateTime(2022, 6, 1, 5, 35, 47, 304, DateTimeKind.Utc).AddTicks(1167), new DateTime(2022, 6, 1, 5, 35, 47, 304, DateTimeKind.Utc).AddTicks(1166) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 309, DateTimeKind.Utc).AddTicks(8864), new DateTime(2022, 6, 1, 5, 35, 47, 309, DateTimeKind.Utc).AddTicks(8862), new DateTime(2022, 6, 1, 5, 35, 47, 309, DateTimeKind.Utc).AddTicks(8866), new DateTime(2022, 6, 1, 5, 35, 47, 309, DateTimeKind.Utc).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 315, DateTimeKind.Utc).AddTicks(5666), new DateTime(2022, 6, 1, 5, 35, 47, 315, DateTimeKind.Utc).AddTicks(5665), new DateTime(2022, 6, 1, 5, 35, 47, 315, DateTimeKind.Utc).AddTicks(5667), new DateTime(2022, 6, 1, 5, 35, 47, 315, DateTimeKind.Utc).AddTicks(5666) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 321, DateTimeKind.Utc).AddTicks(5741), new DateTime(2022, 6, 1, 5, 35, 47, 321, DateTimeKind.Utc).AddTicks(5738), new DateTime(2022, 6, 1, 5, 35, 47, 321, DateTimeKind.Utc).AddTicks(5742), new DateTime(2022, 6, 1, 5, 35, 47, 321, DateTimeKind.Utc).AddTicks(5741) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 327, DateTimeKind.Utc).AddTicks(5799), new DateTime(2022, 6, 1, 5, 35, 47, 327, DateTimeKind.Utc).AddTicks(5796), new DateTime(2022, 6, 1, 5, 35, 47, 327, DateTimeKind.Utc).AddTicks(5801), new DateTime(2022, 6, 1, 5, 35, 47, 327, DateTimeKind.Utc).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 333, DateTimeKind.Utc).AddTicks(5667), new DateTime(2022, 6, 1, 5, 35, 47, 333, DateTimeKind.Utc).AddTicks(5663), new DateTime(2022, 6, 1, 5, 35, 47, 333, DateTimeKind.Utc).AddTicks(5669), new DateTime(2022, 6, 1, 5, 35, 47, 333, DateTimeKind.Utc).AddTicks(5668) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 339, DateTimeKind.Utc).AddTicks(7863), new DateTime(2022, 6, 1, 5, 35, 47, 339, DateTimeKind.Utc).AddTicks(7860), new DateTime(2022, 6, 1, 5, 35, 47, 339, DateTimeKind.Utc).AddTicks(7865), new DateTime(2022, 6, 1, 5, 35, 47, 339, DateTimeKind.Utc).AddTicks(7864) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 345, DateTimeKind.Utc).AddTicks(5448), new DateTime(2022, 6, 1, 5, 35, 47, 345, DateTimeKind.Utc).AddTicks(5446), new DateTime(2022, 6, 1, 5, 35, 47, 345, DateTimeKind.Utc).AddTicks(5450), new DateTime(2022, 6, 1, 5, 35, 47, 345, DateTimeKind.Utc).AddTicks(5449) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 351, DateTimeKind.Utc).AddTicks(3967), new DateTime(2022, 6, 1, 5, 35, 47, 351, DateTimeKind.Utc).AddTicks(3964), new DateTime(2022, 6, 1, 5, 35, 47, 351, DateTimeKind.Utc).AddTicks(3969), new DateTime(2022, 6, 1, 5, 35, 47, 351, DateTimeKind.Utc).AddTicks(3968) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 357, DateTimeKind.Utc).AddTicks(2211), new DateTime(2022, 6, 1, 5, 35, 47, 357, DateTimeKind.Utc).AddTicks(2209), new DateTime(2022, 6, 1, 5, 35, 47, 357, DateTimeKind.Utc).AddTicks(2213), new DateTime(2022, 6, 1, 5, 35, 47, 357, DateTimeKind.Utc).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 362, DateTimeKind.Utc).AddTicks(9996), new DateTime(2022, 6, 1, 5, 35, 47, 362, DateTimeKind.Utc).AddTicks(9995), new DateTime(2022, 6, 1, 5, 35, 47, 362, DateTimeKind.Utc).AddTicks(9998), new DateTime(2022, 6, 1, 5, 35, 47, 362, DateTimeKind.Utc).AddTicks(9997) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 368, DateTimeKind.Utc).AddTicks(7085), new DateTime(2022, 6, 1, 5, 35, 47, 368, DateTimeKind.Utc).AddTicks(7084), new DateTime(2022, 6, 1, 5, 35, 47, 368, DateTimeKind.Utc).AddTicks(7087), new DateTime(2022, 6, 1, 5, 35, 47, 368, DateTimeKind.Utc).AddTicks(7086) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 374, DateTimeKind.Utc).AddTicks(3812), new DateTime(2022, 6, 1, 5, 35, 47, 374, DateTimeKind.Utc).AddTicks(3811), new DateTime(2022, 6, 1, 5, 35, 47, 374, DateTimeKind.Utc).AddTicks(3813), new DateTime(2022, 6, 1, 5, 35, 47, 374, DateTimeKind.Utc).AddTicks(3813) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 380, DateTimeKind.Utc).AddTicks(448), new DateTime(2022, 6, 1, 5, 35, 47, 380, DateTimeKind.Utc).AddTicks(447), new DateTime(2022, 6, 1, 5, 35, 47, 380, DateTimeKind.Utc).AddTicks(450), new DateTime(2022, 6, 1, 5, 35, 47, 380, DateTimeKind.Utc).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 385, DateTimeKind.Utc).AddTicks(8166), new DateTime(2022, 6, 1, 5, 35, 47, 385, DateTimeKind.Utc).AddTicks(8164), new DateTime(2022, 6, 1, 5, 35, 47, 385, DateTimeKind.Utc).AddTicks(8168), new DateTime(2022, 6, 1, 5, 35, 47, 385, DateTimeKind.Utc).AddTicks(8167) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 391, DateTimeKind.Utc).AddTicks(5052), new DateTime(2022, 6, 1, 5, 35, 47, 391, DateTimeKind.Utc).AddTicks(5051), new DateTime(2022, 6, 1, 5, 35, 47, 391, DateTimeKind.Utc).AddTicks(5053), new DateTime(2022, 6, 1, 5, 35, 47, 391, DateTimeKind.Utc).AddTicks(5052) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 397, DateTimeKind.Utc).AddTicks(1797), new DateTime(2022, 6, 1, 5, 35, 47, 397, DateTimeKind.Utc).AddTicks(1796), new DateTime(2022, 6, 1, 5, 35, 47, 397, DateTimeKind.Utc).AddTicks(1799), new DateTime(2022, 6, 1, 5, 35, 47, 397, DateTimeKind.Utc).AddTicks(1798) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 403, DateTimeKind.Utc).AddTicks(1313), new DateTime(2022, 6, 1, 5, 35, 47, 403, DateTimeKind.Utc).AddTicks(1308), new DateTime(2022, 6, 1, 5, 35, 47, 403, DateTimeKind.Utc).AddTicks(1315), new DateTime(2022, 6, 1, 5, 35, 47, 403, DateTimeKind.Utc).AddTicks(1314) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 408, DateTimeKind.Utc).AddTicks(8089), new DateTime(2022, 6, 1, 5, 35, 47, 408, DateTimeKind.Utc).AddTicks(8088), new DateTime(2022, 6, 1, 5, 35, 47, 408, DateTimeKind.Utc).AddTicks(8090), new DateTime(2022, 6, 1, 5, 35, 47, 408, DateTimeKind.Utc).AddTicks(8089) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 414, DateTimeKind.Utc).AddTicks(6206), new DateTime(2022, 6, 1, 5, 35, 47, 414, DateTimeKind.Utc).AddTicks(6203), new DateTime(2022, 6, 1, 5, 35, 47, 414, DateTimeKind.Utc).AddTicks(6208), new DateTime(2022, 6, 1, 5, 35, 47, 414, DateTimeKind.Utc).AddTicks(6207) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 420, DateTimeKind.Utc).AddTicks(4672), new DateTime(2022, 6, 1, 5, 35, 47, 420, DateTimeKind.Utc).AddTicks(4670), new DateTime(2022, 6, 1, 5, 35, 47, 420, DateTimeKind.Utc).AddTicks(4673), new DateTime(2022, 6, 1, 5, 35, 47, 420, DateTimeKind.Utc).AddTicks(4672) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 426, DateTimeKind.Utc).AddTicks(4899), new DateTime(2022, 6, 1, 5, 35, 47, 426, DateTimeKind.Utc).AddTicks(4896), new DateTime(2022, 6, 1, 5, 35, 47, 426, DateTimeKind.Utc).AddTicks(4901), new DateTime(2022, 6, 1, 5, 35, 47, 426, DateTimeKind.Utc).AddTicks(4900) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 432, DateTimeKind.Utc).AddTicks(9619), new DateTime(2022, 6, 1, 5, 35, 47, 432, DateTimeKind.Utc).AddTicks(9615), new DateTime(2022, 6, 1, 5, 35, 47, 432, DateTimeKind.Utc).AddTicks(9622), new DateTime(2022, 6, 1, 5, 35, 47, 432, DateTimeKind.Utc).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 440, DateTimeKind.Utc).AddTicks(508), new DateTime(2022, 6, 1, 5, 35, 47, 440, DateTimeKind.Utc).AddTicks(505), new DateTime(2022, 6, 1, 5, 35, 47, 440, DateTimeKind.Utc).AddTicks(510), new DateTime(2022, 6, 1, 5, 35, 47, 440, DateTimeKind.Utc).AddTicks(509) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 446, DateTimeKind.Utc).AddTicks(589), new DateTime(2022, 6, 1, 5, 35, 47, 446, DateTimeKind.Utc).AddTicks(579), new DateTime(2022, 6, 1, 5, 35, 47, 446, DateTimeKind.Utc).AddTicks(593), new DateTime(2022, 6, 1, 5, 35, 47, 446, DateTimeKind.Utc).AddTicks(591) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 451, DateTimeKind.Utc).AddTicks(9916), new DateTime(2022, 6, 1, 5, 35, 47, 451, DateTimeKind.Utc).AddTicks(9913), new DateTime(2022, 6, 1, 5, 35, 47, 451, DateTimeKind.Utc).AddTicks(9918), new DateTime(2022, 6, 1, 5, 35, 47, 451, DateTimeKind.Utc).AddTicks(9917) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 458, DateTimeKind.Utc).AddTicks(5192), new DateTime(2022, 6, 1, 5, 35, 47, 458, DateTimeKind.Utc).AddTicks(5189), new DateTime(2022, 6, 1, 5, 35, 47, 458, DateTimeKind.Utc).AddTicks(5193), new DateTime(2022, 6, 1, 5, 35, 47, 458, DateTimeKind.Utc).AddTicks(5192) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 464, DateTimeKind.Utc).AddTicks(9205), new DateTime(2022, 6, 1, 5, 35, 47, 464, DateTimeKind.Utc).AddTicks(9200), new DateTime(2022, 6, 1, 5, 35, 47, 464, DateTimeKind.Utc).AddTicks(9207), new DateTime(2022, 6, 1, 5, 35, 47, 464, DateTimeKind.Utc).AddTicks(9206) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 470, DateTimeKind.Utc).AddTicks(7764), new DateTime(2022, 6, 1, 5, 35, 47, 470, DateTimeKind.Utc).AddTicks(7761), new DateTime(2022, 6, 1, 5, 35, 47, 470, DateTimeKind.Utc).AddTicks(7766), new DateTime(2022, 6, 1, 5, 35, 47, 470, DateTimeKind.Utc).AddTicks(7765) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 476, DateTimeKind.Utc).AddTicks(4624), new DateTime(2022, 6, 1, 5, 35, 47, 476, DateTimeKind.Utc).AddTicks(4622), new DateTime(2022, 6, 1, 5, 35, 47, 476, DateTimeKind.Utc).AddTicks(4625), new DateTime(2022, 6, 1, 5, 35, 47, 476, DateTimeKind.Utc).AddTicks(4624) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 482, DateTimeKind.Utc).AddTicks(1907), new DateTime(2022, 6, 1, 5, 35, 47, 482, DateTimeKind.Utc).AddTicks(1905), new DateTime(2022, 6, 1, 5, 35, 47, 482, DateTimeKind.Utc).AddTicks(1909), new DateTime(2022, 6, 1, 5, 35, 47, 482, DateTimeKind.Utc).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 487, DateTimeKind.Utc).AddTicks(8587), new DateTime(2022, 6, 1, 5, 35, 47, 487, DateTimeKind.Utc).AddTicks(8586), new DateTime(2022, 6, 1, 5, 35, 47, 487, DateTimeKind.Utc).AddTicks(8588), new DateTime(2022, 6, 1, 5, 35, 47, 487, DateTimeKind.Utc).AddTicks(8588) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 493, DateTimeKind.Utc).AddTicks(8380), new DateTime(2022, 6, 1, 5, 35, 47, 493, DateTimeKind.Utc).AddTicks(8376), new DateTime(2022, 6, 1, 5, 35, 47, 493, DateTimeKind.Utc).AddTicks(8382), new DateTime(2022, 6, 1, 5, 35, 47, 493, DateTimeKind.Utc).AddTicks(8381) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 499, DateTimeKind.Utc).AddTicks(5750), new DateTime(2022, 6, 1, 5, 35, 47, 499, DateTimeKind.Utc).AddTicks(5749), new DateTime(2022, 6, 1, 5, 35, 47, 499, DateTimeKind.Utc).AddTicks(5751), new DateTime(2022, 6, 1, 5, 35, 47, 499, DateTimeKind.Utc).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 505, DateTimeKind.Utc).AddTicks(2568), new DateTime(2022, 6, 1, 5, 35, 47, 505, DateTimeKind.Utc).AddTicks(2567), new DateTime(2022, 6, 1, 5, 35, 47, 505, DateTimeKind.Utc).AddTicks(2570), new DateTime(2022, 6, 1, 5, 35, 47, 505, DateTimeKind.Utc).AddTicks(2569) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 511, DateTimeKind.Utc).AddTicks(6429), new DateTime(2022, 6, 1, 5, 35, 47, 511, DateTimeKind.Utc).AddTicks(6426), new DateTime(2022, 6, 1, 5, 35, 47, 511, DateTimeKind.Utc).AddTicks(6431), new DateTime(2022, 6, 1, 5, 35, 47, 511, DateTimeKind.Utc).AddTicks(6430) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 517, DateTimeKind.Utc).AddTicks(3268), new DateTime(2022, 6, 1, 5, 35, 47, 517, DateTimeKind.Utc).AddTicks(3267), new DateTime(2022, 6, 1, 5, 35, 47, 517, DateTimeKind.Utc).AddTicks(3270), new DateTime(2022, 6, 1, 5, 35, 47, 517, DateTimeKind.Utc).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 523, DateTimeKind.Utc).AddTicks(579), new DateTime(2022, 6, 1, 5, 35, 47, 523, DateTimeKind.Utc).AddTicks(577), new DateTime(2022, 6, 1, 5, 35, 47, 523, DateTimeKind.Utc).AddTicks(581), new DateTime(2022, 6, 1, 5, 35, 47, 523, DateTimeKind.Utc).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 528, DateTimeKind.Utc).AddTicks(8413), new DateTime(2022, 6, 1, 5, 35, 47, 528, DateTimeKind.Utc).AddTicks(8410), new DateTime(2022, 6, 1, 5, 35, 47, 528, DateTimeKind.Utc).AddTicks(8415), new DateTime(2022, 6, 1, 5, 35, 47, 528, DateTimeKind.Utc).AddTicks(8414) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 534, DateTimeKind.Utc).AddTicks(5529), new DateTime(2022, 6, 1, 5, 35, 47, 534, DateTimeKind.Utc).AddTicks(5527), new DateTime(2022, 6, 1, 5, 35, 47, 534, DateTimeKind.Utc).AddTicks(5531), new DateTime(2022, 6, 1, 5, 35, 47, 534, DateTimeKind.Utc).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 540, DateTimeKind.Utc).AddTicks(3148), new DateTime(2022, 6, 1, 5, 35, 47, 540, DateTimeKind.Utc).AddTicks(3145), new DateTime(2022, 6, 1, 5, 35, 47, 540, DateTimeKind.Utc).AddTicks(3149), new DateTime(2022, 6, 1, 5, 35, 47, 540, DateTimeKind.Utc).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 546, DateTimeKind.Utc).AddTicks(226), new DateTime(2022, 6, 1, 5, 35, 47, 546, DateTimeKind.Utc).AddTicks(225), new DateTime(2022, 6, 1, 5, 35, 47, 546, DateTimeKind.Utc).AddTicks(228), new DateTime(2022, 6, 1, 5, 35, 47, 546, DateTimeKind.Utc).AddTicks(227) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 551, DateTimeKind.Utc).AddTicks(7086), new DateTime(2022, 6, 1, 5, 35, 47, 551, DateTimeKind.Utc).AddTicks(7084), new DateTime(2022, 6, 1, 5, 35, 47, 551, DateTimeKind.Utc).AddTicks(7087), new DateTime(2022, 6, 1, 5, 35, 47, 551, DateTimeKind.Utc).AddTicks(7086) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 557, DateTimeKind.Utc).AddTicks(4720), new DateTime(2022, 6, 1, 5, 35, 47, 557, DateTimeKind.Utc).AddTicks(4717), new DateTime(2022, 6, 1, 5, 35, 47, 557, DateTimeKind.Utc).AddTicks(4721), new DateTime(2022, 6, 1, 5, 35, 47, 557, DateTimeKind.Utc).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 563, DateTimeKind.Utc).AddTicks(2461), new DateTime(2022, 6, 1, 5, 35, 47, 563, DateTimeKind.Utc).AddTicks(2459), new DateTime(2022, 6, 1, 5, 35, 47, 563, DateTimeKind.Utc).AddTicks(2462), new DateTime(2022, 6, 1, 5, 35, 47, 563, DateTimeKind.Utc).AddTicks(2462) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 569, DateTimeKind.Utc).AddTicks(113), new DateTime(2022, 6, 1, 5, 35, 47, 569, DateTimeKind.Utc).AddTicks(112), new DateTime(2022, 6, 1, 5, 35, 47, 569, DateTimeKind.Utc).AddTicks(115), new DateTime(2022, 6, 1, 5, 35, 47, 569, DateTimeKind.Utc).AddTicks(114) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 574, DateTimeKind.Utc).AddTicks(7320), new DateTime(2022, 6, 1, 5, 35, 47, 574, DateTimeKind.Utc).AddTicks(7318), new DateTime(2022, 6, 1, 5, 35, 47, 574, DateTimeKind.Utc).AddTicks(7322), new DateTime(2022, 6, 1, 5, 35, 47, 574, DateTimeKind.Utc).AddTicks(7321) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(3886), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(3886), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(3888), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(3887) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(2750), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(3286), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(3004) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(4470), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(4476), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(4474) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(4505), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(4507), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(4506) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(4528), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(4530), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(4529) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(4550), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(4552), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(4551) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Deleted_at", "EndDate", "StartDate", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 12, 35, 47, 268, DateTimeKind.Local).AddTicks(1162), new DateTime(2022, 6, 1, 12, 35, 47, 268, DateTimeKind.Local).AddTicks(1899), new DateTime(2022, 6, 1, 12, 35, 47, 267, DateTimeKind.Local).AddTicks(9073), new DateTime(2022, 6, 1, 12, 35, 47, 267, DateTimeKind.Local).AddTicks(4578), new DateTime(2022, 6, 1, 12, 35, 47, 268, DateTimeKind.Local).AddTicks(1403) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "Deleted_at", "EndDate", "StartDate", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(953), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(955), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(949), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(943), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(953) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "Deleted_at", "EndDate", "StartDate", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(1055), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(1057), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(1054), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(1052), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(1056) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "Deleted_at", "EndDate", "StartDate", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(1082), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(1083), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(1080), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(1079), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(1083) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_at", "Deleted_at", "EndDate", "StartDate", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(1104), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(1105), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(1102), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(1101), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(1105) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "8f8e2fa5-a932-4136-b67f-f0dca40e6364");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"),
                column: "ConcurrencyStamp",
                value: "970269c7-fe3c-4230-abf1-75dce86711cc");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(8206), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(8697), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(8446) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 12, 35, 47, 270, DateTimeKind.Local).AddTicks(58), new DateTime(2022, 6, 1, 12, 35, 47, 270, DateTimeKind.Local).AddTicks(64), new DateTime(2022, 6, 1, 12, 35, 47, 270, DateTimeKind.Local).AddTicks(62) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 12, 35, 47, 270, DateTimeKind.Local).AddTicks(95), new DateTime(2022, 6, 1, 12, 35, 47, 270, DateTimeKind.Local).AddTicks(97), new DateTime(2022, 6, 1, 12, 35, 47, 270, DateTimeKind.Local).AddTicks(96) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 12, 35, 47, 270, DateTimeKind.Local).AddTicks(118), new DateTime(2022, 6, 1, 12, 35, 47, 270, DateTimeKind.Local).AddTicks(120), new DateTime(2022, 6, 1, 12, 35, 47, 270, DateTimeKind.Local).AddTicks(119) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 6, 1, 12, 35, 47, 270, DateTimeKind.Local).AddTicks(180), new DateTime(2022, 6, 1, 12, 35, 47, 270, DateTimeKind.Local).AddTicks(182), new DateTime(2022, 6, 1, 12, 35, 47, 270, DateTimeKind.Local).AddTicks(181) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2620"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "37f2d396-4629-4561-a02d-5f865307d348", new DateTime(2022, 6, 1, 5, 35, 47, 280, DateTimeKind.Utc).AddTicks(4725), new DateTime(2022, 6, 1, 5, 35, 47, 280, DateTimeKind.Utc).AddTicks(5249), "AQAAAAEAACcQAAAAELZbtGAe36QbudN4JTFUtVJ4lWUntSstrqgk0HzN6RseZLY0y6e7XIESGT5n/YvJLw==", new DateTime(2022, 6, 1, 5, 35, 47, 280, DateTimeKind.Utc).AddTicks(4968) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2621"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "f87af76b-9c33-4aaf-a694-d2076805c806", new DateTime(2022, 6, 1, 5, 35, 47, 286, DateTimeKind.Utc).AddTicks(9515), new DateTime(2022, 6, 1, 5, 35, 47, 286, DateTimeKind.Utc).AddTicks(9518), "AQAAAAEAACcQAAAAEAuikU3HbAX5Xtul1yx4cxvGFK9/JbIjouAp//JjY+Adm5DPvz2MOaSVylVrgC0rrQ==", new DateTime(2022, 6, 1, 5, 35, 47, 286, DateTimeKind.Utc).AddTicks(9517) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2622"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "445fcfec-1072-4c81-8252-8d4f6b89941a", new DateTime(2022, 6, 1, 5, 35, 47, 292, DateTimeKind.Utc).AddTicks(7609), new DateTime(2022, 6, 1, 5, 35, 47, 292, DateTimeKind.Utc).AddTicks(7615), "AQAAAAEAACcQAAAAEDNhtqgEXNBBX+rQLjSbaW8k6gj1OZd9wcTgxf3UEDzzJHQAC/StNR4aVabYE++WbA==", new DateTime(2022, 6, 1, 5, 35, 47, 292, DateTimeKind.Utc).AddTicks(7614) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2623"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "d3f8baee-b16b-4faa-946b-b5f674af7350", new DateTime(2022, 6, 1, 5, 35, 47, 298, DateTimeKind.Utc).AddTicks(4497), new DateTime(2022, 6, 1, 5, 35, 47, 298, DateTimeKind.Utc).AddTicks(4499), "AQAAAAEAACcQAAAAED2XsAnlzensRMCus1Fxo37TFlXnvwmD5eyLUO5s2yQ0bzT+stWJYABWcRdgNElOlA==", new DateTime(2022, 6, 1, 5, 35, 47, 298, DateTimeKind.Utc).AddTicks(4498) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2624"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "e3498411-1bf0-4c8a-8a60-9fd2ce95bc54", new DateTime(2022, 6, 1, 5, 35, 47, 304, DateTimeKind.Utc).AddTicks(1117), new DateTime(2022, 6, 1, 5, 35, 47, 304, DateTimeKind.Utc).AddTicks(1118), "AQAAAAEAACcQAAAAEI83g45UBA4cgFDqyYohiqwQl6j0nUvDaf6NktSzX3CzlYWSj+FR09pzDbvd9MVYxQ==", new DateTime(2022, 6, 1, 5, 35, 47, 304, DateTimeKind.Utc).AddTicks(1118) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2625"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "c8537ae2-12e0-48ac-b916-e3514dcffb8b", new DateTime(2022, 6, 1, 5, 35, 47, 309, DateTimeKind.Utc).AddTicks(8586), new DateTime(2022, 6, 1, 5, 35, 47, 309, DateTimeKind.Utc).AddTicks(8593), "AQAAAAEAACcQAAAAEC1gFNlxm+pxVinSQYOYzSYlFQx1INHfDvrs5+MbvTlCIET/UWo539Hnf1VdnBU1aQ==", new DateTime(2022, 6, 1, 5, 35, 47, 309, DateTimeKind.Utc).AddTicks(8591) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2626"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "af317c5e-bf46-4736-b9c6-2066ccff5fd6", new DateTime(2022, 6, 1, 5, 35, 47, 315, DateTimeKind.Utc).AddTicks(5636), new DateTime(2022, 6, 1, 5, 35, 47, 315, DateTimeKind.Utc).AddTicks(5638), "AQAAAAEAACcQAAAAEAWM+HMy80LwO1IZqQwVEHtgUt4JUL4mqIh65gzBiC/5N9wKT44cBGN7SoYgyPb/Vg==", new DateTime(2022, 6, 1, 5, 35, 47, 315, DateTimeKind.Utc).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2627"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "8309297c-8253-4912-987b-b5a3ca944704", new DateTime(2022, 6, 1, 5, 35, 47, 321, DateTimeKind.Utc).AddTicks(5323), new DateTime(2022, 6, 1, 5, 35, 47, 321, DateTimeKind.Utc).AddTicks(5339), "AQAAAAEAACcQAAAAEMTqiOdDiob4NErXbl0hUtUscLx1d4N4kuAC2KVGgiTYJBw4HcoPEiibgyAZT2lbLw==", new DateTime(2022, 6, 1, 5, 35, 47, 321, DateTimeKind.Utc).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2628"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "93a625ad-6555-4ce5-b540-17f1061201af", new DateTime(2022, 6, 1, 5, 35, 47, 327, DateTimeKind.Utc).AddTicks(5488), new DateTime(2022, 6, 1, 5, 35, 47, 327, DateTimeKind.Utc).AddTicks(5498), "AQAAAAEAACcQAAAAEAhgoNjnpgQwqLk150oQsKjKFEhOj7N2rkZ9h7P3UZBn7ME2Nf3Yon/e7AyNKLxAlQ==", new DateTime(2022, 6, 1, 5, 35, 47, 327, DateTimeKind.Utc).AddTicks(5495) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2629"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "d893b944-987f-466b-8511-aef58719dac4", new DateTime(2022, 6, 1, 5, 35, 47, 333, DateTimeKind.Utc).AddTicks(5293), new DateTime(2022, 6, 1, 5, 35, 47, 333, DateTimeKind.Utc).AddTicks(5301), "AQAAAAEAACcQAAAAEL+F9ENcdQcjifvgfNHaGvhFzvkAS4lccsU1fsoJ7t0NoeXTAL45DdVw9dlQRMjKWg==", new DateTime(2022, 6, 1, 5, 35, 47, 333, DateTimeKind.Utc).AddTicks(5299) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2630"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "f39f66b1-b4a3-49dd-b32b-79840ed32d7c", new DateTime(2022, 6, 1, 5, 35, 47, 339, DateTimeKind.Utc).AddTicks(7572), new DateTime(2022, 6, 1, 5, 35, 47, 339, DateTimeKind.Utc).AddTicks(7578), "AQAAAAEAACcQAAAAEMgbl51gUD4D5f2vodpZdMTbAfA/UY8lwzUPZ4gCJFQV7YnTV07OBG5LrprWCAjnbA==", new DateTime(2022, 6, 1, 5, 35, 47, 339, DateTimeKind.Utc).AddTicks(7576) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2631"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "b6659425-c50f-4f66-870c-c1391209ec9d", new DateTime(2022, 6, 1, 5, 35, 47, 345, DateTimeKind.Utc).AddTicks(5309), new DateTime(2022, 6, 1, 5, 35, 47, 345, DateTimeKind.Utc).AddTicks(5313), "AQAAAAEAACcQAAAAEDP1Xz4pI24GOitRykU588M8GpZrjYzFUo1502PfaudLFGmVkiXMjvsMTVZx7BSCrQ==", new DateTime(2022, 6, 1, 5, 35, 47, 345, DateTimeKind.Utc).AddTicks(5312) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2632"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "15c00930-1832-44e5-94fc-6afe37eba0d6", new DateTime(2022, 6, 1, 5, 35, 47, 351, DateTimeKind.Utc).AddTicks(3773), new DateTime(2022, 6, 1, 5, 35, 47, 351, DateTimeKind.Utc).AddTicks(3778), "AQAAAAEAACcQAAAAEGtcvYLWNkXNNEtzaQpqlzVQwa5nOSowCn/BJpAyPKYiHqa1tWiqj5a0JyxueLsO1A==", new DateTime(2022, 6, 1, 5, 35, 47, 351, DateTimeKind.Utc).AddTicks(3777) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2633"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "a239d73a-35d4-4a46-be2b-dc7b41dbc2a7", new DateTime(2022, 6, 1, 5, 35, 47, 357, DateTimeKind.Utc).AddTicks(2031), new DateTime(2022, 6, 1, 5, 35, 47, 357, DateTimeKind.Utc).AddTicks(2034), "AQAAAAEAACcQAAAAEGn3fWLtZlSY9sUZkKnxDTJ9/ekJiz1nQMOQwCHZHso2YXM9AdKOLVn+svwb3/LzZQ==", new DateTime(2022, 6, 1, 5, 35, 47, 357, DateTimeKind.Utc).AddTicks(2033) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2634"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "004c47b7-450c-4356-bdcf-e411a65cd09c", new DateTime(2022, 6, 1, 5, 35, 47, 362, DateTimeKind.Utc).AddTicks(9851), new DateTime(2022, 6, 1, 5, 35, 47, 362, DateTimeKind.Utc).AddTicks(9855), "AQAAAAEAACcQAAAAEIpYTzcF7JX3fNgHieN+0/F83CbKIsF4yvHv0uXebOmvFRIoOFmwUhyvIFFbKtS7CQ==", new DateTime(2022, 6, 1, 5, 35, 47, 362, DateTimeKind.Utc).AddTicks(9853) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2635"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "b166e557-ad18-44a6-bf44-6feeb77f9e47", new DateTime(2022, 6, 1, 5, 35, 47, 368, DateTimeKind.Utc).AddTicks(6914), new DateTime(2022, 6, 1, 5, 35, 47, 368, DateTimeKind.Utc).AddTicks(6916), "AQAAAAEAACcQAAAAEMFYtX/I3YwBGMVjC3NR2pWSVnJ3Tyg9fJ2CNOpMQ+Zes5xLuMK4qfZhB2NfMdJuwQ==", new DateTime(2022, 6, 1, 5, 35, 47, 368, DateTimeKind.Utc).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2636"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "60f015d9-1d4e-404c-afae-8f9a4c69ebab", new DateTime(2022, 6, 1, 5, 35, 47, 374, DateTimeKind.Utc).AddTicks(3763), new DateTime(2022, 6, 1, 5, 35, 47, 374, DateTimeKind.Utc).AddTicks(3764), "AQAAAAEAACcQAAAAEHk7oxjqeZswaIz51XE5mhzfQ/lrDHZ+MK41M/OJSwp7HRtmUN7YZe/eP6lPVdikZA==", new DateTime(2022, 6, 1, 5, 35, 47, 374, DateTimeKind.Utc).AddTicks(3764) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2637"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "0ed28e77-cd2d-429e-8235-e2442765d65e", new DateTime(2022, 6, 1, 5, 35, 47, 380, DateTimeKind.Utc).AddTicks(411), new DateTime(2022, 6, 1, 5, 35, 47, 380, DateTimeKind.Utc).AddTicks(413), "AQAAAAEAACcQAAAAEF3+3wdp0YEqxnkbsqflQOvkFiUDH5H7+OuL9yUbyJ3Ym6KIHeeZ2288HjlucChXEQ==", new DateTime(2022, 6, 1, 5, 35, 47, 380, DateTimeKind.Utc).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2638"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "7973a62f-e875-4f8d-acc9-4ab3f997ed0d", new DateTime(2022, 6, 1, 5, 35, 47, 385, DateTimeKind.Utc).AddTicks(7958), new DateTime(2022, 6, 1, 5, 35, 47, 385, DateTimeKind.Utc).AddTicks(7965), "AQAAAAEAACcQAAAAEHr8VbAG3p9vcysGrFiHarHzwl+kuZVMLBG7We7vOja+m4EdWx8Yi3M0hSYqW4qnTQ==", new DateTime(2022, 6, 1, 5, 35, 47, 385, DateTimeKind.Utc).AddTicks(7964) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2639"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "44e1ad09-e22e-4d5f-a78b-a5543f18e586", new DateTime(2022, 6, 1, 5, 35, 47, 391, DateTimeKind.Utc).AddTicks(5012), new DateTime(2022, 6, 1, 5, 35, 47, 391, DateTimeKind.Utc).AddTicks(5013), "AQAAAAEAACcQAAAAEGWDjapp2z9L4U90fJKbFqSelZbmWcTaG53/waX76/daN1LcXsqhUSYVuiFO6HtjqA==", new DateTime(2022, 6, 1, 5, 35, 47, 391, DateTimeKind.Utc).AddTicks(5013) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2640"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "f70aebae-d91c-4c4d-86d6-a318e9289c4f", new DateTime(2022, 6, 1, 5, 35, 47, 397, DateTimeKind.Utc).AddTicks(1694), new DateTime(2022, 6, 1, 5, 35, 47, 397, DateTimeKind.Utc).AddTicks(1695), "AQAAAAEAACcQAAAAEERMVPuxpxhiwrL6XcbUSyQY/iPacmFJm+yVaROL0uObX8S80NyKwp3ncRFjR3GczA==", new DateTime(2022, 6, 1, 5, 35, 47, 397, DateTimeKind.Utc).AddTicks(1694) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2641"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "7b4de78b-7b9a-4466-89d4-dd975b2c60aa", new DateTime(2022, 6, 1, 5, 35, 47, 403, DateTimeKind.Utc).AddTicks(1098), new DateTime(2022, 6, 1, 5, 35, 47, 403, DateTimeKind.Utc).AddTicks(1105), "AQAAAAEAACcQAAAAEDm+ju/3XfIh/D+hHLwUfKzeKZqQXGyD+iNdL5OXKYmkoNrLnn2Xr7Xfn50cxjUVyg==", new DateTime(2022, 6, 1, 5, 35, 47, 403, DateTimeKind.Utc).AddTicks(1103) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2642"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "d11dd64c-eb8c-4cb1-8605-5ab48c183068", new DateTime(2022, 6, 1, 5, 35, 47, 408, DateTimeKind.Utc).AddTicks(8044), new DateTime(2022, 6, 1, 5, 35, 47, 408, DateTimeKind.Utc).AddTicks(8046), "AQAAAAEAACcQAAAAEFs5e47HEstn6r/z2ThEcjE21cAop1jlBTYHF67FCRT20rtOalbij+/O7yiC6tOnXg==", new DateTime(2022, 6, 1, 5, 35, 47, 408, DateTimeKind.Utc).AddTicks(8045) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2643"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "adba6416-5178-4944-8b29-2654c45251e4", new DateTime(2022, 6, 1, 5, 35, 47, 414, DateTimeKind.Utc).AddTicks(5939), new DateTime(2022, 6, 1, 5, 35, 47, 414, DateTimeKind.Utc).AddTicks(5948), "AQAAAAEAACcQAAAAEN+hzY/RzQnM2Ah3HWt+PizzX8H5gx4BEv4vOIup8FPLZCWA7wwWOjILB13j2ahLjA==", new DateTime(2022, 6, 1, 5, 35, 47, 414, DateTimeKind.Utc).AddTicks(5946) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2644"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "4c779462-0235-4e79-9d54-d0035a497c3d", new DateTime(2022, 6, 1, 5, 35, 47, 420, DateTimeKind.Utc).AddTicks(4532), new DateTime(2022, 6, 1, 5, 35, 47, 420, DateTimeKind.Utc).AddTicks(4535), "AQAAAAEAACcQAAAAEC2NSwizUf9nLQhsnEYZEntfhJzQs125CQ1XH8E59hrU6lOI3U4TzqxZ4H1NN9Uh9w==", new DateTime(2022, 6, 1, 5, 35, 47, 420, DateTimeKind.Utc).AddTicks(4534) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2645"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "b1ddf45d-7db5-470d-8721-bb4411376beb", new DateTime(2022, 6, 1, 5, 35, 47, 426, DateTimeKind.Utc).AddTicks(4671), new DateTime(2022, 6, 1, 5, 35, 47, 426, DateTimeKind.Utc).AddTicks(4680), "AQAAAAEAACcQAAAAEPBH6l2miFOHY99f6IZ0opMrTIvjCjpuvkt0Evt46dMFsxeH5Lyh7GUBXytsqLTLJw==", new DateTime(2022, 6, 1, 5, 35, 47, 426, DateTimeKind.Utc).AddTicks(4678) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2646"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "b709c650-5091-4ae1-a160-96bff41f0eb2", new DateTime(2022, 6, 1, 5, 35, 47, 432, DateTimeKind.Utc).AddTicks(9074), new DateTime(2022, 6, 1, 5, 35, 47, 432, DateTimeKind.Utc).AddTicks(9095), "AQAAAAEAACcQAAAAEKI5+wdcDkxupv5kwP34f/5GHKVbZ8lC6nCLOBn1IGwqmvq41tm+85mVhO0VGwqc7w==", new DateTime(2022, 6, 1, 5, 35, 47, 432, DateTimeKind.Utc).AddTicks(9088) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2647"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "1df6c0c4-d61d-462c-9419-d30283fc6c63", new DateTime(2022, 6, 1, 5, 35, 47, 440, DateTimeKind.Utc).AddTicks(149), new DateTime(2022, 6, 1, 5, 35, 47, 440, DateTimeKind.Utc).AddTicks(158), "AQAAAAEAACcQAAAAEP8xDFq9eNpLDRz39dKMaPHBhJ1bpFsGjpxiwJbsBMc+uH1uVqerxCfUKyeLqhBsnA==", new DateTime(2022, 6, 1, 5, 35, 47, 440, DateTimeKind.Utc).AddTicks(156) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2648"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "39e1c0cd-58cb-4d1b-887a-176348529d00", new DateTime(2022, 6, 1, 5, 35, 47, 445, DateTimeKind.Utc).AddTicks(9397), new DateTime(2022, 6, 1, 5, 35, 47, 445, DateTimeKind.Utc).AddTicks(9411), "AQAAAAEAACcQAAAAELu+Grabg/Hsfm8XjLYiGj9ySPYueIfdoPELwaeYGHnu5PkgqwzPbG8356AmiP7IRw==", new DateTime(2022, 6, 1, 5, 35, 47, 445, DateTimeKind.Utc).AddTicks(9408) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2649"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "0d0f09df-139d-4201-b42e-eae81807b950", new DateTime(2022, 6, 1, 5, 35, 47, 451, DateTimeKind.Utc).AddTicks(9484), new DateTime(2022, 6, 1, 5, 35, 47, 451, DateTimeKind.Utc).AddTicks(9492), "AQAAAAEAACcQAAAAEDiuG7OFMT4nOH2ynNYYz2tL1XJmaOb+ypQ0IJyeDg+Qndyh2OkJxDSeq4psIvw77A==", new DateTime(2022, 6, 1, 5, 35, 47, 451, DateTimeKind.Utc).AddTicks(9489) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2650"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "6612d53b-ded3-4959-a020-01db0ee19499", new DateTime(2022, 6, 1, 5, 35, 47, 458, DateTimeKind.Utc).AddTicks(4801), new DateTime(2022, 6, 1, 5, 35, 47, 458, DateTimeKind.Utc).AddTicks(4818), "AQAAAAEAACcQAAAAEAMiOp+61hro86eYajUfkWC+d1oVhKUCAXzJYFQ5osUoglEtfExiwwVdO9Q0WAGltg==", new DateTime(2022, 6, 1, 5, 35, 47, 458, DateTimeKind.Utc).AddTicks(4815) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "f22a5ed1-04b6-454e-ada8-f3b110e4e724", new DateTime(2022, 6, 1, 5, 35, 47, 464, DateTimeKind.Utc).AddTicks(8114), new DateTime(2022, 6, 1, 5, 35, 47, 464, DateTimeKind.Utc).AddTicks(8123), "AQAAAAEAACcQAAAAEPLvmxd7oZAcMcRd+VI3IH1vrPVn5XOdo6UyPc8QcD2BUhdEc+7kVpE3eVAvpoVUQQ==", new DateTime(2022, 6, 1, 5, 35, 47, 464, DateTimeKind.Utc).AddTicks(8119) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "948f6a28-442b-4124-8f9d-fefca9edca00", new DateTime(2022, 6, 1, 5, 35, 47, 470, DateTimeKind.Utc).AddTicks(7603), new DateTime(2022, 6, 1, 5, 35, 47, 470, DateTimeKind.Utc).AddTicks(7608), "AQAAAAEAACcQAAAAEJnRZ4Fs7CTWPUBhg9VWFSwSHqlVJED1LSeEbNOMKU9W59A+7U69RFDm48e3z5ioOg==", new DateTime(2022, 6, 1, 5, 35, 47, 470, DateTimeKind.Utc).AddTicks(7606) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "48c13509-4e4e-4514-bd67-a5765ca35d5d", new DateTime(2022, 6, 1, 5, 35, 47, 476, DateTimeKind.Utc).AddTicks(4553), new DateTime(2022, 6, 1, 5, 35, 47, 476, DateTimeKind.Utc).AddTicks(4555), "AQAAAAEAACcQAAAAECt3e4Lc0DZvxHIyuB6sLB9n2QSdNTjG7FK98yusTXkss9G1i+SWS9SCVowevgVqsg==", new DateTime(2022, 6, 1, 5, 35, 47, 476, DateTimeKind.Utc).AddTicks(4554) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "9ffc6b57-16ed-4a5f-a555-ac8cc4c9855f", new DateTime(2022, 6, 1, 5, 35, 47, 482, DateTimeKind.Utc).AddTicks(1713), new DateTime(2022, 6, 1, 5, 35, 47, 482, DateTimeKind.Utc).AddTicks(1718), "AQAAAAEAACcQAAAAEGzExCW2lt66I1op4yo2hnqGyXZNG7bDOOB2vguwTsYiDm5PVZ9t8KSiKdgi4/G5UQ==", new DateTime(2022, 6, 1, 5, 35, 47, 482, DateTimeKind.Utc).AddTicks(1715) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "574d888a-01b0-44cf-b3b8-1871296a8ac1", new DateTime(2022, 6, 1, 5, 35, 47, 487, DateTimeKind.Utc).AddTicks(8550), new DateTime(2022, 6, 1, 5, 35, 47, 487, DateTimeKind.Utc).AddTicks(8552), "AQAAAAEAACcQAAAAED/jEPb/4u28IxXmYrAtsr9pc5nbzmgfGH4mN6xS51qdk3psDBBvF3hjPOaUcZTGwg==", new DateTime(2022, 6, 1, 5, 35, 47, 487, DateTimeKind.Utc).AddTicks(8551) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "b0fc6562-7117-4f3a-8191-187398752a44", new DateTime(2022, 6, 1, 5, 35, 47, 493, DateTimeKind.Utc).AddTicks(8037), new DateTime(2022, 6, 1, 5, 35, 47, 493, DateTimeKind.Utc).AddTicks(8044), "AQAAAAEAACcQAAAAEOP2jEFKb7b3mTcapZooIFkcJdcqJG7zvWZt+2LZckjLGo8CBEDXAgewx2iW1c4tdQ==", new DateTime(2022, 6, 1, 5, 35, 47, 493, DateTimeKind.Utc).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "10a93ff9-0984-44c9-a942-bfe9d5f4da10", new DateTime(2022, 6, 1, 5, 35, 47, 499, DateTimeKind.Utc).AddTicks(5713), new DateTime(2022, 6, 1, 5, 35, 47, 499, DateTimeKind.Utc).AddTicks(5716), "AQAAAAEAACcQAAAAEAa1c7KWuScnXdtGq3wWjt3BAooEpxi5QWuN+WXLX0GL14Z/OzWl9bv4lzJlv3CIcw==", new DateTime(2022, 6, 1, 5, 35, 47, 499, DateTimeKind.Utc).AddTicks(5715) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "15d5fa06-9b77-40df-ad5b-4c60573d94b5", new DateTime(2022, 6, 1, 5, 35, 47, 505, DateTimeKind.Utc).AddTicks(2476), new DateTime(2022, 6, 1, 5, 35, 47, 505, DateTimeKind.Utc).AddTicks(2479), "AQAAAAEAACcQAAAAEC7Rjvrb5Z62yHQdaCqO7GSuJ1utGPE1ixgJfpox2woZvCKNxiqOyNdncd0qlReTTA==", new DateTime(2022, 6, 1, 5, 35, 47, 505, DateTimeKind.Utc).AddTicks(2478) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "cb1e3f75-71b8-4064-9b45-c0533ff550a4", new DateTime(2022, 6, 1, 5, 35, 47, 511, DateTimeKind.Utc).AddTicks(6203), new DateTime(2022, 6, 1, 5, 35, 47, 511, DateTimeKind.Utc).AddTicks(6211), "AQAAAAEAACcQAAAAEEnJoNA3zo7B3gtSMVp6tGa5772GLVtOzxA9rYdd5WpwnaXm0IpZ3+jF28mbeW7pdQ==", new DateTime(2022, 6, 1, 5, 35, 47, 511, DateTimeKind.Utc).AddTicks(6209) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "701a8ee5-46a1-4110-bfa9-a29cf73a1438", new DateTime(2022, 6, 1, 5, 35, 47, 517, DateTimeKind.Utc).AddTicks(3226), new DateTime(2022, 6, 1, 5, 35, 47, 517, DateTimeKind.Utc).AddTicks(3228), "AQAAAAEAACcQAAAAEK2jG54aqXNAaH40vtd12qGCU567ceKBztpk5Kq1296fF25qxK/NuqiJc11mn5MtWQ==", new DateTime(2022, 6, 1, 5, 35, 47, 517, DateTimeKind.Utc).AddTicks(3227) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3361"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "d69dcbd3-2407-4687-b744-56181edd2f13", new DateTime(2022, 6, 1, 5, 35, 47, 523, DateTimeKind.Utc).AddTicks(446), new DateTime(2022, 6, 1, 5, 35, 47, 523, DateTimeKind.Utc).AddTicks(452), "AQAAAAEAACcQAAAAELVJ/QVBMwHh4lnwv1tua6WtAMxiHNTVZvy6D5n3weTVjQi1OQ1JKK2kkDXHnaSAYg==", new DateTime(2022, 6, 1, 5, 35, 47, 523, DateTimeKind.Utc).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3362"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "06a1c71e-c20e-4849-81e6-2699bb0bc3b6", new DateTime(2022, 6, 1, 5, 35, 47, 528, DateTimeKind.Utc).AddTicks(8250), new DateTime(2022, 6, 1, 5, 35, 47, 528, DateTimeKind.Utc).AddTicks(8257), "AQAAAAEAACcQAAAAEKzonBExNtWArz2ypX5AAe+vb1amTHkUDtb1nTlT2moDD5qH0RTyUr67ucyWYQ2CWA==", new DateTime(2022, 6, 1, 5, 35, 47, 528, DateTimeKind.Utc).AddTicks(8255) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3363"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "3b9ba7b3-7ceb-48f0-a98e-89cbc5d48cbc", new DateTime(2022, 6, 1, 5, 35, 47, 534, DateTimeKind.Utc).AddTicks(5437), new DateTime(2022, 6, 1, 5, 35, 47, 534, DateTimeKind.Utc).AddTicks(5441), "AQAAAAEAACcQAAAAEKJ0F/4oUyJEzvCYiB4mlvc+qP0ZtuwIvZrE1SRlC5anuSFl3GoKfr5T2CuZt+qAdQ==", new DateTime(2022, 6, 1, 5, 35, 47, 534, DateTimeKind.Utc).AddTicks(5440) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3364"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "6a14c553-dbf1-4847-85c8-c1c1082e9078", new DateTime(2022, 6, 1, 5, 35, 47, 540, DateTimeKind.Utc).AddTicks(3021), new DateTime(2022, 6, 1, 5, 35, 47, 540, DateTimeKind.Utc).AddTicks(3028), "AQAAAAEAACcQAAAAEOSQl9kUTZXooweUfpAPaaL4uRJQBwwo5+Cvn8IG9KEIHYO3gaZQshFs0nEEHeUM9Q==", new DateTime(2022, 6, 1, 5, 35, 47, 540, DateTimeKind.Utc).AddTicks(3026) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3365"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "837ff5c0-7b48-4a4a-937c-d0304a26dd2c", new DateTime(2022, 6, 1, 5, 35, 47, 546, DateTimeKind.Utc).AddTicks(147), new DateTime(2022, 6, 1, 5, 35, 47, 546, DateTimeKind.Utc).AddTicks(151), "AQAAAAEAACcQAAAAELhTVT+sxo/53FWnZBHB5VI/5UL0X+X+SE82/drDud3O9JW9EdNYsqMB55X/LEgwqw==", new DateTime(2022, 6, 1, 5, 35, 47, 546, DateTimeKind.Utc).AddTicks(149) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3366"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "77fef640-9f2d-4b2c-9484-2070eaf57db9", new DateTime(2022, 6, 1, 5, 35, 47, 551, DateTimeKind.Utc).AddTicks(6971), new DateTime(2022, 6, 1, 5, 35, 47, 551, DateTimeKind.Utc).AddTicks(6974), "AQAAAAEAACcQAAAAEJZT9GedDUv1XGNtgevaKyFr8nTdc/UXoUT/TuaEtZ5DqBmOqAaO3ZO8scwhEfBbjQ==", new DateTime(2022, 6, 1, 5, 35, 47, 551, DateTimeKind.Utc).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3367"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "0a539b33-6bb4-444a-80cc-d4f949b6a4e5", new DateTime(2022, 6, 1, 5, 35, 47, 557, DateTimeKind.Utc).AddTicks(4628), new DateTime(2022, 6, 1, 5, 35, 47, 557, DateTimeKind.Utc).AddTicks(4633), "AQAAAAEAACcQAAAAEKtBlcJdVBxAm/lRcvJVUmHO0Y3tvrjRLdQ6ipKQks/XLkQgL50/mEyQ28siytbhBA==", new DateTime(2022, 6, 1, 5, 35, 47, 557, DateTimeKind.Utc).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3368"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "6467e3e0-d3b4-4679-b899-6583cfe43cab", new DateTime(2022, 6, 1, 5, 35, 47, 563, DateTimeKind.Utc).AddTicks(2410), new DateTime(2022, 6, 1, 5, 35, 47, 563, DateTimeKind.Utc).AddTicks(2413), "AQAAAAEAACcQAAAAELYm8u3jEmHOYZ6bPTnSeQTwKHdZNEmHhOdVHIBDlIHP+LN1gTX65I04/rDWXk+rmw==", new DateTime(2022, 6, 1, 5, 35, 47, 563, DateTimeKind.Utc).AddTicks(2412) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3369"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "3ea58225-ba32-4696-98f6-51bf5da62c4b", new DateTime(2022, 6, 1, 5, 35, 47, 569, DateTimeKind.Utc).AddTicks(63), new DateTime(2022, 6, 1, 5, 35, 47, 569, DateTimeKind.Utc).AddTicks(65), "AQAAAAEAACcQAAAAEKjMfxfH96c7mFrhqppNezeV9uZGRX/bjErbjX1L9aOXeVJgnrmfSmNtVqxJgK57KQ==", new DateTime(2022, 6, 1, 5, 35, 47, 569, DateTimeKind.Utc).AddTicks(64) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3370"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "8dc3fbec-d6b4-4263-b8ed-e86996288d2c", new DateTime(2022, 6, 1, 5, 35, 47, 574, DateTimeKind.Utc).AddTicks(7215), new DateTime(2022, 6, 1, 5, 35, 47, 574, DateTimeKind.Utc).AddTicks(7221), "AQAAAAEAACcQAAAAEG0b+bcEPz4TS6Cmo1A4aLAQqtk2iDPFRpqvxUHqnvB5TH1geFGQ4NgqdHe4z+UQ1Q==", new DateTime(2022, 6, 1, 5, 35, 47, 574, DateTimeKind.Utc).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3371"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "a2c5fe9c-7b75-4350-a2c9-631541830d9e", new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(3868), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(3870), "AQAAAAEAACcQAAAAEPeRBJ+ispOn8hRnyr/j8mFnaAXYsgTVhvL2ckqflAvTrRhTmm4fFbcAY7lv8HFQOA==", new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(3869) });

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Discounts_DiscountId",
                table: "Services",
                column: "DiscountId",
                principalTable: "Discounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
