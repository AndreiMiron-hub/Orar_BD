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
        int idFacultate, idGrupa;
        List<Grupa> listGrupa = new List<Grupa>();
        public Form_Select_Grupe()
        {
            InitializeComponent();
        }

        public Form_Select_Grupe(int id)
        {
            InitializeComponent();
            idFacultate = id;
            listGrupa = IncarcareGrupe(id);
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
            if (comboBoxGrupe.SelectedItem == null)
            {
                labelEroareSelect.Visible = true;
            }
            else
            {
                if (listGrupa.Count > 0)
                {
                    foreach (var item in listGrupa)
                    { 
                        if (item.IdGrupa.ToString() == comboBoxGrupe.SelectedItem.ToString())
                        {
                            lblIdGrupa.Text = item.IdGrupa.ToString();
                            lblIdFac.Text = idFacultate.ToString();
                        }
                    }
                }
                idGrupa = int.Parse(lblIdGrupa.Text);
                using (Form_Orar_Viz selectOF = new Form_Orar_Viz(idGrupa, idFacultate))
                {
                    this.Hide();
                    selectOF.ShowDialog();
                }
            }
        }

        private List<Grupa> IncarcareGrupe(int id)
        {
            List<Grupa> empty = new List<Grupa>();
            try
            {
                var grupe = stocareGrupe.GetGrupeByFaculty(id);
                if (grupe != null && grupe.Any())
                {

                    foreach (var item in grupe)
                    {
                        comboBoxGrupe.Items.Add(item.IdGrupa);
                    }
                }
                return grupe;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
            return empty;

        }
    }
}
