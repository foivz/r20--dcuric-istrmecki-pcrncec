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
            this.components = new System.ComponentModel.Container();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.textBoxKapacitet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDodajKlub = new System.Windows.Forms.Button();
            this.BtnOdustani = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnLogo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxZanr = new System.Windows.Forms.ComboBox();
            this.zanrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.zanrBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(111, 58);
            this.textBoxNaziv.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(123, 20);
            this.textBoxNaziv.TabIndex = 0;
            // 
            // textBoxKapacitet
            // 
            this.textBoxKapacitet.Location = new System.Drawing.Point(111, 132);
            this.textBoxKapacitet.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKapacitet.Name = "textBoxKapacitet";
            this.textBoxKapacitet.Size = new System.Drawing.Size(123, 20);
            this.textBoxKapacitet.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(131, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Naziv kluba";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(137, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kapacitet";
            // 
            // BtnDodajKlub
            // 
            this.BtnDodajKlub.Location = new System.Drawing.Point(41, 317);
            this.BtnDodajKlub.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDodajKlub.Name = "BtnDodajKlub";
            this.BtnDodajKlub.Size = new System.Drawing.Size(91, 32);
            this.BtnDodajKlub.TabIndex = 5;
            this.BtnDodajKlub.Text = "Dodaj klub";
            this.BtnDodajKlub.UseVisualStyleBackColor = true;
            this.BtnDodajKlub.Click += new System.EventHandler(this.BtnDodajKlub_Click);
            // 
            // BtnOdustani
            // 
            this.BtnOdustani.Location = new System.Drawing.Point(209, 317);
            this.BtnOdustani.Margin = new System.Windows.Forms.Padding(2);
            this.BtnOdustani.Name = "BtnOdustani";
            this.BtnOdustani.Size = new System.Drawing.Size(91, 32);
            this.BtnOdustani.TabIndex = 6;
            this.BtnOdustani.Text = "Odustani";
            this.BtnOdustani.UseVisualStyleBackColor = true;
            this.BtnOdustani.Click += new System.EventHandler(this.BtnOdustani_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            // 
            // btnLogo
            // 
            this.btnLogo.Location = new System.Drawing.Point(119, 181);
            this.btnLogo.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(108, 32);
            this.btnLogo.TabIndex = 8;
            this.btnLogo.Text = "Odaberi logo";
            this.btnLogo.UseVisualStyleBackColor = true;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(152, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Žanr";
            // 
            // comboBoxZanr
            // 
            this.comboBoxZanr.DataSource = this.zanrBindingSource;
            this.comboBoxZanr.DisplayMember = "naziv";
            this.comboBoxZanr.FormattingEnabled = true;
            this.comboBoxZanr.Location = new System.Drawing.Point(119, 268);
            this.comboBoxZanr.Name = "comboBoxZanr";
            this.comboBoxZanr.Size = new System.Drawing.Size(108, 21);
            this.comboBoxZanr.TabIndex = 10;
            this.comboBoxZanr.ValueMember = "id_zanr";
            // 
            // zanrBindingSource
            // 
            this.zanrBindingSource.DataSource = typeof(Clubbing.Podaci.Zanr);
            // 
            // FormaDodajKlub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(332, 383);
            this.Controls.Add(this.comboBoxZanr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogo);
            this.Controls.Add(this.BtnOdustani);
            this.Controls.Add(this.BtnDodajKlub);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKapacitet);
            this.Controls.Add(this.textBoxNaziv);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormaDodajKlub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj novi klub";
            this.Load += new System.EventHandler(this.FormaDodajKlub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zanrBindingSource)).EndInit();
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
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnLogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxZanr;
        private System.Windows.Forms.BindingSource zanrBindingSource;
    }
}