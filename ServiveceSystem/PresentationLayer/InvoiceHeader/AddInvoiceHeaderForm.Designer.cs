namespace ServiveceSystem.PresentationLayer.InvoiceHeader
{
    partial class AddInvoiceHeaderForm
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
            PaymentMethodcomboBox.Location = new Point(201, 186);
            PaymentMethodcomboBox.Margin = new Padding(2, 2, 2, 2);
            PaymentMethodcomboBox.Name = "PaymentMethodcomboBox";
            PaymentMethodcomboBox.Size = new Size(137, 23);
            PaymentMethodcomboBox.TabIndex = 44;
            // 
            // ContactIdtextBox
            // 
            ContactIdtextBox.Location = new Point(201, 228);
            ContactIdtextBox.Margin = new Padding(3, 2, 3, 2);
            ContactIdtextBox.Name = "ContactIdtextBox";
            ContactIdtextBox.Size = new Size(137, 23);
            ContactIdtextBox.TabIndex = 43;
            ContactIdtextBox.TextChanged += DiscounttextBox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(35, 106);
            label7.Name = "label7";
            label7.Size = new Size(76, 21);
            label7.TabIndex = 42;
            label7.Text = "TotalPrice";
            // 
            // Savebtn
            // 
            Savebtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Savebtn.Location = new Point(118, 291);
            Savebtn.Margin = new Padding(2, 2, 2, 2);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(78, 38);
            Savebtn.TabIndex = 40;
            Savebtn.Text = "Add";
            Savebtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(35, 226);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 38;
            label5.Text = "ContactId";
            // 
            // InvoicedatetextBox
            // 
            InvoicedatetextBox.Location = new Point(201, 66);
            InvoicedatetextBox.Margin = new Padding(3, 2, 3, 2);
            InvoicedatetextBox.Name = "InvoicedatetextBox";
            InvoicedatetextBox.Size = new Size(137, 23);
            InvoicedatetextBox.TabIndex = 37;
            // 
            // PaymenttextBox
            // 
            PaymenttextBox.Location = new Point(201, 149);
            PaymenttextBox.Margin = new Padding(3, 2, 3, 2);
            PaymenttextBox.Name = "PaymenttextBox";
            PaymenttextBox.Size = new Size(137, 23);
            PaymenttextBox.TabIndex = 36;
            // 
            // totalpricetextBox
            // 
            totalpricetextBox.Location = new Point(201, 106);
            totalpricetextBox.Margin = new Padding(3, 2, 3, 2);
            totalpricetextBox.Name = "totalpricetextBox";
            totalpricetextBox.Size = new Size(137, 23);
            totalpricetextBox.TabIndex = 35;
            // 
            // QuotationIdtextBox
            // 
            QuotationIdtextBox.Location = new Point(201, 27);
            QuotationIdtextBox.Margin = new Padding(3, 2, 3, 2);
            QuotationIdtextBox.Name = "QuotationIdtextBox";
            QuotationIdtextBox.Size = new Size(137, 23);
            QuotationIdtextBox.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(37, 184);
            label4.Name = "label4";
            label4.Size = new Size(124, 21);
            label4.TabIndex = 33;
            label4.Text = "PaymentMethod";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(35, 149);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 32;
            label3.Text = "Payment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(35, 66);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 31;
            label2.Text = "InvoiceDate";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(35, 26);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 30;
            label1.Text = "QuotationId";
            // 
            // AddInvoiceHeaderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 336);
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
            Name = "AddInvoiceHeaderForm";
            Text = "AddInvoiceHeaderForm";
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