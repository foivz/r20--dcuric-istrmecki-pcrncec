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
    public partial class FormaGalerija : Form
    {
        private int index; // trenutni index prikazane slike u listi slikeKluba/slikeDogadjaja
        private bool galerijaKlub;
        public FormaGalerija(bool galerijaKlub)
        {
            // ova forma je zajednička i za prikaz slika nekog završenog događaja i nekog kluba općenito 
            // galerijaKlub je true ako se učitava forma za prikaz galerije kluba
            // u suprotom se radi o formi za prikaz galerije dogadjaja nekog odabranog kluba
            this.galerijaKlub = galerijaKlub;
            index = 0;
            InitializeComponent();
        }

        private void FormaGalerija_Load(object sender, EventArgs e)
        {
            // na početku se učitaju sve slike u potrebnu varijablu (slikeKluba/slikeDogadjaja) uz pomoć metode ucitajSlike() klase Klub
            // osim toga se onemogući klik na prethodnu sliku pošto smo na prvi slici
            // provjerava se ako postoji više od jedne slika, ako ne se onemogući i gumb za iduću sliku
            // ove provjere se dešavaju uvijek nakon što se klikne na gumbove Prethodna/Sljedeća slika
            // za tu provjeru se koristi pomoćna varijabla index
            BtnPrethodnaSlika.Enabled = false;
        }
        private void Osvjezi()
        {
            // osvjezava panel gdje se prikazuju slike
            // potrebno pri dodavnaju/brisanju slike iz galerije kluba/dogadjaja
        }

        private void BtnPrethodna_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPrethodnaSlika_Click(object sender, EventArgs e)
        {
            // prikazuje prethodnu sliku ako je ima(trenutni index liste slika - 1)
            
        }

        private void BtnSljedecaSlika_Click(object sender, EventArgs e)
        {
            // prikatuje sljedeću sliku ako je ima(trenutni index liste slika + 1)
        }

        private void BtnDodajSliku_Click(object sender, EventArgs e)
        {
            // samo admin kluba ima ovu mogućnost
            // pritiskom na ovaj gumb se provjerava da li je neka slika Drag&Drop-ana
            // ako je, dodaje se ta slika u postojeću listu slikeKluba/slikeDogadjaja i osvježava se galerija
            // ako nije, obaviještava se korisnika aplikacije neka prvo Drag&Drop-a sliku ispravnog formata (npr .jpg, .png)
            // Drag&Drop za sad još nije moguće napraviti (TODO)
        }

        private void BtnObrisiSliku_Click(object sender, EventArgs e)
        {
            // samo admin kluba ima ovu mogućnost
            // briše trenutnu prikazanu sliku iz liste slikeKluba/slikeDogadjaja
        }
    }
}
