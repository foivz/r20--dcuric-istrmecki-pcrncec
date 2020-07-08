namespace Clubbing.Forme
{
    partial class FormaDodajStol
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
            this.BtnDodajStol = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMaxMjesta = new System.Windows.Forms.TextBox();
            this.textBoxNazivLokacije = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnOdustani
            // 
            this.BtnOdustani.ForeColor = System.Drawing.Color.Black;
            this.BtnOdustani.Location = new System.Drawing.Point(275, 190);
            this.BtnOdustani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnOdustani.Name = "BtnOdustani";
            this.BtnOdustani.Size = new System.Drawing.Size(121, 39);
            this.BtnOdustani.TabIndex = 18;
            this.BtnOdustani.Text = "Odustani";
            this.BtnOdustani.UseVisualStyleBackColor = true;
            this.BtnOdustani.Click += new System.EventHandler(this.BtnOdustani_Click);
            // 
            // BtnDodajStol
            // 
            this.BtnDodajStol.ForeColor = System.Drawing.Color.Black;
            this.BtnDodajStol.Location = new System.Drawing.Point(275, 82);
            this.BtnDodajStol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDodajStol.Name = "BtnDodajStol";
            this.BtnDodajStol.Size = new System.Drawing.Size(121, 39);
            this.BtnDodajStol.TabIndex = 17;
            this.BtnDodajStol.Text = "Dodaj stol";
            this.BtnDodajStol.UseVisualStyleBackColor = true;
            this.BtnDodajStol.Click += new System.EventHandler(this.BtnDodajStol_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(51, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Maksimalno mjesta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(44, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Naziv lokacije stola";
            // 
            // textBoxMaxMjesta
            // 
            this.textBoxMaxMjesta.Location = new System.Drawing.Point(59, 198);
            this.textBoxMaxMjesta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMaxMjesta.Multiline = true;
            this.textBoxMaxMjesta.Name = "textBoxMaxMjesta";
            this.textBoxMaxMjesta.Size = new System.Drawing.Size(163, 22);
            this.textBoxMaxMjesta.TabIndex = 14;
            // 
            // textBoxNazivLokacije
            // 
            this.textBoxNazivLokacije.Location = new System.Drawing.Point(59, 91);
            this.textBoxNazivLokacije.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNazivLokacije.Name = "textBoxNazivLokacije";
            this.textBoxNazivLokacije.Size = new System.Drawing.Size(163, 22);
            this.textBoxNazivLokacije.TabIndex = 13;
            // 
            // FormaDodajStol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(455, 276);
            this.Controls.Add(this.BtnOdustani);
            this.Controls.Add(this.BtnDodajStol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMaxMjesta);
            this.Controls.Add(this.textBoxNazivLokacije);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormaDodajStol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj stol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOdustani;
        private System.Windows.Forms.Button BtnDodajStol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMaxMjesta;
        private System.Windows.Forms.TextBox textBoxNazivLokacije;
    }
}