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
    public partial class Form_Adauga_Grupa : Form
    {
        private readonly IStocareFacultati stocareFacultati = (IStocareFacultati)new StocareFactory().GetTipStocare(typeof(Facultate));
        private readonly IStocareGrupe stocareGrupe = (IStocareGrupe)new StocareFactory().GetTipStocare(typeof(Grupa));
        List<Facultate> listaFacultati;

        public Form_Adauga_Grupa()
        {
            InitializeComponent();
            listaFacultati = PopuleazaComboFacultati();

        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ButtonAdaugaFacultate_Click(object sender, EventArgs e)
        {
            try
            {
                Facultate facultate = stocareFacultati.GetFacultateByName(comboBoxFacultate.SelectedItem.ToString());
                Grupa grupa = ValideazaInformatii();

                if (grupa == null)
                    return;

                if (stocareGrupe.ValideazaExistentaGrupa(grupa))
                {
                    MessageBox.Show("Materia exista deja in baza de date");
                    return;
                }

                var rezultat = stocareGrupe.AddGrupa(grupa, facultate);

                if (rezultat == true)
                {
                    // Displays the MessageBox.
                    DialogResult dialog = MessageBox.Show("Grupa adaugata cu succes", "Feilcitari!", MessageBoxButtons.OK);
                    if (dialog == DialogResult.OK)
                    {
                        // Closes the parent form.
                        this.Close();
                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Grupa NU a putut fi adaugata.");
            }
        }


        private Grupa ValideazaInformatii()
        {
            try
            {
                StringBuilder mesajEroare = new StringBuilder();

                var denumireValida = Validari.ValideazaNumarGrupa(textBoxNumarGrupa.Text);
                if (string.IsNullOrEmpty(denumireValida.Text))
                {
                    mesajEroare.Append($"{lblNumarGrupa.Text} : {denumireValida.Mesaj}\n");
                    lblNumarGrupa.ForeColor = Color.Red;
                }

                var nrStudentiValid = Validari.ValideazaNumarStudenti(textBoxNumarStudenti.Text);
                if (string.IsNullOrEmpty(nrStudentiValid.Text))
                {
                    mesajEroare.Append($"{lblNumarGrupa.Text} : {nrStudentiValid.Mesaj}\n");
                    lblNumarStudenti.ForeColor = Color.Red;
                }

                var numeSefGrupaValid = Validari.ValideazaDenumireFacultate(textBoxSefGrupa.Text);
                if (string.IsNullOrEmpty(numeSefGrupaValid.Text))
                {
                    mesajEroare.Append($"{lblNumarGrupa.Text} : {numeSefGrupaValid.Mesaj}\n");
                    lblNumarStudenti.ForeColor = Color.Red;
                }


                if (!string.IsNullOrEmpty(mesajEroare.ToString()))
                {
                    MessageBox.Show($"{mesajEroare}");
                    return null;
                }

                int idFac = 0;
                foreach (var item in listaFacultati)
                {
                    if (item.NumeFacultate == comboBoxFacultate.SelectedItem.ToString())
                        idFac = item.IdFacultate;
                }
                if (idFac > 0)
                    return new Grupa(int.Parse(textBoxNumarGrupa.Text), int.Parse(textBoxNumarStudenti.Text), textBoxSefGrupa.Text, idFac, comboBoxFacultate.SelectedItem.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("A aparut o problema la validarea informatiilor despre materie");
            }
            return null;
        }

        private List<Facultate> PopuleazaComboFacultati()
        { 
            try
            {
                var facultati = stocareFacultati.GetFacultati();
                if (facultati != null && facultati.Any())
                {

                    foreach (var item in facultati)
                    {
                        comboBoxFacultate.Items.Add(item.NumeFacultate);
                    }
                }
                return facultati;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
            return null;

        }
    }
}
