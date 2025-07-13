using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiveceSystem.Migrations
{
    /// <inheritdoc />
    public partial class updateContact : Migration
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

            migrationBuilder.AddColumn<string>(
                name: "CreatedLog",
                table: "ContactPersons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DeletedLog",
                table: "ContactPersons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedLog",
                table: "ContactPersons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "ContactPersons",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Services",
                table: "Services",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDetails_Services_ServiceId",
                table: "InvoiceDetails",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "ServiceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDetails_Services_ServiceId",
                table: "InvoiceDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Services",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "CreatedLog",
                table: "ContactPersons");

            migrationBuilder.DropColumn(
                name: "DeletedLog",
                table: "ContactPersons");

            migrationBuilder.DropColumn(
                name: "UpdatedLog",
                table: "ContactPersons");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "ContactPersons");

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
