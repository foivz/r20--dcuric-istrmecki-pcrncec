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
using Clubbing.Modeli;

namespace Clubbing.Forme
{
    public partial class FormaPregledSvihDogadjaja : Form
    {
        private BindingList<Klub> klubovi = null;
        public Dogadjaj odabraniDogadjaj = null;
        public FormaPregledSvihDogadjaja()
        {
            InitializeComponent();
        }

        private void FormaPregledSvihDogadjaja_Load(object sender, EventArgs e)
        {
            // učitava sve događaje u dgv na temelju odabranih opcija
        }
        private void Filtriraj()
        {
            // filtrira (mijenja) atribut klubovi s obzirom na odabrane opcije
        }
        private void PrikaziDogadjaje()
        {
            // prikazuje u dgv sve događaje klubova koji se nalaze u varijabli klubovi
        }

        private void BtnRezerviraj_Click(object sender, EventArgs e)
        {
            // pritiskom na ovaj gumb se otvara forma FormaDodajRezervaciju na kojoj se dodaje rezervacija za odabrani događaj
            // ta akcija se sprječava ako je korisnik već rezervirao odabrani događaj ili ako se odabere završen događaj
            FormaDodajRezervaciju formaDodajRezervaciju = new FormaDodajRezervaciju();
            formaDodajRezervaciju.Show();
        }

        private void BtnGalerijaDogadjaja_Click(object sender, EventArgs e)
        {
            // pritiskom na ovaj gumb se otvara forma galerije dogadjaja/klubova
            // ta akcija se sprječava, odnosno gumb se onemogućuje ukoliko se odabere nadolazeći događaj
            FormaGalerija formaGalerija = new FormaGalerija(false);
            formaGalerija.Show();
        }

        private void BtnPovratak_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void BtnOtvoriKlub_Click(object sender, EventArgs e)
        {
            // otvara klub koji organizira odabrani događaj
            FormaKlub formaKlub = new FormaKlub(new Klub("Klub test", 200));
            this.Hide();
            formaKlub.Show();
        }
    }
}
