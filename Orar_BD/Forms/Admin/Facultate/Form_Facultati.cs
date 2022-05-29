using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using ModelLibraries;

namespace Orar_BD
{
    public partial class Form_Adm : Form
    {
        IStocareFacultati stocareFacultati = (IStocareFacultati)new StocareFactory().GetTipStocare(typeof(Facultate));
        private const int PRIMA_COLOANA = 0;
        List<Facultate> listFac = new List<Facultate>();
    
        public Form_Adm()
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
            using (Form_Dashboard startF = new Form_Dashboard())
            {
                this.Hide();
                startF.ShowDialog();
            }
        }

        private void Button_Afisare_Click(object sender, EventArgs e)
        {
            try
            {
                var facultati = stocareFacultati.GetFacultati();
                if (facultati != null && facultati.Any())
                {
                    dataGridDashboard.DataSource = facultati.Select(m => new { m.IdFacultate, m.NumeFacultate }).ToList();

                    dataGridDashboard.Columns["IdFacultate"].Visible = false;
                    dataGridDashboard.Columns["NumeFacultate"].HeaderText = "Facultate";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

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
                    dataGridDashboard.DataSource = facultati.Select(m => new { m.IdFacultate, m.NumeFacultate }).ToList();

                    dataGridDashboard.Columns["IdFacultate"].Visible = false;
                    dataGridDashboard.Columns["NumeFacultate"].HeaderText = "Facultate";
                }
                return facultati;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
            return empty;

        }

        private void Button_Adaugare_Click(object sender, EventArgs e)
        {
            using (Form_Adauga_Facultate startF = new Form_Adauga_Facultate())
            {
                startF.ShowDialog();
            }
        }

        private void Button_Modificare_Click(object sender, EventArgs e)
        {
            Facultate facultate = GetFacultateDataGrid();
            if (facultate == null) return;

            DialogResult dialogResult = MessageBox.Show("Esti sigur ca vrei sa modifici facultatea?", "Mesaj de confirmare", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
                return;

            using (Form_Modifica_Facultate startF = new Form_Modifica_Facultate(facultate))
            {
                startF.ShowDialog();
            }
        }

        private void Button_Sterge_Click(object sender, EventArgs e)
        {
            Facultate facultate = GetFacultateDataGrid();
            if (facultate == null) return;

            DialogResult dialogResult = MessageBox.Show("Esti sigur ca vrei sa elimini facultatea?", "Mesaj de confirmare", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
                return;

            var result = stocareFacultati.DeleteFacultate(facultate);

            if (result == true)
            {
                IncarcareFacultati();
                MessageBox.Show($"Facultatea: {facultate.NumeFacultate} a fost stearsa cu succes");
            }

        }


        private Facultate GetFacultateDataGrid()
        {
            try
            {
                var currentCell = dataGridDashboard.CurrentCell;
                if (currentCell == null)
                {
                    MessageBox.Show("Selectati o facultate din tabel");
                    return null;
                }
                int idFacultate = Convert.ToInt32(dataGridDashboard[PRIMA_COLOANA, currentCell.RowIndex].Value);

                return stocareFacultati.GetFacultate(idFacultate);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
