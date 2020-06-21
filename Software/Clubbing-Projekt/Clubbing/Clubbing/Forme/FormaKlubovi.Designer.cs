namespace Clubbing.Forme
{
    partial class FormaKlubovi
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
            this.BtnObrisiKlub = new FontAwesome.Sharp.IconButton();
            this.BtnDodajKlub = new FontAwesome.Sharp.IconButton();
            this.BtnPrikaziKlubove = new FontAwesome.Sharp.IconButton();
            this.dataGridViewKlubovi = new System.Windows.Forms.DataGridView();
            this.BtnOtvoriKlub = new FontAwesome.Sharp.IconButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.klubBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKlubovi)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klubBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnObrisiKlub
            // 
            this.BtnObrisiKlub.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnObrisiKlub.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnObrisiKlub.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnObrisiKlub.IconColor = System.Drawing.Color.Black;
            this.BtnObrisiKlub.IconSize = 16;
            this.BtnObrisiKlub.Location = new System.Drawing.Point(179, 297);
            this.BtnObrisiKlub.Margin = new System.Windows.Forms.Padding(2);
            this.BtnObrisiKlub.Name = "BtnObrisiKlub";
            this.BtnObrisiKlub.Rotation = 0D;
            this.BtnObrisiKlub.Size = new System.Drawing.Size(110, 28);
            this.BtnObrisiKlub.TabIndex = 17;
            this.BtnObrisiKlub.Text = "Obriši klub";
            this.BtnObrisiKlub.UseVisualStyleBackColor = true;
            this.BtnObrisiKlub.Click += new System.EventHandler(this.BtnObrisiKlub_Click);
            // 
            // BtnDodajKlub
            // 
            this.BtnDodajKlub.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnDodajKlub.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnDodajKlub.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnDodajKlub.IconColor = System.Drawing.Color.Black;
            this.BtnDodajKlub.IconSize = 16;
            this.BtnDodajKlub.Location = new System.Drawing.Point(179, 245);
            this.BtnDodajKlub.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDodajKlub.Name = "BtnDodajKlub";
            this.BtnDodajKlub.Rotation = 0D;
            this.BtnDodajKlub.Size = new System.Drawing.Size(110, 28);
            this.BtnDodajKlub.TabIndex = 16;
            this.BtnDodajKlub.Text = "Dodaj klub";
            this.BtnDodajKlub.UseVisualStyleBackColor = true;
            this.BtnDodajKlub.Click += new System.EventHandler(this.BtnDodajKlub_Click);
            // 
            // BtnPrikaziKlubove
            // 
            this.BtnPrikaziKlubove.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnPrikaziKlubove.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnPrikaziKlubove.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnPrikaziKlubove.IconColor = System.Drawing.Color.Black;
            this.BtnPrikaziKlubove.IconSize = 16;
            this.BtnPrikaziKlubove.Location = new System.Drawing.Point(25, 325);
            this.BtnPrikaziKlubove.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPrikaziKlubove.Name = "BtnPrikaziKlubove";
            this.BtnPrikaziKlubove.Rotation = 0D;
            this.BtnPrikaziKlubove.Size = new System.Drawing.Size(115, 31);
            this.BtnPrikaziKlubove.TabIndex = 15;
            this.BtnPrikaziKlubove.Text = "Prikaži";
            this.BtnPrikaziKlubove.UseVisualStyleBackColor = true;
            this.BtnPrikaziKlubove.Click += new System.EventHandler(this.BtnPrikaziKlubove_Click);
            // 
            // dataGridViewKlubovi
            // 
            this.dataGridViewKlubovi.AllowUserToAddRows = false;
            this.dataGridViewKlubovi.AllowUserToDeleteRows = false;
            this.dataGridViewKlubovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKlubovi.Location = new System.Drawing.Point(179, 70);
            this.dataGridViewKlubovi.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewKlubovi.Name = "dataGridViewKlubovi";
            this.dataGridViewKlubovi.ReadOnly = true;
            this.dataGridViewKlubovi.RowHeadersWidth = 51;
            this.dataGridViewKlubovi.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewKlubovi.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewKlubovi.RowTemplate.Height = 24;
            this.dataGridViewKlubovi.Size = new System.Drawing.Size(399, 143);
            this.dataGridViewKlubovi.TabIndex = 14;
            this.dataGridViewKlubovi.CurrentCellChanged += new System.EventHandler(this.dataGridViewKlubovi_CurrentCellChanged);
            // 
            // BtnOtvoriKlub
            // 
            this.BtnOtvoriKlub.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnOtvoriKlub.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnOtvoriKlub.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnOtvoriKlub.IconColor = System.Drawing.Color.Black;
            this.BtnOtvoriKlub.IconSize = 16;
            this.BtnOtvoriKlub.Location = new System.Drawing.Point(419, 273);
            this.BtnOtvoriKlub.Margin = new System.Windows.Forms.Padding(2);
            this.BtnOtvoriKlub.Name = "BtnOtvoriKlub";
            this.BtnOtvoriKlub.Rotation = 0D;
            this.BtnOtvoriKlub.Size = new System.Drawing.Size(119, 28);
            this.BtnOtvoriKlub.TabIndex = 18;
            this.BtnOtvoriKlub.Text = "Otvori klub";
            this.BtnOtvoriKlub.UseVisualStyleBackColor = true;
            this.BtnOtvoriKlub.Click += new System.EventHandler(this.BtnOtvoriKlub_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.checkedListBox);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox.Location = new System.Drawing.Point(9, 10);
            this.groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox.Size = new System.Drawing.Size(152, 301);
            this.groupBox.TabIndex = 19;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Opcije odabira";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Žanrovi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ocjena kluba";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Klubovi";
            // 
            // klubBindingSource
            // 
            this.klubBindingSource.DataSource = typeof(Clubbing.Podaci.Klub);
            // 
            // checkedListBox
            // 
            this.checkedListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.checkedListBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.checkedListBox.Location = new System.Drawing.Point(27, 53);
            this.checkedListBox.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(27, 74);
            this.checkedListBox.TabIndex = 14;
            // 
            // FormaKlubovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.BtnOtvoriKlub);
            this.Controls.Add(this.BtnObrisiKlub);
            this.Controls.Add(this.BtnDodajKlub);
            this.Controls.Add(this.BtnPrikaziKlubove);
            this.Controls.Add(this.dataGridViewKlubovi);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormaKlubovi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klubovi";
            this.Load += new System.EventHandler(this.FormaKlubovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKlubovi)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klubBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnObrisiKlub;
        private FontAwesome.Sharp.IconButton BtnDodajKlub;
        private FontAwesome.Sharp.IconButton BtnPrikaziKlubove;
        private System.Windows.Forms.DataGridView dataGridViewKlubovi;
        private FontAwesome.Sharp.IconButton BtnOtvoriKlub;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource klubBindingSource;
        private System.Windows.Forms.CheckedListBox checkedListBox;
    }
}