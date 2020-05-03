namespace Clubbing
{
    partial class LoginForm
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
            this.buttonPrijava = new FontAwesome.Sharp.IconButton();
            this.iconButtonOdustani = new FontAwesome.Sharp.IconButton();
            this.iconButtonRegistracija = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelUsername.Location = new System.Drawing.Point(98, 52);
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
            this.labelPassword.Location = new System.Drawing.Point(98, 137);
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
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(251, 30);
            this.textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(103, 174);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(251, 30);
            this.textBoxPassword.TabIndex = 3;
            // 
            // buttonPrijava
            // 
            this.buttonPrijava.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPrijava.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrijava.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonPrijava.IconColor = System.Drawing.Color.Black;
            this.buttonPrijava.IconSize = 16;
            this.buttonPrijava.Location = new System.Drawing.Point(148, 255);
            this.buttonPrijava.Name = "buttonPrijava";
            this.buttonPrijava.Rotation = 0D;
            this.buttonPrijava.Size = new System.Drawing.Size(153, 38);
            this.buttonPrijava.TabIndex = 4;
            this.buttonPrijava.Text = "Prijava";
            this.buttonPrijava.UseVisualStyleBackColor = true;
            this.buttonPrijava.Click += new System.EventHandler(this.ButtonPrijava_Click);
            // 
            // iconButtonOdustani
            // 
            this.iconButtonOdustani.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonOdustani.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonOdustani.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonOdustani.IconColor = System.Drawing.Color.Black;
            this.iconButtonOdustani.IconSize = 16;
            this.iconButtonOdustani.Location = new System.Drawing.Point(148, 369);
            this.iconButtonOdustani.Name = "iconButtonOdustani";
            this.iconButtonOdustani.Rotation = 0D;
            this.iconButtonOdustani.Size = new System.Drawing.Size(153, 38);
            this.iconButtonOdustani.TabIndex = 5;
            this.iconButtonOdustani.Text = "Odustani";
            this.iconButtonOdustani.UseVisualStyleBackColor = true;
            // 
            // iconButtonRegistracija
            // 
            this.iconButtonRegistracija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonRegistracija.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonRegistracija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonRegistracija.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonRegistracija.IconColor = System.Drawing.Color.Black;
            this.iconButtonRegistracija.IconSize = 16;
            this.iconButtonRegistracija.Location = new System.Drawing.Point(148, 312);
            this.iconButtonRegistracija.Name = "iconButtonRegistracija";
            this.iconButtonRegistracija.Rotation = 0D;
            this.iconButtonRegistracija.Size = new System.Drawing.Size(153, 38);
            this.iconButtonRegistracija.TabIndex = 6;
            this.iconButtonRegistracija.Text = "Registracija";
            this.iconButtonRegistracija.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(457, 511);
            this.Controls.Add(this.iconButtonRegistracija);
            this.Controls.Add(this.iconButtonOdustani);
            this.Controls.Add(this.buttonPrijava);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.MinimumSize = new System.Drawing.Size(475, 558);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private FontAwesome.Sharp.IconButton buttonPrijava;
        private FontAwesome.Sharp.IconButton iconButtonOdustani;
        private FontAwesome.Sharp.IconButton iconButtonRegistracija;
    }
}