namespace Clubbing.Forme
{
    partial class FormaDodajRecenziju
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
            this.BtnDodajRecenziju = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOpis = new System.Windows.Forms.TextBox();
            this.textBoxOcjena = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnOdustani
            // 
            this.BtnOdustani.Location = new System.Drawing.Point(282, 168);
            this.BtnOdustani.Name = "BtnOdustani";
            this.BtnOdustani.Size = new System.Drawing.Size(121, 40);
            this.BtnOdustani.TabIndex = 12;
            this.BtnOdustani.Text = "Odustani";
            this.BtnOdustani.UseVisualStyleBackColor = true;
            this.BtnOdustani.Click += new System.EventHandler(this.BtnOdustani_Click);
            // 
            // BtnDodajRecenziju
            // 
            this.BtnDodajRecenziju.Location = new System.Drawing.Point(282, 79);
            this.BtnDodajRecenziju.Name = "BtnDodajRecenziju";
            this.BtnDodajRecenziju.Size = new System.Drawing.Size(121, 40);
            this.BtnDodajRecenziju.TabIndex = 11;
            this.BtnDodajRecenziju.Text = "Dodaj recenziju";
            this.BtnDodajRecenziju.UseVisualStyleBackColor = true;
            this.BtnDodajRecenziju.Click += new System.EventHandler(this.BtnDodajRecenziju_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(133, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Opis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(121, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ocjena";
            // 
            // textBoxOpis
            // 
            this.textBoxOpis.Location = new System.Drawing.Point(67, 186);
            this.textBoxOpis.Multiline = true;
            this.textBoxOpis.Name = "textBoxOpis";
            this.textBoxOpis.Size = new System.Drawing.Size(163, 22);
            this.textBoxOpis.TabIndex = 8;
            // 
            // textBoxOcjena
            // 
            this.textBoxOcjena.Location = new System.Drawing.Point(67, 79);
            this.textBoxOcjena.Name = "textBoxOcjena";
            this.textBoxOcjena.Size = new System.Drawing.Size(163, 22);
            this.textBoxOcjena.TabIndex = 7;
            // 
            // FormaDodajRecenziju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(457, 276);
            this.Controls.Add(this.BtnOdustani);
            this.Controls.Add(this.BtnDodajRecenziju);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOpis);
            this.Controls.Add(this.textBoxOcjena);
            this.Name = "FormaDodajRecenziju";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormaDodajRecenziju";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOdustani;
        private System.Windows.Forms.Button BtnDodajRecenziju;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOpis;
        private System.Windows.Forms.TextBox textBoxOcjena;
    }
}