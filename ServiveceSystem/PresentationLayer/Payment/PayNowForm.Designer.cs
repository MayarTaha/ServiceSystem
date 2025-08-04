namespace ServiveceSystem.PresentationLayer.Payment
{
    partial class PayNowForm
    {
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.LabelControl dxLblInvoiceIdTitle;
        private DevExpress.XtraEditors.LabelControl dxLblInvoiceId;
        private DevExpress.XtraEditors.LabelControl dxLblCurrentRemainderTitle;
        private DevExpress.XtraEditors.LabelControl dxLblCurrentRemainder;
        private DevExpress.XtraEditors.LabelControl dxLblAmountToPayTitle;
        private DevExpress.XtraEditors.TextEdit dxTxtAmountToPay;
        private DevExpress.XtraEditors.LabelControl dxLblNewRemainderTitle;
        private DevExpress.XtraEditors.LabelControl dxLblNewRemainder;
        private DevExpress.XtraEditors.SimpleButton dxBtnPay;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dxLblInvoiceIdTitle = new DevExpress.XtraEditors.LabelControl();
            dxLblInvoiceId = new DevExpress.XtraEditors.LabelControl();
            dxLblCurrentRemainderTitle = new DevExpress.XtraEditors.LabelControl();
            dxLblCurrentRemainder = new DevExpress.XtraEditors.LabelControl();
            dxLblAmountToPayTitle = new DevExpress.XtraEditors.LabelControl();
            dxTxtAmountToPay = new DevExpress.XtraEditors.TextEdit();
            dxLblNewRemainderTitle = new DevExpress.XtraEditors.LabelControl();
            dxLblNewRemainder = new DevExpress.XtraEditors.LabelControl();
            dxBtnPay = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)dxTxtAmountToPay.Properties).BeginInit();
            SuspendLayout();
            // 
            // dxLblInvoiceIdTitle
            // 
            dxLblInvoiceIdTitle.Appearance.Font = new Font("Segoe UI", 14.25F);
            dxLblInvoiceIdTitle.Appearance.Options.UseFont = true;
            dxLblInvoiceIdTitle.Location = new Point(15, 16);
            dxLblInvoiceIdTitle.Margin = new Padding(2, 2, 2, 2);
            dxLblInvoiceIdTitle.Name = "dxLblInvoiceIdTitle";
            dxLblInvoiceIdTitle.Size = new Size(87, 25);
            dxLblInvoiceIdTitle.TabIndex = 0;
            dxLblInvoiceIdTitle.Text = "Invoice ID:";
            // 
            // dxLblInvoiceId
            // 
            dxLblInvoiceId.Appearance.Font = new Font("Segoe UI", 14.25F);
            dxLblInvoiceId.Appearance.Options.UseFont = true;
            dxLblInvoiceId.Location = new Point(187, 11);
            dxLblInvoiceId.Margin = new Padding(2, 2, 2, 2);
            dxLblInvoiceId.Name = "dxLblInvoiceId";
            dxLblInvoiceId.Size = new Size(50, 25);
            dxLblInvoiceId.TabIndex = 1;
            dxLblInvoiceId.Text = "00000";
            // 
            // dxLblCurrentRemainderTitle
            // 
            dxLblCurrentRemainderTitle.Appearance.Font = new Font("Segoe UI", 14.25F);
            dxLblCurrentRemainderTitle.Appearance.Options.UseFont = true;
            dxLblCurrentRemainderTitle.Location = new Point(15, 49);
            dxLblCurrentRemainderTitle.Margin = new Padding(2, 2, 2, 2);
            dxLblCurrentRemainderTitle.Name = "dxLblCurrentRemainderTitle";
            dxLblCurrentRemainderTitle.Size = new Size(164, 25);
            dxLblCurrentRemainderTitle.TabIndex = 2;
            dxLblCurrentRemainderTitle.Text = "Current Remainder:";
            // 
            // dxLblCurrentRemainder
            // 
            dxLblCurrentRemainder.Appearance.Font = new Font("Segoe UI", 14.25F);
            dxLblCurrentRemainder.Appearance.Options.UseFont = true;
            dxLblCurrentRemainder.Location = new Point(203, 49);
            dxLblCurrentRemainder.Margin = new Padding(2, 2, 2, 2);
            dxLblCurrentRemainder.Name = "dxLblCurrentRemainder";
            dxLblCurrentRemainder.Size = new Size(34, 25);
            dxLblCurrentRemainder.TabIndex = 3;
            dxLblCurrentRemainder.Text = "0.00";
            // 
            // dxLblAmountToPayTitle
            // 
            dxLblAmountToPayTitle.Appearance.Font = new Font("Segoe UI", 14.25F);
            dxLblAmountToPayTitle.Appearance.Options.UseFont = true;
            dxLblAmountToPayTitle.Location = new Point(15, 81);
            dxLblAmountToPayTitle.Margin = new Padding(2, 2, 2, 2);
            dxLblAmountToPayTitle.Name = "dxLblAmountToPayTitle";
            dxLblAmountToPayTitle.Size = new Size(128, 25);
            dxLblAmountToPayTitle.TabIndex = 4;
            dxLblAmountToPayTitle.Text = "Amount to Pay:";
            // 
            // dxTxtAmountToPay
            // 
            dxTxtAmountToPay.Location = new Point(177, 78);
            dxTxtAmountToPay.Margin = new Padding(2, 2, 2, 2);
            dxTxtAmountToPay.Name = "dxTxtAmountToPay";
            dxTxtAmountToPay.Properties.Appearance.Font = new Font("Segoe UI", 14.25F);
            dxTxtAmountToPay.Properties.Appearance.Options.UseFont = true;
            dxTxtAmountToPay.Size = new Size(138, 34);
            dxTxtAmountToPay.TabIndex = 5;
            // 
            // dxLblNewRemainderTitle
            // 
            dxLblNewRemainderTitle.Appearance.Font = new Font("Segoe UI", 14.25F);
            dxLblNewRemainderTitle.Appearance.Options.UseFont = true;
            dxLblNewRemainderTitle.Location = new Point(15, 114);
            dxLblNewRemainderTitle.Margin = new Padding(2, 2, 2, 2);
            dxLblNewRemainderTitle.Name = "dxLblNewRemainderTitle";
            dxLblNewRemainderTitle.Size = new Size(138, 25);
            dxLblNewRemainderTitle.TabIndex = 6;
            dxLblNewRemainderTitle.Text = "New Remainder:";
            // 
            // dxLblNewRemainder
            // 
            dxLblNewRemainder.Appearance.Font = new Font("Segoe UI", 14.25F);
            dxLblNewRemainder.Appearance.Options.UseFont = true;
            dxLblNewRemainder.Location = new Point(203, 114);
            dxLblNewRemainder.Margin = new Padding(2, 2, 2, 2);
            dxLblNewRemainder.Name = "dxLblNewRemainder";
            dxLblNewRemainder.Size = new Size(34, 25);
            dxLblNewRemainder.TabIndex = 7;
            dxLblNewRemainder.Text = "0.00";
            // 
            // dxBtnPay
            // 
            dxBtnPay.Appearance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dxBtnPay.Appearance.Options.UseFont = true;
            dxBtnPay.Location = new Point(11, 143);
            dxBtnPay.Margin = new Padding(2, 2, 2, 2);
            dxBtnPay.Name = "dxBtnPay";
            dxBtnPay.Size = new Size(310, 33);
            dxBtnPay.TabIndex = 8;
            dxBtnPay.Text = "Pay";
            // 
            // PayNowForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 181);
            Controls.Add(dxBtnPay);
            Controls.Add(dxLblNewRemainder);
            Controls.Add(dxLblNewRemainderTitle);
            Controls.Add(dxTxtAmountToPay);
            Controls.Add(dxLblAmountToPayTitle);
            Controls.Add(dxLblCurrentRemainder);
            Controls.Add(dxLblCurrentRemainderTitle);
            Controls.Add(dxLblInvoiceId);
            Controls.Add(dxLblInvoiceIdTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PayNowForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pay Invoice";
            ((System.ComponentModel.ISupportInitialize)dxTxtAmountToPay.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
} 