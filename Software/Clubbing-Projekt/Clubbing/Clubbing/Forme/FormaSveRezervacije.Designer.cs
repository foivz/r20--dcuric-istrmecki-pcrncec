namespace Clubbing.Forme
{
    partial class FormaSveRezervacije
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRezervacije = new System.Windows.Forms.DataGridView();
            this.BtnNovaRezervacija = new System.Windows.Forms.Button();
            this.BtnPotvrdi = new System.Windows.Forms.Button();
            this.BtnOdbij = new System.Windows.Forms.Button();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDogadjaj = new System.Windows.Forms.Label();
            this.labelKorisnik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rezervacije";
            // 
            // dgvRezervacije
            // 
            this.dgvRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacije.Location = new System.Drawing.Point(33, 81);
            this.dgvRezervacije.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRezervacije.Name = "dgvRezervacije";
            this.dgvRezervacije.RowHeadersWidth = 51;
            this.dgvRezervacije.Size = new System.Drawing.Size(531, 146);
            this.dgvRezervacije.TabIndex = 1;
            this.dgvRezervacije.CurrentCellChanged += new System.EventHandler(this.dgvRezervacije_CurrentCellChanged);
            // 
            // BtnNovaRezervacija
            // 
            this.BtnNovaRezervacija.Location = new System.Drawing.Point(33, 330);
            this.BtnNovaRezervacija.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNovaRezervacija.Name = "BtnNovaRezervacija";
            this.BtnNovaRezervacija.Size = new System.Drawing.Size(119, 61);
            this.BtnNovaRezervacija.TabIndex = 2;
            this.BtnNovaRezervacija.Text = "Pregled dostupnih događaja\r\nza rezervaciju";
            this.BtnNovaRezervacija.UseVisualStyleBackColor = true;
            this.BtnNovaRezervacija.Click += new System.EventHandler(this.BtnNovaRezervacija_Click);
            // 
            // BtnPotvrdi
            // 
            this.BtnPotvrdi.Location = new System.Drawing.Point(220, 330);
            this.BtnPotvrdi.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPotvrdi.Name = "BtnPotvrdi";
            this.BtnPotvrdi.Size = new System.Drawing.Size(142, 61);
            this.BtnPotvrdi.TabIndex = 3;
            this.BtnPotvrdi.Text = "Potvrdi rezervaciju";
            this.BtnPotvrdi.UseVisualStyleBackColor = true;
            this.BtnPotvrdi.Click += new System.EventHandler(this.BtnPotvrdi_Click);
            // 
            // BtnOdbij
            // 
            this.BtnOdbij.Location = new System.Drawing.Point(422, 330);
            this.BtnOdbij.Margin = new System.Windows.Forms.Padding(2);
            this.BtnOdbij.Name = "BtnOdbij";
            this.BtnOdbij.Size = new System.Drawing.Size(142, 61);
            this.BtnOdbij.TabIndex = 4;
            this.BtnOdbij.Text = "Odbij rezervaciju";
            this.BtnOdbij.UseVisualStyleBackColor = true;
            this.BtnOdbij.Click += new System.EventHandler(this.BtnOdbij_Click);
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Location = new System.Drawing.Point(491, 26);
            this.btnFiltriraj.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(64, 29);
            this.btnFiltriraj.TabIndex = 18;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Sve rezervacije",
            "Na čekanju",
            "Potvrđeno",
            "Odbijeno"});
            this.comboBox.Location = new System.Drawing.Point(355, 31);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(200, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Filtriraj rezervacije:";
            // 
            // labelDogadjaj
            // 
            this.labelDogadjaj.AutoSize = true;
            this.labelDogadjaj.ForeColor = System.Drawing.Color.White;
            this.labelDogadjaj.Location = new System.Drawing.Point(30, 252);
            this.labelDogadjaj.Name = "labelDogadjaj";
            this.labelDogadjaj.Size = new System.Drawing.Size(57, 15);
            this.labelDogadjaj.TabIndex = 21;
            this.labelDogadjaj.Text = "Događaj:";
            // 
            // labelKorisnik
            // 
            this.labelKorisnik.AutoSize = true;
            this.labelKorisnik.ForeColor = System.Drawing.Color.White;
            this.labelKorisnik.Location = new System.Drawing.Point(30, 291);
            this.labelKorisnik.Name = "labelKorisnik";
            this.labelKorisnik.Size = new System.Drawing.Size(54, 15);
            this.labelKorisnik.TabIndex = 22;
            this.labelKorisnik.Text = "Korisnik:";
            // 
            // FormaSveRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(600, 441);
            this.Controls.Add(this.labelKorisnik);
            this.Controls.Add(this.labelDogadjaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.BtnOdbij);
            this.Controls.Add(this.BtnPotvrdi);
            this.Controls.Add(this.BtnNovaRezervacija);
            this.Controls.Add(this.dgvRezervacije);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormaSveRezervacije";
            this.Text = "Rezervacije";
            this.Load += new System.EventHandler(this.FormaSveRezervacije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRezervacije;
        private System.Windows.Forms.Button BtnNovaRezervacija;
        private System.Windows.Forms.Button BtnPotvrdi;
        private System.Windows.Forms.Button BtnOdbij;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDogadjaj;
        private System.Windows.Forms.Label labelKorisnik;
    }
}