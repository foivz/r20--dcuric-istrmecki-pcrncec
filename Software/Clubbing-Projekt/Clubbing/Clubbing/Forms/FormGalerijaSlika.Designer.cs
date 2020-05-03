namespace Clubbing.Forms
{
    partial class FormGalerijaSlika
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
            this.iconButtonIzlaz = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // iconButtonIzlaz
            // 
            this.iconButtonIzlaz.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonIzlaz.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonIzlaz.IconColor = System.Drawing.Color.Black;
            this.iconButtonIzlaz.IconSize = 16;
            this.iconButtonIzlaz.Location = new System.Drawing.Point(364, 350);
            this.iconButtonIzlaz.Name = "iconButtonIzlaz";
            this.iconButtonIzlaz.Rotation = 0D;
            this.iconButtonIzlaz.Size = new System.Drawing.Size(94, 34);
            this.iconButtonIzlaz.TabIndex = 0;
            this.iconButtonIzlaz.Text = "Izlaz";
            this.iconButtonIzlaz.UseVisualStyleBackColor = true;
            this.iconButtonIzlaz.Click += new System.EventHandler(this.IconButtonIzlaz_Click);
            // 
            // FormGalerijaSlika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(567, 473);
            this.Controls.Add(this.iconButtonIzlaz);
            this.Name = "FormGalerijaSlika";
            this.Text = "FormGalerijaSlika";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonIzlaz;
    }
}