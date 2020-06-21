using Clubbing.Modeli;
using Clubbing.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Configuration;

namespace Clubbing.Forme
{
    public partial class FormaLokacija : Form
    {
        public FormaLokacija()
        {
            InitializeComponent();
        }

        private void FormaLokacija_Load(object sender, EventArgs e)
        {
            if (!Korisnik.PrijavljeniKorisnik.ValidacijaAutorizacijeKlub())
            {
                BtnDodajLokaciju.Visible = false;
                BtnIzmjeniLokaciju.Visible = false;
            }
            if (Klub.trenutniKlub.Lokacija != null)
            {
                PrikaziMapu();
            }
        }

        private void BtnPrethodna_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDodajLokaciju_Click(object sender, EventArgs e)
        {
            if (Klub.trenutniKlub.Lokacija == null)
            {
                FormaDodajLokaciju formaDodajLokaciju = new FormaDodajLokaciju(true);
                formaDodajLokaciju.Show();
            }
            else
            {
                MessageBox.Show("Već ste postavili lokaciju za svoju klub!", "Greška");
            }
        }

        private void BtnIzmjeniLokaciju_Click(object sender, EventArgs e)
        {
            if (Klub.trenutniKlub.Lokacija != null)
            {
                FormaDodajLokaciju formaDodajLokaciju = new FormaDodajLokaciju(false);
                formaDodajLokaciju.Show();
            }
            else
            {
                MessageBox.Show("Ovaj klub još nije unio svoju lokaciju", "Greška");
            }
        }
        private void PrikaziMapu()
        {
            string adresa = Klub.trenutniKlub.Lokacija.DohvatiGMUpit();
            webBrowser.ScriptErrorsSuppressed = true;
            webBrowser.Navigate(adresa);     
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            webBrowser.Dock = DockStyle.Fill;
            WindowState = FormWindowState.Maximized;
            btnPrikazi.Visible = false;
        }

        private void webBrowser_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized && e.KeyCode == Keys.Escape)
            {
                webBrowser.Dock = DockStyle.None;
                WindowState = FormWindowState.Normal;
                btnPrikazi.Visible = true;
            }
        }
    }
}


