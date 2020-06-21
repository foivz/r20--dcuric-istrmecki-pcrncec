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
    public partial class FormaDodajStol : Form
    {
        private string inputNazivLokacije = "";
        private int inputMaxMjesta = 1;
        public FormaDodajStol()
        {
            InitializeComponent();
        }

        private void BtnDodajStol_Click(object sender, EventArgs e)
        {
            try
            {
                inputMaxMjesta = Convert.ToInt32(textBoxMaxMjesta.Text);
                inputNazivLokacije = textBoxNazivLokacije.Text;
                if (ValidacijaStola(inputMaxMjesta))
                {
                    Stol stol = new Stol(inputNazivLokacije, inputMaxMjesta);
                    int idStol = stol.DodajStolUBazu();
                    stol.IDStol = idStol;
                    Dogadjaj.trenutniDogadjaj.Stolovi.Add(stol);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Odabrali ste prevelik broj maksmialnih mjesta za stolom!", "Greška");
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
        private bool ValidacijaStola(int maxMjesta)
        {
            // metoda koja se koristi neposredno prije dodavanja novog stola (novog objekta klase) kako bi se eventualno zabranilo dodavanje novog stola
            // jedan stol = jedna rezervacija
            // usporedba max rezervacija događaja i njegovih svih dosadasnjih kapacteta stolova + kapacitet novog stola
            int suma = Dogadjaj.trenutniDogadjaj.Stolovi.Sum(x => x.MaxMjesta) + maxMjesta;
            if (Dogadjaj.trenutniDogadjaj.MaxRezervacija < suma) return false;
            else return true;
        }
    }
}
