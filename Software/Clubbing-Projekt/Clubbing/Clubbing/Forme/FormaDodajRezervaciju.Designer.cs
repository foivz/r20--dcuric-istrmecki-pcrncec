namespace Clubbing.Forme
{
    partial class FormaDodajRezervaciju
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
            this.BtnOdustani = new System.Windows.Forms.Button();
            this.BtnDodaj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBrojLjudi = new System.Windows.Forms.TextBox();
            this.comboBoxStolovi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnOdustani
            // 
            this.BtnOdustani.ForeColor = System.Drawing.Color.Black;
            this.BtnOdustani.Location = new System.Drawing.Point(287, 223);
            this.BtnOdustani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnOdustani.Name = "BtnOdustani";
            this.BtnOdustani.Size = new System.Drawing.Size(121, 39);
            this.BtnOdustani.TabIndex = 24;
            this.BtnOdustani.Text = "Odustani";
            this.BtnOdustani.UseVisualStyleBackColor = true;
            this.BtnOdustani.Click += new System.EventHandler(this.BtnOdustani_Click);
            // 
            // BtnDodaj
            // 
            this.BtnDodaj.ForeColor = System.Drawing.Color.Black;
            this.BtnDodaj.Location = new System.Drawing.Point(41, 223);
            this.BtnDodaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDodaj.Name = "BtnDodaj";
            this.BtnDodaj.Size = new System.Drawing.Size(121, 39);
            this.BtnDodaj.TabIndex = 23;
            this.BtnDodaj.Text = "Dodaj";
            this.BtnDodaj.UseVisualStyleBackColor = true;
            this.BtnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Odaberi stol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(188, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Broj ljudi";
            // 
            // textBoxBrojLjudi
            // 
            this.textBoxBrojLjudi.Location = new System.Drawing.Point(111, 65);
            this.textBoxBrojLjudi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBrojLjudi.Name = "textBoxBrojLjudi";
            this.textBoxBrojLjudi.Size = new System.Drawing.Size(233, 22);
            this.textBoxBrojLjudi.TabIndex = 19;
            // 
            // comboBoxStolovi
            // 
            this.comboBoxStolovi.FormattingEnabled = true;
            this.comboBoxStolovi.Location = new System.Drawing.Point(111, 156);
            this.comboBoxStolovi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxStolovi.Name = "comboBoxStolovi";
            this.comboBoxStolovi.Size = new System.Drawing.Size(233, 24);
            this.comboBoxStolovi.TabIndex = 25;
            // 
            // FormaDodajRezervaciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(455, 276);
            this.Controls.Add(this.comboBoxStolovi);
            this.Controls.Add(this.BtnOdustani);
            this.Controls.Add(this.BtnDodaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBrojLjudi);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormaDodajRezervaciju";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj rezervaciju";
            this.Load += new System.EventHandler(this.FormaDodajRezervaciju_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOdustani;
        private System.Windows.Forms.Button BtnDodaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBrojLjudi;
        private System.Windows.Forms.ComboBox comboBoxStolovi;
    }
}