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
    public partial class FormGalerijaSlika : Form
    {
        private Form currentChildForm;
        public FormGalerijaSlika()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm)
        {
            
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            childForm.Show();
        }
        private void IconButtonIzlaz_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenChildForm(new FormKlubovi());
        }
    }
}
