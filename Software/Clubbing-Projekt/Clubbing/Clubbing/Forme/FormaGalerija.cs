using Clubbing.Modeli;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clubbing.Forme
{
    public partial class FormaGalerija : Form
    {
        private int index; // trenutni index prikazane slike u listi slikeKluba/slikeDogadjaja
        public FormaGalerija()
        {
            // forma za prikaz svih slika nekog događaja
            index = 0;
            InitializeComponent();
        }

        private void FormaGalerija_Load(object sender, EventArgs e)
        {
            if (!Korisnik.PrijavljeniKorisnik.ValidacijaAutorizacijeDogadjaj())
            {
                BtnDodajSliku.Visible = false;
                BtnObrisiSliku.Visible = false;
            }
            Osvjezi();
        }
        private void Osvjezi()
        {
            // osvjezava panel gdje se prikazuju slike i ako je potrebno onemogućuje gumbove
            // ove provjere se dešavaju uvijek nakon što se klikne na gumbove za prethodnu i sljedeću sliku
            if (Dogadjaj.trenutniDogadjaj.SlikeDogadjaja.Count > 0)
            {
                pictureBox.BackgroundImage = Dogadjaj.trenutniDogadjaj.SlikeDogadjaja[index];
            }
            if (index >= Dogadjaj.trenutniDogadjaj.SlikeDogadjaja.Count-1)
            {
                BtnSljedecaSlika.Enabled = false;
            }
            else
            {
                BtnSljedecaSlika.Enabled = true;
            }
            if(index == 0)
            {
                BtnPrethodnaSlika.Enabled = false;
            }
            else
            {
                BtnPrethodnaSlika.Enabled = true;
            }
        }

        private void BtnPrethodna_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPrethodnaSlika_Click(object sender, EventArgs e)
        {
            // prikazuje prethodnu sliku ako je ima(trenutni index liste slika - 1) 
            index -= 1;
            Osvjezi();
        }

        private void BtnSljedecaSlika_Click(object sender, EventArgs e)
        {
            // prikatuje sljedeću sliku ako je ima(trenutni index liste slika + 1)
            index += 1;
            Osvjezi();
        }

        private void BtnDodajSliku_Click(object sender, EventArgs e)
        {
            // samo admin kluba ima ovu mogućnost
            // dodaje se slika u odabrani događaj
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image slika = Image.FromFile(openFileDialog.FileName);
                Dogadjaj.trenutniDogadjaj.SlikeDogadjaja.Add(slika);
                Dogadjaj.trenutniDogadjaj.DodajSlikuUBazu(slika);
            }

        }

        private void BtnObrisiSliku_Click(object sender, EventArgs e)
        {
            // samo admin kluba ima ovu mogućnost
            // briše trenutnu prikazanu sliku iz liste slikeKluba/slikeDogadjaja
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox.Dock = DockStyle.Fill;
            WindowState = FormWindowState.Maximized;
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox.Dock = DockStyle.None;
            WindowState = FormWindowState.Normal;

        }
    }
}
