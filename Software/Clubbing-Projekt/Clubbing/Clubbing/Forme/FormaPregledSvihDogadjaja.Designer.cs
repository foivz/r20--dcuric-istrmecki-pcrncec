namespace Clubbing.Forme
{
    partial class FormaPregledSvihDogadjaja
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
            this.radioBtnNadolazeci = new System.Windows.Forms.RadioButton();
            this.radioBtnZavrseni = new System.Windows.Forms.RadioButton();
            this.BtnRezerviraj = new System.Windows.Forms.Button();
            this.BtnGalerijaDogadjaja = new System.Windows.Forms.Button();
            this.BtnPovratak = new System.Windows.Forms.Button();
            this.radioBtnSvi = new System.Windows.Forms.RadioButton();
            this.BtnOtvoriKlub = new System.Windows.Forms.Button();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogadjaji)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(37, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Svi događaji";
            // 
            // dgvDogadjaji
            // 
            this.dgvDogadjaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDogadjaji.Location = new System.Drawing.Point(40, 59);
            this.dgvDogadjaji.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDogadjaji.Name = "dgvDogadjaji";
            this.dgvDogadjaji.RowHeadersWidth = 51;
            this.dgvDogadjaji.RowTemplate.Height = 24;
            this.dgvDogadjaji.Size = new System.Drawing.Size(612, 136);
            this.dgvDogadjaji.TabIndex = 1;
            this.dgvDogadjaji.CurrentCellChanged += new System.EventHandler(this.dgvDogadjaji_CurrentCellChanged);
            // 
            // radioBtnNadolazeci
            // 
            this.radioBtnNadolazeci.AutoSize = true;
            this.radioBtnNadolazeci.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioBtnNadolazeci.Location = new System.Drawing.Point(538, 23);
            this.radioBtnNadolazeci.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnNadolazeci.Name = "radioBtnNadolazeci";
            this.radioBtnNadolazeci.Size = new System.Drawing.Size(78, 17);
            this.radioBtnNadolazeci.TabIndex = 12;
            this.radioBtnNadolazeci.TabStop = true;
            this.radioBtnNadolazeci.Text = "Nadolazeći";
            this.radioBtnNadolazeci.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioBtnNadolazeci.UseVisualStyleBackColor = true;
            // 
            // radioBtnZavrseni
            // 
            this.radioBtnZavrseni.AutoSize = true;
            this.radioBtnZavrseni.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioBtnZavrseni.Location = new System.Drawing.Point(375, 23);
            this.radioBtnZavrseni.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnZavrseni.Name = "radioBtnZavrseni";
            this.radioBtnZavrseni.Size = new System.Drawing.Size(66, 17);
            this.radioBtnZavrseni.TabIndex = 11;
            this.radioBtnZavrseni.TabStop = true;
            this.radioBtnZavrseni.Text = "Završeni";
            this.radioBtnZavrseni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioBtnZavrseni.UseVisualStyleBackColor = true;
            // 
            // BtnRezerviraj
            // 
            this.BtnRezerviraj.ForeColor = System.Drawing.Color.Black;
            this.BtnRezerviraj.Location = new System.Drawing.Point(102, 224);
            this.BtnRezerviraj.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRezerviraj.Name = "BtnRezerviraj";
            this.BtnRezerviraj.Size = new System.Drawing.Size(92, 32);
            this.BtnRezerviraj.TabIndex = 13;
            this.BtnRezerviraj.Text = "Rezerviraj";
            this.BtnRezerviraj.UseVisualStyleBackColor = true;
            this.BtnRezerviraj.Click += new System.EventHandler(this.BtnRezerviraj_Click);
            // 
            // BtnGalerijaDogadjaja
            // 
            this.BtnGalerijaDogadjaja.ForeColor = System.Drawing.Color.Black;
            this.BtnGalerijaDogadjaja.Location = new System.Drawing.Point(303, 224);
            this.BtnGalerijaDogadjaja.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGalerijaDogadjaja.Name = "BtnGalerijaDogadjaja";
            this.BtnGalerijaDogadjaja.Size = new System.Drawing.Size(114, 32);
            this.BtnGalerijaDogadjaja.TabIndex = 14;
            this.BtnGalerijaDogadjaja.Text = "Prikaži galeriju";
            this.BtnGalerijaDogadjaja.UseVisualStyleBackColor = true;
            this.BtnGalerijaDogadjaja.Click += new System.EventHandler(this.BtnGalerijaDogadjaja_Click);
            // 
            // BtnPovratak
            // 
            this.BtnPovratak.ForeColor = System.Drawing.Color.Black;
            this.BtnPovratak.Location = new System.Drawing.Point(40, 301);
            this.BtnPovratak.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPovratak.Name = "BtnPovratak";
            this.BtnPovratak.Size = new System.Drawing.Size(92, 32);
            this.BtnPovratak.TabIndex = 15;
            this.BtnPovratak.Text = "Nazad";
            this.BtnPovratak.UseVisualStyleBackColor = true;
            this.BtnPovratak.Click += new System.EventHandler(this.BtnPovratak_Click);
            // 
            // radioBtnSvi
            // 
            this.radioBtnSvi.AutoSize = true;
            this.radioBtnSvi.Checked = true;
            this.radioBtnSvi.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioBtnSvi.Location = new System.Drawing.Point(230, 23);
            this.radioBtnSvi.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnSvi.Name = "radioBtnSvi";
            this.radioBtnSvi.Size = new System.Drawing.Size(40, 17);
            this.radioBtnSvi.TabIndex = 16;
            this.radioBtnSvi.TabStop = true;
            this.radioBtnSvi.Text = "Svi";
            this.radioBtnSvi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioBtnSvi.UseVisualStyleBackColor = true;
            // 
            // BtnOtvoriKlub
            // 
            this.BtnOtvoriKlub.ForeColor = System.Drawing.Color.Black;
            this.BtnOtvoriKlub.Location = new System.Drawing.Point(560, 301);
            this.BtnOtvoriKlub.Margin = new System.Windows.Forms.Padding(2);
            this.BtnOtvoriKlub.Name = "BtnOtvoriKlub";
            this.BtnOtvoriKlub.Size = new System.Drawing.Size(92, 32);
            this.BtnOtvoriKlub.TabIndex = 17;
            this.BtnOtvoriKlub.Text = "Otvori klub";
            this.BtnOtvoriKlub.UseVisualStyleBackColor = true;
            this.BtnOtvoriKlub.Click += new System.EventHandler(this.BtnOtvoriKlub_Click);
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.ForeColor = System.Drawing.Color.Black;
            this.btnFiltriraj.Location = new System.Drawing.Point(524, 224);
            this.btnFiltriraj.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(92, 32);
            this.btnFiltriraj.TabIndex = 18;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // FormaPregledSvihDogadjaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(685, 354);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.BtnOtvoriKlub);
            this.Controls.Add(this.radioBtnSvi);
            this.Controls.Add(this.BtnPovratak);
            this.Controls.Add(this.BtnGalerijaDogadjaja);
            this.Controls.Add(this.BtnRezerviraj);
            this.Controls.Add(this.radioBtnNadolazeci);
            this.Controls.Add(this.radioBtnZavrseni);
            this.Controls.Add(this.dgvDogadjaji);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormaPregledSvihDogadjaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormaPregledSvihDogadjaja";
            this.Load += new System.EventHandler(this.FormaPregledSvihDogadjaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogadjaji)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDogadjaji;
        private System.Windows.Forms.RadioButton radioBtnNadolazeci;
        private System.Windows.Forms.RadioButton radioBtnZavrseni;
        private System.Windows.Forms.Button BtnRezerviraj;
        private System.Windows.Forms.Button BtnGalerijaDogadjaja;
        private System.Windows.Forms.Button BtnPovratak;
        private System.Windows.Forms.RadioButton radioBtnSvi;
        private System.Windows.Forms.Button BtnOtvoriKlub;
        private System.Windows.Forms.Button btnFiltriraj;
    }
}