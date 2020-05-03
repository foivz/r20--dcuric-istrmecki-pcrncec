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
    public partial class FormaDodajKlub : Form
    {
        string inputNazivKluba = "";
        int inputMaxKapacitet = 0;
        public FormaDodajKlub()
        {
            InitializeComponent();
        }

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDodajKlub_Click(object sender, EventArgs e)
        {
            // dodaje se novi klub u listu
            // ova metoda kao i sve ostale nisu još do kraja implementirane
            try { 
                inputNazivKluba = textBoxNaziv.Text;
                inputMaxKapacitet = Convert.ToInt32(textBoxKapacitet.Text);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Krivi unos!");
            }
        }
    }
}
