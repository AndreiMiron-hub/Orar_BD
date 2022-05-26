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

        public Form_Adm()
        {
            InitializeComponent();
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

        private void Button_Afisare_Facultati_Click(object sender, EventArgs e)
        {
            
            try
            {
                List<Facultate> facultati = stocareFacultati.GetFacultati();
                if (facultati != null && facultati.Any())
                {
                    dataGridDashboard.DataSource = facultati.Select(m => new { m.IdFacultate, m.NumeFacultate }).ToList();

                    dataGridDashboard.Columns["IdFacultate"].Visible = true;
                    dataGridDashboard.Columns["IdFacultate"].HeaderText = "ID";
                    dataGridDashboard.Columns["NumeFacultate"].HeaderText = "Facultate";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Button_Afisare_Click(object sender, EventArgs e)
        {

        }


        private void AfiseazaFacultati()
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
    }
}
