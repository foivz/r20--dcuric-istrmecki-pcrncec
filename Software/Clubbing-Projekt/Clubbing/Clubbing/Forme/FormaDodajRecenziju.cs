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
        private int inputOcjena = -1;
        private string inputOpis = null;
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
                    inputOcjena = Convert.ToInt32(textBoxOcjena.Text);
                    inputOpis = textBoxOpis.Text;
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Ocjena mora biti broj!");
                }
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
    }
}
