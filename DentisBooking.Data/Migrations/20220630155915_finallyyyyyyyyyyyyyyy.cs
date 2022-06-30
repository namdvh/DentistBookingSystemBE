using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DentisBooking.Data.Migrations
{
    public partial class finallyyyyyyyyyyyyyyy : Migration
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
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Procedure = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                columns: new[] { "Id", "Address", "Created_at", "Created_by", "Deleted_at", "Deleted_by", "Description", "ImageUrl", "Name", "Phone", "Status", "Updated_at", "Updated_by" },
                values: new object[,]
                {
                    { 1, "TestAddress1", new DateTime(2022, 6, 30, 22, 59, 14, 113, DateTimeKind.Local).AddTicks(7515), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e51"), new DateTime(2022, 6, 30, 22, 59, 14, 113, DateTimeKind.Local).AddTicks(8554), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e51"), "TestDescirption1", null, "TestClinic1", "0868644651", 0, new DateTime(2022, 6, 30, 22, 59, 14, 113, DateTimeKind.Local).AddTicks(7990), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e51") },
                    { 2, "TestAddress2", new DateTime(2022, 6, 30, 22, 59, 14, 114, DateTimeKind.Local).AddTicks(794), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e52"), new DateTime(2022, 6, 30, 22, 59, 14, 114, DateTimeKind.Local).AddTicks(805), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e52"), "TestDescirption2", null, "TestClinic2", "0868644651", 0, new DateTime(2022, 6, 30, 22, 59, 14, 114, DateTimeKind.Local).AddTicks(802), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e52") },
                    { 3, "TestAddress3", new DateTime(2022, 6, 30, 22, 59, 14, 114, DateTimeKind.Local).AddTicks(872), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e53"), new DateTime(2022, 6, 30, 22, 59, 14, 114, DateTimeKind.Local).AddTicks(875), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e53"), "TestDescirption3", null, "TestClinic3", "0868644651", 0, new DateTime(2022, 6, 30, 22, 59, 14, 114, DateTimeKind.Local).AddTicks(874), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e53") },
                    { 4, "TestAddress4", new DateTime(2022, 6, 30, 22, 59, 14, 114, DateTimeKind.Local).AddTicks(918), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e54"), new DateTime(2022, 6, 30, 22, 59, 14, 114, DateTimeKind.Local).AddTicks(921), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e54"), "TestDescirption4", null, "TestClinic4", "0868644651", 0, new DateTime(2022, 6, 30, 22, 59, 14, 114, DateTimeKind.Local).AddTicks(920), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e54") },
                    { 5, "TestAddress5", new DateTime(2022, 6, 30, 22, 59, 14, 114, DateTimeKind.Local).AddTicks(973), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e55"), new DateTime(2022, 6, 30, 22, 59, 14, 114, DateTimeKind.Local).AddTicks(976), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e55"), "TestDescirption5", null, "TestClinic5", "0868644651", 0, new DateTime(2022, 6, 30, 22, 59, 14, 114, DateTimeKind.Local).AddTicks(975), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e55") }
                });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "Amount", "ApplyForAll", "Created_at", "Created_by", "Deleted_at", "Deleted_by", "Description", "EndDate", "Percent", "StartDate", "Title", "Updated_at", "Updated_by", "status" },
                values: new object[,]
                {
                    { 1, 10m, true, new DateTime(2022, 6, 30, 22, 59, 14, 111, DateTimeKind.Local).AddTicks(6144), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e51"), new DateTime(2022, 6, 30, 22, 59, 14, 111, DateTimeKind.Local).AddTicks(7590), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e51"), "TestDescirption1", new DateTime(2022, 6, 30, 22, 59, 14, 111, DateTimeKind.Local).AddTicks(2366), 5f, new DateTime(2022, 6, 30, 22, 59, 14, 110, DateTimeKind.Local).AddTicks(4093), "TestTitle1", new DateTime(2022, 6, 30, 22, 59, 14, 111, DateTimeKind.Local).AddTicks(6597), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e51"), 0 },
                    { 2, 10m, true, new DateTime(2022, 6, 30, 22, 59, 14, 113, DateTimeKind.Local).AddTicks(4198), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e52"), new DateTime(2022, 6, 30, 22, 59, 14, 113, DateTimeKind.Local).AddTicks(4202), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e52"), "TestDescirption2", new DateTime(2022, 6, 30, 22, 59, 14, 113, DateTimeKind.Local).AddTicks(4191), 5f, new DateTime(2022, 6, 30, 22, 59, 14, 113, DateTimeKind.Local).AddTicks(4181), "TestTitle2", new DateTime(2022, 6, 30, 22, 59, 14, 113, DateTimeKind.Local).AddTicks(4200), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e52"), 0 },
                    { 3, 10m, true, new DateTime(2022, 6, 30, 22, 59, 14, 113, DateTimeKind.Local).AddTicks(4404), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e53"), new DateTime(2022, 6, 30, 22, 59, 14, 113, DateTimeKind.Local).AddTicks(4408), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e53"), "TestDescirption3", new DateTime(2022, 6, 30, 22, 59, 14, 113, DateTimeKind.Local).AddTicks(4401), 5f, new DateTime(2022, 6, 30, 22, 59, 14, 113, DateTimeKind.Local).AddTicks(4398), "TestTitle3", new DateTime(2022, 6, 30, 22, 59, 14, 113, DateTimeKind.Local).AddTicks(4406), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e53"), 0 },
                    { 4, 10m, true, new DateTime(2022, 6, 30, 22, 59, 14, 113, DateTimeKind.Local).AddTicks(4562), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e54"), new DateTime(2022, 6, 30, 22, 59, 14, 113, DateTimeKind.Local).AddTicks(4565), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e54"), "TestDescirption4", new DateTime(2022, 6, 30, 22, 59, 14, 113, DateTimeKind.Local).AddTicks(4559), 5f, new DateTime(2022, 6, 30, 22, 59, 14, 113, DateTimeKind.Local).AddTicks(4557), "TestTitle4", new DateTime(2022, 6, 30, 22, 59, 14, 113, DateTimeKind.Local).AddTicks(4563), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e54"), 0 },
                    { 5, 10m, true, new DateTime(2022, 6, 30, 22, 59, 14, 113, DateTimeKind.Local).AddTicks(4606), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e55"), new DateTime(2022, 6, 30, 22, 59, 14, 113, DateTimeKind.Local).AddTicks(4609), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e55"), "TestDescirption5", new DateTime(2022, 6, 30, 22, 59, 14, 113, DateTimeKind.Local).AddTicks(4603), 5f, new DateTime(2022, 6, 30, 22, 59, 14, 113, DateTimeKind.Local).AddTicks(4602), "TestTitle5", new DateTime(2022, 6, 30, 22, 59, 14, 113, DateTimeKind.Local).AddTicks(4607), new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e55"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056d"), "8acbf4b0-d4b2-40c5-925e-13f860b36832", "Docter", "Docter", "DOCTER" },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), "d110ec3c-aeb5-4258-b3da-3f8088aaf101", "Admin", "Admin", "ADMIN" },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"), "7e98b90a-e19b-43a1-9eae-82f706ab085c", "User", "User", "USER" }
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
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2634") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2639") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2638") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2637") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2636") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2635") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2649") },
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
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3362") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3361") },
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
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2623") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2628") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2629") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2620") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2621") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2622") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3371") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2624") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2625") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2626") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2627") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3370") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Created_at", "Created_by", "DOB", "Deleted_at", "Deleted_by", "DentistId", "Email", "EmailConfirmed", "FirstName", "Gender", "ImageUrl", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshTokenExpiryTime", "SecurityStamp", "Status", "Token", "TwoFactorEnabled", "Updated_at", "Updated_by", "UserName" },
                values: new object[,]
                {
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2632"), 0, "7c556756-3549-4a0e-a773-0c64c39f181d", new DateTime(2022, 6, 30, 15, 59, 14, 258, DateTimeKind.Utc).AddTicks(2915), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2632"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 258, DateTimeKind.Utc).AddTicks(2923), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2632"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, null, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEGHsSeQZePtwd17Th83EqXtCPW4SDVUR3O8ZUxdlWND+A1Cp9XsB+e14sXcOZ9b3Zg==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 258, DateTimeKind.Utc).AddTicks(2920), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2632"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2631"), 0, "450ac8c9-c7c8-44ab-be25-9e9e6747b14e", new DateTime(2022, 6, 30, 15, 59, 14, 247, DateTimeKind.Utc).AddTicks(6508), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2631"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 247, DateTimeKind.Utc).AddTicks(6516), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2631"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, null, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEEb+jsHd8gGAf4tenRpWQP2tyshw/O5TIIOxhjeCozIJbyEbkx3QGlFOkjUv98GA7g==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 247, DateTimeKind.Utc).AddTicks(6513), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2631"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2630"), 0, "4f6f501a-6b51-4155-900e-b7399d5298b0", new DateTime(2022, 6, 30, 15, 59, 14, 237, DateTimeKind.Utc).AddTicks(804), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2630"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 237, DateTimeKind.Utc).AddTicks(810), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2630"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, null, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAELCx/375uQ5t++lccJRfFf8lFHUtAatsA+d6Q2fUH9zdKuXpvd1rd4blfLACSdVNvw==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 237, DateTimeKind.Utc).AddTicks(808), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2630"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2629"), 0, "4908ea59-20a5-4dae-862b-723084a99f85", new DateTime(2022, 6, 30, 15, 59, 14, 226, DateTimeKind.Utc).AddTicks(4388), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2629"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 226, DateTimeKind.Utc).AddTicks(4393), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2629"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, null, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEFuZ+yLXM4KD4kkg7uET22xCXgWzRAb/q271w3qWZyeJJsVsnz8uf4YA0yCix+FL2w==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 226, DateTimeKind.Utc).AddTicks(4391), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2629"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2628"), 0, "fbdd170d-6b45-4715-963a-6241c387f51e", new DateTime(2022, 6, 30, 15, 59, 14, 215, DateTimeKind.Utc).AddTicks(8764), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2628"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 215, DateTimeKind.Utc).AddTicks(8772), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2628"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, null, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEEl4Kaj6s9/xDpEBNCTUXB0VbWFwiEsl4jeoygoXVddVyYw3k/IIj6CUYUDLNO6kng==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 215, DateTimeKind.Utc).AddTicks(8770), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2628"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2626"), 0, "3cc418de-3acd-4f46-852e-d2c8d5356c8f", new DateTime(2022, 6, 30, 15, 59, 14, 194, DateTimeKind.Utc).AddTicks(6787), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2626"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 194, DateTimeKind.Utc).AddTicks(6791), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2626"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, null, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEAT86ZvDvOFJblQsRcXTJonyc31KFZ7rDboLZ/eDJdtluH7LA8gPQq8LfxHwhuMlLg==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 194, DateTimeKind.Utc).AddTicks(6790), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2626"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2625"), 0, "c9bda496-e5ef-4a45-8c05-89241d2120ef", new DateTime(2022, 6, 30, 15, 59, 14, 184, DateTimeKind.Utc).AddTicks(1353), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2625"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 184, DateTimeKind.Utc).AddTicks(1360), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2625"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, null, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEIrLFFbVgH4E8R7kFZknclX5WEpZI8z3wWkJiBXxS2FhDeQQ7QqPCu+1MmmM0ujcdg==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 184, DateTimeKind.Utc).AddTicks(1358), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2625"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2624"), 0, "820ef68d-e78a-4859-9f9e-12c87afb468b", new DateTime(2022, 6, 30, 15, 59, 14, 173, DateTimeKind.Utc).AddTicks(5368), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2624"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 173, DateTimeKind.Utc).AddTicks(5374), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2624"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, null, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEBVMOZ3qu2MxY88a9izEYN+R7fLl5iYE3saF+77vFWkP2NFfWIN42nrJlGCYjWfKAQ==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 173, DateTimeKind.Utc).AddTicks(5372), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2624"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2623"), 0, "00432ea0-5c70-4296-a70d-0443543e51d1", new DateTime(2022, 6, 30, 15, 59, 14, 162, DateTimeKind.Utc).AddTicks(9419), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2623"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 162, DateTimeKind.Utc).AddTicks(9423), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2623"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, null, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEBG8Gbd5mBLlmw6bJ3S0qcq2EjBwnF7l3fSeFiiBZPvbvlv1wFJItPMa8HqdSe/yNA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 162, DateTimeKind.Utc).AddTicks(9422), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2623"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2622"), 0, "f6b0e1f4-c152-4ca4-b309-98709b8f802c", new DateTime(2022, 6, 30, 15, 59, 14, 152, DateTimeKind.Utc).AddTicks(4057), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2622"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 152, DateTimeKind.Utc).AddTicks(4064), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2622"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, null, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEE5bBu5mGx9ugSR3q0Q17BK42ie4mymI5VdAoA8XpC8uHbZLbcpudhbghLHL+CunSQ==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 152, DateTimeKind.Utc).AddTicks(4062), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2622"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2621"), 0, "bbb760d6-f5de-4470-9fd7-d7fe2deb716d", new DateTime(2022, 6, 30, 15, 59, 14, 141, DateTimeKind.Utc).AddTicks(7683), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2621"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 141, DateTimeKind.Utc).AddTicks(7691), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2621"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, null, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAENSR3G1xGYWzK+6HI1hQR2wVvybUh4u8uMjZB3xm/538k+yGvutfNkBdbcHAy+b7wA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 141, DateTimeKind.Utc).AddTicks(7688), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2621"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2620"), 0, "475a539c-945d-42aa-aba8-34ff5f9c0b06", new DateTime(2022, 6, 30, 15, 59, 14, 130, DateTimeKind.Utc).AddTicks(728), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2620"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 130, DateTimeKind.Utc).AddTicks(1789), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2620"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, null, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEITq7DlFM2YHWZTpdYwAz3GS5yE4Gb+QmF81fa1VA9IQfywetFt5i46lKwN6uD9aVw==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 130, DateTimeKind.Utc).AddTicks(1255), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2620"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2627"), 0, "e2ba718e-c223-4695-a7a4-5a61408fb187", new DateTime(2022, 6, 30, 15, 59, 14, 205, DateTimeKind.Utc).AddTicks(2641), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2627"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 205, DateTimeKind.Utc).AddTicks(2647), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2627"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, null, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEHncdN+SxKKoEyQzCgUoCuyRkZTfB83UpXr1UsGS9MmdvsLAtTAF/8TMAIkmFnThaA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 205, DateTimeKind.Utc).AddTicks(2645), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2627"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2633"), 0, "03931de0-188a-4ac1-b357-7c322db4ec13", new DateTime(2022, 6, 30, 15, 59, 14, 268, DateTimeKind.Utc).AddTicks(8958), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2633"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 268, DateTimeKind.Utc).AddTicks(8965), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2633"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, null, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAELM38DgAoiPQHjm7GVG0BZsDbhAdXjoWMOFdx4Rpbu+y6V68SDX4FG7DABEy9bYbAw==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 268, DateTimeKind.Utc).AddTicks(8962), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2633"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2636"), 0, "1cabedbf-cba8-4da3-b27d-0b62ccd728ad", new DateTime(2022, 6, 30, 15, 59, 14, 300, DateTimeKind.Utc).AddTicks(7277), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2636"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 300, DateTimeKind.Utc).AddTicks(7297), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2636"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, null, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEJptUSRpW0dzAgZPtCtkxvGEbzXzzz/ruO2P6J7cP0Fi3ukizLT0xNNkUhNxBzSnMQ==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 300, DateTimeKind.Utc).AddTicks(7294), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2636"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2635"), 0, "3c402927-6c5d-480b-bdd2-09bd32650e4d", new DateTime(2022, 6, 30, 15, 59, 14, 290, DateTimeKind.Utc).AddTicks(557), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2635"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 290, DateTimeKind.Utc).AddTicks(564), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2635"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, null, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEHmhLE6olKqhjFTPoGqL/z4beDD+AH+MzpGYUZU/7IqL5Fz/Q30XPgXUJzG3eSjkLQ==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 290, DateTimeKind.Utc).AddTicks(561), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2635"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2637"), 0, "d563249e-bfc9-4509-ad36-71696e88646a", new DateTime(2022, 6, 30, 15, 59, 14, 311, DateTimeKind.Utc).AddTicks(3073), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2637"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 311, DateTimeKind.Utc).AddTicks(3078), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2637"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, null, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEP8TWbwDY0sc55AGJFRIFkFCuV6BUDwjgxrOadnnXN0Ij3Cexgv2NitJxlAu0z7N5Q==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 311, DateTimeKind.Utc).AddTicks(3076), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2637"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2638"), 0, "39b771f4-6ee5-4315-8da7-b9846224fa25", new DateTime(2022, 6, 30, 15, 59, 14, 324, DateTimeKind.Utc).AddTicks(7099), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2638"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 324, DateTimeKind.Utc).AddTicks(7111), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2638"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, null, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEMez89nPJT5WEdkKIWB7sIB3JLhOoujkECXn7Idq4WZH5V7KYSdvoloq2nDxlDuyUQ==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 324, DateTimeKind.Utc).AddTicks(7107), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2638"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2640"), 0, "b441b400-cc43-4942-ab0d-ed40ce43826b", new DateTime(2022, 6, 30, 15, 59, 14, 346, DateTimeKind.Utc).AddTicks(3094), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2640"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 346, DateTimeKind.Utc).AddTicks(3101), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2640"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, null, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEPEr5pRBm8KCb3eMG0kNR1rnJ2Iv59iWIqP9FvyrwQwTqiPX4wbJIUIjxrq153p56g==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 346, DateTimeKind.Utc).AddTicks(3099), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2640"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Created_at", "Created_by", "DOB", "Deleted_at", "Deleted_by", "DentistId", "Email", "EmailConfirmed", "FirstName", "Gender", "ImageUrl", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshTokenExpiryTime", "SecurityStamp", "Status", "Token", "TwoFactorEnabled", "Updated_at", "Updated_by", "UserName" },
                values: new object[,]
                {
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2641"), 0, "cb625660-5610-4c92-9d7e-e0a49661928b", new DateTime(2022, 6, 30, 15, 59, 14, 356, DateTimeKind.Utc).AddTicks(8571), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2641"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 356, DateTimeKind.Utc).AddTicks(8575), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2641"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, null, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEMHLRRy3712huwu3BBuQ0LZvztR574C4+QMgBGb20StBQ2owUNPmqa4WxX4mNpQ7Aw==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 356, DateTimeKind.Utc).AddTicks(8574), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2641"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2642"), 0, "2d22ff3a-132e-44df-a668-09f347ddc63d", new DateTime(2022, 6, 30, 15, 59, 14, 367, DateTimeKind.Utc).AddTicks(5024), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2642"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 367, DateTimeKind.Utc).AddTicks(5029), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2642"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, null, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEG+TRv1/K3O+K7lB9RaI0ypx8/zdtgMN7bxlDhQDPlVmCc+RB2cSRoN/Qs6kC94ong==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 367, DateTimeKind.Utc).AddTicks(5028), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2642"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2643"), 0, "d41d0989-c5e5-4f9d-9d15-270cf4b7db6d", new DateTime(2022, 6, 30, 15, 59, 14, 378, DateTimeKind.Utc).AddTicks(963), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2643"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 378, DateTimeKind.Utc).AddTicks(969), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2643"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, null, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEIiuPTWstyyvLBJICrZab/ZDszEv43MwcKrvQN2o+gNzb5ULcwEzHUQqdVsWK8zcoA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 378, DateTimeKind.Utc).AddTicks(967), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2643"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2644"), 0, "650c67c3-9ae9-4df7-9a1d-0ced3211f8a7", new DateTime(2022, 6, 30, 15, 59, 14, 388, DateTimeKind.Utc).AddTicks(7142), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2644"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 388, DateTimeKind.Utc).AddTicks(7152), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2644"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, null, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEEsuuy/1Iq7U/hGC6KiP1wbmkzOJRZP4hCdRenI30dE+ww4MWqIltp015vZsDMBTPg==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 388, DateTimeKind.Utc).AddTicks(7149), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2644"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2645"), 0, "ede629d8-d2b2-4346-a784-759873472ece", new DateTime(2022, 6, 30, 15, 59, 14, 399, DateTimeKind.Utc).AddTicks(3132), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2645"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 399, DateTimeKind.Utc).AddTicks(3137), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2645"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, null, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEAEJBLzPKwZFuJcRqGX/WXx1DuPVKs5DBtwiDmbsdJgmEGSpMRb9dYf2ZBhrk1Hssg==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 399, DateTimeKind.Utc).AddTicks(3135), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2645"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2646"), 0, "d87336cd-c034-4ff1-bdc0-035284aec1b5", new DateTime(2022, 6, 30, 15, 59, 14, 409, DateTimeKind.Utc).AddTicks(9819), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2646"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 409, DateTimeKind.Utc).AddTicks(9828), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2646"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, null, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAECN/TfltWrETq9h777VamdOKso1h+xN3+pr7ai7k5Dw9/cqLHd/z47gvee5tU9+5lA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 409, DateTimeKind.Utc).AddTicks(9826), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2646"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2647"), 0, "b979688e-4768-4dda-b0a8-1a28fec0a5be", new DateTime(2022, 6, 30, 15, 59, 14, 420, DateTimeKind.Utc).AddTicks(9180), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2647"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 420, DateTimeKind.Utc).AddTicks(9194), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2647"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, null, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEOR711ztCsXA2Ao5Gg544odziMDwnW6/cwdFqIFljaWszgVFxakBj5z/wCy715Q0jA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 420, DateTimeKind.Utc).AddTicks(9190), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2647"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2648"), 0, "dfca0325-52b4-4b41-a622-15ef76d9311d", new DateTime(2022, 6, 30, 15, 59, 14, 438, DateTimeKind.Utc).AddTicks(6696), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2648"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 438, DateTimeKind.Utc).AddTicks(6709), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2648"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, null, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEIuOHp4o0yugDbzPp7kfMhGgDXpFCCSaXwBZ/FapIYiuf5zuFpig+tzweikcjK4vYA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 438, DateTimeKind.Utc).AddTicks(6706), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2648"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2649"), 0, "c65a4a3c-f005-4685-8a8f-6071ac8c4006", new DateTime(2022, 6, 30, 15, 59, 14, 449, DateTimeKind.Utc).AddTicks(3979), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2649"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 449, DateTimeKind.Utc).AddTicks(3987), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2649"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, null, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEPs0UwF0ZmEu+gfyOaMMmOS6SEraV0Rjg4isWvSPH3oUFZWj7gUaXxqXCeas49Y6rg==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 449, DateTimeKind.Utc).AddTicks(3984), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2649"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2650"), 0, "4bb7b146-5ebe-4808-bb43-569c0db202da", new DateTime(2022, 6, 30, 15, 59, 14, 465, DateTimeKind.Utc).AddTicks(2632), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2650"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 465, DateTimeKind.Utc).AddTicks(2642), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2650"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, null, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEA4xVOmFF1RCLw3By/ZuSU0hRsfEdjS4LigWEsCyr/w9qQHiVU8CnjwFtb3K7cXfKw==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 465, DateTimeKind.Utc).AddTicks(2639), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2650"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2634"), 0, "f4475524-570d-45b8-8a69-ac48e33422b9", new DateTime(2022, 6, 30, 15, 59, 14, 279, DateTimeKind.Utc).AddTicks(4719), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2634"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 279, DateTimeKind.Utc).AddTicks(4724), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2634"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, null, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAEEhbk4GZZzGzCapb/9mWok39hogdI79iRHeTIH5PIXT99JdrWd5o53BWJYYHF9D/Fw==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 279, DateTimeKind.Utc).AddTicks(4722), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2634"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2639"), 0, "f176110b-8c2d-4601-a9de-1976ca8a6046", new DateTime(2022, 6, 30, 15, 59, 14, 335, DateTimeKind.Utc).AddTicks(4254), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2639"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 335, DateTimeKind.Utc).AddTicks(4266), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2639"), null, "anhkhoahuynh90@gmail.com", false, "Huynh", 0, null, "Anh Khoa", false, null, null, null, "AQAAAAEAACcQAAAAECjYhMZ5lOG8tQJy7EAHQDAqDXm3+nM6bQ1qLrX+deV2DoRo0FQl3w9PuMO1VkyXXA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 335, DateTimeKind.Utc).AddTicks(4263), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2639"), null }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "Created_at", "Date", "Deleted_at", "Deleted_by", "Status", "Total", "Updated_at", "Updated_by", "UserId" },
                values: new object[,]
                {
                    { 31, new DateTime(2022, 6, 30, 15, 59, 14, 465, DateTimeKind.Utc).AddTicks(3144), new DateTime(2022, 6, 30, 15, 59, 14, 465, DateTimeKind.Utc).AddTicks(3139), new DateTime(2022, 6, 30, 15, 59, 14, 465, DateTimeKind.Utc).AddTicks(3149), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2650"), 0, 100m, new DateTime(2022, 6, 30, 15, 59, 14, 465, DateTimeKind.Utc).AddTicks(3146), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2650"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2650") },
                    { 30, new DateTime(2022, 6, 30, 15, 59, 14, 449, DateTimeKind.Utc).AddTicks(4137), new DateTime(2022, 6, 30, 15, 59, 14, 449, DateTimeKind.Utc).AddTicks(4134), new DateTime(2022, 6, 30, 15, 59, 14, 449, DateTimeKind.Utc).AddTicks(4141), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2649"), 0, 100m, new DateTime(2022, 6, 30, 15, 59, 14, 449, DateTimeKind.Utc).AddTicks(4139), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2649"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2649") },
                    { 1, new DateTime(2022, 6, 30, 15, 59, 14, 130, DateTimeKind.Utc).AddTicks(6377), new DateTime(2022, 6, 30, 15, 59, 14, 130, DateTimeKind.Utc).AddTicks(5111), new DateTime(2022, 6, 30, 15, 59, 14, 130, DateTimeKind.Utc).AddTicks(7224), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2620"), 0, 100m, new DateTime(2022, 6, 30, 15, 59, 14, 130, DateTimeKind.Utc).AddTicks(6784), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2620"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2620") },
                    { 2, new DateTime(2022, 6, 30, 15, 59, 14, 141, DateTimeKind.Utc).AddTicks(7897), new DateTime(2022, 6, 30, 15, 59, 14, 141, DateTimeKind.Utc).AddTicks(7894), new DateTime(2022, 6, 30, 15, 59, 14, 141, DateTimeKind.Utc).AddTicks(7901), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2621"), 0, 100m, new DateTime(2022, 6, 30, 15, 59, 14, 141, DateTimeKind.Utc).AddTicks(7899), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2621"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2621") },
                    { 3, new DateTime(2022, 6, 30, 15, 59, 14, 152, DateTimeKind.Utc).AddTicks(4250), new DateTime(2022, 6, 30, 15, 59, 14, 152, DateTimeKind.Utc).AddTicks(4247), new DateTime(2022, 6, 30, 15, 59, 14, 152, DateTimeKind.Utc).AddTicks(4253), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2622"), 0, 100m, new DateTime(2022, 6, 30, 15, 59, 14, 152, DateTimeKind.Utc).AddTicks(4252), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2622"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2622") },
                    { 4, new DateTime(2022, 6, 30, 15, 59, 14, 162, DateTimeKind.Utc).AddTicks(9497), new DateTime(2022, 6, 30, 15, 59, 14, 162, DateTimeKind.Utc).AddTicks(9495), new DateTime(2022, 6, 30, 15, 59, 14, 162, DateTimeKind.Utc).AddTicks(9500), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2623"), 0, 100m, new DateTime(2022, 6, 30, 15, 59, 14, 162, DateTimeKind.Utc).AddTicks(9499), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2623"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2623") },
                    { 5, new DateTime(2022, 6, 30, 15, 59, 14, 173, DateTimeKind.Utc).AddTicks(5563), new DateTime(2022, 6, 30, 15, 59, 14, 173, DateTimeKind.Utc).AddTicks(5560), new DateTime(2022, 6, 30, 15, 59, 14, 173, DateTimeKind.Utc).AddTicks(5566), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2624"), 0, 100m, new DateTime(2022, 6, 30, 15, 59, 14, 173, DateTimeKind.Utc).AddTicks(5564), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2624"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2624") },
                    { 6, new DateTime(2022, 6, 30, 15, 59, 14, 184, DateTimeKind.Utc).AddTicks(1547), new DateTime(2022, 6, 30, 15, 59, 14, 184, DateTimeKind.Utc).AddTicks(1544), new DateTime(2022, 6, 30, 15, 59, 14, 184, DateTimeKind.Utc).AddTicks(1550), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2625"), 0, 100m, new DateTime(2022, 6, 30, 15, 59, 14, 184, DateTimeKind.Utc).AddTicks(1548), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2625"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2625") },
                    { 7, new DateTime(2022, 6, 30, 15, 59, 14, 194, DateTimeKind.Utc).AddTicks(6867), new DateTime(2022, 6, 30, 15, 59, 14, 194, DateTimeKind.Utc).AddTicks(6865), new DateTime(2022, 6, 30, 15, 59, 14, 194, DateTimeKind.Utc).AddTicks(6870), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2626"), 0, 100m, new DateTime(2022, 6, 30, 15, 59, 14, 194, DateTimeKind.Utc).AddTicks(6868), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2626"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2626") },
                    { 9, new DateTime(2022, 6, 30, 15, 59, 14, 215, DateTimeKind.Utc).AddTicks(9008), new DateTime(2022, 6, 30, 15, 59, 14, 215, DateTimeKind.Utc).AddTicks(9005), new DateTime(2022, 6, 30, 15, 59, 14, 215, DateTimeKind.Utc).AddTicks(9011), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2628"), 0, 100m, new DateTime(2022, 6, 30, 15, 59, 14, 215, DateTimeKind.Utc).AddTicks(9010), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2628"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2628") },
                    { 10, new DateTime(2022, 6, 30, 15, 59, 14, 226, DateTimeKind.Utc).AddTicks(4566), new DateTime(2022, 6, 30, 15, 59, 14, 226, DateTimeKind.Utc).AddTicks(4563), new DateTime(2022, 6, 30, 15, 59, 14, 226, DateTimeKind.Utc).AddTicks(4569), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2629"), 0, 100m, new DateTime(2022, 6, 30, 15, 59, 14, 226, DateTimeKind.Utc).AddTicks(4567), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2629"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2629") },
                    { 11, new DateTime(2022, 6, 30, 15, 59, 14, 237, DateTimeKind.Utc).AddTicks(995), new DateTime(2022, 6, 30, 15, 59, 14, 237, DateTimeKind.Utc).AddTicks(992), new DateTime(2022, 6, 30, 15, 59, 14, 237, DateTimeKind.Utc).AddTicks(998), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2630"), 0, 100m, new DateTime(2022, 6, 30, 15, 59, 14, 237, DateTimeKind.Utc).AddTicks(997), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2630"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2630") },
                    { 12, new DateTime(2022, 6, 30, 15, 59, 14, 247, DateTimeKind.Utc).AddTicks(6831), new DateTime(2022, 6, 30, 15, 59, 14, 247, DateTimeKind.Utc).AddTicks(6825), new DateTime(2022, 6, 30, 15, 59, 14, 247, DateTimeKind.Utc).AddTicks(6838), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2631"), 0, 100m, new DateTime(2022, 6, 30, 15, 59, 14, 247, DateTimeKind.Utc).AddTicks(6835), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2631"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2631") },
                    { 13, new DateTime(2022, 6, 30, 15, 59, 14, 258, DateTimeKind.Utc).AddTicks(3172), new DateTime(2022, 6, 30, 15, 59, 14, 258, DateTimeKind.Utc).AddTicks(3167), new DateTime(2022, 6, 30, 15, 59, 14, 258, DateTimeKind.Utc).AddTicks(3175), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2632"), 0, 100m, new DateTime(2022, 6, 30, 15, 59, 14, 258, DateTimeKind.Utc).AddTicks(3173), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2632"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2632") },
                    { 14, new DateTime(2022, 6, 30, 15, 59, 14, 268, DateTimeKind.Utc).AddTicks(9348), new DateTime(2022, 6, 30, 15, 59, 14, 268, DateTimeKind.Utc).AddTicks(9345), new DateTime(2022, 6, 30, 15, 59, 14, 268, DateTimeKind.Utc).AddTicks(9351), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2633"), 0, 100m, new DateTime(2022, 6, 30, 15, 59, 14, 268, DateTimeKind.Utc).AddTicks(9349), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2633"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2633") },
                    { 8, new DateTime(2022, 6, 30, 15, 59, 14, 205, DateTimeKind.Utc).AddTicks(2813), new DateTime(2022, 6, 30, 15, 59, 14, 205, DateTimeKind.Utc).AddTicks(2811), new DateTime(2022, 6, 30, 15, 59, 14, 205, DateTimeKind.Utc).AddTicks(2817), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2627"), 0, 100m, new DateTime(2022, 6, 30, 15, 59, 14, 205, DateTimeKind.Utc).AddTicks(2815), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2627"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2627") },
                    { 16, new DateTime(2022, 6, 30, 15, 59, 14, 290, DateTimeKind.Utc).AddTicks(765), new DateTime(2022, 6, 30, 15, 59, 14, 290, DateTimeKind.Utc).AddTicks(762), new DateTime(2022, 6, 30, 15, 59, 14, 290, DateTimeKind.Utc).AddTicks(768), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2635"), 0, 100m, new DateTime(2022, 6, 30, 15, 59, 14, 290, DateTimeKind.Utc).AddTicks(766), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2635"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2635") },
                    { 15, new DateTime(2022, 6, 30, 15, 59, 14, 279, DateTimeKind.Utc).AddTicks(4827), new DateTime(2022, 6, 30, 15, 59, 14, 279, DateTimeKind.Utc).AddTicks(4824), new DateTime(2022, 6, 30, 15, 59, 14, 279, DateTimeKind.Utc).AddTicks(4830), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2634"), 0, 100m, new DateTime(2022, 6, 30, 15, 59, 14, 279, DateTimeKind.Utc).AddTicks(4828), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2634"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2634") },
                    { 28, new DateTime(2022, 6, 30, 15, 59, 14, 420, DateTimeKind.Utc).AddTicks(9438), new DateTime(2022, 6, 30, 15, 59, 14, 420, DateTimeKind.Utc).AddTicks(9433), new DateTime(2022, 6, 30, 15, 59, 14, 420, DateTimeKind.Utc).AddTicks(9442), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2647"), 0, 100m, new DateTime(2022, 6, 30, 15, 59, 14, 420, DateTimeKind.Utc).AddTicks(9440), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2647"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2647") },
                    { 27, new DateTime(2022, 6, 30, 15, 59, 14, 410, DateTimeKind.Utc).AddTicks(66), new DateTime(2022, 6, 30, 15, 59, 14, 410, DateTimeKind.Utc).AddTicks(61), new DateTime(2022, 6, 30, 15, 59, 14, 410, DateTimeKind.Utc).AddTicks(69), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2646"), 0, 100m, new DateTime(2022, 6, 30, 15, 59, 14, 410, DateTimeKind.Utc).AddTicks(67), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2646"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2646") },
                    { 26, new DateTime(2022, 6, 30, 15, 59, 14, 399, DateTimeKind.Utc).AddTicks(3241), new DateTime(2022, 6, 30, 15, 59, 14, 399, DateTimeKind.Utc).AddTicks(3238), new DateTime(2022, 6, 30, 15, 59, 14, 399, DateTimeKind.Utc).AddTicks(3244), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2645"), 0, 100m, new DateTime(2022, 6, 30, 15, 59, 14, 399, DateTimeKind.Utc).AddTicks(3242), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2645"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2645") },
                    { 24, new DateTime(2022, 6, 30, 15, 59, 14, 378, DateTimeKind.Utc).AddTicks(1123), new DateTime(2022, 6, 30, 15, 59, 14, 378, DateTimeKind.Utc).AddTicks(1121), new DateTime(2022, 6, 30, 15, 59, 14, 378, DateTimeKind.Utc).AddTicks(1127), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2643"), 0, 100m, new DateTime(2022, 6, 30, 15, 59, 14, 378, DateTimeKind.Utc).AddTicks(1125), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2643"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2643") },
                    { 23, new DateTime(2022, 6, 30, 15, 59, 14, 367, DateTimeKind.Utc).AddTicks(5277), new DateTime(2022, 6, 30, 15, 59, 14, 367, DateTimeKind.Utc).AddTicks(5274), new DateTime(2022, 6, 30, 15, 59, 14, 367, DateTimeKind.Utc).AddTicks(5280), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2642"), 0, 100m, new DateTime(2022, 6, 30, 15, 59, 14, 367, DateTimeKind.Utc).AddTicks(5278), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2642"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2642") },
                    { 25, new DateTime(2022, 6, 30, 15, 59, 14, 388, DateTimeKind.Utc).AddTicks(7370), new DateTime(2022, 6, 30, 15, 59, 14, 388, DateTimeKind.Utc).AddTicks(7367), new DateTime(2022, 6, 30, 15, 59, 14, 388, DateTimeKind.Utc).AddTicks(7373), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2644"), 0, 100m, new DateTime(2022, 6, 30, 15, 59, 14, 388, DateTimeKind.Utc).AddTicks(7371), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2644"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2644") },
                    { 29, new DateTime(2022, 6, 30, 15, 59, 14, 438, DateTimeKind.Utc).AddTicks(6968), new DateTime(2022, 6, 30, 15, 59, 14, 438, DateTimeKind.Utc).AddTicks(6962), new DateTime(2022, 6, 30, 15, 59, 14, 438, DateTimeKind.Utc).AddTicks(6973), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2648"), 0, 100m, new DateTime(2022, 6, 30, 15, 59, 14, 438, DateTimeKind.Utc).AddTicks(6970), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2648"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2648") },
                    { 21, new DateTime(2022, 6, 30, 15, 59, 14, 346, DateTimeKind.Utc).AddTicks(3327), new DateTime(2022, 6, 30, 15, 59, 14, 346, DateTimeKind.Utc).AddTicks(3323), new DateTime(2022, 6, 30, 15, 59, 14, 346, DateTimeKind.Utc).AddTicks(3331), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2640"), 0, 100m, new DateTime(2022, 6, 30, 15, 59, 14, 346, DateTimeKind.Utc).AddTicks(3329), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2640"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2640") },
                    { 20, new DateTime(2022, 6, 30, 15, 59, 14, 335, DateTimeKind.Utc).AddTicks(4739), new DateTime(2022, 6, 30, 15, 59, 14, 335, DateTimeKind.Utc).AddTicks(4735), new DateTime(2022, 6, 30, 15, 59, 14, 335, DateTimeKind.Utc).AddTicks(4743), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2639"), 0, 100m, new DateTime(2022, 6, 30, 15, 59, 14, 335, DateTimeKind.Utc).AddTicks(4741), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2639"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2639") },
                    { 19, new DateTime(2022, 6, 30, 15, 59, 14, 324, DateTimeKind.Utc).AddTicks(7480), new DateTime(2022, 6, 30, 15, 59, 14, 324, DateTimeKind.Utc).AddTicks(7475), new DateTime(2022, 6, 30, 15, 59, 14, 324, DateTimeKind.Utc).AddTicks(7484), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2638"), 0, 100m, new DateTime(2022, 6, 30, 15, 59, 14, 324, DateTimeKind.Utc).AddTicks(7481), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2638"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2638") },
                    { 18, new DateTime(2022, 6, 30, 15, 59, 14, 311, DateTimeKind.Utc).AddTicks(3178), new DateTime(2022, 6, 30, 15, 59, 14, 311, DateTimeKind.Utc).AddTicks(3175), new DateTime(2022, 6, 30, 15, 59, 14, 311, DateTimeKind.Utc).AddTicks(3181), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2637"), 0, 100m, new DateTime(2022, 6, 30, 15, 59, 14, 311, DateTimeKind.Utc).AddTicks(3179), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2637"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2637") },
                    { 17, new DateTime(2022, 6, 30, 15, 59, 14, 300, DateTimeKind.Utc).AddTicks(7634), new DateTime(2022, 6, 30, 15, 59, 14, 300, DateTimeKind.Utc).AddTicks(7631), new DateTime(2022, 6, 30, 15, 59, 14, 300, DateTimeKind.Utc).AddTicks(7638), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2636"), 0, 100m, new DateTime(2022, 6, 30, 15, 59, 14, 300, DateTimeKind.Utc).AddTicks(7636), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2636"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2636") },
                    { 22, new DateTime(2022, 6, 30, 15, 59, 14, 356, DateTimeKind.Utc).AddTicks(8660), new DateTime(2022, 6, 30, 15, 59, 14, 356, DateTimeKind.Utc).AddTicks(8657), new DateTime(2022, 6, 30, 15, 59, 14, 356, DateTimeKind.Utc).AddTicks(8662), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2641"), 0, 100m, new DateTime(2022, 6, 30, 15, 59, 14, 356, DateTimeKind.Utc).AddTicks(8661), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2641"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2641") }
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
                    { 1, new DateTime(2022, 6, 30, 22, 59, 14, 114, DateTimeKind.Local).AddTicks(7850), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a1"), new DateTime(2022, 6, 30, 22, 59, 14, 114, DateTimeKind.Local).AddTicks(8757), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a1"), 1, "testService@gmail.com1", 1m, "testProcedure1", 0, new DateTime(2022, 6, 30, 22, 59, 14, 114, DateTimeKind.Local).AddTicks(8289), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a1") },
                    { 2, new DateTime(2022, 6, 30, 22, 59, 14, 115, DateTimeKind.Local).AddTicks(1444), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a2"), new DateTime(2022, 6, 30, 22, 59, 14, 115, DateTimeKind.Local).AddTicks(1455), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a2"), 2, "testService@gmail.com2", 2m, "testProcedure2", 0, new DateTime(2022, 6, 30, 22, 59, 14, 115, DateTimeKind.Local).AddTicks(1451), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a2") },
                    { 3, new DateTime(2022, 6, 30, 22, 59, 14, 115, DateTimeKind.Local).AddTicks(1604), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a3"), new DateTime(2022, 6, 30, 22, 59, 14, 115, DateTimeKind.Local).AddTicks(1608), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a3"), 3, "testService@gmail.com3", 3m, "testProcedure3", 0, new DateTime(2022, 6, 30, 22, 59, 14, 115, DateTimeKind.Local).AddTicks(1607), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a3") },
                    { 4, new DateTime(2022, 6, 30, 22, 59, 14, 115, DateTimeKind.Local).AddTicks(1657), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a4"), new DateTime(2022, 6, 30, 22, 59, 14, 115, DateTimeKind.Local).AddTicks(1660), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a4"), 4, "testService@gmail.com4", 4m, "testProcedure4", 0, new DateTime(2022, 6, 30, 22, 59, 14, 115, DateTimeKind.Local).AddTicks(1659), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a4") },
                    { 5, new DateTime(2022, 6, 30, 22, 59, 14, 115, DateTimeKind.Local).AddTicks(1705), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a5"), new DateTime(2022, 6, 30, 22, 59, 14, 115, DateTimeKind.Local).AddTicks(1709), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a5"), 5, "testService@gmail.com5", 5m, "testProcedure5", 0, new DateTime(2022, 6, 30, 22, 59, 14, 115, DateTimeKind.Local).AddTicks(1707), new Guid("74965f04-3baa-44ef-878a-50862a6fe9a5") }
                });

            migrationBuilder.InsertData(
                table: "Booking_Details",
                columns: new[] { "Id", "BookingId", "Created_at", "Created_by", "Deleted_at", "Deleted_by", "DentistId", "KeyTime", "Note", "ServiceId", "Status", "Updated_at", "Updated_by" },
                values: new object[,]
                {
                    { 11, 4, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4923), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3313"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4925), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3313"), 13, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4924), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3313") },
                    { 34, 12, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5587), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3321"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5589), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3321"), 21, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5588), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3321") },
                    { 35, 12, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5609), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3321"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5611), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3321"), 21, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5610), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3321") },
                    { 36, 12, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5631), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3321"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5633), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3321"), 21, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5632), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3321") },
                    { 37, 13, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5652), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3322"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5655), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3322"), 22, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5654), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3322") },
                    { 38, 13, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5674), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3322"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5676), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3322"), 22, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5675), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3322") },
                    { 39, 13, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5695), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3322"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5697), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3322"), 22, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5696), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3322") },
                    { 40, 14, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5717), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3323"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5719), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3323"), 23, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5718), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3323") },
                    { 33, 11, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5560), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3320"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5563), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3320"), 20, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5562), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3320") },
                    { 41, 14, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5738), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3323"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5740), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3323"), 23, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5739), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3323") },
                    { 43, 15, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5843), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3324"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5845), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3324"), 24, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5844), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3324") },
                    { 44, 15, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5865), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3324"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5867), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3324"), 24, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5866), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3324") },
                    { 45, 15, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5886), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3324"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5888), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3324"), 24, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5887), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3324") },
                    { 46, 16, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5908), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3325"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5910), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3325"), 25, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5909), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3325") },
                    { 47, 16, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5929), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3325"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5931), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3325"), 25, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5930), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3325") },
                    { 48, 16, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5950), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3325"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5952), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3325"), 25, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5951), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3325") },
                    { 49, 17, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5971), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3326"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5973), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3326"), 26, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5972), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3326") },
                    { 42, 14, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5821), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3323"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5823), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3323"), 23, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5822), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3323") },
                    { 32, 11, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5488), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3320"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5490), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3320"), 20, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5489), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3320") },
                    { 31, 11, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5467), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3320"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5469), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3320"), 20, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5468), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3320") },
                    { 30, 10, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5445), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3319"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5447), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3319"), 19, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5446), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3319") },
                    { 13, 5, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4966), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3314"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4968), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3314"), 14, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4967), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3314") },
                    { 14, 5, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4987), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3314"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4990), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3314"), 14, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4988), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3314") },
                    { 15, 5, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5008), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3314"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5011), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3314"), 14, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5009), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3314") },
                    { 16, 6, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5085), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3315"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5088), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3315"), 15, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5087), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3315") },
                    { 17, 6, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5109), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3315"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5111), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3315"), 15, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5110), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3315") },
                    { 18, 6, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5133), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3315"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5135), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3315"), 15, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5134), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3315") },
                    { 19, 7, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5155), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3316"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5157), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3316"), 16, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5156), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3316") },
                    { 20, 7, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5177), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3316"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5179), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3316"), 16, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5178), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3316") },
                    { 21, 7, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5198), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3316"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5200), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3316"), 16, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5199), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3316") },
                    { 22, 8, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5219), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3317"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5221), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3317"), 17, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5220), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3317") },
                    { 23, 8, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5240), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3317"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5242), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3317"), 17, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5241), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3317") },
                    { 24, 8, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5261), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3317"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5263), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3317"), 17, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5262), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3317") },
                    { 25, 9, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5339), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3318"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5342), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3318"), 18, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5340), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3318") },
                    { 26, 9, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5361), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3318"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5363), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3318"), 18, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5362), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3318") },
                    { 27, 9, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5382), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3318"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5384), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3318"), 18, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5383), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3318") },
                    { 28, 10, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5403), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3319"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5406), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3319"), 19, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5404), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3319") },
                    { 29, 10, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5424), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3319"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5427), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3319"), 19, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(5426), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3319") },
                    { 50, 17, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6143), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3326"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6146), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3326"), 26, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6145), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3326") },
                    { 51, 17, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6173), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3326"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6175), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3326"), 26, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6174), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3326") },
                    { 52, 18, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6194), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3327"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6197), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3327"), 27, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6195), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3327") },
                    { 53, 18, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6216), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3327"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6218), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3327"), 27, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6217), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3327") }
                });

            migrationBuilder.InsertData(
                table: "Booking_Details",
                columns: new[] { "Id", "BookingId", "Created_at", "Created_by", "Deleted_at", "Deleted_by", "DentistId", "KeyTime", "Note", "ServiceId", "Status", "Updated_at", "Updated_by" },
                values: new object[,]
                {
                    { 75, 25, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6796), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3334"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6799), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3334"), 34, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6797), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3334") },
                    { 76, 26, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6871), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3335"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6873), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3335"), 35, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6872), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3335") },
                    { 77, 26, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6893), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3335"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6895), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3335"), 35, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6894), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3335") },
                    { 78, 26, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6915), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3335"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6917), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3335"), 35, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6916), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3335") },
                    { 79, 27, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6936), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3336"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6939), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3336"), 36, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6937), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3336") },
                    { 80, 27, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6957), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3336"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6960), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3336"), 36, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6958), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3336") },
                    { 81, 27, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6978), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3336"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6981), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3336"), 36, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6979), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3336") },
                    { 82, 28, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7000), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3337"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7002), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3337"), 37, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7001), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3337") },
                    { 83, 28, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7021), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3337"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7023), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3337"), 37, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7022), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3337") },
                    { 84, 28, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7094), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3337"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7096), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3337"), 37, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7095), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3337") },
                    { 85, 29, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7117), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3338"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7120), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3338"), 38, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7118), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3338") },
                    { 86, 29, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7138), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3338"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7141), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3338"), 38, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7139), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3338") },
                    { 87, 29, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7160), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3338"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7162), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3338"), 38, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7161), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3338") },
                    { 88, 30, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7181), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3339"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7184), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3339"), 39, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7182), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3339") },
                    { 89, 30, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7202), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3339"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7204), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3339"), 39, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7203), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3339") },
                    { 90, 30, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7223), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3339"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7225), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3339"), 39, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7224), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3339") },
                    { 91, 31, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7245), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3340"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7247), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3340"), 40, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7246), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3340") },
                    { 74, 25, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6775), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3334"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6778), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3334"), 34, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6776), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3334") },
                    { 12, 4, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4944), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3313"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4947), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3313"), 13, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4945), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3313") },
                    { 73, 25, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6754), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3334"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6756), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3334"), 34, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6755), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3334") },
                    { 71, 24, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6712), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3333"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6714), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3333"), 33, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6713), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3333") },
                    { 54, 18, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6236), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3327"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6239), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3327"), 27, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6237), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3327") },
                    { 55, 19, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6257), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3328"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6260), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3328"), 28, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6259), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3328") },
                    { 56, 19, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6278), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3328"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6281), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3328"), 28, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6279), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3328") },
                    { 57, 19, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6299), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3328"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6302), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3328"), 28, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6300), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3328") },
                    { 58, 20, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6320), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3329"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6323), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3329"), 29, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6322), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3329") },
                    { 59, 20, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6395), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3329"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6397), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3329"), 29, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6396), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3329") },
                    { 60, 20, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6418), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3329"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6421), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3329"), 29, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6419), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3329") },
                    { 61, 21, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6440), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3330"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6442), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3330"), 30, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6441), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3330") },
                    { 62, 21, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6461), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3330"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6464), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3330"), 30, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6463), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3330") },
                    { 63, 21, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6483), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3330"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6485), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3330"), 30, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6484), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3330") },
                    { 64, 22, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6504), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3331"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6507), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3331"), 31, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6506), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3331") },
                    { 65, 22, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6525), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3331"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6527), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3331"), 31, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6526), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3331") },
                    { 66, 22, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6548), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3331"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6550), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3331"), 31, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6549), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3331") },
                    { 67, 23, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6624), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3332"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6627), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3332"), 32, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6625), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3332") },
                    { 68, 23, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6646), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3332"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6649), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3332"), 32, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6647), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3332") },
                    { 69, 23, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6668), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3332"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6671), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3332"), 32, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6669), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3332") },
                    { 70, 24, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6690), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3333"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6692), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3333"), 33, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6691), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3333") },
                    { 72, 24, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6733), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3333"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6735), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3333"), 33, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(6734), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3333") },
                    { 92, 31, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7266), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3340"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7268), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3340"), 40, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7267), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3340") },
                    { 93, 31, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7342), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3340"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7344), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3340"), 40, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7343), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3340") },
                    { 9, 3, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4877), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3312"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4880), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3312"), 12, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4879), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3312") }
                });

            migrationBuilder.InsertData(
                table: "Booking_Details",
                columns: new[] { "Id", "BookingId", "Created_at", "Created_by", "Deleted_at", "Deleted_by", "DentistId", "KeyTime", "Note", "ServiceId", "Status", "Updated_at", "Updated_by" },
                values: new object[,]
                {
                    { 8, 3, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4856), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3312"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4859), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3312"), 12, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4857), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3312") },
                    { 7, 3, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4830), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3312"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4833), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3312"), 12, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4831), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3312") },
                    { 6, 2, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4743), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3311"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4745), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3311"), 11, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4744), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3311") },
                    { 5, 2, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4716), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3311"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4718), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3311"), 11, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4717), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3311") },
                    { 4, 2, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4693), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3311"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4696), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3311"), 11, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4695), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3311") },
                    { 3, 1, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4669), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3310"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4671), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3310"), 10, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4670), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3310") },
                    { 2, 1, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4624), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3310"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4630), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3310"), 10, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4628), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3310") },
                    { 1, 1, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(1066), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3310"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(2087), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3310"), 10, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(1504), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3310") },
                    { 10, 4, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4901), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3313"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4903), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3313"), 13, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(4902), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3313") }
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
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Created_at", "Created_by", "DOB", "Deleted_at", "Deleted_by", "DentistId", "Email", "EmailConfirmed", "FirstName", "Gender", "ImageUrl", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshTokenExpiryTime", "SecurityStamp", "Status", "Token", "TwoFactorEnabled", "Updated_at", "Updated_by", "UserName" },
                values: new object[,]
                {
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"), 0, "d91255bb-c51c-4c2c-8167-1724eaaa229e", new DateTime(2022, 6, 30, 15, 59, 14, 572, DateTimeKind.Utc).AddTicks(4189), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 572, DateTimeKind.Utc).AddTicks(4196), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"), 59, "ducsama90@gmail.com", false, "Nguyen", 1, null, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEIGsNMu1YdhV0xsHJNS0PrmeEGV5u5vZynU8L2xNj9k8ouXvnujQfyRNWfvYaNMHOA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 572, DateTimeKind.Utc).AddTicks(4194), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"), 0, "eb2eac42-ad67-44a4-a80a-13cdafe1e173", new DateTime(2022, 6, 30, 15, 59, 14, 491, DateTimeKind.Utc).AddTicks(7183), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 491, DateTimeKind.Utc).AddTicks(7190), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"), 52, "ducsama90@gmail.com", false, "Nguyen", 1, null, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEMHT3veZUw3fOhaLEXGftDK3aCoz84+zs2sPaVfnXuAn5Vdi8+37PLtbCqPNnl5MUg==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 491, DateTimeKind.Utc).AddTicks(7188), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"), 0, "3f37704c-6b3a-45f2-8c55-d2554d2f55e6", new DateTime(2022, 6, 30, 15, 59, 14, 502, DateTimeKind.Utc).AddTicks(3412), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 502, DateTimeKind.Utc).AddTicks(3419), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"), 53, "ducsama90@gmail.com", false, "Nguyen", 1, null, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEKdLYLHW/SJpXtDR2gXmT6e6Vb9uCAsJ7Azphq+GMnDx8kwHNsZqWfiHTFkCgMaSCg==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 502, DateTimeKind.Utc).AddTicks(3417), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"), 0, "2f0158e7-5233-4a9c-b6f8-5ed25b6cb50a", new DateTime(2022, 6, 30, 15, 59, 14, 512, DateTimeKind.Utc).AddTicks(9033), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 512, DateTimeKind.Utc).AddTicks(9038), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"), 54, "ducsama90@gmail.com", false, "Nguyen", 1, null, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEFLLJep+SI7e8M1KLBL7Gtow/22kaHuGawdKM1/sT1APMJ2wo768EZSqdgjOQ+8Asw==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 512, DateTimeKind.Utc).AddTicks(9037), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"), 0, "91f6a30a-9a5c-4b75-aea8-d38319489cef", new DateTime(2022, 6, 30, 15, 59, 14, 528, DateTimeKind.Utc).AddTicks(2055), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 528, DateTimeKind.Utc).AddTicks(2068), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"), 55, "ducsama90@gmail.com", false, "Nguyen", 1, null, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEBGbcvDRkAkj3ITFEJUzTbpRvUlg+vPOUBK12EO+KkG1IDfJVxdOA+UR0rqxCuos9w==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 528, DateTimeKind.Utc).AddTicks(2065), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"), 0, "b51a355a-5ab0-42bf-99bb-cad014b73ff0", new DateTime(2022, 6, 30, 15, 59, 14, 540, DateTimeKind.Utc).AddTicks(6461), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 540, DateTimeKind.Utc).AddTicks(6468), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"), 56, "ducsama90@gmail.com", false, "Nguyen", 1, null, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEMChTQNnSJYjkrAZudXd1b2o5XSz7xCgVog0wsBErBMsZ25kKY6uNGLcKAatcjnjoA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 540, DateTimeKind.Utc).AddTicks(6467), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"), 0, "cd169186-5bc3-46a4-a5a4-fa4ff1ccc9c6", new DateTime(2022, 6, 30, 15, 59, 14, 551, DateTimeKind.Utc).AddTicks(2491), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 551, DateTimeKind.Utc).AddTicks(2500), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"), 57, "ducsama90@gmail.com", false, "Nguyen", 1, null, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAENG83FqFRju2WWKQbmfIx+Z7bk3paEQycA4LNDUfJihfodwJeNfmHbRe4rm2hg0ZLw==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 551, DateTimeKind.Utc).AddTicks(2498), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"), 0, "e8f3a4dc-e6ad-4837-819a-2c0e546552be", new DateTime(2022, 6, 30, 15, 59, 14, 561, DateTimeKind.Utc).AddTicks(8267), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 561, DateTimeKind.Utc).AddTicks(8271), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"), 58, "ducsama90@gmail.com", false, "Nguyen", 1, null, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEHSIIRMWpblDqNn/Z/yNp33wP1gWiGQ0t1GtlqpcKnNR7Lb9Q5hnRbLB9Rnr1MtIVA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 561, DateTimeKind.Utc).AddTicks(8270), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"), 0, "37ea7bb6-ee9a-4821-a629-9670149055c1", new DateTime(2022, 6, 30, 15, 59, 14, 582, DateTimeKind.Utc).AddTicks(9892), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 582, DateTimeKind.Utc).AddTicks(9899), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"), 60, "ducsama90@gmail.com", false, "Nguyen", 1, null, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEOVunvtTQ1AGY3IeeJInG42D5dWxZ5ABaFiMEoCrNmmhdHSZi1jFFrekllT5ki8pkw==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 582, DateTimeKind.Utc).AddTicks(9897), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3366"), 0, "2bd4fb92-9389-4ec0-b3b6-962ca195944c", new DateTime(2022, 6, 30, 15, 59, 14, 650, DateTimeKind.Utc).AddTicks(4682), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3366"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 650, DateTimeKind.Utc).AddTicks(4688), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3366"), 66, "ducsama90@gmail.com", false, "Nguyen", 1, null, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEEWEmQsiAXHtA9tv/iiyLfROUMdEZy0cs2ZwBpZy3bRjDEj7WRFH/mMz9zj8TOeB6w==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 650, DateTimeKind.Utc).AddTicks(4686), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3366"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3362"), 0, "8c47adcf-e340-4d6f-b1c4-769ca38ef274", new DateTime(2022, 6, 30, 15, 59, 14, 608, DateTimeKind.Utc).AddTicks(1356), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3362"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 608, DateTimeKind.Utc).AddTicks(1365), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3362"), 62, "ducsama90@gmail.com", false, "Nguyen", 1, null, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEGq/ls+1aXa1nA6nsbl8Z/Q9jAHqoLI/a/CM/C8VatpZJVtWwKTI6aLXIaVIjYNNag==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 608, DateTimeKind.Utc).AddTicks(1363), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3362"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3363"), 0, "e335cec1-c100-4e86-813b-5b5a0a11b421", new DateTime(2022, 6, 30, 15, 59, 14, 618, DateTimeKind.Utc).AddTicks(7682), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3363"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 618, DateTimeKind.Utc).AddTicks(7689), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3363"), 63, "ducsama90@gmail.com", false, "Nguyen", 1, null, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEJiuZlZ1nFMxuuTrw7d1SDnqXeDXBRtsqF7Zz83Zc6V/8fuFdlGkSGv1eogOhTsVnA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 618, DateTimeKind.Utc).AddTicks(7687), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3363"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3364"), 0, "906667ec-1323-44f1-b76b-f98d22c2bfff", new DateTime(2022, 6, 30, 15, 59, 14, 629, DateTimeKind.Utc).AddTicks(3389), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3364"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 629, DateTimeKind.Utc).AddTicks(3394), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3364"), 64, "ducsama90@gmail.com", false, "Nguyen", 1, null, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEAgXza3I2FH60Gm7Bzt1Eb14f04A7iR1HhZo+tbpS1KxUlnmDQxAqa2QtUZUCt30pA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 629, DateTimeKind.Utc).AddTicks(3393), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3364"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3365"), 0, "7ce0fb64-cafd-498e-92c8-feec5274f5f2", new DateTime(2022, 6, 30, 15, 59, 14, 639, DateTimeKind.Utc).AddTicks(8775), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3365"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 639, DateTimeKind.Utc).AddTicks(8779), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3365"), 65, "ducsama90@gmail.com", false, "Nguyen", 1, null, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAECtJ2V20sWdBtURLN7zXS1KgtE1v51WRvVev/DfArPjZ+zLn8l7j9nJb73lav04mTw==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 639, DateTimeKind.Utc).AddTicks(8778), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3365"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3367"), 0, "5c98bd1a-8ddb-4354-96e9-0b735b737ee4", new DateTime(2022, 6, 30, 15, 59, 14, 661, DateTimeKind.Utc).AddTicks(253), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3367"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 661, DateTimeKind.Utc).AddTicks(258), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3367"), 67, "ducsama90@gmail.com", false, "Nguyen", 1, null, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEF40oYbcGxylqVj/2O1B1n8JDYGgjxuzR5QjxndDEWii5+4kILzYMSqxVur9W+DaNQ==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 661, DateTimeKind.Utc).AddTicks(256), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3367"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3368"), 0, "43fc4a57-65f5-42bb-b2e4-9b6eab93ce26", new DateTime(2022, 6, 30, 15, 59, 14, 671, DateTimeKind.Utc).AddTicks(5427), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3368"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 671, DateTimeKind.Utc).AddTicks(5430), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3368"), 68, "ducsama90@gmail.com", false, "Nguyen", 1, null, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEHJ75q/iykKqim8ZLKIyE+9iZX3sBN98kLXuZurV62aKHLWkxYNhZosfQa0iNrUwdg==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 671, DateTimeKind.Utc).AddTicks(5429), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3368"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3369"), 0, "1d410fa4-3804-4594-aaf6-1d08d1a6506d", new DateTime(2022, 6, 30, 15, 59, 14, 682, DateTimeKind.Utc).AddTicks(1113), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3369"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 682, DateTimeKind.Utc).AddTicks(1118), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3369"), 69, "ducsama90@gmail.com", false, "Nguyen", 1, null, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEN90Po/5gDrzaNQ7dQLe+sQee81stPu+k5tTmjYD71tbIG1mppy6aek35LXSQx6YbA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 682, DateTimeKind.Utc).AddTicks(1117), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3369"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3370"), 0, "7aaee9b1-52dd-4c5b-80cb-143cb6f0d078", new DateTime(2022, 6, 30, 15, 59, 14, 692, DateTimeKind.Utc).AddTicks(6831), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3370"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 692, DateTimeKind.Utc).AddTicks(6837), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3370"), 70, "ducsama90@gmail.com", false, "Nguyen", 1, null, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAELu3YeBD+0g7UQdhDGHtfE3YNKb89DG9AbtFIpjTCgCNS2ayE0EISJ5fO6rrMYbQSQ==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 692, DateTimeKind.Utc).AddTicks(6835), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3370"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3371"), 0, "75a780f7-472d-4ba7-9e4f-334aa7d9650e", new DateTime(2022, 6, 30, 15, 59, 14, 703, DateTimeKind.Utc).AddTicks(6454), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3371"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 703, DateTimeKind.Utc).AddTicks(6466), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3371"), 71, "ducsama90@gmail.com", false, "Nguyen", 1, null, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEHKjo60/OP3cYPLykDtEMZtl9b1BOeEHUvtUs7JiwHiJDGr2sWHp/wU1L50wwzmQcA==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 703, DateTimeKind.Utc).AddTicks(6463), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3371"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3361"), 0, "906f322a-5438-4081-ac79-7c3ee6c32083", new DateTime(2022, 6, 30, 15, 59, 14, 593, DateTimeKind.Utc).AddTicks(5446), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3361"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 593, DateTimeKind.Utc).AddTicks(5450), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3361"), 61, "ducsama90@gmail.com", false, "Nguyen", 1, null, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEBOKjlSP1musu1/3SyEpJ9flxbiWieLrTuo+xJQ4xYZN/a7/9DjWPGJDiKVpp5qzjg==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 593, DateTimeKind.Utc).AddTicks(5448), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3361"), null },
                    { new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"), 0, "168585c7-06f3-4f4d-85fb-e32c47b1541c", new DateTime(2022, 6, 30, 15, 59, 14, 481, DateTimeKind.Utc).AddTicks(67), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 15, 59, 14, 481, DateTimeKind.Utc).AddTicks(75), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"), 51, "ducsama90@gmail.com", false, "Nguyen", 1, null, "Duong Minh Duc", false, null, null, null, "AQAAAAEAACcQAAAAEN2x4X9miiyY4b5yyRwXByXxmWaHH0cnTAUqVxeLF1inLVbQUy5OCfl6iuqFgs96ow==", "0868644651", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, new DateTime(2022, 6, 30, 15, 59, 14, 481, DateTimeKind.Utc).AddTicks(73), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"), null }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "Created_at", "Date", "Deleted_at", "Deleted_by", "Status", "Total", "Updated_at", "Updated_by", "UserId" },
                values: new object[,]
                {
                    { 32, new DateTime(2022, 6, 30, 15, 59, 14, 481, DateTimeKind.Utc).AddTicks(1175), new DateTime(2022, 6, 30, 15, 59, 14, 481, DateTimeKind.Utc).AddTicks(1168), new DateTime(2022, 6, 30, 15, 59, 14, 481, DateTimeKind.Utc).AddTicks(1178), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"), 0, 200m, new DateTime(2022, 6, 30, 15, 59, 14, 481, DateTimeKind.Utc).AddTicks(1176), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351") },
                    { 50, new DateTime(2022, 6, 30, 15, 59, 14, 682, DateTimeKind.Utc).AddTicks(1211), new DateTime(2022, 6, 30, 15, 59, 14, 682, DateTimeKind.Utc).AddTicks(1208), new DateTime(2022, 6, 30, 15, 59, 14, 682, DateTimeKind.Utc).AddTicks(1214), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3369"), 0, 200m, new DateTime(2022, 6, 30, 15, 59, 14, 682, DateTimeKind.Utc).AddTicks(1212), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3369"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3369") },
                    { 49, new DateTime(2022, 6, 30, 15, 59, 14, 671, DateTimeKind.Utc).AddTicks(5534), new DateTime(2022, 6, 30, 15, 59, 14, 671, DateTimeKind.Utc).AddTicks(5532), new DateTime(2022, 6, 30, 15, 59, 14, 671, DateTimeKind.Utc).AddTicks(5537), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3368"), 0, 200m, new DateTime(2022, 6, 30, 15, 59, 14, 671, DateTimeKind.Utc).AddTicks(5536), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3368"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3368") },
                    { 48, new DateTime(2022, 6, 30, 15, 59, 14, 661, DateTimeKind.Utc).AddTicks(349), new DateTime(2022, 6, 30, 15, 59, 14, 661, DateTimeKind.Utc).AddTicks(347), new DateTime(2022, 6, 30, 15, 59, 14, 661, DateTimeKind.Utc).AddTicks(352), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3367"), 0, 200m, new DateTime(2022, 6, 30, 15, 59, 14, 661, DateTimeKind.Utc).AddTicks(350), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3367"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3367") },
                    { 47, new DateTime(2022, 6, 30, 15, 59, 14, 650, DateTimeKind.Utc).AddTicks(4786), new DateTime(2022, 6, 30, 15, 59, 14, 650, DateTimeKind.Utc).AddTicks(4783), new DateTime(2022, 6, 30, 15, 59, 14, 650, DateTimeKind.Utc).AddTicks(4789), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3366"), 0, 200m, new DateTime(2022, 6, 30, 15, 59, 14, 650, DateTimeKind.Utc).AddTicks(4787), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3366"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3366") },
                    { 46, new DateTime(2022, 6, 30, 15, 59, 14, 639, DateTimeKind.Utc).AddTicks(8822), new DateTime(2022, 6, 30, 15, 59, 14, 639, DateTimeKind.Utc).AddTicks(8820), new DateTime(2022, 6, 30, 15, 59, 14, 639, DateTimeKind.Utc).AddTicks(8825), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3365"), 0, 200m, new DateTime(2022, 6, 30, 15, 59, 14, 639, DateTimeKind.Utc).AddTicks(8823), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3365"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3365") },
                    { 45, new DateTime(2022, 6, 30, 15, 59, 14, 629, DateTimeKind.Utc).AddTicks(3489), new DateTime(2022, 6, 30, 15, 59, 14, 629, DateTimeKind.Utc).AddTicks(3487), new DateTime(2022, 6, 30, 15, 59, 14, 629, DateTimeKind.Utc).AddTicks(3492), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3364"), 0, 200m, new DateTime(2022, 6, 30, 15, 59, 14, 629, DateTimeKind.Utc).AddTicks(3490), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3364"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3364") },
                    { 44, new DateTime(2022, 6, 30, 15, 59, 14, 618, DateTimeKind.Utc).AddTicks(7825), new DateTime(2022, 6, 30, 15, 59, 14, 618, DateTimeKind.Utc).AddTicks(7822), new DateTime(2022, 6, 30, 15, 59, 14, 618, DateTimeKind.Utc).AddTicks(7828), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3363"), 0, 200m, new DateTime(2022, 6, 30, 15, 59, 14, 618, DateTimeKind.Utc).AddTicks(7826), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3363"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3363") },
                    { 43, new DateTime(2022, 6, 30, 15, 59, 14, 608, DateTimeKind.Utc).AddTicks(1560), new DateTime(2022, 6, 30, 15, 59, 14, 608, DateTimeKind.Utc).AddTicks(1557), new DateTime(2022, 6, 30, 15, 59, 14, 608, DateTimeKind.Utc).AddTicks(1563), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3362"), 0, 200m, new DateTime(2022, 6, 30, 15, 59, 14, 608, DateTimeKind.Utc).AddTicks(1562), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3362"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3362") },
                    { 51, new DateTime(2022, 6, 30, 15, 59, 14, 692, DateTimeKind.Utc).AddTicks(6929), new DateTime(2022, 6, 30, 15, 59, 14, 692, DateTimeKind.Utc).AddTicks(6926), new DateTime(2022, 6, 30, 15, 59, 14, 692, DateTimeKind.Utc).AddTicks(6931), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3370"), 0, 200m, new DateTime(2022, 6, 30, 15, 59, 14, 692, DateTimeKind.Utc).AddTicks(6930), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3370"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3370") },
                    { 42, new DateTime(2022, 6, 30, 15, 59, 14, 593, DateTimeKind.Utc).AddTicks(5789), new DateTime(2022, 6, 30, 15, 59, 14, 593, DateTimeKind.Utc).AddTicks(5500), new DateTime(2022, 6, 30, 15, 59, 14, 593, DateTimeKind.Utc).AddTicks(5796), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3361"), 0, 200m, new DateTime(2022, 6, 30, 15, 59, 14, 593, DateTimeKind.Utc).AddTicks(5794), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3361"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3361") },
                    { 40, new DateTime(2022, 6, 30, 15, 59, 14, 572, DateTimeKind.Utc).AddTicks(4325), new DateTime(2022, 6, 30, 15, 59, 14, 572, DateTimeKind.Utc).AddTicks(4322), new DateTime(2022, 6, 30, 15, 59, 14, 572, DateTimeKind.Utc).AddTicks(4328), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"), 0, 200m, new DateTime(2022, 6, 30, 15, 59, 14, 572, DateTimeKind.Utc).AddTicks(4326), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359") },
                    { 39, new DateTime(2022, 6, 30, 15, 59, 14, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2022, 6, 30, 15, 59, 14, 561, DateTimeKind.Utc).AddTicks(8325), new DateTime(2022, 6, 30, 15, 59, 14, 561, DateTimeKind.Utc).AddTicks(8330), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"), 0, 200m, new DateTime(2022, 6, 30, 15, 59, 14, 561, DateTimeKind.Utc).AddTicks(8329), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358") },
                    { 38, new DateTime(2022, 6, 30, 15, 59, 14, 551, DateTimeKind.Utc).AddTicks(2643), new DateTime(2022, 6, 30, 15, 59, 14, 551, DateTimeKind.Utc).AddTicks(2640), new DateTime(2022, 6, 30, 15, 59, 14, 551, DateTimeKind.Utc).AddTicks(2646), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"), 0, 200m, new DateTime(2022, 6, 30, 15, 59, 14, 551, DateTimeKind.Utc).AddTicks(2644), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357") },
                    { 37, new DateTime(2022, 6, 30, 15, 59, 14, 540, DateTimeKind.Utc).AddTicks(6671), new DateTime(2022, 6, 30, 15, 59, 14, 540, DateTimeKind.Utc).AddTicks(6667), new DateTime(2022, 6, 30, 15, 59, 14, 540, DateTimeKind.Utc).AddTicks(6674), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"), 0, 200m, new DateTime(2022, 6, 30, 15, 59, 14, 540, DateTimeKind.Utc).AddTicks(6672), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356") },
                    { 36, new DateTime(2022, 6, 30, 15, 59, 14, 528, DateTimeKind.Utc).AddTicks(2578), new DateTime(2022, 6, 30, 15, 59, 14, 528, DateTimeKind.Utc).AddTicks(2572), new DateTime(2022, 6, 30, 15, 59, 14, 528, DateTimeKind.Utc).AddTicks(2582), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"), 0, 200m, new DateTime(2022, 6, 30, 15, 59, 14, 528, DateTimeKind.Utc).AddTicks(2580), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355") },
                    { 35, new DateTime(2022, 6, 30, 15, 59, 14, 512, DateTimeKind.Utc).AddTicks(9130), new DateTime(2022, 6, 30, 15, 59, 14, 512, DateTimeKind.Utc).AddTicks(9127), new DateTime(2022, 6, 30, 15, 59, 14, 512, DateTimeKind.Utc).AddTicks(9133), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"), 0, 200m, new DateTime(2022, 6, 30, 15, 59, 14, 512, DateTimeKind.Utc).AddTicks(9132), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354") },
                    { 34, new DateTime(2022, 6, 30, 15, 59, 14, 502, DateTimeKind.Utc).AddTicks(3558), new DateTime(2022, 6, 30, 15, 59, 14, 502, DateTimeKind.Utc).AddTicks(3555), new DateTime(2022, 6, 30, 15, 59, 14, 502, DateTimeKind.Utc).AddTicks(3561), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"), 0, 200m, new DateTime(2022, 6, 30, 15, 59, 14, 502, DateTimeKind.Utc).AddTicks(3559), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353") },
                    { 33, new DateTime(2022, 6, 30, 15, 59, 14, 491, DateTimeKind.Utc).AddTicks(7369), new DateTime(2022, 6, 30, 15, 59, 14, 491, DateTimeKind.Utc).AddTicks(7366), new DateTime(2022, 6, 30, 15, 59, 14, 491, DateTimeKind.Utc).AddTicks(7372), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"), 0, 200m, new DateTime(2022, 6, 30, 15, 59, 14, 491, DateTimeKind.Utc).AddTicks(7370), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352") },
                    { 41, new DateTime(2022, 6, 30, 15, 59, 14, 583, DateTimeKind.Utc).AddTicks(80), new DateTime(2022, 6, 30, 15, 59, 14, 583, DateTimeKind.Utc).AddTicks(77), new DateTime(2022, 6, 30, 15, 59, 14, 583, DateTimeKind.Utc).AddTicks(83), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"), 0, 200m, new DateTime(2022, 6, 30, 15, 59, 14, 583, DateTimeKind.Utc).AddTicks(82), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360") },
                    { 52, new DateTime(2022, 6, 30, 15, 59, 14, 703, DateTimeKind.Utc).AddTicks(6644), new DateTime(2022, 6, 30, 15, 59, 14, 703, DateTimeKind.Utc).AddTicks(6641), new DateTime(2022, 6, 30, 15, 59, 14, 703, DateTimeKind.Utc).AddTicks(6647), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3371"), 0, 200m, new DateTime(2022, 6, 30, 15, 59, 14, 703, DateTimeKind.Utc).AddTicks(6646), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3371"), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3371") }
                });

            migrationBuilder.InsertData(
                table: "Booking_Details",
                columns: new[] { "Id", "BookingId", "Created_at", "Created_by", "Deleted_at", "Deleted_by", "DentistId", "KeyTime", "Note", "ServiceId", "Status", "Updated_at", "Updated_by" },
                values: new object[,]
                {
                    { 94, 32, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7367), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3341"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7369), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3341"), 41, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7368), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3341") },
                    { 126, 42, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8302), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8304), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"), 51, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8303), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351") },
                    { 127, 43, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8323), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8325), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"), 52, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8324), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352") },
                    { 128, 43, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8396), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8399), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"), 52, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8398), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352") },
                    { 129, 43, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8421), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8423), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"), 52, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8422), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352") },
                    { 130, 44, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8445), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8447), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"), 53, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8446), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353") },
                    { 131, 44, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8467), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8469), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"), 53, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8468), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353") },
                    { 132, 44, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8489), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8492), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"), 53, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8490), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353") },
                    { 133, 45, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8511), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8513), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"), 54, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8512), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354") },
                    { 134, 45, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8533), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8535), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"), 54, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8534), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354") },
                    { 135, 45, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8611), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8613), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"), 54, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8612), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354") },
                    { 136, 46, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8633), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8635), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"), 55, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8634), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355") },
                    { 137, 46, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8654), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8656), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"), 55, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8655), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355") },
                    { 125, 42, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8281), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8283), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"), 51, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8282), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351") },
                    { 138, 46, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8675), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8677), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"), 55, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8676), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355") },
                    { 140, 47, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8717), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8719), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"), 56, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8718), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356") },
                    { 141, 47, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8738), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8740), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"), 56, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8739), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356") },
                    { 142, 48, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8759), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8761), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"), 57, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8760), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357") },
                    { 143, 48, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8780), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8782), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"), 57, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8781), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357") },
                    { 144, 48, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8856), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8858), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"), 57, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8857), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357") },
                    { 145, 49, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8878), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8880), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"), 58, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8879), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358") },
                    { 146, 49, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8900), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8902), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"), 58, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8901), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358") },
                    { 147, 49, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8921), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8924), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"), 58, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8922), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358") },
                    { 148, 50, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8943), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8945), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"), 59, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8944), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359") },
                    { 149, 50, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8964), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8967), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"), 59, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8965), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359") },
                    { 150, 50, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8985), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8987), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"), 59, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8986), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359") },
                    { 151, 51, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(9006), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(9008), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"), 60, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(9007), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360") },
                    { 139, 47, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8696), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8698), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"), 56, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8697), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356") },
                    { 124, 42, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8260), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8262), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"), 51, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8261), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351") },
                    { 123, 41, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8238), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3350"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8241), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3350"), 50, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8240), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3350") },
                    { 122, 41, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8217), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3350"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8220), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3350"), 50, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8218), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3350") },
                    { 95, 32, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7388), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3341"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7391), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3341"), 41, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7389), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3341") },
                    { 96, 32, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7411), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3341"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7413), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3341"), 41, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7412), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3341") },
                    { 97, 33, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7432), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3342"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7435), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3342"), 42, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7434), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3342") },
                    { 98, 33, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7454), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3342"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7457), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3342"), 42, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7455), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3342") },
                    { 99, 33, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7475), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3342"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7477), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3342"), 42, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7476), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3342") },
                    { 100, 34, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7496), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3343"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7499), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3343"), 43, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7498), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3343") },
                    { 101, 34, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7517), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3343"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7520), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3343"), 43, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7518), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3343") },
                    { 102, 34, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7594), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3343"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7597), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3343"), 43, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7596), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3343") },
                    { 103, 35, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7617), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3344"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7620), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3344"), 44, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7619), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3344") },
                    { 104, 35, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7693), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3344"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7696), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3344"), 44, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7695), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3344") },
                    { 105, 35, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7717), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3344"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7719), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3344"), 44, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7718), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3344") }
                });

            migrationBuilder.InsertData(
                table: "Booking_Details",
                columns: new[] { "Id", "BookingId", "Created_at", "Created_by", "Deleted_at", "Deleted_by", "DentistId", "KeyTime", "Note", "ServiceId", "Status", "Updated_at", "Updated_by" },
                values: new object[,]
                {
                    { 106, 36, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7739), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3345"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7742), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3345"), 45, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7740), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3345") },
                    { 107, 36, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7760), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3345"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7763), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3345"), 45, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7762), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3345") },
                    { 108, 36, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7781), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3345"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7784), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3345"), 45, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7782), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3345") },
                    { 109, 37, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7802), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3346"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7805), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3346"), 46, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7803), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3346") },
                    { 110, 37, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7823), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3346"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7825), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3346"), 46, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7824), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3346") },
                    { 111, 37, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7901), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3346"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7903), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3346"), 46, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7902), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3346") },
                    { 112, 38, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7923), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3347"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7925), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3347"), 47, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7924), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3347") },
                    { 113, 38, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7944), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3347"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7946), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3347"), 47, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7945), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3347") },
                    { 114, 38, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7965), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3347"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7967), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3347"), 47, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7966), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3347") },
                    { 115, 39, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7987), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3348"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7989), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3348"), 48, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(7988), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3348") },
                    { 116, 39, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8008), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3348"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8010), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3348"), 48, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8009), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3348") },
                    { 117, 39, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8028), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3348"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8031), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3348"), 48, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8030), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3348") },
                    { 118, 40, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8050), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3349"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8052), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3349"), 49, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8051), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3349") },
                    { 119, 40, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8070), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3349"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8072), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3349"), 49, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8071), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3349") },
                    { 120, 40, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8173), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3349"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8176), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3349"), 49, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8174), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3349") },
                    { 121, 41, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8195), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3350"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8198), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3350"), 50, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(8196), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3350") },
                    { 152, 51, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(9026), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(9029), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"), 60, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(9028), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360") },
                    { 153, 51, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(9101), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"), new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(9104), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"), 60, 0, "nhe nhang thoi nha bac si", 1, 0, new DateTime(2022, 6, 30, 15, 59, 14, 704, DateTimeKind.Utc).AddTicks(9103), new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360") }
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
