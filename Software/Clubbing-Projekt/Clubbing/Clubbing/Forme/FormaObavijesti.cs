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
        List<Obavijest> mojeObavijesti = null;
        public FormaObavijesti()
        {
            InitializeComponent();
            if (!Korisnik.PrijavljeniKorisnik.Admin)
            {
                BtnDodajObavijest.Visible = false;
                labelNOP.Visible = false;
                textBoxObavijest.ReadOnly = true;
                PrikaziObavijesti(false);
            }
            else
            {
                PrikaziObavijesti(true);
            }
        }
        private void PrikaziObavijesti(bool admin)
        {
            // u dgv se prikazuju obavijesti korisnika (klijenta) ili admina
            // adminove obavijesti su recenzije i rezervacije korisnika za njegov klub
            // korisničke obavijesti su obavijesti svih klubova koje taj korisnik prati (obavijest za novi događaj, ručno napisane obavijesti)
            if (admin)
            {
                mojeObavijesti = Obavijest.DohvatiObavijestiAdmina(Korisnik.PrijavljeniKorisnik);
            }
            else
            {
                mojeObavijesti = Obavijest.DohvatiObavijestiKorisnika(Korisnik.PrijavljeniKorisnik);
            }
            dgvObavijesti.DataSource = mojeObavijesti;
            if (dgvObavijesti.DataSource != null)
            {
                dgvObavijesti.Columns["IDObavijest"].Visible = false;
                dgvObavijesti.Columns[1].HeaderText = "Opis obavijesti";
                dgvObavijesti.Columns[2].HeaderText = "Datum obavijesti";
            }
        }
        private void BtnDodajObavijest_Click(object sender, EventArgs e)
        {
            // ovaj button vidi samo admin kluba, pošto samo on može slati obavijesti korisnicima
            // pritiskom na button se dodaje obavijest u bazu za adminov klub
            Obavijest obavijest = new Obavijest(textBoxObavijest.Text, DateTime.Now);
            obavijest.DodajObavijestUBazu(true);
            textBoxObavijest.Text = "";
        }

        private void dgvObavijesti_CurrentCellChanged(object sender, EventArgs e)
        {
            if(dgvObavijesti.CurrentRow != null)
            {
                try
                {
                    Obavijest trenutnaObavijest = dgvObavijesti.CurrentRow.DataBoundItem as Obavijest;
                    textBoxObavijest.Text = trenutnaObavijest.Opis;
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }            
        }
    }
}
