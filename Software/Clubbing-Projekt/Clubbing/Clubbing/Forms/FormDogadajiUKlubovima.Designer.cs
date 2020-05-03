namespace Clubbing.Forms
{
    partial class FormDogadajiUKlubovima
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iconButtonPregledDogadaja = new FontAwesome.Sharp.IconButton();
            this.iconButtonGalerijaSlika = new FontAwesome.Sharp.IconButton();
            this.iconButtonRezervacija = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(363, 218);
            this.dataGridView1.TabIndex = 0;
            // 
            // iconButtonPregledDogadaja
            // 
            this.iconButtonPregledDogadaja.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonPregledDogadaja.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonPregledDogadaja.IconColor = System.Drawing.Color.Black;
            this.iconButtonPregledDogadaja.IconSize = 16;
            this.iconButtonPregledDogadaja.Location = new System.Drawing.Point(417, 12);
            this.iconButtonPregledDogadaja.Name = "iconButtonPregledDogadaja";
            this.iconButtonPregledDogadaja.Rotation = 0D;
            this.iconButtonPregledDogadaja.Size = new System.Drawing.Size(142, 37);
            this.iconButtonPregledDogadaja.TabIndex = 1;
            this.iconButtonPregledDogadaja.Text = "Pregled događaja";
            this.iconButtonPregledDogadaja.UseVisualStyleBackColor = true;
            // 
            // iconButtonGalerijaSlika
            // 
            this.iconButtonGalerijaSlika.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonGalerijaSlika.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonGalerijaSlika.IconColor = System.Drawing.Color.Black;
            this.iconButtonGalerijaSlika.IconSize = 16;
            this.iconButtonGalerijaSlika.Location = new System.Drawing.Point(417, 85);
            this.iconButtonGalerijaSlika.Name = "iconButtonGalerijaSlika";
            this.iconButtonGalerijaSlika.Rotation = 0D;
            this.iconButtonGalerijaSlika.Size = new System.Drawing.Size(142, 37);
            this.iconButtonGalerijaSlika.TabIndex = 2;
            this.iconButtonGalerijaSlika.Text = "Pregled slika";
            this.iconButtonGalerijaSlika.UseVisualStyleBackColor = true;
            // 
            // iconButtonRezervacija
            // 
            this.iconButtonRezervacija.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonRezervacija.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonRezervacija.IconColor = System.Drawing.Color.Black;
            this.iconButtonRezervacija.IconSize = 16;
            this.iconButtonRezervacija.Location = new System.Drawing.Point(417, 160);
            this.iconButtonRezervacija.Name = "iconButtonRezervacija";
            this.iconButtonRezervacija.Rotation = 0D;
            this.iconButtonRezervacija.Size = new System.Drawing.Size(142, 37);
            this.iconButtonRezervacija.TabIndex = 3;
            this.iconButtonRezervacija.Text = "Rezervacija";
            this.iconButtonRezervacija.UseVisualStyleBackColor = true;
            this.iconButtonRezervacija.Click += new System.EventHandler(this.IconButtonRezervacija_Click);
            // 
            // FormDogadajiUKlubovima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iconButtonRezervacija);
            this.Controls.Add(this.iconButtonGalerijaSlika);
            this.Controls.Add(this.iconButtonPregledDogadaja);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDogadajiUKlubovima";
            this.Text = "Događaji u klubovima";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton iconButtonPregledDogadaja;
        private FontAwesome.Sharp.IconButton iconButtonGalerijaSlika;
        private FontAwesome.Sharp.IconButton iconButtonRezervacija;
    }
}