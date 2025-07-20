using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceSystem.Migrations
{
    /// <inheritdoc />
    public partial class relation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clinics",
                columns: table => new
                {
                    ClinicId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClinicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedLog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedLog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedLog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinics", x => x.ClinicId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    PaymentMethodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.PaymentMethodId);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServicePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedLog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedLog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedLog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Permission = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedLog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedLog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedLog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "ContactPersons",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClinicId = table.Column<int>(type: "int", nullable: false),
                    CreatedLog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedLog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedLog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactPersons", x => x.ContactId);
                    table.ForeignKey(
                        name: "FK_ContactPersons_Clinics_ClinicId",
                        column: x => x.ClinicId,
                        principalTable: "Clinics",
                        principalColumn: "ClinicId");
                });

            migrationBuilder.CreateTable(
                name: "QuotationHeaders",
                columns: table => new
                {
                    QuotationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClinicId = table.Column<int>(type: "int", nullable: false),
                    InitialDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    priority = table.Column<int>(type: "int", nullable: false),
                    DiscountType = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalDuo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ContactId = table.Column<int>(type: "int", nullable: false),
                    CreatedLog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedLog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedLog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuotationHeaders", x => x.QuotationId);
                    table.ForeignKey(
                        name: "FK_QuotationHeaders_Clinics_ClinicId",
                        column: x => x.ClinicId,
                        principalTable: "Clinics",
                        principalColumn: "ClinicId");
                    table.ForeignKey(
                        name: "FK_QuotationHeaders_ContactPersons_ContactId",
                        column: x => x.ContactId,
                        principalTable: "ContactPersons",
                        principalColumn: "ContactId");
                });

            migrationBuilder.CreateTable(
                name: "invoiceHeaders",
                columns: table => new
                {
                    InvoiceHeaderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuotationId = table.Column<int>(type: "int", nullable: false),
                    InvoiceDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Payment = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentMethodId = table.Column<int>(type: "int", nullable: false),
                    Reminder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactId = table.Column<int>(type: "int", nullable: false),
                    CreatedLog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedLog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedLog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_invoiceHeaders", x => x.InvoiceHeaderId);
                    table.ForeignKey(
                        name: "FK_invoiceHeaders_ContactPersons_ContactId",
                        column: x => x.ContactId,
                        principalTable: "ContactPersons",
                        principalColumn: "ContactId");
                    table.ForeignKey(
                        name: "FK_invoiceHeaders_PaymentMethods_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalTable: "PaymentMethods",
                        principalColumn: "PaymentMethodId");
                    table.ForeignKey(
                        name: "FK_invoiceHeaders_QuotationHeaders_QuotationId",
                        column: x => x.QuotationId,
                        principalTable: "QuotationHeaders",
                        principalColumn: "QuotationId");
                });

            migrationBuilder.CreateTable(
                name: "QuotationDetails",
                columns: table => new
                {
                    QuotationDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuotationId = table.Column<int>(type: "int", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    DiscountType = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ServicePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalService = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedLog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedLog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedLog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuotationDetails", x => x.QuotationDetailId);
                    table.ForeignKey(
                        name: "FK_QuotationDetails_QuotationHeaders_QuotationId",
                        column: x => x.QuotationId,
                        principalTable: "QuotationHeaders",
                        principalColumn: "QuotationId");
                    table.ForeignKey(
                        name: "FK_QuotationDetails_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceDetails",
                columns: table => new
                {
                    InvoiceDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceHeaderId = table.Column<int>(type: "int", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    QuotationId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountType = table.Column<int>(type: "int", nullable: false),
                    ServicePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalService = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalDuo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedLog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedLog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedLog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceDetails", x => x.InvoiceDetailId);
                    table.ForeignKey(
                        name: "FK_InvoiceDetails_QuotationHeaders_QuotationId",
                        column: x => x.QuotationId,
                        principalTable: "QuotationHeaders",
                        principalColumn: "QuotationId");
                    table.ForeignKey(
                        name: "FK_InvoiceDetails_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "ServiceId");
                    table.ForeignKey(
                        name: "FK_InvoiceDetails_invoiceHeaders_InvoiceHeaderId",
                        column: x => x.InvoiceHeaderId,
                        principalTable: "invoiceHeaders",
                        principalColumn: "InvoiceHeaderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "payments",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceId = table.Column<int>(type: "int", nullable: false),
                    AmountPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RemainingAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentMethodId = table.Column<int>(type: "int", nullable: false),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false),
                    CreatedLog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedLog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedLog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payments", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_payments_PaymentMethods_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalTable: "PaymentMethods",
                        principalColumn: "PaymentMethodId");
                    table.ForeignKey(
                        name: "FK_payments_invoiceHeaders_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "invoiceHeaders",
                        principalColumn: "InvoiceHeaderId");
                });

            migrationBuilder.CreateTable(
                name: "Taxeses",
                columns: table => new
                {
                    TaxesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedLog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedLog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedLog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    InvoiceHeaderId = table.Column<int>(type: "int", nullable: true),
                    QuotationHeaderQuotationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taxeses", x => x.TaxesID);
                    table.ForeignKey(
                        name: "FK_Taxeses_QuotationHeaders_QuotationHeaderQuotationId",
                        column: x => x.QuotationHeaderQuotationId,
                        principalTable: "QuotationHeaders",
                        principalColumn: "QuotationId");
                    table.ForeignKey(
                        name: "FK_Taxeses_invoiceHeaders_InvoiceHeaderId",
                        column: x => x.InvoiceHeaderId,
                        principalTable: "invoiceHeaders",
                        principalColumn: "InvoiceHeaderId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactPersons_ClinicId",
                table: "ContactPersons",
                column: "ClinicId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDetails_InvoiceHeaderId",
                table: "InvoiceDetails",
                column: "InvoiceHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDetails_QuotationId",
                table: "InvoiceDetails",
                column: "QuotationId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDetails_ServiceId",
                table: "InvoiceDetails",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_invoiceHeaders_ContactId",
                table: "invoiceHeaders",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_invoiceHeaders_PaymentMethodId",
                table: "invoiceHeaders",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_invoiceHeaders_QuotationId",
                table: "invoiceHeaders",
                column: "QuotationId");

            migrationBuilder.CreateIndex(
                name: "IX_payments_InvoiceId",
                table: "payments",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_payments_PaymentMethodId",
                table: "payments",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_QuotationDetails_QuotationId",
                table: "QuotationDetails",
                column: "QuotationId");

            migrationBuilder.CreateIndex(
                name: "IX_QuotationDetails_ServiceId",
                table: "QuotationDetails",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_QuotationHeaders_ClinicId",
                table: "QuotationHeaders",
                column: "ClinicId");

            migrationBuilder.CreateIndex(
                name: "IX_QuotationHeaders_ContactId",
                table: "QuotationHeaders",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Taxeses_InvoiceHeaderId",
                table: "Taxeses",
                column: "InvoiceHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_Taxeses_QuotationHeaderQuotationId",
                table: "Taxeses",
                column: "QuotationHeaderQuotationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvoiceDetails");

            migrationBuilder.DropTable(
                name: "payments");

            migrationBuilder.DropTable(
                name: "QuotationDetails");

            migrationBuilder.DropTable(
                name: "Taxeses");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "invoiceHeaders");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "QuotationHeaders");

            migrationBuilder.DropTable(
                name: "ContactPersons");

            migrationBuilder.DropTable(
                name: "Clinics");
        }
    }
}
