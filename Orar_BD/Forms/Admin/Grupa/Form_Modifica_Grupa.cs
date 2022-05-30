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
    public partial class Form_Modifica_Grupa : Form
    {
        private readonly IStocareFacultati stocareFacultati = (IStocareFacultati)new StocareFactory().GetTipStocare(typeof(Facultate));
        private readonly IStocareGrupe stocareGrupe = (IStocareGrupe)new StocareFactory().GetTipStocare(typeof(Grupa));
        Grupa grupaDeModificat;
        List<Facultate> facultateList;
        public Form_Modifica_Grupa()
        {
            InitializeComponent();
        }
        public Form_Modifica_Grupa(Grupa grupa)
        {
            InitializeComponent();
            textBoxGrupaActual.Text = grupa.IdGrupa.ToString();
            textBoxNrStudentiActual.Text = grupa.NrStudenti.ToString();
            textBoxSefGrupaActual.Text = grupa.SefGrupa.ToString();
            textBoxFacultateActual.Text = grupa.NumeFacultate.ToString();
            grupaDeModificat = grupa;
            facultateList = PopuleazaComboFacultati();
        }

        private void ButtonModificaFacultate_Click(object sender, EventArgs e)
        {
            try
            {
                Grupa grupa = ValideazaInformatii();
                if (grupa == null)
                    return;

                
                if (stocareGrupe.ValideazaExistentaGrupa(grupa))
                {
                    MessageBox.Show("Facultatea exista deja in baza de date");
                    return;
                }

                var rezultat = stocareGrupe.UpdateGrupa(grupa);
                if (rezultat == true)
                {
                    DialogResult dialog = MessageBox.Show("Grupa actualizata", "Felicitari", MessageBoxButtons.OK);
                    if (dialog == DialogResult.OK)
                    {
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Eroare la actualizare facultate");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie" + ex.Message);
            }
        }
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ButtonAnuleaza_Click(object sender, EventArgs e)
        {
            this.Hide();
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
                        comboBoxFacultateNou.Items.Add(item.NumeFacultate);
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

        private Grupa ValideazaInformatii()
        {
            try
            {
                StringBuilder mesajEroare = new StringBuilder();

                var denumireValida = Validari.ValideazaNumarGrupa(textBoxGrupaNou.Text);
                if (string.IsNullOrEmpty(denumireValida.Text))
                {
                    mesajEroare.Append($"{lblNumeGrupaNou.Text} : {denumireValida.Mesaj}\n");
                    lblNumeGrupaNou.ForeColor = Color.Red;
                }

                var nrStudentiValid = Validari.ValideazaNumarStudenti(textBoxNumarStudentiNou.Text);
                if (string.IsNullOrEmpty(nrStudentiValid.Text))
                {
                    mesajEroare.Append($"{lblNrStudentiNou.Text} : {nrStudentiValid.Mesaj}\n");
                    lblNrStudentiNou.ForeColor = Color.Red;
                }

                var numeSefGrupaValid = Validari.ValideazaDenumireFacultate(textBoxSefGrupaNou.Text);
                if (string.IsNullOrEmpty(numeSefGrupaValid.Text))
                {
                    mesajEroare.Append($"{lblFacultateNou.Text} : {numeSefGrupaValid.Mesaj}\n");
                    lblFacultateNou.ForeColor = Color.Red;
                }


                if (!string.IsNullOrEmpty(mesajEroare.ToString()))
                {
                    MessageBox.Show($"{mesajEroare}");
                    return null;
                }

                int idFac = 0;
                foreach (var item in facultateList)
                {
                    if (item.NumeFacultate == comboBoxFacultateNou.SelectedItem.ToString())
                        idFac = item.IdFacultate;
                }
                if (idFac > 0)
                    return new Grupa(int.Parse(textBoxGrupaNou.Text), int.Parse(textBoxNumarStudentiNou.Text), textBoxSefGrupaNou.Text, idFac);
                
            }
            catch (Exception)
            {
                MessageBox.Show("A aparut o problema la validarea informatiilor despre materie");
            }
            return null;
        }
    }
}
