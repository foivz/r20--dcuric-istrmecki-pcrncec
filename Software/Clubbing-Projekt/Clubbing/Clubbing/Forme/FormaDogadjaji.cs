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
    public partial class FormaDogadjaji : Form
    {
        private BindingList<Dogadjaj> mojiDogadjaji = null;
        public Dogadjaj odabraniDogadjaj = null;
        public FormaDogadjaji()
        {
            InitializeComponent();
        }

        private void FormaDogadjaji_Load(object sender, EventArgs e)
        {
            // ucitava sve dogadjaje korisnika i prikazuje ih u dgv
        }
        private void Filtriraj()
        {
            // ažurira listu događaja (varijabla mojiDogadjaji) s obzirom na odabrane opcije
        }
        private Dogadjaj DohvatiOdabraniDogadjaj()
        {
            // vraća odabrani događaj iz dgv-a
            return null;
        }
        private void BtnObrisiDogadjaj_Click(object sender, EventArgs e)
        {
            // pristup ove i ostalih mogućnosti iz grupe upravljanje događajima ima samo admin nekog kluba za njegov klub
            // briše odabrani događaj u dgv-u
        }

        private void BtnDodajDogadjaj_Click(object sender, EventArgs e)
        {
            // otvara formu za dodavanje novog događaja te ga dodaje u listu dogadjaji za klub admina
            FormaDodajDogadjaj formaDodajDogadjaj = new FormaDodajDogadjaj();
            formaDodajDogadjaj.Show();
        }

        private void BtnUrediDogadjaj_Click(object sender, EventArgs e)
        {
            // gumb za potvrdu promjene podataka onih događaja koji su promjenjenih u dgv-u
            // nove vrijednosti su one koje su u dgv-u za svaki događaj koji je promijenjen
        }

        private void BtnDodajNoviStol_Click(object sender, EventArgs e)
        {
            // otvara formu za unos novog stola za odabrani događaj u dgv-u
            // dodavanje novog stola znači i novo mjesto za rezervaciju korisnika aplikacije
            FormaDodajStol formaDodajStol = new FormaDodajStol();
            formaDodajStol.Show();
        }

        private void BtnPregledDogadjaja_Click(object sender, EventArgs e)
        {
            // otvara formu gdje se nalaze svi događaji koji postaje u bazi (svi događaji od svih postojećih klubova)
            FormaPregledSvihDogadjaja formaPregledSvihDogadjaja = new FormaPregledSvihDogadjaja();
            formaPregledSvihDogadjaja.Show();
        }

        private void BtnOcijeni_Click(object sender, EventArgs e)
        {
            // otvara formu za unos recenzije (ocjene)
            // obavezno treba unijeti parametar false kako bi se znalo da se unosi recenzija za događaj a ne za klub
            FormaDodajRecenziju formaDodajRecenziju = new FormaDodajRecenziju(false);
            formaDodajRecenziju.Show();
        }

        private void BtnGalerijaDogadjaja_Click(object sender, EventArgs e)
        {
            // otvara formu s galerijom slika za odabrani događaj
            FormaGalerija formaGalerija = new FormaGalerija(false);
            formaGalerija.Show();
        }
    }
}
