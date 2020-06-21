using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clubbing.Modeli;
using Clubbing.Forme;

namespace Clubbing.Forme
{
    public partial class FormaSveRezervacije : Form
    {
        private List<Rezervacija> mojeRezervacije = new List<Rezervacija>();
        private Rezervacija trenutnaRezervacija = null;
        public FormaSveRezervacije()
        {
            InitializeComponent();
        }

        private void FormaSveRezervacije_Load(object sender, EventArgs e)
        {
            PrikaziRezervacije();
        }
        private void PrikaziRezervacije()
        {
            // ako korisnik nije admin - prikazuje sve rezervacije nekog korisnika, sakriva gumbove odbij i prihvati rezervaiciju
            // ako je korisnik admin - prikazuje sve zahtjeve za rezervacije iz baze
            dgvRezervacije.DataSource = null;
            mojeRezervacije.Clear();
            if (Korisnik.PrijavljeniKorisnik.Admin)
            {
                Klub mojKlub = Korisnik.PrijavljeniKorisnik.DohvatiKlubAdmina();
                foreach (Dogadjaj dogadjaj in mojKlub.Dogadjaji)
                {
                    foreach(Rezervacija rezervacija in dogadjaj.Rezervacije)
                    {
                        mojeRezervacije.Add(rezervacija);
                    }
                }
                dgvRezervacije.DataSource = mojeRezervacije;
            }
            else
            {
                mojeRezervacije = Korisnik.PrijavljeniKorisnik.Rezervacije;
                dgvRezervacije.DataSource = mojeRezervacije;
                BtnPotvrdi.Visible = false;
                BtnOdbij.Visible = false;
            }
            dgvRezervacije.Columns["IDRezervacija"].Visible = false;
        }
        private void BtnNovaRezervacija_Click(object sender, EventArgs e)
        {
            // otvara formu s onim događajima koji su dostupni za rezervaiju (nadolazeći i ima još slobodnih stolova)
            FormaPregledSvihDogadjaja formaPregledSvihDogadjaja = new FormaPregledSvihDogadjaja(2);
            formaPregledSvihDogadjaja.Show();
        }

        private void BtnPotvrdi_Click(object sender, EventArgs e)
        {
            if(trenutnaRezervacija.Status.Naziv == "Na čekanju")
            {
                trenutnaRezervacija.Potvrdi();
                PrikaziRezervacije();
            }
            else
            {
                MessageBox.Show("Ne možete više mijenjati ovu rezervaciju!", "Greška");
            }
            
        }

        private void BtnOdbij_Click(object sender, EventArgs e)
        {
            if (trenutnaRezervacija.Status.Naziv == "Na čekanju")
            {
                trenutnaRezervacija.Odbij();
                PrikaziRezervacije();
            }
            else
            {
                MessageBox.Show("Ne možete više mijenjati ovu rezervaciju!", "Greška");
            }
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            dgvRezervacije.DataSource = null;
            string odabir = comboBox.SelectedItem.ToString();
            if (odabir=="Sve rezervacije")
            {
                dgvRezervacije.DataSource = mojeRezervacije;
            }
            else
            {
                dgvRezervacije.DataSource = mojeRezervacije.Where(x => x.Status.Naziv == odabir).ToList();
            }
            dgvRezervacije.Columns["IDRezervacija"].Visible = false;
        }

        private void dgvRezervacije_CurrentCellChanged(object sender, EventArgs e)
        {

            if (dgvRezervacije.CurrentRow != null) { 
                trenutnaRezervacija = dgvRezervacije.CurrentRow.DataBoundItem as Rezervacija;
                labelDogadjaj.Text = "Događaj: " + trenutnaRezervacija.DohvatiImeDogađaja();
                labelKorisnik.Text = "Korisnik: " + trenutnaRezervacija.DohvatiImeKorisnika();
            }
            else
            {
                labelDogadjaj.Text = "";
                labelKorisnik.Text = "";
            }
        }
    }
}
