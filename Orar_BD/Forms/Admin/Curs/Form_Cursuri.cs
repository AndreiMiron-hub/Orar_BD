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
    public partial class Form_Cursuri : Form
    {
        IStocareCursuri stocareCursuri = (IStocareCursuri)new StocareFactory().GetTipStocare(typeof(Curs));
        IStocareGrupe stocareGrupe = (IStocareGrupe)new StocareFactory().GetTipStocare(typeof(Grupa));
        IStocareFacultati stocareFacultati = (IStocareFacultati)new StocareFactory().GetTipStocare(typeof(Facultate));
        List<Facultate> listaFacultati;
        List<Grupa> listaGrupe;

        public Form_Cursuri()
        {
            InitializeComponent();
            IncarcareCursuri();
            listaFacultati = stocareFacultati.GetFacultati();
            listaGrupe = stocareGrupe.GetGrupe();
            PopuleazaComboFacultatiGrupe();
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

        }

        private void Button_Adaugare_Click(object sender, EventArgs e)
        {
            using (Form_Adauga_Curs startF = new Form_Adauga_Curs())
            {
                startF.ShowDialog();
            }
        }

        private void comboBoxGrupe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxGrupe.SelectedIndex != -1)
                comboBoxFacultati.Enabled = false;
        }

        private void ButtonResetFiltru_Click(object sender, EventArgs e)
        {
            comboBoxFacultati.Enabled = true;
            comboBoxFacultati.SelectedIndex = -1;
            comboBoxGrupe.SelectedIndex = -1;
        }

       

        private void ButtonFiltru_Click(object sender, EventArgs e)
        {
            if(comboBoxFacultati.Enabled == false)
            {
                IncarcareCursuriFiltruGrupa();
            }
        }


        private List<Curs> IncarcareCursuri()
        {
            List<Curs> empty = new List<Curs>();
            try
            {
                var cursuri = stocareCursuri.GetCursuri();
                if (cursuri != null && cursuri.Any())
                {
                    dataGridDashboard.DataSource = cursuri.Select(m => new { m.IdCurs, m.NumeMaterie, m.NumeScurt, m.IntervalOrar, m.Profesor, m.Sala,m.Tip, m.Saptamani }).ToList();

                    dataGridDashboard.Columns["idCurs"].HeaderText = "ID Curs";
                    dataGridDashboard.Columns["numeMaterie"].HeaderText = "Materie";
                    dataGridDashboard.Columns["numeScurt"].HeaderText = "Acronim";
                    dataGridDashboard.Columns["IntervalOrar"].HeaderText = "Interval Orar";
                    dataGridDashboard.Columns["Profesor"].HeaderText = "Profesor";
                    dataGridDashboard.Columns["Sala"].HeaderText = "Sala";
                    dataGridDashboard.Columns["Tip"].HeaderText = "Tip";
                    dataGridDashboard.Columns["Saptamani"].HeaderText = "Saptamani";
                }
                return cursuri;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
            return empty;

        }

        private List<Curs> IncarcareCursuriFiltruGrupa()
        {
            List<Curs> empty = new List<Curs>();
            try
            {
                var cursuri = stocareCursuri.GetCursuriByGrupa(int.Parse(comboBoxGrupe.SelectedItem.ToString()));
                if (cursuri != null && cursuri.Any())
                {
                    dataGridDashboard.DataSource = cursuri.Select(m => new { m.IdCurs, m.NumeMaterie, m.NumeScurt, m.IntervalOrar, m.Profesor, m.Sala, m.Saptamani, m.Tip }).ToList();

                    dataGridDashboard.Columns["idCurs"].HeaderText = "ID Curs";
                    dataGridDashboard.Columns["numeMaterie"].HeaderText = "Materie";
                    dataGridDashboard.Columns["numeScurt"].HeaderText = "Acronim";
                    dataGridDashboard.Columns["intervalOrar"].HeaderText = "Interval orar";
                    dataGridDashboard.Columns["Profesor"].HeaderText = "Profesor";
                    dataGridDashboard.Columns["Sala"].HeaderText = "Sala";
                    dataGridDashboard.Columns["Tip"].HeaderText = "Tip";
                    dataGridDashboard.Columns["Saptamani"].HeaderText = "Saptamani";
                }
                return cursuri;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
            return empty;

        }
        private void PopuleazaComboFacultatiGrupe()
        {
            try
            { 
                if (listaFacultati != null && listaFacultati.Any())
                {

                    foreach (var item in listaFacultati)
                    {
                        comboBoxFacultati.Items.Add(item.NumeFacultate);
                    }
                    
                }
            if (listaGrupe != null && listaGrupe.Any())
            {
                foreach (var item in listaGrupe)
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
