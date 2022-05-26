using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DentisBooking.Data.Migrations
{
    public partial class updatefieldGender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "Dentists",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(4743), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(5322), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(5018) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(6739), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(6741), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(6741) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(6767), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(6768), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(6768) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(6783), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(6784), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(6784) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(6797), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(6798), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(6797) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(6820), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(6822), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(6821) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(6909), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(6911), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(6923), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(6925), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(6924) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(6936), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(6938), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(6937) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(6951), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(6952), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(6952) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(6963), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(6965), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(6964) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(6976), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(6978), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(6977) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(6989), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(6990), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(6990) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7002), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7003), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7002) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7014), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7016), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7015) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7061), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7062), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7061) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7074), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7075), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7074) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7088), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7089), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7101), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7103), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7114), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7115), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7115) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7127), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7128), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7127) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7140), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7141), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7153), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7154), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7153) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7165), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7167), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7166) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7214), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7215), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7215) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7229), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7230), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7229) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7244), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7245), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7245) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7257), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7258), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7257) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7270), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7271), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7270) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7283), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7284), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7283) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7295), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7297), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7296) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7308), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7309), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7321), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7322), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7321) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7387), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7388), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7387) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7400), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7402), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7401) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7414), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7416), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7415) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7428), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7430), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7429) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7441), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7442), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7442) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7454), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7456), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7455) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7468), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7469), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7468) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7480), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7482), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7481) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7493), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7494), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7493) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7540), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7542), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7541) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7553), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7555), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7554) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7566), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7567), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7567) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7579), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7580), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7592), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7593), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7592) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7605), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7606), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7617), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7619), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7630), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7632), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7631) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7643), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7644), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7643) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7727), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7729), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7728) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7740), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7742), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7753), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7754), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7766), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7767), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7766) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7778), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7779), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7791), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7792), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7792) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7803), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7805), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7804) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7816), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7817), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7816) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7828), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7830), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7873), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7874), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7873) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7886), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7887), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7898), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7900), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7899) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7912), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7913), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7912) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7924), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7926), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7925) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7939), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7941), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7953), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7954), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7954) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7965), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7967), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(7966) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8008), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8010), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8009) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8022), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8023), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8022) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8034), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8035), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8034) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8046), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8047), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8058), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8060), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8071), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8072), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8071) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8083), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8084), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8084) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8096), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8097), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8097) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8108), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8110), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8109) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8152), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8153), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8152) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8168), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8170), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8169) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8187), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8189), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8188) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8209), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8226), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8223) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8274), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8276), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8275) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8307), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8309), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8335), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8337), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8336) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8357), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8359), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8358) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8378), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8380), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8379) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8407), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8409), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8408) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8533), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8535), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8535) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8550), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8552), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8551) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8563), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8564), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8564) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8575), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8576), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8576) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8588), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8589), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8588) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8600), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8602), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8601) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8613), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8614), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8613) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8625), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8626), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8625) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8637), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8639), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8638) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8690), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8692), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8691) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8702), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8704), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8703) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8715), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8717), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8716) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8728), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8729), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8728) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8740), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8741), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8752), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8753), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8771), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8772), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8810), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8812), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8812) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8861), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8863), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8862) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8937), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8939), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8958), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8960), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8959) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8976), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8978), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8977) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8995), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8996), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(8995) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9014), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9015), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9015) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9033), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9035), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9052), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9054), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9053) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9070), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9072), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9071) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9088), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9090), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9089) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9156), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9157), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9157) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9179), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9180), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9199), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9201), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9220), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9222), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9221) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9239), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9240), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9257), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9258), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9257) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9275), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9276), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9275) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9293), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9295), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9294) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9327), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9329), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9584), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9591), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9680), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9682), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9706), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9708), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9707) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9727), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9729), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9728) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9758), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9760), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9759) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9779), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9780), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9818), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9820), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9819) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9958), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9962), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(9961) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(39), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(41), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(41) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(64), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(65), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(65) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(78), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(79), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(79) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(90), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(92), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(91) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(103), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(104), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(103) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(114), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(116), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(115) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(127), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(129), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(128) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(140), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(141), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(245), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(251), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(248) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(306), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(308), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(307) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(339), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(341), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(367), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(368), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(368) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(388), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(390), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(389) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(411), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(414), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(439), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(441), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(462), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(465), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(492), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(494), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(533), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(537), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(536) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(652), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(654), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(654) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(672), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(673), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(672) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(685), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(686), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(685) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(697), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(698), new DateTime(2022, 5, 26, 14, 52, 45, 434, DateTimeKind.Utc).AddTicks(698) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 90, DateTimeKind.Utc).AddTicks(786), new DateTime(2022, 5, 26, 14, 52, 45, 89, DateTimeKind.Utc).AddTicks(9791), new DateTime(2022, 5, 26, 14, 52, 45, 90, DateTimeKind.Utc).AddTicks(1331), new DateTime(2022, 5, 26, 14, 52, 45, 90, DateTimeKind.Utc).AddTicks(1044) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 96, DateTimeKind.Utc).AddTicks(755), new DateTime(2022, 5, 26, 14, 52, 45, 96, DateTimeKind.Utc).AddTicks(753), new DateTime(2022, 5, 26, 14, 52, 45, 96, DateTimeKind.Utc).AddTicks(756), new DateTime(2022, 5, 26, 14, 52, 45, 96, DateTimeKind.Utc).AddTicks(755) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 101, DateTimeKind.Utc).AddTicks(8086), new DateTime(2022, 5, 26, 14, 52, 45, 101, DateTimeKind.Utc).AddTicks(8085), new DateTime(2022, 5, 26, 14, 52, 45, 101, DateTimeKind.Utc).AddTicks(8087), new DateTime(2022, 5, 26, 14, 52, 45, 101, DateTimeKind.Utc).AddTicks(8086) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 107, DateTimeKind.Utc).AddTicks(5090), new DateTime(2022, 5, 26, 14, 52, 45, 107, DateTimeKind.Utc).AddTicks(5089), new DateTime(2022, 5, 26, 14, 52, 45, 107, DateTimeKind.Utc).AddTicks(5092), new DateTime(2022, 5, 26, 14, 52, 45, 107, DateTimeKind.Utc).AddTicks(5091) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 113, DateTimeKind.Utc).AddTicks(2463), new DateTime(2022, 5, 26, 14, 52, 45, 113, DateTimeKind.Utc).AddTicks(2461), new DateTime(2022, 5, 26, 14, 52, 45, 113, DateTimeKind.Utc).AddTicks(2464), new DateTime(2022, 5, 26, 14, 52, 45, 113, DateTimeKind.Utc).AddTicks(2463) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 118, DateTimeKind.Utc).AddTicks(9761), new DateTime(2022, 5, 26, 14, 52, 45, 118, DateTimeKind.Utc).AddTicks(9760), new DateTime(2022, 5, 26, 14, 52, 45, 118, DateTimeKind.Utc).AddTicks(9763), new DateTime(2022, 5, 26, 14, 52, 45, 118, DateTimeKind.Utc).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 124, DateTimeKind.Utc).AddTicks(6686), new DateTime(2022, 5, 26, 14, 52, 45, 124, DateTimeKind.Utc).AddTicks(6685), new DateTime(2022, 5, 26, 14, 52, 45, 124, DateTimeKind.Utc).AddTicks(6687), new DateTime(2022, 5, 26, 14, 52, 45, 124, DateTimeKind.Utc).AddTicks(6686) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 130, DateTimeKind.Utc).AddTicks(8633), new DateTime(2022, 5, 26, 14, 52, 45, 130, DateTimeKind.Utc).AddTicks(8631), new DateTime(2022, 5, 26, 14, 52, 45, 130, DateTimeKind.Utc).AddTicks(8634), new DateTime(2022, 5, 26, 14, 52, 45, 130, DateTimeKind.Utc).AddTicks(8633) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 136, DateTimeKind.Utc).AddTicks(6702), new DateTime(2022, 5, 26, 14, 52, 45, 136, DateTimeKind.Utc).AddTicks(6701), new DateTime(2022, 5, 26, 14, 52, 45, 136, DateTimeKind.Utc).AddTicks(6704), new DateTime(2022, 5, 26, 14, 52, 45, 136, DateTimeKind.Utc).AddTicks(6703) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 142, DateTimeKind.Utc).AddTicks(4217), new DateTime(2022, 5, 26, 14, 52, 45, 142, DateTimeKind.Utc).AddTicks(4216), new DateTime(2022, 5, 26, 14, 52, 45, 142, DateTimeKind.Utc).AddTicks(4219), new DateTime(2022, 5, 26, 14, 52, 45, 142, DateTimeKind.Utc).AddTicks(4218) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 148, DateTimeKind.Utc).AddTicks(4885), new DateTime(2022, 5, 26, 14, 52, 45, 148, DateTimeKind.Utc).AddTicks(4884), new DateTime(2022, 5, 26, 14, 52, 45, 148, DateTimeKind.Utc).AddTicks(4887), new DateTime(2022, 5, 26, 14, 52, 45, 148, DateTimeKind.Utc).AddTicks(4886) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 154, DateTimeKind.Utc).AddTicks(9453), new DateTime(2022, 5, 26, 14, 52, 45, 154, DateTimeKind.Utc).AddTicks(9448), new DateTime(2022, 5, 26, 14, 52, 45, 154, DateTimeKind.Utc).AddTicks(9455), new DateTime(2022, 5, 26, 14, 52, 45, 154, DateTimeKind.Utc).AddTicks(9453) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 162, DateTimeKind.Utc).AddTicks(3423), new DateTime(2022, 5, 26, 14, 52, 45, 162, DateTimeKind.Utc).AddTicks(3421), new DateTime(2022, 5, 26, 14, 52, 45, 162, DateTimeKind.Utc).AddTicks(3425), new DateTime(2022, 5, 26, 14, 52, 45, 162, DateTimeKind.Utc).AddTicks(3424) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 168, DateTimeKind.Utc).AddTicks(7591), new DateTime(2022, 5, 26, 14, 52, 45, 168, DateTimeKind.Utc).AddTicks(7589), new DateTime(2022, 5, 26, 14, 52, 45, 168, DateTimeKind.Utc).AddTicks(7595), new DateTime(2022, 5, 26, 14, 52, 45, 168, DateTimeKind.Utc).AddTicks(7592) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 175, DateTimeKind.Utc).AddTicks(4450), new DateTime(2022, 5, 26, 14, 52, 45, 175, DateTimeKind.Utc).AddTicks(4446), new DateTime(2022, 5, 26, 14, 52, 45, 175, DateTimeKind.Utc).AddTicks(4454), new DateTime(2022, 5, 26, 14, 52, 45, 175, DateTimeKind.Utc).AddTicks(4452) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 181, DateTimeKind.Utc).AddTicks(5223), new DateTime(2022, 5, 26, 14, 52, 45, 181, DateTimeKind.Utc).AddTicks(5221), new DateTime(2022, 5, 26, 14, 52, 45, 181, DateTimeKind.Utc).AddTicks(5224), new DateTime(2022, 5, 26, 14, 52, 45, 181, DateTimeKind.Utc).AddTicks(5223) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 187, DateTimeKind.Utc).AddTicks(2429), new DateTime(2022, 5, 26, 14, 52, 45, 187, DateTimeKind.Utc).AddTicks(2428), new DateTime(2022, 5, 26, 14, 52, 45, 187, DateTimeKind.Utc).AddTicks(2430), new DateTime(2022, 5, 26, 14, 52, 45, 187, DateTimeKind.Utc).AddTicks(2429) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 194, DateTimeKind.Utc).AddTicks(81), new DateTime(2022, 5, 26, 14, 52, 45, 194, DateTimeKind.Utc).AddTicks(79), new DateTime(2022, 5, 26, 14, 52, 45, 194, DateTimeKind.Utc).AddTicks(83), new DateTime(2022, 5, 26, 14, 52, 45, 194, DateTimeKind.Utc).AddTicks(82) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 200, DateTimeKind.Utc).AddTicks(5552), new DateTime(2022, 5, 26, 14, 52, 45, 200, DateTimeKind.Utc).AddTicks(5551), new DateTime(2022, 5, 26, 14, 52, 45, 200, DateTimeKind.Utc).AddTicks(5554), new DateTime(2022, 5, 26, 14, 52, 45, 200, DateTimeKind.Utc).AddTicks(5553) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 206, DateTimeKind.Utc).AddTicks(8072), new DateTime(2022, 5, 26, 14, 52, 45, 206, DateTimeKind.Utc).AddTicks(8070), new DateTime(2022, 5, 26, 14, 52, 45, 206, DateTimeKind.Utc).AddTicks(8073), new DateTime(2022, 5, 26, 14, 52, 45, 206, DateTimeKind.Utc).AddTicks(8072) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 212, DateTimeKind.Utc).AddTicks(5818), new DateTime(2022, 5, 26, 14, 52, 45, 212, DateTimeKind.Utc).AddTicks(5816), new DateTime(2022, 5, 26, 14, 52, 45, 212, DateTimeKind.Utc).AddTicks(5820), new DateTime(2022, 5, 26, 14, 52, 45, 212, DateTimeKind.Utc).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 218, DateTimeKind.Utc).AddTicks(3063), new DateTime(2022, 5, 26, 14, 52, 45, 218, DateTimeKind.Utc).AddTicks(3061), new DateTime(2022, 5, 26, 14, 52, 45, 218, DateTimeKind.Utc).AddTicks(3065), new DateTime(2022, 5, 26, 14, 52, 45, 218, DateTimeKind.Utc).AddTicks(3064) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 224, DateTimeKind.Utc).AddTicks(2153), new DateTime(2022, 5, 26, 14, 52, 45, 224, DateTimeKind.Utc).AddTicks(2151), new DateTime(2022, 5, 26, 14, 52, 45, 224, DateTimeKind.Utc).AddTicks(2156), new DateTime(2022, 5, 26, 14, 52, 45, 224, DateTimeKind.Utc).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 230, DateTimeKind.Utc).AddTicks(3975), new DateTime(2022, 5, 26, 14, 52, 45, 230, DateTimeKind.Utc).AddTicks(3974), new DateTime(2022, 5, 26, 14, 52, 45, 230, DateTimeKind.Utc).AddTicks(3981), new DateTime(2022, 5, 26, 14, 52, 45, 230, DateTimeKind.Utc).AddTicks(3976) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 238, DateTimeKind.Utc).AddTicks(2230), new DateTime(2022, 5, 26, 14, 52, 45, 238, DateTimeKind.Utc).AddTicks(2227), new DateTime(2022, 5, 26, 14, 52, 45, 238, DateTimeKind.Utc).AddTicks(2232), new DateTime(2022, 5, 26, 14, 52, 45, 238, DateTimeKind.Utc).AddTicks(2231) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 245, DateTimeKind.Utc).AddTicks(1719), new DateTime(2022, 5, 26, 14, 52, 45, 245, DateTimeKind.Utc).AddTicks(1718), new DateTime(2022, 5, 26, 14, 52, 45, 245, DateTimeKind.Utc).AddTicks(1721), new DateTime(2022, 5, 26, 14, 52, 45, 245, DateTimeKind.Utc).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 251, DateTimeKind.Utc).AddTicks(7150), new DateTime(2022, 5, 26, 14, 52, 45, 251, DateTimeKind.Utc).AddTicks(7147), new DateTime(2022, 5, 26, 14, 52, 45, 251, DateTimeKind.Utc).AddTicks(7152), new DateTime(2022, 5, 26, 14, 52, 45, 251, DateTimeKind.Utc).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 259, DateTimeKind.Utc).AddTicks(4010), new DateTime(2022, 5, 26, 14, 52, 45, 259, DateTimeKind.Utc).AddTicks(4003), new DateTime(2022, 5, 26, 14, 52, 45, 259, DateTimeKind.Utc).AddTicks(4014), new DateTime(2022, 5, 26, 14, 52, 45, 259, DateTimeKind.Utc).AddTicks(4012) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 268, DateTimeKind.Utc).AddTicks(9592), new DateTime(2022, 5, 26, 14, 52, 45, 268, DateTimeKind.Utc).AddTicks(9589), new DateTime(2022, 5, 26, 14, 52, 45, 268, DateTimeKind.Utc).AddTicks(9595), new DateTime(2022, 5, 26, 14, 52, 45, 268, DateTimeKind.Utc).AddTicks(9593) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 276, DateTimeKind.Utc).AddTicks(5630), new DateTime(2022, 5, 26, 14, 52, 45, 276, DateTimeKind.Utc).AddTicks(5626), new DateTime(2022, 5, 26, 14, 52, 45, 276, DateTimeKind.Utc).AddTicks(5632), new DateTime(2022, 5, 26, 14, 52, 45, 276, DateTimeKind.Utc).AddTicks(5631) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 283, DateTimeKind.Utc).AddTicks(2660), new DateTime(2022, 5, 26, 14, 52, 45, 283, DateTimeKind.Utc).AddTicks(2655), new DateTime(2022, 5, 26, 14, 52, 45, 283, DateTimeKind.Utc).AddTicks(2663), new DateTime(2022, 5, 26, 14, 52, 45, 283, DateTimeKind.Utc).AddTicks(2661) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 289, DateTimeKind.Utc).AddTicks(7714), new DateTime(2022, 5, 26, 14, 52, 45, 289, DateTimeKind.Utc).AddTicks(7713), new DateTime(2022, 5, 26, 14, 52, 45, 289, DateTimeKind.Utc).AddTicks(7716), new DateTime(2022, 5, 26, 14, 52, 45, 289, DateTimeKind.Utc).AddTicks(7715) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 296, DateTimeKind.Utc).AddTicks(9891), new DateTime(2022, 5, 26, 14, 52, 45, 296, DateTimeKind.Utc).AddTicks(9889), new DateTime(2022, 5, 26, 14, 52, 45, 296, DateTimeKind.Utc).AddTicks(9893), new DateTime(2022, 5, 26, 14, 52, 45, 296, DateTimeKind.Utc).AddTicks(9892) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 304, DateTimeKind.Utc).AddTicks(2821), new DateTime(2022, 5, 26, 14, 52, 45, 304, DateTimeKind.Utc).AddTicks(2818), new DateTime(2022, 5, 26, 14, 52, 45, 304, DateTimeKind.Utc).AddTicks(2823), new DateTime(2022, 5, 26, 14, 52, 45, 304, DateTimeKind.Utc).AddTicks(2822) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 312, DateTimeKind.Utc).AddTicks(8700), new DateTime(2022, 5, 26, 14, 52, 45, 312, DateTimeKind.Utc).AddTicks(8698), new DateTime(2022, 5, 26, 14, 52, 45, 312, DateTimeKind.Utc).AddTicks(8702), new DateTime(2022, 5, 26, 14, 52, 45, 312, DateTimeKind.Utc).AddTicks(8701) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 320, DateTimeKind.Utc).AddTicks(4203), new DateTime(2022, 5, 26, 14, 52, 45, 320, DateTimeKind.Utc).AddTicks(4202), new DateTime(2022, 5, 26, 14, 52, 45, 320, DateTimeKind.Utc).AddTicks(4205), new DateTime(2022, 5, 26, 14, 52, 45, 320, DateTimeKind.Utc).AddTicks(4204) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 326, DateTimeKind.Utc).AddTicks(8816), new DateTime(2022, 5, 26, 14, 52, 45, 326, DateTimeKind.Utc).AddTicks(8813), new DateTime(2022, 5, 26, 14, 52, 45, 326, DateTimeKind.Utc).AddTicks(8818), new DateTime(2022, 5, 26, 14, 52, 45, 326, DateTimeKind.Utc).AddTicks(8817) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 332, DateTimeKind.Utc).AddTicks(9694), new DateTime(2022, 5, 26, 14, 52, 45, 332, DateTimeKind.Utc).AddTicks(9692), new DateTime(2022, 5, 26, 14, 52, 45, 332, DateTimeKind.Utc).AddTicks(9696), new DateTime(2022, 5, 26, 14, 52, 45, 332, DateTimeKind.Utc).AddTicks(9695) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 343, DateTimeKind.Utc).AddTicks(1109), new DateTime(2022, 5, 26, 14, 52, 45, 343, DateTimeKind.Utc).AddTicks(1107), new DateTime(2022, 5, 26, 14, 52, 45, 343, DateTimeKind.Utc).AddTicks(1111), new DateTime(2022, 5, 26, 14, 52, 45, 343, DateTimeKind.Utc).AddTicks(1110) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 352, DateTimeKind.Utc).AddTicks(7675), new DateTime(2022, 5, 26, 14, 52, 45, 352, DateTimeKind.Utc).AddTicks(7669), new DateTime(2022, 5, 26, 14, 52, 45, 352, DateTimeKind.Utc).AddTicks(7677), new DateTime(2022, 5, 26, 14, 52, 45, 352, DateTimeKind.Utc).AddTicks(7676) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 360, DateTimeKind.Utc).AddTicks(1519), new DateTime(2022, 5, 26, 14, 52, 45, 360, DateTimeKind.Utc).AddTicks(1518), new DateTime(2022, 5, 26, 14, 52, 45, 360, DateTimeKind.Utc).AddTicks(1521), new DateTime(2022, 5, 26, 14, 52, 45, 360, DateTimeKind.Utc).AddTicks(1520) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 365, DateTimeKind.Utc).AddTicks(9480), new DateTime(2022, 5, 26, 14, 52, 45, 365, DateTimeKind.Utc).AddTicks(9479), new DateTime(2022, 5, 26, 14, 52, 45, 365, DateTimeKind.Utc).AddTicks(9482), new DateTime(2022, 5, 26, 14, 52, 45, 365, DateTimeKind.Utc).AddTicks(9481) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 371, DateTimeKind.Utc).AddTicks(8984), new DateTime(2022, 5, 26, 14, 52, 45, 371, DateTimeKind.Utc).AddTicks(8983), new DateTime(2022, 5, 26, 14, 52, 45, 371, DateTimeKind.Utc).AddTicks(8985), new DateTime(2022, 5, 26, 14, 52, 45, 371, DateTimeKind.Utc).AddTicks(8985) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 377, DateTimeKind.Utc).AddTicks(8667), new DateTime(2022, 5, 26, 14, 52, 45, 377, DateTimeKind.Utc).AddTicks(8665), new DateTime(2022, 5, 26, 14, 52, 45, 377, DateTimeKind.Utc).AddTicks(8669), new DateTime(2022, 5, 26, 14, 52, 45, 377, DateTimeKind.Utc).AddTicks(8668) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 383, DateTimeKind.Utc).AddTicks(7790), new DateTime(2022, 5, 26, 14, 52, 45, 383, DateTimeKind.Utc).AddTicks(7789), new DateTime(2022, 5, 26, 14, 52, 45, 383, DateTimeKind.Utc).AddTicks(7792), new DateTime(2022, 5, 26, 14, 52, 45, 383, DateTimeKind.Utc).AddTicks(7791) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 389, DateTimeKind.Utc).AddTicks(7677), new DateTime(2022, 5, 26, 14, 52, 45, 389, DateTimeKind.Utc).AddTicks(7675), new DateTime(2022, 5, 26, 14, 52, 45, 389, DateTimeKind.Utc).AddTicks(7678), new DateTime(2022, 5, 26, 14, 52, 45, 389, DateTimeKind.Utc).AddTicks(7677) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 395, DateTimeKind.Utc).AddTicks(6979), new DateTime(2022, 5, 26, 14, 52, 45, 395, DateTimeKind.Utc).AddTicks(6978), new DateTime(2022, 5, 26, 14, 52, 45, 395, DateTimeKind.Utc).AddTicks(6982), new DateTime(2022, 5, 26, 14, 52, 45, 395, DateTimeKind.Utc).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 401, DateTimeKind.Utc).AddTicks(6938), new DateTime(2022, 5, 26, 14, 52, 45, 401, DateTimeKind.Utc).AddTicks(6937), new DateTime(2022, 5, 26, 14, 52, 45, 401, DateTimeKind.Utc).AddTicks(6940), new DateTime(2022, 5, 26, 14, 52, 45, 401, DateTimeKind.Utc).AddTicks(6939) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 411, DateTimeKind.Utc).AddTicks(4338), new DateTime(2022, 5, 26, 14, 52, 45, 411, DateTimeKind.Utc).AddTicks(4336), new DateTime(2022, 5, 26, 14, 52, 45, 411, DateTimeKind.Utc).AddTicks(4340), new DateTime(2022, 5, 26, 14, 52, 45, 411, DateTimeKind.Utc).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 419, DateTimeKind.Utc).AddTicks(872), new DateTime(2022, 5, 26, 14, 52, 45, 419, DateTimeKind.Utc).AddTicks(870), new DateTime(2022, 5, 26, 14, 52, 45, 419, DateTimeKind.Utc).AddTicks(873), new DateTime(2022, 5, 26, 14, 52, 45, 419, DateTimeKind.Utc).AddTicks(872) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 425, DateTimeKind.Utc).AddTicks(2687), new DateTime(2022, 5, 26, 14, 52, 45, 425, DateTimeKind.Utc).AddTicks(2686), new DateTime(2022, 5, 26, 14, 52, 45, 425, DateTimeKind.Utc).AddTicks(2689), new DateTime(2022, 5, 26, 14, 52, 45, 425, DateTimeKind.Utc).AddTicks(2688) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(2373), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(2371), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(2375), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(2374) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(866), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(1401), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(1119) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(2592), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(2598), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(2627), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(2629), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(2628) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(2650), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(2653), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(2652) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(2716), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(2718), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(2717) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e20"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "4d118932-b88b-4103-91bb-fbd24fbd71fe", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(5962), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(6465), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(6204) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e21"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "82d5fca1-3f16-419a-9af9-8cc8b495beda", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(7866), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(7871), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(7870) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e22"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "80690e75-e0d1-48d4-9307-450293fc61df", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(7904), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(7906), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(7905) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e23"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "98000c81-182d-466c-9f45-e73463cb2e54", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(7930), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(7932), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e24"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "4152e198-c89a-41eb-977c-59f1e0ea1451", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(7955), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(7957), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(7956) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e25"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "0f32d07e-eb5a-477b-88ae-8f7bb7e8c745", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8027), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8029), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8028) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e26"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "d025b7aa-f160-4bbf-9844-1f43a2252108", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8054), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8056), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8055) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e27"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "99b19e3b-fc30-4c56-a2d7-2e2b086dc31d", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8079), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8081), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8080) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e28"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "3ea4960b-09e5-46c4-93ba-1810112f9185", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8104), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8106), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8105) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e29"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "a4a5ccf7-c98f-4678-9a76-498bc64722c6", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8133), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8135), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8134) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e30"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "cd1bea7e-417b-4455-9b03-e234b9c58624", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8191), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8193), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8192) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e31"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "ca67bf85-f7ab-40c2-ae53-e52be73bc67b", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8219), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8220), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8219) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e32"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "b2fc21a8-b2ae-4f55-8d63-4ddd7dfd0ba8", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8244), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8246), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8245) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e33"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "473dd3e4-80c8-4eca-bd1f-2bf26556546a", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8269), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8271), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8270) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e34"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "c109704d-b3b4-498f-95df-642eeec07b83", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8293), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8295), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8294) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e35"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "b620a8c4-6bfd-446e-b093-bd73d39314bc", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8317), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8319), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8318) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e36"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "03eb1814-fdcd-4d64-bd3f-89368d1b6ca5", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8409), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8411), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8410) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e37"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "3186cd92-80ca-4cd8-b14d-c1f2623081e5", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8442), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8444), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8443) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e38"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "c58d9d7a-1b7f-4403-8815-b7e8743fdca5", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8468), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8469), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8469) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e39"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "00451ee6-2429-4d3f-a757-32742ced34c5", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8492), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8494), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8493) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e40"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "4ba8fbe4-ae56-4371-b50c-d4645b37f885", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8517), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8519), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8518) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e41"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "8b79f797-301b-40e3-99a4-8331a1180f69", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8541), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8543), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8542) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e42"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "2d7f7030-1260-4227-b332-6886d19f8977", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8599), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8601), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e43"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "209a5868-010e-4bf0-927e-7e9bd98b40ce", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8625), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8627), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e44"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "62e416d2-7d08-4393-9c96-e8b69b260c13", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8650), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8651), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e45"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "96151bf1-a53a-4d63-ac01-44a5bb2ee799", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8676), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8678), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8677) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e46"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "31ba6f18-4d29-4d78-ae47-b9e78c550c2b", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8700), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8702), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8701) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e47"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "2690d174-760f-4e39-b9a8-146fbb330031", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8782), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8784), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8783) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e48"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "5aa1a387-0532-4f36-a4ae-7c1f855e51db", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8810), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8812), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8811) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e49"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "f47c0656-16fb-49fd-b329-66b4241a60eb", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8835), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8837), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8836) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e50"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "d052c74e-9ef3-4456-a38e-68759334d408", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8859), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8861), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e51"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "4111c44a-ce4d-4151-b002-dcfad7488bfd", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8883), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8885), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e52"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "389e4b10-e99c-4a92-89f9-3730690ab197", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8907), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8909), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8908) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e53"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "3d5b7c05-97eb-40fe-8a86-0a0888a43478", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8967), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8969), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8968) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e54"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "76367486-687d-4468-913d-4e7bf1a8caca", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8993), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8995), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e55"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "55ad3f5f-3360-48ad-95cb-1a02a3a3af00", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9019), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9020), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e56"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "3a559de0-f5b8-43aa-9d9d-de063993cbef", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9044), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9046), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e57"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "5bf99142-c256-4702-b810-5f9b8ba7647a", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9069), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9070), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9069) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e58"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "3b422adf-21bc-4db2-ae2b-c2b8d0db3ef8", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9123), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9125), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9125) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e59"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "b2f4cbec-2c09-4727-9527-155d40d88e9f", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9151), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9153), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e60"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "6939dce7-0715-4c74-b9ed-62bca1914a22", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9176), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9178), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e61"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "59a61f76-0208-4e5a-a11f-5170d0d52a7f", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9203), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9205), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9204) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e62"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "c52000bc-0dfa-4cd2-bf9d-090c79e1bce5", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9229), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9231), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e63"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "a9101e6f-9712-43f9-8a56-1aaa8565a09b", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9254), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9255), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9254) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e64"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "ead6b195-2e12-4365-914e-19ef5d682659", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9309), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9311), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9310) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e65"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "2b6e84d9-2843-4f8c-b3ee-ffc62fbf077c", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9335), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9337), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e66"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "98e02de1-ec27-481e-b3ab-4cba2f4c4c5e", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9360), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9362), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e67"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "095bc459-4206-4e3d-afe6-d1169e6b89c0", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9384), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9386), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9385) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e68"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "9b429dfa-f31d-4fe0-a19a-868645241d6c", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9408), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9410), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9409) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e69"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "48214f1b-6765-4465-af60-f688320072c4", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9435), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9437), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9436) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e70"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "c6b2592e-2fd7-4379-9d08-f02e51d6ef65", new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9492), new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9494), 0, new DateTime(2022, 5, 26, 21, 52, 45, 77, DateTimeKind.Local).AddTicks(9493) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Deleted_at", "EndDate", "StartDate", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 21, 52, 45, 75, DateTimeKind.Local).AddTicks(9051), new DateTime(2022, 5, 26, 21, 52, 45, 75, DateTimeKind.Local).AddTicks(9792), new DateTime(2022, 5, 26, 21, 52, 45, 75, DateTimeKind.Local).AddTicks(7038), new DateTime(2022, 5, 26, 21, 52, 45, 75, DateTimeKind.Local).AddTicks(2354), new DateTime(2022, 5, 26, 21, 52, 45, 75, DateTimeKind.Local).AddTicks(9286) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "Deleted_at", "EndDate", "StartDate", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 21, 52, 45, 76, DateTimeKind.Local).AddTicks(9124), new DateTime(2022, 5, 26, 21, 52, 45, 76, DateTimeKind.Local).AddTicks(9126), new DateTime(2022, 5, 26, 21, 52, 45, 76, DateTimeKind.Local).AddTicks(9120), new DateTime(2022, 5, 26, 21, 52, 45, 76, DateTimeKind.Local).AddTicks(9114), new DateTime(2022, 5, 26, 21, 52, 45, 76, DateTimeKind.Local).AddTicks(9125) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "Deleted_at", "EndDate", "StartDate", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 21, 52, 45, 76, DateTimeKind.Local).AddTicks(9243), new DateTime(2022, 5, 26, 21, 52, 45, 76, DateTimeKind.Local).AddTicks(9245), new DateTime(2022, 5, 26, 21, 52, 45, 76, DateTimeKind.Local).AddTicks(9241), new DateTime(2022, 5, 26, 21, 52, 45, 76, DateTimeKind.Local).AddTicks(9240), new DateTime(2022, 5, 26, 21, 52, 45, 76, DateTimeKind.Local).AddTicks(9244) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "Deleted_at", "EndDate", "StartDate", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 21, 52, 45, 76, DateTimeKind.Local).AddTicks(9271), new DateTime(2022, 5, 26, 21, 52, 45, 76, DateTimeKind.Local).AddTicks(9272), new DateTime(2022, 5, 26, 21, 52, 45, 76, DateTimeKind.Local).AddTicks(9269), new DateTime(2022, 5, 26, 21, 52, 45, 76, DateTimeKind.Local).AddTicks(9268), new DateTime(2022, 5, 26, 21, 52, 45, 76, DateTimeKind.Local).AddTicks(9271) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_at", "Deleted_at", "EndDate", "StartDate", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 21, 52, 45, 76, DateTimeKind.Local).AddTicks(9293), new DateTime(2022, 5, 26, 21, 52, 45, 76, DateTimeKind.Local).AddTicks(9295), new DateTime(2022, 5, 26, 21, 52, 45, 76, DateTimeKind.Local).AddTicks(9292), new DateTime(2022, 5, 26, 21, 52, 45, 76, DateTimeKind.Local).AddTicks(9291), new DateTime(2022, 5, 26, 21, 52, 45, 76, DateTimeKind.Local).AddTicks(9294) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "4a4930ea-312b-4140-920b-1db3e08170aa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"),
                column: "ConcurrencyStamp",
                value: "99c66599-37be-42de-9ae4-6d8c1f334a27");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 21, 52, 45, 78, DateTimeKind.Local).AddTicks(976), new DateTime(2022, 5, 26, 21, 52, 45, 78, DateTimeKind.Local).AddTicks(1521), new DateTime(2022, 5, 26, 21, 52, 45, 78, DateTimeKind.Local).AddTicks(1217) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 21, 52, 45, 78, DateTimeKind.Local).AddTicks(2930), new DateTime(2022, 5, 26, 21, 52, 45, 78, DateTimeKind.Local).AddTicks(2936), new DateTime(2022, 5, 26, 21, 52, 45, 78, DateTimeKind.Local).AddTicks(2935) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 21, 52, 45, 78, DateTimeKind.Local).AddTicks(2968), new DateTime(2022, 5, 26, 21, 52, 45, 78, DateTimeKind.Local).AddTicks(2970), new DateTime(2022, 5, 26, 21, 52, 45, 78, DateTimeKind.Local).AddTicks(2969) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 21, 52, 45, 78, DateTimeKind.Local).AddTicks(2992), new DateTime(2022, 5, 26, 21, 52, 45, 78, DateTimeKind.Local).AddTicks(2994), new DateTime(2022, 5, 26, 21, 52, 45, 78, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 21, 52, 45, 78, DateTimeKind.Local).AddTicks(3015), new DateTime(2022, 5, 26, 21, 52, 45, 78, DateTimeKind.Local).AddTicks(3017), new DateTime(2022, 5, 26, 21, 52, 45, 78, DateTimeKind.Local).AddTicks(3016) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2620"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "a5661f77-fcab-42b5-93fc-f4dccb2b5f02", new DateTime(2022, 5, 26, 14, 52, 45, 89, DateTimeKind.Utc).AddTicks(7016), new DateTime(2022, 5, 26, 14, 52, 45, 89, DateTimeKind.Utc).AddTicks(7617), 0, "AQAAAAEAACcQAAAAEFzTgK4S/QMXTVlZNqHnhwYq5nfbgwIsCbmHRkburIVszP+ZnE7dE0ojykXZbDiU1w==", new DateTime(2022, 5, 26, 14, 52, 45, 89, DateTimeKind.Utc).AddTicks(7301) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2621"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "b4b7220c-4dcb-4332-9fba-d259925dac31", new DateTime(2022, 5, 26, 14, 52, 45, 96, DateTimeKind.Utc).AddTicks(676), new DateTime(2022, 5, 26, 14, 52, 45, 96, DateTimeKind.Utc).AddTicks(679), 0, "AQAAAAEAACcQAAAAECruvab37bmpeLU0qBIMJsocYkdv995ZMw3lUCn6x5Grz5NMC2uK638exgsvuihgBQ==", new DateTime(2022, 5, 26, 14, 52, 45, 96, DateTimeKind.Utc).AddTicks(678) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2622"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "9b8641be-651b-4d2a-870a-5d2e1ae3c137", new DateTime(2022, 5, 26, 14, 52, 45, 101, DateTimeKind.Utc).AddTicks(7973), new DateTime(2022, 5, 26, 14, 52, 45, 101, DateTimeKind.Utc).AddTicks(7977), 0, "AQAAAAEAACcQAAAAEGOqzoqgqsKcnUnGF86xvvAtfm9V3DeMHukHhZnsuT9qmh17LlmBXYAOReXka/dwZQ==", new DateTime(2022, 5, 26, 14, 52, 45, 101, DateTimeKind.Utc).AddTicks(7976) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2623"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "ec492477-a9bd-4cad-a313-c924cb816b0a", new DateTime(2022, 5, 26, 14, 52, 45, 107, DateTimeKind.Utc).AddTicks(4945), new DateTime(2022, 5, 26, 14, 52, 45, 107, DateTimeKind.Utc).AddTicks(4948), 0, "AQAAAAEAACcQAAAAEDoxz4MuCepon3CaL2Ya/PpeGsQ32Oiv3XfFya8Ja8shvf2YfOvbaFAlrH9zdvvndg==", new DateTime(2022, 5, 26, 14, 52, 45, 107, DateTimeKind.Utc).AddTicks(4947) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2624"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "85e8fb3c-9ca0-4942-88dc-9db44adfbf74", new DateTime(2022, 5, 26, 14, 52, 45, 113, DateTimeKind.Utc).AddTicks(2310), new DateTime(2022, 5, 26, 14, 52, 45, 113, DateTimeKind.Utc).AddTicks(2315), 0, "AQAAAAEAACcQAAAAEIK/u1R1XOlLXcYdbuvhTEdj0M+3LwLPk+59zB3rtJQJ3A1FoTsMv5wqbRjHAXCRNg==", new DateTime(2022, 5, 26, 14, 52, 45, 113, DateTimeKind.Utc).AddTicks(2314) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2625"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "aef9ff41-92ee-4ceb-b84d-22f42ac73058", new DateTime(2022, 5, 26, 14, 52, 45, 118, DateTimeKind.Utc).AddTicks(9669), new DateTime(2022, 5, 26, 14, 52, 45, 118, DateTimeKind.Utc).AddTicks(9672), 0, "AQAAAAEAACcQAAAAEJva1wp1FzjECAYqwwH1oE/RPOCLSgfekoyYljlrRYwxSG38xU3qu0VOHVQ7Xi6HFQ==", new DateTime(2022, 5, 26, 14, 52, 45, 118, DateTimeKind.Utc).AddTicks(9671) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2626"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "3d20e65c-601a-4c00-9de6-4b2aa11e2d70", new DateTime(2022, 5, 26, 14, 52, 45, 124, DateTimeKind.Utc).AddTicks(6629), new DateTime(2022, 5, 26, 14, 52, 45, 124, DateTimeKind.Utc).AddTicks(6632), 0, "AQAAAAEAACcQAAAAEAndHDFgyUoFuZnWuc7+ryRjIywYUceOZo0PLjMs6pGLV/WpQIrFUUIYnWLNSEibtA==", new DateTime(2022, 5, 26, 14, 52, 45, 124, DateTimeKind.Utc).AddTicks(6631) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2627"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "c7754097-c5a4-4dcf-b808-f993ca798b1f", new DateTime(2022, 5, 26, 14, 52, 45, 130, DateTimeKind.Utc).AddTicks(8400), new DateTime(2022, 5, 26, 14, 52, 45, 130, DateTimeKind.Utc).AddTicks(8414), 0, "AQAAAAEAACcQAAAAEEC+EiYYYqJTfCMY7E7Uts7OrQo6u/1ohPVwL6wlN4vlMl8NDyw8mB9Vk4aOujKzmg==", new DateTime(2022, 5, 26, 14, 52, 45, 130, DateTimeKind.Utc).AddTicks(8408) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2628"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "794cc3b5-34dd-4f18-8a5b-827ff0e6334f", new DateTime(2022, 5, 26, 14, 52, 45, 136, DateTimeKind.Utc).AddTicks(6409), new DateTime(2022, 5, 26, 14, 52, 45, 136, DateTimeKind.Utc).AddTicks(6416), 0, "AQAAAAEAACcQAAAAECCi5x2Gl28HXf6lZY4yerExNBQLU3akI1/cQjeZW+MZKnGHgs/QyzxgkHTNVETn5g==", new DateTime(2022, 5, 26, 14, 52, 45, 136, DateTimeKind.Utc).AddTicks(6414) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2629"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "9e04f08f-d504-49f2-8a2f-ec21d7361ae5", new DateTime(2022, 5, 26, 14, 52, 45, 142, DateTimeKind.Utc).AddTicks(4056), new DateTime(2022, 5, 26, 14, 52, 45, 142, DateTimeKind.Utc).AddTicks(4061), 0, "AQAAAAEAACcQAAAAEBuSDvUvc7n2nlH0J7DNuG6P6ryvyIrGqdaLBDssRk8KRfMpjGqEv3GN+4HxNaJ92A==", new DateTime(2022, 5, 26, 14, 52, 45, 142, DateTimeKind.Utc).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2630"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "acbff0d0-65cf-4f0a-b213-547342d4ea96", new DateTime(2022, 5, 26, 14, 52, 45, 148, DateTimeKind.Utc).AddTicks(4538), new DateTime(2022, 5, 26, 14, 52, 45, 148, DateTimeKind.Utc).AddTicks(4547), 0, "AQAAAAEAACcQAAAAEFjlN5J1febve3Dpd6VoxPGJjtBw4FuF+y6e8C+ABO4VFt+Y+LMfP21AZE6wKmFlUg==", new DateTime(2022, 5, 26, 14, 52, 45, 148, DateTimeKind.Utc).AddTicks(4544) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2631"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "6e7f072a-d68a-4192-8684-9b1fa5c040f0", new DateTime(2022, 5, 26, 14, 52, 45, 154, DateTimeKind.Utc).AddTicks(8994), new DateTime(2022, 5, 26, 14, 52, 45, 154, DateTimeKind.Utc).AddTicks(9008), 0, "AQAAAAEAACcQAAAAEOdPXbtY0P/12QnSfUcL30R/7uWa7UiwoUUZyvAO/p2EC5dJ5igjJHwqKIlqgFg6jw==", new DateTime(2022, 5, 26, 14, 52, 45, 154, DateTimeKind.Utc).AddTicks(9004) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2632"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "7e2c2894-e1a1-404d-aab6-c2b2b028c037", new DateTime(2022, 5, 26, 14, 52, 45, 162, DateTimeKind.Utc).AddTicks(3086), new DateTime(2022, 5, 26, 14, 52, 45, 162, DateTimeKind.Utc).AddTicks(3099), 0, "AQAAAAEAACcQAAAAEJgbyiIwsb4Slj6bkDoZKGEDYJC9XCbOS388cxeM/1e9UFQUpqQ8tzIQmXhGn7Qe3g==", new DateTime(2022, 5, 26, 14, 52, 45, 162, DateTimeKind.Utc).AddTicks(3093) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2633"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "e56e6334-2ec4-42a1-acfb-a311b6b170de", new DateTime(2022, 5, 26, 14, 52, 45, 168, DateTimeKind.Utc).AddTicks(7269), new DateTime(2022, 5, 26, 14, 52, 45, 168, DateTimeKind.Utc).AddTicks(7284), 0, "AQAAAAEAACcQAAAAEPb2noEauxKxOsP1Gu+4dCEUwcblIod0dp3BDsAU4z9EQZV/9pjDeizp90dkf8gFKQ==", new DateTime(2022, 5, 26, 14, 52, 45, 168, DateTimeKind.Utc).AddTicks(7278) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2634"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "140b420a-1449-402c-9dae-86085dbaa52a", new DateTime(2022, 5, 26, 14, 52, 45, 175, DateTimeKind.Utc).AddTicks(4038), new DateTime(2022, 5, 26, 14, 52, 45, 175, DateTimeKind.Utc).AddTicks(4047), 0, "AQAAAAEAACcQAAAAECr4240Y0xPzgutSSCNVDm4Sdb/9dR+XT0iBnrTuEoPsXrYuAGRjCMcYe0W1Upy2Xg==", new DateTime(2022, 5, 26, 14, 52, 45, 175, DateTimeKind.Utc).AddTicks(4044) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2635"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "e084ee08-168b-4cde-b07c-99ae8b9e1913", new DateTime(2022, 5, 26, 14, 52, 45, 181, DateTimeKind.Utc).AddTicks(4961), new DateTime(2022, 5, 26, 14, 52, 45, 181, DateTimeKind.Utc).AddTicks(4970), 0, "AQAAAAEAACcQAAAAEDb1MT5fKkFjoXkdSlHAyZC/chhlICchowt5CNioRH9qDYVrF8dhpbNac1YuQEvcZA==", new DateTime(2022, 5, 26, 14, 52, 45, 181, DateTimeKind.Utc).AddTicks(4968) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2636"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "07076880-e8bd-4346-b306-1af3492eb757", new DateTime(2022, 5, 26, 14, 52, 45, 187, DateTimeKind.Utc).AddTicks(2240), new DateTime(2022, 5, 26, 14, 52, 45, 187, DateTimeKind.Utc).AddTicks(2244), 0, "AQAAAAEAACcQAAAAEGWq8N9KJFBK/MrFOgfp4VBUQ421s6RBtcNhzHiUssXP1LgWjQXZHnQRF/x+fXgoLQ==", new DateTime(2022, 5, 26, 14, 52, 45, 187, DateTimeKind.Utc).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2637"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "09539f83-32af-459b-a3ad-3639983799d9", new DateTime(2022, 5, 26, 14, 52, 45, 193, DateTimeKind.Utc).AddTicks(9841), new DateTime(2022, 5, 26, 14, 52, 45, 193, DateTimeKind.Utc).AddTicks(9850), 0, "AQAAAAEAACcQAAAAEOTCsebKr1NDwhUQPPzkSV0tmoQe1wZasYP1q+uYhp9QcO2R/Fku2O2B3wydosiYrA==", new DateTime(2022, 5, 26, 14, 52, 45, 193, DateTimeKind.Utc).AddTicks(9848) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2638"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "10389e9e-4c01-4733-9ccd-2fb760d1b085", new DateTime(2022, 5, 26, 14, 52, 45, 200, DateTimeKind.Utc).AddTicks(5285), new DateTime(2022, 5, 26, 14, 52, 45, 200, DateTimeKind.Utc).AddTicks(5293), 0, "AQAAAAEAACcQAAAAEEL21sw3hl0bKS/KFnm88xYz3PYv3me89hafCJtGlOIxPz2jOv/70PVMNAZmFMGZyQ==", new DateTime(2022, 5, 26, 14, 52, 45, 200, DateTimeKind.Utc).AddTicks(5291) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2639"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "6a37165e-8795-4966-b265-76bb1276e48e", new DateTime(2022, 5, 26, 14, 52, 45, 206, DateTimeKind.Utc).AddTicks(7833), new DateTime(2022, 5, 26, 14, 52, 45, 206, DateTimeKind.Utc).AddTicks(7842), 0, "AQAAAAEAACcQAAAAEJ7ayhW57bf0QkJVq9uRMtWASKNQOrb+ul+PeQVu6UjHwc5tPkhlgAUXPRWTH23n3A==", new DateTime(2022, 5, 26, 14, 52, 45, 206, DateTimeKind.Utc).AddTicks(7841) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2640"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "49202746-9672-4597-aaca-65469595d93a", new DateTime(2022, 5, 26, 14, 52, 45, 212, DateTimeKind.Utc).AddTicks(5677), new DateTime(2022, 5, 26, 14, 52, 45, 212, DateTimeKind.Utc).AddTicks(5682), 0, "AQAAAAEAACcQAAAAEJ11pytDvtCDD8zsZt+tChaZjwn6u2Y+omvklpYbYAZqQre1XAEEeGFdJcauRAu9cQ==", new DateTime(2022, 5, 26, 14, 52, 45, 212, DateTimeKind.Utc).AddTicks(5681) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2641"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "d2730b5e-d73e-4989-a6fe-0d36f1cba6ff", new DateTime(2022, 5, 26, 14, 52, 45, 218, DateTimeKind.Utc).AddTicks(2869), new DateTime(2022, 5, 26, 14, 52, 45, 218, DateTimeKind.Utc).AddTicks(2878), 0, "AQAAAAEAACcQAAAAEM0UZrwMMv8+IIWN7ewsqUUp6AeSTLw1q8Yzj2ISCwzNfUaEOAnUfOE3uF+WgL9N9w==", new DateTime(2022, 5, 26, 14, 52, 45, 218, DateTimeKind.Utc).AddTicks(2873) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2642"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "5d5d9d18-3369-4e9b-9aeb-60d90b362151", new DateTime(2022, 5, 26, 14, 52, 45, 224, DateTimeKind.Utc).AddTicks(1636), new DateTime(2022, 5, 26, 14, 52, 45, 224, DateTimeKind.Utc).AddTicks(1648), 0, "AQAAAAEAACcQAAAAEJDQZm25/TCA62eRjwLDHwNZarDl4E7y6ZW8hFlYm869e512yhWSdM7V27qiiAxoyQ==", new DateTime(2022, 5, 26, 14, 52, 45, 224, DateTimeKind.Utc).AddTicks(1645) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2643"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "0bc74a8c-b875-411f-8326-2a230fc538ee", new DateTime(2022, 5, 26, 14, 52, 45, 230, DateTimeKind.Utc).AddTicks(3664), new DateTime(2022, 5, 26, 14, 52, 45, 230, DateTimeKind.Utc).AddTicks(3677), 0, "AQAAAAEAACcQAAAAECfZq2iUcxvZ5nS/pOJPbxZcRa0jv2rki7yYtWMJgw0VAr6XEEhipNyYPzNgyN8wAw==", new DateTime(2022, 5, 26, 14, 52, 45, 230, DateTimeKind.Utc).AddTicks(3675) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2644"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "1acc5cbf-ef0a-4203-a964-bfe64b86133b", new DateTime(2022, 5, 26, 14, 52, 45, 238, DateTimeKind.Utc).AddTicks(1683), new DateTime(2022, 5, 26, 14, 52, 45, 238, DateTimeKind.Utc).AddTicks(1696), 0, "AQAAAAEAACcQAAAAEFlT0qvNlKdOu66EW1+MIrsUvgW5+Hv8oja/tW7qx40RotumLGQyhwOBk+IHydRqiw==", new DateTime(2022, 5, 26, 14, 52, 45, 238, DateTimeKind.Utc).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2645"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "63221f67-35f5-4712-8549-d6f4938a716e", new DateTime(2022, 5, 26, 14, 52, 45, 245, DateTimeKind.Utc).AddTicks(1424), new DateTime(2022, 5, 26, 14, 52, 45, 245, DateTimeKind.Utc).AddTicks(1437), 0, "AQAAAAEAACcQAAAAEABoar77zDaylRHCmr7EUPIYO38t5ppSO0O5o4TO6zCpM02cj1d+UH5gZWfXVL+vBg==", new DateTime(2022, 5, 26, 14, 52, 45, 245, DateTimeKind.Utc).AddTicks(1435) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2646"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "5c2d795c-ead3-4860-9fbd-79ca6d838fc5", new DateTime(2022, 5, 26, 14, 52, 45, 251, DateTimeKind.Utc).AddTicks(6728), new DateTime(2022, 5, 26, 14, 52, 45, 251, DateTimeKind.Utc).AddTicks(6738), 0, "AQAAAAEAACcQAAAAEENQMeQO1Qdb3H7bxnxeaU3sVUvzM2t5lD07tpoV6TrB7DdWQqBQhdz+DpSL5IWuIw==", new DateTime(2022, 5, 26, 14, 52, 45, 251, DateTimeKind.Utc).AddTicks(6735) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2647"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "25ba3289-a88d-47f9-9da3-6b920a7e67d2", new DateTime(2022, 5, 26, 14, 52, 45, 259, DateTimeKind.Utc).AddTicks(3032), new DateTime(2022, 5, 26, 14, 52, 45, 259, DateTimeKind.Utc).AddTicks(3048), 0, "AQAAAAEAACcQAAAAEFrdbUrzHdMHaYEn67QtYxQigVXXKN/HARpCGSBHQenU9Pja58y5L95J/jZUYFPaeA==", new DateTime(2022, 5, 26, 14, 52, 45, 259, DateTimeKind.Utc).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2648"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "aea74899-6fe0-4a23-992e-7c4a7ed96bdf", new DateTime(2022, 5, 26, 14, 52, 45, 268, DateTimeKind.Utc).AddTicks(9000), new DateTime(2022, 5, 26, 14, 52, 45, 268, DateTimeKind.Utc).AddTicks(9012), 0, "AQAAAAEAACcQAAAAELSmb/96ViQ7N1O30kF2ZPy1uFa+dIxC44orU3BjF6qpytbTO8xKgEBnxPwxBMHFMQ==", new DateTime(2022, 5, 26, 14, 52, 45, 268, DateTimeKind.Utc).AddTicks(9009) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2649"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "b55eb3b1-0b54-4bd3-9329-e989cec62bed", new DateTime(2022, 5, 26, 14, 52, 45, 276, DateTimeKind.Utc).AddTicks(5073), new DateTime(2022, 5, 26, 14, 52, 45, 276, DateTimeKind.Utc).AddTicks(5091), 0, "AQAAAAEAACcQAAAAEP7iu69HWyzTtZQch8nhqEcJY3JrB11/P5DO5KUm90ThU16x9P7g2o6Yq+O9exSDIA==", new DateTime(2022, 5, 26, 14, 52, 45, 276, DateTimeKind.Utc).AddTicks(5088) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2650"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "4a4c26f0-8ada-4ecd-83c6-5d65cf7ee3f2", new DateTime(2022, 5, 26, 14, 52, 45, 283, DateTimeKind.Utc).AddTicks(1910), new DateTime(2022, 5, 26, 14, 52, 45, 283, DateTimeKind.Utc).AddTicks(1920), 0, "AQAAAAEAACcQAAAAEAFE9xdrLa4aSb3IKIpFTQ+M2Lqt1YHuRmVbLcRFnm3OzONoP3AKSGG+s+TdTINRBA==", new DateTime(2022, 5, 26, 14, 52, 45, 283, DateTimeKind.Utc).AddTicks(1916) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "31f8033e-8c8b-468e-a6ae-c428b9ae9072", new DateTime(2022, 5, 26, 14, 52, 45, 289, DateTimeKind.Utc).AddTicks(7374), new DateTime(2022, 5, 26, 14, 52, 45, 289, DateTimeKind.Utc).AddTicks(7387), 1, "AQAAAAEAACcQAAAAEO8auctxuzybVj5898C56dNin3HwiI8K36iiFL+spJMjQ++x12TDVB0/WThJCoJbpw==", new DateTime(2022, 5, 26, 14, 52, 45, 289, DateTimeKind.Utc).AddTicks(7381) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "bce7d913-3307-4e9c-b16f-af38af248d87", new DateTime(2022, 5, 26, 14, 52, 45, 296, DateTimeKind.Utc).AddTicks(9398), new DateTime(2022, 5, 26, 14, 52, 45, 296, DateTimeKind.Utc).AddTicks(9408), 1, "AQAAAAEAACcQAAAAEH8x+mNV2KCXvfkeuh9EnEkrGo6up52GW66Sn3MYNhI6ieKNpSWGrbXc/KUCfWQBzQ==", new DateTime(2022, 5, 26, 14, 52, 45, 296, DateTimeKind.Utc).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "e64103e8-5fa0-4420-a7e1-4daa3b8c03cc", new DateTime(2022, 5, 26, 14, 52, 45, 304, DateTimeKind.Utc).AddTicks(2416), new DateTime(2022, 5, 26, 14, 52, 45, 304, DateTimeKind.Utc).AddTicks(2430), 1, "AQAAAAEAACcQAAAAELeKQ79rP5lNsEVYEVVZllL9Eamw5wR27Ucvgg/S1dbVFCB4AauATMmgveY+s2v1MA==", new DateTime(2022, 5, 26, 14, 52, 45, 304, DateTimeKind.Utc).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "5aad4627-9618-450a-8a70-f611fc7580c0", new DateTime(2022, 5, 26, 14, 52, 45, 312, DateTimeKind.Utc).AddTicks(8287), new DateTime(2022, 5, 26, 14, 52, 45, 312, DateTimeKind.Utc).AddTicks(8296), 1, "AQAAAAEAACcQAAAAELhBjtJ/qz6nxWFXFlTOi+8naom23L/LesxnnaUw9Wkpbk7NV4jkNfNvAEmMmZiXsw==", new DateTime(2022, 5, 26, 14, 52, 45, 312, DateTimeKind.Utc).AddTicks(8294) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "bca3bb78-58a4-4452-9558-fc41c1144471", new DateTime(2022, 5, 26, 14, 52, 45, 320, DateTimeKind.Utc).AddTicks(3835), new DateTime(2022, 5, 26, 14, 52, 45, 320, DateTimeKind.Utc).AddTicks(3843), 1, "AQAAAAEAACcQAAAAENFTAPCzNCscx+t1+9Sqj9gAXfpF6FMFs91aLjqSu99+V7ZhuEHFdkIRJdjrK6JxyA==", new DateTime(2022, 5, 26, 14, 52, 45, 320, DateTimeKind.Utc).AddTicks(3842) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "dd72c204-83eb-4fcf-817f-4d925a21df1a", new DateTime(2022, 5, 26, 14, 52, 45, 326, DateTimeKind.Utc).AddTicks(8459), new DateTime(2022, 5, 26, 14, 52, 45, 326, DateTimeKind.Utc).AddTicks(8552), 1, "AQAAAAEAACcQAAAAEJu/ie9taSkW/f3fMM0hAFPhKD5McjblFyxTL7JqFfHPeY20UvZU8yALIj31c9uXhQ==", new DateTime(2022, 5, 26, 14, 52, 45, 326, DateTimeKind.Utc).AddTicks(8549) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "7f9cd4cc-e614-45ae-888d-cbba3b108072", new DateTime(2022, 5, 26, 14, 52, 45, 332, DateTimeKind.Utc).AddTicks(9397), new DateTime(2022, 5, 26, 14, 52, 45, 332, DateTimeKind.Utc).AddTicks(9406), 1, "AQAAAAEAACcQAAAAEBhUCGjb+SWWzLpUyyl1DJTX5vyt8pCixDsQJQu4i9fu3h2vYxXg4z/Fd9W9sa3Hbw==", new DateTime(2022, 5, 26, 14, 52, 45, 332, DateTimeKind.Utc).AddTicks(9403) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "a7799b3f-6fcf-49d6-8df2-66801fd93e89", new DateTime(2022, 5, 26, 14, 52, 45, 343, DateTimeKind.Utc).AddTicks(864), new DateTime(2022, 5, 26, 14, 52, 45, 343, DateTimeKind.Utc).AddTicks(875), 1, "AQAAAAEAACcQAAAAEGB6el2F1G4Q/t3/r0llvKySeiRVCXVf8c6jkaNIHVr0rv+p+goDcD/Hdmbp77LQvA==", new DateTime(2022, 5, 26, 14, 52, 45, 343, DateTimeKind.Utc).AddTicks(873) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "d7e5187c-d543-4c93-8735-4ce6f8f0888a", new DateTime(2022, 5, 26, 14, 52, 45, 352, DateTimeKind.Utc).AddTicks(7382), new DateTime(2022, 5, 26, 14, 52, 45, 352, DateTimeKind.Utc).AddTicks(7395), 1, "AQAAAAEAACcQAAAAEC4wDWiXjJwM5GxxLaVdxoRboOfLe2l70EO/YeBDuSKLs//qZ2cC025vGvUXtW21rw==", new DateTime(2022, 5, 26, 14, 52, 45, 352, DateTimeKind.Utc).AddTicks(7392) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "595608e2-a0a2-4fd1-8245-af01c62b096f", new DateTime(2022, 5, 26, 14, 52, 45, 360, DateTimeKind.Utc).AddTicks(1292), new DateTime(2022, 5, 26, 14, 52, 45, 360, DateTimeKind.Utc).AddTicks(1301), 1, "AQAAAAEAACcQAAAAEPfNhzcSzjU6yX/vhTgtKewHh/spja860Iy5ZXMjfcACp340DMyydicrJ7MV7oCQ+w==", new DateTime(2022, 5, 26, 14, 52, 45, 360, DateTimeKind.Utc).AddTicks(1299) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3361"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "24c5edd5-d9eb-4c12-9d2e-751efc273a0a", new DateTime(2022, 5, 26, 14, 52, 45, 365, DateTimeKind.Utc).AddTicks(9337), new DateTime(2022, 5, 26, 14, 52, 45, 365, DateTimeKind.Utc).AddTicks(9344), 1, "AQAAAAEAACcQAAAAEFX8ZLpybITd2XyuNG9m30t8UdbJa8hcf5kO4mqLy0stz6wGWBTLfRsgs9cMniEZ7Q==", new DateTime(2022, 5, 26, 14, 52, 45, 365, DateTimeKind.Utc).AddTicks(9343) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3362"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "b866c394-ff62-4143-8e39-31a4876d53bd", new DateTime(2022, 5, 26, 14, 52, 45, 371, DateTimeKind.Utc).AddTicks(8861), new DateTime(2022, 5, 26, 14, 52, 45, 371, DateTimeKind.Utc).AddTicks(8867), 1, "AQAAAAEAACcQAAAAELlU0VDMYvYku0RKPlx4A9THLHMmOe0K0HD55LGrOgiWOrhb2GrawnesHL8DyJAEiw==", new DateTime(2022, 5, 26, 14, 52, 45, 371, DateTimeKind.Utc).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3363"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "9f6a2046-6b99-4015-b7a6-6745e71cb306", new DateTime(2022, 5, 26, 14, 52, 45, 377, DateTimeKind.Utc).AddTicks(8467), new DateTime(2022, 5, 26, 14, 52, 45, 377, DateTimeKind.Utc).AddTicks(8474), 1, "AQAAAAEAACcQAAAAELY97chavy/U3gn53un2d9E5dTjniyh0G7cr6H6ohTldE8PSeZgBxp9RhEEW8p5GqA==", new DateTime(2022, 5, 26, 14, 52, 45, 377, DateTimeKind.Utc).AddTicks(8472) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3364"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "1f09dcb7-3097-4fa2-a7c3-fca96e73cb46", new DateTime(2022, 5, 26, 14, 52, 45, 383, DateTimeKind.Utc).AddTicks(7620), new DateTime(2022, 5, 26, 14, 52, 45, 383, DateTimeKind.Utc).AddTicks(7627), 1, "AQAAAAEAACcQAAAAEFde5q808PIFCau+ihHzCgQx8TPvOGDIiHB+sD8SetcPMb1RezNm2KILznefLlR5fA==", new DateTime(2022, 5, 26, 14, 52, 45, 383, DateTimeKind.Utc).AddTicks(7626) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3365"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "802ce38c-b285-4575-bec7-b81ba29c1fb5", new DateTime(2022, 5, 26, 14, 52, 45, 389, DateTimeKind.Utc).AddTicks(7507), new DateTime(2022, 5, 26, 14, 52, 45, 389, DateTimeKind.Utc).AddTicks(7513), 1, "AQAAAAEAACcQAAAAEIVHm1hxu+lqmVD1P7cCjnv2qe4OlQPjlzFGPC5cYrbwKlS+sJQxzZseA//ZbakLug==", new DateTime(2022, 5, 26, 14, 52, 45, 389, DateTimeKind.Utc).AddTicks(7511) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3366"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "71a3da7b-63e7-4999-9f03-ce3059298ae6", new DateTime(2022, 5, 26, 14, 52, 45, 395, DateTimeKind.Utc).AddTicks(6782), new DateTime(2022, 5, 26, 14, 52, 45, 395, DateTimeKind.Utc).AddTicks(6789), 1, "AQAAAAEAACcQAAAAEB3d8tvx4+UghaURojUSbDPEjWBmdkG8RBJfZGZjVLKhfJ12T/ScNJw9O+iTojOCig==", new DateTime(2022, 5, 26, 14, 52, 45, 395, DateTimeKind.Utc).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3367"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "b6318b35-3032-4d38-beb3-e7ac1c498390", new DateTime(2022, 5, 26, 14, 52, 45, 401, DateTimeKind.Utc).AddTicks(6712), new DateTime(2022, 5, 26, 14, 52, 45, 401, DateTimeKind.Utc).AddTicks(6720), 1, "AQAAAAEAACcQAAAAEKSb3vR34WC4xSM7ZVSUtchUf0q+JRiKzYaIdvheRh1xAajrVzEBy4FwyowQXB6aEQ==", new DateTime(2022, 5, 26, 14, 52, 45, 401, DateTimeKind.Utc).AddTicks(6718) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3368"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "555c7f68-20f5-4772-8fe7-75f3b55aff67", new DateTime(2022, 5, 26, 14, 52, 45, 411, DateTimeKind.Utc).AddTicks(3981), new DateTime(2022, 5, 26, 14, 52, 45, 411, DateTimeKind.Utc).AddTicks(3996), 1, "AQAAAAEAACcQAAAAEBEae2aj8+EvZR9J/LXzcNdIA8OpoYilSIIL7hRW51KG3X648ADTmesKHDJQqkZyuQ==", new DateTime(2022, 5, 26, 14, 52, 45, 411, DateTimeKind.Utc).AddTicks(3989) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3369"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "58075d37-e9c4-4dd4-a912-def1daf0a4c8", new DateTime(2022, 5, 26, 14, 52, 45, 419, DateTimeKind.Utc).AddTicks(653), new DateTime(2022, 5, 26, 14, 52, 45, 419, DateTimeKind.Utc).AddTicks(665), 1, "AQAAAAEAACcQAAAAEMYpJbfgjWZ5Ow+J1RhPEb+Xn1SshSNi08OYlA+jmL034NZ5rSqYSfmBx/eosl4O6w==", new DateTime(2022, 5, 26, 14, 52, 45, 419, DateTimeKind.Utc).AddTicks(660) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3370"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "6734b246-3161-40ef-aca2-2473c729e158", new DateTime(2022, 5, 26, 14, 52, 45, 425, DateTimeKind.Utc).AddTicks(2453), new DateTime(2022, 5, 26, 14, 52, 45, 425, DateTimeKind.Utc).AddTicks(2461), 1, "AQAAAAEAACcQAAAAECVn+i47/BDP1qG3D672ZvPp3N0upPoWc5YXf5VG03D/rzsJ/lQVDNcf89fr00z7Fw==", new DateTime(2022, 5, 26, 14, 52, 45, 425, DateTimeKind.Utc).AddTicks(2459) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3371"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "70c73eb0-e1d0-44f6-b22d-7dba3ab5f7eb", new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(2091), new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(2101), 1, "AQAAAAEAACcQAAAAEAYpBqCiyQGgq3G4MooR6myT1KuZYgZ/nMwCQ6pEiKnKdgDlfJWP0Qw6wrDb+cDAcA==", new DateTime(2022, 5, 26, 14, 52, 45, 433, DateTimeKind.Utc).AddTicks(2098) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Dentists",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(623), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(625), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(624) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(861), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(863), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(862) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(880), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(881), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(971), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(973), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(972) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(990), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(991), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1013), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1014), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1013) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1028), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1029), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1028) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1043), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1044), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1043) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1057), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1059), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1073), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1075), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1074) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1088), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1090), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1089) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1103), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1105), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1104) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1159), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1161), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1160) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1175), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1177), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1176) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1190), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1192), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1191) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1205), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1206), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1205) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1219), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1221), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1220) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1236), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1237), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1237) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1250), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1252), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1252) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1266), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1267), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1266) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1280), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1282), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1281) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1335), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1337), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1336) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1351), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1353), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1352) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1365), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1367), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1366) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1380), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1382), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1381) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1395), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1397), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1410), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1412), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1411) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1425), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1426), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1425) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1439), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1441), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1454), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1455), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1455) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1508), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1510), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1509) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1524), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1526), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1525) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1539), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1541), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1556), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1557), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1570), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1572), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1571) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1585), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1587), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1586) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1600), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1602), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1615), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1616), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1629), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1630), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1730), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1732), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1745), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1747), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1760), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1761), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1774), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1776), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1775) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1789), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1791), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1790) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1804), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1806), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1805) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1819), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1821), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1820) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1834), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1836), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1835) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1849), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1851), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1904), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1906), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1921), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1923), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1922) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1936), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1937), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1950), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1952), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1951) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1965), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1967), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1966) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1980), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1981), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1994), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1996), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(1995) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2009), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2011), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2010) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2023), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2025), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2024) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2083), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2086), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2085) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2128), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2130), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2129) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2154), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2156), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2155) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2171), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2173), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2187), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2189), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2188) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2203), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2205), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2219), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2221), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2235), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2237), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2236) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2298), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2301), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2300) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2316), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2318), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2317) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2331), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2332), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2332) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2345), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2347), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2346) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2360), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2362), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2375), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2376), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2375) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2389), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2391), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2390) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2404), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2406), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2405) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2418), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2420), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2419) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2433), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2434), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2434) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2490), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2492), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2491) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2504), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2506), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2519), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2521), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2520) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2533), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2535), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2534) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2548), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2550), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2563), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2564), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2577), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2579), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2578) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2592), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2594), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2606), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2608), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2607) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2663), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2665), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2664) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2678), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2680), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2679) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2693), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2694), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2707), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2709), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2708) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2722), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2723), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2723) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2736), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2738), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2737) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2751), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2752), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2752) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2765), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2767), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2766) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2780), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2781), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2837), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2839), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2838) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2852), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2853), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2852) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2866), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2868), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2881), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2883), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2895), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2897), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2896) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2910), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2912), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2925), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2926), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2939), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2941), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2954), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2956), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(2955) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3009), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3010), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3009) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3024), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3026), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3025) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3039), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3041), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3040) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3054), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3056), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3055) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3069), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3071), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3070) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3084), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3086), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3085) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3099), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3101), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3100) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3114), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3116), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3115) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3128), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3130), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3129) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3202), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3204), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3218), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3220), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3219) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3233), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3235), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3234) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3248), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3249), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3249) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3262), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3264), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3263) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3277), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3278), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3277) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3291), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3293), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3292) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3306), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3307), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3320), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3322), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3321) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3335), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3336), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3335) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3391), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3393), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3392) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3405), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3407), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3420), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3422), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3421) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3434), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3436), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3435) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3449), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3451), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3450) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3464), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3466), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3465) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3478), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3480), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3479) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3493), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3495), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3494) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3552), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3554), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3567), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3569), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3568) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3582), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3584), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3583) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3598), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3599), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3598) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3612), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3614), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3627), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3629), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3628) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3643), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3644), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3643) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3657), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3659), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3658) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3714), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3716), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3715) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3729), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3731), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3730) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3744), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3746), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3745) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3759), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3760), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3759) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3774), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3776), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3775) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3789), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3791), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3790) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3803), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3805), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3804) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3818), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3820), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3819) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3832), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3834), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3833) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3888), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3890), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3889) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3903), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3905), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3904) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3918), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3920), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3919) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3933), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3934), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3933) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3947), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3949), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3948) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3962), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3963), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3963) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3976), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3978), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(3977) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 681, DateTimeKind.Utc).AddTicks(1328), new DateTime(2022, 5, 23, 17, 25, 22, 681, DateTimeKind.Utc).AddTicks(1326), new DateTime(2022, 5, 23, 17, 25, 22, 681, DateTimeKind.Utc).AddTicks(1330), new DateTime(2022, 5, 23, 17, 25, 22, 681, DateTimeKind.Utc).AddTicks(1329) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 689, DateTimeKind.Utc).AddTicks(3018), new DateTime(2022, 5, 23, 17, 25, 22, 689, DateTimeKind.Utc).AddTicks(3017), new DateTime(2022, 5, 23, 17, 25, 22, 689, DateTimeKind.Utc).AddTicks(3020), new DateTime(2022, 5, 23, 17, 25, 22, 689, DateTimeKind.Utc).AddTicks(3019) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 699, DateTimeKind.Utc).AddTicks(6021), new DateTime(2022, 5, 23, 17, 25, 22, 699, DateTimeKind.Utc).AddTicks(6019), new DateTime(2022, 5, 23, 17, 25, 22, 699, DateTimeKind.Utc).AddTicks(6022), new DateTime(2022, 5, 23, 17, 25, 22, 699, DateTimeKind.Utc).AddTicks(6021) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 707, DateTimeKind.Utc).AddTicks(7428), new DateTime(2022, 5, 23, 17, 25, 22, 707, DateTimeKind.Utc).AddTicks(7426), new DateTime(2022, 5, 23, 17, 25, 22, 707, DateTimeKind.Utc).AddTicks(7430), new DateTime(2022, 5, 23, 17, 25, 22, 707, DateTimeKind.Utc).AddTicks(7429) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 717, DateTimeKind.Utc).AddTicks(7787), new DateTime(2022, 5, 23, 17, 25, 22, 717, DateTimeKind.Utc).AddTicks(7785), new DateTime(2022, 5, 23, 17, 25, 22, 717, DateTimeKind.Utc).AddTicks(7789), new DateTime(2022, 5, 23, 17, 25, 22, 717, DateTimeKind.Utc).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 725, DateTimeKind.Utc).AddTicks(9426), new DateTime(2022, 5, 23, 17, 25, 22, 725, DateTimeKind.Utc).AddTicks(9423), new DateTime(2022, 5, 23, 17, 25, 22, 725, DateTimeKind.Utc).AddTicks(9427), new DateTime(2022, 5, 23, 17, 25, 22, 725, DateTimeKind.Utc).AddTicks(9426) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 734, DateTimeKind.Utc).AddTicks(257), new DateTime(2022, 5, 23, 17, 25, 22, 734, DateTimeKind.Utc).AddTicks(255), new DateTime(2022, 5, 23, 17, 25, 22, 734, DateTimeKind.Utc).AddTicks(259), new DateTime(2022, 5, 23, 17, 25, 22, 734, DateTimeKind.Utc).AddTicks(258) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 742, DateTimeKind.Utc).AddTicks(2479), new DateTime(2022, 5, 23, 17, 25, 22, 742, DateTimeKind.Utc).AddTicks(2476), new DateTime(2022, 5, 23, 17, 25, 22, 742, DateTimeKind.Utc).AddTicks(2481), new DateTime(2022, 5, 23, 17, 25, 22, 742, DateTimeKind.Utc).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 750, DateTimeKind.Utc).AddTicks(3974), new DateTime(2022, 5, 23, 17, 25, 22, 750, DateTimeKind.Utc).AddTicks(3972), new DateTime(2022, 5, 23, 17, 25, 22, 750, DateTimeKind.Utc).AddTicks(3976), new DateTime(2022, 5, 23, 17, 25, 22, 750, DateTimeKind.Utc).AddTicks(3975) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 758, DateTimeKind.Utc).AddTicks(6462), new DateTime(2022, 5, 23, 17, 25, 22, 758, DateTimeKind.Utc).AddTicks(6460), new DateTime(2022, 5, 23, 17, 25, 22, 758, DateTimeKind.Utc).AddTicks(6464), new DateTime(2022, 5, 23, 17, 25, 22, 758, DateTimeKind.Utc).AddTicks(6463) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 766, DateTimeKind.Utc).AddTicks(7511), new DateTime(2022, 5, 23, 17, 25, 22, 766, DateTimeKind.Utc).AddTicks(7508), new DateTime(2022, 5, 23, 17, 25, 22, 766, DateTimeKind.Utc).AddTicks(7512), new DateTime(2022, 5, 23, 17, 25, 22, 766, DateTimeKind.Utc).AddTicks(7511) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 774, DateTimeKind.Utc).AddTicks(9086), new DateTime(2022, 5, 23, 17, 25, 22, 774, DateTimeKind.Utc).AddTicks(9085), new DateTime(2022, 5, 23, 17, 25, 22, 774, DateTimeKind.Utc).AddTicks(9088), new DateTime(2022, 5, 23, 17, 25, 22, 774, DateTimeKind.Utc).AddTicks(9087) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 782, DateTimeKind.Utc).AddTicks(9864), new DateTime(2022, 5, 23, 17, 25, 22, 782, DateTimeKind.Utc).AddTicks(9863), new DateTime(2022, 5, 23, 17, 25, 22, 782, DateTimeKind.Utc).AddTicks(9866), new DateTime(2022, 5, 23, 17, 25, 22, 782, DateTimeKind.Utc).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 791, DateTimeKind.Utc).AddTicks(1317), new DateTime(2022, 5, 23, 17, 25, 22, 791, DateTimeKind.Utc).AddTicks(1315), new DateTime(2022, 5, 23, 17, 25, 22, 791, DateTimeKind.Utc).AddTicks(1319), new DateTime(2022, 5, 23, 17, 25, 22, 791, DateTimeKind.Utc).AddTicks(1318) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 799, DateTimeKind.Utc).AddTicks(2048), new DateTime(2022, 5, 23, 17, 25, 22, 799, DateTimeKind.Utc).AddTicks(2046), new DateTime(2022, 5, 23, 17, 25, 22, 799, DateTimeKind.Utc).AddTicks(2050), new DateTime(2022, 5, 23, 17, 25, 22, 799, DateTimeKind.Utc).AddTicks(2049) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 807, DateTimeKind.Utc).AddTicks(3528), new DateTime(2022, 5, 23, 17, 25, 22, 807, DateTimeKind.Utc).AddTicks(3527), new DateTime(2022, 5, 23, 17, 25, 22, 807, DateTimeKind.Utc).AddTicks(3530), new DateTime(2022, 5, 23, 17, 25, 22, 807, DateTimeKind.Utc).AddTicks(3529) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 815, DateTimeKind.Utc).AddTicks(4647), new DateTime(2022, 5, 23, 17, 25, 22, 815, DateTimeKind.Utc).AddTicks(4646), new DateTime(2022, 5, 23, 17, 25, 22, 815, DateTimeKind.Utc).AddTicks(4649), new DateTime(2022, 5, 23, 17, 25, 22, 815, DateTimeKind.Utc).AddTicks(4648) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 826, DateTimeKind.Utc).AddTicks(9124), new DateTime(2022, 5, 23, 17, 25, 22, 826, DateTimeKind.Utc).AddTicks(9122), new DateTime(2022, 5, 23, 17, 25, 22, 826, DateTimeKind.Utc).AddTicks(9126), new DateTime(2022, 5, 23, 17, 25, 22, 826, DateTimeKind.Utc).AddTicks(9125) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 835, DateTimeKind.Utc).AddTicks(1969), new DateTime(2022, 5, 23, 17, 25, 22, 835, DateTimeKind.Utc).AddTicks(1966), new DateTime(2022, 5, 23, 17, 25, 22, 835, DateTimeKind.Utc).AddTicks(1971), new DateTime(2022, 5, 23, 17, 25, 22, 835, DateTimeKind.Utc).AddTicks(1970) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 843, DateTimeKind.Utc).AddTicks(3541), new DateTime(2022, 5, 23, 17, 25, 22, 843, DateTimeKind.Utc).AddTicks(3539), new DateTime(2022, 5, 23, 17, 25, 22, 843, DateTimeKind.Utc).AddTicks(3543), new DateTime(2022, 5, 23, 17, 25, 22, 843, DateTimeKind.Utc).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 851, DateTimeKind.Utc).AddTicks(5853), new DateTime(2022, 5, 23, 17, 25, 22, 851, DateTimeKind.Utc).AddTicks(5851), new DateTime(2022, 5, 23, 17, 25, 22, 851, DateTimeKind.Utc).AddTicks(5855), new DateTime(2022, 5, 23, 17, 25, 22, 851, DateTimeKind.Utc).AddTicks(5854) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 859, DateTimeKind.Utc).AddTicks(7081), new DateTime(2022, 5, 23, 17, 25, 22, 859, DateTimeKind.Utc).AddTicks(7079), new DateTime(2022, 5, 23, 17, 25, 22, 859, DateTimeKind.Utc).AddTicks(7083), new DateTime(2022, 5, 23, 17, 25, 22, 859, DateTimeKind.Utc).AddTicks(7082) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 868, DateTimeKind.Utc).AddTicks(1827), new DateTime(2022, 5, 23, 17, 25, 22, 868, DateTimeKind.Utc).AddTicks(1824), new DateTime(2022, 5, 23, 17, 25, 22, 868, DateTimeKind.Utc).AddTicks(1830), new DateTime(2022, 5, 23, 17, 25, 22, 868, DateTimeKind.Utc).AddTicks(1828) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 877, DateTimeKind.Utc).AddTicks(6027), new DateTime(2022, 5, 23, 17, 25, 22, 877, DateTimeKind.Utc).AddTicks(6021), new DateTime(2022, 5, 23, 17, 25, 22, 877, DateTimeKind.Utc).AddTicks(6029), new DateTime(2022, 5, 23, 17, 25, 22, 877, DateTimeKind.Utc).AddTicks(6028) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 886, DateTimeKind.Utc).AddTicks(5678), new DateTime(2022, 5, 23, 17, 25, 22, 886, DateTimeKind.Utc).AddTicks(5675), new DateTime(2022, 5, 23, 17, 25, 22, 886, DateTimeKind.Utc).AddTicks(5680), new DateTime(2022, 5, 23, 17, 25, 22, 886, DateTimeKind.Utc).AddTicks(5679) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 898, DateTimeKind.Utc).AddTicks(9803), new DateTime(2022, 5, 23, 17, 25, 22, 898, DateTimeKind.Utc).AddTicks(9790), new DateTime(2022, 5, 23, 17, 25, 22, 898, DateTimeKind.Utc).AddTicks(9805), new DateTime(2022, 5, 23, 17, 25, 22, 898, DateTimeKind.Utc).AddTicks(9804) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 907, DateTimeKind.Utc).AddTicks(9997), new DateTime(2022, 5, 23, 17, 25, 22, 907, DateTimeKind.Utc).AddTicks(9993), new DateTime(2022, 5, 23, 17, 25, 22, 907, DateTimeKind.Utc).AddTicks(9999), new DateTime(2022, 5, 23, 17, 25, 22, 907, DateTimeKind.Utc).AddTicks(9998) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 917, DateTimeKind.Utc).AddTicks(2288), new DateTime(2022, 5, 23, 17, 25, 22, 917, DateTimeKind.Utc).AddTicks(2286), new DateTime(2022, 5, 23, 17, 25, 22, 917, DateTimeKind.Utc).AddTicks(2290), new DateTime(2022, 5, 23, 17, 25, 22, 917, DateTimeKind.Utc).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 925, DateTimeKind.Utc).AddTicks(6035), new DateTime(2022, 5, 23, 17, 25, 22, 925, DateTimeKind.Utc).AddTicks(6034), new DateTime(2022, 5, 23, 17, 25, 22, 925, DateTimeKind.Utc).AddTicks(6037), new DateTime(2022, 5, 23, 17, 25, 22, 925, DateTimeKind.Utc).AddTicks(6036) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 934, DateTimeKind.Utc).AddTicks(2008), new DateTime(2022, 5, 23, 17, 25, 22, 934, DateTimeKind.Utc).AddTicks(2005), new DateTime(2022, 5, 23, 17, 25, 22, 934, DateTimeKind.Utc).AddTicks(2010), new DateTime(2022, 5, 23, 17, 25, 22, 934, DateTimeKind.Utc).AddTicks(2009) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 942, DateTimeKind.Utc).AddTicks(4502), new DateTime(2022, 5, 23, 17, 25, 22, 942, DateTimeKind.Utc).AddTicks(4500), new DateTime(2022, 5, 23, 17, 25, 22, 942, DateTimeKind.Utc).AddTicks(4504), new DateTime(2022, 5, 23, 17, 25, 22, 942, DateTimeKind.Utc).AddTicks(4503) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 952, DateTimeKind.Utc).AddTicks(7004), new DateTime(2022, 5, 23, 17, 25, 22, 952, DateTimeKind.Utc).AddTicks(7001), new DateTime(2022, 5, 23, 17, 25, 22, 952, DateTimeKind.Utc).AddTicks(7006), new DateTime(2022, 5, 23, 17, 25, 22, 952, DateTimeKind.Utc).AddTicks(7005) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 961, DateTimeKind.Utc).AddTicks(3798), new DateTime(2022, 5, 23, 17, 25, 22, 961, DateTimeKind.Utc).AddTicks(3797), new DateTime(2022, 5, 23, 17, 25, 22, 961, DateTimeKind.Utc).AddTicks(3800), new DateTime(2022, 5, 23, 17, 25, 22, 961, DateTimeKind.Utc).AddTicks(3799) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 971, DateTimeKind.Utc).AddTicks(2064), new DateTime(2022, 5, 23, 17, 25, 22, 971, DateTimeKind.Utc).AddTicks(2062), new DateTime(2022, 5, 23, 17, 25, 22, 971, DateTimeKind.Utc).AddTicks(2065), new DateTime(2022, 5, 23, 17, 25, 22, 971, DateTimeKind.Utc).AddTicks(2064) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 979, DateTimeKind.Utc).AddTicks(5001), new DateTime(2022, 5, 23, 17, 25, 22, 979, DateTimeKind.Utc).AddTicks(5000), new DateTime(2022, 5, 23, 17, 25, 22, 979, DateTimeKind.Utc).AddTicks(5003), new DateTime(2022, 5, 23, 17, 25, 22, 979, DateTimeKind.Utc).AddTicks(5002) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 987, DateTimeKind.Utc).AddTicks(7167), new DateTime(2022, 5, 23, 17, 25, 22, 987, DateTimeKind.Utc).AddTicks(7166), new DateTime(2022, 5, 23, 17, 25, 22, 987, DateTimeKind.Utc).AddTicks(7169), new DateTime(2022, 5, 23, 17, 25, 22, 987, DateTimeKind.Utc).AddTicks(7168) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 22, 996, DateTimeKind.Utc).AddTicks(100), new DateTime(2022, 5, 23, 17, 25, 22, 996, DateTimeKind.Utc).AddTicks(99), new DateTime(2022, 5, 23, 17, 25, 22, 996, DateTimeKind.Utc).AddTicks(102), new DateTime(2022, 5, 23, 17, 25, 22, 996, DateTimeKind.Utc).AddTicks(101) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 4, DateTimeKind.Utc).AddTicks(2478), new DateTime(2022, 5, 23, 17, 25, 23, 4, DateTimeKind.Utc).AddTicks(2477), new DateTime(2022, 5, 23, 17, 25, 23, 4, DateTimeKind.Utc).AddTicks(2480), new DateTime(2022, 5, 23, 17, 25, 23, 4, DateTimeKind.Utc).AddTicks(2479) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 14, DateTimeKind.Utc).AddTicks(7495), new DateTime(2022, 5, 23, 17, 25, 23, 14, DateTimeKind.Utc).AddTicks(7494), new DateTime(2022, 5, 23, 17, 25, 23, 14, DateTimeKind.Utc).AddTicks(7498), new DateTime(2022, 5, 23, 17, 25, 23, 14, DateTimeKind.Utc).AddTicks(7497) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 27, DateTimeKind.Utc).AddTicks(1981), new DateTime(2022, 5, 23, 17, 25, 23, 27, DateTimeKind.Utc).AddTicks(1979), new DateTime(2022, 5, 23, 17, 25, 23, 27, DateTimeKind.Utc).AddTicks(1982), new DateTime(2022, 5, 23, 17, 25, 23, 27, DateTimeKind.Utc).AddTicks(1981) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 35, DateTimeKind.Utc).AddTicks(2873), new DateTime(2022, 5, 23, 17, 25, 23, 35, DateTimeKind.Utc).AddTicks(2872), new DateTime(2022, 5, 23, 17, 25, 23, 35, DateTimeKind.Utc).AddTicks(2875), new DateTime(2022, 5, 23, 17, 25, 23, 35, DateTimeKind.Utc).AddTicks(2874) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 43, DateTimeKind.Utc).AddTicks(5601), new DateTime(2022, 5, 23, 17, 25, 23, 43, DateTimeKind.Utc).AddTicks(5600), new DateTime(2022, 5, 23, 17, 25, 23, 43, DateTimeKind.Utc).AddTicks(5603), new DateTime(2022, 5, 23, 17, 25, 23, 43, DateTimeKind.Utc).AddTicks(5602) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 51, DateTimeKind.Utc).AddTicks(7504), new DateTime(2022, 5, 23, 17, 25, 23, 51, DateTimeKind.Utc).AddTicks(7503), new DateTime(2022, 5, 23, 17, 25, 23, 51, DateTimeKind.Utc).AddTicks(7506), new DateTime(2022, 5, 23, 17, 25, 23, 51, DateTimeKind.Utc).AddTicks(7505) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 61, DateTimeKind.Utc).AddTicks(1618), new DateTime(2022, 5, 23, 17, 25, 23, 61, DateTimeKind.Utc).AddTicks(1617), new DateTime(2022, 5, 23, 17, 25, 23, 61, DateTimeKind.Utc).AddTicks(1620), new DateTime(2022, 5, 23, 17, 25, 23, 61, DateTimeKind.Utc).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 73, DateTimeKind.Utc).AddTicks(4421), new DateTime(2022, 5, 23, 17, 25, 23, 73, DateTimeKind.Utc).AddTicks(4417), new DateTime(2022, 5, 23, 17, 25, 23, 73, DateTimeKind.Utc).AddTicks(4423), new DateTime(2022, 5, 23, 17, 25, 23, 73, DateTimeKind.Utc).AddTicks(4422) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 85, DateTimeKind.Utc).AddTicks(775), new DateTime(2022, 5, 23, 17, 25, 23, 85, DateTimeKind.Utc).AddTicks(774), new DateTime(2022, 5, 23, 17, 25, 23, 85, DateTimeKind.Utc).AddTicks(777), new DateTime(2022, 5, 23, 17, 25, 23, 85, DateTimeKind.Utc).AddTicks(776) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 93, DateTimeKind.Utc).AddTicks(2909), new DateTime(2022, 5, 23, 17, 25, 23, 93, DateTimeKind.Utc).AddTicks(2908), new DateTime(2022, 5, 23, 17, 25, 23, 93, DateTimeKind.Utc).AddTicks(2911), new DateTime(2022, 5, 23, 17, 25, 23, 93, DateTimeKind.Utc).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 101, DateTimeKind.Utc).AddTicks(2701), new DateTime(2022, 5, 23, 17, 25, 23, 101, DateTimeKind.Utc).AddTicks(2699), new DateTime(2022, 5, 23, 17, 25, 23, 101, DateTimeKind.Utc).AddTicks(2703), new DateTime(2022, 5, 23, 17, 25, 23, 101, DateTimeKind.Utc).AddTicks(2702) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 109, DateTimeKind.Utc).AddTicks(4827), new DateTime(2022, 5, 23, 17, 25, 23, 109, DateTimeKind.Utc).AddTicks(4826), new DateTime(2022, 5, 23, 17, 25, 23, 109, DateTimeKind.Utc).AddTicks(4829), new DateTime(2022, 5, 23, 17, 25, 23, 109, DateTimeKind.Utc).AddTicks(4828) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 117, DateTimeKind.Utc).AddTicks(6030), new DateTime(2022, 5, 23, 17, 25, 23, 117, DateTimeKind.Utc).AddTicks(6028), new DateTime(2022, 5, 23, 17, 25, 23, 117, DateTimeKind.Utc).AddTicks(6032), new DateTime(2022, 5, 23, 17, 25, 23, 117, DateTimeKind.Utc).AddTicks(6031) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 125, DateTimeKind.Utc).AddTicks(8276), new DateTime(2022, 5, 23, 17, 25, 23, 125, DateTimeKind.Utc).AddTicks(8274), new DateTime(2022, 5, 23, 17, 25, 23, 125, DateTimeKind.Utc).AddTicks(8277), new DateTime(2022, 5, 23, 17, 25, 23, 125, DateTimeKind.Utc).AddTicks(8276) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(569), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(568), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(571), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(570) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7299), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7301), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7408), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7411), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7410) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7524), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7526), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7525) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7550), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7552), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7551) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7577), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7579), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7578) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e20"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "3049c494-335e-44e4-bab2-7754551b7691", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7752), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7755), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e21"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "07e2d6c4-7920-4c5d-85ec-b7cf5df8d6e1", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7878), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7881), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7880) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e22"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "db8105ba-261c-4504-b5f3-3a19dab84b25", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7914), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7916), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7915) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e23"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "ef3dbc44-8cba-4ecd-a39a-7bf6fc75a88f", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8022), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8025), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8024) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e24"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "74cfc5ec-5566-4214-9ec1-99fbd5a54c94", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8060), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8063), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8061) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e25"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "c1ed8e1f-f501-4625-a55e-a8dc9229ce44", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8094), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8097), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8095) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e26"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "4b362a3a-d142-48e4-b8bc-f0eac6d35e11", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8125), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8128), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8126) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e27"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "251920b7-2b1b-41c6-b50f-177544d71c37", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8168), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8170), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8169) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e28"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "4e1af9fd-9bce-468b-b4df-d420fed7121e", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8200), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8202), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8201) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e29"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "b22fccc1-b783-4f82-8f2d-19bbeacde95c", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8283), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8286), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8285) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e30"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "6d47d378-bf8d-4c4f-83d3-772e74f64b00", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8316), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8318), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8317) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e31"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "1325afbd-fa24-4094-bf99-47220c2ea5d5", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8347), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8349), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8348) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e32"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "5ae145dc-acde-4c91-b355-dac206fa34ed", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8379), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8381), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8380) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e33"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "ea6c508f-8930-49be-a16d-8125e9216a02", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8411), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8413), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8412) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e34"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "600b146c-0c83-40d0-b59c-b09e9a9232db", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8483), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8486), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8484) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e35"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "987b26ef-ddfc-41ba-bdc0-21ec2582fc0f", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8522), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8524), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8523) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e36"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "7de349a2-fc8c-417b-8be3-e94b9810b400", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8554), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8556), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8555) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e37"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "b7e4064f-3889-42eb-887a-f41d9920c0c8", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8587), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8590), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8588) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e38"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "23e6729e-d7e9-48da-8636-9d7e3329edfc", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8617), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8620), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8619) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e39"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "2bf356b4-b458-4c2a-b0e9-25f97bb91a13", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8648), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8651), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8649) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e40"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "43809381-8f22-4eaa-a217-4bc813ad8e7b", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8725), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8727), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e41"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "180b28d2-406d-41c2-9892-c53400481e1d", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8757), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8760), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8758) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e42"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "7c00d890-6b5d-4c1e-a957-993f9b56d4fc", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8788), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8790), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e43"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "e34b74f4-6adb-4884-b87c-0977d7afb498", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8822), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8824), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8823) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e44"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "26d575c5-616d-4c90-b569-8b3aca8b62cd", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8853), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8856), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e45"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "0e62f9e2-43af-4473-b6a6-fd564935e7c4", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8946), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8948), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8947) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e46"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "117da0be-e2a3-4cdd-b1f8-6ec9a1c57a8a", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8982), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8984), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(8983) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e47"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "5596f8d3-157d-476c-b66c-24ef610ae86b", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9013), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9016), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9014) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e48"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "c36b915d-d671-4844-b587-c59a7900b1db", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9043), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9046), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e49"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "848e56f8-8cdc-46f5-ae93-38950e844738", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9074), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9077), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9076) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e50"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "77ef4879-b64d-4f78-b94c-f35d9bb79118", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9105), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9108), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e51"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "7bab95ff-6f4b-4905-bb9b-d48d9498b186", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9220), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9222), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9221) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e52"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "c8f8a6fd-adea-4c6c-89ef-65d2e44e8cfe", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9257), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9260), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9259) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e53"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "c34a974b-5fcb-450e-81c5-3aafc7117a3f", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9290), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9293), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9292) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e54"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "6f5c8125-1a51-4a38-bc79-a2f670af0dbe", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9321), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9323), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9322) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e55"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "9bdd51cf-7485-4d7d-89fa-2ae5477394d4", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9352), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9354), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9353) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e56"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "e1e84c1b-a9dc-4b25-8990-3913f0a19498", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9425), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9428), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9427) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e57"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "adb0ec6e-dd2f-4842-967b-4ac7f4543785", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9460), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9463), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9462) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e58"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "679095a5-6802-4ebd-9487-af568e2a6b1e", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9492), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9494), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9493) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e59"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "77321877-40f8-493b-a485-0885c2a44d8c", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9525), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9528), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9527) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e60"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "f6f2dcf3-9a0a-4817-9633-67c4306e6e24", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9556), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9559), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9558) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e61"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "95395fc5-7418-47c7-aee9-6d8b32619802", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9586), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9589), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e62"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "3852ee2f-cab4-497f-a948-a6f533fa5d79", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9678), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9681), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e63"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "3530a6c2-19eb-4429-a697-06b5dc35a2be", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9713), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9716), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9715) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e64"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "dd557d63-6b25-4259-aeb0-9fa643606f88", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9745), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9747), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e65"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "6c8907d5-f69e-4c81-b3dc-08fc8402dd6d", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9775), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9778), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9777) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e66"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "6201ef42-64dc-4d09-a86c-0419a10be1bd", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9806), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9808), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9807) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e67"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "79b48f78-f62d-45a1-9f12-bce0a2e02040", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9839), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9842), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9841) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e68"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "7350d7d6-6dc7-43b6-a635-b3b344e6545f", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9916), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9919), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9917) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e69"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "02efd86b-1d00-4f16-9402-1d7321902714", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9947), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9950), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9948) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e70"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "Updated_at" },
                values: new object[] { "5cbf19e6-7c6f-42d3-ad5b-3f6adc1a6dbf", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9978), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9980), "Male", new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(9979) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Deleted_at", "EndDate", "StartDate", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 24, 0, 25, 22, 667, DateTimeKind.Local).AddTicks(5535), new DateTime(2022, 5, 24, 0, 25, 22, 667, DateTimeKind.Local).AddTicks(5538), new DateTime(2022, 5, 24, 0, 25, 22, 667, DateTimeKind.Local).AddTicks(5516), new DateTime(2022, 5, 24, 0, 25, 22, 666, DateTimeKind.Local).AddTicks(6055), new DateTime(2022, 5, 24, 0, 25, 22, 667, DateTimeKind.Local).AddTicks(5537) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "Deleted_at", "EndDate", "StartDate", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7053), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7055), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7050), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7042), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "Deleted_at", "EndDate", "StartDate", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7197), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7199), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7195), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7193), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7198) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "Deleted_at", "EndDate", "StartDate", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7228), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7230), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7226), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7225), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7229) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_at", "Deleted_at", "EndDate", "StartDate", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7255), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7258), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7254), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7253), new DateTime(2022, 5, 24, 0, 25, 22, 668, DateTimeKind.Local).AddTicks(7256) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "4a97a616-41aa-4bf9-af86-35ae6b69e376");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"),
                column: "ConcurrencyStamp",
                value: "3c97b51c-8963-4cf7-97ea-abfac5f743fe");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 24, 0, 25, 22, 669, DateTimeKind.Local).AddTicks(20), new DateTime(2022, 5, 24, 0, 25, 22, 669, DateTimeKind.Local).AddTicks(23), new DateTime(2022, 5, 24, 0, 25, 22, 669, DateTimeKind.Local).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 24, 0, 25, 22, 669, DateTimeKind.Local).AddTicks(132), new DateTime(2022, 5, 24, 0, 25, 22, 669, DateTimeKind.Local).AddTicks(135), new DateTime(2022, 5, 24, 0, 25, 22, 669, DateTimeKind.Local).AddTicks(134) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 24, 0, 25, 22, 669, DateTimeKind.Local).AddTicks(162), new DateTime(2022, 5, 24, 0, 25, 22, 669, DateTimeKind.Local).AddTicks(165), new DateTime(2022, 5, 24, 0, 25, 22, 669, DateTimeKind.Local).AddTicks(164) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 24, 0, 25, 22, 669, DateTimeKind.Local).AddTicks(189), new DateTime(2022, 5, 24, 0, 25, 22, 669, DateTimeKind.Local).AddTicks(191), new DateTime(2022, 5, 24, 0, 25, 22, 669, DateTimeKind.Local).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 24, 0, 25, 22, 669, DateTimeKind.Local).AddTicks(264), new DateTime(2022, 5, 24, 0, 25, 22, 669, DateTimeKind.Local).AddTicks(267), new DateTime(2022, 5, 24, 0, 25, 22, 669, DateTimeKind.Local).AddTicks(266) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2620"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "ae90ebc6-896e-4c7f-bd2c-9c86b41df8c9", new DateTime(2022, 5, 23, 17, 25, 22, 681, DateTimeKind.Utc).AddTicks(798), new DateTime(2022, 5, 23, 17, 25, 22, 681, DateTimeKind.Utc).AddTicks(807), "Male", "AQAAAAEAACcQAAAAEADVNF8QkQOV2xrxS5eBUIz1X0t9gYtnV+DyuqjTBEuoFvCE8CLq+kqIjwXOZ4gh1g==", new DateTime(2022, 5, 23, 17, 25, 22, 681, DateTimeKind.Utc).AddTicks(806) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2621"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "ff371aeb-954b-4c36-8e01-b63ec46b6ed5", new DateTime(2022, 5, 23, 17, 25, 22, 689, DateTimeKind.Utc).AddTicks(2923), new DateTime(2022, 5, 23, 17, 25, 22, 689, DateTimeKind.Utc).AddTicks(2927), "Male", "AQAAAAEAACcQAAAAEPClOeDaufWDb8C0RBN4dCJImJiJcXi4mOAvDb/zjUJcTZCmIhUcUuoXodBx4S3v+w==", new DateTime(2022, 5, 23, 17, 25, 22, 689, DateTimeKind.Utc).AddTicks(2926) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2622"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "577bbb12-0967-48b4-b4c8-e7bb4b4be666", new DateTime(2022, 5, 23, 17, 25, 22, 699, DateTimeKind.Utc).AddTicks(5625), new DateTime(2022, 5, 23, 17, 25, 22, 699, DateTimeKind.Utc).AddTicks(5633), "Male", "AQAAAAEAACcQAAAAECUmr7Lgd99Pc7nf/H4K5eHGURBUCBBtKxGA+BnxtzQeoWfnz+dPLhKNsFIBlzM78w==", new DateTime(2022, 5, 23, 17, 25, 22, 699, DateTimeKind.Utc).AddTicks(5632) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2623"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "ebbba89e-5736-4d0c-89e4-fba5ef486d0f", new DateTime(2022, 5, 23, 17, 25, 22, 707, DateTimeKind.Utc).AddTicks(7250), new DateTime(2022, 5, 23, 17, 25, 22, 707, DateTimeKind.Utc).AddTicks(7254), "Male", "AQAAAAEAACcQAAAAEFET2hkonIcJIgWdsomZmFKaPYc7n9JwURnbb/wI7cMY89XBmBoQoDMrnfXnOe/Ltw==", new DateTime(2022, 5, 23, 17, 25, 22, 707, DateTimeKind.Utc).AddTicks(7253) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2624"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "60a22d19-3ad3-49e7-b002-3779053d765e", new DateTime(2022, 5, 23, 17, 25, 22, 717, DateTimeKind.Utc).AddTicks(7453), new DateTime(2022, 5, 23, 17, 25, 22, 717, DateTimeKind.Utc).AddTicks(7468), "Male", "AQAAAAEAACcQAAAAEEybgL4m5DkjLjVi2oeOZ+y9gug9D0guyvW2SmOgKi1bx/iWhDMQZekYT4sGKh3yBA==", new DateTime(2022, 5, 23, 17, 25, 22, 717, DateTimeKind.Utc).AddTicks(7466) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2625"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "ec2e9401-5fa9-48f2-b2a8-c57961326e6a", new DateTime(2022, 5, 23, 17, 25, 22, 725, DateTimeKind.Utc).AddTicks(9249), new DateTime(2022, 5, 23, 17, 25, 22, 725, DateTimeKind.Utc).AddTicks(9253), "Male", "AQAAAAEAACcQAAAAEIk5++/E2+l9S+B86zRPUV1BgkHCXBQqWYHQ+aF0iNvkOkE3e9kF0vxC6t9rfUkriA==", new DateTime(2022, 5, 23, 17, 25, 22, 725, DateTimeKind.Utc).AddTicks(9252) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2626"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "6cfed006-eccf-4c8c-bded-ecdaae7e5e03", new DateTime(2022, 5, 23, 17, 25, 22, 734, DateTimeKind.Utc).AddTicks(129), new DateTime(2022, 5, 23, 17, 25, 22, 734, DateTimeKind.Utc).AddTicks(133), "Male", "AQAAAAEAACcQAAAAECQImd2RKK3UjRxX2/hoi2w72/94wApq7dfLegArofQsUOgWYVNc5IugZ/kgdVFecg==", new DateTime(2022, 5, 23, 17, 25, 22, 734, DateTimeKind.Utc).AddTicks(131) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2627"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "f36f9e95-bc12-45ea-af33-78952432a475", new DateTime(2022, 5, 23, 17, 25, 22, 742, DateTimeKind.Utc).AddTicks(2087), new DateTime(2022, 5, 23, 17, 25, 22, 742, DateTimeKind.Utc).AddTicks(2101), "Male", "AQAAAAEAACcQAAAAEPqLZ1oK2aA9mrfu+ketlZmYlBM0pHbDBho9LmibovleChlY0Jge/J84t/tMU7/J0A==", new DateTime(2022, 5, 23, 17, 25, 22, 742, DateTimeKind.Utc).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2628"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "0a242ad1-f142-4a42-9e09-681afee497b2", new DateTime(2022, 5, 23, 17, 25, 22, 750, DateTimeKind.Utc).AddTicks(3707), new DateTime(2022, 5, 23, 17, 25, 22, 750, DateTimeKind.Utc).AddTicks(3713), "Male", "AQAAAAEAACcQAAAAEEvoamSF6A3STceIfiZBSVuPHarU6KSp/4SnmOOC0ZOSNvMEVFUYd7I1D7fWc4lR7w==", new DateTime(2022, 5, 23, 17, 25, 22, 750, DateTimeKind.Utc).AddTicks(3712) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2629"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "f1c84885-98b5-469c-a09f-39427b8fe387", new DateTime(2022, 5, 23, 17, 25, 22, 758, DateTimeKind.Utc).AddTicks(6175), new DateTime(2022, 5, 23, 17, 25, 22, 758, DateTimeKind.Utc).AddTicks(6183), "Male", "AQAAAAEAACcQAAAAEFi/bLdIpU4ZVX6W7oKgNBtZ1H18Ldi5E0Dr29xmCsdV5ztzUpj/fmcq8hqf5MsqTg==", new DateTime(2022, 5, 23, 17, 25, 22, 758, DateTimeKind.Utc).AddTicks(6182) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2630"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "baa44255-f931-4b67-83d5-be41daa7d1a1", new DateTime(2022, 5, 23, 17, 25, 22, 766, DateTimeKind.Utc).AddTicks(7334), new DateTime(2022, 5, 23, 17, 25, 22, 766, DateTimeKind.Utc).AddTicks(7339), "Male", "AQAAAAEAACcQAAAAEKGnzoa7QgNt5gdMwNToV+rPk5aeIxFtRU3s/B3DC/x8EiUL8Nsp79v/nbkAo4SMRw==", new DateTime(2022, 5, 23, 17, 25, 22, 766, DateTimeKind.Utc).AddTicks(7338) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2631"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "527792c8-5b1e-431f-b927-390a1a68002a", new DateTime(2022, 5, 23, 17, 25, 22, 774, DateTimeKind.Utc).AddTicks(8790), new DateTime(2022, 5, 23, 17, 25, 22, 774, DateTimeKind.Utc).AddTicks(8800), "Male", "AQAAAAEAACcQAAAAEHjNS1+szVM3WZheJ69pYgewL4YS3P4+nDKM2iEy+yf16ZMaxuM40HLL+JtU7/M5SQ==", new DateTime(2022, 5, 23, 17, 25, 22, 774, DateTimeKind.Utc).AddTicks(8799) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2632"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "52afbf75-6022-4012-a07a-c113051b9b0f", new DateTime(2022, 5, 23, 17, 25, 22, 782, DateTimeKind.Utc).AddTicks(9790), new DateTime(2022, 5, 23, 17, 25, 22, 782, DateTimeKind.Utc).AddTicks(9792), "Male", "AQAAAAEAACcQAAAAEOwY1dR+9lNMJp/0LSkQpJHdR1OplgGf7giO8atisjAx2JH1170AdZ+XZYWRO0+iKQ==", new DateTime(2022, 5, 23, 17, 25, 22, 782, DateTimeKind.Utc).AddTicks(9792) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2633"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "0c2482aa-642d-483d-8bbe-23d763d07598", new DateTime(2022, 5, 23, 17, 25, 22, 791, DateTimeKind.Utc).AddTicks(1040), new DateTime(2022, 5, 23, 17, 25, 22, 791, DateTimeKind.Utc).AddTicks(1045), "Male", "AQAAAAEAACcQAAAAEF2D53pqGW0E9WOAmMu46io1QpG7Hw9JTvbXTTZdW8ykel26rCSWO36SupfxBV7fVA==", new DateTime(2022, 5, 23, 17, 25, 22, 791, DateTimeKind.Utc).AddTicks(1044) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2634"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "99b14d0c-ddce-44e8-81bb-6e98e87a74b0", new DateTime(2022, 5, 23, 17, 25, 22, 799, DateTimeKind.Utc).AddTicks(1964), new DateTime(2022, 5, 23, 17, 25, 22, 799, DateTimeKind.Utc).AddTicks(1966), "Male", "AQAAAAEAACcQAAAAEM4SXP/TfUQCZuWr7YfKmuXr05+PHjm/A441c58YWvOiZNFHII7BlDAW5xwHv+u0lA==", new DateTime(2022, 5, 23, 17, 25, 22, 799, DateTimeKind.Utc).AddTicks(1966) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2635"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "9d425a7e-eba6-4e0d-b05e-9468f79ebfec", new DateTime(2022, 5, 23, 17, 25, 22, 807, DateTimeKind.Utc).AddTicks(3235), new DateTime(2022, 5, 23, 17, 25, 22, 807, DateTimeKind.Utc).AddTicks(3243), "Male", "AQAAAAEAACcQAAAAEAQNNb1hyRGUy6oUHwRE9JDDogjnSYg7M+uYO1jjyso7v8Uy3oWCDXBwQafeYgL5Zg==", new DateTime(2022, 5, 23, 17, 25, 22, 807, DateTimeKind.Utc).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2636"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "20033495-a9b9-4207-9631-f8b436453768", new DateTime(2022, 5, 23, 17, 25, 22, 815, DateTimeKind.Utc).AddTicks(4427), new DateTime(2022, 5, 23, 17, 25, 22, 815, DateTimeKind.Utc).AddTicks(4433), "Male", "AQAAAAEAACcQAAAAENJvrm07V9eTrN3rtetOp82WvXwgznG9Z9l3eDg/yvU1i4+pF/kAghlgdm4nug+IZw==", new DateTime(2022, 5, 23, 17, 25, 22, 815, DateTimeKind.Utc).AddTicks(4432) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2637"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "a727fe08-01d8-4769-aa28-bd4d15c1f3a1", new DateTime(2022, 5, 23, 17, 25, 22, 826, DateTimeKind.Utc).AddTicks(8835), new DateTime(2022, 5, 23, 17, 25, 22, 826, DateTimeKind.Utc).AddTicks(8843), "Male", "AQAAAAEAACcQAAAAEIh57tsEjaHagAWNVaF/ISpKicK+NlbKgmpAdNuMkHeLH4Qk+t9qp9Am624vps9vdg==", new DateTime(2022, 5, 23, 17, 25, 22, 826, DateTimeKind.Utc).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2638"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "e3107863-48a2-46b7-89fa-3128c78fc8aa", new DateTime(2022, 5, 23, 17, 25, 22, 835, DateTimeKind.Utc).AddTicks(1501), new DateTime(2022, 5, 23, 17, 25, 22, 835, DateTimeKind.Utc).AddTicks(1513), "Male", "AQAAAAEAACcQAAAAEKfuZDP2CDRBaW4QszQnq9AHFFuHZuAcPrCkSDJZ+fcvCLV3o7652oeNcZ7btyzARg==", new DateTime(2022, 5, 23, 17, 25, 22, 835, DateTimeKind.Utc).AddTicks(1512) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2639"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "dfc8267e-9bb9-42fb-a795-523d204b3368", new DateTime(2022, 5, 23, 17, 25, 22, 843, DateTimeKind.Utc).AddTicks(3305), new DateTime(2022, 5, 23, 17, 25, 22, 843, DateTimeKind.Utc).AddTicks(3311), "Male", "AQAAAAEAACcQAAAAEIH/pPBwmQoy8XEWWa8kyyzNiUoGEBPlnxrgl33P5a9cI18r+LG36ewJ4nO1FUe4Tw==", new DateTime(2022, 5, 23, 17, 25, 22, 843, DateTimeKind.Utc).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2640"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "832c6afa-744f-4734-a6f3-38af08bd5785", new DateTime(2022, 5, 23, 17, 25, 22, 851, DateTimeKind.Utc).AddTicks(5476), new DateTime(2022, 5, 23, 17, 25, 22, 851, DateTimeKind.Utc).AddTicks(5487), "Male", "AQAAAAEAACcQAAAAENsGKVpdBT/BDqdm/RWbwQwXje++bD8MwOmpcXSQKehmztLmLjBZlm4Hdm1sfQ5eOw==", new DateTime(2022, 5, 23, 17, 25, 22, 851, DateTimeKind.Utc).AddTicks(5486) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2641"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "f786aaa5-34fd-4318-b777-edded69180db", new DateTime(2022, 5, 23, 17, 25, 22, 859, DateTimeKind.Utc).AddTicks(6851), new DateTime(2022, 5, 23, 17, 25, 22, 859, DateTimeKind.Utc).AddTicks(6862), "Male", "AQAAAAEAACcQAAAAEPgGmd2hPFKICykusJcybzsaHzW9jZKQ8KLfiyMbB78apArix03vqD0Pg/iuUhI2oA==", new DateTime(2022, 5, 23, 17, 25, 22, 859, DateTimeKind.Utc).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2642"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "94e579b3-9c02-439a-ae20-006bcd32cb81", new DateTime(2022, 5, 23, 17, 25, 22, 868, DateTimeKind.Utc).AddTicks(1376), new DateTime(2022, 5, 23, 17, 25, 22, 868, DateTimeKind.Utc).AddTicks(1388), "Male", "AQAAAAEAACcQAAAAEIQZZvHvzhdJvx58YvpKxNGdvEaMd/fHgq//h8TYUGUP5dHQr8NUz3oD9PHjz3xJ0g==", new DateTime(2022, 5, 23, 17, 25, 22, 868, DateTimeKind.Utc).AddTicks(1387) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2643"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "63e48c6c-be48-4ed9-ad94-57699c3b49c4", new DateTime(2022, 5, 23, 17, 25, 22, 877, DateTimeKind.Utc).AddTicks(5186), new DateTime(2022, 5, 23, 17, 25, 22, 877, DateTimeKind.Utc).AddTicks(5199), "Male", "AQAAAAEAACcQAAAAEMlITgTI6RxZbMwC8boQiFkdfMCb4NfCjdv7E5B1V0aartDppIu5ZgVXHLRWKjzXCw==", new DateTime(2022, 5, 23, 17, 25, 22, 877, DateTimeKind.Utc).AddTicks(5198) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2644"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "894913b5-db2b-4c32-89ce-467026a27c19", new DateTime(2022, 5, 23, 17, 25, 22, 886, DateTimeKind.Utc).AddTicks(4908), new DateTime(2022, 5, 23, 17, 25, 22, 886, DateTimeKind.Utc).AddTicks(4917), "Male", "AQAAAAEAACcQAAAAEJFbKAEwDWfHTHkop4nRcx7qqC0HxgcnqE5VUqftelsN4dEonSwF/UMnu8oBaJWR6w==", new DateTime(2022, 5, 23, 17, 25, 22, 886, DateTimeKind.Utc).AddTicks(4916) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2645"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "406271a4-2165-46fd-9f46-cfd24b6a34a1", new DateTime(2022, 5, 23, 17, 25, 22, 898, DateTimeKind.Utc).AddTicks(7867), new DateTime(2022, 5, 23, 17, 25, 22, 898, DateTimeKind.Utc).AddTicks(7934), "Male", "AQAAAAEAACcQAAAAEEvI6l7H2vHu+HGaQNOo6OvA24wnDZc2ke25buyklHzuyShAToiMdqkyX/aqrGJ7rg==", new DateTime(2022, 5, 23, 17, 25, 22, 898, DateTimeKind.Utc).AddTicks(7932) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2646"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "0318532a-024f-4e8e-8df8-50ad8d0f0fb8", new DateTime(2022, 5, 23, 17, 25, 22, 907, DateTimeKind.Utc).AddTicks(9192), new DateTime(2022, 5, 23, 17, 25, 22, 907, DateTimeKind.Utc).AddTicks(9204), "Male", "AQAAAAEAACcQAAAAEIsEhBWu4viRcjukQ0PB3RQ9k4sBc2HcPxn39RoVfUiArCchsnuBxGb1MERjP7qYww==", new DateTime(2022, 5, 23, 17, 25, 22, 907, DateTimeKind.Utc).AddTicks(9203) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2647"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "a4392dcc-3b6f-4334-abb3-b3fda5421a48", new DateTime(2022, 5, 23, 17, 25, 22, 917, DateTimeKind.Utc).AddTicks(1893), new DateTime(2022, 5, 23, 17, 25, 22, 917, DateTimeKind.Utc).AddTicks(1902), "Male", "AQAAAAEAACcQAAAAEMFe7bQsgaiAsPSfMUvHYXlH5dXRYppPV3eCfIs3Tpp9bXux5wmK6QE+QU/GrEg1Dg==", new DateTime(2022, 5, 23, 17, 25, 22, 917, DateTimeKind.Utc).AddTicks(1901) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2648"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "071005ba-4f65-4374-b4f4-8348bc01d5fb", new DateTime(2022, 5, 23, 17, 25, 22, 925, DateTimeKind.Utc).AddTicks(5567), new DateTime(2022, 5, 23, 17, 25, 22, 925, DateTimeKind.Utc).AddTicks(5578), "Male", "AQAAAAEAACcQAAAAEP8DWkttjgSumAxKXZRKoiHC9KH51vuMmM2Pog2R12iqA4JBKkimj3cUi3rPqi7Kcw==", new DateTime(2022, 5, 23, 17, 25, 22, 925, DateTimeKind.Utc).AddTicks(5576) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2649"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "115bcb47-a8b6-4cb2-97e8-a4f3ccbf1f1f", new DateTime(2022, 5, 23, 17, 25, 22, 934, DateTimeKind.Utc).AddTicks(1603), new DateTime(2022, 5, 23, 17, 25, 22, 934, DateTimeKind.Utc).AddTicks(1613), "Male", "AQAAAAEAACcQAAAAEMBsGDfyF7cIVoo2PQFV9+ZMoXlSVvNBykh/ipqlUD5yne00dQ+7t6DCDMBv/qzutQ==", new DateTime(2022, 5, 23, 17, 25, 22, 934, DateTimeKind.Utc).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2650"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "10934b76-cc9f-41bf-bc2e-5582a2af99b1", new DateTime(2022, 5, 23, 17, 25, 22, 942, DateTimeKind.Utc).AddTicks(4040), new DateTime(2022, 5, 23, 17, 25, 22, 942, DateTimeKind.Utc).AddTicks(4048), "Male", "AQAAAAEAACcQAAAAENkxsmOasbdmFcLX9YtAwcwxmPEIzMee7S34HQPaNXiAparWmST8e314hajsv2ijjw==", new DateTime(2022, 5, 23, 17, 25, 22, 942, DateTimeKind.Utc).AddTicks(4047) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "67d5b52c-7637-40ea-bba4-38974244ff18", new DateTime(2022, 5, 23, 17, 25, 22, 952, DateTimeKind.Utc).AddTicks(6414), new DateTime(2022, 5, 23, 17, 25, 22, 952, DateTimeKind.Utc).AddTicks(6424), "Male", "AQAAAAEAACcQAAAAEPP+wmIExAlmb4z7kTZg1FR5TJ+Ebez1H7BSMSlB7341sHdbiR1aY8i5o5c/XvNwTw==", new DateTime(2022, 5, 23, 17, 25, 22, 952, DateTimeKind.Utc).AddTicks(6423) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "da786457-fb04-4e2b-adf9-cbf918ee6037", new DateTime(2022, 5, 23, 17, 25, 22, 961, DateTimeKind.Utc).AddTicks(3502), new DateTime(2022, 5, 23, 17, 25, 22, 961, DateTimeKind.Utc).AddTicks(3530), "Male", "AQAAAAEAACcQAAAAEHZ/5Hv1uHoK4zR+jW7V9TYEbI4B56DoAfXtG7c5ZyWTJqLqV6WCaFauBDUmEYUkuQ==", new DateTime(2022, 5, 23, 17, 25, 22, 961, DateTimeKind.Utc).AddTicks(3529) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "b6fe887b-cfa5-4441-97e5-b95bcd7f759f", new DateTime(2022, 5, 23, 17, 25, 22, 971, DateTimeKind.Utc).AddTicks(1756), new DateTime(2022, 5, 23, 17, 25, 22, 971, DateTimeKind.Utc).AddTicks(1767), "Male", "AQAAAAEAACcQAAAAEAD/V08fsuHHUxH4s3LBbHgSAU5/PD/oj6hJ6Ca7N4EZB1uK/96fyFmPtmX5TCxpjw==", new DateTime(2022, 5, 23, 17, 25, 22, 971, DateTimeKind.Utc).AddTicks(1766) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "c93a59b4-3e39-400c-9115-7ec5ea5ab86a", new DateTime(2022, 5, 23, 17, 25, 22, 979, DateTimeKind.Utc).AddTicks(4706), new DateTime(2022, 5, 23, 17, 25, 22, 979, DateTimeKind.Utc).AddTicks(4717), "Male", "AQAAAAEAACcQAAAAEGjXasXWcx/EdccbxA7UvIOUlIgC++OWSD1J7c3ZkPxrSqwtyR45ssQYtSikMBWYfQ==", new DateTime(2022, 5, 23, 17, 25, 22, 979, DateTimeKind.Utc).AddTicks(4716) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "571a05a4-d528-4e2a-a119-60aa1dab6eed", new DateTime(2022, 5, 23, 17, 25, 22, 987, DateTimeKind.Utc).AddTicks(6970), new DateTime(2022, 5, 23, 17, 25, 22, 987, DateTimeKind.Utc).AddTicks(6974), "Male", "AQAAAAEAACcQAAAAEIfBGL+8w745cN/kVjOumt7/lbQOdtINX35LinbvTi53NihkGBtz6k5Uw+mvK6Srkw==", new DateTime(2022, 5, 23, 17, 25, 22, 987, DateTimeKind.Utc).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "2243e68c-3729-4b69-acd7-1b32a62cd894", new DateTime(2022, 5, 23, 17, 25, 22, 995, DateTimeKind.Utc).AddTicks(9852), new DateTime(2022, 5, 23, 17, 25, 22, 995, DateTimeKind.Utc).AddTicks(9861), "Male", "AQAAAAEAACcQAAAAEJ6FV3X1SNTmBXWZxrBnHPrmY2t9XTUcxMGIAxiurldxQb3vudeIUihso33mQt0B5Q==", new DateTime(2022, 5, 23, 17, 25, 22, 995, DateTimeKind.Utc).AddTicks(9860) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "24ccd668-c17b-45ac-b289-2edba01a2700", new DateTime(2022, 5, 23, 17, 25, 23, 4, DateTimeKind.Utc).AddTicks(2226), new DateTime(2022, 5, 23, 17, 25, 23, 4, DateTimeKind.Utc).AddTicks(2236), "Male", "AQAAAAEAACcQAAAAEDsDCIuJqzonZJW5v98JKiaw0ocjvckEgGMka0K1OEcEJyKIWUQEulCDNOxvE4iH2Q==", new DateTime(2022, 5, 23, 17, 25, 23, 4, DateTimeKind.Utc).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "f1f52185-3a95-432d-be49-b315f4b73d8e", new DateTime(2022, 5, 23, 17, 25, 23, 14, DateTimeKind.Utc).AddTicks(7206), new DateTime(2022, 5, 23, 17, 25, 23, 14, DateTimeKind.Utc).AddTicks(7216), "Male", "AQAAAAEAACcQAAAAECtI1hMPG2W0yBZ15CTrL1nvJB3/tynBYw1Kb82SvhT2Rl8evx3aAWpMP1/a9I9yQQ==", new DateTime(2022, 5, 23, 17, 25, 23, 14, DateTimeKind.Utc).AddTicks(7215) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "a36f6a70-f8c7-491c-8caa-ec639c6f56d8", new DateTime(2022, 5, 23, 17, 25, 23, 27, DateTimeKind.Utc).AddTicks(1630), new DateTime(2022, 5, 23, 17, 25, 23, 27, DateTimeKind.Utc).AddTicks(1640), "Male", "AQAAAAEAACcQAAAAEBVf0hb1QfjSs3qIOX7bitKG1R0YajeEzUwnMuR24iNow0oFarRQC4/wgzEyP5fFIQ==", new DateTime(2022, 5, 23, 17, 25, 23, 27, DateTimeKind.Utc).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "708f2c16-8d85-4901-9b9c-8d773fdadd30", new DateTime(2022, 5, 23, 17, 25, 23, 35, DateTimeKind.Utc).AddTicks(2802), new DateTime(2022, 5, 23, 17, 25, 23, 35, DateTimeKind.Utc).AddTicks(2805), "Male", "AQAAAAEAACcQAAAAEF7nzS7yNqz/8CnQZZwbLw0D4UZLcKKEW9Ks05ZjzKgtUmKGryfQPHtMOSBL4pyEIQ==", new DateTime(2022, 5, 23, 17, 25, 23, 35, DateTimeKind.Utc).AddTicks(2804) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3361"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "94338251-84fc-45d2-863e-4e810bb9de1f", new DateTime(2022, 5, 23, 17, 25, 23, 43, DateTimeKind.Utc).AddTicks(5394), new DateTime(2022, 5, 23, 17, 25, 23, 43, DateTimeKind.Utc).AddTicks(5403), "Male", "AQAAAAEAACcQAAAAEEOzPsrZMkkHoTXHwaMWWl+K5YGv/3MRVOzoaWH+Yg2zGjHCcJhsgYGYQn+Ov6utug==", new DateTime(2022, 5, 23, 17, 25, 23, 43, DateTimeKind.Utc).AddTicks(5402) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3362"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "db848a33-b75e-4796-84ac-752595265136", new DateTime(2022, 5, 23, 17, 25, 23, 51, DateTimeKind.Utc).AddTicks(7418), new DateTime(2022, 5, 23, 17, 25, 23, 51, DateTimeKind.Utc).AddTicks(7421), "Male", "AQAAAAEAACcQAAAAEM6prN5tXy1FxZ9KeYyArb6StU0dHRvcxCC6+DUFn39Ca9LMeCLMu05pj17yT65kLA==", new DateTime(2022, 5, 23, 17, 25, 23, 51, DateTimeKind.Utc).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3363"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "96966c0e-b23e-43e1-9bea-719120524e41", new DateTime(2022, 5, 23, 17, 25, 23, 61, DateTimeKind.Utc).AddTicks(1345), new DateTime(2022, 5, 23, 17, 25, 23, 61, DateTimeKind.Utc).AddTicks(1357), "Male", "AQAAAAEAACcQAAAAEPfJ5ChTMrpQeLNxvLYtw3mKbQ1nItv1VUicpXWs4fT81PrW2blSaHYfrgRFLnJFEg==", new DateTime(2022, 5, 23, 17, 25, 23, 61, DateTimeKind.Utc).AddTicks(1355) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3364"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "2f405302-aa46-4c5b-a141-38d85e1546da", new DateTime(2022, 5, 23, 17, 25, 23, 73, DateTimeKind.Utc).AddTicks(3952), new DateTime(2022, 5, 23, 17, 25, 23, 73, DateTimeKind.Utc).AddTicks(3967), "Male", "AQAAAAEAACcQAAAAEHXj41/tCcYBF51i+q/L10va12WiSSPojtvTZcJWxsgQWQdXlibkyIeK1rUBZjHH2A==", new DateTime(2022, 5, 23, 17, 25, 23, 73, DateTimeKind.Utc).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3365"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "8faf7696-3cd4-4a78-8beb-a7c5d59aa356", new DateTime(2022, 5, 23, 17, 25, 23, 85, DateTimeKind.Utc).AddTicks(519), new DateTime(2022, 5, 23, 17, 25, 23, 85, DateTimeKind.Utc).AddTicks(534), "Male", "AQAAAAEAACcQAAAAEJAZddToQMB1IVjXNoXCrbPcHxnY+Eqy6t5BSMJ8OOofT01xieOFefwXoq46lkVE3g==", new DateTime(2022, 5, 23, 17, 25, 23, 85, DateTimeKind.Utc).AddTicks(533) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3366"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "be6e6d62-246e-4bfb-b385-128cf57a963b", new DateTime(2022, 5, 23, 17, 25, 23, 93, DateTimeKind.Utc).AddTicks(2685), new DateTime(2022, 5, 23, 17, 25, 23, 93, DateTimeKind.Utc).AddTicks(2696), "Male", "AQAAAAEAACcQAAAAECCMdpVdQi9hAPoef4sKvBgcL/thbRxh/l+ZZ4HbUbGq4AIZE4crhsc/f3JQ4o3zXQ==", new DateTime(2022, 5, 23, 17, 25, 23, 93, DateTimeKind.Utc).AddTicks(2695) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3367"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "f69e3cd4-4134-4e95-a9f0-a4b6c1fb05d1", new DateTime(2022, 5, 23, 17, 25, 23, 101, DateTimeKind.Utc).AddTicks(2540), new DateTime(2022, 5, 23, 17, 25, 23, 101, DateTimeKind.Utc).AddTicks(2543), "Male", "AQAAAAEAACcQAAAAEHnhcSrdpzL5K0Cruahi7VXJbZjZ3PkqFjG8LZyWx4XdE8F/QxAUEPg/yISdsIJn4g==", new DateTime(2022, 5, 23, 17, 25, 23, 101, DateTimeKind.Utc).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3368"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "65e43db9-6051-4bbd-a827-501fb20518a1", new DateTime(2022, 5, 23, 17, 25, 23, 109, DateTimeKind.Utc).AddTicks(4581), new DateTime(2022, 5, 23, 17, 25, 23, 109, DateTimeKind.Utc).AddTicks(4590), "Male", "AQAAAAEAACcQAAAAEOQEY38Ah3XjHYe7k8ZrWz2NO1Ion6GkeiMnos69IqjB/uMC6XCWrlesuZ96vC+16Q==", new DateTime(2022, 5, 23, 17, 25, 23, 109, DateTimeKind.Utc).AddTicks(4589) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3369"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "bc0ecec9-44db-4cf8-bdca-adf22759ddb4", new DateTime(2022, 5, 23, 17, 25, 23, 117, DateTimeKind.Utc).AddTicks(5906), new DateTime(2022, 5, 23, 17, 25, 23, 117, DateTimeKind.Utc).AddTicks(5910), "Male", "AQAAAAEAACcQAAAAEGmD8GHCAm6fMnSHCNjzjFjMSnqUMrcJEhm30OdLe3VnrPQVNyR01tm4kg73VlCM2Q==", new DateTime(2022, 5, 23, 17, 25, 23, 117, DateTimeKind.Utc).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3370"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "f25be910-cb01-4d8e-8441-6df1b4fd0bb5", new DateTime(2022, 5, 23, 17, 25, 23, 125, DateTimeKind.Utc).AddTicks(7989), new DateTime(2022, 5, 23, 17, 25, 23, 125, DateTimeKind.Utc).AddTicks(7999), "Male", "AQAAAAEAACcQAAAAEIJLwzRMxBA0hOtUY0RuoagHDloWSNgdTqH/rCljcini6vGIkVtJ4VP6wRASUtmTtw==", new DateTime(2022, 5, 23, 17, 25, 23, 125, DateTimeKind.Utc).AddTicks(7997) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3371"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Gender", "PasswordHash", "Updated_at" },
                values: new object[] { "2e3f0b7a-e09b-4040-b0c5-a84c6aefd2e9", new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(360), new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(369), "Male", "AQAAAAEAACcQAAAAEKYBegieXbM5JKN7j5z2F5HBVde7dVXS66YCQ9gHKN++qYlaAGffVyHipPMZkH61TA==", new DateTime(2022, 5, 23, 17, 25, 23, 134, DateTimeKind.Utc).AddTicks(368) });
        }
    }
}
