using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceSystem.Migrations
{
    /// <inheritdoc />
    public partial class status_in_invoice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "invoiceHeaders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "invoiceHeaders");
        }
    }
}
