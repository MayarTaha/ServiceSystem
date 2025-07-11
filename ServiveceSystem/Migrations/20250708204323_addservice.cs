using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiveceSystem.Migrations
{
    /// <inheritdoc />
    public partial class addservice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDetails_services_ServiceId",
                table: "InvoiceDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_services",
                table: "services");

            migrationBuilder.RenameTable(
                name: "services",
                newName: "Services");

            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "QuotationDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Services",
                table: "Services",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_QuotationDetails_ServiceId",
                table: "QuotationDetails",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDetails_Services_ServiceId",
                table: "InvoiceDetails",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "ServiceId");

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
                name: "FK_InvoiceDetails_Services_ServiceId",
                table: "InvoiceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_QuotationDetails_Services_ServiceId",
                table: "QuotationDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Services",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_QuotationDetails_ServiceId",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "QuotationDetails");

            migrationBuilder.RenameTable(
                name: "Services",
                newName: "services");

            migrationBuilder.AddPrimaryKey(
                name: "PK_services",
                table: "services",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDetails_services_ServiceId",
                table: "InvoiceDetails",
                column: "ServiceId",
                principalTable: "services",
                principalColumn: "ServiceId");
        }
    }
}
