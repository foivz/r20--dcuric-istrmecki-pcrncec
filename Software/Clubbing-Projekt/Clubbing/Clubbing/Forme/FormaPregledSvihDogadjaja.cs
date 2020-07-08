using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clubbing.Forme;
using Clubbing.Modeli;
using ClubbingClassLibrary;

namespace Clubbing.Forme
{
    public partial class FormaPregledSvihDogadjaja : Form
    {
        private BindingList<Dogadjaj> dogadjaji = new BindingList<Dogadjaj>();
        private int opcijaPrikaza;
        public FormaPregledSvihDogadjaja(int opcijaPrikaza)
        {
            this.opcijaPrikaza = opcijaPrikaza;
            InitializeComponent();
        }

        private void FormaPregledSvihDogadjaja_Load(object sender, EventArgs e)
        {
            // učitava sve događaje u dgv na temelju odabranih opcija
            PrikaziDogadjaje(opcijaPrikaza);
        }
        private void PrikaziDogadjaje(int opcijaPrikaza)
        {
            // funkcija za azuriranje popisa dogadjaja u dgv-u
            // kako je moguće na ovu formu doći iz više različitih formi, postoje razne opcije prikaza podataka, ovisno s koje forme se dođe
            // ako je opcijaPrikaza = 0, onda prikazuje sve moguće događaje
            // ako je opcijaPrikaza = 1, onda prikazuje sve događaje za prethodno odabrani klub
            // ako je opciajPrikaza = 2, onda priakzuje sve događaje koji su dostupni za rezervaciju
            if (opcijaPrikaza == 0)
            {
                foreach (Klub klub in Klub.SviKlubovi)
                {
                    foreach (Dogadjaj dogadjaj in klub.Dogadjaji)
                    {
                        dogadjaji.Add(dogadjaj);
                    }
                }
            }
            else if(opcijaPrikaza==1)
            {
                dogadjaji = Klub.trenutniKlub.Dogadjaji;
            }
            else if (opcijaPrikaza == 2)
            {
                dogadjaji = Dogadjaj.DohvatiDogadjajeZaRezervaciju();
            }
            dgvDogadjaji.DataSource = null;
            dgvDogadjaji.DataSource = dogadjaji;
            dgvDogadjaji.Columns["IDDogadjaj"].Visible = false;
            dgvDogadjaji.Columns[1].HeaderText = "Naziv događaja";
            dgvDogadjaji.Columns[2].HeaderText = "Opis";
            dgvDogadjaji.Columns[3].HeaderText = "Datum početka";
            dgvDogadjaji.Columns[4].HeaderText = "Datum završetka";
            dgvDogadjaji.Columns[5].HeaderText = "Cijena ulaznice";
            dgvDogadjaji.Columns[6].HeaderText = "Maksimalno rezervacija";
        }

        private void BtnRezerviraj_Click(object sender, EventArgs e)
        {
            // pritiskom na ovaj gumb se otvara forma FormaDodajRezervaciju na kojoj se dodaje rezervacija za odabrani događaj
            // ta akcija se sprječava ako je korisnik već rezervirao odabrani događaj ili ako se odabere završen događaj
            if (DogadjajLib.Nadolazeci(Dogadjaj.trenutniDogadjaj.DatumPocetka))
            {
                var mojeRezervacije = Korisnik.PrijavljeniKorisnik.Rezervacije.Select(x => x.IDRezervacija);
                bool vecRezervirano = Dogadjaj.trenutniDogadjaj.Rezervacije.Select(id => id.IDRezervacija).Intersect(mojeRezervacije).Any();
                if (!vecRezervirano)
                {
                    FormaDodajRezervaciju formaDodajRezervaciju = new FormaDodajRezervaciju();
                    formaDodajRezervaciju.Show();
                }
                else
                {
                    MessageBox.Show("Već ste rezervirali ovaj događaj");
                }
            }
            else
            {
                MessageBox.Show("Ne možete rezervirati događaj koji je već završen!", "Greška");
            }

        }

        private void BtnGalerijaDogadjaja_Click(object sender, EventArgs e)
        {
            // pritiskom na ovaj gumb se otvara forma galerije dogadjaja/klubova
            // ta akcija se sprječava, odnosno gumb se onemogućuje ukoliko se odabere nadolazeći događaj
            if (Dogadjaj.trenutniDogadjaj != null)
            {
                FormaGalerija formaGalerija = new FormaGalerija();
                formaGalerija.ShowDialog();
            }
            else
            {
                MessageBox.Show("Morate prvo odabrati događaj na tablici!", "Greška");
            }
        }

        private void BtnPovratak_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOtvoriKlub_Click(object sender, EventArgs e)
        {
            // otvara klub koji organizira odabrani događaj
            FormaKlub formaKlub = new FormaKlub();
            this.Hide();
            formaKlub.ShowDialog();
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            // nakon pritiska na gumb 'Filtriraj' filtrira (mijenja) atribut klubovi s obzirom na odabranu opciju
            if (radioBtnSvi.Checked)
            {
                dgvDogadjaji.DataSource = dogadjaji;
            }
            else if (radioBtnZavrseni.Checked)
            {
                dgvDogadjaji.DataSource = dogadjaji.Where(x => DogadjajLib.Zavrseni(x.DatumZavrsetka)).ToList();
            }
            else if (radioBtnNadolazeci.Checked)
            {
                dgvDogadjaji.DataSource = dogadjaji.Where(x => DogadjajLib.Nadolazeci(x.DatumPocetka)).ToList();
            }
        }
        private Dogadjaj DohvatiOdabraniDogadjaj()
        {
            // vraća odabrani događaj iz dgv-a
            if (dgvDogadjaji.CurrentRow != null)
            {
                return dgvDogadjaji.CurrentRow.DataBoundItem as Dogadjaj;
            }
            else return null;
        }
        private Klub DohvatiOdabraniKlub()
        {
            int idDogadjaj = Dogadjaj.trenutniDogadjaj.IDDogadjaj;
            foreach (Klub klub in Klub.SviKlubovi)
            {
                if (klub.Dogadjaji.Select(x => x.IDDogadjaj).Contains(idDogadjaj))
                {
                    return klub;
                }
            }
            MessageBox.Show("Greška pri otvaranju kluba", "Greška");
            return null;
        }
        private void dgvDogadjaji_CurrentCellChanged(object sender, EventArgs e)
        {
            Dogadjaj.trenutniDogadjaj = DohvatiOdabraniDogadjaj();
            if (Dogadjaj.trenutniDogadjaj != null)
            {
                Klub.trenutniKlub = DohvatiOdabraniKlub();
                if (!AutorizacijaRezervacije())
                {
                    BtnRezerviraj.Enabled = false;
                }
                else
                {
                    BtnRezerviraj.Enabled = true;
                }
            }
        }
        private bool AutorizacijaRezervacije()
        {
            // admin ne smije rezervirati svoj događaj svojeg kluba, pa mu se tak opcija sakriva
            Klub klubAdmina = Korisnik.PrijavljeniKorisnik.DohvatiKlubAdmina();
            if (klubAdmina != null)
            {
                foreach (Dogadjaj dogadjaj in klubAdmina.Dogadjaji)
                {
                    if (Dogadjaj.trenutniDogadjaj.IDDogadjaj == dogadjaj.IDDogadjaj)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
