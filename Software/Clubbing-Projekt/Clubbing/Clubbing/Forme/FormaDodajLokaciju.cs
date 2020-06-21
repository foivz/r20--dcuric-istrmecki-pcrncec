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
    public partial class FormaDodajLokaciju : Form
    {
        private bool novaLokacija;
        public FormaDodajLokaciju(bool novaLokacija)
        {
            // ako je novaLokacija == true onda se dodaje nova lokacija
            // ako nova lokacija == false onda se uređuje sadašnja lokacija (samo je jedna lokacija moguća za jedan klub)
            this.novaLokacija = novaLokacija;
            InitializeComponent();
        }

        private void BtnDodajLokaciju_Click(object sender, EventArgs e)
        {
            if (ValidacijaLokacije())
            {
                try
                {
                    string inputGrad = textBoxGrad.Text;
                    string inputUlica = textBoxUlica.Text;
                    int inputPostankiBroj = Convert.ToInt32(textBoxPostanskiBroj.Text);
                    if (novaLokacija)
                    {
                        Lokacija lokacija = new Lokacija(inputGrad, inputUlica, inputPostankiBroj);
                        lokacija.IDLokacija = lokacija.DodajLokacijuUBazu();
                        Korisnik.PrijavljeniKorisnik.DohvatiKlubAdmina().Lokacija = lokacija;
                    }
                    else
                    {
                        Lokacija lokacija = Korisnik.PrijavljeniKorisnik.DohvatiKlubAdmina().Lokacija;
                        lokacija.Grad = inputGrad;
                        lokacija.Ulica = inputUlica;
                        lokacija.PostanskiBroj = inputPostankiBroj;
                        lokacija.AzurirajLokacijuUBazi();
                    }
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Unos poštanskog broja mora biti broj!");
                }
            }
            else
            {
                MessageBox.Show("Niste unijeli sve potrebne podatke!", "Greška");
            }
        }

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool ValidacijaLokacije()
        {
            return !(string.IsNullOrEmpty(textBoxGrad.Text) || string.IsNullOrEmpty(textBoxUlica.Text) || string.IsNullOrEmpty(textBoxPostanskiBroj.Text));
        }
        private void FormaDodajLokaciju_Load(object sender, EventArgs e)
        {
            if (!novaLokacija)
            {
                Lokacija lokacija = Korisnik.PrijavljeniKorisnik.DohvatiKlubAdmina().Lokacija;
                textBoxGrad.Text = lokacija.Grad;
                textBoxPostanskiBroj.Text = lokacija.PostanskiBroj.ToString();
                textBoxUlica.Text = lokacija.Ulica;
            }
        }
    }
}
