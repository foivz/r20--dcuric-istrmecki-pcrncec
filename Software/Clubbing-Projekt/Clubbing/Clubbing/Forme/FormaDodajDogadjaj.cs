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

        public FormaDodajDogadjaj()
        {
            InitializeComponent();
        }

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDodajDogadjaj_Click(object sender, EventArgs e)
        {
            // pokusava dodati novi dogadjaj u listu dogadjaja za klub admina
            // nije jos sve do kraja dovrseno
            try
            {
                inputNaziv = textBoxNaziv.Text;
                inputOpis = textBoxOpis.Text;
                inputDatumPocetka = Convert.ToDateTime(textBoxPocetak.Text);
                inputDatumZavrsetka = Convert.ToDateTime(textBoxZavrsetak.Text);
                inputCijenaUlaznice = Convert.ToInt32(textBoxCijena.Text);
                inputMaxRezervacija = Convert.ToInt32(textBoxMaxRez.Text);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Krivi unos!");
            }
        }
    }
}
