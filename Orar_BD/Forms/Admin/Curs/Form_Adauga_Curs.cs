using ModelLibraries;
using DataAccess;
using System;
using System.Windows.Forms;
using System.Text;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;

namespace Orar_BD
{
    public partial class Form_Adauga_Curs : Form
    {
        private readonly IStocareFacultati stocareFacultati = (IStocareFacultati)new StocareFactory().GetTipStocare(typeof(Facultate));
        private readonly IStocareCursuri stocareCursuri = (IStocareCursuri)new StocareFactory().GetTipStocare(typeof(Curs));
        List<Facultate> listaFacultati;
        public Form_Adauga_Curs()
        {
            InitializeComponent();
            listaFacultati = PopuleazaComboFacultati();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ButtonAnuleaza_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ButtonAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                Facultate facultate = stocareFacultati.GetFacultateByName(comboBoxFacultati.SelectedItem.ToString());
                Curs curs = ValideazaInformatii();

                if (curs == null)
                    return;

                //if (stocareCursuri.ValideazaExistentaCurs(curs))
                //{
                //    MessageBox.Show("Materia exista deja in baza de date");
                //    return;
                //}

               /* var rezultat = stocareCursuri.AddCurs(curs, facultate);
                
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

                */

            }
            catch (Exception ex)
            {
                MessageBox.Show("Grupa NU a putut fi adaugata.");
            }
        }

        private Curs ValideazaInformatii()
        {
            try
            {
                StringBuilder mesajEroare = new StringBuilder();

                var denumireValida = Validari.ValideazaDenumireFacultate(textBoxNumeCurs.Text);
                if (string.IsNullOrEmpty(denumireValida.Text))
                {
                    mesajEroare.Append($"{labelCurs.Text} : {denumireValida.Mesaj}\n");
                    labelCurs.ForeColor = Color.Red;
                }

                var IntervalValid = Validari.ValideazaInterval(textBoxInceputIntervalOrar.Text, textBoxFinalIntervalOrar.Text);
                if (string.IsNullOrEmpty(IntervalValid.Text))
                {
                    mesajEroare.Append($"{labelIntervalOrar.Text} : {IntervalValid.Mesaj}\n");
                    labelIntervalOrar.ForeColor = Color.Red;
                }

                var SaptamaniValid = Validari.ValideazaDenumireFacultate(textBoxSaptamani.Text);
                if (string.IsNullOrEmpty(SaptamaniValid.Text))
                {
                    mesajEroare.Append($"{labelSaptamani.Text} : {SaptamaniValid.Mesaj}\n");
                    labelSaptamani.ForeColor = Color.Red;
                }

                var SalaValid = Validari.ValideazaDenumireFacultate(textBoxSala.Text);
                if (string.IsNullOrEmpty(SalaValid.Text))
                {
                    mesajEroare.Append($"{labelSala.Text} : {SalaValid.Mesaj}\n");
                    labelSala.ForeColor = Color.Red;
                }

                var ProfesorValid = Validari.ValideazaDenumireFacultate(textBoxProfesor.Text);
                if (string.IsNullOrEmpty(ProfesorValid.Text))
                {
                    mesajEroare.Append($"{labelProfesor.Text} : {ProfesorValid.Mesaj}\n");
                    labelProfesor.ForeColor = Color.Red;
                }

                


                if (!string.IsNullOrEmpty(mesajEroare.ToString()))
                {
                    MessageBox.Show($"{mesajEroare}");
                    return null;
                }

                int idFac = 0;
                /*foreach (var item in listaFacultati)
                {
                    if (item.NumeFacultate == comboBoxFacultate.SelectedItem.ToString())
                        idFac = item.IdFacultate;
                }
                if (idFac > 0)
                    return new Curs(0, idFac, textBoxInceputIntervalOrar.Text, textBoxSaptamani.Text, textBoxProfesor.Text,  textBoxSala.Text, int.Parse(textBoxNumeCurs.Text), idFac);
           */ }
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
                        comboBoxFacultati.Items.Add(item.NumeFacultate);
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
