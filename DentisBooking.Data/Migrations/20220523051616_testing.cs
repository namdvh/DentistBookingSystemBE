using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DentisBooking.Data.Migrations
{
    public partial class testing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clinic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Phone = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created_by = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Deleted_by = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Updated_by = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinic", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Discount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Percent = table.Column<float>(type: "real", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ApplyForAll = table.Column<bool>(type: "bit", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created_by = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Deleted_by = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Updated_by = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discount", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created_by = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Deleted_by = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Updated_by = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dentist",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created_by = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Deleted_by = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Updated_by = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClinicId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dentist", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dentist_Clinic_ClinicId",
                        column: x => x.ClinicId,
                        principalTable: "Clinic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Procedure = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created_by = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Deleted_by = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Updated_by = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DiscountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Service_Discount_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "Discount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    KeyTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted_by = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Updated_by = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceDentists",
                columns: table => new
                {
                    DentistId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceDentists", x => new { x.ServiceId, x.DentistId });
                    table.ForeignKey(
                        name: "FK_ServiceDentists_Dentist_DentistId",
                        column: x => x.DentistId,
                        principalTable: "Dentist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceDentists_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Booking_Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Note = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created_by = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Deleted_by = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Updated_by = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookingId = table.Column<int>(type: "int", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Booking_Details_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Booking_Details_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_Details_BookingId",
                table: "Booking_Details",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_Details_ServiceId",
                table: "Booking_Details",
                column: "ServiceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_UserId",
                table: "Bookings",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dentist_ClinicId",
                table: "Dentist",
                column: "ClinicId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_DiscountId",
                table: "Service",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceDentists_DentistId",
                table: "ServiceDentists",
                column: "DentistId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Booking_Details");

            migrationBuilder.DropTable(
                name: "ServiceDentists");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Dentist");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Clinic");

            migrationBuilder.DropTable(
                name: "Discount");
        }
    }
}
