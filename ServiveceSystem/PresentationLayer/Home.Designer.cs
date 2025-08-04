namespace ServiveceSystem.PresentationLayer
{
    partial class Home
    {
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl;
        private DevExpress.XtraBars.Navigation.AccordionControlElement servicesElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement clinicsElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement contactsElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement quotationsElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement invoicesElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement configurationElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement usersElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement paymentsElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement taxesElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement paymentMethodsElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement reportsElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement clientReportElement;
        private DevExpress.XtraEditors.PanelControl topPanel;
        private DevExpress.XtraEditors.SimpleButton btnMinimize;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.PanelControl mainPanel;
        private DevExpress.XtraEditors.SimpleButton btnMaximize;

        private void InitializeComponent()
        {
            accordionControl = new DevExpress.XtraBars.Navigation.AccordionControl();
            servicesElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            clinicsElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            contactsElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            quotationsElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            invoicesElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            configurationElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            usersElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            paymentsElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            paymentMethodsElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            taxesElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            reportsElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            clientReportElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            topPanel = new DevExpress.XtraEditors.PanelControl();
            btnMinimize = new DevExpress.XtraEditors.SimpleButton();
            btnMaximize = new DevExpress.XtraEditors.SimpleButton();
            btnClose = new DevExpress.XtraEditors.SimpleButton();
            lblTitle = new DevExpress.XtraEditors.LabelControl();
            mainPanel = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)accordionControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)topPanel).BeginInit();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainPanel).BeginInit();
            SuspendLayout();
            // 
            // accordionControl
            // 
            accordionControl.Dock = DockStyle.Left;
            accordionControl.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { servicesElement, clinicsElement, contactsElement, quotationsElement, invoicesElement, configurationElement, reportsElement });
            accordionControl.ItemHeight = 60;
            accordionControl.Location = new Point(0, 0);
            accordionControl.Name = "accordionControl";
            accordionControl.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            accordionControl.Size = new Size(171, 520);
            accordionControl.TabIndex = 0;
            accordionControl.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            accordionControl.ElementClick += accordionControl_ElementClick;
            accordionControl.Click += accordionControl_Click;
            // 
            // servicesElement
            // 
            servicesElement.Expanded = true;
            servicesElement.Height = 50;
            servicesElement.ImageOptions.Image = ServiceSystem.Properties.Resources.icons8_service_100;
            servicesElement.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Squeeze;
            servicesElement.Name = "servicesElement";
            servicesElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            servicesElement.Text = "Services";
            // 
            // clinicsElement
            // 
            clinicsElement.Height = 50;
            clinicsElement.ImageOptions.Image = ServiceSystem.Properties.Resources.icons8_clinic_100;
            clinicsElement.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Squeeze;
            clinicsElement.Name = "clinicsElement";
            clinicsElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            clinicsElement.Text = "Clinics";
            // 
            // contactsElement
            // 
            contactsElement.Height = 50;
            contactsElement.ImageOptions.Image = ServiceSystem.Properties.Resources.icons8_contacts_80;
            contactsElement.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Squeeze;
            contactsElement.Name = "contactsElement";
            contactsElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            contactsElement.Text = "Contact Persons";
            // 
            // quotationsElement
            // 
            quotationsElement.Height = 50;
            quotationsElement.ImageOptions.Image = ServiceSystem.Properties.Resources.icons8_offer_40;
            quotationsElement.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Squeeze;
            quotationsElement.Name = "quotationsElement";
            quotationsElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            quotationsElement.Text = "Quotations";
            // 
            // invoicesElement
            // 
            invoicesElement.Height = 50;
            invoicesElement.ImageOptions.Image = ServiceSystem.Properties.Resources.icons8_invoice_64;
            invoicesElement.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Squeeze;
            invoicesElement.Name = "invoicesElement";
            invoicesElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            invoicesElement.Text = "Invoices";
            // 
            // configurationElement
            // 
            configurationElement.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { usersElement, paymentsElement, paymentMethodsElement, taxesElement });
            configurationElement.Expanded = true;
            configurationElement.Height = 50;
            configurationElement.ImageOptions.Image = ServiceSystem.Properties.Resources.icons8_settings_80;
            configurationElement.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Squeeze;
            configurationElement.Name = "configurationElement";
            configurationElement.Text = "Configuration";
            // 
            // usersElement
            // 
            usersElement.Height = 40;
            usersElement.ImageOptions.Image = ServiceSystem.Properties.Resources.icons8_quotation_64;
            usersElement.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Squeeze;
            usersElement.Name = "usersElement";
            usersElement.Text = "Users";
            // 
            // paymentsElement
            // 
            paymentsElement.Height = 40;
            paymentsElement.ImageOptions.Image = ServiceSystem.Properties.Resources.icons8_payment_100;
            paymentsElement.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Squeeze;
            paymentsElement.Name = "paymentsElement";
            paymentsElement.Text = "Payments";
            // 
            // paymentMethodsElement
            // 
            paymentMethodsElement.Height = 40;
            paymentMethodsElement.ImageOptions.Image = ServiceSystem.Properties.Resources.icons8_payment_100;
            paymentMethodsElement.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Squeeze;
            paymentMethodsElement.Name = "paymentMethodsElement";
            paymentMethodsElement.Text = "Payment Methods";
            // 
            // taxesElement
            // 
            taxesElement.Height = 40;
            taxesElement.ImageOptions.Image = ServiceSystem.Properties.Resources.icons8_taxes_64;
            taxesElement.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Squeeze;
            taxesElement.Name = "taxesElement";
            taxesElement.Text = "Taxes";
            // 
            // reportsElement
            // 
            reportsElement.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { clientReportElement });
            reportsElement.Expanded = true;
            reportsElement.Height = 50;
            reportsElement.ImageOptions.Image = ServiceSystem.Properties.Resources.icons8_invoice_64;
            reportsElement.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Squeeze;
            reportsElement.Name = "reportsElement";
            reportsElement.Text = "Reports";
            // 
            // clientReportElement
            // 
            clientReportElement.Height = 40;
            clientReportElement.ImageOptions.Image = ServiceSystem.Properties.Resources.icons8_clinic_100;
            clientReportElement.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Squeeze;
            clientReportElement.Name = "clientReportElement";
            clientReportElement.Text = "Client Report";
            // 
            // topPanel
            // 
            topPanel.Controls.Add(btnMinimize);
            topPanel.Controls.Add(btnMaximize);
            topPanel.Controls.Add(btnClose);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(171, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(686, 43);
            topPanel.TabIndex = 1;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.Location = new Point(566, 9);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(34, 26);
            btnMinimize.TabIndex = 0;
            btnMinimize.Text = "_";
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.Location = new Point(609, 9);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(34, 26);
            btnMaximize.TabIndex = 1;
            btnMaximize.Text = "⬜";
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Location = new Point(651, 9);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(34, 26);
            btnClose.TabIndex = 2;
            btnClose.Text = "X";
            btnClose.Click += btnClose_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.Appearance.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Appearance.Options.UseFont = true;
            lblTitle.Location = new Point(300, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 32);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Home";
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(171, 43);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(686, 477);
            mainPanel.TabIndex = 2;
            // 
            // Home
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 520);
            Controls.Add(mainPanel);
            Controls.Add(topPanel);
            Controls.Add(accordionControl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)accordionControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)topPanel).EndInit();
            topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainPanel).EndInit();
            ResumeLayout(false);
        }
    }
} 