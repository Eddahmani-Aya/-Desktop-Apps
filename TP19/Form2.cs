using System;

using System.Windows.Forms;

namespace Correction_TP19_EDI
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Form1.cvData != null)
            {
                Class1 cv = Form1.cvData;

                lbl_NomComplet.Text = $"{cv.Nom} {cv.Prenom}";
                lbl_Poste.Text = cv.Poste;
                lbl_Telephone.Text = cv.Telephone;
                lbl_Genre.Text = cv.Genre;
                int age = DateTime.Now.Year - cv.Naissance.Year;
                if (cv.Naissance > DateTime.Now.AddYears(-age))
                    age--;
                lbl_Age.Text = age.ToString();
                lbl_Langue.Text = cv.Langue;
                lbl_Diplomes.Text = cv.Diplomes;
                lbl_Skills.Text = cv.Skills;
            }
            else
            {
                MessageBox.Show("No data found!");
            }
        }
    
    }
}
