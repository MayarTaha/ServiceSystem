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
            Cancelbtn = new Button();
            Savebtn = new Button();
            label6 = new Label();
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
            PaymentMethodcomboBox.Location = new Point(333, 378);
            PaymentMethodcomboBox.Name = "PaymentMethodcomboBox";
            PaymentMethodcomboBox.Size = new Size(194, 33);
            PaymentMethodcomboBox.TabIndex = 44;
            // 
            // ContactIdtextBox
            // 
            ContactIdtextBox.Location = new Point(333, 448);
            ContactIdtextBox.Margin = new Padding(4);
            ContactIdtextBox.Name = "ContactIdtextBox";
            ContactIdtextBox.Size = new Size(194, 31);
            ContactIdtextBox.TabIndex = 43;
            ContactIdtextBox.TextChanged += DiscounttextBox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(96, 245);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(116, 32);
            label7.TabIndex = 42;
            label7.Text = "TotalPrice";
            // 
            // Cancelbtn
            // 
            Cancelbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Cancelbtn.Location = new Point(380, 556);
            Cancelbtn.Name = "Cancelbtn";
            Cancelbtn.Size = new Size(112, 40);
            Cancelbtn.TabIndex = 41;
            Cancelbtn.Text = "Cancel";
            Cancelbtn.UseVisualStyleBackColor = true;
            // 
            // Savebtn
            // 
            Savebtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Savebtn.Location = new Point(171, 556);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(112, 40);
            Savebtn.TabIndex = 40;
            Savebtn.Text = "Save";
            Savebtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(180, 37);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(267, 38);
            label6.TabIndex = 39;
            label6.Text = "Add InvoiceHeader";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(96, 445);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(116, 32);
            label5.TabIndex = 38;
            label5.Text = "ContactId";
            // 
            // InvoicedatetextBox
            // 
            InvoicedatetextBox.Location = new Point(333, 178);
            InvoicedatetextBox.Margin = new Padding(4);
            InvoicedatetextBox.Name = "InvoicedatetextBox";
            InvoicedatetextBox.Size = new Size(194, 31);
            InvoicedatetextBox.TabIndex = 37;
            // 
            // PaymenttextBox
            // 
            PaymenttextBox.Location = new Point(333, 317);
            PaymenttextBox.Margin = new Padding(4);
            PaymenttextBox.Name = "PaymenttextBox";
            PaymenttextBox.Size = new Size(194, 31);
            PaymenttextBox.TabIndex = 36;
            // 
            // totalpricetextBox
            // 
            totalpricetextBox.Location = new Point(333, 245);
            totalpricetextBox.Margin = new Padding(4);
            totalpricetextBox.Name = "totalpricetextBox";
            totalpricetextBox.Size = new Size(194, 31);
            totalpricetextBox.TabIndex = 35;
            // 
            // QuotationIdtextBox
            // 
            QuotationIdtextBox.Location = new Point(333, 114);
            QuotationIdtextBox.Margin = new Padding(4);
            QuotationIdtextBox.Name = "QuotationIdtextBox";
            QuotationIdtextBox.Size = new Size(194, 31);
            QuotationIdtextBox.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(98, 375);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(191, 32);
            label4.TabIndex = 33;
            label4.Text = "PaymentMethod";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(96, 316);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(106, 32);
            label3.TabIndex = 32;
            label3.Text = "Payment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(96, 178);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(140, 32);
            label2.TabIndex = 31;
            label2.Text = "InvoiceDate";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(96, 111);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(142, 32);
            label1.TabIndex = 30;
            label1.Text = "QuotationId";
            // 
            // AddInvoiceHeaderForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 632);
            Controls.Add(PaymentMethodcomboBox);
            Controls.Add(ContactIdtextBox);
            Controls.Add(label7);
            Controls.Add(Cancelbtn);
            Controls.Add(Savebtn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(InvoicedatetextBox);
            Controls.Add(PaymenttextBox);
            Controls.Add(totalpricetextBox);
            Controls.Add(QuotationIdtextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddInvoiceHeaderForm";
            Text = "AddInvoiceHeaderForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox PaymentMethodcomboBox;
        private TextBox ContactIdtextBox;
        private Label label7;
        private Button Cancelbtn;
        private Button Savebtn;
        private Label label6;
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