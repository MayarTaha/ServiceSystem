using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceSystem.Migrations
{
    /// <inheritdoc />
    public partial class updata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalDuo",
                table: "InvoiceDetails");

            migrationBuilder.AddColumn<decimal>(
                name: "Discount",
                table: "invoiceHeaders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "DiscountType",
                table: "invoiceHeaders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "invoiceHeaders");

            migrationBuilder.DropColumn(
                name: "DiscountType",
                table: "invoiceHeaders");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalDuo",
                table: "InvoiceDetails",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
