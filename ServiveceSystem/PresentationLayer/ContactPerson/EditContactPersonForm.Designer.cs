namespace ServiveceSystem.PresentationLayer.ContactPerson
{
    partial class EditContactPersonForm
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
            Cancelbtn = new Button();
            Savebtn = new Button();
            label1 = new Label();
            EditContactEmailtextBox = new TextBox();
            EditContactPhonetextBox = new TextBox();
            EditContactNametextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // Cancelbtn
            // 
            Cancelbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Cancelbtn.Location = new Point(360, 510);
            Cancelbtn.Name = "Cancelbtn";
            Cancelbtn.Size = new Size(112, 40);
            Cancelbtn.TabIndex = 50;
            Cancelbtn.Text = "Cancel";
            Cancelbtn.UseVisualStyleBackColor = true;
            // 
            // Savebtn
            // 
            Savebtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Savebtn.Location = new Point(123, 510);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(112, 40);
            Savebtn.TabIndex = 49;
            Savebtn.Text = "Save";
            Savebtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(154, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(265, 38);
            label1.TabIndex = 48;
            label1.Text = "Edit ContactPerson";
            // 
            // EditContactEmailtextBox
            // 
            EditContactEmailtextBox.Location = new Point(329, 333);
            EditContactEmailtextBox.Margin = new Padding(4);
            EditContactEmailtextBox.Name = "EditContactEmailtextBox";
            EditContactEmailtextBox.Size = new Size(194, 31);
            EditContactEmailtextBox.TabIndex = 44;
            // 
            // EditContactPhonetextBox
            // 
            EditContactPhonetextBox.Location = new Point(329, 227);
            EditContactPhonetextBox.Margin = new Padding(4);
            EditContactPhonetextBox.Name = "EditContactPhonetextBox";
            EditContactPhonetextBox.Size = new Size(194, 31);
            EditContactPhonetextBox.TabIndex = 43;
            // 
            // EditContactNametextBox
            // 
            EditContactNametextBox.Location = new Point(329, 130);
            EditContactNametextBox.Margin = new Padding(4);
            EditContactNametextBox.Name = "EditContactNametextBox";
            EditContactNametextBox.Size = new Size(194, 31);
            EditContactNametextBox.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(99, 327);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 36);
            label4.TabIndex = 41;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(99, 221);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 36);
            label3.TabIndex = 40;
            label3.Text = "Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F);
            label7.Location = new Point(99, 124);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(90, 36);
            label7.TabIndex = 38;
            label7.Text = " Name";
            // 
            // EditContactPersonForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 632);
            Controls.Add(Cancelbtn);
            Controls.Add(Savebtn);
            Controls.Add(label1);
            Controls.Add(EditContactEmailtextBox);
            Controls.Add(EditContactPhonetextBox);
            Controls.Add(EditContactNametextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label7);
            Name = "EditContactPersonForm";
            Text = "EditContactPersonForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cancelbtn;
        private Button Savebtn;
        private Label label1;
        private TextBox EditContactEmailtextBox;
        private TextBox EditContactPhonetextBox;
        private TextBox EditContactNametextBox;
        private Label label4;
        private Label label3;
        private Label label7;
    }
}