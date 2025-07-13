using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiveceSystem.Migrations
{
    /// <inheritdoc />
    public partial class updateQuotation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "QuotationDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_QuotationDetails_ServiceId",
                table: "QuotationDetails",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuotationDetails_Services_ServiceId",
                table: "QuotationDetails",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "ServiceId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuotationDetails_Services_ServiceId",
                table: "QuotationDetails");

            migrationBuilder.DropIndex(
                name: "IX_QuotationDetails_ServiceId",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "QuotationDetails");
        }
    }
}
