using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceSystem.Migrations
{
    /// <inheritdoc />
    public partial class SalesManModell : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_invoiceHeaders_SalesMan_SalesManId",
                table: "invoiceHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_QuotationHeaders_SalesMan_SalesManId",
                table: "QuotationHeaders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesMan",
                table: "SalesMan");

            migrationBuilder.RenameTable(
                name: "SalesMan",
                newName: "SalesMen");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesMen",
                table: "SalesMen",
                column: "SalesManId");

            migrationBuilder.AddForeignKey(
                name: "FK_invoiceHeaders_SalesMen_SalesManId",
                table: "invoiceHeaders",
                column: "SalesManId",
                principalTable: "SalesMen",
                principalColumn: "SalesManId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuotationHeaders_SalesMen_SalesManId",
                table: "QuotationHeaders",
                column: "SalesManId",
                principalTable: "SalesMen",
                principalColumn: "SalesManId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_invoiceHeaders_SalesMen_SalesManId",
                table: "invoiceHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_QuotationHeaders_SalesMen_SalesManId",
                table: "QuotationHeaders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesMen",
                table: "SalesMen");

            migrationBuilder.RenameTable(
                name: "SalesMen",
                newName: "SalesMan");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesMan",
                table: "SalesMan",
                column: "SalesManId");

            migrationBuilder.AddForeignKey(
                name: "FK_invoiceHeaders_SalesMan_SalesManId",
                table: "invoiceHeaders",
                column: "SalesManId",
                principalTable: "SalesMan",
                principalColumn: "SalesManId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuotationHeaders_SalesMan_SalesManId",
                table: "QuotationHeaders",
                column: "SalesManId",
                principalTable: "SalesMan",
                principalColumn: "SalesManId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
