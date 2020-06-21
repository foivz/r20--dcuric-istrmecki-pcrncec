using Clubbing.Podaci;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clubbing.Forme
{
    public partial class FormaRegistracija : Form
    {
        public FormaRegistracija()
        {
            InitializeComponent();
        }

        private void BtnRegistracija_Click(object sender, EventArgs e)
        {
            // provjera se ispravnost unesenih podataka (ValidacijaRezervacija()) i ako su ispravni se kreira novi korisnik u bazi
            // ako podaci nisu ispravni, korisniku prikazuje poruka o neispravnosti podataka (poruka grešeke) i ponovno se pokušava registrirati
            if (ValidacijaRegistracije() == true)
            {
                using (Entities entities = new Entities())
                {
                    Korisnik korisnik = new Korisnik()
                    {
                        ime = textBoxIme.Text,
                        prezime = textBoxPrezime.Text,
                        korisnicko_ime = textBoxKorisnickoIme.Text,
                        lozinka = textBoxLozinka.Text,
                        admin = (byte)(checkBoxAdmin.Checked ? 1 : 0)
                    };
                    entities.Korisniks.Add(korisnik);
                    entities.SaveChanges();
                }
                this.Hide();
                FormaPrijava formaPrijava = new FormaPrijava();
                formaPrijava.Show();
            }
        }
        private bool ValidacijaRegistracije()
        {
            string ime = textBoxIme.Text;
            string prezime = textBoxPrezime.Text;
            string korime = textBoxKorisnickoIme.Text;
            string lozinka = textBoxLozinka.Text;
            string lozinkaPotvrda = textBoxLozinka2.Text;
            int postojeciKorisnik = 0;

            using (Entities entities = new Entities())
            {
                entities.Korisniks.Load();
                postojeciKorisnik = (from kor in entities.Korisniks
                                     where kor.korisnicko_ime == korime
                                     select kor).Count();

            }

            if (string.IsNullOrEmpty(ime) || string.IsNullOrEmpty(prezime) || string.IsNullOrEmpty(korime) || string.IsNullOrEmpty(lozinka) || string.IsNullOrEmpty(lozinkaPotvrda))
            {
                MessageBox.Show("Niste unijeli sve potrebne podatke za registraciju!");
                return false;
            }
            if (lozinka != lozinkaPotvrda)
            {
                MessageBox.Show("Unesene lozinke se moraju podudarati!");
                return false;
            }
            if (postojeciKorisnik > 0)
            {
                MessageBox.Show("Postoji već korisnik s unesenim korisničkim imenom!");
                return false;
            }
            return true;
        }

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaPrijava formaPrijava = new FormaPrijava();
            formaPrijava.Show();
        }
    }
}
