namespace ServiceSystem.PresentationLayer.Reports
{
    partial class QuotationReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            
            // Create report controls
            this.xrLabelTitle = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelCompanyName = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelCompanySlogan = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelQuotationTo = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelContactName = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelContactEmail = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelContactPhone = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelContactAddress = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelTotalDue = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelTotalAmount = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelQuotationNo = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelQuotationDate = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelQuotationNoValue = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelQuotationDateValue = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelContactNameValue = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelContactEmailValue = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelContactPhoneValue = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelContactAddressValue = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelTotalAmountValue = new DevExpress.XtraReports.UI.XRLabel();
            
            // Products table
            this.xrTableProducts = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRowHeader = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCellProducts = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellQty = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellPrice = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellTotal = new DevExpress.XtraReports.UI.XRTableCell();
            
            // Detail table
            this.xrTableDetail = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRowDetail = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCellServiceName = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellQuantity = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellServicePrice = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellTotalService = new DevExpress.XtraReports.UI.XRTableCell();
            
            // Summary
            this.xrLabelSubTotal = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelSubTotalValue = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelTax = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelTaxValue = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelTotal = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelTotalValue = new DevExpress.XtraReports.UI.XRLabel();
            
            // Payment method
            this.xrLabelPaymentMethod = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelBankName = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelBankAccount = new DevExpress.XtraReports.UI.XRLabel();
            
            // Footer
            this.xrLabelThankYou = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelSignature = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelAdministrator = new DevExpress.XtraReports.UI.XRLabel();
            
            // TopMargin
            this.TopMargin.HeightF = 20F;
            this.TopMargin.Name = "TopMargin";
            
            // BottomMargin
            this.BottomMargin.HeightF = 20F;
            this.BottomMargin.Name = "BottomMargin";
            
