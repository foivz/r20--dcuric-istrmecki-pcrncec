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
    public partial class FormaDodajRecenziju : Form
    {
        private bool zaKlub;
        public FormaDodajRecenziju(bool zaKlub)
        {
            // ako je zaKlub = true onda se radi recenzija za odabrani klub (općenitije)
            // ako je zaKlub = false onda se radi recenzija za odabrani događaj 
            this.zaKlub = zaKlub;
            InitializeComponent();
        }

        private void BtnDodajRecenziju_Click(object sender, EventArgs e)
        {
            // dodaje recenziju na temelju unosa
            // ako unos nedostaje ili je u krivom formatu onda se to ispisuje korisniku kao upozorenje
            if (!string.IsNullOrEmpty(textBoxOcjena.Text) && !string.IsNullOrEmpty(textBoxOpis.Text)) {
                try
                {
                    int inputOcjena = Convert.ToInt32(textBoxOcjena.Text);
                    string inputOpis = textBoxOpis.Text;
                    Recenzija recenzija = new Recenzija(inputOcjena, inputOpis, zaKlub);
                    if (zaKlub)
                    {
                        int id = recenzija.DodajRecenzijuKlubUBazu();
                        recenzija.IDRecenzija = id;
                        Klub.trenutniKlub.Recenzije.Add(recenzija);
                    }
                    else
                    {
                        int id = recenzija.DodajRecenzijuDogadjajUBazu();
                        recenzija.IDRecenzija = id;
                        Dogadjaj.trenutniDogadjaj.RecenzijeDogadjaja.Add(recenzija);
                    }
                    Obavijest obavijest = new Obavijest(GenerirajOpisObavijesti(recenzija, zaKlub), DateTime.Now);
                    obavijest.DodajObavijestUBazu(false);
                }
                catch
                {
                    MessageBox.Show("Ocjena mora biti broj!");
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Niste unijeli sve podatke!");
            }
        }

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string GenerirajOpisObavijesti(Recenzija recenzija, bool zaKlub)
        {
            string punoImeKorisnika = Korisnik.PrijavljeniKorisnik.ToString();
            if (zaKlub)
            {
                return punoImeKorisnika + " je ocijenio klub s " + recenzija.Ocjena + ". Mišljenje: " + recenzija.Opis;
            }
            else
            {
                return punoImeKorisnika + " je ocijenio događaj: " + Dogadjaj.trenutniDogadjaj.NazivDogadjaja + " s " + recenzija.Ocjena + ". Mišljenje: " + recenzija.Opis;
            }
            
        }
    }
}
