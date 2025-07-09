namespace ServiveceSystem.PresentationLayer.InvoiceDetail
{
    partial class EditInvoiceDetailForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DiscountTypecomboBox = new ComboBox();
            DiscounttextBox = new TextBox();
            label7 = new Label();
            Savebtn = new Button();
            label5 = new Label();
            ServiceIdtextBox = new TextBox();
            ServicePricetextBox = new TextBox();
            QuotationIdtextBox = new TextBox();
            QuantitytextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // DiscountTypecomboBox
            // 
            DiscountTypecomboBox.FormattingEnabled = true;
            DiscountTypecomboBox.Location = new Point(204, 227);
            DiscountTypecomboBox.Margin = new Padding(2, 2, 2, 2);
            DiscountTypecomboBox.Name = "DiscountTypecomboBox";
            DiscountTypecomboBox.Size = new Size(137, 23);
            DiscountTypecomboBox.TabIndex = 44;
            // 
            // DiscounttextBox
            // 
            DiscounttextBox.Location = new Point(204, 188);
            DiscounttextBox.Margin = new Padding(3, 2, 3, 2);
            DiscounttextBox.Name = "DiscounttextBox";
            DiscounttextBox.Size = new Size(137, 23);
            DiscounttextBox.TabIndex = 43;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(39, 108);
            label7.Name = "label7";
            label7.Size = new Size(93, 21);
            label7.TabIndex = 42;
            label7.Text = "QuotationId";
            // 
            // Savebtn
            // 
            Savebtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Savebtn.Location = new Point(113, 288);
            Savebtn.Margin = new Padding(2, 2, 2, 2);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(92, 41);
            Savebtn.TabIndex = 40;
            Savebtn.Text = "Update";
            Savebtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(39, 228);
            label5.Name = "label5";
            label5.Size = new Size(103, 21);
            label5.TabIndex = 38;
            label5.Text = "DiscountType";
            // 
            // ServiceIdtextBox
            // 
            ServiceIdtextBox.Location = new Point(204, 68);
            ServiceIdtextBox.Margin = new Padding(3, 2, 3, 2);
            ServiceIdtextBox.Name = "ServiceIdtextBox";
            ServiceIdtextBox.Size = new Size(137, 23);
            ServiceIdtextBox.TabIndex = 37;
            // 
            // ServicePricetextBox
            // 
            ServicePricetextBox.Location = new Point(204, 151);
            ServicePricetextBox.Margin = new Padding(3, 2, 3, 2);
            ServicePricetextBox.Name = "ServicePricetextBox";
            ServicePricetextBox.Size = new Size(137, 23);
            ServicePricetextBox.TabIndex = 36;
            // 
            // QuotationIdtextBox
            // 
            QuotationIdtextBox.Location = new Point(204, 108);
            QuotationIdtextBox.Margin = new Padding(3, 2, 3, 2);
            QuotationIdtextBox.Name = "QuotationIdtextBox";
            QuotationIdtextBox.Size = new Size(137, 23);
            QuotationIdtextBox.TabIndex = 35;
            // 
            // QuantitytextBox
            // 
            QuantitytextBox.Location = new Point(204, 29);
            QuantitytextBox.Margin = new Padding(3, 2, 3, 2);
            QuantitytextBox.Name = "QuantitytextBox";
            QuantitytextBox.Size = new Size(137, 23);
            QuantitytextBox.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(40, 186);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 33;
            label4.Text = "Discount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(39, 151);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 32;
            label3.Text = "ServicePrice";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(39, 68);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 31;
            label2.Text = "ServiceId";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(39, 28);
            label1.Name = "label1";
            label1.Size = new Size(70, 21);
            label1.TabIndex = 30;
            label1.Text = "Quantity";
            // 
            // EditInvoiceDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 358);
            Controls.Add(DiscountTypecomboBox);
            Controls.Add(DiscounttextBox);
            Controls.Add(label7);
            Controls.Add(Savebtn);
            Controls.Add(label5);
            Controls.Add(ServiceIdtextBox);
            Controls.Add(ServicePricetextBox);
            Controls.Add(QuotationIdtextBox);
            Controls.Add(QuantitytextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditInvoiceDetailForm";
            Text = "EditInvoiceDetailForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox DiscountTypecomboBox;
        private TextBox DiscounttextBox;
        private Label label7;
        private Button Savebtn;
        private Label label5;
        private TextBox ServiceIdtextBox;
        private TextBox ServicePricetextBox;
        private TextBox QuotationIdtextBox;
        private TextBox QuantitytextBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}