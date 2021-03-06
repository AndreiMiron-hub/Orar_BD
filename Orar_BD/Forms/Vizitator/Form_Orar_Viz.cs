using ModelLibraries;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Orar_BD
{
    public partial class Form_Orar_Viz : Form
    {
        IStocareCursuri stocareCursuri = (IStocareCursuri)new StocareFactory().GetTipStocare(typeof(Curs));
        public Form_Orar_Viz()
        {
            InitializeComponent();
        }

        public Form_Orar_Viz(int idGrupa, int idFacultate)
        {
            InitializeComponent();
            IncarcareCursuri(idGrupa, idFacultate);
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            using (Form_Select_Grupe selectGF = new Form_Select_Grupe())
            {
                this.Hide();
                selectGF.ShowDialog();
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private List<Curs> IncarcareCursuri(int idGrupa, int idFacultate)
        {
            List<Curs> empty = new List<Curs>();
            try
            {
                var cursuri = stocareCursuri.GetCursuriByGrupa(idGrupa);

                if (cursuri != null && cursuri.Any())
                {

                    foreach (var item in cursuri)
                    {
                       
                    }
                }
                return cursuri;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
            return empty;

        }
    }
}