            // Detail
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            
            // ReportHeader
            this.ReportHeader.HeightF = 320F;
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
                this.xrLabelTitle, this.xrLabelCompanyName, this.xrLabelCompanySlogan,
                this.xrLabelQuotationTo, this.xrLabelContactName, this.xrLabelContactEmail,
                this.xrLabelContactPhone, this.xrLabelContactAddress, this.xrLabelTotalDue,
                this.xrLabelTotalAmount, this.xrLabelQuotationNo, this.xrLabelQuotationDate,
                this.xrLabelQuotationNoValue, this.xrLabelQuotationDateValue,
                this.xrLabelContactNameValue, this.xrLabelContactEmailValue,
                this.xrLabelContactPhoneValue, this.xrLabelContactAddressValue,
                this.xrLabelTotalAmountValue, this.xrTableProducts});
            
            // DetailReport
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
                this.Detail1});
            this.DetailReport.DataMember = "QuotationHeader.QuotationDetail";
            this.DetailReport.DataSource = this.DataSource;
            this.DetailReport.HeightF = 25F;
            this.DetailReport.Name = "DetailReport";
            
            // Detail1
            this.Detail1.HeightF = 25F;
            this.Detail1.Name = "Detail1";
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
                this.xrTableDetail});
            
            // ReportFooter
            this.ReportFooter.HeightF = 150F;
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
                this.xrLabelSubTotal, this.xrLabelSubTotalValue, this.xrLabelTax,
                this.xrLabelTaxValue, this.xrLabelTotal, this.xrLabelTotalValue,
                this.xrLabelPaymentMethod, this.xrLabelBankName, this.xrLabelBankAccount,
                this.xrLabelThankYou, this.xrLabelSignature, this.xrLabelAdministrator});
            
            // Configure controls
            ConfigureReportControls();
            
            // QuotationReport
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
                this.TopMargin,
                this.ReportHeader,
                this.Detail,
                this.DetailReport,
                this.ReportFooter,
                this.BottomMargin});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(50, 50, 20, 20);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4;
            this.Version = "22.2";
        }

        private void ConfigureReportControls()
        {
            // Title
            this.xrLabelTitle.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold);
            this.xrLabelTitle.LocationFloat = new DevExpress.Utils.PointFloat(250F, 20F);
            this.xrLabelTitle.SizeF = new System.Drawing.SizeF(300F, 50F);
            this.xrLabelTitle.Text = "QUOTATION";
            this.xrLabelTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            
            // Company name
            this.xrLabelCompanyName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.xrLabelCompanyName.LocationFloat = new DevExpress.Utils.PointFloat(250F, 80F);
            this.xrLabelCompanyName.SizeF = new System.Drawing.SizeF(300F, 30F);
            this.xrLabelCompanyName.Text = "Really Great Company";
            this.xrLabelCompanyName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            
            // Company slogan
            this.xrLabelCompanySlogan.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic);
            this.xrLabelCompanySlogan.LocationFloat = new DevExpress.Utils.PointFloat(250F, 110F);
            this.xrLabelCompanySlogan.SizeF = new System.Drawing.SizeF(300F, 25F);
            this.xrLabelCompanySlogan.Text = "Your Business Partner";
            this.xrLabelCompanySlogan.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            
            // Quotation To
            this.xrLabelQuotationTo.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.xrLabelQuotationTo.LocationFloat = new DevExpress.Utils.PointFloat(50F, 160F);
            this.xrLabelQuotationTo.SizeF = new System.Drawing.SizeF(150F, 25F);
            this.xrLabelQuotationTo.Text = "QUOTATION TO:";
            
            // Contact name
            this.xrLabelContactName.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.xrLabelContactName.LocationFloat = new DevExpress.Utils.PointFloat(50F, 190F);
            this.xrLabelContactName.SizeF = new System.Drawing.SizeF(250F, 30F);
            this.xrLabelContactName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                new DevExpress.XtraReports.UI.XRBinding("Text", null, "QuotationHeader.ContactName")});
            
            // Contact details
            this.xrLabelContactEmail.Font = new System.Drawing.Font("Arial", 12F);
            this.xrLabelContactEmail.LocationFloat = new DevExpress.Utils.PointFloat(50F, 225F);
            this.xrLabelContactEmail.SizeF = new System.Drawing.SizeF(250F, 25F);
            this.xrLabelContactEmail.Text = "E: ";
            this.xrLabelContactEmail.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                new DevExpress.XtraReports.UI.XRBinding("Text", null, "QuotationHeader.ContactEmail", "E: {0}")});
            
            this.xrLabelContactPhone.Font = new System.Drawing.Font("Arial", 12F);
            this.xrLabelContactPhone.LocationFloat = new DevExpress.Utils.PointFloat(50F, 250F);
            this.xrLabelContactPhone.SizeF = new System.Drawing.SizeF(250F, 25F);
            this.xrLabelContactPhone.Text = "P: ";
            this.xrLabelContactPhone.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                new DevExpress.XtraReports.UI.XRBinding("Text", null, "QuotationHeader.ContactPhone", "P: {0}")});
            
            this.xrLabelContactAddress.Font = new System.Drawing.Font("Arial", 12F);
            this.xrLabelContactAddress.LocationFloat = new DevExpress.Utils.PointFloat(50F, 275F);
            this.xrLabelContactAddress.SizeF = new System.Drawing.SizeF(250F, 25F);
            this.xrLabelContactAddress.Text = "A: ";
            this.xrLabelContactAddress.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                new DevExpress.XtraReports.UI.XRBinding("Text", null, "QuotationHeader.ContactAddress", "A: {0}")});
            
            // Total Due
            this.xrLabelTotalDue.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.xrLabelTotalDue.LocationFloat = new DevExpress.Utils.PointFloat(500F, 160F);
            this.xrLabelTotalDue.SizeF = new System.Drawing.SizeF(150F, 25F);
            this.xrLabelTotalDue.Text = "TOTAL DUE";
            
            // Total amount
            this.xrLabelTotalAmount.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold);
            this.xrLabelTotalAmount.LocationFloat = new DevExpress.Utils.PointFloat(500F, 190F);
            this.xrLabelTotalAmount.SizeF = new System.Drawing.SizeF(150F, 40F);
            this.xrLabelTotalAmount.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                new DevExpress.XtraReports.UI.XRBinding("Text", null, "QuotationHeader.TotalAmount", "{0:C}")});
            this.xrLabelTotalAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            
            // Quotation details
            this.xrLabelQuotationNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabelQuotationNo.LocationFloat = new DevExpress.Utils.PointFloat(500F, 240F);
            this.xrLabelQuotationNo.SizeF = new System.Drawing.SizeF(150F, 20F);
            this.xrLabelQuotationNo.Text = "Quotation ID: ";
            this.xrLabelQuotationNo.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                new DevExpress.XtraReports.UI.XRBinding("Text", null, "QuotationHeader.QuotationId", "Quotation ID: {0}")});
            
            this.xrLabelQuotationDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabelQuotationDate.LocationFloat = new DevExpress.Utils.PointFloat(500F, 260F);
            this.xrLabelQuotationDate.SizeF = new System.Drawing.SizeF(150F, 20F);
            this.xrLabelQuotationDate.Text = "Date: ";
            this.xrLabelQuotationDate.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                new DevExpress.XtraReports.UI.XRBinding("Text", null, "QuotationHeader.QuotationDate", "Date: {0:dd/MM/yyyy}")});
            
            // Products table header
            ConfigureProductsTable();
            
            // Detail table
            ConfigureDetailTable();
            
            // Summary
            ConfigureSummary();
            
            // Payment method
            ConfigurePaymentMethod();
            
            // Footer
            ConfigureFooter();
        }

        private void ConfigureProductsTable()
        {
            this.xrTableProducts.LocationFloat = new DevExpress.Utils.PointFloat(50F, 320F);
            this.xrTableProducts.SizeF = new System.Drawing.SizeF(600F, 25F);
            
            this.xrTableRowHeader.HeightF = 25F;
            this.xrTableRowHeader.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
                this.xrTableCellProducts, this.xrTableCellQty, this.xrTableCellPrice, this.xrTableCellTotal});
            
            this.xrTableCellProducts.BackColor = System.Drawing.Color.DarkBlue;
            this.xrTableCellProducts.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.xrTableCellProducts.ForeColor = System.Drawing.Color.White;
            this.xrTableCellProducts.Text = "PRODUCTS";
            this.xrTableCellProducts.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCellProducts.WidthF = 200F;
            
            this.xrTableCellQty.BackColor = System.Drawing.Color.DarkBlue;
            this.xrTableCellQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.xrTableCellQty.ForeColor = System.Drawing.Color.White;
            this.xrTableCellQty.Text = "QTY";
            this.xrTableCellQty.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCellQty.WidthF = 100F;
            
            this.xrTableCellPrice.BackColor = System.Drawing.Color.DarkBlue;
            this.xrTableCellPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.xrTableCellPrice.ForeColor = System.Drawing.Color.White;
            this.xrTableCellPrice.Text = "PRICE";
            this.xrTableCellPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCellPrice.WidthF = 100F;
            
            this.xrTableCellTotal.BackColor = System.Drawing.Color.DarkBlue;
            this.xrTableCellTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.xrTableCellTotal.ForeColor = System.Drawing.Color.White;
            this.xrTableCellTotal.Text = "TOTAL";
            this.xrTableCellTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCellTotal.WidthF = 200F;
            
            this.xrTableProducts.Rows.Add(this.xrTableRowHeader);
        }

        private void ConfigureDetailTable()
        {
            this.xrTableDetail.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTableDetail.SizeF = new System.Drawing.SizeF(600F, 25F);
            
            this.xrTableRowDetail.HeightF = 25F;
            this.xrTableRowDetail.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
                this.xrTableCellServiceName, this.xrTableCellQuantity, this.xrTableCellServicePrice, this.xrTableCellTotalService});
            
            this.xrTableCellServiceName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                new DevExpress.XtraReports.UI.XRBinding("Text", null, "QuotationDetail.ServiceName")});
            this.xrTableCellServiceName.WidthF = 200F;
            this.xrTableCellServiceName.Font = new System.Drawing.Font("Arial", 11F);
            
            this.xrTableCellQuantity.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                new DevExpress.XtraReports.UI.XRBinding("Text", null, "QuotationDetail.Quantity")});
            this.xrTableCellQuantity.WidthF = 100F;
            this.xrTableCellQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCellQuantity.Font = new System.Drawing.Font("Arial", 11F);
            
            this.xrTableCellServicePrice.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                new DevExpress.XtraReports.UI.XRBinding("Text", null, "QuotationDetail.ServicePrice", "{0:C}")});
            this.xrTableCellServicePrice.WidthF = 100F;
            this.xrTableCellServicePrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCellServicePrice.Font = new System.Drawing.Font("Arial", 11F);
            
            this.xrTableCellTotalService.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                new DevExpress.XtraReports.UI.XRBinding("Text", null, "QuotationDetail.TotalService", "{0:C}")});
            this.xrTableCellTotalService.WidthF = 200F;
            this.xrTableCellTotalService.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCellTotalService.Font = new System.Drawing.Font("Arial", 11F);
            
            this.xrTableDetail.Rows.Add(this.xrTableRowDetail);
        }

        private void ConfigureSummary()
        {
            this.xrLabelSubTotal.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.xrLabelSubTotal.LocationFloat = new DevExpress.Utils.PointFloat(400F, 20F);
            this.xrLabelSubTotal.SizeF = new System.Drawing.SizeF(100F, 25F);
            this.xrLabelSubTotal.Text = "Sub-total:";
            
            this.xrLabelSubTotalValue.Font = new System.Drawing.Font("Arial", 14F);
            this.xrLabelSubTotalValue.LocationFloat = new DevExpress.Utils.PointFloat(500F, 20F);
            this.xrLabelSubTotalValue.SizeF = new System.Drawing.SizeF(100F, 25F);
            this.xrLabelSubTotalValue.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                new DevExpress.XtraReports.UI.XRBinding("Text", null, "QuotationHeader.TotalAmount", "{0:C}")});
            this.xrLabelSubTotalValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            
            this.xrLabelTax.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.xrLabelTax.LocationFloat = new DevExpress.Utils.PointFloat(400F, 50F);
            this.xrLabelTax.SizeF = new System.Drawing.SizeF(100F, 25F);
            this.xrLabelTax.Text = "Tax:";
            
            this.xrLabelTaxValue.Font = new System.Drawing.Font("Arial", 14F);
            this.xrLabelTaxValue.LocationFloat = new DevExpress.Utils.PointFloat(500F, 50F);
            this.xrLabelTaxValue.SizeF = new System.Drawing.SizeF(100F, 25F);
            this.xrLabelTaxValue.Text = "$0.00";
            this.xrLabelTaxValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            
            this.xrLabelTotal.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.xrLabelTotal.LocationFloat = new DevExpress.Utils.PointFloat(400F, 80F);
            this.xrLabelTotal.SizeF = new System.Drawing.SizeF(100F, 25F);
            this.xrLabelTotal.Text = "Total:";
            
            this.xrLabelTotalValue.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.xrLabelTotalValue.LocationFloat = new DevExpress.Utils.PointFloat(500F, 80F);
            this.xrLabelTotalValue.SizeF = new System.Drawing.SizeF(100F, 25F);
            this.xrLabelTotalValue.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                new DevExpress.XtraReports.UI.XRBinding("Text", null, "QuotationHeader.TotalAmount", "{0:C}")});
            this.xrLabelTotalValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        }

        private void ConfigurePaymentMethod()
        {
            this.xrLabelPaymentMethod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabelPaymentMethod.LocationFloat = new DevExpress.Utils.PointFloat(50F, 20F);
            this.xrLabelPaymentMethod.SizeF = new System.Drawing.SizeF(150F, 20F);
            this.xrLabelPaymentMethod.Text = "Payment Method :";
            
            this.xrLabelBankName.Font = new System.Drawing.Font("Arial", 10F);
            this.xrLabelBankName.LocationFloat = new DevExpress.Utils.PointFloat(50F, 45F);
            this.xrLabelBankName.SizeF = new System.Drawing.SizeF(200F, 20F);
            this.xrLabelBankName.Text = "Bank Name: [BankName]";
            
            this.xrLabelBankAccount.Font = new System.Drawing.Font("Arial", 10F);
            this.xrLabelBankAccount.LocationFloat = new DevExpress.Utils.PointFloat(50F, 65F);
            this.xrLabelBankAccount.SizeF = new System.Drawing.SizeF(200F, 20F);
            this.xrLabelBankAccount.Text = "Bank Account: [BankAccount]";
        }

        private void ConfigureFooter()
        {
            this.xrLabelThankYou.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.xrLabelThankYou.LocationFloat = new DevExpress.Utils.PointFloat(50F, 100F);
            this.xrLabelThankYou.SizeF = new System.Drawing.SizeF(250F, 25F);
            this.xrLabelThankYou.Text = "Thank you for your business!";
            
            this.xrLabelSignature.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.xrLabelSignature.LocationFloat = new DevExpress.Utils.PointFloat(500F, 100F);
            this.xrLabelSignature.SizeF = new System.Drawing.SizeF(150F, 25F);
            this.xrLabelSignature.Text = "[Signature]";
            
            this.xrLabelAdministrator.Font = new System.Drawing.Font("Arial", 12F);
            this.xrLabelAdministrator.LocationFloat = new DevExpress.Utils.PointFloat(500F, 125F);
            this.xrLabelAdministrator.SizeF = new System.Drawing.SizeF(150F, 25F);
            this.xrLabelAdministrator.Text = "Administrator";
        }

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
        private DevExpress.XtraReports.UI.DetailBand Detail1;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;

        // Report controls
        private DevExpress.XtraReports.UI.XRLabel xrLabelTitle;
        private DevExpress.XtraReports.UI.XRLabel xrLabelCompanyName;
        private DevExpress.XtraReports.UI.XRLabel xrLabelCompanySlogan;
        private DevExpress.XtraReports.UI.XRLabel xrLabelQuotationTo;
        private DevExpress.XtraReports.UI.XRLabel xrLabelContactName;
        private DevExpress.XtraReports.UI.XRLabel xrLabelContactEmail;
        private DevExpress.XtraReports.UI.XRLabel xrLabelContactPhone;
        private DevExpress.XtraReports.UI.XRLabel xrLabelContactAddress;
        private DevExpress.XtraReports.UI.XRLabel xrLabelTotalDue;
        private DevExpress.XtraReports.UI.XRLabel xrLabelTotalAmount;
        private DevExpress.XtraReports.UI.XRLabel xrLabelQuotationNo;
        private DevExpress.XtraReports.UI.XRLabel xrLabelQuotationDate;
        private DevExpress.XtraReports.UI.XRLabel xrLabelQuotationNoValue;
        private DevExpress.XtraReports.UI.XRLabel xrLabelQuotationDateValue;
        private DevExpress.XtraReports.UI.XRLabel xrLabelContactNameValue;
        private DevExpress.XtraReports.UI.XRLabel xrLabelContactEmailValue;
        private DevExpress.XtraReports.UI.XRLabel xrLabelContactPhoneValue;
        private DevExpress.XtraReports.UI.XRLabel xrLabelContactAddressValue;
        private DevExpress.XtraReports.UI.XRLabel xrLabelTotalAmountValue;

        // Products table
        private DevExpress.XtraReports.UI.XRTable xrTableProducts;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRowHeader;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellProducts;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellQty;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellPrice;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellTotal;

        // Detail table
        private DevExpress.XtraReports.UI.XRTable xrTableDetail;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRowDetail;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellServiceName;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellQuantity;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellServicePrice;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellTotalService;

        // Summary
        private DevExpress.XtraReports.UI.XRLabel xrLabelSubTotal;
        private DevExpress.XtraReports.UI.XRLabel xrLabelSubTotalValue;
        private DevExpress.XtraReports.UI.XRLabel xrLabelTax;
        private DevExpress.XtraReports.UI.XRLabel xrLabelTaxValue;
        private DevExpress.XtraReports.UI.XRLabel xrLabelTotal;
        private DevExpress.XtraReports.UI.XRLabel xrLabelTotalValue;

        // Payment method
        private DevExpress.XtraReports.UI.XRLabel xrLabelPaymentMethod;
        private DevExpress.XtraReports.UI.XRLabel xrLabelBankName;
        private DevExpress.XtraReports.UI.XRLabel xrLabelBankAccount;

        // Footer
        private DevExpress.XtraReports.UI.XRLabel xrLabelThankYou;
        private DevExpress.XtraReports.UI.XRLabel xrLabelSignature;
        private DevExpress.XtraReports.UI.XRLabel xrLabelAdministrator;

        #endregion
    }
}
