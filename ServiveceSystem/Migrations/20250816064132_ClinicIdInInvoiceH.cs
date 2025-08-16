using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceSystem.Migrations
{
    /// <inheritdoc />
    public partial class ClinicIdInInvoiceH : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClinicId",
                table: "invoiceHeaders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClinicId",
                table: "invoiceHeaders");
        }
    }
}
