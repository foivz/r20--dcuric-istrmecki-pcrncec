namespace Clubbing.Forme
{
    partial class FormaObavijesti
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
            this.BtnDodajObavijest = new System.Windows.Forms.Button();
            this.dgvObavijesti = new System.Windows.Forms.DataGridView();
            this.labelObavijesti = new System.Windows.Forms.Label();
            this.textBoxObavijest = new System.Windows.Forms.TextBox();
            this.labelNOP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijesti)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDodajObavijest
            // 
            this.BtnDodajObavijest.Location = new System.Drawing.Point(446, 310);
            this.BtnDodajObavijest.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDodajObavijest.Name = "BtnDodajObavijest";
            this.BtnDodajObavijest.Size = new System.Drawing.Size(124, 37);
            this.BtnDodajObavijest.TabIndex = 7;
            this.BtnDodajObavijest.Text = "Pošalji obavijest";
            this.BtnDodajObavijest.UseVisualStyleBackColor = true;
            this.BtnDodajObavijest.Click += new System.EventHandler(this.BtnDodajObavijest_Click);
            // 
            // dgvObavijesti
            // 
            this.dgvObavijesti.AllowUserToAddRows = false;
            this.dgvObavijesti.AllowUserToDeleteRows = false;
            this.dgvObavijesti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObavijesti.Location = new System.Drawing.Point(29, 68);
            this.dgvObavijesti.Margin = new System.Windows.Forms.Padding(2);
            this.dgvObavijesti.Name = "dgvObavijesti";
            this.dgvObavijesti.ReadOnly = true;
            this.dgvObavijesti.RowHeadersWidth = 51;
            this.dgvObavijesti.Size = new System.Drawing.Size(518, 146);
            this.dgvObavijesti.TabIndex = 6;
            this.dgvObavijesti.CurrentCellChanged += new System.EventHandler(this.dgvObavijesti_CurrentCellChanged);
            // 
            // labelObavijesti
            // 
            this.labelObavijesti.AutoSize = true;
            this.labelObavijesti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObavijesti.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelObavijesti.Location = new System.Drawing.Point(26, 31);
            this.labelObavijesti.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelObavijesti.Name = "labelObavijesti";
            this.labelObavijesti.Size = new System.Drawing.Size(93, 20);
            this.labelObavijesti.TabIndex = 5;
            this.labelObavijesti.Text = "Obavijesti";
            // 
            // textBoxObavijest
            // 
            this.textBoxObavijest.Location = new System.Drawing.Point(29, 287);
            this.textBoxObavijest.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxObavijest.Multiline = true;
            this.textBoxObavijest.Name = "textBoxObavijest";
            this.textBoxObavijest.Size = new System.Drawing.Size(407, 91);
            this.textBoxObavijest.TabIndex = 8;
            // 
            // labelNOP
            // 
            this.labelNOP.AutoSize = true;
            this.labelNOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNOP.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelNOP.Location = new System.Drawing.Point(26, 247);
            this.labelNOP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNOP.Name = "labelNOP";
            this.labelNOP.Size = new System.Drawing.Size(253, 20);
            this.labelNOP.TabIndex = 15;
            this.labelNOP.Text = "Napišite obavijest pratiocima";
            // 
            // FormaObavijesti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(615, 410);
            this.Controls.Add(this.labelNOP);
            this.Controls.Add(this.textBoxObavijest);
            this.Controls.Add(this.BtnDodajObavijest);
            this.Controls.Add(this.dgvObavijesti);
            this.Controls.Add(this.labelObavijesti);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormaObavijesti";
            this.Text = "Obavijesti";
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijesti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnDodajObavijest;
        private System.Windows.Forms.DataGridView dgvObavijesti;
        private System.Windows.Forms.Label labelObavijesti;
        private System.Windows.Forms.TextBox textBoxObavijest;
        private System.Windows.Forms.Label labelNOP;
    }
}