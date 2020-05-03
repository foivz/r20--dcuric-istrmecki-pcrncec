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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnDodajNoviStol = new System.Windows.Forms.Button();
            this.BtnPregledDogadjaja = new System.Windows.Forms.Button();
            this.BtnOcijeni = new System.Windows.Forms.Button();
            this.BtnGalerijaDogadjaja = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogadjaji)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Moji događaji";
            // 
            // dgvDogadjaji
            // 
            this.dgvDogadjaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDogadjaji.Location = new System.Drawing.Point(27, 71);
            this.dgvDogadjaji.Name = "dgvDogadjaji";
            this.dgvDogadjaji.RowHeadersWidth = 51;
            this.dgvDogadjaji.RowTemplate.Height = 24;
            this.dgvDogadjaji.Size = new System.Drawing.Size(743, 126);
            this.dgvDogadjaji.TabIndex = 1;
            // 
            // BtnDodajDogadjaj
            // 
            this.BtnDodajDogadjaj.ForeColor = System.Drawing.Color.Black;
            this.BtnDodajDogadjaj.Location = new System.Drawing.Point(15, 38);
            this.BtnDodajDogadjaj.Name = "BtnDodajDogadjaj";
            this.BtnDodajDogadjaj.Size = new System.Drawing.Size(209, 37);
            this.BtnDodajDogadjaj.TabIndex = 2;
            this.BtnDodajDogadjaj.Text = "Dodaj događaj";
            this.BtnDodajDogadjaj.UseVisualStyleBackColor = true;
            this.BtnDodajDogadjaj.Click += new System.EventHandler(this.BtnDodajDogadjaj_Click);
            // 
            // BtnUrediDogadjaj
            // 
            this.BtnUrediDogadjaj.ForeColor = System.Drawing.Color.Black;
            this.BtnUrediDogadjaj.Location = new System.Drawing.Point(15, 175);
            this.BtnUrediDogadjaj.Name = "BtnUrediDogadjaj";
            this.BtnUrediDogadjaj.Size = new System.Drawing.Size(209, 37);
            this.BtnUrediDogadjaj.TabIndex = 3;
            this.BtnUrediDogadjaj.Text = "Uredi događaj";
            this.BtnUrediDogadjaj.UseVisualStyleBackColor = true;
            this.BtnUrediDogadjaj.Click += new System.EventHandler(this.BtnUrediDogadjaj_Click);
            // 
            // BtnObrisiDogadjaj
            // 
            this.BtnObrisiDogadjaj.ForeColor = System.Drawing.Color.Black;
            this.BtnObrisiDogadjaj.Location = new System.Drawing.Point(15, 133);
            this.BtnObrisiDogadjaj.Name = "BtnObrisiDogadjaj";
            this.BtnObrisiDogadjaj.Size = new System.Drawing.Size(209, 37);
            this.BtnObrisiDogadjaj.TabIndex = 4;
            this.BtnObrisiDogadjaj.Text = "Obriši događaj";
            this.BtnObrisiDogadjaj.UseVisualStyleBackColor = true;
            this.BtnObrisiDogadjaj.Click += new System.EventHandler(this.BtnObrisiDogadjaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnDodajNoviStol);
            this.groupBox1.Controls.Add(this.BtnObrisiDogadjaj);
            this.groupBox1.Controls.Add(this.BtnUrediDogadjaj);
            this.groupBox1.Controls.Add(this.BtnDodajDogadjaj);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(27, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 220);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Upravljanje događajima";
            // 
            // BtnDodajNoviStol
            // 
            this.BtnDodajNoviStol.ForeColor = System.Drawing.Color.Black;
            this.BtnDodajNoviStol.Location = new System.Drawing.Point(15, 90);
            this.BtnDodajNoviStol.Name = "BtnDodajNoviStol";
            this.BtnDodajNoviStol.Size = new System.Drawing.Size(209, 37);
            this.BtnDodajNoviStol.TabIndex = 5;
            this.BtnDodajNoviStol.Text = "Dodaj stol";
            this.BtnDodajNoviStol.UseVisualStyleBackColor = true;
            this.BtnDodajNoviStol.Click += new System.EventHandler(this.BtnDodajNoviStol_Click);
            // 
            // BtnPregledDogadjaja
            // 
            this.BtnPregledDogadjaja.ForeColor = System.Drawing.Color.Black;
            this.BtnPregledDogadjaja.Location = new System.Drawing.Point(322, 262);
            this.BtnPregledDogadjaja.Name = "BtnPregledDogadjaja";
            this.BtnPregledDogadjaja.Size = new System.Drawing.Size(209, 37);
            this.BtnPregledDogadjaja.TabIndex = 6;
            this.BtnPregledDogadjaja.Text = "Pregled svih događaja";
            this.BtnPregledDogadjaja.UseVisualStyleBackColor = true;
            this.BtnPregledDogadjaja.Click += new System.EventHandler(this.BtnPregledDogadjaja_Click);
            // 
            // BtnOcijeni
            // 
            this.BtnOcijeni.ForeColor = System.Drawing.Color.Black;
            this.BtnOcijeni.Location = new System.Drawing.Point(322, 332);
            this.BtnOcijeni.Name = "BtnOcijeni";
            this.BtnOcijeni.Size = new System.Drawing.Size(209, 37);
            this.BtnOcijeni.TabIndex = 7;
            this.BtnOcijeni.Text = "Ocijeni događaj";
            this.BtnOcijeni.UseVisualStyleBackColor = true;
            this.BtnOcijeni.Click += new System.EventHandler(this.BtnOcijeni_Click);
            // 
            // BtnGalerijaDogadjaja
            // 
            this.BtnGalerijaDogadjaja.ForeColor = System.Drawing.Color.Black;
            this.BtnGalerijaDogadjaja.Location = new System.Drawing.Point(322, 401);
            this.BtnGalerijaDogadjaja.Name = "BtnGalerijaDogadjaja";
            this.BtnGalerijaDogadjaja.Size = new System.Drawing.Size(209, 37);
            this.BtnGalerijaDogadjaja.TabIndex = 8;
            this.BtnGalerijaDogadjaja.Text = "Pogledaj galeriju slika";
            this.BtnGalerijaDogadjaja.UseVisualStyleBackColor = true;
            this.BtnGalerijaDogadjaja.Click += new System.EventHandler(this.BtnGalerijaDogadjaja_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioButton1.Location = new System.Drawing.Point(265, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(142, 21);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Završeni događaji";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioButton2.Location = new System.Drawing.Point(499, 25);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(157, 21);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nadolazeći događaji";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // FormaDogadjaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.BtnGalerijaDogadjaja);
            this.Controls.Add(this.BtnOcijeni);
            this.Controls.Add(this.BtnPregledDogadjaja);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDogadjaji);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "FormaDogadjaji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dogadaji";
            this.Load += new System.EventHandler(this.FormaDogadjaji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogadjaji)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDogadjaji;
        private System.Windows.Forms.Button BtnDodajDogadjaj;
        private System.Windows.Forms.Button BtnUrediDogadjaj;
        private System.Windows.Forms.Button BtnObrisiDogadjaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnDodajNoviStol;
        private System.Windows.Forms.Button BtnPregledDogadjaja;
        private System.Windows.Forms.Button BtnOcijeni;
        private System.Windows.Forms.Button BtnGalerijaDogadjaja;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}