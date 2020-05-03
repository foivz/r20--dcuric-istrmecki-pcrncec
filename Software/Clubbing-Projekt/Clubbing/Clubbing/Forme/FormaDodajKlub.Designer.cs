namespace Clubbing.Forme
{
    partial class FormaDodajKlub
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
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.textBoxKapacitet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDodajKlub = new System.Windows.Forms.Button();
            this.BtnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(47, 76);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(163, 22);
            this.textBoxNaziv.TabIndex = 0;
            // 
            // textBoxKapacitet
            // 
            this.textBoxKapacitet.Location = new System.Drawing.Point(47, 174);
            this.textBoxKapacitet.Name = "textBoxKapacitet";
            this.textBoxKapacitet.Size = new System.Drawing.Size(163, 22);
            this.textBoxKapacitet.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(82, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Naziv kluba";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(91, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kapacitet";
            // 
            // BtnDodajKlub
            // 
            this.BtnDodajKlub.Location = new System.Drawing.Point(276, 71);
            this.BtnDodajKlub.Name = "BtnDodajKlub";
            this.BtnDodajKlub.Size = new System.Drawing.Size(121, 40);
            this.BtnDodajKlub.TabIndex = 5;
            this.BtnDodajKlub.Text = "Dodaj klub";
            this.BtnDodajKlub.UseVisualStyleBackColor = true;
            this.BtnDodajKlub.Click += new System.EventHandler(this.BtnDodajKlub_Click);
            // 
            // BtnOdustani
            // 
            this.BtnOdustani.Location = new System.Drawing.Point(276, 160);
            this.BtnOdustani.Name = "BtnOdustani";
            this.BtnOdustani.Size = new System.Drawing.Size(121, 40);
            this.BtnOdustani.TabIndex = 6;
            this.BtnOdustani.Text = "Odustani";
            this.BtnOdustani.UseVisualStyleBackColor = true;
            this.BtnOdustani.Click += new System.EventHandler(this.BtnOdustani_Click);
            // 
            // FormaDodajKlub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(457, 276);
            this.Controls.Add(this.BtnOdustani);
            this.Controls.Add(this.BtnDodajKlub);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKapacitet);
            this.Controls.Add(this.textBoxNaziv);
            this.Name = "FormaDodajKlub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj novi klub";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.TextBox textBoxKapacitet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDodajKlub;
        private System.Windows.Forms.Button BtnOdustani;
    }
}