using Clubbing.Modeli;
using Clubbing.Podaci;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clubbing.Forme
{
    public partial class FormaDodajKlub : Form
    {
        private Image logo;
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
            try {
                string inputNazivKluba = textBoxNaziv.Text;
                int inputMaxKapacitet = Convert.ToInt32(textBoxKapacitet.Text);
                int inputZanr = Convert.ToInt32(comboBoxZanr.SelectedValue);
                if (string.IsNullOrEmpty(inputNazivKluba) || inputMaxKapacitet <= 0 || logo==null)
                {
                    MessageBox.Show("Krivi unos!");
                    return;
                }
                if (ValidacijaKlub(inputNazivKluba) == false) return;
                Modeli.Klub klub = new Modeli.Klub(inputNazivKluba, inputMaxKapacitet, logo, inputZanr , Modeli.Korisnik.PrijavljeniKorisnik);
                int idKlub = klub.DodajKlubUBazu(logo);
                klub.IDKlub = idKlub;
                Modeli.Klub.SviKlubovi.Add(klub);
                this.Close();
           
            }
            catch
            {
                MessageBox.Show("Krivi unos!");
            }
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                logo = Image.FromFile(openFileDialog.FileName);
            }
        }
        private bool ValidacijaKlub(string nazivKluba)
        {
            if (nazivKluba.Length > 50)
            {
                MessageBox.Show("Naziv kluba je predugačak!");
                return false;
            }
            using(Entities entities = new Entities())
            {
                entities.Klubs.Load();
                int postojeciKlub = (from klub in entities.Klubs
                                     where klub.naziv == nazivKluba
                                     select klub).Count();
                if (postojeciKlub > 0)
                {
                    MessageBox.Show("Postoji već klub s tim nazivom");
                    return false;
                }
            }
            return true;
        }

        private void FormaDodajKlub_Load(object sender, EventArgs e)
        {
            using(Entities entities = new Entities())
            {
                entities.Zanrs.Load();
                zanrBindingSource.DataSource = entities.Zanrs.ToList();
            }
        }
    }
}
