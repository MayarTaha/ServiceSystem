namespace ServiveceSystem.PresentationLayer.InvoiceHeader
{
    partial class EditInvoiceHeaderForm
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
            PaymentMethodcomboBox = new ComboBox();
            ContactIdtextBox = new TextBox();
            label7 = new Label();
            Savebtn = new Button();
            label5 = new Label();
            InvoicedatetextBox = new TextBox();
            PaymenttextBox = new TextBox();
            totalpricetextBox = new TextBox();
            QuotationIdtextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // PaymentMethodcomboBox
            // 
            PaymentMethodcomboBox.FormattingEnabled = true;
            PaymentMethodcomboBox.Location = new Point(191, 180);
            PaymentMethodcomboBox.Margin = new Padding(2, 2, 2, 2);
            PaymentMethodcomboBox.Name = "PaymentMethodcomboBox";
            PaymentMethodcomboBox.Size = new Size(137, 23);
            PaymentMethodcomboBox.TabIndex = 59;
            // 
            // ContactIdtextBox
            // 
            ContactIdtextBox.Location = new Point(191, 222);
            ContactIdtextBox.Margin = new Padding(3, 2, 3, 2);
            ContactIdtextBox.Name = "ContactIdtextBox";
            ContactIdtextBox.Size = new Size(137, 23);
            ContactIdtextBox.TabIndex = 58;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(25, 100);
            label7.Name = "label7";
            label7.Size = new Size(76, 21);
            label7.TabIndex = 57;
            label7.Text = "TotalPrice";
            // 
            // Savebtn
            // 
            Savebtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Savebtn.Location = new Point(111, 266);
            Savebtn.Margin = new Padding(2, 2, 2, 2);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(84, 37);
            Savebtn.TabIndex = 55;
            Savebtn.Text = "Update";
            Savebtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(25, 220);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 53;
            label5.Text = "ContactId";
            // 
            // InvoicedatetextBox
            // 
            InvoicedatetextBox.Location = new Point(191, 60);
            InvoicedatetextBox.Margin = new Padding(3, 2, 3, 2);
            InvoicedatetextBox.Name = "InvoicedatetextBox";
            InvoicedatetextBox.Size = new Size(137, 23);
            InvoicedatetextBox.TabIndex = 52;
            // 
            // PaymenttextBox
            // 
            PaymenttextBox.Location = new Point(191, 143);
            PaymenttextBox.Margin = new Padding(3, 2, 3, 2);
            PaymenttextBox.Name = "PaymenttextBox";
            PaymenttextBox.Size = new Size(137, 23);
            PaymenttextBox.TabIndex = 51;
            // 
            // totalpricetextBox
            // 
            totalpricetextBox.Location = new Point(191, 100);
            totalpricetextBox.Margin = new Padding(3, 2, 3, 2);
            totalpricetextBox.Name = "totalpricetextBox";
            totalpricetextBox.Size = new Size(137, 23);
            totalpricetextBox.TabIndex = 50;
            // 
            // QuotationIdtextBox
            // 
            QuotationIdtextBox.Location = new Point(191, 21);
            QuotationIdtextBox.Margin = new Padding(3, 2, 3, 2);
            QuotationIdtextBox.Name = "QuotationIdtextBox";
            QuotationIdtextBox.Size = new Size(137, 23);
            QuotationIdtextBox.TabIndex = 49;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(27, 178);
            label4.Name = "label4";
            label4.Size = new Size(124, 21);
            label4.TabIndex = 48;
            label4.Text = "PaymentMethod";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(25, 143);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 47;
            label3.Text = "Payment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(25, 60);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 46;
            label2.Text = "InvoiceDate";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(25, 20);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 45;
            label1.Text = "QuotationId";
            // 
            // EditInvoiceHeaderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 318);
            Controls.Add(PaymentMethodcomboBox);
            Controls.Add(ContactIdtextBox);
            Controls.Add(label7);
            Controls.Add(Savebtn);
            Controls.Add(label5);
            Controls.Add(InvoicedatetextBox);
            Controls.Add(PaymenttextBox);
            Controls.Add(totalpricetextBox);
            Controls.Add(QuotationIdtextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditInvoiceHeaderForm";
            Text = "EditInvoiceHeaderForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox PaymentMethodcomboBox;
        private TextBox ContactIdtextBox;
        private Label label7;
        private Button Savebtn;
        private Label label5;
        private TextBox InvoicedatetextBox;
        private TextBox PaymenttextBox;
        private TextBox totalpricetextBox;
        private TextBox QuotationIdtextBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}