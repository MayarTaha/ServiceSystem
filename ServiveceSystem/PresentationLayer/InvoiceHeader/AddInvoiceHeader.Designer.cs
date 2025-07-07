namespace ServiveceSystem.PresentationLayer.InvoiceHeader
{
    partial class AddInvoiceHeader
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
            editFormUserControl1 = new DevExpress.XtraGrid.Views.Grid.EditFormUserControl();
            SuspendLayout();
            // 
            // editFormUserControl1
            // 
            editFormUserControl1.Appearance.BackColor = SystemColors.ActiveCaption;
            editFormUserControl1.Appearance.Options.UseBackColor = true;
            editFormUserControl1.Location = new Point(13, 14);
            editFormUserControl1.Margin = new Padding(4, 5, 4, 5);
            editFormUserControl1.Name = "editFormUserControl1";
            editFormUserControl1.Size = new Size(497, 352);
            editFormUserControl1.TabIndex = 0;
            editFormUserControl1.Load += editFormUserControl1_Load;
            // 
            // AddInvoiceHeader
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            editFormUserControl1.SetBoundPropertyName(this, "");
            ClientSize = new Size(1033, 653);
            Controls.Add(editFormUserControl1);
            Font = new Font("Segoe UI", 8F);
            Name = "AddInvoiceHeader";
            Text = "AddInvoiceHeader";
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.EditFormUserControl editFormUserControl1;
    }
}