namespace Clubbing.Forms
{
    partial class FormKlubovi
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.dataGridViewKlubovi = new System.Windows.Forms.DataGridView();
            this.iconButtonPrikazGalerije = new FontAwesome.Sharp.IconButton();
            this.iconButtonPrikazi = new FontAwesome.Sharp.IconButton();
            this.iconButtonPrikazLokacijeKluba = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKlubovi)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBox1.Location = new System.Drawing.Point(70, 70);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Rock";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBox2.Location = new System.Drawing.Point(70, 97);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(55, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Pop";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBox3.Location = new System.Drawing.Point(70, 124);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(120, 21);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Strana muzika";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBox4.Location = new System.Drawing.Point(70, 151);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(133, 21);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Narodna muzika";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBox5.Location = new System.Drawing.Point(70, 178);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(62, 21);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Rock";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // dataGridViewKlubovi
            // 
            this.dataGridViewKlubovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKlubovi.Location = new System.Drawing.Point(268, 12);
            this.dataGridViewKlubovi.Name = "dataGridViewKlubovi";
            this.dataGridViewKlubovi.RowHeadersWidth = 51;
            this.dataGridViewKlubovi.RowTemplate.Height = 24;
            this.dataGridViewKlubovi.Size = new System.Drawing.Size(520, 176);
            this.dataGridViewKlubovi.TabIndex = 5;
            // 
            // iconButtonPrikazGalerije
            // 
            this.iconButtonPrikazGalerije.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonPrikazGalerije.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonPrikazGalerije.IconColor = System.Drawing.Color.Black;
            this.iconButtonPrikazGalerije.IconSize = 16;
            this.iconButtonPrikazGalerije.Location = new System.Drawing.Point(629, 205);
            this.iconButtonPrikazGalerije.Name = "iconButtonPrikazGalerije";
            this.iconButtonPrikazGalerije.Rotation = 0D;
            this.iconButtonPrikazGalerije.Size = new System.Drawing.Size(159, 35);
            this.iconButtonPrikazGalerije.TabIndex = 7;
            this.iconButtonPrikazGalerije.Text = "Prikaži galeriju slika";
            this.iconButtonPrikazGalerije.UseVisualStyleBackColor = true;
            this.iconButtonPrikazGalerije.Click += new System.EventHandler(this.IconButton1_Click);
            // 
            // iconButtonPrikazi
            // 
            this.iconButtonPrikazi.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonPrikazi.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonPrikazi.IconColor = System.Drawing.Color.Black;
            this.iconButtonPrikazi.IconSize = 16;
            this.iconButtonPrikazi.Location = new System.Drawing.Point(70, 220);
            this.iconButtonPrikazi.Name = "iconButtonPrikazi";
            this.iconButtonPrikazi.Rotation = 0D;
            this.iconButtonPrikazi.Size = new System.Drawing.Size(153, 38);
            this.iconButtonPrikazi.TabIndex = 6;
            this.iconButtonPrikazi.Text = "Prikaži";
            this.iconButtonPrikazi.UseVisualStyleBackColor = true;
            // 
            // iconButtonPrikazLokacijeKluba
            // 
            this.iconButtonPrikazLokacijeKluba.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonPrikazLokacijeKluba.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonPrikazLokacijeKluba.IconColor = System.Drawing.Color.Black;
            this.iconButtonPrikazLokacijeKluba.IconSize = 16;
            this.iconButtonPrikazLokacijeKluba.Location = new System.Drawing.Point(629, 256);
            this.iconButtonPrikazLokacijeKluba.Name = "iconButtonPrikazLokacijeKluba";
            this.iconButtonPrikazLokacijeKluba.Rotation = 0D;
            this.iconButtonPrikazLokacijeKluba.Size = new System.Drawing.Size(159, 35);
            this.iconButtonPrikazLokacijeKluba.TabIndex = 8;
            this.iconButtonPrikazLokacijeKluba.Text = "Prikaži lokaciju kluba";
            this.iconButtonPrikazLokacijeKluba.UseVisualStyleBackColor = true;
            // 
            // FormKlubovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iconButtonPrikazLokacijeKluba);
            this.Controls.Add(this.iconButtonPrikazGalerije);
            this.Controls.Add(this.iconButtonPrikazi);
            this.Controls.Add(this.dataGridViewKlubovi);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "FormKlubovi";
            this.Text = "Klubovi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKlubovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.DataGridView dataGridViewKlubovi;
        private FontAwesome.Sharp.IconButton iconButtonPrikazi;
        private FontAwesome.Sharp.IconButton iconButtonPrikazGalerije;
        private FontAwesome.Sharp.IconButton iconButtonPrikazLokacijeKluba;
    }
}