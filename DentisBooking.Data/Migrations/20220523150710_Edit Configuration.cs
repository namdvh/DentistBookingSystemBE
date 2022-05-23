using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DentisBooking.Data.Migrations
{
    public partial class EditConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Token",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("20efd516-f16c-41b3-b11d-bc908cd20565"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae26cf") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Created_by", "DOB", "Deleted_at", "Deleted_by", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "Status", "Token", "TwoFactorEnabled", "Updated_at", "Updated_by", "UserName" },
                values: new object[] { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae26cf"), 0, "0d3418e6-32af-4329-b926-7acc383573eb", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "doanvuhoainam15@gmail.com", true, "Toan", "male", "Bach", false, null, "doanvuhoainam15@gmail.com", "admin", "AQAAAAEAACcQAAAAEMq6w1UBTKOE2FoV8ks6QtenSp9W5RFesxvEMCo9lOppCqn/tgK4kAi/2xdpFSjILA==", null, false, 0, "", 0, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("20efd516-f16c-41b3-b11d-bc908cd20565"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae26cf") });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae26cf"));

            migrationBuilder.AlterColumn<string>(
                name: "Token",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
