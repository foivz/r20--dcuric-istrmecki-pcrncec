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

namespace Clubbing.Forme
{
    public partial class FormaKlubovi : Form
    {
        private BindingList<Klub> klubovi = null; // koristit će se kod prikaza klubova u dgv-u i filtriranja
        public FormaKlubovi()
        {
            InitializeComponent();
        }

        private void BtnPrikaziKlubove_Click(object sender, EventArgs e)
        {
            // pritiskom na button se prikazuju svi klubovi s obzirom na odabrane opcije u dgv
        }
        private void FormaKlubovi_Load(object sender, EventArgs e)
        {

        }
        private void Filtriraj()
        {
            // radi na istom principu kao i ostala filtriranja u ovoj aplikaciji
            // filtrira listu klubova s obzirom na odabrane opcije na formi (odabrani žanr/ovi i ocjena/e)
            AzurirajPopisKlubova();
        }
        private void BtnDodajKlub_Click(object sender, EventArgs e)
        {
            // pristup za ovaj button ima samo admin, i to samo ako nema nijedan klub (svaki admin ima samo jedan klub, tj. upravlja jednim klubom) 
            // dodaje novi klub u bazu i stvara novi objekt klase Klub i dodaje ga listu svih klubova
            // ažurira se dgv
            FormaDodajKlub formaDodajKlub = new FormaDodajKlub();
            formaDodajKlub.Show();
        }

        private void BtnObrisiKlub_Click(object sender, EventArgs e)
        {
            // pristup za ovaj button ima samo admin, i to samo ako ima dodjeljen klub (svaki admin ima samo jedan klub, tj. upravlja jednim klubom) 
            // briše se klub iz liste svih klubova (klasa Klub) i iz baze
            // ažurira se dgv
            AzurirajPopisKlubova();
        }

        private void AzurirajPopisKlubova()
        {
            // pomocna funkcija za azuriranje popisa klubova
        }
        private void BtnOtvoriKlub_Click(object sender, EventArgs e)
        {
            // otvara novu formu gdje se nalaze dodatne informacije o odabranom klubu
            FormaKlub formaKlub = new FormaKlub(new Klub("Klub test", 200));
            formaKlub.Show();
            AzurirajPopisKlubova();
        }
        private Klub DohvatiOdabraniKlub()
        {
            // vraća odabrani klub iz dgv-a
            return null;
        }
    }
}
