using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Clubbing.Forme;
using Clubbing.Modeli;
using Clubbing.Podaci;

namespace Clubbing.Forme
{
    public partial class FormaKlubovi : Form
    {
        private BindingList<Modeli.Klub> filtriraniKlubovi = new BindingList<Modeli.Klub>(); // koristit će se kod filtriranja klubova
        public FormaKlubovi()
        {
            InitializeComponent();
        }

        private void BtnPrikaziKlubove_Click(object sender, EventArgs e)
        {
            // pritiskom na button se prikazuju svi klubovi s obzirom na odabrane opcije u dgv (odabrani žanr/ovi i ocjena/e)
            // radi na istom principu kao i ostala filtriranja u ovoj aplikaciji

            // filtriranje po ocjeni
            filtriraniKlubovi.Clear();
            BindingList<Modeli.Klub> filtriraniKluboviOcjene = new BindingList<Modeli.Klub>();
            List<int> odabraneOcjene = new List<int>();
            foreach (var item in checkedListBox.CheckedItems)
            {
                odabraneOcjene.Add(Convert.ToInt32(item));
            }
            foreach (Modeli.Klub filtriraniKlub in Modeli.Klub.SviKlubovi)
            {
                int x = filtriraniKlub.IzracunajProsjekOcjena();
                if (odabraneOcjene.Contains(x))
                {
                    filtriraniKluboviOcjene.Add(filtriraniKlub);
                }
            }

            // filtriranje po zanrovima
            List<string> odabraniZanrovi = new List<string>();
            foreach (CheckBox c in groupBox.Controls.OfType<CheckBox>())
            {
                if (c.Checked)
                {
                    odabraniZanrovi.Add(c.Name);
                }
            }
            if(odabraneOcjene.Count == 0 && odabraniZanrovi.Count == 0)
            {
                AzurirajPopisKlubova(false);
                return;
            }
            if(odabraneOcjene.Count>0 && odabraniZanrovi.Count == 0)
            {
                filtriraniKlubovi = filtriraniKluboviOcjene;
                AzurirajPopisKlubova(true);
                return;
            }
            using(Entities entities = new Entities())
            {
                entities.Zanrs.Load();
                List<Zanr> listaOdabranihZanrova = (from zanr in entities.Zanrs
                                                   where odabraniZanrovi.Contains(zanr.naziv)
                                                   select zanr).ToList();
                foreach (Zanr zanr in listaOdabranihZanrova)
                {
                    foreach (Podaci.Klub klub in zanr.Klubs)
                    {
                        bool postoji = filtriraniKluboviOcjene.Select(x => x.IDKlub).Contains(klub.id_klub);
                        if (postoji || odabraneOcjene.Count == 0)
                        {
                            Modeli.Klub filtriraniKlub = Modeli.Klub.SviKlubovi.Where(x=> x.IDKlub==klub.id_klub).First();
                            filtriraniKlubovi.Add(filtriraniKlub);
                        }
                    }
                }
            }
            AzurirajPopisKlubova(true);
        }
        private void FormaKlubovi_Load(object sender, EventArgs e)
        {
            KreirajCheckBoxeve();
            AzurirajPopisKlubova(false);
            if (!Modeli.Korisnik.PrijavljeniKorisnik.Admin)
            {
                BtnDodajKlub.Visible = false;
                BtnObrisiKlub.Visible = false;
            }
        }
        private void KreirajCheckBoxeve()
        {
            // dinamičko kreiranje checkboxeva (žanrovi)
            using (Entities entities = new Entities())
            {
                entities.Zanrs.Load();
                List<string> zanrovi = (from z in entities.Zanrs
                                        select z.naziv).ToList();
                int h = 220;
                CheckBox box;
                foreach (string nazivZanr in zanrovi)
                {
                    box = new CheckBox();
                    box.Text = nazivZanr;
                    box.Name = nazivZanr;
                    box.Size = new Size(52, 17);
                    box.Location = new Point(10, h);
                    box.AutoSize = true;
                    groupBox.Controls.Add(box);
                    h += 22;
                }
            }
        }
        private void BtnDodajKlub_Click(object sender, EventArgs e)
        {
            // pristup za ovaj button ima samo admin, i to samo ako nema nijedan klub (svaki admin ima samo jedan klub, tj. upravlja jednim klubom) 
            // dodaje novi klub u bazu i stvara novi objekt klase Klub i dodaje ga listu svih klubova
            // ažurira se dgv
            if (Modeli.Korisnik.PrijavljeniKorisnik.DohvatiKlubAdmina() == null)
            {
                FormaDodajKlub formaDodajKlub = new FormaDodajKlub();
                formaDodajKlub.ShowDialog();
                AzurirajPopisKlubova(false);
            }
            else
            {
                MessageBox.Show("Smijete imati samo jedan kreirani klub!", "Greška");
            }
        }

        private void BtnObrisiKlub_Click(object sender, EventArgs e)
        {
            // pristup za ovaj button ima samo admin, i to samo ako ima dodjeljen klub (svaki admin ima samo jedan klub, tj. upravlja jednim klubom) 
            // briše se klub iz liste svih klubova (klasa Klub) i iz baze
            // ažurira se dgv
            if (Modeli.Klub.trenutniKlub != null)
            {
                int klubAdminaID = Modeli.Korisnik.PrijavljeniKorisnik.DohvatiKlubAdmina().IDKlub;
                if(Modeli.Klub.trenutniKlub.IDKlub == klubAdminaID)
                {
                    Modeli.Klub.trenutniKlub.ObrisiKlubIzBaze();
                    Modeli.Klub.SviKlubovi.Remove(Modeli.Klub.trenutniKlub);
                }
                else
                {
                    MessageBox.Show("Ne možete obrisati klub koji nije vaš", "Greška");
                }
            }
            else
            {
                MessageBox.Show("Morate prvo odabrati klub!", "Greška");
            }
        }

        private void AzurirajPopisKlubova(bool filtriranje)
        {
            // funkcija za azuriranje popisa klubova u dgv-u
            dataGridViewKlubovi.DataSource = null;
            if (filtriranje)
            {
                dataGridViewKlubovi.DataSource = filtriraniKlubovi;
            }
            else
            {
                // Modeli.Klub.PostaviSveKlubove();
                dataGridViewKlubovi.DataSource = Modeli.Klub.SviKlubovi;
            }
            dataGridViewKlubovi.Columns["IDKlub"].Visible = false;
            dataGridViewKlubovi.Columns["Logo"].Visible = false;
            dataGridViewKlubovi.Columns["FKZanr"].Visible = false;
            dataGridViewKlubovi.Columns["Lokacija"].Visible = false;
        }
        private void BtnOtvoriKlub_Click(object sender, EventArgs e)
        {
            // otvara novu formu gdje se nalaze dodatne informacije o odabranom klubu
            if (Modeli.Klub.trenutniKlub != null)
            {
                FormaKlub formaKlub = new FormaKlub();
                formaKlub.Show();
            }
            else
            {
                MessageBox.Show("Morate prvo odabrati klub!", "Greška");
            }
        }
        private Modeli.Klub DohvatiOdabraniKlub()
        {
            if (dataGridViewKlubovi.CurrentRow != null)
            {
                return dataGridViewKlubovi.CurrentRow.DataBoundItem as Modeli.Klub;
            }
            else return null;
        }

        private void dataGridViewKlubovi_CurrentCellChanged(object sender, EventArgs e)
        {
            // postavlja odabrani klub u static varijablu trenutniKlub (klasa Klub)
            Modeli.Klub.trenutniKlub = DohvatiOdabraniKlub();
        }

    }
}
