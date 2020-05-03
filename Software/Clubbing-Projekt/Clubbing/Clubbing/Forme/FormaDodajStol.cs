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
    public partial class FormaDodajStol : Form
    {
        private string inputNazivLokacije = "";
        private int inputMaxMjesta = 1;
        public FormaDodajStol()
        {
            InitializeComponent();
        }

        private void BtnDodajStol_Click(object sender, EventArgs e)
        {
            try
            {
                inputMaxMjesta = Convert.ToInt32(textBoxMaxMjesta.Text);
                inputNazivLokacije = textBoxNazivLokacije.Text;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Krivi unos!");
            }
        }

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormaDodajStol_Load(object sender, EventArgs e)
        {

        }
    }
}
