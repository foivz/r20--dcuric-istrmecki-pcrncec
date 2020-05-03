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
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ButtonPrijava_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlavnaForma glavnaForma = new GlavnaForma();
            glavnaForma.ShowDialog();

            
        }
    }
}
