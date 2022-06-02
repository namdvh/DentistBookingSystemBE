using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DentisBooking.Data.Migrations
{
    public partial class ver26 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clinics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Phone = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created_by = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted_by = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Updated_by = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
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
                    status = table.Column<int>(type: "int", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created_by = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted_by = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Updated_by = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Dentists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Position = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ClinicId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dentists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dentists_Clinics_ClinicId",
                        column: x => x.ClinicId,
                        principalTable: "Clinics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Procedure = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created_by = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted_by = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Updated_by = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DiscountId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_Discounts_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "Discounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created_by = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted_by = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Updated_by = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DentistId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Dentists_DentistId",
                        column: x => x.DentistId,
                        principalTable: "Dentists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServiceDentists",
                columns: table => new
                {
                    DentistId = table.Column<int>(type: "int", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceDentists", x => new { x.ServiceId, x.DentistId });
                    table.ForeignKey(
                        name: "FK_ServiceDentists_Dentists_DentistId",
                        column: x => x.DentistId,
                        principalTable: "Dentists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceDentists_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
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
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_by = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Updated_by = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                name: "Booking_Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeyTime = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created_by = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted_by = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Updated_by = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BookingId = table.Column<int>(type: "int", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    DentistId = table.Column<int>(type: "int", nullable: true)
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
                        name: "FK_Booking_Details_Dentists_DentistId",
                        column: x => x.DentistId,
                        principalTable: "Dentists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Booking_Details_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clinics",
                columns: new[] { "Id", "Address", "Created_at", "Created_by", "Deleted_at", "Deleted_by", "Description", "Name", "Phone", "Status", "Updated_at", "Updated_by" },
                values: new object[,]
                {
                    { 1, "TestAddress1", new DateTime(2022, 6, 2, 12, 52, 10, 43, DateTimeKind.Local).AddTicks(1701), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e51"), new DateTime(2022, 6, 2, 12, 52, 10, 43, DateTimeKind.Local).AddTicks(2661), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e51"), "TestDescirption1", "TestClinic1", 868644651, 0, new DateTime(2022, 6, 2, 12, 52, 10, 43, DateTimeKind.Local).AddTicks(2152), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e51") },
                    { 2, "TestAddress2", new DateTime(2022, 6, 2, 12, 52, 10, 43, DateTimeKind.Local).AddTicks(4807), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e52"), new DateTime(2022, 6, 2, 12, 52, 10, 43, DateTimeKind.Local).AddTicks(4817), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e52"), "TestDescirption2", "TestClinic2", 868644651, 0, new DateTime(2022, 6, 2, 12, 52, 10, 43, DateTimeKind.Local).AddTicks(4815), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e52") },
                    { 3, "TestAddress3", new DateTime(2022, 6, 2, 12, 52, 10, 43, DateTimeKind.Local).AddTicks(4871), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e53"), new DateTime(2022, 6, 2, 12, 52, 10, 43, DateTimeKind.Local).AddTicks(4875), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e53"), "TestDescirption3", "TestClinic3", 868644651, 0, new DateTime(2022, 6, 2, 12, 52, 10, 43, DateTimeKind.Local).AddTicks(4873), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e53") },
                    { 4, "TestAddress4", new DateTime(2022, 6, 2, 12, 52, 10, 43, DateTimeKind.Local).AddTicks(5033), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e54"), new DateTime(2022, 6, 2, 12, 52, 10, 43, DateTimeKind.Local).AddTicks(5038), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e54"), "TestDescirption4", "TestClinic4", 868644651, 0, new DateTime(2022, 6, 2, 12, 52, 10, 43, DateTimeKind.Local).AddTicks(5036), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e54") },
                    { 5, "TestAddress5", new DateTime(2022, 6, 2, 12, 52, 10, 43, DateTimeKind.Local).AddTicks(5089), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e55"), new DateTime(2022, 6, 2, 12, 52, 10, 43, DateTimeKind.Local).AddTicks(5093), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e55"), "TestDescirption5", "TestClinic5", 868644651, 0, new DateTime(2022, 6, 2, 12, 52, 10, 43, DateTimeKind.Local).AddTicks(5091), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e55") }
                });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "Amount", "ApplyForAll", "Created_at", "Created_by", "Deleted_at", "Deleted_by", "Description", "EndDate", "Percent", "StartDate", "Title", "Updated_at", "Updated_by", "status" },
                values: new object[,]
                {
                    { 4, 10m, true, new DateTime(2022, 6, 2, 12, 52, 10, 42, DateTimeKind.Local).AddTicks(8614), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e54"), new DateTime(2022, 6, 2, 12, 52, 10, 42, DateTimeKind.Local).AddTicks(8617), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e54"), "TestDescirption4", new DateTime(2022, 6, 2, 12, 52, 10, 42, DateTimeKind.Local).AddTicks(8611), 5f, new DateTime(2022, 6, 2, 12, 52, 10, 42, DateTimeKind.Local).AddTicks(8609), "TestTitle4", new DateTime(2022, 6, 2, 12, 52, 10, 42, DateTimeKind.Local).AddTicks(8615), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e54"), 0 },
                    { 3, 10m, true, new DateTime(2022, 6, 2, 12, 52, 10, 42, DateTimeKind.Local).AddTicks(8560), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e53"), new DateTime(2022, 6, 2, 12, 52, 10, 42, DateTimeKind.Local).AddTicks(8564), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e53"), "TestDescirption3", new DateTime(2022, 6, 2, 12, 52, 10, 42, DateTimeKind.Local).AddTicks(8557), 5f, new DateTime(2022, 6, 2, 12, 52, 10, 42, DateTimeKind.Local).AddTicks(8554), "TestTitle3", new DateTime(2022, 6, 2, 12, 52, 10, 42, DateTimeKind.Local).AddTicks(8562), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e53"), 0 },
                    { 5, 10m, true, new DateTime(2022, 6, 2, 12, 52, 10, 42, DateTimeKind.Local).AddTicks(8653), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e55"), new DateTime(2022, 6, 2, 12, 52, 10, 42, DateTimeKind.Local).AddTicks(8656), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e55"), "TestDescirption5", new DateTime(2022, 6, 2, 12, 52, 10, 42, DateTimeKind.Local).AddTicks(8651), 5f, new DateTime(2022, 6, 2, 12, 52, 10, 42, DateTimeKind.Local).AddTicks(8649), "TestTitle5", new DateTime(2022, 6, 2, 12, 52, 10, 42, DateTimeKind.Local).AddTicks(8655), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e55"), 0 },
                    { 1, 10m, true, new DateTime(2022, 6, 2, 12, 52, 10, 41, DateTimeKind.Local).AddTicks(1036), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e51"), new DateTime(2022, 6, 2, 12, 52, 10, 41, DateTimeKind.Local).AddTicks(2361), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e51"), "TestDescirption1", new DateTime(2022, 6, 2, 12, 52, 10, 40, DateTimeKind.Local).AddTicks(7396), 5f, new DateTime(2022, 6, 2, 12, 52, 10, 39, DateTimeKind.Local).AddTicks(9114), "TestTitle1", new DateTime(2022, 6, 2, 12, 52, 10, 41, DateTimeKind.Local).AddTicks(1466), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e51"), 0 },
                    { 2, 10m, true, new DateTime(2022, 6, 2, 12, 52, 10, 42, DateTimeKind.Local).AddTicks(8369), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e52"), new DateTime(2022, 6, 2, 12, 52, 10, 42, DateTimeKind.Local).AddTicks(8373), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e52"), "TestDescirption2", new DateTime(2022, 6, 2, 12, 52, 10, 42, DateTimeKind.Local).AddTicks(8356), 5f, new DateTime(2022, 6, 2, 12, 52, 10, 42, DateTimeKind.Local).AddTicks(8346), "TestTitle2", new DateTime(2022, 6, 2, 12, 52, 10, 42, DateTimeKind.Local).AddTicks(8371), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e52"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), "a8d6fb16-792e-42cd-b9c0-08bb6dd7f1b2", "Admin", "Admin", "ADMIN" },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"), "79f6e8f3-f1c8-4d6a-80cb-9f0da351d20f", "User", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2642") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2648") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2647") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2646") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2645") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2644") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2643") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2641") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2635") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2639") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2638") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2637") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2636") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2649") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2634") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2633") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2632") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2640") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2650") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3369") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3368") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3367") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3366") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3365") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3364") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3363") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3362") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3361") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2631") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2630") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2624") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2628") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2629") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2620") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2621") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2622") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3371") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3370") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2625") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2626") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2627") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2623") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Created_at", "Created_by", "DOB", "Deleted_at", "Deleted_by", "DentistId", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshTokenExpiryTime", "SecurityStamp", "Status", "Token", "TwoFactorEnabled", "Updated_at", "Updated_by", "UserName" },
                values: new object[,]
                {
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2632"), 0, "ba0b6c6e-6bd5-48fa-a8ff-0ce1120f5d28", new DateTime(2022, 6, 2, 5, 52, 10, 190, DateTimeKind.Utc).AddTicks(1578), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2632"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 190, DateTimeKind.Utc).AddTicks(1591), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2632"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEBkHZ/rYAc6AhEz/h3sNDlTkXFK6XEwJdWFJubkWLps04L10KyL8vQfPKr58xssv3Q==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 190, DateTimeKind.Utc).AddTicks(1587), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2632"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2631"), 0, "a5566086-0a5c-47ef-9f1e-178f06b0275f", new DateTime(2022, 6, 2, 5, 52, 10, 178, DateTimeKind.Utc).AddTicks(6551), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2631"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 178, DateTimeKind.Utc).AddTicks(6562), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2631"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEKehAAN4CsegTIAMyXU6x5doc4yxZIk/XEC8TSE0j4Cl+E3MKA57aniQ3utQ0bqArA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 178, DateTimeKind.Utc).AddTicks(6560), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2631"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2630"), 0, "6a7c75e1-8c18-483d-922f-f7a7fc488713", new DateTime(2022, 6, 2, 5, 52, 10, 166, DateTimeKind.Utc).AddTicks(4878), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2630"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 166, DateTimeKind.Utc).AddTicks(4887), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2630"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEFeZKW+5Jj5RxSHaKdQ7GY5jmtZCywWb45l6RsQv7gXb7I9FFmiAm9VKDikXn4WqIQ==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 166, DateTimeKind.Utc).AddTicks(4885), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2630"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2629"), 0, "9d395465-b8d5-485c-8c64-2f04613e19c2", new DateTime(2022, 6, 2, 5, 52, 10, 155, DateTimeKind.Utc).AddTicks(6118), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2629"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 155, DateTimeKind.Utc).AddTicks(6122), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2629"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAED/FuoZsToXu4gzGm8/UCp91wQP3E2iLq6W/mOKkIuBVhsfbRS/1LofgKhTWWWD05w==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 155, DateTimeKind.Utc).AddTicks(6120), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2629"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2628"), 0, "5c36c4ae-fb58-4cfb-86b5-163f287cf319", new DateTime(2022, 6, 2, 5, 52, 10, 145, DateTimeKind.Utc).AddTicks(949), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2628"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 145, DateTimeKind.Utc).AddTicks(960), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2628"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEIidZVnyjCzBDMVQgokjzXmxB8yGoK/MEm39wvArMnVaIuQMeM72jMLFYO9cii2U9w==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 145, DateTimeKind.Utc).AddTicks(958), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2628"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2626"), 0, "e6a99532-f82c-474c-8969-5a1ec2356a7c", new DateTime(2022, 6, 2, 5, 52, 10, 123, DateTimeKind.Utc).AddTicks(9792), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2626"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 123, DateTimeKind.Utc).AddTicks(9798), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2626"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEBZbeWFMrPdQa0Fsr3hx80V0KcfCPi0yEenEyXHrIa/LvCpoumWE/V8VJyqya9+9SQ==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 123, DateTimeKind.Utc).AddTicks(9796), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2626"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2625"), 0, "11f19064-2e29-4a21-8643-48d5c908f5d1", new DateTime(2022, 6, 2, 5, 52, 10, 113, DateTimeKind.Utc).AddTicks(4743), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2625"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 113, DateTimeKind.Utc).AddTicks(4750), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2625"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEKNGHDi/7yM1n8xZTTWTfMCNFJIWccEFBlPVvg0ugQx6kgVyivB2F8UumoAxvAb4LA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 113, DateTimeKind.Utc).AddTicks(4748), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2625"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2624"), 0, "f07fe0ad-780e-453c-96ba-a41923206239", new DateTime(2022, 6, 2, 5, 52, 10, 102, DateTimeKind.Utc).AddTicks(9683), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2624"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 102, DateTimeKind.Utc).AddTicks(9694), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2624"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAELRbJtA3Fpe/mkyZwN3buLCBMjh+vfxc2u/L8v9bRkhHSS31opxA+buIpvH0FRC10Q==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 102, DateTimeKind.Utc).AddTicks(9692), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2624"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2623"), 0, "b349c72f-4142-4037-88f4-4b948295d0d8", new DateTime(2022, 6, 2, 5, 52, 10, 92, DateTimeKind.Utc).AddTicks(3855), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2623"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 92, DateTimeKind.Utc).AddTicks(3860), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2623"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEJKEVWygNfHJqKafdPGTjVe7vMeuEaF4i2MDHhoG7l3fmSIIA4nw/wmPxrN/WV8BxA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 92, DateTimeKind.Utc).AddTicks(3857), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2623"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2622"), 0, "14a3cd45-4aa1-42cc-9369-ca16ee2bdf9b", new DateTime(2022, 6, 2, 5, 52, 10, 81, DateTimeKind.Utc).AddTicks(9068), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2622"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 81, DateTimeKind.Utc).AddTicks(9075), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2622"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAELu3btMNdR7bYBplfeIxnSjOfyDWyf5qolCaiQlg7hmL32P6H+TEjqplf1DMB3MFhw==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 81, DateTimeKind.Utc).AddTicks(9073), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2622"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2621"), 0, "2baa2532-5626-4ee8-af78-71c99366f007", new DateTime(2022, 6, 2, 5, 52, 10, 71, DateTimeKind.Utc).AddTicks(3368), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2621"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 71, DateTimeKind.Utc).AddTicks(3377), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2621"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEEywTfK4ZXcQLHKi3xmYFTZtR6xxWgynLe2tJBSuN8nnqBxO+sOMi0ZPcZoiXTfWtQ==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 71, DateTimeKind.Utc).AddTicks(3374), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2621"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2620"), 0, "272e63e0-f881-4174-afc0-c650ce9bb437", new DateTime(2022, 6, 2, 5, 52, 10, 59, DateTimeKind.Utc).AddTicks(7436), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2620"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 59, DateTimeKind.Utc).AddTicks(8454), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2620"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEChm66cGseuR/xp2gGoPfowfwn+eoei4dstqxWEYe/cZjwDQAPmRWowkZdTDgyKK8Q==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 59, DateTimeKind.Utc).AddTicks(7861), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2620"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2627"), 0, "a887651e-219d-4987-bd95-ec8f84047f9f", new DateTime(2022, 6, 2, 5, 52, 10, 134, DateTimeKind.Utc).AddTicks(5482), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2627"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 134, DateTimeKind.Utc).AddTicks(5487), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2627"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAECOptamMV76WMBF5HOKU8InTnrTTxZjBYOsn3E5BspX85sziU8or3eACD9b0BKDQNA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 134, DateTimeKind.Utc).AddTicks(5485), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2627"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2633"), 0, "e310ed4f-4f6b-46fd-8440-83fe787d1eae", new DateTime(2022, 6, 2, 5, 52, 10, 200, DateTimeKind.Utc).AddTicks(8821), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2633"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 200, DateTimeKind.Utc).AddTicks(8830), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2633"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEMB1+GS4wxnOgqtmjyb04oFPkO23IRNWg80ORWnVjvv8whAYubQJbaGS7emzH89smw==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 200, DateTimeKind.Utc).AddTicks(8827), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2633"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2636"), 0, "796ddef0-848d-4542-873f-27266915c792", new DateTime(2022, 6, 2, 5, 52, 10, 238, DateTimeKind.Utc).AddTicks(6990), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2636"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 238, DateTimeKind.Utc).AddTicks(7020), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2636"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAECEfJgKNkC8B4wsbUON8GQruHYxoDeRW0DXgTXW9QwSqaGI4J1CQ+qMSPVADYk+8QQ==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 238, DateTimeKind.Utc).AddTicks(7015), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2636"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2635"), 0, "705ab783-184d-4c55-8d44-8270a5a0a341", new DateTime(2022, 6, 2, 5, 52, 10, 227, DateTimeKind.Utc).AddTicks(9599), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2635"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 227, DateTimeKind.Utc).AddTicks(9617), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2635"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAELiEOYfqPAlQgAKL3bBt9hgzK6Nzevavoce1bR0uIh5ZlzCkwfSy2d8jDdYaM4MyNA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 227, DateTimeKind.Utc).AddTicks(9608), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2635"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2637"), 0, "74b3cd55-cccf-4846-9923-0de2b0b7c44d", new DateTime(2022, 6, 2, 5, 52, 10, 249, DateTimeKind.Utc).AddTicks(3070), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2637"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 249, DateTimeKind.Utc).AddTicks(3082), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2637"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEBUUn58/ckwY2bm6+deCXUTkHl6dSgScG21Gr5cuErRruS4lU5i53rQvywPhrbIHGw==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 249, DateTimeKind.Utc).AddTicks(3079), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2637"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2638"), 0, "dac1393d-f95f-48ff-8a57-9fc3ac5ea874", new DateTime(2022, 6, 2, 5, 52, 10, 259, DateTimeKind.Utc).AddTicks(8507), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2638"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 259, DateTimeKind.Utc).AddTicks(8514), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2638"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAENa7jU5960pznANvNxe0bP7HSerp7SJ25fG8OlmF0h2zg+XeD1NrWLlzNToXmfZzyw==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 259, DateTimeKind.Utc).AddTicks(8512), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2638"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2640"), 0, "cc5cab82-fa4b-4859-855f-c42eaddfc2d9", new DateTime(2022, 6, 2, 5, 52, 10, 281, DateTimeKind.Utc).AddTicks(7950), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2640"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 281, DateTimeKind.Utc).AddTicks(7960), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2640"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEOINwaw7Yo3F/7w5FDoWY5qDH4Et/1niFc7dfWxvWz09vaRcJcZ55UTTzx5rgOYBBg==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 281, DateTimeKind.Utc).AddTicks(7957), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2640"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2641"), 0, "e800a8d3-3bed-4af5-ac8b-65dcc86e9ec3", new DateTime(2022, 6, 2, 5, 52, 10, 294, DateTimeKind.Utc).AddTicks(2876), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2641"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 294, DateTimeKind.Utc).AddTicks(2889), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2641"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEFJfMwt5KZbm3DdU370A6f7EPgKiETSKbq1y2mX/q9hgNeO/IwT45nLe/2ZhpgY5Pg==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 294, DateTimeKind.Utc).AddTicks(2885), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2641"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Created_at", "Created_by", "DOB", "Deleted_at", "Deleted_by", "DentistId", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshTokenExpiryTime", "SecurityStamp", "Status", "Token", "TwoFactorEnabled", "Updated_at", "Updated_by", "UserName" },
                values: new object[,]
                {
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2642"), 0, "1cbeb61c-605e-47f0-ab27-0817ae9a2ead", new DateTime(2022, 6, 2, 5, 52, 10, 305, DateTimeKind.Utc).AddTicks(1205), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2642"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 305, DateTimeKind.Utc).AddTicks(1214), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2642"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAECkmQ+Bk1cCFmrMvlyIYu6SnE10VwNbC9mUFlQlIzeWcLaW+5qefCtPBDwrtf8rUGw==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 305, DateTimeKind.Utc).AddTicks(1212), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2642"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2643"), 0, "a7c89953-f3aa-4ddf-b470-1374467b4e26", new DateTime(2022, 6, 2, 5, 52, 10, 315, DateTimeKind.Utc).AddTicks(6965), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2643"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 315, DateTimeKind.Utc).AddTicks(6973), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2643"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEK4CxNsbstlcNlrQLOb9hrTZHmtEZkxYMj7legNcoXK3UwpraExd/Ds0CJns4B963A==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 315, DateTimeKind.Utc).AddTicks(6971), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2643"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2644"), 0, "7fb804db-6157-4455-879f-78226ca722af", new DateTime(2022, 6, 2, 5, 52, 10, 326, DateTimeKind.Utc).AddTicks(3119), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2644"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 326, DateTimeKind.Utc).AddTicks(3126), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2644"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAECc6Wvb8hp1RD0Q5TZzvg+VCknE2hvcukfl4vno9RXl/3n3LugqGB8wC5HP6OzsSTw==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 326, DateTimeKind.Utc).AddTicks(3124), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2644"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2645"), 0, "d1a4fe6e-323b-4a31-91a7-96e4277c6321", new DateTime(2022, 6, 2, 5, 52, 10, 336, DateTimeKind.Utc).AddTicks(7858), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2645"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 336, DateTimeKind.Utc).AddTicks(7861), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2645"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEFB+OA1XVNjv/f1qWi6yzB2cx92PzuAos/Z/jMiUIgqxMUKRYB04hNsFiybdskDpEw==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 336, DateTimeKind.Utc).AddTicks(7860), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2645"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2646"), 0, "5af743e8-dd26-4074-8c7b-bee852472bc9", new DateTime(2022, 6, 2, 5, 52, 10, 347, DateTimeKind.Utc).AddTicks(3121), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2646"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 347, DateTimeKind.Utc).AddTicks(3129), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2646"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEKQvslTZwW1iKMkVVBRYQUS7xzlRKE2JbJacwYsSwS/K4vzfYllSO2x7h4W7uS62QA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 347, DateTimeKind.Utc).AddTicks(3127), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2646"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2647"), 0, "f7457219-b40e-4400-ba19-61a0df47b8df", new DateTime(2022, 6, 2, 5, 52, 10, 357, DateTimeKind.Utc).AddTicks(8471), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2647"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 357, DateTimeKind.Utc).AddTicks(8478), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2647"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEP8bBJLODcKCKp+mYRwQL7UVoHYl1e1Z+41F9pee6u19wvJT0QxUo/f6MzWThoZbDw==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 357, DateTimeKind.Utc).AddTicks(8476), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2647"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2648"), 0, "bae3d9bf-05f0-494a-915d-73b552bbad41", new DateTime(2022, 6, 2, 5, 52, 10, 368, DateTimeKind.Utc).AddTicks(3570), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2648"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 368, DateTimeKind.Utc).AddTicks(3577), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2648"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAECbnxOEc6kzerEfa7KfCmdL2vMUV34C3d2cPDsZyjpfzW+5S9URlRy0DC/XdiKzv9A==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 368, DateTimeKind.Utc).AddTicks(3575), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2648"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2649"), 0, "eb0ee550-a2ec-4a27-bb7d-b37d77de8a1d", new DateTime(2022, 6, 2, 5, 52, 10, 378, DateTimeKind.Utc).AddTicks(8590), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2649"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 378, DateTimeKind.Utc).AddTicks(8596), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2649"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEPQ0B85HS/xDQKuC2QfZM/Zdl8ku/b6Dnqy5a0v9nBPXu8iAbv8mNGUq2RK57ggH2Q==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 378, DateTimeKind.Utc).AddTicks(8595), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2649"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2650"), 0, "c68e2285-708c-4122-b181-3194c3525081", new DateTime(2022, 6, 2, 5, 52, 10, 389, DateTimeKind.Utc).AddTicks(3893), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2650"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 389, DateTimeKind.Utc).AddTicks(3901), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2650"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEMShscj/qUoWalIf0tQZB63rudyumFZWlyynJirsQ8MlU3RMHcGhxPxlU7NsfJHsew==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 389, DateTimeKind.Utc).AddTicks(3899), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2650"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2634"), 0, "83e36711-932d-4bdf-8af8-a874ebe5f901", new DateTime(2022, 6, 2, 5, 52, 10, 216, DateTimeKind.Utc).AddTicks(8325), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2634"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 216, DateTimeKind.Utc).AddTicks(8341), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2634"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEAz50d1eLAuWbPwwqneihLFaHC0r6JmCHwECuG2Pay0lcUel+xhksefnZQDhoQB7Lg==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 216, DateTimeKind.Utc).AddTicks(8336), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2634"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2639"), 0, "7d477d5b-50a2-4379-ba67-5c38485e83fb", new DateTime(2022, 6, 2, 5, 52, 10, 270, DateTimeKind.Utc).AddTicks(4951), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2639"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 270, DateTimeKind.Utc).AddTicks(4964), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2639"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEFqKew49iF8LCRf9h93WgWtDrytBrlMDaJudK1Bv2rvJnmgnFS7qf8b44gMmyUcOuA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 270, DateTimeKind.Utc).AddTicks(4960), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2639"), null }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "Created_at", "Date", "Deleted_at", "Deleted_by", "Status", "Total", "Updated_at", "Updated_by", "UserId" },
                values: new object[,]
                {
                    { 31, new DateTime(2022, 6, 2, 5, 52, 10, 389, DateTimeKind.Utc).AddTicks(4087), new DateTime(2022, 6, 2, 5, 52, 10, 389, DateTimeKind.Utc).AddTicks(4084), new DateTime(2022, 6, 2, 5, 52, 10, 389, DateTimeKind.Utc).AddTicks(4090), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2650"), 0, 100m, new DateTime(2022, 6, 2, 5, 52, 10, 389, DateTimeKind.Utc).AddTicks(4088), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2650"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2650") },
                    { 30, new DateTime(2022, 6, 2, 5, 52, 10, 378, DateTimeKind.Utc).AddTicks(8748), new DateTime(2022, 6, 2, 5, 52, 10, 378, DateTimeKind.Utc).AddTicks(8745), new DateTime(2022, 6, 2, 5, 52, 10, 378, DateTimeKind.Utc).AddTicks(8751), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2649"), 0, 100m, new DateTime(2022, 6, 2, 5, 52, 10, 378, DateTimeKind.Utc).AddTicks(8749), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2649"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2649") },
                    { 1, new DateTime(2022, 6, 2, 5, 52, 10, 60, DateTimeKind.Utc).AddTicks(3116), new DateTime(2022, 6, 2, 5, 52, 10, 60, DateTimeKind.Utc).AddTicks(1895), new DateTime(2022, 6, 2, 5, 52, 10, 60, DateTimeKind.Utc).AddTicks(3941), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2620"), 0, 100m, new DateTime(2022, 6, 2, 5, 52, 10, 60, DateTimeKind.Utc).AddTicks(3510), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2620"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2620") },
                    { 2, new DateTime(2022, 6, 2, 5, 52, 10, 71, DateTimeKind.Utc).AddTicks(3582), new DateTime(2022, 6, 2, 5, 52, 10, 71, DateTimeKind.Utc).AddTicks(3579), new DateTime(2022, 6, 2, 5, 52, 10, 71, DateTimeKind.Utc).AddTicks(3586), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2621"), 0, 100m, new DateTime(2022, 6, 2, 5, 52, 10, 71, DateTimeKind.Utc).AddTicks(3584), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2621"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2621") },
                    { 3, new DateTime(2022, 6, 2, 5, 52, 10, 81, DateTimeKind.Utc).AddTicks(9259), new DateTime(2022, 6, 2, 5, 52, 10, 81, DateTimeKind.Utc).AddTicks(9257), new DateTime(2022, 6, 2, 5, 52, 10, 81, DateTimeKind.Utc).AddTicks(9262), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2622"), 0, 100m, new DateTime(2022, 6, 2, 5, 52, 10, 81, DateTimeKind.Utc).AddTicks(9260), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2622"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2622") },
                    { 4, new DateTime(2022, 6, 2, 5, 52, 10, 92, DateTimeKind.Utc).AddTicks(4033), new DateTime(2022, 6, 2, 5, 52, 10, 92, DateTimeKind.Utc).AddTicks(4031), new DateTime(2022, 6, 2, 5, 52, 10, 92, DateTimeKind.Utc).AddTicks(4036), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2623"), 0, 100m, new DateTime(2022, 6, 2, 5, 52, 10, 92, DateTimeKind.Utc).AddTicks(4034), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2623"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2623") },
                    { 5, new DateTime(2022, 6, 2, 5, 52, 10, 102, DateTimeKind.Utc).AddTicks(9939), new DateTime(2022, 6, 2, 5, 52, 10, 102, DateTimeKind.Utc).AddTicks(9936), new DateTime(2022, 6, 2, 5, 52, 10, 102, DateTimeKind.Utc).AddTicks(9942), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2624"), 0, 100m, new DateTime(2022, 6, 2, 5, 52, 10, 102, DateTimeKind.Utc).AddTicks(9940), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2624"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2624") },
                    { 6, new DateTime(2022, 6, 2, 5, 52, 10, 113, DateTimeKind.Utc).AddTicks(4909), new DateTime(2022, 6, 2, 5, 52, 10, 113, DateTimeKind.Utc).AddTicks(4906), new DateTime(2022, 6, 2, 5, 52, 10, 113, DateTimeKind.Utc).AddTicks(4912), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2625"), 0, 100m, new DateTime(2022, 6, 2, 5, 52, 10, 113, DateTimeKind.Utc).AddTicks(4910), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2625"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2625") },
                    { 7, new DateTime(2022, 6, 2, 5, 52, 10, 123, DateTimeKind.Utc).AddTicks(9957), new DateTime(2022, 6, 2, 5, 52, 10, 123, DateTimeKind.Utc).AddTicks(9955), new DateTime(2022, 6, 2, 5, 52, 10, 123, DateTimeKind.Utc).AddTicks(9960), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2626"), 0, 100m, new DateTime(2022, 6, 2, 5, 52, 10, 123, DateTimeKind.Utc).AddTicks(9958), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2626"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2626") },
                    { 9, new DateTime(2022, 6, 2, 5, 52, 10, 145, DateTimeKind.Utc).AddTicks(1254), new DateTime(2022, 6, 2, 5, 52, 10, 145, DateTimeKind.Utc).AddTicks(1251), new DateTime(2022, 6, 2, 5, 52, 10, 145, DateTimeKind.Utc).AddTicks(1257), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2628"), 0, 100m, new DateTime(2022, 6, 2, 5, 52, 10, 145, DateTimeKind.Utc).AddTicks(1255), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2628"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2628") },
                    { 10, new DateTime(2022, 6, 2, 5, 52, 10, 155, DateTimeKind.Utc).AddTicks(6209), new DateTime(2022, 6, 2, 5, 52, 10, 155, DateTimeKind.Utc).AddTicks(6207), new DateTime(2022, 6, 2, 5, 52, 10, 155, DateTimeKind.Utc).AddTicks(6213), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2629"), 0, 100m, new DateTime(2022, 6, 2, 5, 52, 10, 155, DateTimeKind.Utc).AddTicks(6211), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2629"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2629") },
                    { 11, new DateTime(2022, 6, 2, 5, 52, 10, 166, DateTimeKind.Utc).AddTicks(5174), new DateTime(2022, 6, 2, 5, 52, 10, 166, DateTimeKind.Utc).AddTicks(5171), new DateTime(2022, 6, 2, 5, 52, 10, 166, DateTimeKind.Utc).AddTicks(5177), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2630"), 0, 100m, new DateTime(2022, 6, 2, 5, 52, 10, 166, DateTimeKind.Utc).AddTicks(5175), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2630"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2630") },
                    { 12, new DateTime(2022, 6, 2, 5, 52, 10, 178, DateTimeKind.Utc).AddTicks(6907), new DateTime(2022, 6, 2, 5, 52, 10, 178, DateTimeKind.Utc).AddTicks(6903), new DateTime(2022, 6, 2, 5, 52, 10, 178, DateTimeKind.Utc).AddTicks(6910), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2631"), 0, 100m, new DateTime(2022, 6, 2, 5, 52, 10, 178, DateTimeKind.Utc).AddTicks(6908), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2631"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2631") },
                    { 13, new DateTime(2022, 6, 2, 5, 52, 10, 190, DateTimeKind.Utc).AddTicks(2025), new DateTime(2022, 6, 2, 5, 52, 10, 190, DateTimeKind.Utc).AddTicks(2021), new DateTime(2022, 6, 2, 5, 52, 10, 190, DateTimeKind.Utc).AddTicks(2029), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2632"), 0, 100m, new DateTime(2022, 6, 2, 5, 52, 10, 190, DateTimeKind.Utc).AddTicks(2026), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2632"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2632") },
                    { 14, new DateTime(2022, 6, 2, 5, 52, 10, 200, DateTimeKind.Utc).AddTicks(9117), new DateTime(2022, 6, 2, 5, 52, 10, 200, DateTimeKind.Utc).AddTicks(9113), new DateTime(2022, 6, 2, 5, 52, 10, 200, DateTimeKind.Utc).AddTicks(9120), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2633"), 0, 100m, new DateTime(2022, 6, 2, 5, 52, 10, 200, DateTimeKind.Utc).AddTicks(9118), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2633"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2633") },
                    { 8, new DateTime(2022, 6, 2, 5, 52, 10, 134, DateTimeKind.Utc).AddTicks(5670), new DateTime(2022, 6, 2, 5, 52, 10, 134, DateTimeKind.Utc).AddTicks(5667), new DateTime(2022, 6, 2, 5, 52, 10, 134, DateTimeKind.Utc).AddTicks(5673), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2627"), 0, 100m, new DateTime(2022, 6, 2, 5, 52, 10, 134, DateTimeKind.Utc).AddTicks(5671), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2627"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2627") },
                    { 16, new DateTime(2022, 6, 2, 5, 52, 10, 228, DateTimeKind.Utc).AddTicks(119), new DateTime(2022, 6, 2, 5, 52, 10, 228, DateTimeKind.Utc).AddTicks(113), new DateTime(2022, 6, 2, 5, 52, 10, 228, DateTimeKind.Utc).AddTicks(122), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2635"), 0, 100m, new DateTime(2022, 6, 2, 5, 52, 10, 228, DateTimeKind.Utc).AddTicks(120), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2635"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2635") },
                    { 15, new DateTime(2022, 6, 2, 5, 52, 10, 216, DateTimeKind.Utc).AddTicks(9028), new DateTime(2022, 6, 2, 5, 52, 10, 216, DateTimeKind.Utc).AddTicks(9019), new DateTime(2022, 6, 2, 5, 52, 10, 216, DateTimeKind.Utc).AddTicks(9034), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2634"), 0, 100m, new DateTime(2022, 6, 2, 5, 52, 10, 216, DateTimeKind.Utc).AddTicks(9031), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2634"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2634") },
                    { 28, new DateTime(2022, 6, 2, 5, 52, 10, 357, DateTimeKind.Utc).AddTicks(8878), new DateTime(2022, 6, 2, 5, 52, 10, 357, DateTimeKind.Utc).AddTicks(8875), new DateTime(2022, 6, 2, 5, 52, 10, 357, DateTimeKind.Utc).AddTicks(8881), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2647"), 0, 100m, new DateTime(2022, 6, 2, 5, 52, 10, 357, DateTimeKind.Utc).AddTicks(8879), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2647"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2647") },
                    { 27, new DateTime(2022, 6, 2, 5, 52, 10, 347, DateTimeKind.Utc).AddTicks(3354), new DateTime(2022, 6, 2, 5, 52, 10, 347, DateTimeKind.Utc).AddTicks(3351), new DateTime(2022, 6, 2, 5, 52, 10, 347, DateTimeKind.Utc).AddTicks(3357), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2646"), 0, 100m, new DateTime(2022, 6, 2, 5, 52, 10, 347, DateTimeKind.Utc).AddTicks(3355), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2646"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2646") },
                    { 26, new DateTime(2022, 6, 2, 5, 52, 10, 336, DateTimeKind.Utc).AddTicks(7927), new DateTime(2022, 6, 2, 5, 52, 10, 336, DateTimeKind.Utc).AddTicks(7925), new DateTime(2022, 6, 2, 5, 52, 10, 336, DateTimeKind.Utc).AddTicks(7930), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2645"), 0, 100m, new DateTime(2022, 6, 2, 5, 52, 10, 336, DateTimeKind.Utc).AddTicks(7929), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2645"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2645") },
                    { 24, new DateTime(2022, 6, 2, 5, 52, 10, 315, DateTimeKind.Utc).AddTicks(7172), new DateTime(2022, 6, 2, 5, 52, 10, 315, DateTimeKind.Utc).AddTicks(7168), new DateTime(2022, 6, 2, 5, 52, 10, 315, DateTimeKind.Utc).AddTicks(7175), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2643"), 0, 100m, new DateTime(2022, 6, 2, 5, 52, 10, 315, DateTimeKind.Utc).AddTicks(7173), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2643"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2643") },
                    { 23, new DateTime(2022, 6, 2, 5, 52, 10, 305, DateTimeKind.Utc).AddTicks(1461), new DateTime(2022, 6, 2, 5, 52, 10, 305, DateTimeKind.Utc).AddTicks(1457), new DateTime(2022, 6, 2, 5, 52, 10, 305, DateTimeKind.Utc).AddTicks(1464), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2642"), 0, 100m, new DateTime(2022, 6, 2, 5, 52, 10, 305, DateTimeKind.Utc).AddTicks(1462), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2642"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2642") },
                    { 25, new DateTime(2022, 6, 2, 5, 52, 10, 326, DateTimeKind.Utc).AddTicks(3408), new DateTime(2022, 6, 2, 5, 52, 10, 326, DateTimeKind.Utc).AddTicks(3405), new DateTime(2022, 6, 2, 5, 52, 10, 326, DateTimeKind.Utc).AddTicks(3411), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2644"), 0, 100m, new DateTime(2022, 6, 2, 5, 52, 10, 326, DateTimeKind.Utc).AddTicks(3410), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2644"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2644") },
                    { 29, new DateTime(2022, 6, 2, 5, 52, 10, 368, DateTimeKind.Utc).AddTicks(3721), new DateTime(2022, 6, 2, 5, 52, 10, 368, DateTimeKind.Utc).AddTicks(3719), new DateTime(2022, 6, 2, 5, 52, 10, 368, DateTimeKind.Utc).AddTicks(3724), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2648"), 0, 100m, new DateTime(2022, 6, 2, 5, 52, 10, 368, DateTimeKind.Utc).AddTicks(3723), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2648"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2648") },
                    { 21, new DateTime(2022, 6, 2, 5, 52, 10, 281, DateTimeKind.Utc).AddTicks(8246), new DateTime(2022, 6, 2, 5, 52, 10, 281, DateTimeKind.Utc).AddTicks(8241), new DateTime(2022, 6, 2, 5, 52, 10, 281, DateTimeKind.Utc).AddTicks(8251), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2640"), 0, 100m, new DateTime(2022, 6, 2, 5, 52, 10, 281, DateTimeKind.Utc).AddTicks(8248), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2640"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2640") },
                    { 20, new DateTime(2022, 6, 2, 5, 52, 10, 270, DateTimeKind.Utc).AddTicks(5250), new DateTime(2022, 6, 2, 5, 52, 10, 270, DateTimeKind.Utc).AddTicks(5247), new DateTime(2022, 6, 2, 5, 52, 10, 270, DateTimeKind.Utc).AddTicks(5253), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2639"), 0, 100m, new DateTime(2022, 6, 2, 5, 52, 10, 270, DateTimeKind.Utc).AddTicks(5252), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2639"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2639") },
                    { 19, new DateTime(2022, 6, 2, 5, 52, 10, 259, DateTimeKind.Utc).AddTicks(8886), new DateTime(2022, 6, 2, 5, 52, 10, 259, DateTimeKind.Utc).AddTicks(8882), new DateTime(2022, 6, 2, 5, 52, 10, 259, DateTimeKind.Utc).AddTicks(8889), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2638"), 0, 100m, new DateTime(2022, 6, 2, 5, 52, 10, 259, DateTimeKind.Utc).AddTicks(8887), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2638"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2638") },
                    { 18, new DateTime(2022, 6, 2, 5, 52, 10, 249, DateTimeKind.Utc).AddTicks(3451), new DateTime(2022, 6, 2, 5, 52, 10, 249, DateTimeKind.Utc).AddTicks(3447), new DateTime(2022, 6, 2, 5, 52, 10, 249, DateTimeKind.Utc).AddTicks(3454), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2637"), 0, 100m, new DateTime(2022, 6, 2, 5, 52, 10, 249, DateTimeKind.Utc).AddTicks(3453), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2637"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2637") },
                    { 17, new DateTime(2022, 6, 2, 5, 52, 10, 238, DateTimeKind.Utc).AddTicks(7690), new DateTime(2022, 6, 2, 5, 52, 10, 238, DateTimeKind.Utc).AddTicks(7685), new DateTime(2022, 6, 2, 5, 52, 10, 238, DateTimeKind.Utc).AddTicks(7694), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2636"), 0, 100m, new DateTime(2022, 6, 2, 5, 52, 10, 238, DateTimeKind.Utc).AddTicks(7692), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2636"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2636") },
                    { 22, new DateTime(2022, 6, 2, 5, 52, 10, 294, DateTimeKind.Utc).AddTicks(3289), new DateTime(2022, 6, 2, 5, 52, 10, 294, DateTimeKind.Utc).AddTicks(3284), new DateTime(2022, 6, 2, 5, 52, 10, 294, DateTimeKind.Utc).AddTicks(3294), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2641"), 0, 100m, new DateTime(2022, 6, 2, 5, 52, 10, 294, DateTimeKind.Utc).AddTicks(3291), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2641"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2641") }
                });

            migrationBuilder.InsertData(
                table: "Dentists",
                columns: new[] { "Id", "ClinicId", "Description", "Position" },
                values: new object[,]
                {
                    { 63, 1, "TestDescirption63", 0 },
                    { 59, 1, "TestDescirption59", 0 },
                    { 60, 1, "TestDescirption60", 0 },
                    { 61, 1, "TestDescirption61", 0 },
                    { 62, 1, "TestDescirption62", 0 },
                    { 64, 1, "TestDescirption64", 0 },
                    { 71, 1, "TestDescirption71", 0 },
                    { 66, 1, "TestDescirption66", 0 },
                    { 67, 1, "TestDescirption67", 0 },
                    { 68, 1, "TestDescirption68", 0 },
                    { 69, 1, "TestDescirption69", 0 }
                });

            migrationBuilder.InsertData(
                table: "Dentists",
                columns: new[] { "Id", "ClinicId", "Description", "Position" },
                values: new object[,]
                {
                    { 70, 1, "TestDescirption70", 0 },
                    { 57, 1, "TestDescirption57", 0 },
                    { 65, 1, "TestDescirption65", 0 },
                    { 56, 1, "TestDescirption56", 0 },
                    { 58, 1, "TestDescirption58", 0 },
                    { 54, 1, "TestDescirption54", 0 },
                    { 32, 1, "TestDescirption32", 0 },
                    { 31, 1, "TestDescirption31", 0 },
                    { 30, 1, "TestDescirption30", 0 },
                    { 29, 1, "TestDescirption29", 0 },
                    { 28, 1, "TestDescirption28", 0 },
                    { 27, 1, "TestDescirption27", 0 },
                    { 26, 1, "TestDescirption26", 0 },
                    { 25, 1, "TestDescirption25", 0 },
                    { 24, 1, "TestDescirption24", 0 },
                    { 23, 1, "TestDescirption23", 0 },
                    { 33, 1, "TestDescirption33", 0 },
                    { 22, 1, "TestDescirption22", 0 },
                    { 20, 1, "TestDescirption20", 0 },
                    { 19, 1, "TestDescirption19", 0 },
                    { 18, 1, "TestDescirption18", 0 },
                    { 17, 1, "TestDescirption17", 0 },
                    { 16, 1, "TestDescirption16", 0 },
                    { 15, 1, "TestDescirption15", 0 },
                    { 14, 1, "TestDescirption14", 0 },
                    { 13, 1, "TestDescirption13", 0 },
                    { 12, 1, "TestDescirption12", 0 },
                    { 11, 1, "TestDescirption11", 0 },
                    { 21, 1, "TestDescirption21", 0 },
                    { 55, 1, "TestDescirption55", 0 },
                    { 34, 1, "TestDescirption34", 0 },
                    { 36, 1, "TestDescirption36", 0 },
                    { 53, 1, "TestDescirption53", 0 },
                    { 52, 1, "TestDescirption52", 0 },
                    { 51, 1, "TestDescirption51", 0 },
                    { 50, 1, "TestDescirption50", 0 },
                    { 49, 1, "TestDescirption49", 0 },
                    { 48, 1, "TestDescirption48", 0 },
                    { 47, 1, "TestDescirption47", 0 },
                    { 46, 1, "TestDescirption46", 0 },
                    { 45, 1, "TestDescirption45", 0 },
                    { 44, 1, "TestDescirption44", 0 }
                });

            migrationBuilder.InsertData(
                table: "Dentists",
                columns: new[] { "Id", "ClinicId", "Description", "Position" },
                values: new object[,]
                {
                    { 35, 1, "TestDescirption35", 0 },
                    { 43, 1, "TestDescirption43", 0 },
                    { 41, 1, "TestDescirption41", 0 },
                    { 40, 1, "TestDescirption40", 0 },
                    { 39, 1, "TestDescirption39", 0 },
                    { 38, 1, "TestDescirption38", 0 },
                    { 37, 1, "TestDescirption37", 0 },
                    { 42, 1, "TestDescirption42", 0 },
                    { 10, 1, "TestDescirption10", 0 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Created_at", "Created_by", "Deleted_at", "Deleted_by", "DiscountId", "Name", "Price", "Procedure", "Status", "Updated_at", "Updated_by" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 2, 12, 52, 10, 44, DateTimeKind.Local).AddTicks(1466), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a1"), new DateTime(2022, 6, 2, 12, 52, 10, 44, DateTimeKind.Local).AddTicks(2351), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a1"), 1, "testService@gmail.com1", 1m, "testProcedure1", 0, new DateTime(2022, 6, 2, 12, 52, 10, 44, DateTimeKind.Local).AddTicks(1897), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a1") },
                    { 2, new DateTime(2022, 6, 2, 12, 52, 10, 44, DateTimeKind.Local).AddTicks(4899), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a2"), new DateTime(2022, 6, 2, 12, 52, 10, 44, DateTimeKind.Local).AddTicks(4909), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a2"), 2, "testService@gmail.com2", 2m, "testProcedure2", 0, new DateTime(2022, 6, 2, 12, 52, 10, 44, DateTimeKind.Local).AddTicks(4907), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a2") },
                    { 3, new DateTime(2022, 6, 2, 12, 52, 10, 44, DateTimeKind.Local).AddTicks(4971), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a3"), new DateTime(2022, 6, 2, 12, 52, 10, 44, DateTimeKind.Local).AddTicks(4975), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a3"), 3, "testService@gmail.com3", 3m, "testProcedure3", 0, new DateTime(2022, 6, 2, 12, 52, 10, 44, DateTimeKind.Local).AddTicks(4973), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a3") },
                    { 4, new DateTime(2022, 6, 2, 12, 52, 10, 44, DateTimeKind.Local).AddTicks(5014), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a4"), new DateTime(2022, 6, 2, 12, 52, 10, 44, DateTimeKind.Local).AddTicks(5018), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a4"), 4, "testService@gmail.com4", 4m, "testProcedure4", 0, new DateTime(2022, 6, 2, 12, 52, 10, 44, DateTimeKind.Local).AddTicks(5016), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a4") },
                    { 5, new DateTime(2022, 6, 2, 12, 52, 10, 44, DateTimeKind.Local).AddTicks(5055), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a5"), new DateTime(2022, 6, 2, 12, 52, 10, 44, DateTimeKind.Local).AddTicks(5059), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a5"), 5, "testService@gmail.com5", 5m, "testProcedure5", 0, new DateTime(2022, 6, 2, 12, 52, 10, 44, DateTimeKind.Local).AddTicks(5057), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a5") }
                });

            migrationBuilder.InsertData(
                table: "Booking_Details",
                columns: new[] { "Id", "BookingId", "Created_at", "Created_by", "Deleted_at", "Deleted_by", "DentistId", "KeyTime", "Note", "ServiceId", "Status", "Updated_at", "Updated_by" },
                values: new object[,]
                {
                    { 11, 4, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5647), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3313"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5650), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3313"), 13, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5649), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3313") },
                    { 34, 12, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6337), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3321"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6339), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3321"), 21, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6338), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3321") },
                    { 35, 12, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6359), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3321"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6361), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3321"), 21, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6360), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3321") },
                    { 36, 12, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6380), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3321"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6382), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3321"), 21, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6381), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3321") },
                    { 37, 13, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6401), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3322"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6403), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3322"), 22, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6402), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3322") },
                    { 38, 13, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6422), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3322"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6424), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3322"), 22, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6423), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3322") },
                    { 39, 13, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6498), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3322"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6500), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3322"), 22, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6499), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3322") },
                    { 40, 14, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6523), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3323"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6525), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3323"), 23, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6524), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3323") },
                    { 33, 11, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6313), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3320"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6316), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3320"), 20, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6314), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3320") },
                    { 41, 14, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6545), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3323"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6547), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3323"), 23, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6546), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3323") },
                    { 43, 15, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6587), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3324"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6590), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3324"), 24, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6588), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3324") },
                    { 44, 15, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6609), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3324"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6611), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3324"), 24, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6610), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3324") },
                    { 45, 15, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6629), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3324"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6632), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3324"), 24, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6631), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3324") },
                    { 46, 16, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6651), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3325"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6653), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3325"), 25, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6652), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3325") },
                    { 47, 16, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6672), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3325"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6674), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3325"), 25, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6673), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3325") },
                    { 48, 16, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6748), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3325"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6750), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3325"), 25, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6749), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3325") },
                    { 49, 17, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6772), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3326"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6774), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3326"), 26, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6773), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3326") },
                    { 42, 14, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6566), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3323"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6569), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3323"), 23, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6567), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3323") },
                    { 32, 11, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6292), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3320"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6294), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3320"), 20, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6293), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3320") },
                    { 31, 11, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6267), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3320"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6269), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3320"), 20, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6268), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3320") },
                    { 30, 10, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6190), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3319"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6193), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3319"), 19, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6191), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3319") },
                    { 13, 5, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5691), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3314"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5693), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3314"), 14, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5692), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3314") },
                    { 14, 5, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5783), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3314"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5785), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3314"), 14, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5784), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3314") },
                    { 15, 5, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5805), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3314"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5808), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3314"), 14, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5807), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3314") },
                    { 16, 6, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5827), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3315"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5830), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3315"), 15, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5829), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3315") },
                    { 17, 6, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5848), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3315"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5851), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3315"), 15, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5849), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3315") },
                    { 18, 6, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5871), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3315"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5873), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3315"), 15, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5872), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3315") },
                    { 19, 7, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5897), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3316"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5900), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3316"), 16, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5898), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3316") },
                    { 20, 7, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5920), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3316"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5922), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3316"), 16, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5921), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3316") },
                    { 21, 7, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5941), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3316"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5943), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3316"), 16, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5942), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3316") },
                    { 22, 8, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6017), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3317"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6019), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3317"), 17, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6018), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3317") },
                    { 23, 8, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6042), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3317"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6045), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3317"), 17, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6043), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3317") },
                    { 24, 8, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6064), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3317"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6066), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3317"), 17, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6065), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3317") },
                    { 25, 9, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6085), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3318"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6088), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3318"), 18, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6086), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3318") },
                    { 26, 9, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6106), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3318"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6108), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3318"), 18, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6107), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3318") },
                    { 27, 9, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6127), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3318"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6129), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3318"), 18, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6128), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3318") },
                    { 28, 10, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6148), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3319"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6150), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3319"), 19, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6149), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3319") },
                    { 29, 10, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6169), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3319"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6171), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3319"), 19, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6170), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3319") },
                    { 50, 17, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6793), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3326"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6796), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3326"), 26, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6794), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3326") },
                    { 51, 17, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6814), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3326"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6816), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3326"), 26, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6815), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3326") },
                    { 52, 18, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6836), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3327"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6838), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3327"), 27, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6837), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3327") },
                    { 53, 18, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6857), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3327"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6859), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3327"), 27, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6858), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3327") }
                });

            migrationBuilder.InsertData(
                table: "Booking_Details",
                columns: new[] { "Id", "BookingId", "Created_at", "Created_by", "Deleted_at", "Deleted_by", "DentistId", "KeyTime", "Note", "ServiceId", "Status", "Updated_at", "Updated_by" },
                values: new object[,]
                {
                    { 75, 25, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7535), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3334"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7537), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3334"), 34, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7536), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3334") },
                    { 76, 26, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7558), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3335"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7560), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3335"), 35, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7559), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3335") },
                    { 77, 26, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7579), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3335"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7581), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3335"), 35, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7580), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3335") },
                    { 78, 26, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7600), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3335"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7603), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3335"), 35, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7601), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3335") },
                    { 79, 27, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7622), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3336"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7624), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3336"), 36, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7623), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3336") },
                    { 80, 27, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7643), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3336"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7645), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3336"), 36, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7644), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3336") },
                    { 81, 27, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7663), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3336"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7666), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3336"), 36, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7664), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3336") },
                    { 82, 28, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7739), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3337"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7741), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3337"), 37, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7740), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3337") },
                    { 83, 28, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7764), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3337"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7767), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3337"), 37, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7765), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3337") },
                    { 84, 28, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7786), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3337"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7788), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3337"), 37, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7787), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3337") },
                    { 85, 29, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7808), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3338"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7810), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3338"), 38, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7809), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3338") },
                    { 86, 29, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7829), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3338"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7831), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3338"), 38, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7830), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3338") },
                    { 87, 29, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7850), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3338"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7853), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3338"), 38, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7852), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3338") },
                    { 88, 30, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7872), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3339"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7874), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3339"), 39, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7873), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3339") },
                    { 89, 30, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7893), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3339"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7895), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3339"), 39, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7894), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3339") },
                    { 90, 30, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7914), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3339"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7917), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3339"), 39, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7915), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3339") },
                    { 91, 31, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7989), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3340"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7992), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3340"), 40, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7991), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3340") },
                    { 74, 25, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7513), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3334"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7515), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3334"), 34, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7514), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3334") },
                    { 12, 4, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5669), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3313"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5672), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3313"), 13, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5671), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3313") },
                    { 73, 25, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7487), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3334"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7489), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3334"), 34, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7488), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3334") },
                    { 71, 24, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7365), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3333"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7367), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3333"), 33, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7366), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3333") },
                    { 54, 18, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6878), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3327"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6880), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3327"), 27, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6879), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3327") },
                    { 55, 19, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6899), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3328"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6901), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3328"), 28, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6900), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3328") },
                    { 56, 19, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6920), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3328"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6922), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3328"), 28, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6921), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3328") },
                    { 57, 19, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6995), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3328"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6997), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3328"), 28, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(6996), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3328") },
                    { 58, 20, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7018), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3329"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7020), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3329"), 29, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7019), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3329") },
                    { 59, 20, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7040), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3329"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7042), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3329"), 29, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7041), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3329") },
                    { 60, 20, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7062), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3329"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7064), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3329"), 29, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7063), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3329") },
                    { 61, 21, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7083), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3330"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7085), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3330"), 30, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7084), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3330") },
                    { 62, 21, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7104), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3330"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7106), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3330"), 30, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7105), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3330") },
                    { 63, 21, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7124), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3330"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7127), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3330"), 30, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7126), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3330") },
                    { 64, 22, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7145), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3331"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7147), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3331"), 31, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7146), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3331") },
                    { 65, 22, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7166), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3331"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7168), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3331"), 31, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7167), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3331") },
                    { 66, 22, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7257), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3331"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7260), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3331"), 31, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7258), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3331") },
                    { 67, 23, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7279), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3332"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7282), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3332"), 32, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7281), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3332") },
                    { 68, 23, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7302), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3332"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7304), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3332"), 32, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7303), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3332") },
                    { 69, 23, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7323), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3332"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7325), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3332"), 32, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7324), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3332") },
                    { 70, 24, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7344), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3333"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7346), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3333"), 33, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7345), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3333") },
                    { 72, 24, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7385), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3333"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7388), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3333"), 33, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(7387), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3333") },
                    { 92, 31, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8012), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3340"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8015), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3340"), 40, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8013), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3340") },
                    { 93, 31, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8034), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3340"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8036), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3340"), 40, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8035), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3340") },
                    { 9, 3, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5602), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3312"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5604), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3312"), 12, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5603), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3312") }
                });

            migrationBuilder.InsertData(
                table: "Booking_Details",
                columns: new[] { "Id", "BookingId", "Created_at", "Created_by", "Deleted_at", "Deleted_by", "DentistId", "KeyTime", "Note", "ServiceId", "Status", "Updated_at", "Updated_by" },
                values: new object[,]
                {
                    { 8, 3, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5581), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3312"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5583), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3312"), 12, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5582), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3312") },
                    { 7, 3, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5560), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3312"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5562), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3312"), 12, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5561), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3312") },
                    { 6, 2, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5537), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3311"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5539), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3311"), 11, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5538), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3311") },
                    { 5, 2, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5499), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3311"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5502), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3311"), 11, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5501), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3311") },
                    { 4, 2, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5353), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3311"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5356), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3311"), 11, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5354), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3311") },
                    { 3, 1, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5329), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3310"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5331), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3310"), 10, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5330), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3310") },
                    { 2, 1, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5282), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3310"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5288), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3310"), 10, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5285), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3310") },
                    { 1, 1, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(1967), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3310"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(3052), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3310"), 10, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(2529), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3310") },
                    { 10, 4, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5625), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3313"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5627), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3313"), 13, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(5626), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3313") }
                });

            migrationBuilder.InsertData(
                table: "ServiceDentists",
                columns: new[] { "DentistId", "ServiceId" },
                values: new object[,]
                {
                    { 34, 2 },
                    { 35, 2 },
                    { 36, 2 },
                    { 37, 2 },
                    { 42, 3 },
                    { 40, 2 },
                    { 41, 3 },
                    { 33, 2 },
                    { 38, 2 },
                    { 32, 2 },
                    { 27, 1 },
                    { 30, 1 },
                    { 29, 1 },
                    { 28, 1 },
                    { 43, 3 },
                    { 26, 1 },
                    { 25, 1 },
                    { 24, 1 },
                    { 23, 1 },
                    { 22, 1 },
                    { 21, 1 },
                    { 20, 1 },
                    { 31, 2 },
                    { 44, 3 },
                    { 39, 2 },
                    { 46, 3 },
                    { 70, 5 },
                    { 45, 3 },
                    { 68, 5 },
                    { 67, 5 },
                    { 66, 5 },
                    { 65, 5 },
                    { 64, 5 }
                });

            migrationBuilder.InsertData(
                table: "ServiceDentists",
                columns: new[] { "DentistId", "ServiceId" },
                values: new object[,]
                {
                    { 63, 5 },
                    { 62, 5 },
                    { 61, 5 },
                    { 60, 4 },
                    { 59, 4 },
                    { 69, 5 },
                    { 57, 4 },
                    { 58, 4 },
                    { 48, 3 },
                    { 49, 3 },
                    { 50, 3 },
                    { 51, 4 },
                    { 47, 3 },
                    { 53, 4 },
                    { 54, 4 },
                    { 55, 4 },
                    { 56, 4 },
                    { 52, 4 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Created_at", "Created_by", "DOB", "Deleted_at", "Deleted_by", "DentistId", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshTokenExpiryTime", "SecurityStamp", "Status", "Token", "TwoFactorEnabled", "Updated_at", "Updated_by", "UserName" },
                values: new object[,]
                {
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"), 0, "477f9ace-83c7-4ff3-93e1-451c92d72b61", new DateTime(2022, 6, 2, 5, 52, 10, 490, DateTimeKind.Utc).AddTicks(9304), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 490, DateTimeKind.Utc).AddTicks(9307), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"), 59, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEBMy4Q0PByITavv+bPOiKAEbXtqY//021nIJBq2GALceig9b244maRctVGhWN22odA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 490, DateTimeKind.Utc).AddTicks(9306), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"), 0, "19512b6a-df68-4c4e-a143-5444fc28ffdd", new DateTime(2022, 6, 2, 5, 52, 10, 411, DateTimeKind.Utc).AddTicks(3276), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 411, DateTimeKind.Utc).AddTicks(3285), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"), 52, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAECca2yyxyr6XEG/kdAFGJI43UlzQ4MlRy74G/6zkvtKX0dPkcxE7KWvdpUnzOJVVKw==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 411, DateTimeKind.Utc).AddTicks(3283), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"), 0, "cc2ef291-cc38-4a0d-a693-6b4188d912e6", new DateTime(2022, 6, 2, 5, 52, 10, 421, DateTimeKind.Utc).AddTicks(9540), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 421, DateTimeKind.Utc).AddTicks(9546), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"), 53, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEBNzq5gn02deaFpuCiScquXi9471/PlpGhKDxAHBemYs93IGmXXQT8E0Z+NANB+Z8Q==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 421, DateTimeKind.Utc).AddTicks(9544), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"), 0, "1533234f-48ff-4e69-a8e0-894ed8da6ef8", new DateTime(2022, 6, 2, 5, 52, 10, 432, DateTimeKind.Utc).AddTicks(4706), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 432, DateTimeKind.Utc).AddTicks(4710), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"), 54, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAELOEqnWhcoG9zuxhqXaac1KXMzWAfk25VUtZyHEluG5vZXgarzLXwJBFPc6nLTd+eg==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 432, DateTimeKind.Utc).AddTicks(4708), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"), 0, "2690af59-542f-4331-82cc-5d0eae1405ae", new DateTime(2022, 6, 2, 5, 52, 10, 444, DateTimeKind.Utc).AddTicks(9409), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 444, DateTimeKind.Utc).AddTicks(9422), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"), 55, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEFFg+RJtB/25ZcZrtdP/Re6cGkjLUrZhUb5U17KrDbiiiagAtoBqb1+4ZgNy1iPkyw==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 444, DateTimeKind.Utc).AddTicks(9420), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"), 0, "b6fdb41c-d957-4319-970d-adf78122b318", new DateTime(2022, 6, 2, 5, 52, 10, 455, DateTimeKind.Utc).AddTicks(5303), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 455, DateTimeKind.Utc).AddTicks(5311), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"), 56, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEJ02oRV37wNtkrKGovnu6S2vdZFaK39GwWSnQo2vLFsnDMNXJeTXfEri5Pm88oIWwQ==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 455, DateTimeKind.Utc).AddTicks(5309), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"), 0, "5f83063d-44da-4f7e-b30f-3868a0b0baae", new DateTime(2022, 6, 2, 5, 52, 10, 467, DateTimeKind.Utc).AddTicks(2050), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 467, DateTimeKind.Utc).AddTicks(2064), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"), 57, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEK4n+SY49f08NzKuVILR8L4IZcu32QiGwJsMSi4wvCKGuwOhspia8Z1FbRSePA4ULw==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 467, DateTimeKind.Utc).AddTicks(2060), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"), 0, "4dcfd7e3-5da8-457f-b5a0-0de18a63d5b8", new DateTime(2022, 6, 2, 5, 52, 10, 480, DateTimeKind.Utc).AddTicks(4471), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 480, DateTimeKind.Utc).AddTicks(4479), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"), 58, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEC9zVopaFGbTSO1mdGN7PUtlx0U89kNMgIFFumhluxs77VaNkHvvN/qsoNmDTmVluA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 480, DateTimeKind.Utc).AddTicks(4477), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"), 0, "2a6b560f-907b-4621-9ecb-17b3638c593a", new DateTime(2022, 6, 2, 5, 52, 10, 501, DateTimeKind.Utc).AddTicks(5605), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 501, DateTimeKind.Utc).AddTicks(5616), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"), 60, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEE+3RsqvHEIHJtvCs7905gMW5i//hJv/lRgKjRRNHN8wS000VYgcoswSYpj9kCh/RQ==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 501, DateTimeKind.Utc).AddTicks(5614), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3366"), 0, "f293351c-9dc9-4d86-ae0b-63caab168463", new DateTime(2022, 6, 2, 5, 52, 10, 566, DateTimeKind.Utc).AddTicks(2858), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3366"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 566, DateTimeKind.Utc).AddTicks(2871), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3366"), 66, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEIvmc6+zzXMEnh6IvCmirh2VIm/fczHWqSDMN4MzUW0rMWc7WySi05ady2fsyD/KpQ==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 566, DateTimeKind.Utc).AddTicks(2869), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3366"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3362"), 0, "ece0f6fe-88e6-42ac-a2c6-ccfc7a94e807", new DateTime(2022, 6, 2, 5, 52, 10, 523, DateTimeKind.Utc).AddTicks(21), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3362"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 523, DateTimeKind.Utc).AddTicks(33), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3362"), 62, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEDHlBZ3UNgN7pO1K6HMjLmbLQIHNxQpQCQpKZwnXfkOBcBwZTmYcOQvK3P881XRZ2w==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 523, DateTimeKind.Utc).AddTicks(31), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3362"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3363"), 0, "12d39ded-50c6-48b8-8aac-7787cf1069a7", new DateTime(2022, 6, 2, 5, 52, 10, 533, DateTimeKind.Utc).AddTicks(9129), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3363"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 533, DateTimeKind.Utc).AddTicks(9143), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3363"), 63, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEKdmdgZErhdlyZgkyBS+JTVzOgE1q2+dYENLkkaFZ/OnkgocUhLCGMn+ZU+TZPuaoQ==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 533, DateTimeKind.Utc).AddTicks(9141), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3363"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3364"), 0, "aed273ca-bc50-4bf2-ba76-f4f5597241a7", new DateTime(2022, 6, 2, 5, 52, 10, 544, DateTimeKind.Utc).AddTicks(6366), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3364"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 544, DateTimeKind.Utc).AddTicks(6377), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3364"), 64, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEG+WEYXrdD0xaumz8cltcwf39AGxMKKD6bAYwGA6GKesZzJ3F+fMjO564suseujINg==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 544, DateTimeKind.Utc).AddTicks(6375), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3364"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3365"), 0, "5f2a0318-4244-4b2f-b171-06a008822060", new DateTime(2022, 6, 2, 5, 52, 10, 555, DateTimeKind.Utc).AddTicks(3236), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3365"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 555, DateTimeKind.Utc).AddTicks(3244), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3365"), 65, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAECLuJASjX0cqNmvm+TzyBSHJimrwcMUZu0zCIZOAnwYvuMcZ2D/k6OTD/BDoHARCLg==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 555, DateTimeKind.Utc).AddTicks(3243), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3365"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3367"), 0, "684a5df3-c939-4e2e-93f3-90d465a049d4", new DateTime(2022, 6, 2, 5, 52, 10, 576, DateTimeKind.Utc).AddTicks(8661), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3367"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 576, DateTimeKind.Utc).AddTicks(8678), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3367"), 67, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEMPDfRFv8AlgVr3ViUHlLXJXW7T5zxSD75kbaTocMXsEc4dsthhK/x+5q4z71iwYng==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 576, DateTimeKind.Utc).AddTicks(8675), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3367"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3368"), 0, "85836cb5-7c07-4865-bbfe-0439242f7c92", new DateTime(2022, 6, 2, 5, 52, 10, 588, DateTimeKind.Utc).AddTicks(795), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3368"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 588, DateTimeKind.Utc).AddTicks(807), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3368"), 68, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEGV9r3sk/XjVtr6gDtmgjznAIv5Jx42rlA56hO0RjF2i0wdp//LCDYeWlTgYFF/MOw==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 588, DateTimeKind.Utc).AddTicks(805), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3368"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3369"), 0, "631b0026-403a-4496-8db3-179a89eab73c", new DateTime(2022, 6, 2, 5, 52, 10, 598, DateTimeKind.Utc).AddTicks(5718), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3369"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 598, DateTimeKind.Utc).AddTicks(5723), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3369"), 69, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEMKpa9m2my1tJOTsZIeCslHS5O94mFrYAiFeHmtSEv4XFcFTFlZNkGeHs42w0nD8DQ==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 598, DateTimeKind.Utc).AddTicks(5721), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3369"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3370"), 0, "c294573b-ddd6-4883-8d3f-b00dfd78a17c", new DateTime(2022, 6, 2, 5, 52, 10, 609, DateTimeKind.Utc).AddTicks(1208), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3370"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 609, DateTimeKind.Utc).AddTicks(1220), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3370"), 70, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEJudtHrKNHPV56WH0ezlrvfSVP89Qvw6Z2CnSKK/7zwa/OOp0rrqa1uh8XKC871DKA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 609, DateTimeKind.Utc).AddTicks(1218), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3370"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3371"), 0, "20744421-ec1a-4aca-b809-3d0d8b0dc060", new DateTime(2022, 6, 2, 5, 52, 10, 619, DateTimeKind.Utc).AddTicks(7120), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3371"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 619, DateTimeKind.Utc).AddTicks(7129), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3371"), 71, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEFtVUjn2cz0fTvs8y7lVdm7jLMbrJQwB2qApucGQVI4BoLp+hS1ss4aSi+Q1us5VZQ==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 619, DateTimeKind.Utc).AddTicks(7128), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3371"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3361"), 0, "687fb7dc-60b4-4d36-b124-1ca43af3ba4e", new DateTime(2022, 6, 2, 5, 52, 10, 512, DateTimeKind.Utc).AddTicks(2904), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3361"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 512, DateTimeKind.Utc).AddTicks(2913), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3361"), 61, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEKho6PGYu2VJ2WIXKSp05Eyz4zbAWWLKWpHAgwA/VMF6RtHXhDqAqFzrkULlwWmzeg==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 512, DateTimeKind.Utc).AddTicks(2911), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3361"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"), 0, "2438298f-eff7-4e1e-bb70-e0e7edb8fbc4", new DateTime(2022, 6, 2, 5, 52, 10, 400, DateTimeKind.Utc).AddTicks(1634), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 5, 52, 10, 400, DateTimeKind.Utc).AddTicks(1644), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"), 51, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEPAJP1NQr2F4ELl/W8ekNMpllakwxcepczbz7ScG7Nv+2J7YJOgXPXbOVYqSIK7enQ==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 2, 5, 52, 10, 400, DateTimeKind.Utc).AddTicks(1641), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"), null }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "Created_at", "Date", "Deleted_at", "Deleted_by", "Status", "Total", "Updated_at", "Updated_by", "UserId" },
                values: new object[,]
                {
                    { 32, new DateTime(2022, 6, 2, 5, 52, 10, 400, DateTimeKind.Utc).AddTicks(2651), new DateTime(2022, 6, 2, 5, 52, 10, 400, DateTimeKind.Utc).AddTicks(2646), new DateTime(2022, 6, 2, 5, 52, 10, 400, DateTimeKind.Utc).AddTicks(2654), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"), 0, 200m, new DateTime(2022, 6, 2, 5, 52, 10, 400, DateTimeKind.Utc).AddTicks(2652), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351") },
                    { 50, new DateTime(2022, 6, 2, 5, 52, 10, 598, DateTimeKind.Utc).AddTicks(5819), new DateTime(2022, 6, 2, 5, 52, 10, 598, DateTimeKind.Utc).AddTicks(5817), new DateTime(2022, 6, 2, 5, 52, 10, 598, DateTimeKind.Utc).AddTicks(5822), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3369"), 0, 200m, new DateTime(2022, 6, 2, 5, 52, 10, 598, DateTimeKind.Utc).AddTicks(5821), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3369"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3369") },
                    { 49, new DateTime(2022, 6, 2, 5, 52, 10, 588, DateTimeKind.Utc).AddTicks(1079), new DateTime(2022, 6, 2, 5, 52, 10, 588, DateTimeKind.Utc).AddTicks(1076), new DateTime(2022, 6, 2, 5, 52, 10, 588, DateTimeKind.Utc).AddTicks(1081), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3368"), 0, 200m, new DateTime(2022, 6, 2, 5, 52, 10, 588, DateTimeKind.Utc).AddTicks(1080), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3368"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3368") },
                    { 48, new DateTime(2022, 6, 2, 5, 52, 10, 576, DateTimeKind.Utc).AddTicks(8946), new DateTime(2022, 6, 2, 5, 52, 10, 576, DateTimeKind.Utc).AddTicks(8943), new DateTime(2022, 6, 2, 5, 52, 10, 576, DateTimeKind.Utc).AddTicks(8949), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3367"), 0, 200m, new DateTime(2022, 6, 2, 5, 52, 10, 576, DateTimeKind.Utc).AddTicks(8947), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3367"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3367") },
                    { 47, new DateTime(2022, 6, 2, 5, 52, 10, 566, DateTimeKind.Utc).AddTicks(3161), new DateTime(2022, 6, 2, 5, 52, 10, 566, DateTimeKind.Utc).AddTicks(3157), new DateTime(2022, 6, 2, 5, 52, 10, 566, DateTimeKind.Utc).AddTicks(3164), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3366"), 0, 200m, new DateTime(2022, 6, 2, 5, 52, 10, 566, DateTimeKind.Utc).AddTicks(3162), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3366"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3366") },
                    { 46, new DateTime(2022, 6, 2, 5, 52, 10, 555, DateTimeKind.Utc).AddTicks(3438), new DateTime(2022, 6, 2, 5, 52, 10, 555, DateTimeKind.Utc).AddTicks(3434), new DateTime(2022, 6, 2, 5, 52, 10, 555, DateTimeKind.Utc).AddTicks(3442), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3365"), 0, 200m, new DateTime(2022, 6, 2, 5, 52, 10, 555, DateTimeKind.Utc).AddTicks(3440), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3365"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3365") },
                    { 45, new DateTime(2022, 6, 2, 5, 52, 10, 544, DateTimeKind.Utc).AddTicks(6632), new DateTime(2022, 6, 2, 5, 52, 10, 544, DateTimeKind.Utc).AddTicks(6629), new DateTime(2022, 6, 2, 5, 52, 10, 544, DateTimeKind.Utc).AddTicks(6635), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3364"), 0, 200m, new DateTime(2022, 6, 2, 5, 52, 10, 544, DateTimeKind.Utc).AddTicks(6633), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3364"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3364") },
                    { 44, new DateTime(2022, 6, 2, 5, 52, 10, 533, DateTimeKind.Utc).AddTicks(9381), new DateTime(2022, 6, 2, 5, 52, 10, 533, DateTimeKind.Utc).AddTicks(9379), new DateTime(2022, 6, 2, 5, 52, 10, 533, DateTimeKind.Utc).AddTicks(9384), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3363"), 0, 200m, new DateTime(2022, 6, 2, 5, 52, 10, 533, DateTimeKind.Utc).AddTicks(9382), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3363"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3363") },
                    { 43, new DateTime(2022, 6, 2, 5, 52, 10, 523, DateTimeKind.Utc).AddTicks(346), new DateTime(2022, 6, 2, 5, 52, 10, 523, DateTimeKind.Utc).AddTicks(343), new DateTime(2022, 6, 2, 5, 52, 10, 523, DateTimeKind.Utc).AddTicks(349), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3362"), 0, 200m, new DateTime(2022, 6, 2, 5, 52, 10, 523, DateTimeKind.Utc).AddTicks(347), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3362"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3362") },
                    { 51, new DateTime(2022, 6, 2, 5, 52, 10, 609, DateTimeKind.Utc).AddTicks(1594), new DateTime(2022, 6, 2, 5, 52, 10, 609, DateTimeKind.Utc).AddTicks(1590), new DateTime(2022, 6, 2, 5, 52, 10, 609, DateTimeKind.Utc).AddTicks(1597), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3370"), 0, 200m, new DateTime(2022, 6, 2, 5, 52, 10, 609, DateTimeKind.Utc).AddTicks(1595), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3370"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3370") },
                    { 42, new DateTime(2022, 6, 2, 5, 52, 10, 512, DateTimeKind.Utc).AddTicks(3105), new DateTime(2022, 6, 2, 5, 52, 10, 512, DateTimeKind.Utc).AddTicks(3096), new DateTime(2022, 6, 2, 5, 52, 10, 512, DateTimeKind.Utc).AddTicks(3108), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3361"), 0, 200m, new DateTime(2022, 6, 2, 5, 52, 10, 512, DateTimeKind.Utc).AddTicks(3106), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3361"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3361") },
                    { 40, new DateTime(2022, 6, 2, 5, 52, 10, 490, DateTimeKind.Utc).AddTicks(9358), new DateTime(2022, 6, 2, 5, 52, 10, 490, DateTimeKind.Utc).AddTicks(9356), new DateTime(2022, 6, 2, 5, 52, 10, 490, DateTimeKind.Utc).AddTicks(9360), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"), 0, 200m, new DateTime(2022, 6, 2, 5, 52, 10, 490, DateTimeKind.Utc).AddTicks(9359), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359") },
                    { 39, new DateTime(2022, 6, 2, 5, 52, 10, 480, DateTimeKind.Utc).AddTicks(4624), new DateTime(2022, 6, 2, 5, 52, 10, 480, DateTimeKind.Utc).AddTicks(4621), new DateTime(2022, 6, 2, 5, 52, 10, 480, DateTimeKind.Utc).AddTicks(4627), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"), 0, 200m, new DateTime(2022, 6, 2, 5, 52, 10, 480, DateTimeKind.Utc).AddTicks(4626), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358") },
                    { 38, new DateTime(2022, 6, 2, 5, 52, 10, 467, DateTimeKind.Utc).AddTicks(2289), new DateTime(2022, 6, 2, 5, 52, 10, 467, DateTimeKind.Utc).AddTicks(2283), new DateTime(2022, 6, 2, 5, 52, 10, 467, DateTimeKind.Utc).AddTicks(2296), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"), 0, 200m, new DateTime(2022, 6, 2, 5, 52, 10, 467, DateTimeKind.Utc).AddTicks(2293), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357") },
                    { 37, new DateTime(2022, 6, 2, 5, 52, 10, 455, DateTimeKind.Utc).AddTicks(5448), new DateTime(2022, 6, 2, 5, 52, 10, 455, DateTimeKind.Utc).AddTicks(5445), new DateTime(2022, 6, 2, 5, 52, 10, 455, DateTimeKind.Utc).AddTicks(5451), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"), 0, 200m, new DateTime(2022, 6, 2, 5, 52, 10, 455, DateTimeKind.Utc).AddTicks(5450), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356") },
                    { 36, new DateTime(2022, 6, 2, 5, 52, 10, 444, DateTimeKind.Utc).AddTicks(9687), new DateTime(2022, 6, 2, 5, 52, 10, 444, DateTimeKind.Utc).AddTicks(9682), new DateTime(2022, 6, 2, 5, 52, 10, 444, DateTimeKind.Utc).AddTicks(9690), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"), 0, 200m, new DateTime(2022, 6, 2, 5, 52, 10, 444, DateTimeKind.Utc).AddTicks(9688), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355") },
                    { 35, new DateTime(2022, 6, 2, 5, 52, 10, 432, DateTimeKind.Utc).AddTicks(4869), new DateTime(2022, 6, 2, 5, 52, 10, 432, DateTimeKind.Utc).AddTicks(4867), new DateTime(2022, 6, 2, 5, 52, 10, 432, DateTimeKind.Utc).AddTicks(4872), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"), 0, 200m, new DateTime(2022, 6, 2, 5, 52, 10, 432, DateTimeKind.Utc).AddTicks(4871), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354") },
                    { 34, new DateTime(2022, 6, 2, 5, 52, 10, 421, DateTimeKind.Utc).AddTicks(9779), new DateTime(2022, 6, 2, 5, 52, 10, 421, DateTimeKind.Utc).AddTicks(9776), new DateTime(2022, 6, 2, 5, 52, 10, 421, DateTimeKind.Utc).AddTicks(9782), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"), 0, 200m, new DateTime(2022, 6, 2, 5, 52, 10, 421, DateTimeKind.Utc).AddTicks(9781), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353") },
                    { 33, new DateTime(2022, 6, 2, 5, 52, 10, 411, DateTimeKind.Utc).AddTicks(3749), new DateTime(2022, 6, 2, 5, 52, 10, 411, DateTimeKind.Utc).AddTicks(3745), new DateTime(2022, 6, 2, 5, 52, 10, 411, DateTimeKind.Utc).AddTicks(3752), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"), 0, 200m, new DateTime(2022, 6, 2, 5, 52, 10, 411, DateTimeKind.Utc).AddTicks(3750), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352") },
                    { 41, new DateTime(2022, 6, 2, 5, 52, 10, 501, DateTimeKind.Utc).AddTicks(5858), new DateTime(2022, 6, 2, 5, 52, 10, 501, DateTimeKind.Utc).AddTicks(5851), new DateTime(2022, 6, 2, 5, 52, 10, 501, DateTimeKind.Utc).AddTicks(5861), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"), 0, 200m, new DateTime(2022, 6, 2, 5, 52, 10, 501, DateTimeKind.Utc).AddTicks(5859), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360") },
                    { 52, new DateTime(2022, 6, 2, 5, 52, 10, 619, DateTimeKind.Utc).AddTicks(7322), new DateTime(2022, 6, 2, 5, 52, 10, 619, DateTimeKind.Utc).AddTicks(7319), new DateTime(2022, 6, 2, 5, 52, 10, 619, DateTimeKind.Utc).AddTicks(7325), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3371"), 0, 200m, new DateTime(2022, 6, 2, 5, 52, 10, 619, DateTimeKind.Utc).AddTicks(7323), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3371"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3371") }
                });

            migrationBuilder.InsertData(
                table: "Booking_Details",
                columns: new[] { "Id", "BookingId", "Created_at", "Created_by", "Deleted_at", "Deleted_by", "DentistId", "KeyTime", "Note", "ServiceId", "Status", "Updated_at", "Updated_by" },
                values: new object[,]
                {
                    { 94, 32, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8056), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3341"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8058), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3341"), 41, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8057), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3341") },
                    { 126, 42, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8953), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8955), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"), 51, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8954), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351") },
                    { 127, 43, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8977), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8980), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"), 52, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8979), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352") },
                    { 128, 43, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8999), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9001), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"), 52, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9000), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352") },
                    { 129, 43, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9020), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9023), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"), 52, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9022), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352") },
                    { 130, 44, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9045), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9047), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"), 53, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9046), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353") },
                    { 131, 44, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9067), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9069), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"), 53, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9068), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353") },
                    { 132, 44, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9088), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9090), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"), 53, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9089), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353") },
                    { 133, 45, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9164), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9166), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"), 54, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9165), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354") },
                    { 134, 45, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9186), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9188), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"), 54, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9187), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354") },
                    { 135, 45, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9207), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9210), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"), 54, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9208), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354") },
                    { 136, 46, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9229), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9232), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"), 55, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9230), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355") },
                    { 137, 46, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9251), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9253), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"), 55, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9252), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355") },
                    { 125, 42, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8880), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8882), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"), 51, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8881), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351") },
                    { 138, 46, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9272), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9275), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"), 55, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9273), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355") },
                    { 140, 47, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9315), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9317), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"), 56, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9316), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356") },
                    { 141, 47, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9335), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9338), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"), 56, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9337), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356") },
                    { 142, 48, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9460), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9463), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"), 57, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9461), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357") },
                    { 143, 48, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9483), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9486), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"), 57, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9484), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357") },
                    { 144, 48, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9505), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9507), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"), 57, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9506), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357") },
                    { 145, 49, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9526), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9528), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"), 58, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9527), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358") },
                    { 146, 49, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9547), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9550), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"), 58, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9549), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358") },
                    { 147, 49, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9569), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9571), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"), 58, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9570), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358") },
                    { 148, 50, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9590), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9592), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"), 59, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9591), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359") },
                    { 149, 50, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9611), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9613), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"), 59, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9612), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359") },
                    { 150, 50, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9684), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9686), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"), 59, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9685), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359") },
                    { 151, 51, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9710), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9713), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"), 60, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9711), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360") },
                    { 139, 47, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9294), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9296), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"), 56, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9295), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356") },
                    { 124, 42, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8859), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8862), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"), 51, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8860), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351") },
                    { 123, 41, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8838), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3350"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8840), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3350"), 50, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8839), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3350") },
                    { 122, 41, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8817), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3350"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8819), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3350"), 50, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8818), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3350") },
                    { 95, 32, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8077), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3341"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8079), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3341"), 41, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8078), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3341") },
                    { 96, 32, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8098), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3341"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8101), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3341"), 41, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8100), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3341") },
                    { 97, 33, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8120), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3342"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8122), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3342"), 42, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8121), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3342") },
                    { 98, 33, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8141), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3342"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8143), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3342"), 42, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8142), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3342") },
                    { 99, 33, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8162), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3342"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8164), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3342"), 42, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8163), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3342") },
                    { 100, 34, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8238), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3343"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8240), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3343"), 43, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8239), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3343") },
                    { 101, 34, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8260), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3343"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8262), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3343"), 43, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8261), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3343") },
                    { 102, 34, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8281), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3343"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8283), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3343"), 43, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8282), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3343") },
                    { 103, 35, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8302), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3344"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8305), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3344"), 44, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8303), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3344") },
                    { 104, 35, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8323), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3344"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8325), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3344"), 44, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8324), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3344") },
                    { 105, 35, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8344), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3344"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8346), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3344"), 44, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8345), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3344") }
                });

            migrationBuilder.InsertData(
                table: "Booking_Details",
                columns: new[] { "Id", "BookingId", "Created_at", "Created_by", "Deleted_at", "Deleted_by", "DentistId", "KeyTime", "Note", "ServiceId", "Status", "Updated_at", "Updated_by" },
                values: new object[,]
                {
                    { 106, 36, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8365), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3345"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8368), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3345"), 45, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8367), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3345") },
                    { 107, 36, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8386), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3345"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8389), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3345"), 45, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8387), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3345") },
                    { 108, 36, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8407), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3345"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8409), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3345"), 45, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8408), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3345") },
                    { 109, 37, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8485), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3346"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8487), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3346"), 46, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8486), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3346") },
                    { 110, 37, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8506), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3346"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8509), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3346"), 46, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8507), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3346") },
                    { 111, 37, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8528), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3346"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8530), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3346"), 46, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8529), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3346") },
                    { 112, 38, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8549), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3347"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8552), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3347"), 47, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8551), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3347") },
                    { 113, 38, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8571), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3347"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8573), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3347"), 47, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8572), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3347") },
                    { 114, 38, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8591), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3347"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8594), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3347"), 47, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8592), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3347") },
                    { 115, 39, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8612), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3348"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8615), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3348"), 48, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8614), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3348") },
                    { 116, 39, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8633), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3348"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8636), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3348"), 48, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8634), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3348") },
                    { 117, 39, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8706), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3348"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8708), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3348"), 48, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8707), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3348") },
                    { 118, 40, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8730), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3349"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8733), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3349"), 49, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8732), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3349") },
                    { 119, 40, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8752), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3349"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8755), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3349"), 49, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8754), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3349") },
                    { 120, 40, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8774), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3349"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8776), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3349"), 49, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8775), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3349") },
                    { 121, 41, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8796), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3350"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8798), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3350"), 50, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(8797), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3350") },
                    { 152, 51, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9732), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9734), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"), 60, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9733), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360") },
                    { 153, 51, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9754), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"), new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9756), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"), 60, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 2, 5, 52, 10, 620, DateTimeKind.Utc).AddTicks(9755), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_Details_BookingId",
                table: "Booking_Details",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_Details_DentistId",
                table: "Booking_Details",
                column: "DentistId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_Details_ServiceId",
                table: "Booking_Details",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_UserId",
                table: "Bookings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Dentists_ClinicId",
                table: "Dentists",
                column: "ClinicId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceDentists_DentistId",
                table: "ServiceDentists",
                column: "DentistId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_DiscountId",
                table: "Services",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_DentistId",
                table: "Users",
                column: "DentistId",
                unique: true,
                filter: "[DentistId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Booking_Details");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "ServiceDentists");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "Dentists");

            migrationBuilder.DropTable(
                name: "Clinics");
        }
    }
}
