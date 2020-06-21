using Clubbing.Forme;
using Clubbing.Modeli;
using Clubbing.Podaci;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clubbing
{
    public partial class FormaPrijava : Form
    {
        string inputKorisnickoIme = "";
        string inputLozinka = "";
        public FormaPrijava()
        {
            InitializeComponent();
        }
        private bool ValidacijaPrijave()
        {
            using(Entities entities = new Entities())
            {
                entities.Korisniks.Load();
                var korisnik = (from kor in entities.Korisniks
                               where kor.korisnicko_ime == inputKorisnickoIme && kor.lozinka == inputLozinka
                               select kor).FirstOrDefault();
                if (korisnik != null)
                {
                    int id = korisnik.id_korisnik;
                    string ime = korisnik.ime;
                    string prezime = korisnik.prezime;
                    string korime = korisnik.korisnicko_ime;
                    string lozinka = korisnik.lozinka;
                    bool admin = korisnik.admin == 1;
                    Modeli.Korisnik.PrijavljeniKorisnik = new Modeli.Korisnik(id, ime, prezime, korime, lozinka, admin);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void BtnRegistracija_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaRegistracija formaRegistracija = new FormaRegistracija();
            formaRegistracija.ShowDialog();
        }

        private void BtnPrijava_Click(object sender, EventArgs e)
        {
            inputKorisnickoIme = textBoxUsername.Text;
            inputLozinka = textBoxPassword.Text;
            if(string.IsNullOrEmpty(inputKorisnickoIme) || string.IsNullOrEmpty(inputLozinka))
            {
                MessageBox.Show("Niste unijeli sve potrebne podatke za prijavu!");
            }
            else
            { 
                if (ValidacijaPrijave())
                {
                    this.Hide();
                    FormaGlavniMeni glavnaForma = new FormaGlavniMeni();
                    glavnaForma.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Unijeli ste krive podatke za prijavu");
                }
            }
        }
    }
}
