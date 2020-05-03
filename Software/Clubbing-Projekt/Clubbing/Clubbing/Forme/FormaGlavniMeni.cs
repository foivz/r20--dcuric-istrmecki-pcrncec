using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Clubbing.Forme;

namespace Clubbing
{
    public partial class FormaGlavniMeni : Form
    {
        private IconButton BtnTrenutni;
        private Panel BtnLijeviDio;
        private Form FormaDijete;
        public FormaGlavniMeni()
        {
            InitializeComponent();
            BtnLijeviDio = new Panel();
            BtnLijeviDio.Size = new Size(7, 60);
            panelMeni.Controls.Add(BtnLijeviDio);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);

        }
        private void OdabraniIzbornik(object BtnSender, Color color)
        {
            if (BtnSender != null)
            {
                DisableButton();
                BtnTrenutni = (IconButton)BtnSender;
                BtnTrenutni.BackColor = Color.FromArgb(37, 36, 81);
                BtnTrenutni.ForeColor = color;
                BtnTrenutni.TextAlign = ContentAlignment.MiddleCenter;
                BtnTrenutni.IconColor = color;
                BtnTrenutni.TextImageRelation = TextImageRelation.TextBeforeImage;
                BtnTrenutni.ImageAlign = ContentAlignment.MiddleRight;

                BtnLijeviDio.BackColor = color;
                BtnLijeviDio.Location = new Point(0, BtnTrenutni.Location.Y);
                BtnLijeviDio.Visible = true;
                BtnLijeviDio.BringToFront();
                trenutnaForma.IconChar = BtnTrenutni.IconChar;
                trenutnaForma.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (BtnTrenutni != null)
            {
                BtnTrenutni.BackColor = Color.FromArgb(31, 30, 68);
                BtnTrenutni.ForeColor = Color.Gainsboro;
                BtnTrenutni.TextAlign = ContentAlignment.MiddleLeft;
                BtnTrenutni.IconColor = Color.Gainsboro;
                BtnTrenutni.TextImageRelation = TextImageRelation.ImageBeforeText;
                BtnTrenutni.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OtvoriFormuDijete(Form formaDijete)
        {
            if (FormaDijete != null)
            {
                FormaDijete.Close();
            }
            FormaDijete = formaDijete;

            formaDijete.TopLevel = false;
            formaDijete.FormBorderStyle = FormBorderStyle.None;
            formaDijete.Dock = DockStyle.Fill;
            glavniPanel.Controls.Add(formaDijete);
            glavniPanel.Tag = formaDijete;
            formaDijete.BringToFront();
            formaDijete.Show();
            labelTitleChildForm.Text = formaDijete.Text;
        }

        private void PanelMeni_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IconButtonKlubovi_Click(object sender, EventArgs e)
        {
            OdabraniIzbornik(sender, RGBColors.color1);
            OtvoriFormuDijete(new FormaKlubovi());
        }

        private void IconButtonDogadaji_Click(object sender, EventArgs e)
        {
            OdabraniIzbornik(sender, RGBColors.color2);
            OtvoriFormuDijete(new FormaDogadjaji());
        }

        private void IconButtonRezervacije_Click(object sender, EventArgs e)
        {
            OdabraniIzbornik(sender, RGBColors.color3);
            OtvoriFormuDijete(new FormaSveRezervacije());
        }
        private void IconButtonObavijest_Click(object sender, EventArgs e)
        {
            OdabraniIzbornik(sender, RGBColors.color5);
            OtvoriFormuDijete(new FormaObavijesti());
        }

        private void IconButtonOdjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {

        }
        private void ButtonHome_Click_1(object sender, EventArgs e)
        {
            if (FormaDijete != null)
            {
                FormaDijete.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            BtnLijeviDio.Visible = false;
            trenutnaForma.IconChar = IconChar.Home;
            trenutnaForma.IconColor = Color.Gainsboro;
            labelTitleChildForm.Text = "Home";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void IconClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IconMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void IconMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void PostaviKlubAdmina()
        {
            // dohvaca se iz baze klub za prijavljenog admina i taj klub se pridodaje statičkoj varijabli klubAdmina (klasa Klub)
            Modeli.Klub.KlubAdmina = null;
        }

        private void IconButtonHelp_Click(object sender, EventArgs e)
        {
            FormaHelpF1 formHelpF1 = new FormaHelpF1();
            formHelpF1.Show();
        }

        private void FormaGlavniMeni_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void FormaGlavniMeni_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                IconButtonHelp.PerformClick();
            }
        }
    }
}
