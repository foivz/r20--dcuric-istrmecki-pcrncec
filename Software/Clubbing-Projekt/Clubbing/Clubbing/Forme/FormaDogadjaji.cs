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
using Clubbing.Forme;

namespace Clubbing.Forme
{
    public partial class FormaDogadjaji : Form
    {
        public FormaDogadjaji()
        {
            InitializeComponent();
        }

        private void FormaDogadjaji_Load(object sender, EventArgs e)
        {
            // prikazuje u dgv sve dogadjaje adminovog kluba ili dogadjaje na kojima je korisnik (klijent) bio
            PrikaziDogadjaje();
            if (!Korisnik.PrijavljeniKorisnik.Admin)
            {
                groupBox.Visible = false;
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
        private void PrikaziDogadjaje()
        {
            // funkcija za prikaz popisa dogadjaja u dgv-u
            dgvDogadjaji.DataSource = null;
            if (Korisnik.PrijavljeniKorisnik.Admin)
            {
                Klub klubAdmina = Korisnik.PrijavljeniKorisnik.DohvatiKlubAdmina();
                if (klubAdmina != null)
                {
                    dgvDogadjaji.DataSource = klubAdmina.Dogadjaji;
                    dgvDogadjaji.Columns["IDDogadjaj"].Visible = false;
                }
                else
                {
                    MessageBox.Show("Još niste kreirali svoj klub", "Upozorenje");
                    groupBox.Visible = false;
                }
            }
            else
            {
                BindingList<Dogadjaj> dogadjaji = Korisnik.PrijavljeniKorisnik.DohvatiKlijentoveDogadjaje();
                if (dogadjaji != null)
                {
                    dgvDogadjaji.DataSource = dogadjaji;
                    dgvDogadjaji.Columns["IDDogadjaj"].Visible = false;
                }
            }

        }
        private void BtnObrisiDogadjaj_Click(object sender, EventArgs e)
        {
            // pristup ove i ostalih mogućnosti iz grupe upravljanje događajima ima samo admin nekog kluba za njegov klub
            // briše odabrani događaj u dgv-u i iz baze
            if (Dogadjaj.trenutniDogadjaj != null)
            {
                Dogadjaj.trenutniDogadjaj.ObrisiDogadjajIzBaze();
                Klub klubAdmina = Korisnik.PrijavljeniKorisnik.DohvatiKlubAdmina();
                klubAdmina.Dogadjaji.Remove(Dogadjaj.trenutniDogadjaj);
            }
            else
            {
                MessageBox.Show("Morate prvo odabrati događaj na tablici!", "Greška");
            }
            
        }
        private void BtnDodajDogadjaj_Click(object sender, EventArgs e)
        {
            // otvara formu za dodavanje novog događaja te ga dodaje u listu dogadjaji za klub admina
            FormaDodajDogadjaj formaDodajDogadjaj = new FormaDodajDogadjaj(true);
            formaDodajDogadjaj.ShowDialog();
            PrikaziDogadjaje();
        }

        private void BtnUrediDogadjaj_Click(object sender, EventArgs e)
        {
            // otvara formu za promjenu podataka odabranog događaja
            // to je ista forma kao i kod dodavanja događaja samo što su u ovom slučaju popunjeni podaci (inputi)
            if (Dogadjaj.trenutniDogadjaj != null)
            {
                FormaDodajDogadjaj formaDodajDogadjaj = new FormaDodajDogadjaj(false);
                formaDodajDogadjaj.ShowDialog();
                PrikaziDogadjaje();
            }
            else
            {
                MessageBox.Show("Morate prvo odabrati događaj na tablici!", "Greška");
            }
        }

        private void BtnDodajNoviStol_Click(object sender, EventArgs e)
        {
            // otvara formu za unos novog stola za odabrani događaj u dgv-u
            // dodavanje novog stola znači i novo moguće mjesto za rezervaciju korisnika aplikacije
            FormaDodajStol formaDodajStol = new FormaDodajStol();
            formaDodajStol.ShowDialog();
        }

        private void BtnPregledDogadjaja_Click(object sender, EventArgs e)
        {
            // otvara formu gdje se nalaze svi događaji koji postaje u bazi (svi događaji od svih postojećih klubova)
            FormaPregledSvihDogadjaja formaPregledSvihDogadjaja = new FormaPregledSvihDogadjaja(0);
            formaPregledSvihDogadjaja.ShowDialog();
        }

        private void BtnOcijeni_Click(object sender, EventArgs e)
        {
            // otvara formu za unos recenzije (ocjene)
            // obavezno treba unijeti parametar false kako bi se znalo da se unosi recenzija za događaj a ne za klub
            // ocijeniti događaj može samo klijent a ne admin
            if (!Korisnik.PrijavljeniKorisnik.Admin)
            {
                if (Dogadjaj.trenutniDogadjaj != null)
                {
                    if (Dogadjaj.trenutniDogadjaj.Zavrseni())
                    {
                        FormaDodajRecenziju formaDodajRecenziju = new FormaDodajRecenziju(false);
                        formaDodajRecenziju.ShowDialog();
                    }
                    else
                    {
                        // TODO: DODATI DA SE NE MOŽE OCIJENITI DOGAĐAJ NA KOJEM KORISNIK NIJE BIO
                        MessageBox.Show("Ne možete ocijeniti događaj koji još nije završen!");
                    }
                }
                else
                {
                    MessageBox.Show("Morate prvo odabrati događaj na tablici!", "Greška");
                }
            }
            else
            {
                MessageBox.Show("Ne možete ocijeniti svoje događaje", "Greška");
            }
        }
        private void BtnGalerijaDogadjaja_Click(object sender, EventArgs e)
        {
            // otvara formu s galerijom slika za odabrani događaj
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
        private void dgvDogadjaji_CurrentCellChanged(object sender, EventArgs e)
        {
            // postavlja odabrani dogadjaj u static varijablu trenutniDogadjaj (klasa Dogadjaj)
            Dogadjaj.trenutniDogadjaj = DohvatiOdabraniDogadjaj();
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            // nakon pritiska filtriraj ažurira listu događaja s obzirom na odabrane opcije
            dgvDogadjaji.DataSource = null;
            
            if (Korisnik.PrijavljeniKorisnik.Admin)
            {
                Klub klubAdmina = Korisnik.PrijavljeniKorisnik.DohvatiKlubAdmina();
                Filtriraj(klubAdmina.Dogadjaji);
            }
            else
            {
                BindingList<Dogadjaj> dogadjaji = Korisnik.PrijavljeniKorisnik.DohvatiKlijentoveDogadjaje();
                Filtriraj(dogadjaji);
            }
        }
        private void Filtriraj(BindingList<Dogadjaj> dogadjaji)
        {
            if (radioBtnSvi.Checked)
            {
                dgvDogadjaji.DataSource = dogadjaji;
            }
            else if (radioBtnZavrseni.Checked)
            {
                dgvDogadjaji.DataSource = dogadjaji.Where(x => x.Zavrseni()).ToList();
            }
            else if (radioBtnNadolazeci.Checked)
            {
                dgvDogadjaji.DataSource = dogadjaji.Where(x => x.Nadolazeci()).ToList();
            }
            dgvDogadjaji.Columns["IDDogadjaj"].Visible = false;
        }
    }
}
