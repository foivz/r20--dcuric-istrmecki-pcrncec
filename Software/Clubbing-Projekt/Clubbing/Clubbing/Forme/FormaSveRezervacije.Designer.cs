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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnNovaRezervacija = new System.Windows.Forms.Button();
            this.BtnPotvrdi = new System.Windows.Forms.Button();
            this.BtnOdbij = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rezervacije";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(723, 180);
            this.dataGridView1.TabIndex = 1;
            // 
            // BtnNovaRezervacija
            // 
            this.BtnNovaRezervacija.Location = new System.Drawing.Point(44, 296);
            this.BtnNovaRezervacija.Name = "BtnNovaRezervacija";
            this.BtnNovaRezervacija.Size = new System.Drawing.Size(159, 75);
            this.BtnNovaRezervacija.TabIndex = 2;
            this.BtnNovaRezervacija.Text = "Pregled dostupnih događaja\r\nza rezervaciju";
            this.BtnNovaRezervacija.UseVisualStyleBackColor = true;
            this.BtnNovaRezervacija.Click += new System.EventHandler(this.BtnNovaRezervacija_Click);
            // 
            // BtnPotvrdi
            // 
            this.BtnPotvrdi.Location = new System.Drawing.Point(297, 296);
            this.BtnPotvrdi.Name = "BtnPotvrdi";
            this.BtnPotvrdi.Size = new System.Drawing.Size(190, 75);
            this.BtnPotvrdi.TabIndex = 3;
            this.BtnPotvrdi.Text = "Potvrdi rezervaciju";
            this.BtnPotvrdi.UseVisualStyleBackColor = true;
            this.BtnPotvrdi.Click += new System.EventHandler(this.BtnPotvrdi_Click);
            // 
            // BtnOdbij
            // 
            this.BtnOdbij.Location = new System.Drawing.Point(577, 296);
            this.BtnOdbij.Name = "BtnOdbij";
            this.BtnOdbij.Size = new System.Drawing.Size(190, 75);
            this.BtnOdbij.TabIndex = 4;
            this.BtnOdbij.Text = "Odbij rezervaciju";
            this.BtnOdbij.UseVisualStyleBackColor = true;
            this.BtnOdbij.Click += new System.EventHandler(this.BtnOdbij_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioButton2.Location = new System.Drawing.Point(423, 32);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(94, 21);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Potvrđene";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioButton1.Location = new System.Drawing.Point(263, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(100, 21);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Na čekanju";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioButton3.Location = new System.Drawing.Point(577, 31);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(86, 21);
            this.radioButton3.TabIndex = 17;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Odbijene";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // FormaSveRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.BtnOdbij);
            this.Controls.Add(this.BtnPotvrdi);
            this.Controls.Add(this.BtnNovaRezervacija);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FormaSveRezervacije";
            this.Text = "Rezervacije";
            this.Load += new System.EventHandler(this.FormaSveRezervacije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnNovaRezervacija;
        private System.Windows.Forms.Button BtnPotvrdi;
        private System.Windows.Forms.Button BtnOdbij;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}