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

        }
    }
}
