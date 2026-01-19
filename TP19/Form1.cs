using System;

using System.Windows.Forms;

namespace Correction_TP19_EDI
{
    public partial class Form1 : Form
    {
        public static Class1 cvData;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Creer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBx_Nom.Text) ||
                string.IsNullOrWhiteSpace(txtBx_Prenom.Text) ||
                string.IsNullOrWhiteSpace(txtBx_Telephone.Text) ||
                string.IsNullOrWhiteSpace(txtBx_Adresse.Text) ||
                string.IsNullOrWhiteSpace(txtBx_Poste.Text) ||
                string.IsNullOrWhiteSpace(rTxtBx_Diplomes.Text) ||
                string.IsNullOrWhiteSpace(rTxtBx_Skills.Text) ||
                string.IsNullOrWhiteSpace(cmbBx_Langue.Text))
            {
                MessageBox.Show("Erreur entrer les info");
                return;
            }
            if (!rdBtn_Man.Checked && !rdBtn_Woman.Checked)
            {
                MessageBox.Show("Erreur chose one");
                return;
            }
            if (dtpNaissance.Value.Year>DateTime.Now.Year)
            {
                MessageBox.Show("Erreur de date");
                return;
            }
            string genre;
            if (rdBtn_Woman.Checked)
                genre = "Woman";
            else
                genre = "Man";

            cvData = new Class1(
               Nom: txtBx_Nom.Text,
               Prenom: txtBx_Prenom.Text,
               Telephone: txtBx_Telephone.Text,
               Adresse: txtBx_Adresse.Text,
               Poste: txtBx_Poste.Text,
               Naissance: dtpNaissance.Value,
               Diplomes: rTxtBx_Diplomes.Text,
               Skills: rTxtBx_Skills.Text,
               Genre: genre,
               Langue: cmbBx_Langue.Text
           );
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }
    }

}
