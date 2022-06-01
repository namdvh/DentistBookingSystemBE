using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DentisBooking.Data.Migrations
{
    public partial class update4 : Migration
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
                    DiscountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_Discounts_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "Discounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    { 1, "TestAddress1", new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(2750), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e51"), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(3286), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e51"), "TestDescirption1", "TestClinic1", 868644651, 0, new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(3004), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e51") },
                    { 2, "TestAddress2", new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(4470), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e52"), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(4476), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e52"), "TestDescirption2", "TestClinic2", 868644651, 0, new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(4474), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e52") },
                    { 3, "TestAddress3", new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(4505), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e53"), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(4507), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e53"), "TestDescirption3", "TestClinic3", 868644651, 0, new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(4506), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e53") },
                    { 4, "TestAddress4", new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(4528), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e54"), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(4530), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e54"), "TestDescirption4", "TestClinic4", 868644651, 0, new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(4529), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e54") },
                    { 5, "TestAddress5", new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(4550), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e55"), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(4552), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e55"), "TestDescirption5", "TestClinic5", 868644651, 0, new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(4551), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e55") }
                });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "Amount", "ApplyForAll", "Created_at", "Created_by", "Deleted_at", "Deleted_by", "Description", "EndDate", "Percent", "StartDate", "Title", "Updated_at", "Updated_by", "status" },
                values: new object[,]
                {
                    { 4, 10m, true, new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(1082), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e54"), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(1083), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e54"), "TestDescirption4", new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(1080), 5f, new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(1079), "TestTitle4", new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(1083), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e54"), 0 },
                    { 3, 10m, true, new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(1055), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e53"), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(1057), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e53"), "TestDescirption3", new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(1054), 5f, new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(1052), "TestTitle3", new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(1056), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e53"), 0 },
                    { 5, 10m, true, new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(1104), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e55"), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(1105), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e55"), "TestDescirption5", new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(1102), 5f, new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(1101), "TestTitle5", new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(1105), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e55"), 0 },
                    { 1, 10m, true, new DateTime(2022, 6, 1, 12, 35, 47, 268, DateTimeKind.Local).AddTicks(1162), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e51"), new DateTime(2022, 6, 1, 12, 35, 47, 268, DateTimeKind.Local).AddTicks(1899), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e51"), "TestDescirption1", new DateTime(2022, 6, 1, 12, 35, 47, 267, DateTimeKind.Local).AddTicks(9073), 5f, new DateTime(2022, 6, 1, 12, 35, 47, 267, DateTimeKind.Local).AddTicks(4578), "TestTitle1", new DateTime(2022, 6, 1, 12, 35, 47, 268, DateTimeKind.Local).AddTicks(1403), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e51"), 0 },
                    { 2, 10m, true, new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(953), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e52"), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(955), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e52"), "TestDescirption2", new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(949), 5f, new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(943), "TestTitle2", new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(953), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e52"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), "970269c7-fe3c-4230-abf1-75dce86711cc", "Admin", "Admin", "ADMIN" },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"), "8f8e2fa5-a932-4136-b67f-f0dca40e6364", "User", "User", "USER" }
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
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2632"), 0, "15c00930-1832-44e5-94fc-6afe37eba0d6", new DateTime(2022, 6, 1, 5, 35, 47, 351, DateTimeKind.Utc).AddTicks(3773), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2632"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 351, DateTimeKind.Utc).AddTicks(3778), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2632"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEGtcvYLWNkXNNEtzaQpqlzVQwa5nOSowCn/BJpAyPKYiHqa1tWiqj5a0JyxueLsO1A==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 351, DateTimeKind.Utc).AddTicks(3777), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2632"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2631"), 0, "b6659425-c50f-4f66-870c-c1391209ec9d", new DateTime(2022, 6, 1, 5, 35, 47, 345, DateTimeKind.Utc).AddTicks(5309), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2631"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 345, DateTimeKind.Utc).AddTicks(5313), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2631"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEDP1Xz4pI24GOitRykU588M8GpZrjYzFUo1502PfaudLFGmVkiXMjvsMTVZx7BSCrQ==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 345, DateTimeKind.Utc).AddTicks(5312), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2631"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2630"), 0, "f39f66b1-b4a3-49dd-b32b-79840ed32d7c", new DateTime(2022, 6, 1, 5, 35, 47, 339, DateTimeKind.Utc).AddTicks(7572), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2630"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 339, DateTimeKind.Utc).AddTicks(7578), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2630"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEMgbl51gUD4D5f2vodpZdMTbAfA/UY8lwzUPZ4gCJFQV7YnTV07OBG5LrprWCAjnbA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 339, DateTimeKind.Utc).AddTicks(7576), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2630"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2629"), 0, "d893b944-987f-466b-8511-aef58719dac4", new DateTime(2022, 6, 1, 5, 35, 47, 333, DateTimeKind.Utc).AddTicks(5293), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2629"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 333, DateTimeKind.Utc).AddTicks(5301), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2629"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEL+F9ENcdQcjifvgfNHaGvhFzvkAS4lccsU1fsoJ7t0NoeXTAL45DdVw9dlQRMjKWg==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 333, DateTimeKind.Utc).AddTicks(5299), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2629"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2628"), 0, "93a625ad-6555-4ce5-b540-17f1061201af", new DateTime(2022, 6, 1, 5, 35, 47, 327, DateTimeKind.Utc).AddTicks(5488), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2628"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 327, DateTimeKind.Utc).AddTicks(5498), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2628"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEAhgoNjnpgQwqLk150oQsKjKFEhOj7N2rkZ9h7P3UZBn7ME2Nf3Yon/e7AyNKLxAlQ==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 327, DateTimeKind.Utc).AddTicks(5495), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2628"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2626"), 0, "af317c5e-bf46-4736-b9c6-2066ccff5fd6", new DateTime(2022, 6, 1, 5, 35, 47, 315, DateTimeKind.Utc).AddTicks(5636), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2626"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 315, DateTimeKind.Utc).AddTicks(5638), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2626"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEAWM+HMy80LwO1IZqQwVEHtgUt4JUL4mqIh65gzBiC/5N9wKT44cBGN7SoYgyPb/Vg==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 315, DateTimeKind.Utc).AddTicks(5637), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2626"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2625"), 0, "c8537ae2-12e0-48ac-b916-e3514dcffb8b", new DateTime(2022, 6, 1, 5, 35, 47, 309, DateTimeKind.Utc).AddTicks(8586), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2625"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 309, DateTimeKind.Utc).AddTicks(8593), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2625"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEC1gFNlxm+pxVinSQYOYzSYlFQx1INHfDvrs5+MbvTlCIET/UWo539Hnf1VdnBU1aQ==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 309, DateTimeKind.Utc).AddTicks(8591), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2625"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2624"), 0, "e3498411-1bf0-4c8a-8a60-9fd2ce95bc54", new DateTime(2022, 6, 1, 5, 35, 47, 304, DateTimeKind.Utc).AddTicks(1117), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2624"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 304, DateTimeKind.Utc).AddTicks(1118), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2624"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEI83g45UBA4cgFDqyYohiqwQl6j0nUvDaf6NktSzX3CzlYWSj+FR09pzDbvd9MVYxQ==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 304, DateTimeKind.Utc).AddTicks(1118), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2624"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2623"), 0, "d3f8baee-b16b-4faa-946b-b5f674af7350", new DateTime(2022, 6, 1, 5, 35, 47, 298, DateTimeKind.Utc).AddTicks(4497), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2623"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 298, DateTimeKind.Utc).AddTicks(4499), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2623"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAED2XsAnlzensRMCus1Fxo37TFlXnvwmD5eyLUO5s2yQ0bzT+stWJYABWcRdgNElOlA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 298, DateTimeKind.Utc).AddTicks(4498), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2623"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2622"), 0, "445fcfec-1072-4c81-8252-8d4f6b89941a", new DateTime(2022, 6, 1, 5, 35, 47, 292, DateTimeKind.Utc).AddTicks(7609), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2622"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 292, DateTimeKind.Utc).AddTicks(7615), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2622"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEDNhtqgEXNBBX+rQLjSbaW8k6gj1OZd9wcTgxf3UEDzzJHQAC/StNR4aVabYE++WbA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 292, DateTimeKind.Utc).AddTicks(7614), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2622"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2621"), 0, "f87af76b-9c33-4aaf-a694-d2076805c806", new DateTime(2022, 6, 1, 5, 35, 47, 286, DateTimeKind.Utc).AddTicks(9515), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2621"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 286, DateTimeKind.Utc).AddTicks(9518), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2621"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEAuikU3HbAX5Xtul1yx4cxvGFK9/JbIjouAp//JjY+Adm5DPvz2MOaSVylVrgC0rrQ==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 286, DateTimeKind.Utc).AddTicks(9517), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2621"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2620"), 0, "37f2d396-4629-4561-a02d-5f865307d348", new DateTime(2022, 6, 1, 5, 35, 47, 280, DateTimeKind.Utc).AddTicks(4725), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2620"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 280, DateTimeKind.Utc).AddTicks(5249), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2620"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAELZbtGAe36QbudN4JTFUtVJ4lWUntSstrqgk0HzN6RseZLY0y6e7XIESGT5n/YvJLw==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 280, DateTimeKind.Utc).AddTicks(4968), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2620"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2627"), 0, "8309297c-8253-4912-987b-b5a3ca944704", new DateTime(2022, 6, 1, 5, 35, 47, 321, DateTimeKind.Utc).AddTicks(5323), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2627"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 321, DateTimeKind.Utc).AddTicks(5339), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2627"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEMTqiOdDiob4NErXbl0hUtUscLx1d4N4kuAC2KVGgiTYJBw4HcoPEiibgyAZT2lbLw==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 321, DateTimeKind.Utc).AddTicks(5337), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2627"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2633"), 0, "a239d73a-35d4-4a46-be2b-dc7b41dbc2a7", new DateTime(2022, 6, 1, 5, 35, 47, 357, DateTimeKind.Utc).AddTicks(2031), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2633"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 357, DateTimeKind.Utc).AddTicks(2034), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2633"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEGn3fWLtZlSY9sUZkKnxDTJ9/ekJiz1nQMOQwCHZHso2YXM9AdKOLVn+svwb3/LzZQ==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 357, DateTimeKind.Utc).AddTicks(2033), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2633"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2636"), 0, "60f015d9-1d4e-404c-afae-8f9a4c69ebab", new DateTime(2022, 6, 1, 5, 35, 47, 374, DateTimeKind.Utc).AddTicks(3763), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2636"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 374, DateTimeKind.Utc).AddTicks(3764), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2636"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEHk7oxjqeZswaIz51XE5mhzfQ/lrDHZ+MK41M/OJSwp7HRtmUN7YZe/eP6lPVdikZA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 374, DateTimeKind.Utc).AddTicks(3764), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2636"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2635"), 0, "b166e557-ad18-44a6-bf44-6feeb77f9e47", new DateTime(2022, 6, 1, 5, 35, 47, 368, DateTimeKind.Utc).AddTicks(6914), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2635"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 368, DateTimeKind.Utc).AddTicks(6916), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2635"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEMFYtX/I3YwBGMVjC3NR2pWSVnJ3Tyg9fJ2CNOpMQ+Zes5xLuMK4qfZhB2NfMdJuwQ==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 368, DateTimeKind.Utc).AddTicks(6915), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2635"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2637"), 0, "0ed28e77-cd2d-429e-8235-e2442765d65e", new DateTime(2022, 6, 1, 5, 35, 47, 380, DateTimeKind.Utc).AddTicks(411), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2637"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 380, DateTimeKind.Utc).AddTicks(413), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2637"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEF3+3wdp0YEqxnkbsqflQOvkFiUDH5H7+OuL9yUbyJ3Ym6KIHeeZ2288HjlucChXEQ==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 380, DateTimeKind.Utc).AddTicks(412), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2637"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2638"), 0, "7973a62f-e875-4f8d-acc9-4ab3f997ed0d", new DateTime(2022, 6, 1, 5, 35, 47, 385, DateTimeKind.Utc).AddTicks(7958), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2638"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 385, DateTimeKind.Utc).AddTicks(7965), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2638"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEHr8VbAG3p9vcysGrFiHarHzwl+kuZVMLBG7We7vOja+m4EdWx8Yi3M0hSYqW4qnTQ==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 385, DateTimeKind.Utc).AddTicks(7964), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2638"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2640"), 0, "f70aebae-d91c-4c4d-86d6-a318e9289c4f", new DateTime(2022, 6, 1, 5, 35, 47, 397, DateTimeKind.Utc).AddTicks(1694), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2640"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 397, DateTimeKind.Utc).AddTicks(1695), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2640"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEERMVPuxpxhiwrL6XcbUSyQY/iPacmFJm+yVaROL0uObX8S80NyKwp3ncRFjR3GczA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 397, DateTimeKind.Utc).AddTicks(1694), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2640"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2641"), 0, "7b4de78b-7b9a-4466-89d4-dd975b2c60aa", new DateTime(2022, 6, 1, 5, 35, 47, 403, DateTimeKind.Utc).AddTicks(1098), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2641"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 403, DateTimeKind.Utc).AddTicks(1105), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2641"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEDm+ju/3XfIh/D+hHLwUfKzeKZqQXGyD+iNdL5OXKYmkoNrLnn2Xr7Xfn50cxjUVyg==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 403, DateTimeKind.Utc).AddTicks(1103), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2641"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Created_at", "Created_by", "DOB", "Deleted_at", "Deleted_by", "DentistId", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshTokenExpiryTime", "SecurityStamp", "Status", "Token", "TwoFactorEnabled", "Updated_at", "Updated_by", "UserName" },
                values: new object[,]
                {
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2642"), 0, "d11dd64c-eb8c-4cb1-8605-5ab48c183068", new DateTime(2022, 6, 1, 5, 35, 47, 408, DateTimeKind.Utc).AddTicks(8044), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2642"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 408, DateTimeKind.Utc).AddTicks(8046), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2642"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEFs5e47HEstn6r/z2ThEcjE21cAop1jlBTYHF67FCRT20rtOalbij+/O7yiC6tOnXg==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 408, DateTimeKind.Utc).AddTicks(8045), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2642"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2643"), 0, "adba6416-5178-4944-8b29-2654c45251e4", new DateTime(2022, 6, 1, 5, 35, 47, 414, DateTimeKind.Utc).AddTicks(5939), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2643"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 414, DateTimeKind.Utc).AddTicks(5948), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2643"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEN+hzY/RzQnM2Ah3HWt+PizzX8H5gx4BEv4vOIup8FPLZCWA7wwWOjILB13j2ahLjA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 414, DateTimeKind.Utc).AddTicks(5946), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2643"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2644"), 0, "4c779462-0235-4e79-9d54-d0035a497c3d", new DateTime(2022, 6, 1, 5, 35, 47, 420, DateTimeKind.Utc).AddTicks(4532), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2644"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 420, DateTimeKind.Utc).AddTicks(4535), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2644"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEC2NSwizUf9nLQhsnEYZEntfhJzQs125CQ1XH8E59hrU6lOI3U4TzqxZ4H1NN9Uh9w==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 420, DateTimeKind.Utc).AddTicks(4534), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2644"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2645"), 0, "b1ddf45d-7db5-470d-8721-bb4411376beb", new DateTime(2022, 6, 1, 5, 35, 47, 426, DateTimeKind.Utc).AddTicks(4671), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2645"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 426, DateTimeKind.Utc).AddTicks(4680), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2645"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEPBH6l2miFOHY99f6IZ0opMrTIvjCjpuvkt0Evt46dMFsxeH5Lyh7GUBXytsqLTLJw==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 426, DateTimeKind.Utc).AddTicks(4678), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2645"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2646"), 0, "b709c650-5091-4ae1-a160-96bff41f0eb2", new DateTime(2022, 6, 1, 5, 35, 47, 432, DateTimeKind.Utc).AddTicks(9074), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2646"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 432, DateTimeKind.Utc).AddTicks(9095), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2646"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEKI5+wdcDkxupv5kwP34f/5GHKVbZ8lC6nCLOBn1IGwqmvq41tm+85mVhO0VGwqc7w==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 432, DateTimeKind.Utc).AddTicks(9088), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2646"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2647"), 0, "1df6c0c4-d61d-462c-9419-d30283fc6c63", new DateTime(2022, 6, 1, 5, 35, 47, 440, DateTimeKind.Utc).AddTicks(149), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2647"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 440, DateTimeKind.Utc).AddTicks(158), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2647"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEP8xDFq9eNpLDRz39dKMaPHBhJ1bpFsGjpxiwJbsBMc+uH1uVqerxCfUKyeLqhBsnA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 440, DateTimeKind.Utc).AddTicks(156), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2647"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2648"), 0, "39e1c0cd-58cb-4d1b-887a-176348529d00", new DateTime(2022, 6, 1, 5, 35, 47, 445, DateTimeKind.Utc).AddTicks(9397), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2648"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 445, DateTimeKind.Utc).AddTicks(9411), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2648"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAELu+Grabg/Hsfm8XjLYiGj9ySPYueIfdoPELwaeYGHnu5PkgqwzPbG8356AmiP7IRw==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 445, DateTimeKind.Utc).AddTicks(9408), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2648"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2649"), 0, "0d0f09df-139d-4201-b42e-eae81807b950", new DateTime(2022, 6, 1, 5, 35, 47, 451, DateTimeKind.Utc).AddTicks(9484), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2649"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 451, DateTimeKind.Utc).AddTicks(9492), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2649"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEDiuG7OFMT4nOH2ynNYYz2tL1XJmaOb+ypQ0IJyeDg+Qndyh2OkJxDSeq4psIvw77A==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 451, DateTimeKind.Utc).AddTicks(9489), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2649"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2650"), 0, "6612d53b-ded3-4959-a020-01db0ee19499", new DateTime(2022, 6, 1, 5, 35, 47, 458, DateTimeKind.Utc).AddTicks(4801), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2650"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 458, DateTimeKind.Utc).AddTicks(4818), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2650"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEAMiOp+61hro86eYajUfkWC+d1oVhKUCAXzJYFQ5osUoglEtfExiwwVdO9Q0WAGltg==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 458, DateTimeKind.Utc).AddTicks(4815), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2650"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2634"), 0, "004c47b7-450c-4356-bdcf-e411a65cd09c", new DateTime(2022, 6, 1, 5, 35, 47, 362, DateTimeKind.Utc).AddTicks(9851), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2634"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 362, DateTimeKind.Utc).AddTicks(9855), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2634"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEIpYTzcF7JX3fNgHieN+0/F83CbKIsF4yvHv0uXebOmvFRIoOFmwUhyvIFFbKtS7CQ==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 362, DateTimeKind.Utc).AddTicks(9853), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2634"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2639"), 0, "44e1ad09-e22e-4d5f-a78b-a5543f18e586", new DateTime(2022, 6, 1, 5, 35, 47, 391, DateTimeKind.Utc).AddTicks(5012), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2639"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 391, DateTimeKind.Utc).AddTicks(5013), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2639"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEGWDjapp2z9L4U90fJKbFqSelZbmWcTaG53/waX76/daN1LcXsqhUSYVuiFO6HtjqA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 391, DateTimeKind.Utc).AddTicks(5013), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2639"), null }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "Created_at", "Date", "Deleted_at", "Deleted_by", "Status", "Total", "Updated_at", "Updated_by", "UserId" },
                values: new object[,]
                {
                    { 31, new DateTime(2022, 6, 1, 5, 35, 47, 458, DateTimeKind.Utc).AddTicks(5192), new DateTime(2022, 6, 1, 5, 35, 47, 458, DateTimeKind.Utc).AddTicks(5189), new DateTime(2022, 6, 1, 5, 35, 47, 458, DateTimeKind.Utc).AddTicks(5193), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2650"), 0, 100m, new DateTime(2022, 6, 1, 5, 35, 47, 458, DateTimeKind.Utc).AddTicks(5192), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2650"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2650") },
                    { 30, new DateTime(2022, 6, 1, 5, 35, 47, 451, DateTimeKind.Utc).AddTicks(9916), new DateTime(2022, 6, 1, 5, 35, 47, 451, DateTimeKind.Utc).AddTicks(9913), new DateTime(2022, 6, 1, 5, 35, 47, 451, DateTimeKind.Utc).AddTicks(9918), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2649"), 0, 100m, new DateTime(2022, 6, 1, 5, 35, 47, 451, DateTimeKind.Utc).AddTicks(9917), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2649"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2649") },
                    { 1, new DateTime(2022, 6, 1, 5, 35, 47, 280, DateTimeKind.Utc).AddTicks(7952), new DateTime(2022, 6, 1, 5, 35, 47, 280, DateTimeKind.Utc).AddTicks(7225), new DateTime(2022, 6, 1, 5, 35, 47, 280, DateTimeKind.Utc).AddTicks(8411), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2620"), 0, 100m, new DateTime(2022, 6, 1, 5, 35, 47, 280, DateTimeKind.Utc).AddTicks(8171), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2620"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2620") },
                    { 2, new DateTime(2022, 6, 1, 5, 35, 47, 286, DateTimeKind.Utc).AddTicks(9586), new DateTime(2022, 6, 1, 5, 35, 47, 286, DateTimeKind.Utc).AddTicks(9585), new DateTime(2022, 6, 1, 5, 35, 47, 286, DateTimeKind.Utc).AddTicks(9588), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2621"), 0, 100m, new DateTime(2022, 6, 1, 5, 35, 47, 286, DateTimeKind.Utc).AddTicks(9587), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2621"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2621") },
                    { 3, new DateTime(2022, 6, 1, 5, 35, 47, 292, DateTimeKind.Utc).AddTicks(7795), new DateTime(2022, 6, 1, 5, 35, 47, 292, DateTimeKind.Utc).AddTicks(7794), new DateTime(2022, 6, 1, 5, 35, 47, 292, DateTimeKind.Utc).AddTicks(7797), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2622"), 0, 100m, new DateTime(2022, 6, 1, 5, 35, 47, 292, DateTimeKind.Utc).AddTicks(7796), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2622"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2622") },
                    { 4, new DateTime(2022, 6, 1, 5, 35, 47, 298, DateTimeKind.Utc).AddTicks(4530), new DateTime(2022, 6, 1, 5, 35, 47, 298, DateTimeKind.Utc).AddTicks(4529), new DateTime(2022, 6, 1, 5, 35, 47, 298, DateTimeKind.Utc).AddTicks(4531), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2623"), 0, 100m, new DateTime(2022, 6, 1, 5, 35, 47, 298, DateTimeKind.Utc).AddTicks(4530), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2623"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2623") },
                    { 5, new DateTime(2022, 6, 1, 5, 35, 47, 304, DateTimeKind.Utc).AddTicks(1166), new DateTime(2022, 6, 1, 5, 35, 47, 304, DateTimeKind.Utc).AddTicks(1165), new DateTime(2022, 6, 1, 5, 35, 47, 304, DateTimeKind.Utc).AddTicks(1167), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2624"), 0, 100m, new DateTime(2022, 6, 1, 5, 35, 47, 304, DateTimeKind.Utc).AddTicks(1166), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2624"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2624") },
                    { 6, new DateTime(2022, 6, 1, 5, 35, 47, 309, DateTimeKind.Utc).AddTicks(8864), new DateTime(2022, 6, 1, 5, 35, 47, 309, DateTimeKind.Utc).AddTicks(8862), new DateTime(2022, 6, 1, 5, 35, 47, 309, DateTimeKind.Utc).AddTicks(8866), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2625"), 0, 100m, new DateTime(2022, 6, 1, 5, 35, 47, 309, DateTimeKind.Utc).AddTicks(8865), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2625"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2625") },
                    { 7, new DateTime(2022, 6, 1, 5, 35, 47, 315, DateTimeKind.Utc).AddTicks(5666), new DateTime(2022, 6, 1, 5, 35, 47, 315, DateTimeKind.Utc).AddTicks(5665), new DateTime(2022, 6, 1, 5, 35, 47, 315, DateTimeKind.Utc).AddTicks(5667), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2626"), 0, 100m, new DateTime(2022, 6, 1, 5, 35, 47, 315, DateTimeKind.Utc).AddTicks(5666), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2626"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2626") },
                    { 9, new DateTime(2022, 6, 1, 5, 35, 47, 327, DateTimeKind.Utc).AddTicks(5799), new DateTime(2022, 6, 1, 5, 35, 47, 327, DateTimeKind.Utc).AddTicks(5796), new DateTime(2022, 6, 1, 5, 35, 47, 327, DateTimeKind.Utc).AddTicks(5801), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2628"), 0, 100m, new DateTime(2022, 6, 1, 5, 35, 47, 327, DateTimeKind.Utc).AddTicks(5800), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2628"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2628") },
                    { 10, new DateTime(2022, 6, 1, 5, 35, 47, 333, DateTimeKind.Utc).AddTicks(5667), new DateTime(2022, 6, 1, 5, 35, 47, 333, DateTimeKind.Utc).AddTicks(5663), new DateTime(2022, 6, 1, 5, 35, 47, 333, DateTimeKind.Utc).AddTicks(5669), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2629"), 0, 100m, new DateTime(2022, 6, 1, 5, 35, 47, 333, DateTimeKind.Utc).AddTicks(5668), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2629"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2629") },
                    { 11, new DateTime(2022, 6, 1, 5, 35, 47, 339, DateTimeKind.Utc).AddTicks(7863), new DateTime(2022, 6, 1, 5, 35, 47, 339, DateTimeKind.Utc).AddTicks(7860), new DateTime(2022, 6, 1, 5, 35, 47, 339, DateTimeKind.Utc).AddTicks(7865), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2630"), 0, 100m, new DateTime(2022, 6, 1, 5, 35, 47, 339, DateTimeKind.Utc).AddTicks(7864), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2630"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2630") },
                    { 12, new DateTime(2022, 6, 1, 5, 35, 47, 345, DateTimeKind.Utc).AddTicks(5448), new DateTime(2022, 6, 1, 5, 35, 47, 345, DateTimeKind.Utc).AddTicks(5446), new DateTime(2022, 6, 1, 5, 35, 47, 345, DateTimeKind.Utc).AddTicks(5450), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2631"), 0, 100m, new DateTime(2022, 6, 1, 5, 35, 47, 345, DateTimeKind.Utc).AddTicks(5449), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2631"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2631") },
                    { 13, new DateTime(2022, 6, 1, 5, 35, 47, 351, DateTimeKind.Utc).AddTicks(3967), new DateTime(2022, 6, 1, 5, 35, 47, 351, DateTimeKind.Utc).AddTicks(3964), new DateTime(2022, 6, 1, 5, 35, 47, 351, DateTimeKind.Utc).AddTicks(3969), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2632"), 0, 100m, new DateTime(2022, 6, 1, 5, 35, 47, 351, DateTimeKind.Utc).AddTicks(3968), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2632"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2632") },
                    { 14, new DateTime(2022, 6, 1, 5, 35, 47, 357, DateTimeKind.Utc).AddTicks(2211), new DateTime(2022, 6, 1, 5, 35, 47, 357, DateTimeKind.Utc).AddTicks(2209), new DateTime(2022, 6, 1, 5, 35, 47, 357, DateTimeKind.Utc).AddTicks(2213), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2633"), 0, 100m, new DateTime(2022, 6, 1, 5, 35, 47, 357, DateTimeKind.Utc).AddTicks(2212), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2633"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2633") },
                    { 8, new DateTime(2022, 6, 1, 5, 35, 47, 321, DateTimeKind.Utc).AddTicks(5741), new DateTime(2022, 6, 1, 5, 35, 47, 321, DateTimeKind.Utc).AddTicks(5738), new DateTime(2022, 6, 1, 5, 35, 47, 321, DateTimeKind.Utc).AddTicks(5742), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2627"), 0, 100m, new DateTime(2022, 6, 1, 5, 35, 47, 321, DateTimeKind.Utc).AddTicks(5741), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2627"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2627") },
                    { 16, new DateTime(2022, 6, 1, 5, 35, 47, 368, DateTimeKind.Utc).AddTicks(7085), new DateTime(2022, 6, 1, 5, 35, 47, 368, DateTimeKind.Utc).AddTicks(7084), new DateTime(2022, 6, 1, 5, 35, 47, 368, DateTimeKind.Utc).AddTicks(7087), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2635"), 0, 100m, new DateTime(2022, 6, 1, 5, 35, 47, 368, DateTimeKind.Utc).AddTicks(7086), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2635"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2635") },
                    { 15, new DateTime(2022, 6, 1, 5, 35, 47, 362, DateTimeKind.Utc).AddTicks(9996), new DateTime(2022, 6, 1, 5, 35, 47, 362, DateTimeKind.Utc).AddTicks(9995), new DateTime(2022, 6, 1, 5, 35, 47, 362, DateTimeKind.Utc).AddTicks(9998), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2634"), 0, 100m, new DateTime(2022, 6, 1, 5, 35, 47, 362, DateTimeKind.Utc).AddTicks(9997), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2634"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2634") },
                    { 28, new DateTime(2022, 6, 1, 5, 35, 47, 440, DateTimeKind.Utc).AddTicks(508), new DateTime(2022, 6, 1, 5, 35, 47, 440, DateTimeKind.Utc).AddTicks(505), new DateTime(2022, 6, 1, 5, 35, 47, 440, DateTimeKind.Utc).AddTicks(510), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2647"), 0, 100m, new DateTime(2022, 6, 1, 5, 35, 47, 440, DateTimeKind.Utc).AddTicks(509), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2647"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2647") },
                    { 27, new DateTime(2022, 6, 1, 5, 35, 47, 432, DateTimeKind.Utc).AddTicks(9619), new DateTime(2022, 6, 1, 5, 35, 47, 432, DateTimeKind.Utc).AddTicks(9615), new DateTime(2022, 6, 1, 5, 35, 47, 432, DateTimeKind.Utc).AddTicks(9622), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2646"), 0, 100m, new DateTime(2022, 6, 1, 5, 35, 47, 432, DateTimeKind.Utc).AddTicks(9620), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2646"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2646") },
                    { 26, new DateTime(2022, 6, 1, 5, 35, 47, 426, DateTimeKind.Utc).AddTicks(4899), new DateTime(2022, 6, 1, 5, 35, 47, 426, DateTimeKind.Utc).AddTicks(4896), new DateTime(2022, 6, 1, 5, 35, 47, 426, DateTimeKind.Utc).AddTicks(4901), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2645"), 0, 100m, new DateTime(2022, 6, 1, 5, 35, 47, 426, DateTimeKind.Utc).AddTicks(4900), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2645"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2645") },
                    { 24, new DateTime(2022, 6, 1, 5, 35, 47, 414, DateTimeKind.Utc).AddTicks(6206), new DateTime(2022, 6, 1, 5, 35, 47, 414, DateTimeKind.Utc).AddTicks(6203), new DateTime(2022, 6, 1, 5, 35, 47, 414, DateTimeKind.Utc).AddTicks(6208), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2643"), 0, 100m, new DateTime(2022, 6, 1, 5, 35, 47, 414, DateTimeKind.Utc).AddTicks(6207), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2643"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2643") },
                    { 23, new DateTime(2022, 6, 1, 5, 35, 47, 408, DateTimeKind.Utc).AddTicks(8089), new DateTime(2022, 6, 1, 5, 35, 47, 408, DateTimeKind.Utc).AddTicks(8088), new DateTime(2022, 6, 1, 5, 35, 47, 408, DateTimeKind.Utc).AddTicks(8090), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2642"), 0, 100m, new DateTime(2022, 6, 1, 5, 35, 47, 408, DateTimeKind.Utc).AddTicks(8089), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2642"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2642") },
                    { 25, new DateTime(2022, 6, 1, 5, 35, 47, 420, DateTimeKind.Utc).AddTicks(4672), new DateTime(2022, 6, 1, 5, 35, 47, 420, DateTimeKind.Utc).AddTicks(4670), new DateTime(2022, 6, 1, 5, 35, 47, 420, DateTimeKind.Utc).AddTicks(4673), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2644"), 0, 100m, new DateTime(2022, 6, 1, 5, 35, 47, 420, DateTimeKind.Utc).AddTicks(4672), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2644"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2644") },
                    { 29, new DateTime(2022, 6, 1, 5, 35, 47, 446, DateTimeKind.Utc).AddTicks(589), new DateTime(2022, 6, 1, 5, 35, 47, 446, DateTimeKind.Utc).AddTicks(579), new DateTime(2022, 6, 1, 5, 35, 47, 446, DateTimeKind.Utc).AddTicks(593), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2648"), 0, 100m, new DateTime(2022, 6, 1, 5, 35, 47, 446, DateTimeKind.Utc).AddTicks(591), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2648"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2648") },
                    { 21, new DateTime(2022, 6, 1, 5, 35, 47, 397, DateTimeKind.Utc).AddTicks(1797), new DateTime(2022, 6, 1, 5, 35, 47, 397, DateTimeKind.Utc).AddTicks(1796), new DateTime(2022, 6, 1, 5, 35, 47, 397, DateTimeKind.Utc).AddTicks(1799), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2640"), 0, 100m, new DateTime(2022, 6, 1, 5, 35, 47, 397, DateTimeKind.Utc).AddTicks(1798), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2640"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2640") },
                    { 20, new DateTime(2022, 6, 1, 5, 35, 47, 391, DateTimeKind.Utc).AddTicks(5052), new DateTime(2022, 6, 1, 5, 35, 47, 391, DateTimeKind.Utc).AddTicks(5051), new DateTime(2022, 6, 1, 5, 35, 47, 391, DateTimeKind.Utc).AddTicks(5053), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2639"), 0, 100m, new DateTime(2022, 6, 1, 5, 35, 47, 391, DateTimeKind.Utc).AddTicks(5052), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2639"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2639") },
                    { 19, new DateTime(2022, 6, 1, 5, 35, 47, 385, DateTimeKind.Utc).AddTicks(8166), new DateTime(2022, 6, 1, 5, 35, 47, 385, DateTimeKind.Utc).AddTicks(8164), new DateTime(2022, 6, 1, 5, 35, 47, 385, DateTimeKind.Utc).AddTicks(8168), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2638"), 0, 100m, new DateTime(2022, 6, 1, 5, 35, 47, 385, DateTimeKind.Utc).AddTicks(8167), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2638"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2638") },
                    { 18, new DateTime(2022, 6, 1, 5, 35, 47, 380, DateTimeKind.Utc).AddTicks(448), new DateTime(2022, 6, 1, 5, 35, 47, 380, DateTimeKind.Utc).AddTicks(447), new DateTime(2022, 6, 1, 5, 35, 47, 380, DateTimeKind.Utc).AddTicks(450), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2637"), 0, 100m, new DateTime(2022, 6, 1, 5, 35, 47, 380, DateTimeKind.Utc).AddTicks(449), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2637"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2637") },
                    { 17, new DateTime(2022, 6, 1, 5, 35, 47, 374, DateTimeKind.Utc).AddTicks(3812), new DateTime(2022, 6, 1, 5, 35, 47, 374, DateTimeKind.Utc).AddTicks(3811), new DateTime(2022, 6, 1, 5, 35, 47, 374, DateTimeKind.Utc).AddTicks(3813), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2636"), 0, 100m, new DateTime(2022, 6, 1, 5, 35, 47, 374, DateTimeKind.Utc).AddTicks(3813), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2636"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2636") },
                    { 22, new DateTime(2022, 6, 1, 5, 35, 47, 403, DateTimeKind.Utc).AddTicks(1313), new DateTime(2022, 6, 1, 5, 35, 47, 403, DateTimeKind.Utc).AddTicks(1308), new DateTime(2022, 6, 1, 5, 35, 47, 403, DateTimeKind.Utc).AddTicks(1315), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2641"), 0, 100m, new DateTime(2022, 6, 1, 5, 35, 47, 403, DateTimeKind.Utc).AddTicks(1314), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2641"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2641") }
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
                    { 1, new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(8206), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a1"), new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(8697), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a1"), 1, "testService@gmail.com1", 1m, "testProcedure1", 0, new DateTime(2022, 6, 1, 12, 35, 47, 269, DateTimeKind.Local).AddTicks(8446), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a1") },
                    { 2, new DateTime(2022, 6, 1, 12, 35, 47, 270, DateTimeKind.Local).AddTicks(58), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a2"), new DateTime(2022, 6, 1, 12, 35, 47, 270, DateTimeKind.Local).AddTicks(64), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a2"), 2, "testService@gmail.com2", 2m, "testProcedure2", 0, new DateTime(2022, 6, 1, 12, 35, 47, 270, DateTimeKind.Local).AddTicks(62), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a2") },
                    { 3, new DateTime(2022, 6, 1, 12, 35, 47, 270, DateTimeKind.Local).AddTicks(95), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a3"), new DateTime(2022, 6, 1, 12, 35, 47, 270, DateTimeKind.Local).AddTicks(97), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a3"), 3, "testService@gmail.com3", 3m, "testProcedure3", 0, new DateTime(2022, 6, 1, 12, 35, 47, 270, DateTimeKind.Local).AddTicks(96), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a3") },
                    { 4, new DateTime(2022, 6, 1, 12, 35, 47, 270, DateTimeKind.Local).AddTicks(118), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a4"), new DateTime(2022, 6, 1, 12, 35, 47, 270, DateTimeKind.Local).AddTicks(120), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a4"), 4, "testService@gmail.com4", 4m, "testProcedure4", 0, new DateTime(2022, 6, 1, 12, 35, 47, 270, DateTimeKind.Local).AddTicks(119), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a4") },
                    { 5, new DateTime(2022, 6, 1, 12, 35, 47, 270, DateTimeKind.Local).AddTicks(180), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a5"), new DateTime(2022, 6, 1, 12, 35, 47, 270, DateTimeKind.Local).AddTicks(182), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a5"), 5, "testService@gmail.com5", 5m, "testProcedure5", 0, new DateTime(2022, 6, 1, 12, 35, 47, 270, DateTimeKind.Local).AddTicks(181), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a5") }
                });

            migrationBuilder.InsertData(
                table: "Booking_Details",
                columns: new[] { "Id", "BookingId", "Created_at", "Created_by", "Deleted_at", "Deleted_by", "DentistId", "KeyTime", "Note", "ServiceId", "Status", "Updated_at", "Updated_by" },
                values: new object[,]
                {
                    { 11, 4, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8546), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3313"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8548), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3313"), 13, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8547), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3313") },
                    { 34, 12, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8889), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3321"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8890), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3321"), 21, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8890), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3321") },
                    { 35, 12, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8933), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3321"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8934), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3321"), 21, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8934), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3321") },
                    { 36, 12, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8945), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3321"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8946), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3321"), 21, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8946), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3321") },
                    { 37, 13, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8957), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3322"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8959), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3322"), 22, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8958), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3322") },
                    { 38, 13, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8969), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3322"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8971), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3322"), 22, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8970), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3322") },
                    { 39, 13, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8981), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3322"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8982), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3322"), 22, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8982), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3322") },
                    { 40, 14, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8993), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3323"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8994), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3323"), 23, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8994), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3323") },
                    { 33, 11, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8876), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3320"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8877), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3320"), 20, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8876), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3320") },
                    { 41, 14, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9005), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3323"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9006), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3323"), 23, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9005), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3323") },
                    { 43, 15, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9028), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3324"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9030), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3324"), 24, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9029), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3324") },
                    { 44, 15, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9106), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3324"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9108), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3324"), 24, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9107), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3324") },
                    { 45, 15, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9119), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3324"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9120), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3324"), 24, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9119), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3324") },
                    { 46, 16, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9132), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3325"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9133), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3325"), 25, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9132), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3325") },
                    { 47, 16, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9144), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3325"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9145), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3325"), 25, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9144), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3325") },
                    { 48, 16, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9156), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3325"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9157), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3325"), 25, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9156), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3325") },
                    { 49, 17, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9168), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3326"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9169), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3326"), 26, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9168), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3326") },
                    { 42, 14, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9016), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3323"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9018), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3323"), 23, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9017), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3323") },
                    { 32, 11, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8864), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3320"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8865), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3320"), 20, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8865), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3320") },
                    { 31, 11, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8852), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3320"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8854), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3320"), 20, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8853), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3320") },
                    { 30, 10, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8840), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3319"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8842), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3319"), 19, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8841), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3319") },
                    { 13, 5, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8570), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3314"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8572), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3314"), 14, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8571), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3314") },
                    { 14, 5, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8582), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3314"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8584), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3314"), 14, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8583), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3314") },
                    { 15, 5, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8594), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3314"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8595), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3314"), 14, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8595), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3314") },
                    { 16, 6, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8606), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3315"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8608), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3315"), 15, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8607), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3315") },
                    { 17, 6, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8618), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3315"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8620), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3315"), 15, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8619), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3315") },
                    { 18, 6, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8662), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3315"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8663), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3315"), 15, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8663), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3315") },
                    { 19, 7, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8675), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3316"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8677), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3316"), 16, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8676), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3316") },
                    { 20, 7, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8687), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3316"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8689), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3316"), 16, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8688), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3316") },
                    { 21, 7, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8699), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3316"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8701), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3316"), 16, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8700), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3316") },
                    { 22, 8, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8712), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3317"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8713), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3317"), 17, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8712), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3317") },
                    { 23, 8, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8724), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3317"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8725), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3317"), 17, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8724), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3317") },
                    { 24, 8, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8736), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3317"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8737), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3317"), 17, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8736), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3317") },
                    { 25, 9, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8747), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3318"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8749), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3318"), 18, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8748), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3318") },
                    { 26, 9, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8759), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3318"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8760), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3318"), 18, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8760), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3318") },
                    { 27, 9, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8804), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3318"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8805), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3318"), 18, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8805), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3318") },
                    { 28, 10, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8816), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3319"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8818), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3319"), 19, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8817), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3319") },
                    { 29, 10, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8828), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3319"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8830), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3319"), 19, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8829), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3319") },
                    { 50, 17, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9180), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3326"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9181), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3326"), 26, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9180), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3326") },
                    { 51, 17, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9191), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3326"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9193), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3326"), 26, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9192), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3326") },
                    { 52, 18, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9233), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3327"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9235), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3327"), 27, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9234), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3327") },
                    { 53, 18, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9247), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3327"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9249), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3327"), 27, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9248), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3327") }
                });

            migrationBuilder.InsertData(
                table: "Booking_Details",
                columns: new[] { "Id", "BookingId", "Created_at", "Created_by", "Deleted_at", "Deleted_by", "DentistId", "KeyTime", "Note", "ServiceId", "Status", "Updated_at", "Updated_by" },
                values: new object[,]
                {
                    { 75, 25, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9600), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3334"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9602), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3334"), 34, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9601), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3334") },
                    { 76, 26, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9612), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3335"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9613), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3335"), 35, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9613), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3335") },
                    { 77, 26, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9624), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3335"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9625), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3335"), 35, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9624), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3335") },
                    { 78, 26, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9668), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3335"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9669), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3335"), 35, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9668), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3335") },
                    { 79, 27, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9680), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3336"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9682), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3336"), 36, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9681), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3336") },
                    { 80, 27, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9693), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3336"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9694), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3336"), 36, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9693), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3336") },
                    { 81, 27, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9705), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3336"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9706), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3336"), 36, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9705), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3336") },
                    { 82, 28, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9717), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3337"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9719), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3337"), 37, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9718), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3337") },
                    { 83, 28, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9729), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3337"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9731), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3337"), 37, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9730), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3337") },
                    { 84, 28, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9741), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3337"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9742), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3337"), 37, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9742), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3337") },
                    { 85, 29, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9753), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3338"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9755), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3338"), 38, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9754), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3338") },
                    { 86, 29, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9765), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3338"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9766), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3338"), 38, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9766), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3338") },
                    { 87, 29, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9810), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3338"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9812), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3338"), 38, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9811), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3338") },
                    { 88, 30, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9822), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3339"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9824), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3339"), 39, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9823), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3339") },
                    { 89, 30, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9835), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3339"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9836), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3339"), 39, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9835), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3339") },
                    { 90, 30, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9846), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3339"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9848), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3339"), 39, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9847), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3339") },
                    { 91, 31, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9858), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3340"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9860), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3340"), 40, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9859), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3340") },
                    { 74, 25, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9588), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3334"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9590), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3334"), 34, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9589), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3334") },
                    { 12, 4, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8558), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3313"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8560), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3313"), 13, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8559), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3313") },
                    { 73, 25, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9577), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3334"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9578), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3334"), 34, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9577), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3334") },
                    { 71, 24, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9552), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3333"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9553), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3333"), 33, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9552), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3333") },
                    { 54, 18, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9259), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3327"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9261), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3327"), 27, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9260), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3327") },
                    { 55, 19, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9272), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3328"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9273), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3328"), 28, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9272), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3328") },
                    { 56, 19, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9284), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3328"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9285), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3328"), 28, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9284), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3328") },
                    { 57, 19, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9296), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3328"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9297), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3328"), 28, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9296), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3328") },
                    { 58, 20, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9308), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3329"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9309), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3329"), 29, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9309), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3329") },
                    { 59, 20, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9320), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3329"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9321), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3329"), 29, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9320), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3329") },
                    { 60, 20, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9332), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3329"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9333), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3329"), 29, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9332), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3329") },
                    { 61, 21, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9374), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3330"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9375), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3330"), 30, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9375), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3330") },
                    { 62, 21, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9388), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3330"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9389), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3330"), 30, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9388), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3330") },
                    { 63, 21, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9400), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3330"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9401), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3330"), 30, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9400), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3330") },
                    { 64, 22, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9412), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3331"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9413), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3331"), 31, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9413), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3331") },
                    { 65, 22, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9424), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3331"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9425), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3331"), 31, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9425), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3331") },
                    { 66, 22, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9438), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3331"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9439), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3331"), 31, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9439), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3331") },
                    { 67, 23, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9470), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3332"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9471), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3332"), 32, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9471), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3332") },
                    { 68, 23, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9482), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3332"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9484), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3332"), 32, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9483), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3332") },
                    { 69, 23, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9526), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3332"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9528), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3332"), 32, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9527), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3332") },
                    { 70, 24, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9539), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3333"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9541), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3333"), 33, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9540), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3333") },
                    { 72, 24, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9564), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3333"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9565), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3333"), 33, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9565), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3333") },
                    { 92, 31, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9870), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3340"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9871), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3340"), 40, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9871), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3340") },
                    { 93, 31, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9882), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3340"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9883), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3340"), 40, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9882), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3340") },
                    { 9, 3, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8517), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3312"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8518), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3312"), 12, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8517), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3312") }
                });

            migrationBuilder.InsertData(
                table: "Booking_Details",
                columns: new[] { "Id", "BookingId", "Created_at", "Created_by", "Deleted_at", "Deleted_by", "DentistId", "KeyTime", "Note", "ServiceId", "Status", "Updated_at", "Updated_by" },
                values: new object[,]
                {
                    { 8, 3, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8462), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3312"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8464), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3312"), 12, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8463), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3312") },
                    { 7, 3, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8450), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3312"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8452), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3312"), 12, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8451), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3312") },
                    { 6, 2, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8437), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3311"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8438), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3311"), 11, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8438), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3311") },
                    { 5, 2, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8417), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3311"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8419), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3311"), 11, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8418), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3311") },
                    { 4, 2, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8404), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3311"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8406), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3311"), 11, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8405), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3311") },
                    { 3, 1, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8391), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3310"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8392), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3310"), 10, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8391), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3310") },
                    { 2, 1, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8365), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3310"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8369), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3310"), 10, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8368), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3310") },
                    { 1, 1, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(6578), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3310"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(7097), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3310"), 10, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(6815), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3310") },
                    { 10, 4, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8534), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3313"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8535), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3313"), 13, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(8535), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3313") }
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
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"), 0, "cb1e3f75-71b8-4064-9b45-c0533ff550a4", new DateTime(2022, 6, 1, 5, 35, 47, 511, DateTimeKind.Utc).AddTicks(6203), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 511, DateTimeKind.Utc).AddTicks(6211), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"), 59, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEEnJoNA3zo7B3gtSMVp6tGa5772GLVtOzxA9rYdd5WpwnaXm0IpZ3+jF28mbeW7pdQ==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 511, DateTimeKind.Utc).AddTicks(6209), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"), 0, "948f6a28-442b-4124-8f9d-fefca9edca00", new DateTime(2022, 6, 1, 5, 35, 47, 470, DateTimeKind.Utc).AddTicks(7603), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 470, DateTimeKind.Utc).AddTicks(7608), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"), 52, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEJnRZ4Fs7CTWPUBhg9VWFSwSHqlVJED1LSeEbNOMKU9W59A+7U69RFDm48e3z5ioOg==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 470, DateTimeKind.Utc).AddTicks(7606), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"), 0, "48c13509-4e4e-4514-bd67-a5765ca35d5d", new DateTime(2022, 6, 1, 5, 35, 47, 476, DateTimeKind.Utc).AddTicks(4553), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 476, DateTimeKind.Utc).AddTicks(4555), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"), 53, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAECt3e4Lc0DZvxHIyuB6sLB9n2QSdNTjG7FK98yusTXkss9G1i+SWS9SCVowevgVqsg==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 476, DateTimeKind.Utc).AddTicks(4554), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"), 0, "9ffc6b57-16ed-4a5f-a555-ac8cc4c9855f", new DateTime(2022, 6, 1, 5, 35, 47, 482, DateTimeKind.Utc).AddTicks(1713), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 482, DateTimeKind.Utc).AddTicks(1718), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"), 54, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEGzExCW2lt66I1op4yo2hnqGyXZNG7bDOOB2vguwTsYiDm5PVZ9t8KSiKdgi4/G5UQ==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 482, DateTimeKind.Utc).AddTicks(1715), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"), 0, "574d888a-01b0-44cf-b3b8-1871296a8ac1", new DateTime(2022, 6, 1, 5, 35, 47, 487, DateTimeKind.Utc).AddTicks(8550), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 487, DateTimeKind.Utc).AddTicks(8552), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"), 55, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAED/jEPb/4u28IxXmYrAtsr9pc5nbzmgfGH4mN6xS51qdk3psDBBvF3hjPOaUcZTGwg==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 487, DateTimeKind.Utc).AddTicks(8551), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"), 0, "b0fc6562-7117-4f3a-8191-187398752a44", new DateTime(2022, 6, 1, 5, 35, 47, 493, DateTimeKind.Utc).AddTicks(8037), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 493, DateTimeKind.Utc).AddTicks(8044), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"), 56, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEOP2jEFKb7b3mTcapZooIFkcJdcqJG7zvWZt+2LZckjLGo8CBEDXAgewx2iW1c4tdQ==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 493, DateTimeKind.Utc).AddTicks(8042), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"), 0, "10a93ff9-0984-44c9-a942-bfe9d5f4da10", new DateTime(2022, 6, 1, 5, 35, 47, 499, DateTimeKind.Utc).AddTicks(5713), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 499, DateTimeKind.Utc).AddTicks(5716), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"), 57, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEAa1c7KWuScnXdtGq3wWjt3BAooEpxi5QWuN+WXLX0GL14Z/OzWl9bv4lzJlv3CIcw==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 499, DateTimeKind.Utc).AddTicks(5715), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"), 0, "15d5fa06-9b77-40df-ad5b-4c60573d94b5", new DateTime(2022, 6, 1, 5, 35, 47, 505, DateTimeKind.Utc).AddTicks(2476), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 505, DateTimeKind.Utc).AddTicks(2479), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"), 58, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEC7Rjvrb5Z62yHQdaCqO7GSuJ1utGPE1ixgJfpox2woZvCKNxiqOyNdncd0qlReTTA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 505, DateTimeKind.Utc).AddTicks(2478), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"), 0, "701a8ee5-46a1-4110-bfa9-a29cf73a1438", new DateTime(2022, 6, 1, 5, 35, 47, 517, DateTimeKind.Utc).AddTicks(3226), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 517, DateTimeKind.Utc).AddTicks(3228), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"), 60, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEK2jG54aqXNAaH40vtd12qGCU567ceKBztpk5Kq1296fF25qxK/NuqiJc11mn5MtWQ==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 517, DateTimeKind.Utc).AddTicks(3227), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3366"), 0, "77fef640-9f2d-4b2c-9484-2070eaf57db9", new DateTime(2022, 6, 1, 5, 35, 47, 551, DateTimeKind.Utc).AddTicks(6971), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3366"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 551, DateTimeKind.Utc).AddTicks(6974), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3366"), 66, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEJZT9GedDUv1XGNtgevaKyFr8nTdc/UXoUT/TuaEtZ5DqBmOqAaO3ZO8scwhEfBbjQ==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 551, DateTimeKind.Utc).AddTicks(6973), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3366"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3362"), 0, "06a1c71e-c20e-4849-81e6-2699bb0bc3b6", new DateTime(2022, 6, 1, 5, 35, 47, 528, DateTimeKind.Utc).AddTicks(8250), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3362"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 528, DateTimeKind.Utc).AddTicks(8257), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3362"), 62, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEKzonBExNtWArz2ypX5AAe+vb1amTHkUDtb1nTlT2moDD5qH0RTyUr67ucyWYQ2CWA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 528, DateTimeKind.Utc).AddTicks(8255), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3362"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3363"), 0, "3b9ba7b3-7ceb-48f0-a98e-89cbc5d48cbc", new DateTime(2022, 6, 1, 5, 35, 47, 534, DateTimeKind.Utc).AddTicks(5437), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3363"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 534, DateTimeKind.Utc).AddTicks(5441), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3363"), 63, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEKJ0F/4oUyJEzvCYiB4mlvc+qP0ZtuwIvZrE1SRlC5anuSFl3GoKfr5T2CuZt+qAdQ==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 534, DateTimeKind.Utc).AddTicks(5440), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3363"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3364"), 0, "6a14c553-dbf1-4847-85c8-c1c1082e9078", new DateTime(2022, 6, 1, 5, 35, 47, 540, DateTimeKind.Utc).AddTicks(3021), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3364"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 540, DateTimeKind.Utc).AddTicks(3028), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3364"), 64, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEOSQl9kUTZXooweUfpAPaaL4uRJQBwwo5+Cvn8IG9KEIHYO3gaZQshFs0nEEHeUM9Q==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 540, DateTimeKind.Utc).AddTicks(3026), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3364"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3365"), 0, "837ff5c0-7b48-4a4a-937c-d0304a26dd2c", new DateTime(2022, 6, 1, 5, 35, 47, 546, DateTimeKind.Utc).AddTicks(147), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3365"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 546, DateTimeKind.Utc).AddTicks(151), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3365"), 65, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAELhTVT+sxo/53FWnZBHB5VI/5UL0X+X+SE82/drDud3O9JW9EdNYsqMB55X/LEgwqw==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 546, DateTimeKind.Utc).AddTicks(149), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3365"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3367"), 0, "0a539b33-6bb4-444a-80cc-d4f949b6a4e5", new DateTime(2022, 6, 1, 5, 35, 47, 557, DateTimeKind.Utc).AddTicks(4628), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3367"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 557, DateTimeKind.Utc).AddTicks(4633), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3367"), 67, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEKtBlcJdVBxAm/lRcvJVUmHO0Y3tvrjRLdQ6ipKQks/XLkQgL50/mEyQ28siytbhBA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 557, DateTimeKind.Utc).AddTicks(4632), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3367"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3368"), 0, "6467e3e0-d3b4-4679-b899-6583cfe43cab", new DateTime(2022, 6, 1, 5, 35, 47, 563, DateTimeKind.Utc).AddTicks(2410), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3368"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 563, DateTimeKind.Utc).AddTicks(2413), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3368"), 68, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAELYm8u3jEmHOYZ6bPTnSeQTwKHdZNEmHhOdVHIBDlIHP+LN1gTX65I04/rDWXk+rmw==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 563, DateTimeKind.Utc).AddTicks(2412), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3368"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3369"), 0, "3ea58225-ba32-4696-98f6-51bf5da62c4b", new DateTime(2022, 6, 1, 5, 35, 47, 569, DateTimeKind.Utc).AddTicks(63), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3369"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 569, DateTimeKind.Utc).AddTicks(65), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3369"), 69, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEKjMfxfH96c7mFrhqppNezeV9uZGRX/bjErbjX1L9aOXeVJgnrmfSmNtVqxJgK57KQ==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 569, DateTimeKind.Utc).AddTicks(64), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3369"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3370"), 0, "8dc3fbec-d6b4-4263-b8ed-e86996288d2c", new DateTime(2022, 6, 1, 5, 35, 47, 574, DateTimeKind.Utc).AddTicks(7215), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3370"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 574, DateTimeKind.Utc).AddTicks(7221), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3370"), 70, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEG0b+bcEPz4TS6Cmo1A4aLAQqtk2iDPFRpqvxUHqnvB5TH1geFGQ4NgqdHe4z+UQ1Q==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 574, DateTimeKind.Utc).AddTicks(7220), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3370"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3371"), 0, "a2c5fe9c-7b75-4350-a2c9-631541830d9e", new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(3868), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3371"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(3870), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3371"), 71, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEPeRBJ+ispOn8hRnyr/j8mFnaAXYsgTVhvL2ckqflAvTrRhTmm4fFbcAY7lv8HFQOA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(3869), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3371"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3361"), 0, "d69dcbd3-2407-4687-b744-56181edd2f13", new DateTime(2022, 6, 1, 5, 35, 47, 523, DateTimeKind.Utc).AddTicks(446), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3361"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 523, DateTimeKind.Utc).AddTicks(452), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3361"), 61, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAELVJ/QVBMwHh4lnwv1tua6WtAMxiHNTVZvy6D5n3weTVjQi1OQ1JKK2kkDXHnaSAYg==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 523, DateTimeKind.Utc).AddTicks(449), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3361"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"), 0, "f22a5ed1-04b6-454e-ada8-f3b110e4e724", new DateTime(2022, 6, 1, 5, 35, 47, 464, DateTimeKind.Utc).AddTicks(8114), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 5, 35, 47, 464, DateTimeKind.Utc).AddTicks(8123), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"), 51, "ducsama90@gmail.com", false, "Nguyen", 1, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEPLvmxd7oZAcMcRd+VI3IH1vrPVn5XOdo6UyPc8QcD2BUhdEc+7kVpE3eVAvpoVUQQ==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 1, 5, 35, 47, 464, DateTimeKind.Utc).AddTicks(8119), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"), null }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "Created_at", "Date", "Deleted_at", "Deleted_by", "Status", "Total", "Updated_at", "Updated_by", "UserId" },
                values: new object[,]
                {
                    { 32, new DateTime(2022, 6, 1, 5, 35, 47, 464, DateTimeKind.Utc).AddTicks(9205), new DateTime(2022, 6, 1, 5, 35, 47, 464, DateTimeKind.Utc).AddTicks(9200), new DateTime(2022, 6, 1, 5, 35, 47, 464, DateTimeKind.Utc).AddTicks(9207), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"), 0, 200m, new DateTime(2022, 6, 1, 5, 35, 47, 464, DateTimeKind.Utc).AddTicks(9206), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351") },
                    { 50, new DateTime(2022, 6, 1, 5, 35, 47, 569, DateTimeKind.Utc).AddTicks(113), new DateTime(2022, 6, 1, 5, 35, 47, 569, DateTimeKind.Utc).AddTicks(112), new DateTime(2022, 6, 1, 5, 35, 47, 569, DateTimeKind.Utc).AddTicks(115), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3369"), 0, 200m, new DateTime(2022, 6, 1, 5, 35, 47, 569, DateTimeKind.Utc).AddTicks(114), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3369"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3369") },
                    { 49, new DateTime(2022, 6, 1, 5, 35, 47, 563, DateTimeKind.Utc).AddTicks(2461), new DateTime(2022, 6, 1, 5, 35, 47, 563, DateTimeKind.Utc).AddTicks(2459), new DateTime(2022, 6, 1, 5, 35, 47, 563, DateTimeKind.Utc).AddTicks(2462), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3368"), 0, 200m, new DateTime(2022, 6, 1, 5, 35, 47, 563, DateTimeKind.Utc).AddTicks(2462), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3368"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3368") },
                    { 48, new DateTime(2022, 6, 1, 5, 35, 47, 557, DateTimeKind.Utc).AddTicks(4720), new DateTime(2022, 6, 1, 5, 35, 47, 557, DateTimeKind.Utc).AddTicks(4717), new DateTime(2022, 6, 1, 5, 35, 47, 557, DateTimeKind.Utc).AddTicks(4721), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3367"), 0, 200m, new DateTime(2022, 6, 1, 5, 35, 47, 557, DateTimeKind.Utc).AddTicks(4720), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3367"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3367") },
                    { 47, new DateTime(2022, 6, 1, 5, 35, 47, 551, DateTimeKind.Utc).AddTicks(7086), new DateTime(2022, 6, 1, 5, 35, 47, 551, DateTimeKind.Utc).AddTicks(7084), new DateTime(2022, 6, 1, 5, 35, 47, 551, DateTimeKind.Utc).AddTicks(7087), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3366"), 0, 200m, new DateTime(2022, 6, 1, 5, 35, 47, 551, DateTimeKind.Utc).AddTicks(7086), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3366"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3366") },
                    { 46, new DateTime(2022, 6, 1, 5, 35, 47, 546, DateTimeKind.Utc).AddTicks(226), new DateTime(2022, 6, 1, 5, 35, 47, 546, DateTimeKind.Utc).AddTicks(225), new DateTime(2022, 6, 1, 5, 35, 47, 546, DateTimeKind.Utc).AddTicks(228), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3365"), 0, 200m, new DateTime(2022, 6, 1, 5, 35, 47, 546, DateTimeKind.Utc).AddTicks(227), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3365"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3365") },
                    { 45, new DateTime(2022, 6, 1, 5, 35, 47, 540, DateTimeKind.Utc).AddTicks(3148), new DateTime(2022, 6, 1, 5, 35, 47, 540, DateTimeKind.Utc).AddTicks(3145), new DateTime(2022, 6, 1, 5, 35, 47, 540, DateTimeKind.Utc).AddTicks(3149), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3364"), 0, 200m, new DateTime(2022, 6, 1, 5, 35, 47, 540, DateTimeKind.Utc).AddTicks(3149), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3364"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3364") },
                    { 44, new DateTime(2022, 6, 1, 5, 35, 47, 534, DateTimeKind.Utc).AddTicks(5529), new DateTime(2022, 6, 1, 5, 35, 47, 534, DateTimeKind.Utc).AddTicks(5527), new DateTime(2022, 6, 1, 5, 35, 47, 534, DateTimeKind.Utc).AddTicks(5531), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3363"), 0, 200m, new DateTime(2022, 6, 1, 5, 35, 47, 534, DateTimeKind.Utc).AddTicks(5530), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3363"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3363") },
                    { 43, new DateTime(2022, 6, 1, 5, 35, 47, 528, DateTimeKind.Utc).AddTicks(8413), new DateTime(2022, 6, 1, 5, 35, 47, 528, DateTimeKind.Utc).AddTicks(8410), new DateTime(2022, 6, 1, 5, 35, 47, 528, DateTimeKind.Utc).AddTicks(8415), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3362"), 0, 200m, new DateTime(2022, 6, 1, 5, 35, 47, 528, DateTimeKind.Utc).AddTicks(8414), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3362"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3362") },
                    { 51, new DateTime(2022, 6, 1, 5, 35, 47, 574, DateTimeKind.Utc).AddTicks(7320), new DateTime(2022, 6, 1, 5, 35, 47, 574, DateTimeKind.Utc).AddTicks(7318), new DateTime(2022, 6, 1, 5, 35, 47, 574, DateTimeKind.Utc).AddTicks(7322), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3370"), 0, 200m, new DateTime(2022, 6, 1, 5, 35, 47, 574, DateTimeKind.Utc).AddTicks(7321), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3370"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3370") },
                    { 42, new DateTime(2022, 6, 1, 5, 35, 47, 523, DateTimeKind.Utc).AddTicks(579), new DateTime(2022, 6, 1, 5, 35, 47, 523, DateTimeKind.Utc).AddTicks(577), new DateTime(2022, 6, 1, 5, 35, 47, 523, DateTimeKind.Utc).AddTicks(581), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3361"), 0, 200m, new DateTime(2022, 6, 1, 5, 35, 47, 523, DateTimeKind.Utc).AddTicks(580), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3361"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3361") },
                    { 40, new DateTime(2022, 6, 1, 5, 35, 47, 511, DateTimeKind.Utc).AddTicks(6429), new DateTime(2022, 6, 1, 5, 35, 47, 511, DateTimeKind.Utc).AddTicks(6426), new DateTime(2022, 6, 1, 5, 35, 47, 511, DateTimeKind.Utc).AddTicks(6431), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"), 0, 200m, new DateTime(2022, 6, 1, 5, 35, 47, 511, DateTimeKind.Utc).AddTicks(6430), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359") },
                    { 39, new DateTime(2022, 6, 1, 5, 35, 47, 505, DateTimeKind.Utc).AddTicks(2568), new DateTime(2022, 6, 1, 5, 35, 47, 505, DateTimeKind.Utc).AddTicks(2567), new DateTime(2022, 6, 1, 5, 35, 47, 505, DateTimeKind.Utc).AddTicks(2570), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"), 0, 200m, new DateTime(2022, 6, 1, 5, 35, 47, 505, DateTimeKind.Utc).AddTicks(2569), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358") },
                    { 38, new DateTime(2022, 6, 1, 5, 35, 47, 499, DateTimeKind.Utc).AddTicks(5750), new DateTime(2022, 6, 1, 5, 35, 47, 499, DateTimeKind.Utc).AddTicks(5749), new DateTime(2022, 6, 1, 5, 35, 47, 499, DateTimeKind.Utc).AddTicks(5751), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"), 0, 200m, new DateTime(2022, 6, 1, 5, 35, 47, 499, DateTimeKind.Utc).AddTicks(5750), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357") },
                    { 37, new DateTime(2022, 6, 1, 5, 35, 47, 493, DateTimeKind.Utc).AddTicks(8380), new DateTime(2022, 6, 1, 5, 35, 47, 493, DateTimeKind.Utc).AddTicks(8376), new DateTime(2022, 6, 1, 5, 35, 47, 493, DateTimeKind.Utc).AddTicks(8382), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"), 0, 200m, new DateTime(2022, 6, 1, 5, 35, 47, 493, DateTimeKind.Utc).AddTicks(8381), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356") },
                    { 36, new DateTime(2022, 6, 1, 5, 35, 47, 487, DateTimeKind.Utc).AddTicks(8587), new DateTime(2022, 6, 1, 5, 35, 47, 487, DateTimeKind.Utc).AddTicks(8586), new DateTime(2022, 6, 1, 5, 35, 47, 487, DateTimeKind.Utc).AddTicks(8588), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"), 0, 200m, new DateTime(2022, 6, 1, 5, 35, 47, 487, DateTimeKind.Utc).AddTicks(8588), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355") },
                    { 35, new DateTime(2022, 6, 1, 5, 35, 47, 482, DateTimeKind.Utc).AddTicks(1907), new DateTime(2022, 6, 1, 5, 35, 47, 482, DateTimeKind.Utc).AddTicks(1905), new DateTime(2022, 6, 1, 5, 35, 47, 482, DateTimeKind.Utc).AddTicks(1909), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"), 0, 200m, new DateTime(2022, 6, 1, 5, 35, 47, 482, DateTimeKind.Utc).AddTicks(1908), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354") },
                    { 34, new DateTime(2022, 6, 1, 5, 35, 47, 476, DateTimeKind.Utc).AddTicks(4624), new DateTime(2022, 6, 1, 5, 35, 47, 476, DateTimeKind.Utc).AddTicks(4622), new DateTime(2022, 6, 1, 5, 35, 47, 476, DateTimeKind.Utc).AddTicks(4625), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"), 0, 200m, new DateTime(2022, 6, 1, 5, 35, 47, 476, DateTimeKind.Utc).AddTicks(4624), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353") },
                    { 33, new DateTime(2022, 6, 1, 5, 35, 47, 470, DateTimeKind.Utc).AddTicks(7764), new DateTime(2022, 6, 1, 5, 35, 47, 470, DateTimeKind.Utc).AddTicks(7761), new DateTime(2022, 6, 1, 5, 35, 47, 470, DateTimeKind.Utc).AddTicks(7766), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"), 0, 200m, new DateTime(2022, 6, 1, 5, 35, 47, 470, DateTimeKind.Utc).AddTicks(7765), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352") },
                    { 41, new DateTime(2022, 6, 1, 5, 35, 47, 517, DateTimeKind.Utc).AddTicks(3268), new DateTime(2022, 6, 1, 5, 35, 47, 517, DateTimeKind.Utc).AddTicks(3267), new DateTime(2022, 6, 1, 5, 35, 47, 517, DateTimeKind.Utc).AddTicks(3270), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"), 0, 200m, new DateTime(2022, 6, 1, 5, 35, 47, 517, DateTimeKind.Utc).AddTicks(3269), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360") },
                    { 52, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(3886), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(3886), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(3888), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3371"), 0, 200m, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(3887), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3371"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3371") }
                });

            migrationBuilder.InsertData(
                table: "Booking_Details",
                columns: new[] { "Id", "BookingId", "Created_at", "Created_by", "Deleted_at", "Deleted_by", "DentistId", "KeyTime", "Note", "ServiceId", "Status", "Updated_at", "Updated_by" },
                values: new object[,]
                {
                    { 94, 32, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9893), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3341"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9895), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3341"), 41, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9894), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3341") },
                    { 126, 42, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(421), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(422), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"), 51, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(422), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351") },
                    { 127, 43, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(433), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(434), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"), 52, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(434), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352") },
                    { 128, 43, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(445), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(446), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"), 52, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(446), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352") },
                    { 129, 43, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(457), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(458), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"), 52, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(457), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352") },
                    { 130, 44, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(503), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(504), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"), 53, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(503), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353") },
                    { 131, 44, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(515), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(517), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"), 53, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(516), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353") },
                    { 132, 44, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(527), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(529), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"), 53, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(528), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353") },
                    { 133, 45, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(540), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(541), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"), 54, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(541), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354") },
                    { 134, 45, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(552), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(553), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"), 54, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(553), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354") },
                    { 135, 45, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(564), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(565), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"), 54, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(565), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354") },
                    { 136, 46, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(576), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(577), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"), 55, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(576), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355") },
                    { 137, 46, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(618), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(619), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"), 55, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(619), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355") },
                    { 125, 42, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(409), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(411), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"), 51, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(410), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351") },
                    { 138, 46, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(631), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(633), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"), 55, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(632), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355") },
                    { 140, 47, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(656), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(657), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"), 56, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(657), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356") },
                    { 141, 47, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(668), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(670), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"), 56, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(669), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356") },
                    { 142, 48, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(680), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(682), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"), 57, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(681), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357") },
                    { 143, 48, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(692), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(693), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"), 57, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(693), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357") },
                    { 144, 48, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(704), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(705), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"), 57, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(705), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357") },
                    { 145, 49, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(716), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(717), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"), 58, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(716), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358") },
                    { 146, 49, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(760), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(761), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"), 58, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(761), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358") },
                    { 147, 49, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(772), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(774), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"), 58, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(773), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358") },
                    { 148, 50, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(785), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(786), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"), 59, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(786), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359") },
                    { 149, 50, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(797), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(798), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"), 59, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(798), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359") },
                    { 150, 50, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(809), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(810), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"), 59, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(810), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359") },
                    { 151, 51, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(821), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(822), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"), 60, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(821), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360") },
                    { 139, 47, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(644), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(645), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"), 56, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(644), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356") },
                    { 124, 42, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(397), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(399), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"), 51, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(398), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351") },
                    { 123, 41, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(385), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3350"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(386), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3350"), 50, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(386), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3350") },
                    { 122, 41, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(373), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3350"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(374), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3350"), 50, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(373), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3350") },
                    { 95, 32, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9935), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3341"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9936), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3341"), 41, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9935), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3341") },
                    { 96, 32, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9948), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3341"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9950), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3341"), 41, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9949), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3341") },
                    { 97, 33, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9961), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3342"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9962), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3342"), 42, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9961), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3342") },
                    { 98, 33, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9973), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3342"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9974), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3342"), 42, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9973), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3342") },
                    { 99, 33, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9984), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3342"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9986), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3342"), 42, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9985), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3342") },
                    { 100, 34, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9997), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3343"), new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9998), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3343"), 43, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 580, DateTimeKind.Utc).AddTicks(9997), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3343") },
                    { 101, 34, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(8), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3343"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(10), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3343"), 43, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(9), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3343") },
                    { 102, 34, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(20), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3343"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(22), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3343"), 43, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(21), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3343") },
                    { 103, 35, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(32), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3344"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(34), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3344"), 44, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(33), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3344") },
                    { 104, 35, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(75), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3344"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(77), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3344"), 44, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(76), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3344") },
                    { 105, 35, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(89), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3344"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(90), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3344"), 44, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(89), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3344") }
                });

            migrationBuilder.InsertData(
                table: "Booking_Details",
                columns: new[] { "Id", "BookingId", "Created_at", "Created_by", "Deleted_at", "Deleted_by", "DentistId", "KeyTime", "Note", "ServiceId", "Status", "Updated_at", "Updated_by" },
                values: new object[,]
                {
                    { 106, 36, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(101), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3345"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(102), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3345"), 45, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(102), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3345") },
                    { 107, 36, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(114), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3345"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(115), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3345"), 45, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(114), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3345") },
                    { 108, 36, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(126), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3345"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(127), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3345"), 45, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(126), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3345") },
                    { 109, 37, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(138), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3346"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(139), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3346"), 46, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(139), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3346") },
                    { 110, 37, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(150), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3346"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(151), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3346"), 46, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(150), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3346") },
                    { 111, 37, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(162), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3346"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(163), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3346"), 46, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(162), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3346") },
                    { 112, 38, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(174), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3347"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(175), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3347"), 47, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(175), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3347") },
                    { 113, 38, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(229), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3347"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(231), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3347"), 47, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(230), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3347") },
                    { 114, 38, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(242), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3347"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(244), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3347"), 47, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(243), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3347") },
                    { 115, 39, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(255), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3348"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(256), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3348"), 48, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(256), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3348") },
                    { 116, 39, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(267), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3348"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(269), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3348"), 48, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(268), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3348") },
                    { 117, 39, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(279), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3348"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(281), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3348"), 48, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(280), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3348") },
                    { 118, 40, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(292), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3349"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(293), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3349"), 49, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(292), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3349") },
                    { 119, 40, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(303), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3349"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(305), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3349"), 49, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(304), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3349") },
                    { 120, 40, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(315), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3349"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(317), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3349"), 49, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(316), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3349") },
                    { 121, 41, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(327), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3350"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(328), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3350"), 50, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(328), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3350") },
                    { 152, 51, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(833), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(834), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"), 60, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(833), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360") },
                    { 153, 51, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(844), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"), new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(846), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"), 60, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 1, 5, 35, 47, 581, DateTimeKind.Utc).AddTicks(845), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360") }
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
