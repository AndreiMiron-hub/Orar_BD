using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orar_BD
{
    public partial class Form_Cursuri : Form
    {
        public Form_Cursuri()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            using (Form_Dashboard startF = new Form_Dashboard())
            {
                this.Hide();
                startF.ShowDialog();
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Afisare_Click(object sender, EventArgs e)
        {

        }
    }
}
