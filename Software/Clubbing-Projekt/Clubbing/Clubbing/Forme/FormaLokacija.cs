using Clubbing.Modeli;
using Clubbing.Forme;
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
    public partial class FormaLokacija : Form
    {
        public FormaLokacija()
        {
            InitializeComponent();
        }

        private void FormaLokacija_Load(object sender, EventArgs e)
        {

        }

        private void BtnPrethodna_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDodajLokaciju_Click(object sender, EventArgs e)
        {
            FormaDodajLokaciju formaDodajLokaciju = new FormaDodajLokaciju(true);
            formaDodajLokaciju.Show();
        }

        private void BtnIzmjeniLokaciju_Click(object sender, EventArgs e)
        {
            FormaDodajLokaciju formaDodajLokaciju = new FormaDodajLokaciju(false);
            formaDodajLokaciju.Show();
        }
    }
}
