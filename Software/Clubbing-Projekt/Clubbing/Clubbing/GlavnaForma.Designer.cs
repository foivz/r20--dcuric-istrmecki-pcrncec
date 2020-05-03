namespace Clubbing
{
    partial class GlavnaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavnaForma));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButtonOdjava = new FontAwesome.Sharp.IconButton();
            this.iconButtonObavijest = new FontAwesome.Sharp.IconButton();
            this.iconButtonRezervacije = new FontAwesome.Sharp.IconButton();
            this.iconButtonDogadaji = new FontAwesome.Sharp.IconButton();
            this.iconButtonKlubovi = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.ButtonHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.iconMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.iconClose = new FontAwesome.Sharp.IconPictureBox();
            this.labelTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.iconButtonOdjava);
            this.panelMenu.Controls.Add(this.iconButtonObavijest);
            this.panelMenu.Controls.Add(this.iconButtonRezervacije);
            this.panelMenu.Controls.Add(this.iconButtonDogadaji);
            this.panelMenu.Controls.Add(this.iconButtonKlubovi);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 687);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMenu_Paint);
            // 
            // iconButtonOdjava
            // 
            this.iconButtonOdjava.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonOdjava.FlatAppearance.BorderSize = 0;
            this.iconButtonOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonOdjava.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonOdjava.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonOdjava.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.iconButtonOdjava.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonOdjava.IconSize = 32;
            this.iconButtonOdjava.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonOdjava.Location = new System.Drawing.Point(0, 380);
            this.iconButtonOdjava.Name = "iconButtonOdjava";
            this.iconButtonOdjava.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonOdjava.Rotation = 0D;
            this.iconButtonOdjava.Size = new System.Drawing.Size(220, 60);
            this.iconButtonOdjava.TabIndex = 6;
            this.iconButtonOdjava.Text = "Odjava";
            this.iconButtonOdjava.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonOdjava.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonOdjava.UseVisualStyleBackColor = true;
            this.iconButtonOdjava.Click += new System.EventHandler(this.IconButtonSetting_Click);
            // 
            // iconButtonObavijest
            // 
            this.iconButtonObavijest.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonObavijest.FlatAppearance.BorderSize = 0;
            this.iconButtonObavijest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonObavijest.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonObavijest.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonObavijest.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            this.iconButtonObavijest.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonObavijest.IconSize = 32;
            this.iconButtonObavijest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonObavijest.Location = new System.Drawing.Point(0, 320);
            this.iconButtonObavijest.Name = "iconButtonObavijest";
            this.iconButtonObavijest.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonObavijest.Rotation = 0D;
            this.iconButtonObavijest.Size = new System.Drawing.Size(220, 60);
            this.iconButtonObavijest.TabIndex = 5;
            this.iconButtonObavijest.Text = "Obavjesti";
            this.iconButtonObavijest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonObavijest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonObavijest.UseVisualStyleBackColor = true;
            this.iconButtonObavijest.Click += new System.EventHandler(this.IconButtonMarketing_Click);
            // 
            // iconButtonRezervacije
            // 
            this.iconButtonRezervacije.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonRezervacije.FlatAppearance.BorderSize = 0;
            this.iconButtonRezervacije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonRezervacije.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonRezervacije.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonRezervacije.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.iconButtonRezervacije.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonRezervacije.IconSize = 32;
            this.iconButtonRezervacije.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonRezervacije.Location = new System.Drawing.Point(0, 260);
            this.iconButtonRezervacije.Name = "iconButtonRezervacije";
            this.iconButtonRezervacije.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonRezervacije.Rotation = 0D;
            this.iconButtonRezervacije.Size = new System.Drawing.Size(220, 60);
            this.iconButtonRezervacije.TabIndex = 3;
            this.iconButtonRezervacije.Text = "Rezervacije";
            this.iconButtonRezervacije.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonRezervacije.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonRezervacije.UseVisualStyleBackColor = true;
            this.iconButtonRezervacije.Click += new System.EventHandler(this.IconButtonProducts_Click);
            // 
            // iconButtonDogadaji
            // 
            this.iconButtonDogadaji.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonDogadaji.FlatAppearance.BorderSize = 0;
            this.iconButtonDogadaji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDogadaji.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonDogadaji.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonDogadaji.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.iconButtonDogadaji.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonDogadaji.IconSize = 32;
            this.iconButtonDogadaji.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDogadaji.Location = new System.Drawing.Point(0, 200);
            this.iconButtonDogadaji.Name = "iconButtonDogadaji";
            this.iconButtonDogadaji.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonDogadaji.Rotation = 0D;
            this.iconButtonDogadaji.Size = new System.Drawing.Size(220, 60);
            this.iconButtonDogadaji.TabIndex = 2;
            this.iconButtonDogadaji.Text = "Događaji u klubovima";
            this.iconButtonDogadaji.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDogadaji.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDogadaji.UseVisualStyleBackColor = true;
            this.iconButtonDogadaji.Click += new System.EventHandler(this.IconButtonOrders_Click);
            // 
            // iconButtonKlubovi
            // 
            this.iconButtonKlubovi.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonKlubovi.FlatAppearance.BorderSize = 0;
            this.iconButtonKlubovi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonKlubovi.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonKlubovi.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonKlubovi.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.iconButtonKlubovi.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonKlubovi.IconSize = 32;
            this.iconButtonKlubovi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonKlubovi.Location = new System.Drawing.Point(0, 140);
            this.iconButtonKlubovi.Name = "iconButtonKlubovi";
            this.iconButtonKlubovi.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonKlubovi.Rotation = 0D;
            this.iconButtonKlubovi.Size = new System.Drawing.Size(220, 60);
            this.iconButtonKlubovi.TabIndex = 1;
            this.iconButtonKlubovi.Text = "Klubovi";
            this.iconButtonKlubovi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonKlubovi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonKlubovi.UseVisualStyleBackColor = true;
            this.iconButtonKlubovi.Click += new System.EventHandler(this.IconButtonDashboard_Click);
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
            this.panelTitleBar.Size = new System.Drawing.Size(1020, 75);
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
            this.iconMinimize.Location = new System.Drawing.Point(909, 3);
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
            this.iconMaximize.Location = new System.Drawing.Point(947, 3);
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
            this.iconClose.Location = new System.Drawing.Point(985, 3);
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
            this.iconCurrentChildForm.Location = new System.Drawing.Point(38, 34);
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
            this.panelShadow.Size = new System.Drawing.Size(1020, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1020, 603);
            this.panelDesktop.TabIndex = 3;
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1240, 687);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(1258, 734);
            this.Name = "GlavnaForma";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButtonObavijest;
        private FontAwesome.Sharp.IconButton iconButtonRezervacije;
        private FontAwesome.Sharp.IconButton iconButtonDogadaji;
        private FontAwesome.Sharp.IconButton iconButtonKlubovi;
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
        private FontAwesome.Sharp.IconButton iconButtonOdjava;
    }
}

