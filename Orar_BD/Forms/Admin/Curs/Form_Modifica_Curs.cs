using DataAccess;
using ModelLibraries;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Orar_BD
{
    public partial class Form_Modifica_Curs : Form
    {
        private readonly IStocareFacultati stocareFacultati = (IStocareFacultati)new StocareFactory().GetTipStocare(typeof(Facultate));
        private readonly IStocareCursuri stocareCursuri = (IStocareCursuri)new StocareFactory().GetTipStocare(typeof(Curs));
        List<Facultate> listaFacultati;
        Curs cursDeModificat;

        public Form_Modifica_Curs()
        {
            InitializeComponent();
        }

        public Form_Modifica_Curs(Curs curs)
        {
            InitializeComponent();
            //listaFacultati = stocareFacultati.GetFacultate()
            textBoxNumeCurs.Text = curs.NumeMaterie;
            textBoxIntervalOrar.Text = curs.IntervalOrar;
            textBoxSaptamani.Text = curs.Saptamani;
            textBoxSala.Text = curs.Sala;
            textBoxProfesor.Text = curs.Profesor;
            textBoxTip.Text = curs.Tip;
            cursDeModificat = curs;

        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ButtonAnuleaza_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ButtonModificaCurs_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValideazaInformatii())
                    return;
                cursDeModificat.NumeMaterie = textBoxNumeCursNou.Text;
                cursDeModificat.NumeScurt = acronim(textBoxNumeCursNou.Text);

                cursDeModificat.Saptamani = textBoxSaptamaniNou.Text;
                cursDeModificat.Sala = textBoxSalaNou.Text;

                cursDeModificat.IntervalOrar = textBoxInceputIntervalOrar.Text + " : " + textBoxFinalIntervalOrar.Text;

                cursDeModificat.Profesor = textBoxProfesorNou.Text;
                cursDeModificat.Tip = comboBoxTipuri.SelectedItem.ToString();


                if (stocareCursuri.ValideazaExistentaCurs(cursDeModificat))
                {
                    MessageBox.Show("Materia exista deja in baza de date");
                    return;
                }

                var rezultat = stocareCursuri.UpdateCurs(cursDeModificat);

                if (rezultat != false)
                {
                    // Displays the MessageBox.
                    DialogResult dialog = MessageBox.Show("Curs modificat cu succes", "Feilcitari!", MessageBoxButtons.OK);
                    if (dialog == DialogResult.OK)
                    {
                        // Closes the parent form.
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cursul NU a putut fi modificat.");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Cursul NU a putut fi modificat.");
            }
        }



        private bool ValideazaInformatii()
        {
            try
            {
                StringBuilder mesajEroare = new StringBuilder();

                var denumireValida = Validari.ValideazaDenumireFacultate(textBoxNumeCursNou.Text);
                if (string.IsNullOrEmpty(denumireValida.Text))
                {
                    mesajEroare.Append($"{labelCursNou.Text} : {denumireValida.Mesaj}\n");
                    labelCursNou.ForeColor = Color.Red;
                }

                var IntervalValid = Validari.ValideazaInterval(textBoxInceputIntervalOrar.Text, textBoxFinalIntervalOrar.Text);
                if (string.IsNullOrEmpty(IntervalValid.Text))
                {
                    mesajEroare.Append($"{labelIntervalOrar.Text} : {IntervalValid.Mesaj}\n");
                    labelIntervalOrar.ForeColor = Color.Red;
                }

                var SaptamaniValid = Validari.ValideazaDenumireFacultate(textBoxSaptamaniNou.Text);
                if (string.IsNullOrEmpty(SaptamaniValid.Text))
                {
                    mesajEroare.Append($"{labelSaptamaniNou.Text} : {SaptamaniValid.Mesaj}\n");
                    labelSaptamaniNou.ForeColor = Color.Red;
                }

                //var SalaValid = Validari.ValideazaDenumireFacultate(textBoxSala.Text);
                //if (string.IsNullOrEmpty(SalaValid.Text))
                //{
                //    mesajEroare.Append($"{labelSala.Text} : {SalaValid.Mesaj}\n");
                //    labelSala.ForeColor = Color.Red;
                //}

                var ProfesorValid = Validari.ValideazaDenumireFacultate(textBoxProfesorNou.Text);
                if (string.IsNullOrEmpty(ProfesorValid.Text))
                {
                    mesajEroare.Append($"{labelProfesorNou.Text} : {ProfesorValid.Mesaj}\n");
                    labelProfesorNou.ForeColor = Color.Red;
                }




                if (!string.IsNullOrEmpty(mesajEroare.ToString()))
                {
                    MessageBox.Show($"{mesajEroare}");
                    return false;
                }

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("A aparut o problema la validarea informatiilor despre materie");
            }
            return false;
        }

        private string acronim(string input)
        {
            input = input.ToUpper();
            return string.Join(string.Empty,
        input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => s[0])
        );
        }
    }
}
