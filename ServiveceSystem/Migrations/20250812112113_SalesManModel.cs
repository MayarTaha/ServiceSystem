using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceSystem.Migrations
{
    /// <inheritdoc />
    public partial class SalesManModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SalesManId",
                table: "QuotationHeaders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SalesManId",
                table: "invoiceHeaders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SalesMan",
                columns: table => new
                {
                    SalesManId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesManName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesMan", x => x.SalesManId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuotationHeaders_SalesManId",
                table: "QuotationHeaders",
                column: "SalesManId");

            migrationBuilder.CreateIndex(
                name: "IX_invoiceHeaders_SalesManId",
                table: "invoiceHeaders",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_invoiceHeaders_SalesMan_SalesManId",
                table: "invoiceHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_QuotationHeaders_SalesMan_SalesManId",
                table: "QuotationHeaders");

            migrationBuilder.DropTable(
                name: "SalesMan");

            migrationBuilder.DropIndex(
                name: "IX_QuotationHeaders_SalesManId",
                table: "QuotationHeaders");

            migrationBuilder.DropIndex(
                name: "IX_invoiceHeaders_SalesManId",
                table: "invoiceHeaders");

            migrationBuilder.DropColumn(
                name: "SalesManId",
                table: "QuotationHeaders");

            migrationBuilder.DropColumn(
                name: "SalesManId",
                table: "invoiceHeaders");
        }
    }
}
