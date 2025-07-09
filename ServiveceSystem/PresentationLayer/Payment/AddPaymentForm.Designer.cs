namespace ServiveceSystem.PresentationLayer.PaymentMethod
{
    partial class AddPaymentForm
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
            PaymentStatuscomboBox = new ComboBox();
            label7 = new Label();
            Savebtn = new Button();
            label5 = new Label();
            InvoiceIdtextBox = new TextBox();
            PaymentDatetextBox = new TextBox();
            AmountPaidtextBox = new TextBox();
            RemainingAmounttextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            PaymentMethodcomboBox = new ComboBox();
            SuspendLayout();
            // 
            // PaymentStatuscomboBox
            // 
            PaymentStatuscomboBox.FormattingEnabled = true;
            PaymentStatuscomboBox.Location = new Point(182, 222);
            PaymentStatuscomboBox.Margin = new Padding(2);
            PaymentStatuscomboBox.Name = "PaymentStatuscomboBox";
            PaymentStatuscomboBox.Size = new Size(137, 23);
            PaymentStatuscomboBox.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(18, 61);
            label7.Name = "label7";
            label7.Size = new Size(95, 21);
            label7.TabIndex = 42;
            label7.Text = "AmountPaid";
            // 
            // Savebtn
            // 
            Savebtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Savebtn.Location = new Point(115, 277);
            Savebtn.Margin = new Padding(2);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(88, 37);
            Savebtn.TabIndex = 40;
            Savebtn.Text = "Add";
            Savebtn.UseVisualStyleBackColor = true;
            Savebtn.Click += Savebtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(16, 223);
            label5.Name = "label5";
            label5.Size = new Size(112, 21);
            label5.TabIndex = 38;
            label5.Text = "PaymentStatus";
            // 
            // InvoiceIdtextBox
            // 
            InvoiceIdtextBox.Location = new Point(182, 24);
            InvoiceIdtextBox.Margin = new Padding(3, 2, 3, 2);
            InvoiceIdtextBox.Name = "InvoiceIdtextBox";
            InvoiceIdtextBox.Size = new Size(137, 23);
            InvoiceIdtextBox.TabIndex = 37;
            // 
            // PaymentDatetextBox
            // 
            PaymentDatetextBox.Location = new Point(182, 146);
            PaymentDatetextBox.Margin = new Padding(3, 2, 3, 2);
            PaymentDatetextBox.Name = "PaymentDatetextBox";
            PaymentDatetextBox.Size = new Size(137, 23);
            PaymentDatetextBox.TabIndex = 36;
            // 
            // AmountPaidtextBox
            // 
            AmountPaidtextBox.Location = new Point(182, 103);
            AmountPaidtextBox.Margin = new Padding(3, 2, 3, 2);
            AmountPaidtextBox.Name = "AmountPaidtextBox";
            AmountPaidtextBox.Size = new Size(137, 23);
            AmountPaidtextBox.TabIndex = 35;
            // 
            // RemainingAmounttextBox
            // 
            RemainingAmounttextBox.Location = new Point(182, 61);
            RemainingAmounttextBox.Margin = new Padding(3, 2, 3, 2);
            RemainingAmounttextBox.Name = "RemainingAmounttextBox";
            RemainingAmounttextBox.Size = new Size(137, 23);
            RemainingAmounttextBox.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(18, 181);
            label4.Name = "label4";
            label4.Size = new Size(124, 21);
            label4.TabIndex = 33;
            label4.Text = "PaymentMethod";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(16, 146);
            label3.Name = "label3";
            label3.Size = new Size(102, 21);
            label3.TabIndex = 32;
            label3.Text = "PaymentDate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(24, 24);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 31;
            label2.Text = "InvoiceId";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(16, 101);
            label1.Name = "label1";
            label1.Size = new Size(141, 21);
            label1.TabIndex = 30;
            label1.Text = "RemainingAmount";
            // 
            // PaymentMethodcomboBox
            // 
            PaymentMethodcomboBox.FormattingEnabled = true;
            PaymentMethodcomboBox.Location = new Point(182, 183);
            PaymentMethodcomboBox.Margin = new Padding(2);
            PaymentMethodcomboBox.Name = "PaymentMethodcomboBox";
            PaymentMethodcomboBox.Size = new Size(137, 23);
            PaymentMethodcomboBox.TabIndex = 45;
            // 
            // AddPaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 325);
            Controls.Add(PaymentMethodcomboBox);
            Controls.Add(PaymentStatuscomboBox);
            Controls.Add(label7);
            Controls.Add(Savebtn);
            Controls.Add(label5);
            Controls.Add(InvoiceIdtextBox);
            Controls.Add(PaymentDatetextBox);
            Controls.Add(AmountPaidtextBox);
            Controls.Add(RemainingAmounttextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddPaymentForm";
            Text = "AddPaymentMethodForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox PaymentStatuscomboBox;
        private Label label7;
        private Button Savebtn;
        private Label label5;
        private TextBox InvoiceIdtextBox;
        private TextBox PaymentDatetextBox;
        private TextBox AmountPaidtextBox;
        private TextBox RemainingAmounttextBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox PaymentMethodcomboBox;
    }
}