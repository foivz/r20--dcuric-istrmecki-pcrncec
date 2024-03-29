﻿namespace Clubbing.Forme
{
    partial class FormaGalerija
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
            this.labelNaslov = new System.Windows.Forms.Label();
            this.BtnDodajSliku = new System.Windows.Forms.Button();
            this.BtnObrisiSliku = new System.Windows.Forms.Button();
            this.BtnPrethodna = new System.Windows.Forms.Button();
            this.BtnSljedecaSlika = new System.Windows.Forms.Button();
            this.BtnPrethodnaSlika = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNaslov
            // 
            this.labelNaslov.AutoSize = true;
            this.labelNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNaslov.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelNaslov.Location = new System.Drawing.Point(40, 26);
            this.labelNaslov.Name = "labelNaslov";
            this.labelNaslov.Size = new System.Drawing.Size(75, 20);
            this.labelNaslov.TabIndex = 0;
            this.labelNaslov.Text = "Galerija";
            // 
            // BtnDodajSliku
            // 
            this.BtnDodajSliku.Location = new System.Drawing.Point(44, 345);
            this.BtnDodajSliku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDodajSliku.Name = "BtnDodajSliku";
            this.BtnDodajSliku.Size = new System.Drawing.Size(111, 39);
            this.BtnDodajSliku.TabIndex = 2;
            this.BtnDodajSliku.Text = "Dodaj sliku";
            this.BtnDodajSliku.UseVisualStyleBackColor = true;
            this.BtnDodajSliku.Click += new System.EventHandler(this.BtnDodajSliku_Click);
            // 
            // BtnObrisiSliku
            // 
            this.BtnObrisiSliku.Location = new System.Drawing.Point(179, 345);
            this.BtnObrisiSliku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnObrisiSliku.Name = "BtnObrisiSliku";
            this.BtnObrisiSliku.Size = new System.Drawing.Size(111, 39);
            this.BtnObrisiSliku.TabIndex = 3;
            this.BtnObrisiSliku.Text = "Obriši sliku";
            this.BtnObrisiSliku.UseVisualStyleBackColor = true;
            this.BtnObrisiSliku.Click += new System.EventHandler(this.BtnObrisiSliku_Click);
            // 
            // BtnPrethodna
            // 
            this.BtnPrethodna.Location = new System.Drawing.Point(28, 425);
            this.BtnPrethodna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnPrethodna.Name = "BtnPrethodna";
            this.BtnPrethodna.Size = new System.Drawing.Size(111, 39);
            this.BtnPrethodna.TabIndex = 4;
            this.BtnPrethodna.Text = "Povratak";
            this.BtnPrethodna.UseVisualStyleBackColor = true;
            this.BtnPrethodna.Click += new System.EventHandler(this.BtnPrethodna_Click);
            // 
            // BtnSljedecaSlika
            // 
            this.BtnSljedecaSlika.Location = new System.Drawing.Point(669, 374);
            this.BtnSljedecaSlika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSljedecaSlika.Name = "BtnSljedecaSlika";
            this.BtnSljedecaSlika.Size = new System.Drawing.Size(83, 37);
            this.BtnSljedecaSlika.TabIndex = 5;
            this.BtnSljedecaSlika.Text = "->";
            this.BtnSljedecaSlika.UseVisualStyleBackColor = true;
            this.BtnSljedecaSlika.Click += new System.EventHandler(this.BtnSljedecaSlika_Click);
            // 
            // BtnPrethodnaSlika
            // 
            this.BtnPrethodnaSlika.Location = new System.Drawing.Point(555, 374);
            this.BtnPrethodnaSlika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnPrethodnaSlika.Name = "BtnPrethodnaSlika";
            this.BtnPrethodnaSlika.Size = new System.Drawing.Size(83, 37);
            this.BtnPrethodnaSlika.TabIndex = 6;
            this.BtnPrethodnaSlika.Text = "<-";
            this.BtnPrethodnaSlika.UseVisualStyleBackColor = true;
            this.BtnPrethodnaSlika.Click += new System.EventHandler(this.BtnPrethodnaSlika_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(44, 74);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(708, 236);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // FormaGalerija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.BtnPrethodnaSlika);
            this.Controls.Add(this.BtnSljedecaSlika);
            this.Controls.Add(this.BtnPrethodna);
            this.Controls.Add(this.BtnObrisiSliku);
            this.Controls.Add(this.BtnDodajSliku);
            this.Controls.Add(this.labelNaslov);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormaGalerija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Galerija";
            this.Load += new System.EventHandler(this.FormaGalerija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNaslov;
        private System.Windows.Forms.Button BtnDodajSliku;
        private System.Windows.Forms.Button BtnObrisiSliku;
        private System.Windows.Forms.Button BtnPrethodna;
        private System.Windows.Forms.Button BtnSljedecaSlika;
        private System.Windows.Forms.Button BtnPrethodnaSlika;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}