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
    public partial class Form_Dashboard : Form
    {
        public Form_Dashboard()
        {
            InitializeComponent();
        }

        private void Button_Facultati_Click(object sender, EventArgs e)
        {
            using (Form_Adm startOAF = new Form_Adm())
            {
                this.Hide();
                startOAF.ShowDialog();
            }

        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            using (Form_Start startF = new Form_Start())
            {
                this.Hide();
                startF.ShowDialog();
            }
        }

        private void Button_Orar_Click(object sender, EventArgs e)
        {
            using (Form_Orar_Viz startF = new Form_Orar_Viz())
            {
                this.Hide();
                startF.ShowDialog();
                
            }
        }
    }
}
