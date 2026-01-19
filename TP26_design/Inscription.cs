using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace passage_1dai
{
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }
        public void inscrire(string Nom, string Username, string Password , string Phone , string Gender)
        {
            Donnees.Nom = Nom;
            Donnees.Username = Username;
            Donnees.Password = Password;
            Donnees.Phone = Phone;
            Donnees.Gender = Gender;
        }
        public bool infosValables()
        {
            if (txtBx_Nom.Text == "" ||
                txtBx_Username.Text == "" ||
                txtBx_Password.Text == "" ||
                txtBx_Phone.Text == "" ||
                cmbBx_Gender.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }
        private void Inscription_Load(object sender, EventArgs e)
        {

        }

        private void btn_Inscription_Click(object sender, EventArgs e)
        {
            if (infosValables())
            {
                inscrire(
                    txtBx_Nom.Text,
                    txtBx_Username.Text,
                    txtBx_Password.Text,
                    txtBx_Phone.Text,
                    cmbBx_Gender.Text
                );

                MessageBox.Show("Inscription réussie !");
                this.Hide();
                login l = new login();
                l.Show();
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs !");
            }
        }

    }
}
