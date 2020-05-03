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
        private string inputGrad = "";
        private string inputUlica = "";
        private int inputPostankiBroj = 10000;
        private bool NovaLokacija{ get; set; }
        public FormaDodajLokaciju(bool novaLokacija)
        {
            // ako je novaLokacija == true onda se dodaje nova lokacija
            // ako nova lokacija == false onda se uređuje sadašnja lokacija (samo je jedna lokacija moguća za jedan klub)
            NovaLokacija = novaLokacija;
            InitializeComponent();
        }

        private void BtnDodajLokaciju_Click(object sender, EventArgs e)
        {
            try { 
                // TODO: provjeriti ako je sve uneseno i ostale provjere po potrebi
                inputGrad = textBoxGrad.Text;
                inputUlica = textBoxUlica.Text;
                inputPostankiBroj = Convert.ToInt32(textBoxPostanskiBroj.Text);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Unos poštanskog broja mora biti broj!");
            }
        }

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
