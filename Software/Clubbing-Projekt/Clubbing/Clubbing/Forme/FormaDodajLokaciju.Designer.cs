namespace Clubbing.Forme
{
    partial class FormaDodajLokaciju
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
            this.BtnDodajLokaciju = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPostanskiBroj = new System.Windows.Forms.TextBox();
            this.textBoxGrad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUlica = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnOdustani
            // 
            this.BtnOdustani.Location = new System.Drawing.Point(283, 177);
            this.BtnOdustani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnOdustani.Name = "BtnOdustani";
            this.BtnOdustani.Size = new System.Drawing.Size(121, 39);
            this.BtnOdustani.TabIndex = 12;
            this.BtnOdustani.Text = "Odustani";
            this.BtnOdustani.UseVisualStyleBackColor = true;
            this.BtnOdustani.Click += new System.EventHandler(this.BtnOdustani_Click);
            // 
            // BtnDodajLokaciju
            // 
            this.BtnDodajLokaciju.Location = new System.Drawing.Point(283, 89);
            this.BtnDodajLokaciju.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDodajLokaciju.Name = "BtnDodajLokaciju";
            this.BtnDodajLokaciju.Size = new System.Drawing.Size(121, 39);
            this.BtnDodajLokaciju.TabIndex = 11;
            this.BtnDodajLokaciju.Text = "Dodaj lokaciju";
            this.BtnDodajLokaciju.UseVisualStyleBackColor = true;
            this.BtnDodajLokaciju.Click += new System.EventHandler(this.BtnDodajLokaciju_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(63, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Poštanski broj";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(108, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Grad";
            // 
            // textBoxPostanskiBroj
            // 
            this.textBoxPostanskiBroj.Location = new System.Drawing.Point(53, 218);
            this.textBoxPostanskiBroj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPostanskiBroj.Name = "textBoxPostanskiBroj";
            this.textBoxPostanskiBroj.Size = new System.Drawing.Size(163, 22);
            this.textBoxPostanskiBroj.TabIndex = 8;
            // 
            // textBoxGrad
            // 
            this.textBoxGrad.Location = new System.Drawing.Point(53, 69);
            this.textBoxGrad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxGrad.Name = "textBoxGrad";
            this.textBoxGrad.Size = new System.Drawing.Size(163, 22);
            this.textBoxGrad.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(108, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ulica";
            // 
            // textBoxUlica
            // 
            this.textBoxUlica.Location = new System.Drawing.Point(53, 145);
            this.textBoxUlica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUlica.Name = "textBoxUlica";
            this.textBoxUlica.Size = new System.Drawing.Size(163, 22);
            this.textBoxUlica.TabIndex = 13;
            // 
            // FormaDodajLokaciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(457, 276);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUlica);
            this.Controls.Add(this.BtnOdustani);
            this.Controls.Add(this.BtnDodajLokaciju);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPostanskiBroj);
            this.Controls.Add(this.textBoxGrad);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormaDodajLokaciju";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj lokaciju";
            this.Load += new System.EventHandler(this.FormaDodajLokaciju_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOdustani;
        private System.Windows.Forms.Button BtnDodajLokaciju;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPostanskiBroj;
        private System.Windows.Forms.TextBox textBoxGrad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUlica;
    }
}