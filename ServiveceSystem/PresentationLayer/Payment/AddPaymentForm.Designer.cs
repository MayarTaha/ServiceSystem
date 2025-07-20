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
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // PaymentStatuscomboBox
            // 
            PaymentStatuscomboBox.FormattingEnabled = true;
            PaymentStatuscomboBox.Location = new Point(146, 191);
            PaymentStatuscomboBox.Margin = new Padding(2);
            PaymentStatuscomboBox.Name = "PaymentStatuscomboBox";
            PaymentStatuscomboBox.Size = new Size(118, 21);
            PaymentStatuscomboBox.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(5, 52);
            label7.Name = "label7";
            label7.Size = new Size(95, 21);
            label7.TabIndex = 42;
            label7.Text = "AmountPaid";
            // 
            // Savebtn
            // 
            Savebtn.BackColor = Color.White;
            Savebtn.FlatAppearance.BorderColor = Color.White;
            Savebtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Savebtn.ForeColor = Color.Black;
            Savebtn.Location = new Point(11, 229);
            Savebtn.Margin = new Padding(2);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(273, 32);
            Savebtn.TabIndex = 40;
            Savebtn.Text = "Add";
            Savebtn.UseVisualStyleBackColor = false;
            Savebtn.Click += Savebtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(4, 192);
            label5.Name = "label5";
            label5.Size = new Size(112, 21);
            label5.TabIndex = 38;
            label5.Text = "PaymentStatus";
            // 
            // InvoiceIdtextBox
            // 
            InvoiceIdtextBox.Location = new Point(146, 20);
            InvoiceIdtextBox.Margin = new Padding(3, 2, 3, 2);
            InvoiceIdtextBox.Name = "InvoiceIdtextBox";
            InvoiceIdtextBox.Size = new Size(118, 22);
            InvoiceIdtextBox.TabIndex = 37;
            // 
            // PaymentDatetextBox
            // 
            PaymentDatetextBox.Location = new Point(146, 126);
            PaymentDatetextBox.Margin = new Padding(3, 2, 3, 2);
            PaymentDatetextBox.Name = "PaymentDatetextBox";
            PaymentDatetextBox.Size = new Size(118, 22);
            PaymentDatetextBox.TabIndex = 36;
            // 
            // AmountPaidtextBox
            // 
            AmountPaidtextBox.Location = new Point(146, 88);
            AmountPaidtextBox.Margin = new Padding(3, 2, 3, 2);
            AmountPaidtextBox.Name = "AmountPaidtextBox";
            AmountPaidtextBox.Size = new Size(118, 22);
            AmountPaidtextBox.TabIndex = 35;
            // 
            // RemainingAmounttextBox
            // 
            RemainingAmounttextBox.Location = new Point(146, 52);
            RemainingAmounttextBox.Margin = new Padding(3, 2, 3, 2);
            RemainingAmounttextBox.Name = "RemainingAmounttextBox";
            RemainingAmounttextBox.Size = new Size(118, 22);
            RemainingAmounttextBox.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(5, 156);
            label4.Name = "label4";
            label4.Size = new Size(124, 21);
            label4.TabIndex = 33;
            label4.Text = "PaymentMethod";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(4, 126);
            label3.Name = "label3";
            label3.Size = new Size(102, 21);
            label3.TabIndex = 32;
            label3.Text = "PaymentDate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(11, 20);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 31;
            label2.Text = "InvoiceId";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(4, 87);
            label1.Name = "label1";
            label1.Size = new Size(141, 21);
            label1.TabIndex = 30;
            label1.Text = "RemainingAmount";
            // 
            // PaymentMethodcomboBox
            // 
            PaymentMethodcomboBox.FormattingEnabled = true;
            PaymentMethodcomboBox.Location = new Point(146, 158);
            PaymentMethodcomboBox.Margin = new Padding(2);
            PaymentMethodcomboBox.Name = "PaymentMethodcomboBox";
            PaymentMethodcomboBox.Size = new Size(118, 21);
            PaymentMethodcomboBox.TabIndex = 45;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(InvoiceIdtextBox);
            groupBox1.Controls.Add(PaymentMethodcomboBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(PaymentStatuscomboBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(RemainingAmounttextBox);
            groupBox1.Controls.Add(AmountPaidtextBox);
            groupBox1.Controls.Add(PaymentDatetextBox);
            groupBox1.Location = new Point(12, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(272, 223);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data";
            // 
            // AddPaymentForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 265);
            Controls.Add(groupBox1);
            Controls.Add(Savebtn);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddPaymentForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Payment Method";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
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
        private GroupBox groupBox1;
    }
}