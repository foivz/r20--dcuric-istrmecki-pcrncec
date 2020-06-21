namespace Clubbing.Forme
{
    partial class FormaDogadjaji
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
            this.dgvDogadjaji = new System.Windows.Forms.DataGridView();
            this.BtnDodajDogadjaj = new System.Windows.Forms.Button();
            this.BtnUrediDogadjaj = new System.Windows.Forms.Button();
            this.BtnObrisiDogadjaj = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.BtnDodajNoviStol = new System.Windows.Forms.Button();
            this.BtnPregledDogadjaja = new System.Windows.Forms.Button();
            this.BtnOcijeni = new System.Windows.Forms.Button();
            this.BtnGalerijaDogadjaja = new System.Windows.Forms.Button();
            this.radioBtnZavrseni = new System.Windows.Forms.RadioButton();
            this.radioBtnNadolazeci = new System.Windows.Forms.RadioButton();
            this.radioBtnSvi = new System.Windows.Forms.RadioButton();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogadjaji)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Moji događaji";
            // 
            // dgvDogadjaji
            // 
            this.dgvDogadjaji.AllowUserToAddRows = false;
            this.dgvDogadjaji.AllowUserToDeleteRows = false;
            this.dgvDogadjaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDogadjaji.Location = new System.Drawing.Point(20, 58);
            this.dgvDogadjaji.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDogadjaji.Name = "dgvDogadjaji";
            this.dgvDogadjaji.ReadOnly = true;
            this.dgvDogadjaji.RowHeadersWidth = 51;
            this.dgvDogadjaji.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDogadjaji.RowTemplate.Height = 24;
            this.dgvDogadjaji.Size = new System.Drawing.Size(557, 102);
            this.dgvDogadjaji.TabIndex = 1;
            this.dgvDogadjaji.CurrentCellChanged += new System.EventHandler(this.dgvDogadjaji_CurrentCellChanged);
            // 
            // BtnDodajDogadjaj
            // 
            this.BtnDodajDogadjaj.ForeColor = System.Drawing.Color.Black;
            this.BtnDodajDogadjaj.Location = new System.Drawing.Point(11, 31);
            this.BtnDodajDogadjaj.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDodajDogadjaj.Name = "BtnDodajDogadjaj";
            this.BtnDodajDogadjaj.Size = new System.Drawing.Size(157, 30);
            this.BtnDodajDogadjaj.TabIndex = 2;
            this.BtnDodajDogadjaj.Text = "Dodaj događaj";
            this.BtnDodajDogadjaj.UseVisualStyleBackColor = true;
            this.BtnDodajDogadjaj.Click += new System.EventHandler(this.BtnDodajDogadjaj_Click);
            // 
            // BtnUrediDogadjaj
            // 
            this.BtnUrediDogadjaj.ForeColor = System.Drawing.Color.Black;
            this.BtnUrediDogadjaj.Location = new System.Drawing.Point(11, 99);
            this.BtnUrediDogadjaj.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUrediDogadjaj.Name = "BtnUrediDogadjaj";
            this.BtnUrediDogadjaj.Size = new System.Drawing.Size(157, 30);
            this.BtnUrediDogadjaj.TabIndex = 3;
            this.BtnUrediDogadjaj.Text = "Uredi događaj";
            this.BtnUrediDogadjaj.UseVisualStyleBackColor = true;
            this.BtnUrediDogadjaj.Click += new System.EventHandler(this.BtnUrediDogadjaj_Click);
            // 
            // BtnObrisiDogadjaj
            // 
            this.BtnObrisiDogadjaj.ForeColor = System.Drawing.Color.Black;
            this.BtnObrisiDogadjaj.Location = new System.Drawing.Point(11, 65);
            this.BtnObrisiDogadjaj.Margin = new System.Windows.Forms.Padding(2);
            this.BtnObrisiDogadjaj.Name = "BtnObrisiDogadjaj";
            this.BtnObrisiDogadjaj.Size = new System.Drawing.Size(157, 30);
            this.BtnObrisiDogadjaj.TabIndex = 4;
            this.BtnObrisiDogadjaj.Text = "Obriši događaj";
            this.BtnObrisiDogadjaj.UseVisualStyleBackColor = true;
            this.BtnObrisiDogadjaj.Click += new System.EventHandler(this.BtnObrisiDogadjaj_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.BtnDodajNoviStol);
            this.groupBox.Controls.Add(this.BtnObrisiDogadjaj);
            this.groupBox.Controls.Add(this.BtnUrediDogadjaj);
            this.groupBox.Controls.Add(this.BtnDodajDogadjaj);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox.Location = new System.Drawing.Point(20, 184);
            this.groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox.Size = new System.Drawing.Size(179, 179);
            this.groupBox.TabIndex = 5;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Upravljanje događajima";
            // 
            // BtnDodajNoviStol
            // 
            this.BtnDodajNoviStol.ForeColor = System.Drawing.Color.Black;
            this.BtnDodajNoviStol.Location = new System.Drawing.Point(11, 142);
            this.BtnDodajNoviStol.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDodajNoviStol.Name = "BtnDodajNoviStol";
            this.BtnDodajNoviStol.Size = new System.Drawing.Size(157, 30);
            this.BtnDodajNoviStol.TabIndex = 5;
            this.BtnDodajNoviStol.Text = "Dodaj stol";
            this.BtnDodajNoviStol.UseVisualStyleBackColor = true;
            this.BtnDodajNoviStol.Click += new System.EventHandler(this.BtnDodajNoviStol_Click);
            // 
            // BtnPregledDogadjaja
            // 
            this.BtnPregledDogadjaja.ForeColor = System.Drawing.Color.Black;
            this.BtnPregledDogadjaja.Location = new System.Drawing.Point(242, 213);
            this.BtnPregledDogadjaja.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPregledDogadjaja.Name = "BtnPregledDogadjaja";
            this.BtnPregledDogadjaja.Size = new System.Drawing.Size(157, 30);
            this.BtnPregledDogadjaja.TabIndex = 6;
            this.BtnPregledDogadjaja.Text = "Pregled svih događaja";
            this.BtnPregledDogadjaja.UseVisualStyleBackColor = true;
            this.BtnPregledDogadjaja.Click += new System.EventHandler(this.BtnPregledDogadjaja_Click);
            // 
            // BtnOcijeni
            // 
            this.BtnOcijeni.ForeColor = System.Drawing.Color.Black;
            this.BtnOcijeni.Location = new System.Drawing.Point(242, 270);
            this.BtnOcijeni.Margin = new System.Windows.Forms.Padding(2);
            this.BtnOcijeni.Name = "BtnOcijeni";
            this.BtnOcijeni.Size = new System.Drawing.Size(157, 30);
            this.BtnOcijeni.TabIndex = 7;
            this.BtnOcijeni.Text = "Ocijeni događaj";
            this.BtnOcijeni.UseVisualStyleBackColor = true;
            this.BtnOcijeni.Click += new System.EventHandler(this.BtnOcijeni_Click);
            // 
            // BtnGalerijaDogadjaja
            // 
            this.BtnGalerijaDogadjaja.ForeColor = System.Drawing.Color.Black;
            this.BtnGalerijaDogadjaja.Location = new System.Drawing.Point(242, 326);
            this.BtnGalerijaDogadjaja.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGalerijaDogadjaja.Name = "BtnGalerijaDogadjaja";
            this.BtnGalerijaDogadjaja.Size = new System.Drawing.Size(157, 30);
            this.BtnGalerijaDogadjaja.TabIndex = 8;
            this.BtnGalerijaDogadjaja.Text = "Pogledaj galeriju slika";
            this.BtnGalerijaDogadjaja.UseVisualStyleBackColor = true;
            this.BtnGalerijaDogadjaja.Click += new System.EventHandler(this.BtnGalerijaDogadjaja_Click);
            // 
            // radioBtnZavrseni
            // 
            this.radioBtnZavrseni.AutoSize = true;
            this.radioBtnZavrseni.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioBtnZavrseni.Location = new System.Drawing.Point(325, 21);
            this.radioBtnZavrseni.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnZavrseni.Name = "radioBtnZavrseni";
            this.radioBtnZavrseni.Size = new System.Drawing.Size(74, 19);
            this.radioBtnZavrseni.TabIndex = 9;
            this.radioBtnZavrseni.Text = "Završeni";
            this.radioBtnZavrseni.UseVisualStyleBackColor = true;
            // 
            // radioBtnNadolazeci
            // 
            this.radioBtnNadolazeci.AutoSize = true;
            this.radioBtnNadolazeci.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioBtnNadolazeci.Location = new System.Drawing.Point(447, 22);
            this.radioBtnNadolazeci.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnNadolazeci.Name = "radioBtnNadolazeci";
            this.radioBtnNadolazeci.Size = new System.Drawing.Size(90, 19);
            this.radioBtnNadolazeci.TabIndex = 10;
            this.radioBtnNadolazeci.Text = "Nadolazeći";
            this.radioBtnNadolazeci.UseVisualStyleBackColor = true;
            // 
            // radioBtnSvi
            // 
            this.radioBtnSvi.AutoSize = true;
            this.radioBtnSvi.Checked = true;
            this.radioBtnSvi.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioBtnSvi.Location = new System.Drawing.Point(232, 22);
            this.radioBtnSvi.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnSvi.Name = "radioBtnSvi";
            this.radioBtnSvi.Size = new System.Drawing.Size(44, 19);
            this.radioBtnSvi.TabIndex = 11;
            this.radioBtnSvi.TabStop = true;
            this.radioBtnSvi.Text = "Svi";
            this.radioBtnSvi.UseVisualStyleBackColor = true;
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.ForeColor = System.Drawing.Color.Black;
            this.btnFiltriraj.Location = new System.Drawing.Point(460, 184);
            this.btnFiltriraj.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(109, 30);
            this.btnFiltriraj.TabIndex = 12;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // FormaDogadjaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.radioBtnSvi);
            this.Controls.Add(this.radioBtnNadolazeci);
            this.Controls.Add(this.radioBtnZavrseni);
            this.Controls.Add(this.BtnGalerijaDogadjaja);
            this.Controls.Add(this.BtnOcijeni);
            this.Controls.Add(this.BtnPregledDogadjaja);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.dgvDogadjaji);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormaDogadjaji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dogadaji";
            this.Load += new System.EventHandler(this.FormaDogadjaji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogadjaji)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDogadjaji;
        private System.Windows.Forms.Button BtnDodajDogadjaj;
        private System.Windows.Forms.Button BtnUrediDogadjaj;
        private System.Windows.Forms.Button BtnObrisiDogadjaj;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button BtnDodajNoviStol;
        private System.Windows.Forms.Button BtnPregledDogadjaja;
        private System.Windows.Forms.Button BtnOcijeni;
        private System.Windows.Forms.Button BtnGalerijaDogadjaja;
        private System.Windows.Forms.RadioButton radioBtnZavrseni;
        private System.Windows.Forms.RadioButton radioBtnNadolazeci;
        private System.Windows.Forms.RadioButton radioBtnSvi;
        private System.Windows.Forms.Button btnFiltriraj;
    }
}