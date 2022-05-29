using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DataAccess;
using ModelLibraries;

namespace Orar_BD
{
    public partial class Form_Adauga_Facultate : Form
    {
        private readonly IStocareFacultati stocareFacultati = (IStocareFacultati)new StocareFactory().GetTipStocare(typeof(Facultate));
        public Form_Adauga_Facultate()
        {
            InitializeComponent();
        }


        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ButtonAnuleaza_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ButtonAdaugaFacultate_Click(object sender, EventArgs e)
        {
            try
            {

                Facultate facultate = ValideazaInformatii();

                if (facultate == null)
                    return;

                if (stocareFacultati.ValideazaExistentaFacultate(facultate))
                {
                    MessageBox.Show("Materia exista deja in baza de date");
                    return;
                }

                var rezultat = stocareFacultati.AddFacultate(facultate);

                if (rezultat == true)
                {
                    // Displays the MessageBox.
                    DialogResult dialog = MessageBox.Show("Facultate adaugata cu succes", "Feilcitari!", MessageBoxButtons.OK);
                    if (dialog == DialogResult.OK)
                    {
                        // Closes the parent form.
                        this.Close();
                    }
                }

                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Materia nu a fost adaugata cu succes");
            }
        }

        private Facultate ValideazaInformatii()
        {
            try
            {
                StringBuilder mesajEroare = new StringBuilder();

                var denumireValida = Validari.ValideazaDenumireFacultate(textBoxNumeFacultate.Text);
                if (string.IsNullOrEmpty(denumireValida.Text))
                {
                    mesajEroare.Append($"{lblNumeFacultate.Text} : {denumireValida.Mesaj}\n");
                    lblNumeFacultate.ForeColor = Color.Red;
                }


                if (!string.IsNullOrEmpty(mesajEroare.ToString()))
                {
                    MessageBox.Show($"{mesajEroare}");
                    return null;
                }


                return new Facultate(textBoxNumeFacultate.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("A aparut o problema la validarea informatiilor despre materie");
            }
            return null;
        }

    }

}
