namespace Clubbing
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButtonSetting = new FontAwesome.Sharp.IconButton();
            this.iconButtonMarketing = new FontAwesome.Sharp.IconButton();
            this.iconButtonCustomers = new FontAwesome.Sharp.IconButton();
            this.iconButtonProducts = new FontAwesome.Sharp.IconButton();
            this.iconButtonOrders = new FontAwesome.Sharp.IconButton();
            this.iconButtonDashboardd = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.iconMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.iconClose = new FontAwesome.Sharp.IconPictureBox();
            this.labelTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.ButtonHome = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.iconButtonSetting);
            this.panelMenu.Controls.Add(this.iconButtonMarketing);
            this.panelMenu.Controls.Add(this.iconButtonCustomers);
            this.panelMenu.Controls.Add(this.iconButtonProducts);
            this.panelMenu.Controls.Add(this.iconButtonOrders);
            this.panelMenu.Controls.Add(this.iconButtonDashboardd);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 573);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMenu_Paint);
            // 
            // iconButtonSetting
            // 
            this.iconButtonSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonSetting.FlatAppearance.BorderSize = 0;
            this.iconButtonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSetting.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonSetting.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSetting.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.iconButtonSetting.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSetting.IconSize = 32;
            this.iconButtonSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSetting.Location = new System.Drawing.Point(0, 440);
            this.iconButtonSetting.Name = "iconButtonSetting";
            this.iconButtonSetting.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonSetting.Rotation = 0D;
            this.iconButtonSetting.Size = new System.Drawing.Size(220, 60);
            this.iconButtonSetting.TabIndex = 6;
            this.iconButtonSetting.Text = "Setting";
            this.iconButtonSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSetting.UseVisualStyleBackColor = true;
            this.iconButtonSetting.Click += new System.EventHandler(this.IconButtonSetting_Click);
            // 
            // iconButtonMarketing
            // 
            this.iconButtonMarketing.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonMarketing.FlatAppearance.BorderSize = 0;
            this.iconButtonMarketing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMarketing.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonMarketing.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonMarketing.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            this.iconButtonMarketing.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonMarketing.IconSize = 32;
            this.iconButtonMarketing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMarketing.Location = new System.Drawing.Point(0, 380);
            this.iconButtonMarketing.Name = "iconButtonMarketing";
            this.iconButtonMarketing.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonMarketing.Rotation = 0D;
            this.iconButtonMarketing.Size = new System.Drawing.Size(220, 60);
            this.iconButtonMarketing.TabIndex = 5;
            this.iconButtonMarketing.Text = "Marketing";
            this.iconButtonMarketing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMarketing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonMarketing.UseVisualStyleBackColor = true;
            this.iconButtonMarketing.Click += new System.EventHandler(this.IconButtonMarketing_Click);
            // 
            // iconButtonCustomers
            // 
            this.iconButtonCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonCustomers.FlatAppearance.BorderSize = 0;
            this.iconButtonCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCustomers.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonCustomers.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonCustomers.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.iconButtonCustomers.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonCustomers.IconSize = 32;
            this.iconButtonCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCustomers.Location = new System.Drawing.Point(0, 320);
            this.iconButtonCustomers.Name = "iconButtonCustomers";
            this.iconButtonCustomers.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonCustomers.Rotation = 0D;
            this.iconButtonCustomers.Size = new System.Drawing.Size(220, 60);
            this.iconButtonCustomers.TabIndex = 4;
            this.iconButtonCustomers.Text = "Customers";
            this.iconButtonCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCustomers.UseVisualStyleBackColor = true;
            this.iconButtonCustomers.Click += new System.EventHandler(this.IconButtonCustomers_Click);
            // 
            // iconButtonProducts
            // 
            this.iconButtonProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonProducts.FlatAppearance.BorderSize = 0;
            this.iconButtonProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonProducts.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonProducts.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonProducts.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.iconButtonProducts.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonProducts.IconSize = 32;
            this.iconButtonProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonProducts.Location = new System.Drawing.Point(0, 260);
            this.iconButtonProducts.Name = "iconButtonProducts";
            this.iconButtonProducts.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonProducts.Rotation = 0D;
            this.iconButtonProducts.Size = new System.Drawing.Size(220, 60);
            this.iconButtonProducts.TabIndex = 3;
            this.iconButtonProducts.Text = "Products";
            this.iconButtonProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonProducts.UseVisualStyleBackColor = true;
            this.iconButtonProducts.Click += new System.EventHandler(this.IconButtonProducts_Click);
            // 
            // iconButtonOrders
            // 
            this.iconButtonOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonOrders.FlatAppearance.BorderSize = 0;
            this.iconButtonOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonOrders.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonOrders.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonOrders.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.iconButtonOrders.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonOrders.IconSize = 32;
            this.iconButtonOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonOrders.Location = new System.Drawing.Point(0, 200);
            this.iconButtonOrders.Name = "iconButtonOrders";
            this.iconButtonOrders.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonOrders.Rotation = 0D;
            this.iconButtonOrders.Size = new System.Drawing.Size(220, 60);
            this.iconButtonOrders.TabIndex = 2;
            this.iconButtonOrders.Text = "Orders";
            this.iconButtonOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonOrders.UseVisualStyleBackColor = true;
            this.iconButtonOrders.Click += new System.EventHandler(this.IconButtonOrders_Click);
            // 
            // iconButtonDashboardd
            // 
            this.iconButtonDashboardd.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonDashboardd.FlatAppearance.BorderSize = 0;
            this.iconButtonDashboardd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDashboardd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonDashboardd.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonDashboardd.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.iconButtonDashboardd.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonDashboardd.IconSize = 32;
            this.iconButtonDashboardd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDashboardd.Location = new System.Drawing.Point(0, 140);
            this.iconButtonDashboardd.Name = "iconButtonDashboardd";
            this.iconButtonDashboardd.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonDashboardd.Rotation = 0D;
            this.iconButtonDashboardd.Size = new System.Drawing.Size(220, 60);
            this.iconButtonDashboardd.TabIndex = 1;
            this.iconButtonDashboardd.Text = "Dashboard";
            this.iconButtonDashboardd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDashboardd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDashboardd.UseVisualStyleBackColor = true;
            this.iconButtonDashboardd.Click += new System.EventHandler(this.IconButtonDashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.ButtonHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.iconMinimize);
            this.panelTitleBar.Controls.Add(this.iconMaximize);
            this.panelTitleBar.Controls.Add(this.iconClose);
            this.panelTitleBar.Controls.Add(this.labelTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(698, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitleBar_MouseDown);
            // 
            // iconMinimize
            // 
            this.iconMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconMinimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.iconMinimize.Location = new System.Drawing.Point(587, 3);
            this.iconMinimize.Name = "iconMinimize";
            this.iconMinimize.Size = new System.Drawing.Size(32, 32);
            this.iconMinimize.TabIndex = 4;
            this.iconMinimize.TabStop = false;
            this.iconMinimize.Click += new System.EventHandler(this.IconMinimize_Click);
            // 
            // iconMaximize
            // 
            this.iconMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconMaximize.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.iconMaximize.Location = new System.Drawing.Point(625, 3);
            this.iconMaximize.Name = "iconMaximize";
            this.iconMaximize.Size = new System.Drawing.Size(32, 32);
            this.iconMaximize.TabIndex = 3;
            this.iconMaximize.TabStop = false;
            this.iconMaximize.Click += new System.EventHandler(this.IconMaximize_Click);
            // 
            // iconClose
            // 
            this.iconClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconClose.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconClose.IconColor = System.Drawing.Color.Gainsboro;
            this.iconClose.Location = new System.Drawing.Point(663, 3);
            this.iconClose.Name = "iconClose";
            this.iconClose.Size = new System.Drawing.Size(32, 32);
            this.iconClose.TabIndex = 2;
            this.iconClose.TabStop = false;
            this.iconClose.Click += new System.EventHandler(this.IconClose_Click);
            // 
            // labelTitleChildForm
            // 
            this.labelTitleChildForm.AutoSize = true;
            this.labelTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitleChildForm.Location = new System.Drawing.Point(76, 34);
            this.labelTitleChildForm.Name = "labelTitleChildForm";
            this.labelTitleChildForm.Size = new System.Drawing.Size(45, 17);
            this.labelTitleChildForm.TabIndex = 1;
            this.labelTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(37, 27);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(698, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(698, 489);
            this.panelDesktop.TabIndex = 3;
            // 
            // ButtonHome
            // 
            this.ButtonHome.Image = ((System.Drawing.Image)(resources.GetObject("ButtonHome.Image")));
            this.ButtonHome.Location = new System.Drawing.Point(3, 3);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(211, 131);
            this.ButtonHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonHome.TabIndex = 0;
            this.ButtonHome.TabStop = false;
            this.ButtonHome.Click += new System.EventHandler(this.ButtonHome_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(918, 573);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(936, 620);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButtonSetting;
        private FontAwesome.Sharp.IconButton iconButtonMarketing;
        private FontAwesome.Sharp.IconButton iconButtonCustomers;
        private FontAwesome.Sharp.IconButton iconButtonProducts;
        private FontAwesome.Sharp.IconButton iconButtonOrders;
        private FontAwesome.Sharp.IconButton iconButtonDashboardd;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label labelTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox iconClose;
        private FontAwesome.Sharp.IconPictureBox iconMaximize;
        private FontAwesome.Sharp.IconPictureBox iconMinimize;
        private System.Windows.Forms.PictureBox ButtonHome;
    }
}

