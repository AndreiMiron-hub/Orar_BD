using DataAccess;
using ModelLibraries;
using System;
using System.Windows.Forms;

namespace Orar_BD
{
    public partial class Form_Login : Form
    {
        IStocareConturi stocareConturi = (IStocareConturi)new StocareFactory().GetTipStocare(typeof(Cont));
        public Form_Login()
        {
            InitializeComponent();
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

        private void Button_Autentificare_Click(object sender, EventArgs e)
        {
            bool completatNume = false, completatParola = false;
            if (String.IsNullOrEmpty(textBoxNume.Text))
            {
                lblErrorNume.Visible = true;
                labelErrorLogin.Visible = false;
                
            }
            if (String.IsNullOrEmpty(textBoxParola.Text))
                {
                    labelErrorParola.Visible = true;
                    labelErrorLogin.Visible = false;
                }
            if (!String.IsNullOrEmpty(textBoxNume.Text))
            {
                lblErrorNume.Visible = false;
                labelErrorLogin.Visible = false;
                completatNume = true;
            }
            if (!String.IsNullOrEmpty(textBoxParola.Text))
            {
                labelErrorParola.Visible = false;
                labelErrorLogin.Visible = false;
                completatParola = true;
            }
            if(completatNume && completatParola)
            {
                string numeUtilizator = textBoxNume.Text, parola = textBoxParola.Text;
                if (stocareConturi.CheckCont(numeUtilizator, parola))
                    using (Form_Dashboard startF = new Form_Dashboard())
                    {
                        this.Hide();
                        startF.ShowDialog();
                    }
                else
                {
                    labelErrorLogin.Visible = true;
                    lblErrorNume.Visible = false;
                    labelErrorParola.Visible = false;
                }
            }
        }
    }
}
