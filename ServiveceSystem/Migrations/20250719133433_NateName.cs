using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceSystem.Migrations
{
    /// <inheritdoc />
    public partial class NateName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "QuotationNaMe",
                table: "QuotationHeaders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "invoiceHeaders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuotationNaMe",
                table: "QuotationHeaders");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "invoiceHeaders");
        }
    }
}
