namespace Clubbing.Forme
{
    partial class FormaKlub
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
            this.labelMaxKapacitet = new System.Windows.Forms.Label();
            this.labelImeKluba = new System.Windows.Forms.Label();
            this.BtnOcijeni = new System.Windows.Forms.Button();
            this.BtnPrati = new System.Windows.Forms.Button();
            this.BtnPovratak = new System.Windows.Forms.Button();
            this.BtnLokacija = new System.Windows.Forms.Button();
            this.BtnOtvoriDogadjaje = new System.Windows.Forms.Button();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMaxKapacitet
            // 
            this.labelMaxKapacitet.AutoSize = true;
            this.labelMaxKapacitet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxKapacitet.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelMaxKapacitet.Location = new System.Drawing.Point(22, 76);
            this.labelMaxKapacitet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaxKapacitet.Name = "labelMaxKapacitet";
            this.labelMaxKapacitet.Size = new System.Drawing.Size(187, 20);
            this.labelMaxKapacitet.TabIndex = 1;
            this.labelMaxKapacitet.Text = "Maksimalni kapcitet: ";
            // 
            // labelImeKluba
            // 
            this.labelImeKluba.AutoSize = true;
            this.labelImeKluba.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImeKluba.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelImeKluba.Location = new System.Drawing.Point(22, 30);
            this.labelImeKluba.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelImeKluba.Name = "labelImeKluba";
            this.labelImeKluba.Size = new System.Drawing.Size(101, 20);
            this.labelImeKluba.TabIndex = 3;
            this.labelImeKluba.Text = "Ime kluba: ";
            // 
            // BtnOcijeni
            // 
            this.BtnOcijeni.Location = new System.Drawing.Point(36, 192);
            this.BtnOcijeni.Margin = new System.Windows.Forms.Padding(2);
            this.BtnOcijeni.Name = "BtnOcijeni";
            this.BtnOcijeni.Size = new System.Drawing.Size(119, 38);
            this.BtnOcijeni.TabIndex = 6;
            this.BtnOcijeni.Text = "Dodaj recenziju";
            this.BtnOcijeni.UseVisualStyleBackColor = true;
            this.BtnOcijeni.Click += new System.EventHandler(this.BtnOcijeni_Click);
            // 
            // BtnPrati
            // 
            this.BtnPrati.Location = new System.Drawing.Point(230, 192);
            this.BtnPrati.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPrati.Name = "BtnPrati";
            this.BtnPrati.Size = new System.Drawing.Size(106, 38);
            this.BtnPrati.TabIndex = 7;
            this.BtnPrati.Text = "Zaprati klub";
            this.BtnPrati.UseVisualStyleBackColor = true;
            this.BtnPrati.Click += new System.EventHandler(this.BtnPrati_Click);
            // 
            // BtnPovratak
            // 
            this.BtnPovratak.Location = new System.Drawing.Point(25, 303);
            this.BtnPovratak.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPovratak.Name = "BtnPovratak";
            this.BtnPovratak.Size = new System.Drawing.Size(107, 38);
            this.BtnPovratak.TabIndex = 9;
            this.BtnPovratak.Text = "Povratak";
            this.BtnPovratak.UseVisualStyleBackColor = true;
            this.BtnPovratak.Click += new System.EventHandler(this.BtnPovratak_Click);
            // 
            // BtnLokacija
            // 
            this.BtnLokacija.Location = new System.Drawing.Point(417, 192);
            this.BtnLokacija.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLokacija.Name = "BtnLokacija";
            this.BtnLokacija.Size = new System.Drawing.Size(117, 38);
            this.BtnLokacija.TabIndex = 10;
            this.BtnLokacija.Text = "Prikaži lokaciju";
            this.BtnLokacija.UseVisualStyleBackColor = true;
            this.BtnLokacija.Click += new System.EventHandler(this.BtnLokacija_Click);
            // 
            // BtnOtvoriDogadjaje
            // 
            this.BtnOtvoriDogadjaje.Location = new System.Drawing.Point(435, 303);
            this.BtnOtvoriDogadjaje.Margin = new System.Windows.Forms.Padding(2);
            this.BtnOtvoriDogadjaje.Name = "BtnOtvoriDogadjaje";
            this.BtnOtvoriDogadjaje.Size = new System.Drawing.Size(140, 38);
            this.BtnOtvoriDogadjaje.TabIndex = 11;
            this.BtnOtvoriDogadjaje.Text = "Pregled događaja";
            this.BtnOtvoriDogadjaje.UseVisualStyleBackColor = true;
            this.BtnOtvoriDogadjaje.Click += new System.EventHandler(this.BtnOtvoriDogadjaje_Click);
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelAdmin.Location = new System.Drawing.Point(22, 124);
            this.labelAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(123, 20);
            this.labelAdmin.TabIndex = 12;
            this.labelAdmin.Text = "Admin kluba: ";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(332, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(235, 150);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 13;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormaKlub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelAdmin);
            this.Controls.Add(this.BtnOtvoriDogadjaje);
            this.Controls.Add(this.BtnLokacija);
            this.Controls.Add(this.BtnPovratak);
            this.Controls.Add(this.BtnPrati);
            this.Controls.Add(this.BtnOcijeni);
            this.Controls.Add(this.labelImeKluba);
            this.Controls.Add(this.labelMaxKapacitet);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormaKlub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormaKlub";
            this.Load += new System.EventHandler(this.FormaKlub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMaxKapacitet;
        private System.Windows.Forms.Label labelImeKluba;
        private System.Windows.Forms.Button BtnOcijeni;
        private System.Windows.Forms.Button BtnPrati;
        private System.Windows.Forms.Button BtnPovratak;
        private System.Windows.Forms.Button BtnLokacija;
        private System.Windows.Forms.Button BtnOtvoriDogadjaje;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}