using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DataAccess;
using ModelLibraries;


namespace Orar_BD
{
    public partial class Form_Select_Grupe : Form
    {
        IStocareGrupe stocareGrupe = (IStocareGrupe)new StocareFactory().GetTipStocare(typeof(Grupa));
        public Form_Select_Grupe()
        {
            InitializeComponent();
        }

        public Form_Select_Grupe(int idFacultate)
        {
            InitializeComponent();
            IncarcareGrupe(idFacultate);
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            using (Form_Select_Facult selectF = new Form_Select_Facult())
            {
                this.Hide();
                selectF.ShowDialog();
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Acces_Orar_Click(object sender, EventArgs e)
        {
            using (Form_Orar_Viz selectOF = new Form_Orar_Viz())
            {
                this.Hide();
                selectOF.ShowDialog();
            }
        }

        private void IncarcareGrupe(int idFacultate)
        {
            try
            {
                List<Grupa> facultati = stocareGrupe.GetGrupe();
                if (facultati != null && facultati.Any())
                {

                    foreach (var item in facultati)
                    {
                        comboBoxGrupe.Items.Add(item.IdGrupa);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
    }
}
