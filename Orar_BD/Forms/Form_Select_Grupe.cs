using DataAccess;
using ModelLibraries;
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
    public partial class Form_Select_Grupe : Form
    {
        IStocareGrupe stocareGrupe = (IStocareGrupe)new StocareFactory().GetTipStocare(typeof(Grupa));
        public Form_Select_Grupe()
        {
            InitializeComponent();
        }

        public Form_Select_Grupe(int id)
        {
            InitializeComponent();
            IncarcareGrupe(id);
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
