namespace ServiveceSystem.PresentationLayer.ContactPerson
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
            CancelContactPersonbtn = new Button();
            SaveContactPersonbtn = new Button();
            label6 = new Label();
            ContactEmailtextBox = new TextBox();
            ContactPhonetextBox = new TextBox();
            ContactNametextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // CancelContactPersonbtn
            // 
            CancelContactPersonbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            CancelContactPersonbtn.Location = new Point(346, 493);
            CancelContactPersonbtn.Name = "CancelContactPersonbtn";
            CancelContactPersonbtn.Size = new Size(112, 40);
            CancelContactPersonbtn.TabIndex = 26;
            CancelContactPersonbtn.Text = "Cancel";
            CancelContactPersonbtn.UseVisualStyleBackColor = true;
            // 
            // SaveContactPersonbtn
            // 
            SaveContactPersonbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveContactPersonbtn.Location = new Point(134, 493);
            SaveContactPersonbtn.Name = "SaveContactPersonbtn";
            SaveContactPersonbtn.Size = new Size(112, 40);
            SaveContactPersonbtn.TabIndex = 25;
            SaveContactPersonbtn.Text = "Save";
            SaveContactPersonbtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(166, 34);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(268, 38);
            label6.TabIndex = 24;
            label6.Text = "Add ContactPerson";
            // 
            // ContactEmailtextBox
            // 
            ContactEmailtextBox.Location = new Point(316, 340);
            ContactEmailtextBox.Margin = new Padding(4);
            ContactEmailtextBox.Name = "ContactEmailtextBox";
            ContactEmailtextBox.Size = new Size(194, 31);
            ContactEmailtextBox.TabIndex = 20;
            // 
            // ContactPhonetextBox
            // 
            ContactPhonetextBox.Location = new Point(316, 226);
            ContactPhonetextBox.Margin = new Padding(4);
            ContactPhonetextBox.Name = "ContactPhonetextBox";
            ContactPhonetextBox.Size = new Size(194, 31);
            ContactPhonetextBox.TabIndex = 19;
            // 
            // ContactNametextBox
            // 
            ContactNametextBox.Location = new Point(316, 124);
            ContactNametextBox.Margin = new Padding(4);
            ContactNametextBox.Name = "ContactNametextBox";
            ContactNametextBox.Size = new Size(194, 31);
            ContactNametextBox.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(112, 337);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 32);
            label4.TabIndex = 17;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(112, 223);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 32);
            label3.TabIndex = 16;
            label3.Text = "Phone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(112, 128);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 32);
            label1.TabIndex = 14;
            label1.Text = " Name";
            // 
            // AddContactPersonForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 632);
            Controls.Add(CancelContactPersonbtn);
            Controls.Add(SaveContactPersonbtn);
            Controls.Add(label6);
            Controls.Add(ContactEmailtextBox);
            Controls.Add(ContactPhonetextBox);
            Controls.Add(ContactNametextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "AddContactPersonForm";
            Text = "AddContactPersonForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancelContactPersonbtn;
        private Button SaveContactPersonbtn;
        private Label label6;
        private TextBox ContactEmailtextBox;
        private TextBox ContactPhonetextBox;
        private TextBox ContactNametextBox;
        private Label label4;
        private Label label3;
        private Label label1;
    }
}