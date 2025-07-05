namespace ServiveceSystem.PresentationLayer
{
    partial class AddContactPersonForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ClinicNametextBox = new TextBox();
            PhonetextBox = new TextBox();
            EmailtextBox = new TextBox();
            CompanyNametextBox = new TextBox();
            label5 = new Label();
            LocationtextBox = new TextBox();
            label6 = new Label();
            Savebtn = new Button();
            Cancelbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 113);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(143, 32);
            label1.TabIndex = 0;
            label1.Text = "Clinic Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 186);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(187, 32);
            label2.TabIndex = 1;
            label2.Text = "Company Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 269);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 32);
            label3.TabIndex = 2;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 352);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 32);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // ClinicNametextBox
            // 
            ClinicNametextBox.Location = new Point(299, 109);
            ClinicNametextBox.Margin = new Padding(4);
            ClinicNametextBox.Name = "ClinicNametextBox";
            ClinicNametextBox.Size = new Size(194, 39);
            ClinicNametextBox.TabIndex = 4;
            // 
            // PhonetextBox
            // 
            PhonetextBox.Location = new Point(299, 265);
            PhonetextBox.Margin = new Padding(4);
            PhonetextBox.Name = "PhonetextBox";
            PhonetextBox.Size = new Size(194, 39);
            PhonetextBox.TabIndex = 5;
            // 
            // EmailtextBox
            // 
            EmailtextBox.Location = new Point(299, 344);
            EmailtextBox.Margin = new Padding(4);
            EmailtextBox.Name = "EmailtextBox";
            EmailtextBox.Size = new Size(194, 39);
            EmailtextBox.TabIndex = 6;
            EmailtextBox.TextChanged += textBox3_TextChanged;
            // 
            // CompanyNametextBox
            // 
            CompanyNametextBox.Location = new Point(299, 182);
            CompanyNametextBox.Margin = new Padding(4);
            CompanyNametextBox.Name = "CompanyNametextBox";
            CompanyNametextBox.Size = new Size(194, 39);
            CompanyNametextBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(95, 434);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(104, 32);
            label5.TabIndex = 8;
            label5.Text = "Location";
            // 
            // LocationtextBox
            // 
            LocationtextBox.Location = new Point(299, 434);
            LocationtextBox.Margin = new Padding(4);
            LocationtextBox.Name = "LocationtextBox";
            LocationtextBox.Size = new Size(194, 39);
            LocationtextBox.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(229, 23);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(150, 38);
            label6.TabIndex = 11;
            label6.Text = "Add Clinic";
            // 
            // Savebtn
            // 
            Savebtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Savebtn.Location = new Point(137, 540);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(112, 40);
            Savebtn.TabIndex = 12;
            Savebtn.Text = "Save";
            Savebtn.UseVisualStyleBackColor = true;
            // 
            // Cancelbtn
            // 
            Cancelbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Cancelbtn.Location = new Point(346, 540);
            Cancelbtn.Name = "Cancelbtn";
            Cancelbtn.Size = new Size(112, 40);
            Cancelbtn.TabIndex = 13;
            Cancelbtn.Text = "Cancel";
            Cancelbtn.UseVisualStyleBackColor = true;
            // 
            // AddContactPersonForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 632);
            Controls.Add(Cancelbtn);
            Controls.Add(Savebtn);
            Controls.Add(label6);
            Controls.Add(LocationtextBox);
            Controls.Add(label5);
            Controls.Add(CompanyNametextBox);
            Controls.Add(EmailtextBox);
            Controls.Add(PhonetextBox);
            Controls.Add(ClinicNametextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "AddContactPersonForm";
            Text = "ClincServiseForm";
            Load += AddContactPersonForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox ClinicNametextBox;
        private TextBox PhonetextBox;
        private TextBox EmailtextBox;
        private TextBox CompanyNametextBox;
        private Label label5;
        private TextBox LocationtextBox;
        private Label label6;
        private Button Savebtn;
        private Button Cancelbtn;
    }
}