using System;
using System.Windows.Forms;

namespace Orar_BD
{
    public partial class Form_Start : Form
    {
       
        public Form_Start()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Orar_Click(object sender, EventArgs e)
        {
            using (Form_Select_Facult selectF = new Form_Select_Facult())
            {
                this.Hide();
                selectF.ShowDialog();
            }
        }

        private void Button_Autentificare_Click_1(object sender, EventArgs e)
        {
            using (Form_Login form_login = new Form_Login())
            {
                this.Hide();
                form_login.ShowDialog();
            }
        }
    }
}
