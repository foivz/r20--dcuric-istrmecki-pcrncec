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
            this.Hide();
            FormaGlavniMeni formaGlavniMeni = new FormaGlavniMeni();
            formaGlavniMeni.Show();
        }
        private bool ValidacijaRezervacije()
        {
            // provjerava se ispravnost unesenih podataka
            return false;
        }

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm formaPrijava = new LoginForm();
            formaPrijava.Show();
        }
    }
}
