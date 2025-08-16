using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceSystem.Migrations
{
    /// <inheritdoc />
    public partial class ClinicIdInInvoiceHeader : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_invoiceHeaders_ClinicId",
                table: "invoiceHeaders",
                column: "ClinicId");

            migrationBuilder.AddForeignKey(
                name: "FK_invoiceHeaders_Clinics_ClinicId",
                table: "invoiceHeaders",
                column: "ClinicId",
                principalTable: "Clinics",
                principalColumn: "ClinicId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_invoiceHeaders_Clinics_ClinicId",
                table: "invoiceHeaders");

            migrationBuilder.DropIndex(
                name: "IX_invoiceHeaders_ClinicId",
                table: "invoiceHeaders");
        }
    }
}
