using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clubbing.Forms
{
    public partial class FormKlubovi : Form
    {
        public FormKlubovi()
        {
            InitializeComponent();
        }

        private void IconButton1_Click(object sender, EventArgs e)
        {
            FormGalerijaSlika formGalerijaSlika = new FormGalerijaSlika();
            formGalerijaSlika.ShowDialog();

        }
    }
}
