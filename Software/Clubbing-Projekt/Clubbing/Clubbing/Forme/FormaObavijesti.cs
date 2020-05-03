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

namespace Clubbing.Forme
{
    public partial class FormaObavijesti : Form
    {
        private BindingList<Obavijest> sveObavijesti = null;
        public FormaObavijesti()
        {
            InitializeComponent();
        }

        private void FormaObavijesti_Load(object sender, EventArgs e)
        {
            // iz baze se uzimaju sve obavijesti nekog korisnika i one se popunjavaju u dgv uz pomoc metode PrikaziObavijesti()
        }
        private void PrikaziObavijesti()
        {
            // ova metoda popunjava varijablu sveObavijesti s obzirom na dohvaćane podatke iz baze
        }
        private void Filtriraj()
        {
            // filtrira (mijenja) atribut sveObavijesti s obzirom na odabrane opcije
        }
        private void BtnDodajObavijest_Click(object sender, EventArgs e)
        {
            // ovaj button vidi samo admin kluba, pošto samo on može slati obavijesti korisnicima
            // obavijest se cita iz textboxa lijevo
            // pritiskom na button se dodaje obavijest u bazu za sve korisnike koji prate adminov klub (onaj admin koji je posalo obavijest)
        }
    }
}
