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
        public FormaKlub()
        {
            InitializeComponent();
        }

        private void FormaKlub_Load(object sender, EventArgs e)
        {
            labelImeKluba.Text += Klub.trenutniKlub.ImeKluba;
            labelMaxKapacitet.Text += Klub.trenutniKlub.MaxKapacitet;
            labelAdmin.Text += Klub.trenutniKlub.AdminKluba;
            pictureBoxLogo.BackgroundImage = Klub.trenutniKlub.Logo;
            if (Korisnik.PrijavljeniKorisnik.DohvatiKlubAdmina()!=null)
            {
                if(Korisnik.PrijavljeniKorisnik.DohvatiKlubAdmina().IDKlub == Klub.trenutniKlub.IDKlub)
                {
                    BtnOcijeni.Visible = false;
                    BtnPrati.Visible = false;
                }
            }
        }

        private void BtnPovratak_Click(object sender, EventArgs e)
        {
            this.Close();
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
            // admin ne može vidjeti taj button jer nema smisla
            // ako je uspješno onda se u bazu i statičku listu postavlja da korisnik x prati klub y
            if (Korisnik.PrijavljeniKorisnik.ZapratiKlub())
            {
                Korisnik.PrijavljeniKorisnik.PraceniKlubovi.Add(Klub.trenutniKlub);
            }
            else
            {
                MessageBox.Show("Već pratite ovaj klub", "Greška");
            }
        }

        private void BtnLokacija_Click(object sender, EventArgs e)
        {
            // otvara formu s prikazom lokacije kluba uz pomoc google maps-a
            if (Klub.trenutniKlub.Lokacija != null || Korisnik.PrijavljeniKorisnik.ValidacijaAutorizacijeKlub())
            {
                FormaLokacija formaLokacija = new FormaLokacija();
                formaLokacija.Show();
            }    
            else
            {
                MessageBox.Show("Ovaj klub još nije unio svoju lokaciju", "Greška");
            }
        }

        private void BtnOtvoriDogadjaje_Click(object sender, EventArgs e)
        {
            // otvara se forma na kojoj se nalaze svi događaji za odabran klub
            FormaPregledSvihDogadjaja formaPregledSvihDogadjaja = new FormaPregledSvihDogadjaja(1);
            this.Hide();
            formaPregledSvihDogadjaja.Show();
        }
    }
}
