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
using Clubbing.Forme;

namespace Clubbing.Forme
{
    public partial class FormaKlub : Form
    {
        public Klub odabraniKlub = null;
        public FormaKlub(Klub odabraniKlub)
        {
            this.odabraniKlub = odabraniKlub;
            InitializeComponent();
        }

        private void FormaKlub_Load(object sender, EventArgs e)
        {
            labelImeKluba.Text += odabraniKlub.ImeKluba;
            labelMaxKapacitet.Text += odabraniKlub.MaxKapacitet;
            panel1.BackgroundImage = null;
            // još i učitava neku random sliku kluba (ili pak logo) na panel
        }

        private void BtnPovratak_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGalerija_Click(object sender, EventArgs e)
        {
            // otvara galeriju slika za odabrani klub
            FormaGalerija formaGalerija = new FormaGalerija(true);
            formaGalerija.Show();
        }

        private void BtnOcijeni_Click(object sender, EventArgs e)
        {
            // otvara formu za dodavanje nove recenzije za taj klub
            FormaDodajRecenziju formaDodajRecenziju = new FormaDodajRecenziju(true);
            formaDodajRecenziju.Show();
        }

        private void BtnPrati_Click(object sender, EventArgs e)
        {
            // ako korisnik već prati klub onda se pojavljuje poruka da već on prati taj klub
            // admin ne može vidjeti taj button jer nam smisla
            // kad je uspješno se u bazu postavlja da korisnik x prati klub y
        }

        private void BtnLokacija_Click(object sender, EventArgs e)
        {
            // otvara formu s prikazom lokacije kluba
            FormaLokacija formaLokacija = new FormaLokacija();
            formaLokacija.Show();
        }

        private void BtnOtvoriDogadjaje_Click(object sender, EventArgs e)
        {
            // otvara se forma na kojoj se nalaze svi događaji za odabran klub
            FormaPregledSvihDogadjaja formaPregledSvihDogadjaja = new FormaPregledSvihDogadjaja();
            this.Hide();
            formaPregledSvihDogadjaja.Show();
        }
    }
}
