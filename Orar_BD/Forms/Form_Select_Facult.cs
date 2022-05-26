using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DataAccess;
using ModelLibraries;


namespace Orar_BD
{
    public partial class Form_Select_Facult : Form
    {
        IStocareFacultati stocareFacultati = (IStocareFacultati)new StocareFactory().GetTipStocare(typeof(Facultate));
        List<Facultate> facultati;

        public Form_Select_Facult()
        {
            InitializeComponent();
            IncarcareFacultati();
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

        private void Button_Acces_Grupe_Click(object sender, EventArgs e)
        {
            if (comboBoxFacultati.SelectedItem == null)
            {
                labelEroareSelect.Visible = true;
            }
            else
            {
                foreach (var item in facultati)
                {
                    if (comboBoxFacultati.SelectedItem == item.NumeFacultate)
                        lblIdFacultate.Text = item.IdFacultate.ToString();
                }
                using (Form_Select_Grupe startGF = new Form_Select_Grupe(Convert.ToInt32(lblIdFacultate.Text)))
                {
                    this.Hide();
                    startGF.ShowDialog();
                }
            }
        }

        private void IncarcareFacultati()
        {
            try
            {
                facultati = stocareFacultati.GetFacultati();
                if (facultati != null && facultati.Any())
                {

                    foreach (var item in facultati)
                    {
                        comboBoxFacultati.Items.Add(item.NumeFacultate);
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
