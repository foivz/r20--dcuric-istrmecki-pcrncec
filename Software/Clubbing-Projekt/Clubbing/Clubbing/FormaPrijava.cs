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

namespace Clubbing
{
    public partial class LoginForm : Form
    {
        string inputKorisnickoIme = "";
        string inputLozinka = "";
        public LoginForm()
        {
            InitializeComponent();
        }


        private bool validacijaPrijave()
        {
            return true;
        }

        private void BtnRegistracija_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaRegistracija formaRegistracija = new FormaRegistracija();
            formaRegistracija.ShowDialog();
        }

        private void BtnPrijava_Click(object sender, EventArgs e)
        {
            inputKorisnickoIme = textBoxUsername.Text;
            inputLozinka = textBoxPassword.Text;
            if (validacijaPrijave())
            {
                this.Hide();
                FormaGlavniMeni glavnaForma = new FormaGlavniMeni();
                glavnaForma.ShowDialog();
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
