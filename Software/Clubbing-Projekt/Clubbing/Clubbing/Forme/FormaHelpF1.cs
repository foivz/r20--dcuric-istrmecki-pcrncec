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
    public partial class FormaHelpF1 : Form
    {
        // forma za prikaz korisnikčke dokumentacije
        // služi kao pomoć korisniku kako bi lakše shvatio rad aplikacije
        public FormaHelpF1()
        {
            InitializeComponent();
        }

        private void FormHelpF1_Load(object sender, EventArgs e)
        {
            TextBoxHelpF1.Text = Properties.Resources.HelpF1;
            TextBoxHelpF1.Select(0, 0);
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
