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
        private int inputBrojLjudi;
        private Stol inputStol = null;
        public FormaDodajRezervaciju()
        {
            InitializeComponent();
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            // pokusava dodati novu rezervaciju
            try
            {
                inputBrojLjudi = Convert.ToInt32(textBoxBrojLjudi.Text);
                // inputStol = (Stol)listViewStolovi.SelectedItems[0];
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
            // ovdje se popunjava Listview iz baze uz određene uvijete
            // primjer uvijeta je da se odaberu samo oni stolovi koji nisu već rezervirani za odabrani događaj
            // osim toga mora ze zadovoljiti metoda ValidacijaRezervaijce()
        }
        private bool ValidacijaRezervacije()
        {
            return false;
        }
    }
}
