namespace Clubbing
{
    partial class FormaPrijava
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.BtnPrijava = new FontAwesome.Sharp.IconButton();
            this.BtnRegistracija = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelUsername.Location = new System.Drawing.Point(99, 52);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(102, 25);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelPassword.Location = new System.Drawing.Point(99, 137);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(98, 25);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(103, 89);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(251, 30);
            this.textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(103, 174);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(251, 30);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // BtnPrijava
            // 
            this.BtnPrijava.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnPrijava.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrijava.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnPrijava.IconColor = System.Drawing.Color.Black;
            this.BtnPrijava.IconSize = 16;
            this.BtnPrijava.Location = new System.Drawing.Point(148, 255);
            this.BtnPrijava.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnPrijava.Name = "BtnPrijava";
            this.BtnPrijava.Rotation = 0D;
            this.BtnPrijava.Size = new System.Drawing.Size(153, 38);
            this.BtnPrijava.TabIndex = 4;
            this.BtnPrijava.Text = "Prijava";
            this.BtnPrijava.UseVisualStyleBackColor = true;
            this.BtnPrijava.Click += new System.EventHandler(this.BtnPrijava_Click);
            // 
            // BtnRegistracija
            // 
            this.BtnRegistracija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnRegistracija.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnRegistracija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistracija.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnRegistracija.IconColor = System.Drawing.Color.Black;
            this.BtnRegistracija.IconSize = 16;
            this.BtnRegistracija.Location = new System.Drawing.Point(148, 327);
            this.BtnRegistracija.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRegistracija.Name = "BtnRegistracija";
            this.BtnRegistracija.Rotation = 0D;
            this.BtnRegistracija.Size = new System.Drawing.Size(153, 38);
            this.BtnRegistracija.TabIndex = 6;
            this.BtnRegistracija.Text = "Registracija";
            this.BtnRegistracija.UseVisualStyleBackColor = true;
            this.BtnRegistracija.Click += new System.EventHandler(this.BtnRegistracija_Click);
            // 
            // FormaPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(459, 519);
            this.Controls.Add(this.BtnRegistracija);
            this.Controls.Add(this.BtnPrijava);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(474, 557);
            this.Name = "FormaPrijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava/Registracija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private FontAwesome.Sharp.IconButton BtnPrijava;
        private FontAwesome.Sharp.IconButton BtnRegistracija;
    }
}