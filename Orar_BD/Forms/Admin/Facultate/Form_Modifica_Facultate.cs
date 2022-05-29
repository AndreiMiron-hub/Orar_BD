using DataAccess;
using ModelLibraries;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Orar_BD
{
    public partial class Form_Modifica_Facultate : Form
    {
        private readonly IStocareFacultati stocareFacultati = (IStocareFacultati)new StocareFactory().GetTipStocare(typeof(Facultate));

        Facultate facultateDeModificat;
        public Form_Modifica_Facultate()
        {
            InitializeComponent();
        }
        public Form_Modifica_Facultate(Facultate facultate)
        {
            InitializeComponent();
            textBoxFacultateActual.Text = facultate.NumeFacultate;
            facultateDeModificat = facultate;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ButtonAnuleaza_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ButtonModificaFacultate_Click(object sender, EventArgs e)
        {
            try
            {
               
                if(!ValideazaInformatii())
                    return;
                facultateDeModificat.NumeFacultate = textBoxFacultateNou.Text;
                if (stocareFacultati.ValideazaExistentaFacultate(facultateDeModificat))
                {
                    MessageBox.Show("Facultatea exista deja in baza de date");
                    return;
                }

                var rezultat = stocareFacultati.UpdateFacultate(facultateDeModificat);
                if (rezultat == true)
                {
                    DialogResult dialog = MessageBox.Show("Facultate actualizata", "Felicitari", MessageBoxButtons.OK);
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


        private bool ValideazaInformatii()
        {
            try
            {
                StringBuilder mesajEroare = new StringBuilder();

                var denumireValida = Validari.ValideazaDenumireFacultate(textBoxFacultateNou.Text);
                if (string.IsNullOrEmpty(denumireValida.Text))
                {
                    mesajEroare.Append($"{lblNumeFacultate.Text} : {denumireValida.Mesaj}\n");
                    lblNumeFacultate.ForeColor = Color.Red;
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
    }
}
