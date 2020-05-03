namespace Clubbing.Forme
{
    partial class FormaLokacija
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnDodajLokaciju = new System.Windows.Forms.Button();
            this.BtnPrethodna = new System.Windows.Forms.Button();
            this.BtnIzmjeniLokaciju = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lokacija kluba";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 279);
            this.panel1.TabIndex = 1;
            // 
            // BtnDodajLokaciju
            // 
            this.BtnDodajLokaciju.Location = new System.Drawing.Point(231, 370);
            this.BtnDodajLokaciju.Name = "BtnDodajLokaciju";
            this.BtnDodajLokaciju.Size = new System.Drawing.Size(156, 36);
            this.BtnDodajLokaciju.TabIndex = 2;
            this.BtnDodajLokaciju.Text = "Dodaj novu lokaciju";
            this.BtnDodajLokaciju.UseVisualStyleBackColor = true;
            this.BtnDodajLokaciju.Click += new System.EventHandler(this.BtnDodajLokaciju_Click);
            // 
            // BtnPrethodna
            // 
            this.BtnPrethodna.Location = new System.Drawing.Point(12, 392);
            this.BtnPrethodna.Name = "BtnPrethodna";
            this.BtnPrethodna.Size = new System.Drawing.Size(113, 36);
            this.BtnPrethodna.TabIndex = 3;
            this.BtnPrethodna.Text = "Nazad";
            this.BtnPrethodna.UseVisualStyleBackColor = true;
            this.BtnPrethodna.Click += new System.EventHandler(this.BtnPrethodna_Click);
            // 
            // BtnIzmjeniLokaciju
            // 
            this.BtnIzmjeniLokaciju.Location = new System.Drawing.Point(466, 370);
            this.BtnIzmjeniLokaciju.Name = "BtnIzmjeniLokaciju";
            this.BtnIzmjeniLokaciju.Size = new System.Drawing.Size(136, 36);
            this.BtnIzmjeniLokaciju.TabIndex = 4;
            this.BtnIzmjeniLokaciju.Text = "Izmjeni lokaciju";
            this.BtnIzmjeniLokaciju.UseVisualStyleBackColor = true;
            this.BtnIzmjeniLokaciju.Click += new System.EventHandler(this.BtnIzmjeniLokaciju_Click);
            // 
            // FormaLokacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnIzmjeniLokaciju);
            this.Controls.Add(this.BtnPrethodna);
            this.Controls.Add(this.BtnDodajLokaciju);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FormaLokacija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormaLokacija";
            this.Load += new System.EventHandler(this.FormaLokacija_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnDodajLokaciju;
        private System.Windows.Forms.Button BtnPrethodna;
        private System.Windows.Forms.Button BtnIzmjeniLokaciju;
    }
}