using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DentisBooking.Data.Migrations
{
    public partial class Updaterftoken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 638, DateTimeKind.Utc).AddTicks(7800), new DateTime(2022, 5, 28, 14, 1, 37, 638, DateTimeKind.Utc).AddTicks(8475), new DateTime(2022, 5, 28, 14, 1, 37, 638, DateTimeKind.Utc).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(48), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(51), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(50) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(76), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(78), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(77) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(94), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(96), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(95) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(109), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(111), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(110) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(128), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(130), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(145), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(146), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(145) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(160), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(162), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(161) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(176), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(178), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(177) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(240), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(241), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(241) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(259), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(261), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(260) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(275), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(276), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(275) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(290), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(292), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(305), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(307), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(306) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(320), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(322), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(321) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(336), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(338), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(337) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(351), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(353), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(352) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(367), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(369), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(368) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(419), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(420), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(435), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(437), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(436) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(451), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(453), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(467), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(469), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(468) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(482), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(484), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(483) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(498), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(500), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(499) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(514), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(516), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(515) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(530), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(531), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(530) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(545), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(547), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(546) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(597), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(599), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(598) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(614), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(616), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(615) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(630), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(632), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(645), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(647), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(646) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(661), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(662), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(661) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(676), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(678), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(677) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(692), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(693), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(693) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(708), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(709), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(708) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(723), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(725), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(784), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(786), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(785) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(800), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(802), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(801) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(816), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(818), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(817) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(831), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(833), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(832) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(846), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(848), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(847) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(862), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(863), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(863) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(877), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(878), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(878) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(892), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(893), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(893) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(907), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(909), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(908) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(958), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(960), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(959) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(975), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(976), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(975) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(990), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(992), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(991) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1006), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1007), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1007) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1021), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1022), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1036), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1037), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1036) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1050), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1052), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1051) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1066), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1068), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1067) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1081), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1083), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1082) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1168), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1170), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1169) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1188), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1189), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1188) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1203), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1204), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1204) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1218), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1220), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1219) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1233), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1235), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1234) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1249), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1250), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1249) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1264), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1265), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1265) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1279), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1280), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1294), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1295), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1294) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1309), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1311), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1310) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1407), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1409), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1408) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1424), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1426), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1425) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1441), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1442), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1441) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1456), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1458), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1457) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1472), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1473), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1473) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1488), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1489), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1488) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1503), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1505), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1504) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1519), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1520), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1520) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1571), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1573), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1586), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1588), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1601), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1603), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1616), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1618), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1632), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1633), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1632) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1647), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1648), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1662), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1663), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1676), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1678), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1677) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1692), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1694), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1745), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1746), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1760), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1762), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1761) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1776), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1778), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1777) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1792), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1793), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1792) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1807), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1808), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1807) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1822), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1823), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1837), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1839), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1838) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1853), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1854), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1853) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1868), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1869), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1869) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1919), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1921), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1935), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1937), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1936) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1950), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1952), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1951) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1966), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1967), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1966) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1981), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1983), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1982) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1997), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1998), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2012), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2014), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2013) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2027), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2028), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2028) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2042), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2044), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2043) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2093), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2094), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2093) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2109), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2111), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2125), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2126), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2125) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2140), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2142), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2141) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2155), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2157), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2156) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2170), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2172), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2171) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2186), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2188), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2187) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2201), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2203), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2216), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2218), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2217) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2268), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2270), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2269) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2284), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2286), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2300), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2301), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2300) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2315), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2317), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2331), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2332), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2331) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2346), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2347), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2347) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2361), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2362), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2362) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2375), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2377), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2376) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2391), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2392), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2391) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2406), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2407), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2407) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2458), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2460), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2459) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2473), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2475), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2474) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2489), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2490), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2504), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2505), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2519), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2521), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2520) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2534), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2536), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2535) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2549), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2551), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2564), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2566), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2565) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2579), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2581), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2580) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2633), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2635), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2634) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2648), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2650), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2649) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2665), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2666), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2666) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2680), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2682), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2696), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2697), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2696) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2711), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2713), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2712) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2727), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2728), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2727) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2802), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2804), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2803) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2818), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2819), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2819) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2833), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2835), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2848), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2850), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2849) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2863), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2865), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2864) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2879), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2880), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2879) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2894), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2896), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2895) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2910), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2911), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2924), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2926), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2978), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2979), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2978) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2994), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2995), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(2995) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(3009), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(3010), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(3010) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(3024), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(3025), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(3040), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(3041), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(3040) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(3055), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(3057), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(3056) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(3070), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(3071), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(3071) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(3086), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(3087), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(3086) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(3101), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(3103), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(3102) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(3153), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(3155), new DateTime(2022, 5, 28, 14, 1, 37, 639, DateTimeKind.Utc).AddTicks(3154) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 247, DateTimeKind.Utc).AddTicks(1296), new DateTime(2022, 5, 28, 14, 1, 37, 246, DateTimeKind.Utc).AddTicks(9932), new DateTime(2022, 5, 28, 14, 1, 37, 247, DateTimeKind.Utc).AddTicks(1954), new DateTime(2022, 5, 28, 14, 1, 37, 247, DateTimeKind.Utc).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 254, DateTimeKind.Utc).AddTicks(8846), new DateTime(2022, 5, 28, 14, 1, 37, 254, DateTimeKind.Utc).AddTicks(8844), new DateTime(2022, 5, 28, 14, 1, 37, 254, DateTimeKind.Utc).AddTicks(8848), new DateTime(2022, 5, 28, 14, 1, 37, 254, DateTimeKind.Utc).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 262, DateTimeKind.Utc).AddTicks(3343), new DateTime(2022, 5, 28, 14, 1, 37, 262, DateTimeKind.Utc).AddTicks(3342), new DateTime(2022, 5, 28, 14, 1, 37, 262, DateTimeKind.Utc).AddTicks(3346), new DateTime(2022, 5, 28, 14, 1, 37, 262, DateTimeKind.Utc).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 269, DateTimeKind.Utc).AddTicks(7238), new DateTime(2022, 5, 28, 14, 1, 37, 269, DateTimeKind.Utc).AddTicks(7236), new DateTime(2022, 5, 28, 14, 1, 37, 269, DateTimeKind.Utc).AddTicks(7240), new DateTime(2022, 5, 28, 14, 1, 37, 269, DateTimeKind.Utc).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 277, DateTimeKind.Utc).AddTicks(2241), new DateTime(2022, 5, 28, 14, 1, 37, 277, DateTimeKind.Utc).AddTicks(2239), new DateTime(2022, 5, 28, 14, 1, 37, 277, DateTimeKind.Utc).AddTicks(2243), new DateTime(2022, 5, 28, 14, 1, 37, 277, DateTimeKind.Utc).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 284, DateTimeKind.Utc).AddTicks(6640), new DateTime(2022, 5, 28, 14, 1, 37, 284, DateTimeKind.Utc).AddTicks(6639), new DateTime(2022, 5, 28, 14, 1, 37, 284, DateTimeKind.Utc).AddTicks(6644), new DateTime(2022, 5, 28, 14, 1, 37, 284, DateTimeKind.Utc).AddTicks(6642) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 292, DateTimeKind.Utc).AddTicks(1143), new DateTime(2022, 5, 28, 14, 1, 37, 292, DateTimeKind.Utc).AddTicks(1141), new DateTime(2022, 5, 28, 14, 1, 37, 292, DateTimeKind.Utc).AddTicks(1145), new DateTime(2022, 5, 28, 14, 1, 37, 292, DateTimeKind.Utc).AddTicks(1143) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 299, DateTimeKind.Utc).AddTicks(5361), new DateTime(2022, 5, 28, 14, 1, 37, 299, DateTimeKind.Utc).AddTicks(5360), new DateTime(2022, 5, 28, 14, 1, 37, 299, DateTimeKind.Utc).AddTicks(5363), new DateTime(2022, 5, 28, 14, 1, 37, 299, DateTimeKind.Utc).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 307, DateTimeKind.Utc).AddTicks(1278), new DateTime(2022, 5, 28, 14, 1, 37, 307, DateTimeKind.Utc).AddTicks(1276), new DateTime(2022, 5, 28, 14, 1, 37, 307, DateTimeKind.Utc).AddTicks(1280), new DateTime(2022, 5, 28, 14, 1, 37, 307, DateTimeKind.Utc).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 314, DateTimeKind.Utc).AddTicks(2997), new DateTime(2022, 5, 28, 14, 1, 37, 314, DateTimeKind.Utc).AddTicks(2996), new DateTime(2022, 5, 28, 14, 1, 37, 314, DateTimeKind.Utc).AddTicks(3000), new DateTime(2022, 5, 28, 14, 1, 37, 314, DateTimeKind.Utc).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 321, DateTimeKind.Utc).AddTicks(4529), new DateTime(2022, 5, 28, 14, 1, 37, 321, DateTimeKind.Utc).AddTicks(4527), new DateTime(2022, 5, 28, 14, 1, 37, 321, DateTimeKind.Utc).AddTicks(4531), new DateTime(2022, 5, 28, 14, 1, 37, 321, DateTimeKind.Utc).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 328, DateTimeKind.Utc).AddTicks(6638), new DateTime(2022, 5, 28, 14, 1, 37, 328, DateTimeKind.Utc).AddTicks(6636), new DateTime(2022, 5, 28, 14, 1, 37, 328, DateTimeKind.Utc).AddTicks(6640), new DateTime(2022, 5, 28, 14, 1, 37, 328, DateTimeKind.Utc).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 335, DateTimeKind.Utc).AddTicks(8100), new DateTime(2022, 5, 28, 14, 1, 37, 335, DateTimeKind.Utc).AddTicks(8098), new DateTime(2022, 5, 28, 14, 1, 37, 335, DateTimeKind.Utc).AddTicks(8102), new DateTime(2022, 5, 28, 14, 1, 37, 335, DateTimeKind.Utc).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 343, DateTimeKind.Utc).AddTicks(265), new DateTime(2022, 5, 28, 14, 1, 37, 343, DateTimeKind.Utc).AddTicks(263), new DateTime(2022, 5, 28, 14, 1, 37, 343, DateTimeKind.Utc).AddTicks(267), new DateTime(2022, 5, 28, 14, 1, 37, 343, DateTimeKind.Utc).AddTicks(266) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 350, DateTimeKind.Utc).AddTicks(2097), new DateTime(2022, 5, 28, 14, 1, 37, 350, DateTimeKind.Utc).AddTicks(2095), new DateTime(2022, 5, 28, 14, 1, 37, 350, DateTimeKind.Utc).AddTicks(2099), new DateTime(2022, 5, 28, 14, 1, 37, 350, DateTimeKind.Utc).AddTicks(2097) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 357, DateTimeKind.Utc).AddTicks(4314), new DateTime(2022, 5, 28, 14, 1, 37, 357, DateTimeKind.Utc).AddTicks(4312), new DateTime(2022, 5, 28, 14, 1, 37, 357, DateTimeKind.Utc).AddTicks(4316), new DateTime(2022, 5, 28, 14, 1, 37, 357, DateTimeKind.Utc).AddTicks(4315) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 364, DateTimeKind.Utc).AddTicks(5803), new DateTime(2022, 5, 28, 14, 1, 37, 364, DateTimeKind.Utc).AddTicks(5801), new DateTime(2022, 5, 28, 14, 1, 37, 364, DateTimeKind.Utc).AddTicks(5805), new DateTime(2022, 5, 28, 14, 1, 37, 364, DateTimeKind.Utc).AddTicks(5804) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 371, DateTimeKind.Utc).AddTicks(7950), new DateTime(2022, 5, 28, 14, 1, 37, 371, DateTimeKind.Utc).AddTicks(7948), new DateTime(2022, 5, 28, 14, 1, 37, 371, DateTimeKind.Utc).AddTicks(7952), new DateTime(2022, 5, 28, 14, 1, 37, 371, DateTimeKind.Utc).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 378, DateTimeKind.Utc).AddTicks(9327), new DateTime(2022, 5, 28, 14, 1, 37, 378, DateTimeKind.Utc).AddTicks(9326), new DateTime(2022, 5, 28, 14, 1, 37, 378, DateTimeKind.Utc).AddTicks(9329), new DateTime(2022, 5, 28, 14, 1, 37, 378, DateTimeKind.Utc).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 386, DateTimeKind.Utc).AddTicks(2077), new DateTime(2022, 5, 28, 14, 1, 37, 386, DateTimeKind.Utc).AddTicks(2074), new DateTime(2022, 5, 28, 14, 1, 37, 386, DateTimeKind.Utc).AddTicks(2079), new DateTime(2022, 5, 28, 14, 1, 37, 386, DateTimeKind.Utc).AddTicks(2078) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 394, DateTimeKind.Utc).AddTicks(8384), new DateTime(2022, 5, 28, 14, 1, 37, 394, DateTimeKind.Utc).AddTicks(8381), new DateTime(2022, 5, 28, 14, 1, 37, 394, DateTimeKind.Utc).AddTicks(8388), new DateTime(2022, 5, 28, 14, 1, 37, 394, DateTimeKind.Utc).AddTicks(8386) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 403, DateTimeKind.Utc).AddTicks(9186), new DateTime(2022, 5, 28, 14, 1, 37, 403, DateTimeKind.Utc).AddTicks(9180), new DateTime(2022, 5, 28, 14, 1, 37, 403, DateTimeKind.Utc).AddTicks(9189), new DateTime(2022, 5, 28, 14, 1, 37, 403, DateTimeKind.Utc).AddTicks(9187) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 413, DateTimeKind.Utc).AddTicks(8594), new DateTime(2022, 5, 28, 14, 1, 37, 413, DateTimeKind.Utc).AddTicks(8592), new DateTime(2022, 5, 28, 14, 1, 37, 413, DateTimeKind.Utc).AddTicks(8596), new DateTime(2022, 5, 28, 14, 1, 37, 413, DateTimeKind.Utc).AddTicks(8595) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 421, DateTimeKind.Utc).AddTicks(1616), new DateTime(2022, 5, 28, 14, 1, 37, 421, DateTimeKind.Utc).AddTicks(1614), new DateTime(2022, 5, 28, 14, 1, 37, 421, DateTimeKind.Utc).AddTicks(1618), new DateTime(2022, 5, 28, 14, 1, 37, 421, DateTimeKind.Utc).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 429, DateTimeKind.Utc).AddTicks(974), new DateTime(2022, 5, 28, 14, 1, 37, 429, DateTimeKind.Utc).AddTicks(971), new DateTime(2022, 5, 28, 14, 1, 37, 429, DateTimeKind.Utc).AddTicks(975), new DateTime(2022, 5, 28, 14, 1, 37, 429, DateTimeKind.Utc).AddTicks(974) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 436, DateTimeKind.Utc).AddTicks(2933), new DateTime(2022, 5, 28, 14, 1, 37, 436, DateTimeKind.Utc).AddTicks(2932), new DateTime(2022, 5, 28, 14, 1, 37, 436, DateTimeKind.Utc).AddTicks(2935), new DateTime(2022, 5, 28, 14, 1, 37, 436, DateTimeKind.Utc).AddTicks(2934) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 443, DateTimeKind.Utc).AddTicks(5649), new DateTime(2022, 5, 28, 14, 1, 37, 443, DateTimeKind.Utc).AddTicks(5648), new DateTime(2022, 5, 28, 14, 1, 37, 443, DateTimeKind.Utc).AddTicks(5651), new DateTime(2022, 5, 28, 14, 1, 37, 443, DateTimeKind.Utc).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 450, DateTimeKind.Utc).AddTicks(7415), new DateTime(2022, 5, 28, 14, 1, 37, 450, DateTimeKind.Utc).AddTicks(7413), new DateTime(2022, 5, 28, 14, 1, 37, 450, DateTimeKind.Utc).AddTicks(7417), new DateTime(2022, 5, 28, 14, 1, 37, 450, DateTimeKind.Utc).AddTicks(7416) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 457, DateTimeKind.Utc).AddTicks(9280), new DateTime(2022, 5, 28, 14, 1, 37, 457, DateTimeKind.Utc).AddTicks(9278), new DateTime(2022, 5, 28, 14, 1, 37, 457, DateTimeKind.Utc).AddTicks(9282), new DateTime(2022, 5, 28, 14, 1, 37, 457, DateTimeKind.Utc).AddTicks(9280) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 465, DateTimeKind.Utc).AddTicks(1114), new DateTime(2022, 5, 28, 14, 1, 37, 465, DateTimeKind.Utc).AddTicks(1112), new DateTime(2022, 5, 28, 14, 1, 37, 465, DateTimeKind.Utc).AddTicks(1116), new DateTime(2022, 5, 28, 14, 1, 37, 465, DateTimeKind.Utc).AddTicks(1115) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 472, DateTimeKind.Utc).AddTicks(2592), new DateTime(2022, 5, 28, 14, 1, 37, 472, DateTimeKind.Utc).AddTicks(2591), new DateTime(2022, 5, 28, 14, 1, 37, 472, DateTimeKind.Utc).AddTicks(2594), new DateTime(2022, 5, 28, 14, 1, 37, 472, DateTimeKind.Utc).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 479, DateTimeKind.Utc).AddTicks(4340), new DateTime(2022, 5, 28, 14, 1, 37, 479, DateTimeKind.Utc).AddTicks(4339), new DateTime(2022, 5, 28, 14, 1, 37, 479, DateTimeKind.Utc).AddTicks(4342), new DateTime(2022, 5, 28, 14, 1, 37, 479, DateTimeKind.Utc).AddTicks(4341) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 486, DateTimeKind.Utc).AddTicks(7527), new DateTime(2022, 5, 28, 14, 1, 37, 486, DateTimeKind.Utc).AddTicks(7525), new DateTime(2022, 5, 28, 14, 1, 37, 486, DateTimeKind.Utc).AddTicks(7528), new DateTime(2022, 5, 28, 14, 1, 37, 486, DateTimeKind.Utc).AddTicks(7527) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 496, DateTimeKind.Utc).AddTicks(2300), new DateTime(2022, 5, 28, 14, 1, 37, 496, DateTimeKind.Utc).AddTicks(2296), new DateTime(2022, 5, 28, 14, 1, 37, 496, DateTimeKind.Utc).AddTicks(2303), new DateTime(2022, 5, 28, 14, 1, 37, 496, DateTimeKind.Utc).AddTicks(2301) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 509, DateTimeKind.Utc).AddTicks(97), new DateTime(2022, 5, 28, 14, 1, 37, 509, DateTimeKind.Utc).AddTicks(94), new DateTime(2022, 5, 28, 14, 1, 37, 509, DateTimeKind.Utc).AddTicks(100), new DateTime(2022, 5, 28, 14, 1, 37, 509, DateTimeKind.Utc).AddTicks(98) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 521, DateTimeKind.Utc).AddTicks(7033), new DateTime(2022, 5, 28, 14, 1, 37, 521, DateTimeKind.Utc).AddTicks(7030), new DateTime(2022, 5, 28, 14, 1, 37, 521, DateTimeKind.Utc).AddTicks(7036), new DateTime(2022, 5, 28, 14, 1, 37, 521, DateTimeKind.Utc).AddTicks(7034) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 529, DateTimeKind.Utc).AddTicks(4739), new DateTime(2022, 5, 28, 14, 1, 37, 529, DateTimeKind.Utc).AddTicks(4737), new DateTime(2022, 5, 28, 14, 1, 37, 529, DateTimeKind.Utc).AddTicks(4741), new DateTime(2022, 5, 28, 14, 1, 37, 529, DateTimeKind.Utc).AddTicks(4740) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 536, DateTimeKind.Utc).AddTicks(8554), new DateTime(2022, 5, 28, 14, 1, 37, 536, DateTimeKind.Utc).AddTicks(8552), new DateTime(2022, 5, 28, 14, 1, 37, 536, DateTimeKind.Utc).AddTicks(8556), new DateTime(2022, 5, 28, 14, 1, 37, 536, DateTimeKind.Utc).AddTicks(8555) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 544, DateTimeKind.Utc).AddTicks(2785), new DateTime(2022, 5, 28, 14, 1, 37, 544, DateTimeKind.Utc).AddTicks(2783), new DateTime(2022, 5, 28, 14, 1, 37, 544, DateTimeKind.Utc).AddTicks(2787), new DateTime(2022, 5, 28, 14, 1, 37, 544, DateTimeKind.Utc).AddTicks(2786) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 551, DateTimeKind.Utc).AddTicks(6866), new DateTime(2022, 5, 28, 14, 1, 37, 551, DateTimeKind.Utc).AddTicks(6865), new DateTime(2022, 5, 28, 14, 1, 37, 551, DateTimeKind.Utc).AddTicks(6868), new DateTime(2022, 5, 28, 14, 1, 37, 551, DateTimeKind.Utc).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 559, DateTimeKind.Utc).AddTicks(1197), new DateTime(2022, 5, 28, 14, 1, 37, 559, DateTimeKind.Utc).AddTicks(1196), new DateTime(2022, 5, 28, 14, 1, 37, 559, DateTimeKind.Utc).AddTicks(1199), new DateTime(2022, 5, 28, 14, 1, 37, 559, DateTimeKind.Utc).AddTicks(1198) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 566, DateTimeKind.Utc).AddTicks(4930), new DateTime(2022, 5, 28, 14, 1, 37, 566, DateTimeKind.Utc).AddTicks(4929), new DateTime(2022, 5, 28, 14, 1, 37, 566, DateTimeKind.Utc).AddTicks(4932), new DateTime(2022, 5, 28, 14, 1, 37, 566, DateTimeKind.Utc).AddTicks(4931) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 573, DateTimeKind.Utc).AddTicks(9042), new DateTime(2022, 5, 28, 14, 1, 37, 573, DateTimeKind.Utc).AddTicks(9040), new DateTime(2022, 5, 28, 14, 1, 37, 573, DateTimeKind.Utc).AddTicks(9043), new DateTime(2022, 5, 28, 14, 1, 37, 573, DateTimeKind.Utc).AddTicks(9042) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 581, DateTimeKind.Utc).AddTicks(2622), new DateTime(2022, 5, 28, 14, 1, 37, 581, DateTimeKind.Utc).AddTicks(2620), new DateTime(2022, 5, 28, 14, 1, 37, 581, DateTimeKind.Utc).AddTicks(2623), new DateTime(2022, 5, 28, 14, 1, 37, 581, DateTimeKind.Utc).AddTicks(2622) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 588, DateTimeKind.Utc).AddTicks(4550), new DateTime(2022, 5, 28, 14, 1, 37, 588, DateTimeKind.Utc).AddTicks(4549), new DateTime(2022, 5, 28, 14, 1, 37, 588, DateTimeKind.Utc).AddTicks(4552), new DateTime(2022, 5, 28, 14, 1, 37, 588, DateTimeKind.Utc).AddTicks(4551) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 595, DateTimeKind.Utc).AddTicks(5834), new DateTime(2022, 5, 28, 14, 1, 37, 595, DateTimeKind.Utc).AddTicks(5832), new DateTime(2022, 5, 28, 14, 1, 37, 595, DateTimeKind.Utc).AddTicks(5836), new DateTime(2022, 5, 28, 14, 1, 37, 595, DateTimeKind.Utc).AddTicks(5835) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 602, DateTimeKind.Utc).AddTicks(7344), new DateTime(2022, 5, 28, 14, 1, 37, 602, DateTimeKind.Utc).AddTicks(7343), new DateTime(2022, 5, 28, 14, 1, 37, 602, DateTimeKind.Utc).AddTicks(7373), new DateTime(2022, 5, 28, 14, 1, 37, 602, DateTimeKind.Utc).AddTicks(7372) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 609, DateTimeKind.Utc).AddTicks(8705), new DateTime(2022, 5, 28, 14, 1, 37, 609, DateTimeKind.Utc).AddTicks(8704), new DateTime(2022, 5, 28, 14, 1, 37, 609, DateTimeKind.Utc).AddTicks(8707), new DateTime(2022, 5, 28, 14, 1, 37, 609, DateTimeKind.Utc).AddTicks(8706) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 617, DateTimeKind.Utc).AddTicks(372), new DateTime(2022, 5, 28, 14, 1, 37, 617, DateTimeKind.Utc).AddTicks(371), new DateTime(2022, 5, 28, 14, 1, 37, 617, DateTimeKind.Utc).AddTicks(374), new DateTime(2022, 5, 28, 14, 1, 37, 617, DateTimeKind.Utc).AddTicks(373) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 624, DateTimeKind.Utc).AddTicks(2029), new DateTime(2022, 5, 28, 14, 1, 37, 624, DateTimeKind.Utc).AddTicks(2028), new DateTime(2022, 5, 28, 14, 1, 37, 624, DateTimeKind.Utc).AddTicks(2031), new DateTime(2022, 5, 28, 14, 1, 37, 624, DateTimeKind.Utc).AddTicks(2030) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 631, DateTimeKind.Utc).AddTicks(3286), new DateTime(2022, 5, 28, 14, 1, 37, 631, DateTimeKind.Utc).AddTicks(3285), new DateTime(2022, 5, 28, 14, 1, 37, 631, DateTimeKind.Utc).AddTicks(3288), new DateTime(2022, 5, 28, 14, 1, 37, 631, DateTimeKind.Utc).AddTicks(3287) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 14, 1, 37, 638, DateTimeKind.Utc).AddTicks(5608), new DateTime(2022, 5, 28, 14, 1, 37, 638, DateTimeKind.Utc).AddTicks(5607), new DateTime(2022, 5, 28, 14, 1, 37, 638, DateTimeKind.Utc).AddTicks(5610), new DateTime(2022, 5, 28, 14, 1, 37, 638, DateTimeKind.Utc).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 21, 1, 37, 210, DateTimeKind.Local).AddTicks(4923), new DateTime(2022, 5, 28, 21, 1, 37, 210, DateTimeKind.Local).AddTicks(5643), new DateTime(2022, 5, 28, 21, 1, 37, 210, DateTimeKind.Local).AddTicks(5267) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 21, 1, 37, 210, DateTimeKind.Local).AddTicks(7250), new DateTime(2022, 5, 28, 21, 1, 37, 210, DateTimeKind.Local).AddTicks(7257), new DateTime(2022, 5, 28, 21, 1, 37, 210, DateTimeKind.Local).AddTicks(7255) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 21, 1, 37, 210, DateTimeKind.Local).AddTicks(7297), new DateTime(2022, 5, 28, 21, 1, 37, 210, DateTimeKind.Local).AddTicks(7299), new DateTime(2022, 5, 28, 21, 1, 37, 210, DateTimeKind.Local).AddTicks(7298) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 21, 1, 37, 210, DateTimeKind.Local).AddTicks(7328), new DateTime(2022, 5, 28, 21, 1, 37, 210, DateTimeKind.Local).AddTicks(7330), new DateTime(2022, 5, 28, 21, 1, 37, 210, DateTimeKind.Local).AddTicks(7329) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 21, 1, 37, 210, DateTimeKind.Local).AddTicks(7364), new DateTime(2022, 5, 28, 21, 1, 37, 210, DateTimeKind.Local).AddTicks(7367), new DateTime(2022, 5, 28, 21, 1, 37, 210, DateTimeKind.Local).AddTicks(7365) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e20"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "84b16967-bf94-46cc-9e21-800d36b989a3", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(1826), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(2493), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(2144) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e21"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "8bcdc4b0-df61-4d4c-8522-dbdd00bab331", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(4424), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(4431), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(4429) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e22"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "082f6bb4-d40f-4526-b676-6f7b5a9d0850", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(4589), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(4593), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(4592) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e23"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "8c1e7ca0-962a-4315-8eec-4c237bdaff10", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(4629), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(4633), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(4631) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e24"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "0a175b03-5606-439a-813b-6f4e848aa698", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(4665), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(4668), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(4667) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e25"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "ade0218f-0e60-4fd7-ad57-a5680efe787d", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(4705), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(4707), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(4706) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e26"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "2d588310-7a2c-4a2f-a402-a45453c08767", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(4741), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(4744), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(4743) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e27"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "4de4fad8-58ea-4407-b739-fb016208ee7d", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(4821), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(4825), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(4823) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e28"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "a57ec504-fd1c-4da4-90c7-2e4c9abe2bcb", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(4867), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(4870), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(4869) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e29"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "3d0c731c-8bcc-449a-8ef5-797c13cb9c52", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(4906), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(4909), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(4908) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e30"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "343ede14-fb54-475f-b002-dfabbc320142", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(4943), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(4946), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(4944) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e31"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "3fa83618-7727-4638-85ca-555220a7ad78", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(4978), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(4981), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(4980) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e32"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "a2ef216b-b7ee-4c2c-a703-6513c10acbaa", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5015), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5017), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5016) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e33"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "83855e25-59dd-4d1c-9395-adcf0f6f883c", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5095), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5098), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5097) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e34"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "ff3881e7-71fb-45cf-aa49-1ef64a9cea0e", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5134), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5137), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5135) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e35"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "d6f726dd-0c2f-40d1-bbe6-92c4aef1397e", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5169), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5172), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5171) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e36"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "de172fe4-f0f3-4add-b39b-4b723d44b9d6", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5208), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5211), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e37"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "7657b4b9-5235-4ee2-ba33-c800d69d4148", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5247), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5250), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5249) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e38"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "52d26a73-be39-4f28-8ff5-bee498f2ce7f", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5325), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5328), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5326) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e39"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "5eef8eae-9316-4135-8556-e856926ee023", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5364), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5366), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5365) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e40"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "1f8bd53c-8926-424b-83f7-784970140e09", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5400), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5403), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5402) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e41"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "6ce0b2f7-dc80-4076-9451-6bb7f8f343fc", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5436), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5439), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5438) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e42"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "de4d4895-aa5a-4cf2-86e3-5bd552231d57", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5473), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5475), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5474) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e43"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "72019549-326f-4803-a158-b8f7d623634c", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5508), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5511), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e44"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "91956551-a18f-420a-82dc-a8b2c3a8c29a", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5588), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5591), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e45"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "6bc0cbc8-f87e-45fe-a4d1-4485cebfc487", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5628), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5630), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5629) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e46"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "ec966105-881a-422f-a006-c3c00b69d575", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5664), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5667), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5666) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e47"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "e988e26b-0a97-4458-8fab-b4e10c82e099", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5700), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5703), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5702) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e48"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "6a83cf35-2bdd-4138-b815-cffe73dfd238", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5736), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5739), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5738) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e49"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "df821e0a-9677-42de-b58f-85a217668a7f", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5771), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5774), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5773) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e50"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "22996908-1081-4b67-9b61-8f41f2d45622", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5850), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5853), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5851) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e51"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "7cd82fc4-1135-406e-9803-6ad3c5371fb0", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5886), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5889), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5888) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e52"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "e8502ac6-de9d-4038-ba1d-fac7788f0df7", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5925), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5928), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e53"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "e2a4023f-d562-4766-8a02-c6fd39bd636a", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5964), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5967), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(5965) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e54"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "9230e6a9-db5c-415b-b5f0-a08daca3f608", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6000), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6002), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6001) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e55"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "d67a58c8-3efd-4d0c-8f0e-d59c9371cca0", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6076), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6079), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6078) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e56"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "c18dbce9-5ff0-4a66-bbbb-153af61bea36", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6115), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6118), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6116) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e57"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "21e0c907-4214-4a7f-a1c2-441fd7ae6c48", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6151), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6154), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6152) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e58"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "43bda7ad-8e61-46a7-870d-d67ef37e2217", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6186), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6189), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6188) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e59"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "439bd05e-a7c6-4c5a-8b9b-f0daf31b7830", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6222), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6224), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6223) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e60"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "1dacbf76-1482-4c32-8d14-fef34092e340", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6260), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6263), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e61"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "c3aff59b-de8d-482e-97cf-d0306f43d0dd", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6339), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6342), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e62"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "861c975e-31db-417d-902b-22b8acf8f39a", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6375), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6378), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6377) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e63"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "65355784-89e3-4e61-a1f1-0ac9b9010980", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6410), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6413), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6412) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e64"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "614d158e-e05f-42e3-a729-93a0e076d0e3", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6445), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6448), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e65"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "d777039a-77ac-4fed-a575-34e3fa90b2fb", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6480), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6483), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6482) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e66"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "3379a6a4-c6d9-4bd2-8688-185586201f76", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6579), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6582), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6581) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e67"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "a4dbc67b-023c-470e-a253-447aa6924631", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6621), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6624), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6622) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e68"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "1b95b17b-3227-4459-bba7-99cbd4610a76", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6660), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6663), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6662) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e69"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "9a0db2bb-e228-4194-bbe7-3a399eaf5dcf", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6696), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6699), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6697) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e70"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "9cff8f80-bfa0-4a1b-8dfc-07abba98b2e7", new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6731), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6734), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(6733) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Deleted_at", "EndDate", "StartDate", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 21, 1, 37, 208, DateTimeKind.Local).AddTicks(8512), new DateTime(2022, 5, 28, 21, 1, 37, 208, DateTimeKind.Local).AddTicks(9567), new DateTime(2022, 5, 28, 21, 1, 37, 208, DateTimeKind.Local).AddTicks(5197), new DateTime(2022, 5, 28, 21, 1, 37, 207, DateTimeKind.Local).AddTicks(180), new DateTime(2022, 5, 28, 21, 1, 37, 208, DateTimeKind.Local).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "Deleted_at", "EndDate", "StartDate", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 21, 1, 37, 210, DateTimeKind.Local).AddTicks(2243), new DateTime(2022, 5, 28, 21, 1, 37, 210, DateTimeKind.Local).AddTicks(2245), new DateTime(2022, 5, 28, 21, 1, 37, 210, DateTimeKind.Local).AddTicks(2238), new DateTime(2022, 5, 28, 21, 1, 37, 210, DateTimeKind.Local).AddTicks(2230), new DateTime(2022, 5, 28, 21, 1, 37, 210, DateTimeKind.Local).AddTicks(2244) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "Deleted_at", "EndDate", "StartDate", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 21, 1, 37, 210, DateTimeKind.Local).AddTicks(2386), new DateTime(2022, 5, 28, 21, 1, 37, 210, DateTimeKind.Local).AddTicks(2388), new DateTime(2022, 5, 28, 21, 1, 37, 210, DateTimeKind.Local).AddTicks(2383), new DateTime(2022, 5, 28, 21, 1, 37, 210, DateTimeKind.Local).AddTicks(2380), new DateTime(2022, 5, 28, 21, 1, 37, 210, DateTimeKind.Local).AddTicks(2387) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "Deleted_at", "EndDate", "StartDate", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 21, 1, 37, 210, DateTimeKind.Local).AddTicks(2432), new DateTime(2022, 5, 28, 21, 1, 37, 210, DateTimeKind.Local).AddTicks(2434), new DateTime(2022, 5, 28, 21, 1, 37, 210, DateTimeKind.Local).AddTicks(2430), new DateTime(2022, 5, 28, 21, 1, 37, 210, DateTimeKind.Local).AddTicks(2429), new DateTime(2022, 5, 28, 21, 1, 37, 210, DateTimeKind.Local).AddTicks(2433) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_at", "Deleted_at", "EndDate", "StartDate", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 21, 1, 37, 210, DateTimeKind.Local).AddTicks(2463), new DateTime(2022, 5, 28, 21, 1, 37, 210, DateTimeKind.Local).AddTicks(2466), new DateTime(2022, 5, 28, 21, 1, 37, 210, DateTimeKind.Local).AddTicks(2461), new DateTime(2022, 5, 28, 21, 1, 37, 210, DateTimeKind.Local).AddTicks(2460), new DateTime(2022, 5, 28, 21, 1, 37, 210, DateTimeKind.Local).AddTicks(2464) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "c463cb30-338b-4534-8d1c-d63d86ccfb65");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"),
                column: "ConcurrencyStamp",
                value: "61d4d74e-3c57-44b4-b9a2-9d7c394cf657");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(9144), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(9836), new DateTime(2022, 5, 28, 21, 1, 37, 211, DateTimeKind.Local).AddTicks(9486) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 21, 1, 37, 212, DateTimeKind.Local).AddTicks(2442), new DateTime(2022, 5, 28, 21, 1, 37, 212, DateTimeKind.Local).AddTicks(2451), new DateTime(2022, 5, 28, 21, 1, 37, 212, DateTimeKind.Local).AddTicks(2449) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 21, 1, 37, 212, DateTimeKind.Local).AddTicks(2560), new DateTime(2022, 5, 28, 21, 1, 37, 212, DateTimeKind.Local).AddTicks(2563), new DateTime(2022, 5, 28, 21, 1, 37, 212, DateTimeKind.Local).AddTicks(2562) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 21, 1, 37, 212, DateTimeKind.Local).AddTicks(2593), new DateTime(2022, 5, 28, 21, 1, 37, 212, DateTimeKind.Local).AddTicks(2596), new DateTime(2022, 5, 28, 21, 1, 37, 212, DateTimeKind.Local).AddTicks(2595) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 21, 1, 37, 212, DateTimeKind.Local).AddTicks(2625), new DateTime(2022, 5, 28, 21, 1, 37, 212, DateTimeKind.Local).AddTicks(2627), new DateTime(2022, 5, 28, 21, 1, 37, 212, DateTimeKind.Local).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2620"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "d5bdfe5e-932b-4a6f-b9fb-7004d09ef232", new DateTime(2022, 5, 28, 14, 1, 37, 246, DateTimeKind.Utc).AddTicks(6702), new DateTime(2022, 5, 28, 14, 1, 37, 246, DateTimeKind.Utc).AddTicks(7409), "AQAAAAEAACcQAAAAEGHoZkVVgJnHwWPlkDtExn1plt8DEgvBWbZgj5XIdHWaSEKCgvkkARkTA9ufeZ8xEw==", new DateTime(2022, 5, 28, 14, 1, 37, 246, DateTimeKind.Utc).AddTicks(7010) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2621"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "1a64e935-4983-4154-b1a3-de6d4e4932da", new DateTime(2022, 5, 28, 14, 1, 37, 254, DateTimeKind.Utc).AddTicks(8744), new DateTime(2022, 5, 28, 14, 1, 37, 254, DateTimeKind.Utc).AddTicks(8749), "AQAAAAEAACcQAAAAECliPSzhTuevzafNxZvleg/Ax341UHCHcDt0/PUOoe960sYIKjsBCTfZjhTWA++5Sw==", new DateTime(2022, 5, 28, 14, 1, 37, 254, DateTimeKind.Utc).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2622"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "d51bad8c-a64e-4e36-83ca-3c69c27ae7ff", new DateTime(2022, 5, 28, 14, 1, 37, 262, DateTimeKind.Utc).AddTicks(3214), new DateTime(2022, 5, 28, 14, 1, 37, 262, DateTimeKind.Utc).AddTicks(3219), "AQAAAAEAACcQAAAAEEilRQlVRINg6cKCec/cHgpKoF+T4MCt4LUvUYFImTJytNvscGgQsxKfO5hm111SWA==", new DateTime(2022, 5, 28, 14, 1, 37, 262, DateTimeKind.Utc).AddTicks(3217) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2623"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "54c3f2d7-78bb-438a-99fb-f67d5d2bc71d", new DateTime(2022, 5, 28, 14, 1, 37, 269, DateTimeKind.Utc).AddTicks(7180), new DateTime(2022, 5, 28, 14, 1, 37, 269, DateTimeKind.Utc).AddTicks(7182), "AQAAAAEAACcQAAAAEOjmTfej7IpjDiuvDYXJ5UWQzBtQDFlUDAdhx7ie0S6nyDlZmIfMLfNi0VXthXNXbQ==", new DateTime(2022, 5, 28, 14, 1, 37, 269, DateTimeKind.Utc).AddTicks(7181) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2624"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "1b84a6d5-b7dd-429f-a96e-5a7481d5a6a8", new DateTime(2022, 5, 28, 14, 1, 37, 277, DateTimeKind.Utc).AddTicks(1836), new DateTime(2022, 5, 28, 14, 1, 37, 277, DateTimeKind.Utc).AddTicks(1843), "AQAAAAEAACcQAAAAEHylmqtADb2UshXVNijgLF+NZtKpHz91wsiRJsshtlhs6eF+h7Ge4/hHiM7KuwYoxQ==", new DateTime(2022, 5, 28, 14, 1, 37, 277, DateTimeKind.Utc).AddTicks(1841) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2625"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "e50018a3-c5eb-4998-92cc-b7fee4e5d5c6", new DateTime(2022, 5, 28, 14, 1, 37, 284, DateTimeKind.Utc).AddTicks(6506), new DateTime(2022, 5, 28, 14, 1, 37, 284, DateTimeKind.Utc).AddTicks(6510), "AQAAAAEAACcQAAAAELVwA58Kc1oqZWSSBi7mz4b223GeljiSiYNYI+hQEd+PI+n0w+9oruvuiO1Q+fR6dg==", new DateTime(2022, 5, 28, 14, 1, 37, 284, DateTimeKind.Utc).AddTicks(6509) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2626"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "e074aef6-bba3-47ac-b21e-214afdfef45f", new DateTime(2022, 5, 28, 14, 1, 37, 292, DateTimeKind.Utc).AddTicks(940), new DateTime(2022, 5, 28, 14, 1, 37, 292, DateTimeKind.Utc).AddTicks(947), "AQAAAAEAACcQAAAAEIBjg3Usj/XYt8FxMReyQ5++BsrzYo4AQVLKmIW0cyemSbxsi+2MKfF12fv2YgLjiA==", new DateTime(2022, 5, 28, 14, 1, 37, 292, DateTimeKind.Utc).AddTicks(945) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2627"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "502ba693-b1d2-4932-b522-48cc9e9f63bb", new DateTime(2022, 5, 28, 14, 1, 37, 299, DateTimeKind.Utc).AddTicks(5273), new DateTime(2022, 5, 28, 14, 1, 37, 299, DateTimeKind.Utc).AddTicks(5276), "AQAAAAEAACcQAAAAEB47wv3zsEbP1+/l3yN2qBOG3sQBFiuUwF84ievoGZ7LoSrNK+HgC4UKk4EMsMF0ww==", new DateTime(2022, 5, 28, 14, 1, 37, 299, DateTimeKind.Utc).AddTicks(5274) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2628"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "a04d46eb-9174-4551-9bb2-e3c3bd8f3850", new DateTime(2022, 5, 28, 14, 1, 37, 307, DateTimeKind.Utc).AddTicks(1075), new DateTime(2022, 5, 28, 14, 1, 37, 307, DateTimeKind.Utc).AddTicks(1081), "AQAAAAEAACcQAAAAENA4Msg07pANrksj5ZL/CIexNdz8SwwloyiFv0tOILPLuBaXy4M5XYabLf1tzq5sYw==", new DateTime(2022, 5, 28, 14, 1, 37, 307, DateTimeKind.Utc).AddTicks(1079) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2629"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "33a4a6c0-d34d-496e-92c0-00960aaf8556", new DateTime(2022, 5, 28, 14, 1, 37, 314, DateTimeKind.Utc).AddTicks(2925), new DateTime(2022, 5, 28, 14, 1, 37, 314, DateTimeKind.Utc).AddTicks(2927), "AQAAAAEAACcQAAAAENUCl+Dy5ZepJM55d9omhRVwDnT8o8a/pGBMedz3PJsTTqTXvwgX4uKaGQklbVQRAA==", new DateTime(2022, 5, 28, 14, 1, 37, 314, DateTimeKind.Utc).AddTicks(2926) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2630"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "dd5f7ab1-6ee8-44c9-a7d7-86d205d7c2a1", new DateTime(2022, 5, 28, 14, 1, 37, 321, DateTimeKind.Utc).AddTicks(4482), new DateTime(2022, 5, 28, 14, 1, 37, 321, DateTimeKind.Utc).AddTicks(4484), "AQAAAAEAACcQAAAAELgZOVLgxcTw4h5ftdn4EbJfsyiCDf8cSPAXO61Tk1qMPx/eOx1IU16A8KXgihvZLA==", new DateTime(2022, 5, 28, 14, 1, 37, 321, DateTimeKind.Utc).AddTicks(4483) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2631"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "57d8eb64-18f0-4e68-8db8-24ca91c0ed72", new DateTime(2022, 5, 28, 14, 1, 37, 328, DateTimeKind.Utc).AddTicks(6402), new DateTime(2022, 5, 28, 14, 1, 37, 328, DateTimeKind.Utc).AddTicks(6408), "AQAAAAEAACcQAAAAEGkFCLpqFAkF54aHuxSZSQVVfvZVbcpmvd4sKymDRy1O6Lq3yUGkTPnUAGGmtNlhWw==", new DateTime(2022, 5, 28, 14, 1, 37, 328, DateTimeKind.Utc).AddTicks(6407) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2632"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "23378573-2d1d-462c-8362-dea8e6b47d04", new DateTime(2022, 5, 28, 14, 1, 37, 335, DateTimeKind.Utc).AddTicks(7967), new DateTime(2022, 5, 28, 14, 1, 37, 335, DateTimeKind.Utc).AddTicks(7969), "AQAAAAEAACcQAAAAEAf7rMhq30mX4pdcqyjNwPJ68Ww4cECt3Eaa0Y4x4eyCSpgVflT1ZTLuxMdLHlVJmA==", new DateTime(2022, 5, 28, 14, 1, 37, 335, DateTimeKind.Utc).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2633"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "f2f023af-8b12-44fa-bc5c-ec1ca5c3fb54", new DateTime(2022, 5, 28, 14, 1, 37, 343, DateTimeKind.Utc).AddTicks(42), new DateTime(2022, 5, 28, 14, 1, 37, 343, DateTimeKind.Utc).AddTicks(48), "AQAAAAEAACcQAAAAEH8CiJYUgVo6sjLhb9OM2eoPK7b2QvHKN6og8ZvHD5y3GZpacdv6xLAt7j8V5X+lvA==", new DateTime(2022, 5, 28, 14, 1, 37, 343, DateTimeKind.Utc).AddTicks(46) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2634"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "59f7431b-188c-4b12-957c-f86518575813", new DateTime(2022, 5, 28, 14, 1, 37, 350, DateTimeKind.Utc).AddTicks(1988), new DateTime(2022, 5, 28, 14, 1, 37, 350, DateTimeKind.Utc).AddTicks(1991), "AQAAAAEAACcQAAAAEF2rjlmXWqFWpeNmW7MLZLbt2kGNU0GAEC51Qm1uiSkkK7EXjcXFEBLY8C8A7nH1YQ==", new DateTime(2022, 5, 28, 14, 1, 37, 350, DateTimeKind.Utc).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2635"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "32db5a40-b5b7-40f6-a3f0-94c65172177f", new DateTime(2022, 5, 28, 14, 1, 37, 357, DateTimeKind.Utc).AddTicks(4115), new DateTime(2022, 5, 28, 14, 1, 37, 357, DateTimeKind.Utc).AddTicks(4122), "AQAAAAEAACcQAAAAEOj8kgcF5RsMsMg5VC6MXarZpJ8gy0lP9TPISTXAgj8oGg2y9u8SVoA9SnF703KgQA==", new DateTime(2022, 5, 28, 14, 1, 37, 357, DateTimeKind.Utc).AddTicks(4120) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2636"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "639f8289-b6c5-4f93-89d2-bf59cd5bebcf", new DateTime(2022, 5, 28, 14, 1, 37, 364, DateTimeKind.Utc).AddTicks(5721), new DateTime(2022, 5, 28, 14, 1, 37, 364, DateTimeKind.Utc).AddTicks(5723), "AQAAAAEAACcQAAAAEPAEPgXMit6P43u61/Pqn6oYvD7Eqx4kwS2uhB6HGEAktziFWhOfx4qrnvSIK9LVDw==", new DateTime(2022, 5, 28, 14, 1, 37, 364, DateTimeKind.Utc).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2637"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "a2966f30-9daa-472f-bb6c-cf509608201d", new DateTime(2022, 5, 28, 14, 1, 37, 371, DateTimeKind.Utc).AddTicks(7675), new DateTime(2022, 5, 28, 14, 1, 37, 371, DateTimeKind.Utc).AddTicks(7681), "AQAAAAEAACcQAAAAEE/fT57m50rB1B1qECYbTw+yqCa8gyT8SEAGTP8JErw/vFpXUwbarUmour15VsM0uQ==", new DateTime(2022, 5, 28, 14, 1, 37, 371, DateTimeKind.Utc).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2638"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "f70f1cd7-cab5-4ba2-83a0-1a5f1ac66cfa", new DateTime(2022, 5, 28, 14, 1, 37, 378, DateTimeKind.Utc).AddTicks(9269), new DateTime(2022, 5, 28, 14, 1, 37, 378, DateTimeKind.Utc).AddTicks(9271), "AQAAAAEAACcQAAAAEKyjzVXio3JB+Lc9d96VBvu+GRta7e1Z/Rvf1y6dV6NqkEUVHf1zSajkWoNOtoooWw==", new DateTime(2022, 5, 28, 14, 1, 37, 378, DateTimeKind.Utc).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2639"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "4cd84a5c-18fd-4816-950a-78ec1fd8ed93", new DateTime(2022, 5, 28, 14, 1, 37, 386, DateTimeKind.Utc).AddTicks(1782), new DateTime(2022, 5, 28, 14, 1, 37, 386, DateTimeKind.Utc).AddTicks(1791), "AQAAAAEAACcQAAAAEDe+jq4T8HHs4fgTKlOkYr6iS/Y5O/NVQIbjYValPIOxTJuca/3NAJALEVIoUTChCw==", new DateTime(2022, 5, 28, 14, 1, 37, 386, DateTimeKind.Utc).AddTicks(1789) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2640"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "2cbfd8a8-9e5d-4981-9d4a-1d40ddd42a3c", new DateTime(2022, 5, 28, 14, 1, 37, 394, DateTimeKind.Utc).AddTicks(7711), new DateTime(2022, 5, 28, 14, 1, 37, 394, DateTimeKind.Utc).AddTicks(7726), "AQAAAAEAACcQAAAAEJqxi8bWs9kFrrfDXcLUVorSC+1dVR80lp8WrKdhChZxsraIxH7F3xdtGBb+LKzmjQ==", new DateTime(2022, 5, 28, 14, 1, 37, 394, DateTimeKind.Utc).AddTicks(7721) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2641"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "5a4a7fce-a2c0-486c-9d42-f1f8fa0be09e", new DateTime(2022, 5, 28, 14, 1, 37, 403, DateTimeKind.Utc).AddTicks(8866), new DateTime(2022, 5, 28, 14, 1, 37, 403, DateTimeKind.Utc).AddTicks(8879), "AQAAAAEAACcQAAAAEMndeiveNUPEVDfJ49nTDItu6ab5FAVdOx2Oog1rFa09MP3i9T9hhnE4d2i10TFccw==", new DateTime(2022, 5, 28, 14, 1, 37, 403, DateTimeKind.Utc).AddTicks(8875) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2642"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "5aab94c1-cd74-4505-b4d6-fe1a67469e58", new DateTime(2022, 5, 28, 14, 1, 37, 413, DateTimeKind.Utc).AddTicks(8032), new DateTime(2022, 5, 28, 14, 1, 37, 413, DateTimeKind.Utc).AddTicks(8044), "AQAAAAEAACcQAAAAEBekQyYQ49TpfWKhSZr3a2ZBM9mTZOF5bfiHn1Tt/MaYFcrjl4b+bF/m3VO69gM0dw==", new DateTime(2022, 5, 28, 14, 1, 37, 413, DateTimeKind.Utc).AddTicks(8040) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2643"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "96908203-4fc9-403c-bbce-b4ca40a76492", new DateTime(2022, 5, 28, 14, 1, 37, 421, DateTimeKind.Utc).AddTicks(1307), new DateTime(2022, 5, 28, 14, 1, 37, 421, DateTimeKind.Utc).AddTicks(1324), "AQAAAAEAACcQAAAAEG8O1dc5ug4cxpjT/rzGtcfhgY5U6ER20KJa7MiERey3tUSkSCFrPHNKX44EXBqibg==", new DateTime(2022, 5, 28, 14, 1, 37, 421, DateTimeKind.Utc).AddTicks(1321) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2644"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "248d6b94-6c20-4abb-934c-4b4a1265b14f", new DateTime(2022, 5, 28, 14, 1, 37, 429, DateTimeKind.Utc).AddTicks(605), new DateTime(2022, 5, 28, 14, 1, 37, 429, DateTimeKind.Utc).AddTicks(619), "AQAAAAEAACcQAAAAEGbVSyzj+IYlksIXMAIDErJM34NJeRFW2vLLaNRvzqTqNW7Fs9CziBEeM3Gp1ZGEkA==", new DateTime(2022, 5, 28, 14, 1, 37, 429, DateTimeKind.Utc).AddTicks(613) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2645"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "11475c25-784f-4084-b456-450a61d55bb1", new DateTime(2022, 5, 28, 14, 1, 37, 436, DateTimeKind.Utc).AddTicks(2803), new DateTime(2022, 5, 28, 14, 1, 37, 436, DateTimeKind.Utc).AddTicks(2807), "AQAAAAEAACcQAAAAEAXzkw4wLhtqiY8X8j68sndmYRM+eOsAi7aptSDMTB2GH/0280oABORwWkZTmiLcHA==", new DateTime(2022, 5, 28, 14, 1, 37, 436, DateTimeKind.Utc).AddTicks(2806) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2646"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "9ba1fed1-a77e-4d9f-b708-bba1d57b6ae9", new DateTime(2022, 5, 28, 14, 1, 37, 443, DateTimeKind.Utc).AddTicks(5384), new DateTime(2022, 5, 28, 14, 1, 37, 443, DateTimeKind.Utc).AddTicks(5391), "AQAAAAEAACcQAAAAEJ3X/NEqgC0HbGrDscZ4bvyFw+ozFr24CMbNT13SvX0buioF5UhJKKydzd5vkkhNSQ==", new DateTime(2022, 5, 28, 14, 1, 37, 443, DateTimeKind.Utc).AddTicks(5388) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2647"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "f7da04ec-0dc2-49a5-8693-7e41e4f2636e", new DateTime(2022, 5, 28, 14, 1, 37, 450, DateTimeKind.Utc).AddTicks(7348), new DateTime(2022, 5, 28, 14, 1, 37, 450, DateTimeKind.Utc).AddTicks(7350), "AQAAAAEAACcQAAAAEIIA+hTBpmCuBDrz1vHKEUfSblao4cC6mwNpJj8dmxRFQSqrmyifVAPZo4MpK5/azQ==", new DateTime(2022, 5, 28, 14, 1, 37, 450, DateTimeKind.Utc).AddTicks(7349) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2648"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "54e6f006-4737-46f4-9c2f-fbc749f3225d", new DateTime(2022, 5, 28, 14, 1, 37, 457, DateTimeKind.Utc).AddTicks(9138), new DateTime(2022, 5, 28, 14, 1, 37, 457, DateTimeKind.Utc).AddTicks(9143), "AQAAAAEAACcQAAAAELsByWUD5x1IM/5HCphI7d7IDICQD7fXtmV77hbGDF6Q0T2DLJcjjd3eNBZJ4smFOQ==", new DateTime(2022, 5, 28, 14, 1, 37, 457, DateTimeKind.Utc).AddTicks(9141) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2649"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "ccf394b9-b9af-4afb-82af-9f6f0d69d946", new DateTime(2022, 5, 28, 14, 1, 37, 465, DateTimeKind.Utc).AddTicks(944), new DateTime(2022, 5, 28, 14, 1, 37, 465, DateTimeKind.Utc).AddTicks(949), "AQAAAAEAACcQAAAAEJAY7vYphm6KFM8NxvIjuF26YP8Ogwfbp9aYdFx60oDB7z4ABt5dbt64jc7m1Nhkhw==", new DateTime(2022, 5, 28, 14, 1, 37, 465, DateTimeKind.Utc).AddTicks(947) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2650"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "49ff46dc-0714-4a3e-a467-4f811ca42bb5", new DateTime(2022, 5, 28, 14, 1, 37, 472, DateTimeKind.Utc).AddTicks(2541), new DateTime(2022, 5, 28, 14, 1, 37, 472, DateTimeKind.Utc).AddTicks(2544), "AQAAAAEAACcQAAAAEHHVq0Q8mlfx0XZXJJPwhrQoG73GDmcvcsEmgqPha+HPYdhRITqoWCZysnfVt1NMrQ==", new DateTime(2022, 5, 28, 14, 1, 37, 472, DateTimeKind.Utc).AddTicks(2543) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "5e103b70-6354-494d-9d2d-0e19cfa8ff60", new DateTime(2022, 5, 28, 14, 1, 37, 479, DateTimeKind.Utc).AddTicks(4201), new DateTime(2022, 5, 28, 14, 1, 37, 479, DateTimeKind.Utc).AddTicks(4205), "AQAAAAEAACcQAAAAEE5iGdOnP2l6RFsJjg1KLP7sORRsluWSzUg16hXQvj/hoxxiS4ZYYz6wkBPO8GBsYg==", new DateTime(2022, 5, 28, 14, 1, 37, 479, DateTimeKind.Utc).AddTicks(4204) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "f984edb7-9d5a-4b48-ab16-435250542233", new DateTime(2022, 5, 28, 14, 1, 37, 486, DateTimeKind.Utc).AddTicks(7475), new DateTime(2022, 5, 28, 14, 1, 37, 486, DateTimeKind.Utc).AddTicks(7477), "AQAAAAEAACcQAAAAEFMCbqZacYckgN4BmhQNtmY3kwkmcEbeV+KYtlj6QmOhU1YY2O/IBkMekHbFnQZlRw==", new DateTime(2022, 5, 28, 14, 1, 37, 486, DateTimeKind.Utc).AddTicks(7476) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "17018d2c-f2d4-4422-b162-84323c745dd1", new DateTime(2022, 5, 28, 14, 1, 37, 496, DateTimeKind.Utc).AddTicks(1836), new DateTime(2022, 5, 28, 14, 1, 37, 496, DateTimeKind.Utc).AddTicks(1846), "AQAAAAEAACcQAAAAEDbpMpiyoqzvJQb7BJjDxyytXPitNqKw+/OlU1d0k1fjwj9yOxQvlq6bHmmvVG/4PQ==", new DateTime(2022, 5, 28, 14, 1, 37, 496, DateTimeKind.Utc).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "0897d733-29e5-4afc-86ce-40bb969d5125", new DateTime(2022, 5, 28, 14, 1, 37, 508, DateTimeKind.Utc).AddTicks(9884), new DateTime(2022, 5, 28, 14, 1, 37, 508, DateTimeKind.Utc).AddTicks(9894), "AQAAAAEAACcQAAAAEAPrvRFsxJQoo9DEJ5B8GIoSSwBvLxOne+gkkYmjLtM1+9S7scKMfCPIvONnI8uTdg==", new DateTime(2022, 5, 28, 14, 1, 37, 508, DateTimeKind.Utc).AddTicks(9892) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "8d170858-76df-4a47-8982-98ed9a486efc", new DateTime(2022, 5, 28, 14, 1, 37, 521, DateTimeKind.Utc).AddTicks(6871), new DateTime(2022, 5, 28, 14, 1, 37, 521, DateTimeKind.Utc).AddTicks(6878), "AQAAAAEAACcQAAAAEAlYnxUmn5+w+uhfgVT+EyJrgQvFoGTBlD0AJDAfpViqeRMMSMT0SaUSlPZeCoht/w==", new DateTime(2022, 5, 28, 14, 1, 37, 521, DateTimeKind.Utc).AddTicks(6876) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "eda9c488-d1f2-4ef5-b9e7-ab78f34a59c2", new DateTime(2022, 5, 28, 14, 1, 37, 529, DateTimeKind.Utc).AddTicks(4563), new DateTime(2022, 5, 28, 14, 1, 37, 529, DateTimeKind.Utc).AddTicks(4570), "AQAAAAEAACcQAAAAEIH0UrIdbznouIz/ghG6GubqnsgKsM/QU4JtaoVOglJ7TdFaLIEVGioxsGTZCFXYkQ==", new DateTime(2022, 5, 28, 14, 1, 37, 529, DateTimeKind.Utc).AddTicks(4568) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "67399c8c-59ad-4087-aaad-ed134def8ffb", new DateTime(2022, 5, 28, 14, 1, 37, 536, DateTimeKind.Utc).AddTicks(8502), new DateTime(2022, 5, 28, 14, 1, 37, 536, DateTimeKind.Utc).AddTicks(8504), "AQAAAAEAACcQAAAAEPbmW2wFkdHyJOU6nYhjaEfLlp5G0kZhSIfz6uLchYbgThwXvRJvpeE7c15UBBubUw==", new DateTime(2022, 5, 28, 14, 1, 37, 536, DateTimeKind.Utc).AddTicks(8503) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "b3732f43-434f-4a5f-b99f-811c6bc02c9a", new DateTime(2022, 5, 28, 14, 1, 37, 544, DateTimeKind.Utc).AddTicks(2529), new DateTime(2022, 5, 28, 14, 1, 37, 544, DateTimeKind.Utc).AddTicks(2533), "AQAAAAEAACcQAAAAECp4GxsvsBOB9gmf+qKWfM5RzYl7EnLRoKnAVEkEdEKmDxfXX8ew7D4QsLsx+ba6xw==", new DateTime(2022, 5, 28, 14, 1, 37, 544, DateTimeKind.Utc).AddTicks(2532) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "0802ced3-118f-4460-aedb-fdae14f32ab9", new DateTime(2022, 5, 28, 14, 1, 37, 551, DateTimeKind.Utc).AddTicks(6636), new DateTime(2022, 5, 28, 14, 1, 37, 551, DateTimeKind.Utc).AddTicks(6641), "AQAAAAEAACcQAAAAEDjBTmcKdxETiJb6WdnPms43/YYRlABg0Gm231PRjFgnhSS3tBBx9W3+DEjXkxchLw==", new DateTime(2022, 5, 28, 14, 1, 37, 551, DateTimeKind.Utc).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "082e7f5a-6a05-45cc-b50e-5a41e4ac4977", new DateTime(2022, 5, 28, 14, 1, 37, 559, DateTimeKind.Utc).AddTicks(1077), new DateTime(2022, 5, 28, 14, 1, 37, 559, DateTimeKind.Utc).AddTicks(1083), "AQAAAAEAACcQAAAAEDkgwtosGqiBI6HxcE79G09bg6gdckrdKzawS9Me08Ng2qyQv145JJrhAx62+WdkOg==", new DateTime(2022, 5, 28, 14, 1, 37, 559, DateTimeKind.Utc).AddTicks(1082) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3361"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "57a15e8e-8d06-4af9-af6f-9417db804782", new DateTime(2022, 5, 28, 14, 1, 37, 566, DateTimeKind.Utc).AddTicks(4899), new DateTime(2022, 5, 28, 14, 1, 37, 566, DateTimeKind.Utc).AddTicks(4901), "AQAAAAEAACcQAAAAEI7IiisHp91sKQ9LJF8Lh4Zm7E0pytsTWR0FDF922kjZziXyIFuqOjGbt/YRjQiIrw==", new DateTime(2022, 5, 28, 14, 1, 37, 566, DateTimeKind.Utc).AddTicks(4900) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3362"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "0b329a53-354c-4f04-8a47-cc9ebd2f172c", new DateTime(2022, 5, 28, 14, 1, 37, 573, DateTimeKind.Utc).AddTicks(8957), new DateTime(2022, 5, 28, 14, 1, 37, 573, DateTimeKind.Utc).AddTicks(8962), "AQAAAAEAACcQAAAAELN9Ml7jy/jafNrP94jryHzFvLPyug8c96BvGlhFHwASfBXzPxIMVBgYtrYjtBTUSA==", new DateTime(2022, 5, 28, 14, 1, 37, 573, DateTimeKind.Utc).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3363"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "3b30279e-a749-4cb0-8527-f719674a1910", new DateTime(2022, 5, 28, 14, 1, 37, 581, DateTimeKind.Utc).AddTicks(2593), new DateTime(2022, 5, 28, 14, 1, 37, 581, DateTimeKind.Utc).AddTicks(2595), "AQAAAAEAACcQAAAAEPu24d0yYw+0PxlB0s3XUjdoRP7XO0b8ovPYWxoZTQQEC4XuFBiU6qa56COFRdwvpw==", new DateTime(2022, 5, 28, 14, 1, 37, 581, DateTimeKind.Utc).AddTicks(2594) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3364"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "50a06ea8-ba20-48e1-a640-e03973dad12f", new DateTime(2022, 5, 28, 14, 1, 37, 588, DateTimeKind.Utc).AddTicks(4472), new DateTime(2022, 5, 28, 14, 1, 37, 588, DateTimeKind.Utc).AddTicks(4476), "AQAAAAEAACcQAAAAEEod+bLmXn9ww4bgHa5COZVakErPASs7jkjFv6ocwBK2deHCiGzgbZzCYueq7mVvmQ==", new DateTime(2022, 5, 28, 14, 1, 37, 588, DateTimeKind.Utc).AddTicks(4474) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3365"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "7cdc82ee-2af5-430c-a490-071b3d521398", new DateTime(2022, 5, 28, 14, 1, 37, 595, DateTimeKind.Utc).AddTicks(5806), new DateTime(2022, 5, 28, 14, 1, 37, 595, DateTimeKind.Utc).AddTicks(5808), "AQAAAAEAACcQAAAAEAZdf1pIhcbcTLN1ueu93LDAthk70BDrNdWWdDmKupE4z+AO6sbbsj6Otz+wzsLiig==", new DateTime(2022, 5, 28, 14, 1, 37, 595, DateTimeKind.Utc).AddTicks(5807) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3366"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "5b61cade-716c-47dd-8499-392dd3c62fee", new DateTime(2022, 5, 28, 14, 1, 37, 602, DateTimeKind.Utc).AddTicks(7274), new DateTime(2022, 5, 28, 14, 1, 37, 602, DateTimeKind.Utc).AddTicks(7277), "AQAAAAEAACcQAAAAEClIifP7eB3+AQ7ZtQaX0uGweYJWuBxRV2TrTITBkYQFQGadNMzpBWBIEHXy8SKJkw==", new DateTime(2022, 5, 28, 14, 1, 37, 602, DateTimeKind.Utc).AddTicks(7276) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3367"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "2f7fd67d-40f7-40ed-a797-06edafda6451", new DateTime(2022, 5, 28, 14, 1, 37, 609, DateTimeKind.Utc).AddTicks(8675), new DateTime(2022, 5, 28, 14, 1, 37, 609, DateTimeKind.Utc).AddTicks(8677), "AQAAAAEAACcQAAAAEN38hYt1uL6LUUfxHrfADAT4Zd4oYH5qkDU4daELwIJYInonV3gdFHPoIM3VTZil1g==", new DateTime(2022, 5, 28, 14, 1, 37, 609, DateTimeKind.Utc).AddTicks(8676) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3368"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "a939d407-243e-4970-a52e-bbd254e89ba5", new DateTime(2022, 5, 28, 14, 1, 37, 617, DateTimeKind.Utc).AddTicks(219), new DateTime(2022, 5, 28, 14, 1, 37, 617, DateTimeKind.Utc).AddTicks(222), "AQAAAAEAACcQAAAAEMXmD46u8rrToycrirflnetHv+capL9rtuSImgrSeX0cL11Pq1PTlqcmIT3o4TsWzw==", new DateTime(2022, 5, 28, 14, 1, 37, 617, DateTimeKind.Utc).AddTicks(221) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3369"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "0fd13481-884b-446a-a3ef-c067fe898b86", new DateTime(2022, 5, 28, 14, 1, 37, 624, DateTimeKind.Utc).AddTicks(1883), new DateTime(2022, 5, 28, 14, 1, 37, 624, DateTimeKind.Utc).AddTicks(1885), "AQAAAAEAACcQAAAAEBl+CHFheiE9ZYNT9oYNFrvolXFENyGMF4R+mwPw/sruCUkfOoo07VXhutjWGRr3qQ==", new DateTime(2022, 5, 28, 14, 1, 37, 624, DateTimeKind.Utc).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3370"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "f156096c-bed4-4425-af80-05e011127f52", new DateTime(2022, 5, 28, 14, 1, 37, 631, DateTimeKind.Utc).AddTicks(3260), new DateTime(2022, 5, 28, 14, 1, 37, 631, DateTimeKind.Utc).AddTicks(3262), "AQAAAAEAACcQAAAAEIPfVUoCEE0sN6w0el2FtaQZ9zH8eKpnjRWrnWhQtXV5fDzaYmyWMUesBdHFCxsLiQ==", new DateTime(2022, 5, 28, 14, 1, 37, 631, DateTimeKind.Utc).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3371"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "0154901b-1cf1-40df-bb5f-38c19c7f6141", new DateTime(2022, 5, 28, 14, 1, 37, 638, DateTimeKind.Utc).AddTicks(5507), new DateTime(2022, 5, 28, 14, 1, 37, 638, DateTimeKind.Utc).AddTicks(5512), "AQAAAAEAACcQAAAAEOcpcbusfnVKlG9v8xVssj+JGe4UG873aVyjBAfegBnWq7Pj0k8p+HTwVqOCyc22/A==", new DateTime(2022, 5, 28, 14, 1, 37, 638, DateTimeKind.Utc).AddTicks(5511) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiryTime",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(7825), new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(8356), new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(8035) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9486), new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9489), new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9487) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9516), new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9518), new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9517) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9540), new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9541), new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9541) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9562), new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9564), new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9563) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9602), new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9604), new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9603) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9633), new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9635), new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9634) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9778), new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9781), new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9813), new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9814), new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9814) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9847), new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9849), new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9848) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9875), new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9877), new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9876) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9905), new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9906), new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9905) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9932), new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9934), new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9933) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9960), new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9962), new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9961) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9994), new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9996), new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(9995) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(24), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(26), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(25) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(152), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(155), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(154) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(191), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(193), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(192) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(221), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(223), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(222) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(249), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(251), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(280), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(282), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(281) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(310), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(312), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(311) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(339), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(340), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(367), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(369), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(368) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(395), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(396), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(395) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(494), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(497), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(496) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(553), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(555), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(554) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(581), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(583), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(582) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(609), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(611), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(610) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(638), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(640), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(639) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(669), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(671), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(670) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(725), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(728), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(727) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(778), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(780), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(779) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(861), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(863), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(862) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(934), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(938), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(936) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(969), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(971), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(997), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(999), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(998) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1026), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1028), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1027) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1056), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1058), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1085), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1087), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1086) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1112), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1114), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1157), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1160), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1159) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1224), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1226), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1225) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1338), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1339), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1338) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1359), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1360), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1359) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1379), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1381), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1400), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1402), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1401) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1421), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1422), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1422) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1442), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1443), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1443) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1462), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1464), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1463) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1484), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1485), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1484) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1504), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1506), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1505) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1554), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1555), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1554) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1575), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1576), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1575) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1595), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1597), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1617), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1618), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1638), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1639), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1659), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1660), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1679), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1681), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1680) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1700), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1701), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1700) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1720), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1722), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1770), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1772), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1771) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1791), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1792), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1791) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1812), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1813), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1812) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1833), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1834), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1834) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1859), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1861), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1860) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1880), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1882), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1881) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1901), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1903), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1902) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1922), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1924), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1976), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1977), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1977) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1997), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1999), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(1998) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2018), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2020), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2019) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2039), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2040), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2039) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2059), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2061), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2080), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2081), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2080) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2101), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2102), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2101) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2121), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2123), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2122) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2142), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2144), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2143) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2192), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2193), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2214), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2216), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2215) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2235), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2237), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2236) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2256), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2258), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2277), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2279), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2278) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2298), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2300), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2299) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2319), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2321), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2320) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2340), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2342), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2361), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2363), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2362) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2411), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2412), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2411) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2432), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2434), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2433) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2453), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2455), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2454) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2474), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2475), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2475) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2496), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2497), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2496) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2519), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2521), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2520) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2540), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2542), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2541) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2561), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2562), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2562) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2582), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2583), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2582) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2602), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2604), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2603) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2652), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2653), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2652) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2672), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2674), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2673) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2693), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2695), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2714), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2716), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2715) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2735), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2736), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2736) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2756), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2758), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2757) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2777), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2778), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2778) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2798), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2799), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2798) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2818), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2820), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2819) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2882), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2883), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2903), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2905), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2904) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2924), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2926), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2945), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2947), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2946) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2966), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2968), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2967) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2987), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2989), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3008), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3010), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3009) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3029), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3030), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3050), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3051), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3050) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3126), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3127), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3126) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3148), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3149), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3169), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3171), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3190), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3191), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3191) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3210), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3212), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3211) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3231), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3232), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3251), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3253), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3252) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3273), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3274), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3273) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3293), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3295), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3294) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3339), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3341), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3360), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3362), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3361) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3381), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3383), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3382) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3403), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3404), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3403) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3424), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3425), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3425) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3447), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3448), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3447) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3468), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3469), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3523), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3525), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3524) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3545), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3546), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3545) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3565), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3567), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3566) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3586), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3588), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3587) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3607), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3609), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3608) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3629), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3630), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3650), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3651), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3651) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3671), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3673), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3672) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3692), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3693), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3693) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3746), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3748), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3747) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3768), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3770), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3769) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3789), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3791), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3790) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3810), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3812), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3811) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3831), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3832), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3832) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3852), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3853), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3852) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3872), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3874), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3873) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3894), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3895), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3894) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3915), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3917), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3916) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3961), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3963), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3962) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3982), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3984), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(4003), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(4005), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(4004) });

            migrationBuilder.UpdateData(
                table: "Booking_Details",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(4025), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(4026), new DateTime(2022, 5, 28, 9, 27, 30, 976, DateTimeKind.Utc).AddTicks(4026) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 915, DateTimeKind.Utc).AddTicks(7659), new DateTime(2022, 5, 28, 9, 27, 30, 915, DateTimeKind.Utc).AddTicks(7047), new DateTime(2022, 5, 28, 9, 27, 30, 915, DateTimeKind.Utc).AddTicks(8004), new DateTime(2022, 5, 28, 9, 27, 30, 915, DateTimeKind.Utc).AddTicks(7818) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 917, DateTimeKind.Utc).AddTicks(2692), new DateTime(2022, 5, 28, 9, 27, 30, 917, DateTimeKind.Utc).AddTicks(2691), new DateTime(2022, 5, 28, 9, 27, 30, 917, DateTimeKind.Utc).AddTicks(2694), new DateTime(2022, 5, 28, 9, 27, 30, 917, DateTimeKind.Utc).AddTicks(2693) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 918, DateTimeKind.Utc).AddTicks(4313), new DateTime(2022, 5, 28, 9, 27, 30, 918, DateTimeKind.Utc).AddTicks(4312), new DateTime(2022, 5, 28, 9, 27, 30, 918, DateTimeKind.Utc).AddTicks(4314), new DateTime(2022, 5, 28, 9, 27, 30, 918, DateTimeKind.Utc).AddTicks(4313) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 919, DateTimeKind.Utc).AddTicks(5877), new DateTime(2022, 5, 28, 9, 27, 30, 919, DateTimeKind.Utc).AddTicks(5876), new DateTime(2022, 5, 28, 9, 27, 30, 919, DateTimeKind.Utc).AddTicks(5879), new DateTime(2022, 5, 28, 9, 27, 30, 919, DateTimeKind.Utc).AddTicks(5878) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 920, DateTimeKind.Utc).AddTicks(7394), new DateTime(2022, 5, 28, 9, 27, 30, 920, DateTimeKind.Utc).AddTicks(7394), new DateTime(2022, 5, 28, 9, 27, 30, 920, DateTimeKind.Utc).AddTicks(7396), new DateTime(2022, 5, 28, 9, 27, 30, 920, DateTimeKind.Utc).AddTicks(7395) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 921, DateTimeKind.Utc).AddTicks(9052), new DateTime(2022, 5, 28, 9, 27, 30, 921, DateTimeKind.Utc).AddTicks(9051), new DateTime(2022, 5, 28, 9, 27, 30, 921, DateTimeKind.Utc).AddTicks(9054), new DateTime(2022, 5, 28, 9, 27, 30, 921, DateTimeKind.Utc).AddTicks(9053) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 923, DateTimeKind.Utc).AddTicks(661), new DateTime(2022, 5, 28, 9, 27, 30, 923, DateTimeKind.Utc).AddTicks(660), new DateTime(2022, 5, 28, 9, 27, 30, 923, DateTimeKind.Utc).AddTicks(662), new DateTime(2022, 5, 28, 9, 27, 30, 923, DateTimeKind.Utc).AddTicks(661) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 924, DateTimeKind.Utc).AddTicks(2122), new DateTime(2022, 5, 28, 9, 27, 30, 924, DateTimeKind.Utc).AddTicks(2121), new DateTime(2022, 5, 28, 9, 27, 30, 924, DateTimeKind.Utc).AddTicks(2123), new DateTime(2022, 5, 28, 9, 27, 30, 924, DateTimeKind.Utc).AddTicks(2122) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 925, DateTimeKind.Utc).AddTicks(3507), new DateTime(2022, 5, 28, 9, 27, 30, 925, DateTimeKind.Utc).AddTicks(3506), new DateTime(2022, 5, 28, 9, 27, 30, 925, DateTimeKind.Utc).AddTicks(3509), new DateTime(2022, 5, 28, 9, 27, 30, 925, DateTimeKind.Utc).AddTicks(3508) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 926, DateTimeKind.Utc).AddTicks(5165), new DateTime(2022, 5, 28, 9, 27, 30, 926, DateTimeKind.Utc).AddTicks(5164), new DateTime(2022, 5, 28, 9, 27, 30, 926, DateTimeKind.Utc).AddTicks(5167), new DateTime(2022, 5, 28, 9, 27, 30, 926, DateTimeKind.Utc).AddTicks(5166) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 927, DateTimeKind.Utc).AddTicks(6587), new DateTime(2022, 5, 28, 9, 27, 30, 927, DateTimeKind.Utc).AddTicks(6586), new DateTime(2022, 5, 28, 9, 27, 30, 927, DateTimeKind.Utc).AddTicks(6588), new DateTime(2022, 5, 28, 9, 27, 30, 927, DateTimeKind.Utc).AddTicks(6588) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 928, DateTimeKind.Utc).AddTicks(8290), new DateTime(2022, 5, 28, 9, 27, 30, 928, DateTimeKind.Utc).AddTicks(8288), new DateTime(2022, 5, 28, 9, 27, 30, 928, DateTimeKind.Utc).AddTicks(8292), new DateTime(2022, 5, 28, 9, 27, 30, 928, DateTimeKind.Utc).AddTicks(8291) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 930, DateTimeKind.Utc).AddTicks(73), new DateTime(2022, 5, 28, 9, 27, 30, 930, DateTimeKind.Utc).AddTicks(72), new DateTime(2022, 5, 28, 9, 27, 30, 930, DateTimeKind.Utc).AddTicks(74), new DateTime(2022, 5, 28, 9, 27, 30, 930, DateTimeKind.Utc).AddTicks(74) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 931, DateTimeKind.Utc).AddTicks(1813), new DateTime(2022, 5, 28, 9, 27, 30, 931, DateTimeKind.Utc).AddTicks(1812), new DateTime(2022, 5, 28, 9, 27, 30, 931, DateTimeKind.Utc).AddTicks(1815), new DateTime(2022, 5, 28, 9, 27, 30, 931, DateTimeKind.Utc).AddTicks(1814) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 932, DateTimeKind.Utc).AddTicks(3263), new DateTime(2022, 5, 28, 9, 27, 30, 932, DateTimeKind.Utc).AddTicks(3263), new DateTime(2022, 5, 28, 9, 27, 30, 932, DateTimeKind.Utc).AddTicks(3265), new DateTime(2022, 5, 28, 9, 27, 30, 932, DateTimeKind.Utc).AddTicks(3264) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 933, DateTimeKind.Utc).AddTicks(4727), new DateTime(2022, 5, 28, 9, 27, 30, 933, DateTimeKind.Utc).AddTicks(4726), new DateTime(2022, 5, 28, 9, 27, 30, 933, DateTimeKind.Utc).AddTicks(4729), new DateTime(2022, 5, 28, 9, 27, 30, 933, DateTimeKind.Utc).AddTicks(4728) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 934, DateTimeKind.Utc).AddTicks(6347), new DateTime(2022, 5, 28, 9, 27, 30, 934, DateTimeKind.Utc).AddTicks(6346), new DateTime(2022, 5, 28, 9, 27, 30, 934, DateTimeKind.Utc).AddTicks(6348), new DateTime(2022, 5, 28, 9, 27, 30, 934, DateTimeKind.Utc).AddTicks(6347) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 935, DateTimeKind.Utc).AddTicks(7966), new DateTime(2022, 5, 28, 9, 27, 30, 935, DateTimeKind.Utc).AddTicks(7965), new DateTime(2022, 5, 28, 9, 27, 30, 935, DateTimeKind.Utc).AddTicks(7968), new DateTime(2022, 5, 28, 9, 27, 30, 935, DateTimeKind.Utc).AddTicks(7967) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 936, DateTimeKind.Utc).AddTicks(9538), new DateTime(2022, 5, 28, 9, 27, 30, 936, DateTimeKind.Utc).AddTicks(9538), new DateTime(2022, 5, 28, 9, 27, 30, 936, DateTimeKind.Utc).AddTicks(9540), new DateTime(2022, 5, 28, 9, 27, 30, 936, DateTimeKind.Utc).AddTicks(9539) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 938, DateTimeKind.Utc).AddTicks(1032), new DateTime(2022, 5, 28, 9, 27, 30, 938, DateTimeKind.Utc).AddTicks(1031), new DateTime(2022, 5, 28, 9, 27, 30, 938, DateTimeKind.Utc).AddTicks(1034), new DateTime(2022, 5, 28, 9, 27, 30, 938, DateTimeKind.Utc).AddTicks(1033) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 939, DateTimeKind.Utc).AddTicks(2558), new DateTime(2022, 5, 28, 9, 27, 30, 939, DateTimeKind.Utc).AddTicks(2557), new DateTime(2022, 5, 28, 9, 27, 30, 939, DateTimeKind.Utc).AddTicks(2559), new DateTime(2022, 5, 28, 9, 27, 30, 939, DateTimeKind.Utc).AddTicks(2558) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 940, DateTimeKind.Utc).AddTicks(4022), new DateTime(2022, 5, 28, 9, 27, 30, 940, DateTimeKind.Utc).AddTicks(4021), new DateTime(2022, 5, 28, 9, 27, 30, 940, DateTimeKind.Utc).AddTicks(4023), new DateTime(2022, 5, 28, 9, 27, 30, 940, DateTimeKind.Utc).AddTicks(4022) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 941, DateTimeKind.Utc).AddTicks(5603), new DateTime(2022, 5, 28, 9, 27, 30, 941, DateTimeKind.Utc).AddTicks(5602), new DateTime(2022, 5, 28, 9, 27, 30, 941, DateTimeKind.Utc).AddTicks(5604), new DateTime(2022, 5, 28, 9, 27, 30, 941, DateTimeKind.Utc).AddTicks(5603) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 942, DateTimeKind.Utc).AddTicks(7091), new DateTime(2022, 5, 28, 9, 27, 30, 942, DateTimeKind.Utc).AddTicks(7090), new DateTime(2022, 5, 28, 9, 27, 30, 942, DateTimeKind.Utc).AddTicks(7093), new DateTime(2022, 5, 28, 9, 27, 30, 942, DateTimeKind.Utc).AddTicks(7092) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 943, DateTimeKind.Utc).AddTicks(8583), new DateTime(2022, 5, 28, 9, 27, 30, 943, DateTimeKind.Utc).AddTicks(8582), new DateTime(2022, 5, 28, 9, 27, 30, 943, DateTimeKind.Utc).AddTicks(8584), new DateTime(2022, 5, 28, 9, 27, 30, 943, DateTimeKind.Utc).AddTicks(8584) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 945, DateTimeKind.Utc).AddTicks(516), new DateTime(2022, 5, 28, 9, 27, 30, 945, DateTimeKind.Utc).AddTicks(514), new DateTime(2022, 5, 28, 9, 27, 30, 945, DateTimeKind.Utc).AddTicks(518), new DateTime(2022, 5, 28, 9, 27, 30, 945, DateTimeKind.Utc).AddTicks(517) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 946, DateTimeKind.Utc).AddTicks(1980), new DateTime(2022, 5, 28, 9, 27, 30, 946, DateTimeKind.Utc).AddTicks(1979), new DateTime(2022, 5, 28, 9, 27, 30, 946, DateTimeKind.Utc).AddTicks(1982), new DateTime(2022, 5, 28, 9, 27, 30, 946, DateTimeKind.Utc).AddTicks(1981) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 947, DateTimeKind.Utc).AddTicks(3424), new DateTime(2022, 5, 28, 9, 27, 30, 947, DateTimeKind.Utc).AddTicks(3423), new DateTime(2022, 5, 28, 9, 27, 30, 947, DateTimeKind.Utc).AddTicks(3426), new DateTime(2022, 5, 28, 9, 27, 30, 947, DateTimeKind.Utc).AddTicks(3425) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 948, DateTimeKind.Utc).AddTicks(4999), new DateTime(2022, 5, 28, 9, 27, 30, 948, DateTimeKind.Utc).AddTicks(4998), new DateTime(2022, 5, 28, 9, 27, 30, 948, DateTimeKind.Utc).AddTicks(5000), new DateTime(2022, 5, 28, 9, 27, 30, 948, DateTimeKind.Utc).AddTicks(5000) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 949, DateTimeKind.Utc).AddTicks(6624), new DateTime(2022, 5, 28, 9, 27, 30, 949, DateTimeKind.Utc).AddTicks(6623), new DateTime(2022, 5, 28, 9, 27, 30, 949, DateTimeKind.Utc).AddTicks(6626), new DateTime(2022, 5, 28, 9, 27, 30, 949, DateTimeKind.Utc).AddTicks(6625) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 950, DateTimeKind.Utc).AddTicks(8260), new DateTime(2022, 5, 28, 9, 27, 30, 950, DateTimeKind.Utc).AddTicks(8259), new DateTime(2022, 5, 28, 9, 27, 30, 950, DateTimeKind.Utc).AddTicks(8262), new DateTime(2022, 5, 28, 9, 27, 30, 950, DateTimeKind.Utc).AddTicks(8261) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 951, DateTimeKind.Utc).AddTicks(9768), new DateTime(2022, 5, 28, 9, 27, 30, 951, DateTimeKind.Utc).AddTicks(9767), new DateTime(2022, 5, 28, 9, 27, 30, 951, DateTimeKind.Utc).AddTicks(9770), new DateTime(2022, 5, 28, 9, 27, 30, 951, DateTimeKind.Utc).AddTicks(9769) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 953, DateTimeKind.Utc).AddTicks(1483), new DateTime(2022, 5, 28, 9, 27, 30, 953, DateTimeKind.Utc).AddTicks(1482), new DateTime(2022, 5, 28, 9, 27, 30, 953, DateTimeKind.Utc).AddTicks(1485), new DateTime(2022, 5, 28, 9, 27, 30, 953, DateTimeKind.Utc).AddTicks(1484) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 954, DateTimeKind.Utc).AddTicks(3099), new DateTime(2022, 5, 28, 9, 27, 30, 954, DateTimeKind.Utc).AddTicks(3098), new DateTime(2022, 5, 28, 9, 27, 30, 954, DateTimeKind.Utc).AddTicks(3100), new DateTime(2022, 5, 28, 9, 27, 30, 954, DateTimeKind.Utc).AddTicks(3099) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 955, DateTimeKind.Utc).AddTicks(4610), new DateTime(2022, 5, 28, 9, 27, 30, 955, DateTimeKind.Utc).AddTicks(4609), new DateTime(2022, 5, 28, 9, 27, 30, 955, DateTimeKind.Utc).AddTicks(4611), new DateTime(2022, 5, 28, 9, 27, 30, 955, DateTimeKind.Utc).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 956, DateTimeKind.Utc).AddTicks(6138), new DateTime(2022, 5, 28, 9, 27, 30, 956, DateTimeKind.Utc).AddTicks(6137), new DateTime(2022, 5, 28, 9, 27, 30, 956, DateTimeKind.Utc).AddTicks(6140), new DateTime(2022, 5, 28, 9, 27, 30, 956, DateTimeKind.Utc).AddTicks(6139) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 957, DateTimeKind.Utc).AddTicks(7608), new DateTime(2022, 5, 28, 9, 27, 30, 957, DateTimeKind.Utc).AddTicks(7607), new DateTime(2022, 5, 28, 9, 27, 30, 957, DateTimeKind.Utc).AddTicks(7610), new DateTime(2022, 5, 28, 9, 27, 30, 957, DateTimeKind.Utc).AddTicks(7609) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 958, DateTimeKind.Utc).AddTicks(9106), new DateTime(2022, 5, 28, 9, 27, 30, 958, DateTimeKind.Utc).AddTicks(9105), new DateTime(2022, 5, 28, 9, 27, 30, 958, DateTimeKind.Utc).AddTicks(9107), new DateTime(2022, 5, 28, 9, 27, 30, 958, DateTimeKind.Utc).AddTicks(9106) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 960, DateTimeKind.Utc).AddTicks(1437), new DateTime(2022, 5, 28, 9, 27, 30, 960, DateTimeKind.Utc).AddTicks(1435), new DateTime(2022, 5, 28, 9, 27, 30, 960, DateTimeKind.Utc).AddTicks(1439), new DateTime(2022, 5, 28, 9, 27, 30, 960, DateTimeKind.Utc).AddTicks(1438) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 961, DateTimeKind.Utc).AddTicks(2937), new DateTime(2022, 5, 28, 9, 27, 30, 961, DateTimeKind.Utc).AddTicks(2936), new DateTime(2022, 5, 28, 9, 27, 30, 961, DateTimeKind.Utc).AddTicks(2938), new DateTime(2022, 5, 28, 9, 27, 30, 961, DateTimeKind.Utc).AddTicks(2938) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 962, DateTimeKind.Utc).AddTicks(4709), new DateTime(2022, 5, 28, 9, 27, 30, 962, DateTimeKind.Utc).AddTicks(4706), new DateTime(2022, 5, 28, 9, 27, 30, 962, DateTimeKind.Utc).AddTicks(4710), new DateTime(2022, 5, 28, 9, 27, 30, 962, DateTimeKind.Utc).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 963, DateTimeKind.Utc).AddTicks(6426), new DateTime(2022, 5, 28, 9, 27, 30, 963, DateTimeKind.Utc).AddTicks(6425), new DateTime(2022, 5, 28, 9, 27, 30, 963, DateTimeKind.Utc).AddTicks(6428), new DateTime(2022, 5, 28, 9, 27, 30, 963, DateTimeKind.Utc).AddTicks(6427) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 964, DateTimeKind.Utc).AddTicks(8006), new DateTime(2022, 5, 28, 9, 27, 30, 964, DateTimeKind.Utc).AddTicks(8005), new DateTime(2022, 5, 28, 9, 27, 30, 964, DateTimeKind.Utc).AddTicks(8008), new DateTime(2022, 5, 28, 9, 27, 30, 964, DateTimeKind.Utc).AddTicks(8007) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 966, DateTimeKind.Utc).AddTicks(79), new DateTime(2022, 5, 28, 9, 27, 30, 966, DateTimeKind.Utc).AddTicks(78), new DateTime(2022, 5, 28, 9, 27, 30, 966, DateTimeKind.Utc).AddTicks(80), new DateTime(2022, 5, 28, 9, 27, 30, 966, DateTimeKind.Utc).AddTicks(79) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 967, DateTimeKind.Utc).AddTicks(2018), new DateTime(2022, 5, 28, 9, 27, 30, 967, DateTimeKind.Utc).AddTicks(2018), new DateTime(2022, 5, 28, 9, 27, 30, 967, DateTimeKind.Utc).AddTicks(2020), new DateTime(2022, 5, 28, 9, 27, 30, 967, DateTimeKind.Utc).AddTicks(2019) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 968, DateTimeKind.Utc).AddTicks(3937), new DateTime(2022, 5, 28, 9, 27, 30, 968, DateTimeKind.Utc).AddTicks(3936), new DateTime(2022, 5, 28, 9, 27, 30, 968, DateTimeKind.Utc).AddTicks(3939), new DateTime(2022, 5, 28, 9, 27, 30, 968, DateTimeKind.Utc).AddTicks(3938) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 969, DateTimeKind.Utc).AddTicks(5850), new DateTime(2022, 5, 28, 9, 27, 30, 969, DateTimeKind.Utc).AddTicks(5849), new DateTime(2022, 5, 28, 9, 27, 30, 969, DateTimeKind.Utc).AddTicks(5852), new DateTime(2022, 5, 28, 9, 27, 30, 969, DateTimeKind.Utc).AddTicks(5851) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 970, DateTimeKind.Utc).AddTicks(7560), new DateTime(2022, 5, 28, 9, 27, 30, 970, DateTimeKind.Utc).AddTicks(7559), new DateTime(2022, 5, 28, 9, 27, 30, 970, DateTimeKind.Utc).AddTicks(7562), new DateTime(2022, 5, 28, 9, 27, 30, 970, DateTimeKind.Utc).AddTicks(7561) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 971, DateTimeKind.Utc).AddTicks(9425), new DateTime(2022, 5, 28, 9, 27, 30, 971, DateTimeKind.Utc).AddTicks(9424), new DateTime(2022, 5, 28, 9, 27, 30, 971, DateTimeKind.Utc).AddTicks(9427), new DateTime(2022, 5, 28, 9, 27, 30, 971, DateTimeKind.Utc).AddTicks(9426) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 973, DateTimeKind.Utc).AddTicks(1706), new DateTime(2022, 5, 28, 9, 27, 30, 973, DateTimeKind.Utc).AddTicks(1705), new DateTime(2022, 5, 28, 9, 27, 30, 973, DateTimeKind.Utc).AddTicks(1708), new DateTime(2022, 5, 28, 9, 27, 30, 973, DateTimeKind.Utc).AddTicks(1707) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 974, DateTimeKind.Utc).AddTicks(3691), new DateTime(2022, 5, 28, 9, 27, 30, 974, DateTimeKind.Utc).AddTicks(3690), new DateTime(2022, 5, 28, 9, 27, 30, 974, DateTimeKind.Utc).AddTicks(3692), new DateTime(2022, 5, 28, 9, 27, 30, 974, DateTimeKind.Utc).AddTicks(3691) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created_at", "Date", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(5959), new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(5958), new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(5960), new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(5959) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(5175), new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(5604), new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(5395) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(6462), new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(6468), new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(6466) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(6494), new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(6496), new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(6495) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(6519), new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(6521), new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(6543), new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(6546), new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(6545) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e20"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "e567cc4d-852e-403a-b701-ef90505740ea", new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(9807), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(177), new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(9984) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e21"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "0a3ab8d0-5526-4b81-b1c6-eff6fc83303d", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1207), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1212), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1211) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e22"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "32ed7d50-6c0b-4dbf-b014-390b19ed0c1a", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1243), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1245), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1244) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e23"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "d13ef0dd-83c8-4463-86da-2198263d1c4b", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1272), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1274), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1273) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e24"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "293f9320-6316-4b76-bfe0-9bc6cb88e779", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1300), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1302), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1301) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e25"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "d67c5540-3261-4140-b259-37a6904c7315", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1366), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1368), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1367) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e26"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "644347a2-c55b-4acd-8e37-50b6e2190692", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1408), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1410), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1409) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e27"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "f57066d3-3322-4a4e-92f9-90b8330ab011", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1435), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1437), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1436) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e28"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "a5b4373a-6c71-41b1-a413-91124111a2ad", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1462), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1465), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1464) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e29"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "f4a46ee3-af4d-42d4-9c81-79127a7d6688", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1491), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1493), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1492) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e30"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "cc92d415-d839-4bf8-a92a-42a2594d4cca", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1518), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1520), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1519) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e31"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "975a18d0-c215-4ad6-944c-826cf4adbad8", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1580), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1582), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e32"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "5a610fcb-38c6-4c6d-a90a-35eab494b223", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1608), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1610), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1609) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e33"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "b6f94ed9-9380-4e68-93ce-1c0a1f1d2b28", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1634), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1637), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e34"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "e8d6a79a-4732-4cfd-929e-ecd4c20f509c", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1664), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1666), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e35"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "f468b323-4e4e-4278-9b2f-84a68d8c85d1", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1691), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1693), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e36"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "93e45d88-0cc3-4e59-b882-940b6adaad76", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1753), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1755), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1754) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e37"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "2d72e52e-d4ba-439b-bd02-ae4503a328aa", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1782), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1784), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1783) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e38"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "4b612927-8a2d-43f5-9dbd-b5fbf5fda9af", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1809), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1811), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e39"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "14ad289c-4777-4714-8887-565e8979149f", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1837), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1839), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1838) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e40"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "713d4120-f00d-4d40-bcea-6b27f4cc95f7", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1864), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1866), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e41"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "96bd5306-3470-4187-8e60-7eda9bf6f55a", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1891), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1893), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(1892) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e42"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "32a8be4b-52b7-40ba-aab1-6ebb6d7e7f05", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2374), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2379), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2377) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e43"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "32470db1-59cb-44b6-9363-d88c127f2d0e", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2410), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2412), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2411) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e44"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "5cfc9dc3-b199-4a5f-8e99-d2e8e1419553", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2437), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2440), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e45"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "d08931a7-4efd-4dd8-a1bb-0eac4b8bbb67", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2465), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2467), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2466) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e46"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "25b8ed3c-260d-47ff-bb43-e878d48b5f6b", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2492), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2494), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2493) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e47"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "7b934abd-dc4b-4c1c-b228-45d31ea13cf5", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2519), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2521), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2520) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e48"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "83166a99-b01e-43da-8ee4-1f63dc96b0a7", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2597), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2599), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2598) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e49"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "d1746f21-1f43-4b3d-94e2-05e7541bf3ef", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2624), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2626), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2625) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e50"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "583d9391-a562-4f3e-b8c0-573f05ff49a8", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2653), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2655), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2654) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e51"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "13585499-8f5a-4d5e-b5ec-a8b25bd12eec", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2679), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2682), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e52"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "0ecd88a1-92ed-4ded-b489-8e48d123069f", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2707), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2709), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2708) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e53"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "74d26685-8dc0-4d52-9020-9dde157f4370", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2792), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2794), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2793) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e54"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "43383dfa-472f-4ab8-8aab-c089bed34e5d", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2820), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2822), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2821) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e55"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "3bc2109b-1718-4ceb-afb2-58cdc5bbd312", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2847), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2850), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2849) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e56"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "01ddb0de-f1f1-4991-a0b6-c6704b6fe907", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2874), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2876), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2875) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e57"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "92a61556-1a66-41b5-9228-607c3948b7a1", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2901), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2904), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(2903) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e58"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "320ae21b-242c-4a3f-ae10-7a183506b30d", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(3324), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(3330), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(3328) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e59"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "2817c122-739d-4b1e-8903-962bc0319bb3", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(3391), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(3393), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(3392) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e60"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "c1630456-a877-48f6-9bb2-4215cc1a78e6", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(3418), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(3420), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(3419) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e61"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "73a91908-a5f2-4206-b108-47c1ac94a2b0", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(3445), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(3447), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(3446) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e62"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "2c3caf76-0eba-4f70-848f-75c5fe0b71a5", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(3473), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(3475), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(3474) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e63"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "118a8e07-8dac-4f63-864f-36c07735b48a", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(3499), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(3501), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(3500) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e64"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "10fae6e5-2d18-4533-a92d-0bf4cbdc6fc6", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(3944), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(3948), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(3947) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e65"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "aa020439-659a-4ac0-b905-1b8245d1792a", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(3997), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(3999), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(3998) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e66"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "ee755325-5dbe-4f47-8049-41aa1670fcac", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(4027), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(4029), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(4028) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e67"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "ff852acf-e714-49e9-a3e0-28616f298092", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(4054), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(4057), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(4056) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e68"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "f4a97a81-71e2-4fa2-8181-2fa4b95ac2b2", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(4082), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(4084), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(4083) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e69"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "e150afa7-069a-4645-bec9-2853d3823550", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(4108), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(4110), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(4109) });

            migrationBuilder.UpdateData(
                table: "Dentists",
                keyColumn: "Id",
                keyValue: new Guid("4bc632aa-7765-4040-9fbf-f2bb408d8e70"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { "2d2d4b7a-f859-4e9b-ac2f-ad41c998c70e", new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(4172), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(4174), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Deleted_at", "EndDate", "StartDate", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 16, 27, 30, 908, DateTimeKind.Local).AddTicks(3524), new DateTime(2022, 5, 28, 16, 27, 30, 908, DateTimeKind.Local).AddTicks(4074), new DateTime(2022, 5, 28, 16, 27, 30, 908, DateTimeKind.Local).AddTicks(1885), new DateTime(2022, 5, 28, 16, 27, 30, 907, DateTimeKind.Local).AddTicks(7522), new DateTime(2022, 5, 28, 16, 27, 30, 908, DateTimeKind.Local).AddTicks(3695) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "Deleted_at", "EndDate", "StartDate", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(3710), new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(3714), new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(3706), new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(3694), new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(3711) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "Deleted_at", "EndDate", "StartDate", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(3885), new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(3887), new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(3881), new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(3878), new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(3886) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "Deleted_at", "EndDate", "StartDate", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(3916), new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(3918), new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(3914), new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(3913), new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(3917) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_at", "Deleted_at", "EndDate", "StartDate", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(3941), new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(3943), new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(3940), new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(3938), new DateTime(2022, 5, 28, 16, 27, 30, 909, DateTimeKind.Local).AddTicks(3942) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "2fdab47b-dfd4-4c40-9c8d-6e413b33960e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056c"),
                column: "ConcurrencyStamp",
                value: "99ef97f4-b59d-47de-afd2-41fa5dd5b616");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(5573), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(5931), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(5752) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(6932), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(6938), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(6937) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(6966), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(6968), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(6967) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(6991), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(6994), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(6992) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_at", "Deleted_at", "Updated_at" },
                values: new object[] { new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(7016), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(7018), new DateTime(2022, 5, 28, 16, 27, 30, 910, DateTimeKind.Local).AddTicks(7017) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2620"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "3056bb76-9e1d-4ec1-9a7e-a6329d54b035", new DateTime(2022, 5, 28, 9, 27, 30, 915, DateTimeKind.Utc).AddTicks(5067), new DateTime(2022, 5, 28, 9, 27, 30, 915, DateTimeKind.Utc).AddTicks(5450), "AQAAAAEAACcQAAAAEMQb4LT9M/pS+MWpGvn4gUxqA1hQfRXI4fd7aZrDxYyiADBvNHhnIVojcEcst2Qipg==", new DateTime(2022, 5, 28, 9, 27, 30, 915, DateTimeKind.Utc).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2621"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "8b2b7089-771a-419e-86c4-8080cfa5dedc", new DateTime(2022, 5, 28, 9, 27, 30, 917, DateTimeKind.Utc).AddTicks(2638), new DateTime(2022, 5, 28, 9, 27, 30, 917, DateTimeKind.Utc).AddTicks(2642), "AQAAAAEAACcQAAAAEMOB4ElRzxVPzXox/3QYPyR24Ua+cv9cPTABsB1b1KC23EZaBoMSsce0qMcIXrWmlQ==", new DateTime(2022, 5, 28, 9, 27, 30, 917, DateTimeKind.Utc).AddTicks(2641) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2622"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "261409fd-784b-4546-aa83-197b6f610ad2", new DateTime(2022, 5, 28, 9, 27, 30, 918, DateTimeKind.Utc).AddTicks(4284), new DateTime(2022, 5, 28, 9, 27, 30, 918, DateTimeKind.Utc).AddTicks(4286), "AQAAAAEAACcQAAAAEEL2gcaupOlAAFAztS/YyjSFsrulGQ84wOAj0utmbOT8Sxx2toSKOoQTPPEMhkq39g==", new DateTime(2022, 5, 28, 9, 27, 30, 918, DateTimeKind.Utc).AddTicks(4285) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2623"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "e3ef5f4f-506d-431d-985b-eb03af05da45", new DateTime(2022, 5, 28, 9, 27, 30, 919, DateTimeKind.Utc).AddTicks(5811), new DateTime(2022, 5, 28, 9, 27, 30, 919, DateTimeKind.Utc).AddTicks(5813), "AQAAAAEAACcQAAAAENNFToLu6eCa+mxd7JmmmGSKuVkjQC1/aI++697y+R616xjhOO8HSzRyWLroFGj3IA==", new DateTime(2022, 5, 28, 9, 27, 30, 919, DateTimeKind.Utc).AddTicks(5812) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2624"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "808b2104-cf0c-4fc8-855f-dd70be082c9d", new DateTime(2022, 5, 28, 9, 27, 30, 920, DateTimeKind.Utc).AddTicks(7362), new DateTime(2022, 5, 28, 9, 27, 30, 920, DateTimeKind.Utc).AddTicks(7364), "AQAAAAEAACcQAAAAEGiSA3KvKSIMkQ5OyKibUEQD3jGAQzo0naivoKY7unFTM3R8rR/RrE8H2XmO/W5ffQ==", new DateTime(2022, 5, 28, 9, 27, 30, 920, DateTimeKind.Utc).AddTicks(7363) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2625"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "f808c691-b333-4ed2-85dd-245405664b4b", new DateTime(2022, 5, 28, 9, 27, 30, 921, DateTimeKind.Utc).AddTicks(9026), new DateTime(2022, 5, 28, 9, 27, 30, 921, DateTimeKind.Utc).AddTicks(9028), "AQAAAAEAACcQAAAAEOboJCzAq92d2eqxxLwpF8QSForAw/Sk5bWvYQx93wI9ngxz2vr7np577GNf8PoExw==", new DateTime(2022, 5, 28, 9, 27, 30, 921, DateTimeKind.Utc).AddTicks(9027) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2626"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "cfba9422-1198-4031-b7b2-39cb555799ff", new DateTime(2022, 5, 28, 9, 27, 30, 923, DateTimeKind.Utc).AddTicks(633), new DateTime(2022, 5, 28, 9, 27, 30, 923, DateTimeKind.Utc).AddTicks(635), "AQAAAAEAACcQAAAAEJoVIc04ssHssN07Jfeg03w9LHYDj9NnBCRIaRiPjf4HL00Ya3HVH0ufqr/49nnZ0g==", new DateTime(2022, 5, 28, 9, 27, 30, 923, DateTimeKind.Utc).AddTicks(634) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2627"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "f66a4911-c07c-4a6a-b2d2-df16aa561317", new DateTime(2022, 5, 28, 9, 27, 30, 924, DateTimeKind.Utc).AddTicks(2096), new DateTime(2022, 5, 28, 9, 27, 30, 924, DateTimeKind.Utc).AddTicks(2097), "AQAAAAEAACcQAAAAEFi7qQncc/RHREpZeywgjI5ETVCf3+1eLxq3s+pdYUDIiAWqfvjSwJ/dVqKLalqZBA==", new DateTime(2022, 5, 28, 9, 27, 30, 924, DateTimeKind.Utc).AddTicks(2097) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2628"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "d4625ee8-5dbb-4e36-951a-e907bd106bf6", new DateTime(2022, 5, 28, 9, 27, 30, 925, DateTimeKind.Utc).AddTicks(3480), new DateTime(2022, 5, 28, 9, 27, 30, 925, DateTimeKind.Utc).AddTicks(3481), "AQAAAAEAACcQAAAAEKl5yLBloUFrmXkeAwWKatuleT5ufDyUttlvl/zDfamIt200CoMvJm5yTA8kag/i5w==", new DateTime(2022, 5, 28, 9, 27, 30, 925, DateTimeKind.Utc).AddTicks(3481) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2629"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "e6252313-eaeb-4545-b764-4187d10cc97b", new DateTime(2022, 5, 28, 9, 27, 30, 926, DateTimeKind.Utc).AddTicks(5140), new DateTime(2022, 5, 28, 9, 27, 30, 926, DateTimeKind.Utc).AddTicks(5141), "AQAAAAEAACcQAAAAECaA9b6lW3rjbCDs1mhSmNhF2d5uqmTzSlk6QAEfJ8J+neAzr+EKygAvtRT9ZZqM3w==", new DateTime(2022, 5, 28, 9, 27, 30, 926, DateTimeKind.Utc).AddTicks(5140) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2630"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "42cf7b6c-ce5e-48ff-9612-59ec09d77ed9", new DateTime(2022, 5, 28, 9, 27, 30, 927, DateTimeKind.Utc).AddTicks(6561), new DateTime(2022, 5, 28, 9, 27, 30, 927, DateTimeKind.Utc).AddTicks(6563), "AQAAAAEAACcQAAAAEBmE1aBjb54LqhUCZlhiLcZjw181vfMnFPSZA5OH8A41aXT/jArCx5YMLbTdws+6kw==", new DateTime(2022, 5, 28, 9, 27, 30, 927, DateTimeKind.Utc).AddTicks(6562) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2631"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "beeecb72-6766-40c2-945d-380201acc823", new DateTime(2022, 5, 28, 9, 27, 30, 928, DateTimeKind.Utc).AddTicks(8009), new DateTime(2022, 5, 28, 9, 27, 30, 928, DateTimeKind.Utc).AddTicks(8014), "AQAAAAEAACcQAAAAEAmHNNLoDfZb4FClVT6MUch4ufbKhtQX2cbTHaVvdXbaQxqlcVMOn3HnCEulqBxhOg==", new DateTime(2022, 5, 28, 9, 27, 30, 928, DateTimeKind.Utc).AddTicks(8013) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2632"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "716e312e-84d6-4fa0-8e47-bde890e9ea38", new DateTime(2022, 5, 28, 9, 27, 30, 930, DateTimeKind.Utc).AddTicks(38), new DateTime(2022, 5, 28, 9, 27, 30, 930, DateTimeKind.Utc).AddTicks(40), "AQAAAAEAACcQAAAAEDGs6unPpaPs9/TG1FXZ5Ous+aqKdHOhACrzJejVIBfINFmItWkAGC2UdviRiiDqTg==", new DateTime(2022, 5, 28, 9, 27, 30, 930, DateTimeKind.Utc).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2633"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "b61522e1-7023-4188-922d-cad93e726aa4", new DateTime(2022, 5, 28, 9, 27, 30, 931, DateTimeKind.Utc).AddTicks(1787), new DateTime(2022, 5, 28, 9, 27, 30, 931, DateTimeKind.Utc).AddTicks(1789), "AQAAAAEAACcQAAAAEG73FMyCw34EB7rYQohFfoFIE8DgZZYXLyiRctd5OpY/hCJGIkrttDp8JIH5R8rbUg==", new DateTime(2022, 5, 28, 9, 27, 30, 931, DateTimeKind.Utc).AddTicks(1788) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2634"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "a2d2c9e6-d80e-47a7-9f57-674a06332a16", new DateTime(2022, 5, 28, 9, 27, 30, 932, DateTimeKind.Utc).AddTicks(3237), new DateTime(2022, 5, 28, 9, 27, 30, 932, DateTimeKind.Utc).AddTicks(3239), "AQAAAAEAACcQAAAAEFpnegh6Nub80LTiGe+KlJ71oPraeZMl7G1sV5rmuILhbb7iAdsYk3MiCVp/LSlYOg==", new DateTime(2022, 5, 28, 9, 27, 30, 932, DateTimeKind.Utc).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2635"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "963b8ff6-3108-495c-910f-77e3d3d10b04", new DateTime(2022, 5, 28, 9, 27, 30, 933, DateTimeKind.Utc).AddTicks(4695), new DateTime(2022, 5, 28, 9, 27, 30, 933, DateTimeKind.Utc).AddTicks(4697), "AQAAAAEAACcQAAAAECoJeaPMZDZb1gcb099ix5BaUNqIzRJ5sF3+3YceiHuH+gWVg6b6AL4Q5NsAJj+IkQ==", new DateTime(2022, 5, 28, 9, 27, 30, 933, DateTimeKind.Utc).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2636"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "19afedec-76f5-45bd-919c-7800fd018a3f", new DateTime(2022, 5, 28, 9, 27, 30, 934, DateTimeKind.Utc).AddTicks(6302), new DateTime(2022, 5, 28, 9, 27, 30, 934, DateTimeKind.Utc).AddTicks(6304), "AQAAAAEAACcQAAAAECG8slMgZIkRNw/CPlyGHAbuIor9to2dBput0ZfS5w0HrFLpfwiYTtywGBZh0fYR5w==", new DateTime(2022, 5, 28, 9, 27, 30, 934, DateTimeKind.Utc).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2637"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "cb0eb8ae-1ceb-4336-8425-406b6c69d15a", new DateTime(2022, 5, 28, 9, 27, 30, 935, DateTimeKind.Utc).AddTicks(7940), new DateTime(2022, 5, 28, 9, 27, 30, 935, DateTimeKind.Utc).AddTicks(7942), "AQAAAAEAACcQAAAAELMrjMXPHZ4CIVEFT59yRrDIQjZBoWZOfttDwSro2M1gHS6k1sVPzhw2uccxDFdPWQ==", new DateTime(2022, 5, 28, 9, 27, 30, 935, DateTimeKind.Utc).AddTicks(7941) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2638"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "2201f832-c80a-4a4d-b01c-73a5133989cd", new DateTime(2022, 5, 28, 9, 27, 30, 936, DateTimeKind.Utc).AddTicks(9511), new DateTime(2022, 5, 28, 9, 27, 30, 936, DateTimeKind.Utc).AddTicks(9513), "AQAAAAEAACcQAAAAEI+Lyww5bdR2x0GmWH1+sQgsy/wQ6LOR3HVCdLAqn65hEXtG2y5RZeOHFh1ECgPToQ==", new DateTime(2022, 5, 28, 9, 27, 30, 936, DateTimeKind.Utc).AddTicks(9512) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2639"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "c265b8d0-c817-4f2e-a163-fadd753daaa6", new DateTime(2022, 5, 28, 9, 27, 30, 938, DateTimeKind.Utc).AddTicks(966), new DateTime(2022, 5, 28, 9, 27, 30, 938, DateTimeKind.Utc).AddTicks(968), "AQAAAAEAACcQAAAAELipQx3bqHeokxTVcWfUqgpRDosD5j3EINZtEQSEZ97816uBn+YUM9OIJ/jpf10VFg==", new DateTime(2022, 5, 28, 9, 27, 30, 938, DateTimeKind.Utc).AddTicks(967) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2640"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "eeab3ab3-efee-433a-90ba-69e1471ea812", new DateTime(2022, 5, 28, 9, 27, 30, 939, DateTimeKind.Utc).AddTicks(2532), new DateTime(2022, 5, 28, 9, 27, 30, 939, DateTimeKind.Utc).AddTicks(2534), "AQAAAAEAACcQAAAAECnvJCKZsCbbo8XRWCd1iaw9oyGsl3wJegsRrdyhZcS2pU15uB8Xwn4uNUpXidCciA==", new DateTime(2022, 5, 28, 9, 27, 30, 939, DateTimeKind.Utc).AddTicks(2533) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2641"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "77746e79-9c09-4a32-bfbc-308e5dc713a3", new DateTime(2022, 5, 28, 9, 27, 30, 940, DateTimeKind.Utc).AddTicks(3996), new DateTime(2022, 5, 28, 9, 27, 30, 940, DateTimeKind.Utc).AddTicks(3998), "AQAAAAEAACcQAAAAEHUP/AdsRWHhIzp5aPc6ZlhK0O488+WA1qmgwxwetLwUmqNOUlLmM7LNCdc4c/2pRQ==", new DateTime(2022, 5, 28, 9, 27, 30, 940, DateTimeKind.Utc).AddTicks(3997) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2642"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "7a51b885-3f22-4339-ab60-80cf2418a291", new DateTime(2022, 5, 28, 9, 27, 30, 941, DateTimeKind.Utc).AddTicks(5574), new DateTime(2022, 5, 28, 9, 27, 30, 941, DateTimeKind.Utc).AddTicks(5576), "AQAAAAEAACcQAAAAEDkUK9usjMMeWj3S2o9W405oHK9H4Ml7cq7ghb4evNLJ30LHg1Q3+CFZqWevsmhW4w==", new DateTime(2022, 5, 28, 9, 27, 30, 941, DateTimeKind.Utc).AddTicks(5575) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2643"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "4fe56576-5bbd-4674-9c1a-b74c509ef94a", new DateTime(2022, 5, 28, 9, 27, 30, 942, DateTimeKind.Utc).AddTicks(7066), new DateTime(2022, 5, 28, 9, 27, 30, 942, DateTimeKind.Utc).AddTicks(7067), "AQAAAAEAACcQAAAAEMPgw1wtQpWFpi4zBYMh66MrEKNpMqF08B0zFxF2hyI9knSEZpTgS0d1eLL+wmNAHQ==", new DateTime(2022, 5, 28, 9, 27, 30, 942, DateTimeKind.Utc).AddTicks(7066) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2644"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "454d977f-930d-4848-bcb2-1f0a416dae40", new DateTime(2022, 5, 28, 9, 27, 30, 943, DateTimeKind.Utc).AddTicks(8558), new DateTime(2022, 5, 28, 9, 27, 30, 943, DateTimeKind.Utc).AddTicks(8559), "AQAAAAEAACcQAAAAECappleXQLrLiD/kOqxg7VJqLd/vDGXpLPyCSIIDkEDfk0X4K39mDWfZatXeP9V5mg==", new DateTime(2022, 5, 28, 9, 27, 30, 943, DateTimeKind.Utc).AddTicks(8559) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2645"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "dc007b84-1844-40aa-8935-ed3c7bd098e4", new DateTime(2022, 5, 28, 9, 27, 30, 945, DateTimeKind.Utc).AddTicks(372), new DateTime(2022, 5, 28, 9, 27, 30, 945, DateTimeKind.Utc).AddTicks(378), "AQAAAAEAACcQAAAAEJ7lutw0EdsY6u9JhxDpy2rGMSsMyYne+X4FQVxQTuq9NMg8T3Ir9Hn8DNiFH7BPKg==", new DateTime(2022, 5, 28, 9, 27, 30, 945, DateTimeKind.Utc).AddTicks(377) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2646"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "b7775d4a-21c7-4f1a-b8ae-6ae974431476", new DateTime(2022, 5, 28, 9, 27, 30, 946, DateTimeKind.Utc).AddTicks(1952), new DateTime(2022, 5, 28, 9, 27, 30, 946, DateTimeKind.Utc).AddTicks(1954), "AQAAAAEAACcQAAAAEF9N7kQtsrwDE9p/krsv6CoIdOKN6uewEIhyjr2sUMUZo1ogQtyF9qIyO/rlg8EiGw==", new DateTime(2022, 5, 28, 9, 27, 30, 946, DateTimeKind.Utc).AddTicks(1953) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2647"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "e79f3af4-9d9a-421d-b86d-ebcd0e73889a", new DateTime(2022, 5, 28, 9, 27, 30, 947, DateTimeKind.Utc).AddTicks(3342), new DateTime(2022, 5, 28, 9, 27, 30, 947, DateTimeKind.Utc).AddTicks(3343), "AQAAAAEAACcQAAAAEEvxpekf/cbK7i4P+xDU0ewcpLeEmubSs4PzuDQltls7Z1bm0LuuQoAuTt2x67zp/Q==", new DateTime(2022, 5, 28, 9, 27, 30, 947, DateTimeKind.Utc).AddTicks(3343) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2648"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "62cc9089-f939-4c9c-a4ec-9ac4ade5106b", new DateTime(2022, 5, 28, 9, 27, 30, 948, DateTimeKind.Utc).AddTicks(4971), new DateTime(2022, 5, 28, 9, 27, 30, 948, DateTimeKind.Utc).AddTicks(4972), "AQAAAAEAACcQAAAAED51dDj4upJBughIqFy9LtnJcVr/aqqNm5OXbP7bnL8sXI+8ERDIPAI8pqaEZb83uQ==", new DateTime(2022, 5, 28, 9, 27, 30, 948, DateTimeKind.Utc).AddTicks(4972) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2649"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "125a2f4b-71e0-4b42-a671-d8d31a9ff586", new DateTime(2022, 5, 28, 9, 27, 30, 949, DateTimeKind.Utc).AddTicks(6599), new DateTime(2022, 5, 28, 9, 27, 30, 949, DateTimeKind.Utc).AddTicks(6600), "AQAAAAEAACcQAAAAEKQ9PRgYhx4Ega5iUxHn1h80mMb1ANjqL1KA/O/eX5OzMS9K0vie5F0GH9TGAl91pA==", new DateTime(2022, 5, 28, 9, 27, 30, 949, DateTimeKind.Utc).AddTicks(6599) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae2650"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "86a2f14a-53f4-40fd-9202-4bcec3e55483", new DateTime(2022, 5, 28, 9, 27, 30, 950, DateTimeKind.Utc).AddTicks(8234), new DateTime(2022, 5, 28, 9, 27, 30, 950, DateTimeKind.Utc).AddTicks(8236), "AQAAAAEAACcQAAAAEIyma6NobNLEzS2hABSx3ZRob8w/0Men3on66XAKfpxdQRNRDYyLAk2GrHuxbsTtWg==", new DateTime(2022, 5, 28, 9, 27, 30, 950, DateTimeKind.Utc).AddTicks(8235) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3351"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "a4b96797-b40b-46d5-9650-fe371be779cf", new DateTime(2022, 5, 28, 9, 27, 30, 951, DateTimeKind.Utc).AddTicks(9737), new DateTime(2022, 5, 28, 9, 27, 30, 951, DateTimeKind.Utc).AddTicks(9740), "AQAAAAEAACcQAAAAEEifsi+z486zVgd2TWseai/KjtvMBzk8Nyg547oyit0IRKCIO/wjVQa1wVmUonZTcw==", new DateTime(2022, 5, 28, 9, 27, 30, 951, DateTimeKind.Utc).AddTicks(9738) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3352"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "cca92891-c361-4caa-8778-1677a7f9e0ef", new DateTime(2022, 5, 28, 9, 27, 30, 953, DateTimeKind.Utc).AddTicks(1447), new DateTime(2022, 5, 28, 9, 27, 30, 953, DateTimeKind.Utc).AddTicks(1449), "AQAAAAEAACcQAAAAELdvsjGCuB6gDZfn9+JZ96AEuPsypiv9JwYAgULUwqizZiC848lUAbNfsUXKW+lWuQ==", new DateTime(2022, 5, 28, 9, 27, 30, 953, DateTimeKind.Utc).AddTicks(1448) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3353"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "3056d0ef-c631-4d46-a885-c6f2d01a6309", new DateTime(2022, 5, 28, 9, 27, 30, 954, DateTimeKind.Utc).AddTicks(3073), new DateTime(2022, 5, 28, 9, 27, 30, 954, DateTimeKind.Utc).AddTicks(3074), "AQAAAAEAACcQAAAAEBaB7hP9eHIDZONn7qyQXi5r2cK8vvEJZGqXlGgoXVRRHP4oqj9dT0OLkfqF65nErw==", new DateTime(2022, 5, 28, 9, 27, 30, 954, DateTimeKind.Utc).AddTicks(3074) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3354"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "044f30a9-72a8-48ea-b27d-9246208b8637", new DateTime(2022, 5, 28, 9, 27, 30, 955, DateTimeKind.Utc).AddTicks(4584), new DateTime(2022, 5, 28, 9, 27, 30, 955, DateTimeKind.Utc).AddTicks(4586), "AQAAAAEAACcQAAAAEJMyUuIJzd2DmN2dH0+cxxiEOa84+fp96R5/yKALQr93ctQF2EmKeilLgzIhwQedHA==", new DateTime(2022, 5, 28, 9, 27, 30, 955, DateTimeKind.Utc).AddTicks(4585) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3355"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "2bba70cd-c78e-433f-a178-27f83f7cd69c", new DateTime(2022, 5, 28, 9, 27, 30, 956, DateTimeKind.Utc).AddTicks(6113), new DateTime(2022, 5, 28, 9, 27, 30, 956, DateTimeKind.Utc).AddTicks(6114), "AQAAAAEAACcQAAAAELuUItM81GaCljeP6Dm+oK0o0RfPaMSMItDpyqBnpO4t7XvSGu/wpYp/dPG84irjHw==", new DateTime(2022, 5, 28, 9, 27, 30, 956, DateTimeKind.Utc).AddTicks(6113) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3356"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "21215033-2cf8-448f-8989-a82d725aa5c5", new DateTime(2022, 5, 28, 9, 27, 30, 957, DateTimeKind.Utc).AddTicks(7583), new DateTime(2022, 5, 28, 9, 27, 30, 957, DateTimeKind.Utc).AddTicks(7585), "AQAAAAEAACcQAAAAEIaBTM7ruC6/GqDLQ+E9a1cUKHQWAHArrCF/ZL0oVNiYklSNC+AUIeaLfmi4wWHJUg==", new DateTime(2022, 5, 28, 9, 27, 30, 957, DateTimeKind.Utc).AddTicks(7584) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3357"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "9cea183b-8d86-456e-958e-3d5cde9ad33c", new DateTime(2022, 5, 28, 9, 27, 30, 958, DateTimeKind.Utc).AddTicks(9080), new DateTime(2022, 5, 28, 9, 27, 30, 958, DateTimeKind.Utc).AddTicks(9081), "AQAAAAEAACcQAAAAEAPtkDGS4136e6H2PCpyHg2KXJtHAdY/vUdvV32El42ussb4xqKI9OU/QK5y1tqmDQ==", new DateTime(2022, 5, 28, 9, 27, 30, 958, DateTimeKind.Utc).AddTicks(9081) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3358"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "5e00d30f-5ed5-4879-b860-815949d21202", new DateTime(2022, 5, 28, 9, 27, 30, 960, DateTimeKind.Utc).AddTicks(1300), new DateTime(2022, 5, 28, 9, 27, 30, 960, DateTimeKind.Utc).AddTicks(1307), "AQAAAAEAACcQAAAAEHUHmxqX4Rpzs4S03dYsCKYNCVt12pTHf1vq2yKHoySAYA/WxDJufLl7IJym2Poo5A==", new DateTime(2022, 5, 28, 9, 27, 30, 960, DateTimeKind.Utc).AddTicks(1306) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3359"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "b37c5a4e-7285-4ee6-bf3a-b461e5f8c2cc", new DateTime(2022, 5, 28, 9, 27, 30, 961, DateTimeKind.Utc).AddTicks(2884), new DateTime(2022, 5, 28, 9, 27, 30, 961, DateTimeKind.Utc).AddTicks(2886), "AQAAAAEAACcQAAAAEPND1O0cd/kTdieo6eeskULnQn9gyykSrdQx+60ol3UrKWcvWb5aOGRq5gXzwy9mxg==", new DateTime(2022, 5, 28, 9, 27, 30, 961, DateTimeKind.Utc).AddTicks(2886) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3360"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "d3a169fa-98db-466f-bc3b-8a90920e0049", new DateTime(2022, 5, 28, 9, 27, 30, 962, DateTimeKind.Utc).AddTicks(4599), new DateTime(2022, 5, 28, 9, 27, 30, 962, DateTimeKind.Utc).AddTicks(4601), "AQAAAAEAACcQAAAAEGO1T/kTh2vLjuSIKfveL4ylos3l9mI6eLGIGAHOTr/589NjfJnBUgq2i+g8ojZKHg==", new DateTime(2022, 5, 28, 9, 27, 30, 962, DateTimeKind.Utc).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3361"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "077ce937-dea0-4ed1-9f8d-e18a979ba62f", new DateTime(2022, 5, 28, 9, 27, 30, 963, DateTimeKind.Utc).AddTicks(6401), new DateTime(2022, 5, 28, 9, 27, 30, 963, DateTimeKind.Utc).AddTicks(6402), "AQAAAAEAACcQAAAAEF5gZL/2fyzKWtE33YZrIi3kA1lxAxxv+XFey+21mQ6d4yvZhnaFQL6tsR8VkJStBQ==", new DateTime(2022, 5, 28, 9, 27, 30, 963, DateTimeKind.Utc).AddTicks(6401) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3362"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "597e755f-daf6-459e-84dd-8fdf2865857e", new DateTime(2022, 5, 28, 9, 27, 30, 964, DateTimeKind.Utc).AddTicks(7980), new DateTime(2022, 5, 28, 9, 27, 30, 964, DateTimeKind.Utc).AddTicks(7982), "AQAAAAEAACcQAAAAEHIFh51b5dwzdBZgcbZ30LeZPRF4jW6fIEdpoHEtScrx+RO5dYfzDSRarNn6IKF/7w==", new DateTime(2022, 5, 28, 9, 27, 30, 964, DateTimeKind.Utc).AddTicks(7981) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3363"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "6c18ec69-d418-4883-97f5-2d96283d78f0", new DateTime(2022, 5, 28, 9, 27, 30, 966, DateTimeKind.Utc).AddTicks(52), new DateTime(2022, 5, 28, 9, 27, 30, 966, DateTimeKind.Utc).AddTicks(53), "AQAAAAEAACcQAAAAEOAC/g2X3DKnY5ntJ6AH+/LacDzGSGioOfgOkPQcZ5STyVnAwlUvl4UUQGL5I2MpIQ==", new DateTime(2022, 5, 28, 9, 27, 30, 966, DateTimeKind.Utc).AddTicks(52) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3364"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "6a89f538-b96f-4d46-90a6-c02d929422b4", new DateTime(2022, 5, 28, 9, 27, 30, 967, DateTimeKind.Utc).AddTicks(1993), new DateTime(2022, 5, 28, 9, 27, 30, 967, DateTimeKind.Utc).AddTicks(1995), "AQAAAAEAACcQAAAAEH3sZyBrlppHZtUmuYL9b0pKd4ak/dunCIvqambRE76ytt37X+zyIlBq6+/ZYWFmvw==", new DateTime(2022, 5, 28, 9, 27, 30, 967, DateTimeKind.Utc).AddTicks(1994) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3365"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "bad9ac0a-cdd1-4135-b059-5bf26470b562", new DateTime(2022, 5, 28, 9, 27, 30, 968, DateTimeKind.Utc).AddTicks(3911), new DateTime(2022, 5, 28, 9, 27, 30, 968, DateTimeKind.Utc).AddTicks(3913), "AQAAAAEAACcQAAAAENXImdcpqI9j2iw1KLzYnGFFXyVaMxLLruUiV6NXnBb/GYl91BGXm3eZOqUuTPEyrg==", new DateTime(2022, 5, 28, 9, 27, 30, 968, DateTimeKind.Utc).AddTicks(3912) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3366"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "69c50186-cb1b-4697-8ebb-8301aa725840", new DateTime(2022, 5, 28, 9, 27, 30, 969, DateTimeKind.Utc).AddTicks(5825), new DateTime(2022, 5, 28, 9, 27, 30, 969, DateTimeKind.Utc).AddTicks(5827), "AQAAAAEAACcQAAAAELR9JVxg8Kgzl99rMPs/oedBiaghO8+1X7VBmYnQsiAP5HgIKnGjpuUA+eCgC9CdQg==", new DateTime(2022, 5, 28, 9, 27, 30, 969, DateTimeKind.Utc).AddTicks(5826) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3367"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "889a25e0-73e4-4912-ae5c-7eb379264d93", new DateTime(2022, 5, 28, 9, 27, 30, 970, DateTimeKind.Utc).AddTicks(7534), new DateTime(2022, 5, 28, 9, 27, 30, 970, DateTimeKind.Utc).AddTicks(7536), "AQAAAAEAACcQAAAAEL4jEZRdnzIcd6HnXEGXDM8IfYk+fMzdnK2Tef+gJqNr+wkL67WBXhT0cDxl0vYu/g==", new DateTime(2022, 5, 28, 9, 27, 30, 970, DateTimeKind.Utc).AddTicks(7535) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3368"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "4b3c83bc-79ae-43ca-8d32-c746289aca78", new DateTime(2022, 5, 28, 9, 27, 30, 971, DateTimeKind.Utc).AddTicks(9361), new DateTime(2022, 5, 28, 9, 27, 30, 971, DateTimeKind.Utc).AddTicks(9363), "AQAAAAEAACcQAAAAEJP5BVCxgVUCm8lC0ur9w37PMNt1oMEk3cOLEKbPu6pLd9JwauvpV1eM3kJxtJ6slQ==", new DateTime(2022, 5, 28, 9, 27, 30, 971, DateTimeKind.Utc).AddTicks(9362) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3369"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "e4c8363c-5005-4d86-8e71-c66f539fa5a2", new DateTime(2022, 5, 28, 9, 27, 30, 973, DateTimeKind.Utc).AddTicks(1680), new DateTime(2022, 5, 28, 9, 27, 30, 973, DateTimeKind.Utc).AddTicks(1682), "AQAAAAEAACcQAAAAEKFRMwSY4ypvV2c0jcjkdnkWbFz95MzZHFIwmfXrsmOYSZA3zBY2XZh2vcl4QPp0YA==", new DateTime(2022, 5, 28, 9, 27, 30, 973, DateTimeKind.Utc).AddTicks(1681) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3370"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "20b5f563-6732-4736-9769-dc26c3213a7f", new DateTime(2022, 5, 28, 9, 27, 30, 974, DateTimeKind.Utc).AddTicks(3665), new DateTime(2022, 5, 28, 9, 27, 30, 974, DateTimeKind.Utc).AddTicks(3667), "AQAAAAEAACcQAAAAEGP0VYWaBBAwb4RfcrHmCQWHNqODAUz1vWiZRnxH0LfCPgN1OV9SeezlfRt5p72hmQ==", new DateTime(2022, 5, 28, 9, 27, 30, 974, DateTimeKind.Utc).AddTicks(3666) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5a918c6-5ed4-43eb-bcdf-042594ae3371"),
                columns: new[] { "ConcurrencyStamp", "Created_at", "Deleted_at", "PasswordHash", "Updated_at" },
                values: new object[] { "530df487-b347-4577-853b-b348f19dcbf9", new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(5925), new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(5928), "AQAAAAEAACcQAAAAECBMt0wnVieMd/Oq4Ym/tECe8pKLHc9cjPkd7mqO0bF2x4eX7BMRkurkyKkdM9DmJA==", new DateTime(2022, 5, 28, 9, 27, 30, 975, DateTimeKind.Utc).AddTicks(5927) });
        }
    }
}
