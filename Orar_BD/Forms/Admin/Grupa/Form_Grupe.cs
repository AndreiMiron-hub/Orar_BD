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
    public partial class Form_Grupe : Form
    {
        IStocareGrupe stocareGrupe = (IStocareGrupe)new StocareFactory().GetTipStocare(typeof(Grupa));
        private const int PRIMA_COLOANA = 0;


        public Form_Grupe()
        {
            InitializeComponent();
            IncarcareGrupe();
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
            IncarcareGrupe();
        }

        private void Button_Adaugare_Click(object sender, EventArgs e)
        {
            using (Form_Adauga_Grupa startF = new Form_Adauga_Grupa())
            {
                startF.ShowDialog();
            }
        }


        private List<Grupa> IncarcareGrupe()
        {
            List<Grupa> empty = new List<Grupa>();
            try
            {
                var grupe = stocareGrupe.GetGrupeAfisare();
                if (grupe != null && grupe.Any())
                {
                    dataGridDashboard.DataSource = grupe.Select(m => new { m.IdGrupa, m.SefGrupa, m.NrStudenti, m.NumeFacultate }).ToList();

                    dataGridDashboard.Columns["idGrupa"].HeaderText = "Grupa";
                    dataGridDashboard.Columns["SefGrupa"].HeaderText = "Sef Grupa";
                    dataGridDashboard.Columns["NrStudenti"].HeaderText = "Nr Studenti";
                    dataGridDashboard.Columns["NumeFacultate"].HeaderText = "Facultate";
                }
                return grupe;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
            return empty;

        }

        private void Button_Modificare_Click(object sender, EventArgs e)
        {
            Grupa grupa = GetGrupaDataGrid();
            if (grupa == null) return;

            DialogResult dialogResult = MessageBox.Show("Esti sigur ca vrei sa modifici grupa?", "Mesaj de confirmare", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
                return;

            using (Form_Modifica_Grupa startF = new Form_Modifica_Grupa(grupa))
            {
                startF.ShowDialog();
            }
        }

        private void Button_Sterge_Click(object sender, EventArgs e)
        {
            Grupa grupa = GetGrupaDataGrid();
            if (grupa == null) return;

            DialogResult dialogResult = MessageBox.Show("Esti sigur ca vrei sa elimini grupa?", "Mesaj de confirmare", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
                return;

            var result = stocareGrupe.DeleteGrupa(grupa);

            if (result == true)
            {
                IncarcareGrupe();
                MessageBox.Show($"Grupa: {grupa.IdGrupa} a fost stearsa cu succes");
            }
        }


        private Grupa GetGrupaDataGrid()
        {
            try
            {
                var currentCell = dataGridDashboard.CurrentCell;
                if (currentCell == null)
                {
                    MessageBox.Show("Selectati o grupa din tabel");
                    return null;
                }
                int idGrupa = Convert.ToInt32(dataGridDashboard[PRIMA_COLOANA, currentCell.RowIndex].Value);

                return stocareGrupe.GetGrupa(idGrupa);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
