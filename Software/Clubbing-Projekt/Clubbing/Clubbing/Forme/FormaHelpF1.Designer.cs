namespace Clubbing.Forme
{
    partial class FormaHelpF1
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
            this.TextBoxHelpF1 = new System.Windows.Forms.TextBox();
            this.BtnOk = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // TextBoxHelpF1
            // 
            this.TextBoxHelpF1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.TextBoxHelpF1.ForeColor = System.Drawing.Color.Gainsboro;
            this.TextBoxHelpF1.Location = new System.Drawing.Point(12, 12);
            this.TextBoxHelpF1.Multiline = true;
            this.TextBoxHelpF1.Name = "TextBoxHelpF1";
            this.TextBoxHelpF1.ReadOnly = true;
            this.TextBoxHelpF1.Size = new System.Drawing.Size(559, 509);
            this.TextBoxHelpF1.TabIndex = 0;
            // 
            // BtnOk
            // 
            this.BtnOk.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnOk.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnOk.IconColor = System.Drawing.Color.Black;
            this.BtnOk.IconSize = 16;
            this.BtnOk.Location = new System.Drawing.Point(228, 543);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Rotation = 0D;
            this.BtnOk.Size = new System.Drawing.Size(113, 41);
            this.BtnOk.TabIndex = 1;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // FormaHelpF1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(583, 596);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.TextBoxHelpF1);
            this.Name = "FormaHelpF1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHelpF1";
            this.Load += new System.EventHandler(this.FormHelpF1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxHelpF1;
        private FontAwesome.Sharp.IconButton BtnOk;
    }
}