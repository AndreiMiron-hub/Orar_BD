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
        List<Facultate> listFac = new List<Facultate>();
        public Form_Select_Facult()
        {
            InitializeComponent();
            listFac = IncarcareFacultati();
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
                if(listFac.Count > 0)
                {
                    foreach (var item in listFac)
                    {
                        if (item.NumeFacultate == comboBoxFacultati.SelectedItem)
                            lblIndexFac.Text = item.IdFacultate.ToString();
                    }
                }
                int id = int.Parse(lblIndexFac.Text);
                using (Form_Select_Grupe startGF = new Form_Select_Grupe(id)) 
                {
                    this.Hide();
                    startGF.ShowDialog();
                }
            }
        }

        private List<Facultate> IncarcareFacultati()
        {
            List<Facultate> empty = new List<Facultate>(); 
            try
            {
                var facultati = stocareFacultati.GetFacultati();
                if (facultati != null && facultati.Any())
                {

                    foreach (var item in facultati)
                    {
                        comboBoxFacultati.Items.Add(item.NumeFacultate);
                    }
                }
                return facultati;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                
            }
            return empty;

        }
    }
}
