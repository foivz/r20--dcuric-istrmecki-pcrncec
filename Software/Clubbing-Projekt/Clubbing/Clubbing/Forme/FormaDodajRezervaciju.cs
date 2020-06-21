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
    public partial class FormaDodajRezervaciju : Form
    {
        public FormaDodajRezervaciju()
        {
            InitializeComponent();
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            // pokusava dodati novu rezervaciju
            try
            {
                int inputBrojLjudi = Convert.ToInt32(textBoxBrojLjudi.Text);
                Stol inputStol = comboBoxStolovi.SelectedItem as Stol;
                if (ValidacijaRezervacije(inputStol, inputBrojLjudi))
                {
                    Rezervacija rezervacija = new Rezervacija(inputBrojLjudi, inputStol,  DateTime.Now, 0);
                    int id = rezervacija.DodajRezervacijuUBazu();
                    rezervacija.IDRezervacija = id;
                    Dogadjaj.trenutniDogadjaj.Rezervacije.Add(rezervacija);
                    Korisnik.PrijavljeniKorisnik.Rezervacije.Add(rezervacija);
                    MessageBox.Show("Uspješno ste rezervirali odabrani događaj!");

                    string opisObavijest = "Korisnik " + Korisnik.PrijavljeniKorisnik.ToString() + " je rezervirao događaj " + Dogadjaj.trenutniDogadjaj.NazivDogadjaja;
                    Obavijest obavijest = new Obavijest(opisObavijest, DateTime.Now);
                    obavijest.DodajObavijestUBazu(false);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Unijeli ste prevelik broj ljudi za taj stol", "Greška");
                }
            }
            catch
            {
                MessageBox.Show("Krivi unos!");
            }
        }

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormaDodajRezervaciju_Load(object sender, EventArgs e)
        {
            // ovdje se popunjava combobox iz baze uz uvijet
            // uvijet je da se odaberu samo oni stolovi koji nisu već rezervirani za odabrani događaj
            List<Stol> slobodniStolovi = Dogadjaj.trenutniDogadjaj.DohvatiSlobodneStolove();
            comboBoxStolovi.DataSource = slobodniStolovi;
            comboBoxStolovi.DisplayMember = slobodniStolovi.ToString();
        }
        private bool ValidacijaRezervacije(Stol odabraniStol, int brojLjudi)
        {
            // provjerava se da li nije unesen prevelik broj ljudi za odabrani stol
            return odabraniStol.MaxMjesta >= brojLjudi;
            
        }
    }
}
