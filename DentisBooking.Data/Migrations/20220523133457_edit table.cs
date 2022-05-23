using Microsoft.EntityFrameworkCore.Migrations;

namespace DentisBooking.Data.Migrations
{
    public partial class edittable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Details_Service_ServiceId",
                table: "Booking_Details");

            migrationBuilder.DropForeignKey(
                name: "FK_Dentist_Clinic_ClinicId",
                table: "Dentist");

            migrationBuilder.DropForeignKey(
                name: "FK_Service_Discount_DiscountId",
                table: "Service");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceDentists_Dentist_DentistId",
                table: "ServiceDentists");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceDentists_Service_ServiceId",
                table: "ServiceDentists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Service",
                table: "Service");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Role",
                table: "Role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Discount",
                table: "Discount");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dentist",
                table: "Dentist");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clinic",
                table: "Clinic");

            migrationBuilder.RenameTable(
                name: "Service",
                newName: "Services");

            migrationBuilder.RenameTable(
                name: "Role",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "Discount",
                newName: "Discounts");

            migrationBuilder.RenameTable(
                name: "Dentist",
                newName: "Dentists");

            migrationBuilder.RenameTable(
                name: "Clinic",
                newName: "Clinics");

            migrationBuilder.RenameIndex(
                name: "IX_Service_DiscountId",
                table: "Services",
                newName: "IX_Services_DiscountId");

            migrationBuilder.RenameIndex(
                name: "IX_Dentist_ClinicId",
                table: "Dentists",
                newName: "IX_Dentists_ClinicId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Services",
                table: "Services",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Discounts",
                table: "Discounts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dentists",
                table: "Dentists",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clinics",
                table: "Clinics",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Details_Services_ServiceId",
                table: "Booking_Details",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dentists_Clinics_ClinicId",
                table: "Dentists",
                column: "ClinicId",
                principalTable: "Clinics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceDentists_Dentists_DentistId",
                table: "ServiceDentists",
                column: "DentistId",
                principalTable: "Dentists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceDentists_Services_ServiceId",
                table: "ServiceDentists",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Discounts_DiscountId",
                table: "Services",
                column: "DiscountId",
                principalTable: "Discounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Details_Services_ServiceId",
                table: "Booking_Details");

            migrationBuilder.DropForeignKey(
                name: "FK_Dentists_Clinics_ClinicId",
                table: "Dentists");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceDentists_Dentists_DentistId",
                table: "ServiceDentists");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceDentists_Services_ServiceId",
                table: "ServiceDentists");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_Discounts_DiscountId",
                table: "Services");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Services",
                table: "Services");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Discounts",
                table: "Discounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dentists",
                table: "Dentists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clinics",
                table: "Clinics");

            migrationBuilder.RenameTable(
                name: "Services",
                newName: "Service");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "Role");

            migrationBuilder.RenameTable(
                name: "Discounts",
                newName: "Discount");

            migrationBuilder.RenameTable(
                name: "Dentists",
                newName: "Dentist");

            migrationBuilder.RenameTable(
                name: "Clinics",
                newName: "Clinic");

            migrationBuilder.RenameIndex(
                name: "IX_Services_DiscountId",
                table: "Service",
                newName: "IX_Service_DiscountId");

            migrationBuilder.RenameIndex(
                name: "IX_Dentists_ClinicId",
                table: "Dentist",
                newName: "IX_Dentist_ClinicId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Service",
                table: "Service",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Role",
                table: "Role",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Discount",
                table: "Discount",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dentist",
                table: "Dentist",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clinic",
                table: "Clinic",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Details_Service_ServiceId",
                table: "Booking_Details",
                column: "ServiceId",
                principalTable: "Service",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dentist_Clinic_ClinicId",
                table: "Dentist",
                column: "ClinicId",
                principalTable: "Clinic",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Service_Discount_DiscountId",
                table: "Service",
                column: "DiscountId",
                principalTable: "Discount",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceDentists_Dentist_DentistId",
                table: "ServiceDentists",
                column: "DentistId",
                principalTable: "Dentist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceDentists_Service_ServiceId",
                table: "ServiceDentists",
                column: "ServiceId",
                principalTable: "Service",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
