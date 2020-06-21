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
    public partial class FormaDodajDogadjaj : Form
    {
        private string inputNaziv = "";
        private string inputOpis = "";
        private DateTime inputDatumPocetka;
        private DateTime inputDatumZavrsetka;
        private int inputCijenaUlaznice;
        private int inputMaxRezervacija;
        private bool dodavanjne;
        public FormaDodajDogadjaj(bool dodaj)
        {
            dodavanjne = dodaj;
            InitializeComponent();
        }
        private void FormaDodajDogadjaj_Load(object sender, EventArgs e)
        {
            if (!dodavanjne)
            {
                Dogadjaj odabraniDogadjaj = Dogadjaj.trenutniDogadjaj;
                textBoxNaziv.Text = odabraniDogadjaj.NazivDogadjaja;
                textBoxOpis.Text = odabraniDogadjaj.Opis;
                textBoxCijena.Text = odabraniDogadjaj.CijenaUlaznice.ToString();
                textBoxMaxRez.Text = odabraniDogadjaj.MaxRezervacija.ToString();
                dateTimePocetak.Value = odabraniDogadjaj.DatumPocetka;
                dateTimeZavrsetak.Value = odabraniDogadjaj.DatumZavrsetka;
                BtnDodajDogadjaj.Text = "Ažuriraj";
            }
        }
        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDodajDogadjaj_Click(object sender, EventArgs e)
        {
            // pokusava dodati novi dogadjaj u listu dogadjaja za klub admina
            if (string.IsNullOrEmpty(textBoxNaziv.Text) || string.IsNullOrEmpty(textBoxOpis.Text))
            {
                MessageBox.Show("Krivi unos!");
                return;
            }
            try
            {
                inputNaziv = textBoxNaziv.Text;
                inputOpis = textBoxOpis.Text;
                inputDatumPocetka = dateTimePocetak.Value;
                inputDatumZavrsetka = dateTimeZavrsetak.Value;
                inputCijenaUlaznice = Convert.ToInt32(textBoxCijena.Text);
                inputMaxRezervacija = Convert.ToInt32(textBoxMaxRez.Text);
                if (dodavanjne)
                {
                    // kreiranje novog događaja
                    Dogadjaj dogadjaj = new Dogadjaj(inputNaziv, inputOpis, inputDatumPocetka, inputDatumZavrsetka, inputCijenaUlaznice, inputMaxRezervacija);
                    int id = dogadjaj.DodajDogadjajUBazu();
                    dogadjaj.IDDogadjaj = id;
                    Korisnik.PrijavljeniKorisnik.DohvatiKlubAdmina().Dogadjaji.Add(dogadjaj);
                    // kreiranje obavijesti
                    string opisObavijesti = "Kreiran je novi događaj: " + dogadjaj.NazivDogadjaja;
                    Obavijest obavijest = new Obavijest(opisObavijesti, DateTime.Now);
                    obavijest.DodajObavijestUBazu(true);
                }
                else
                {
                    // ažuriranje postojećeg događaja
                    Dogadjaj odabraniDogadjaj = Dogadjaj.trenutniDogadjaj;
                    odabraniDogadjaj.NazivDogadjaja = inputNaziv;
                    odabraniDogadjaj.Opis = inputOpis;
                    odabraniDogadjaj.CijenaUlaznice = inputCijenaUlaznice;
                    odabraniDogadjaj.MaxRezervacija = inputMaxRezervacija;
                    odabraniDogadjaj.DatumPocetka = inputDatumPocetka;
                    odabraniDogadjaj.DatumZavrsetka = inputDatumZavrsetka;
                    odabraniDogadjaj.AzurirajDogadjajUBazi();
                }
                this.Close();
            }
            catch
            {
                MessageBox.Show("Krivi unos!");
            }
        }   
    }
}
