using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clubbing.Modeli;
using Clubbing.Forme;

namespace Clubbing.Forme
{
    public partial class FormaSveRezervacije : Form
    {
        private BindingList<Rezervacija> mojeRezervacije = null;
        public FormaSveRezervacije()
        {
            InitializeComponent();
        }

        private void FormaSveRezervacije_Load(object sender, EventArgs e)
        {
            // ako koirisnik nije admin - ucitava iz baze sve rezervacije nekog korisnika
            // ako je korisnik admin - ucitava iz baze sve zahtjeve iz baze
            // rezervacije mogu biti na zahtjevu, potvrđene ili odijene
            // ucitava sve rezervacije u listi mojeRezervacije u listu
        }
        private void Filtriraj()
        {
            // metoda za filtriranje rezervacija ovisno o odabranoj opciji (Npr. Odobrene)
            // popunjava iznova listu mojeRezervacije, ali s trenutno filtriranim rezervacijama
            // radi na isti princip kao i sve ostale filtracije u ovoj aplikaciji
        }

        private void BtnNovaRezervacija_Click(object sender, EventArgs e)
        {
            // otvara formu s onim događajima koji su dostupni za rezervaiju (nadolazeći i ima još slobodnih mjesta)
            // ovaj button admin ne vidi jer nema smisla da sam sebi rezervira mjesto na nekom događaju
            FormaPregledSvihDogadjaja formaPregledSvihDogadjaja = new FormaPregledSvihDogadjaja();
            formaPregledSvihDogadjaja.Show();
        }

        private void BtnPotvrdi_Click(object sender, EventArgs e)
        {
            // ovaj button vidi samo admin kluba koji orgranizira događaj koji se odnosi na odabranu rezervaciju
            // u bazu i u aplikaciju se postavlja atribut status u Potvrđeno 
        }

        private void BtnOdbij_Click(object sender, EventArgs e)
        {
            // ovaj button vidi samo admin kluba koji orgranizira događaj za koji se odnosi odabrana rezervacija
            // u bazu i u aplikaciju se postavlja atribut status u Odbijeno 

        }
    }
}
