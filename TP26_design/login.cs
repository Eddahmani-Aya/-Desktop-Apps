using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passage_1dai
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        public void connexion()
        {
            if (txtBx_Username.Text == "" || txtBx_Password.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs !");
                return;
            }

            if (txtBx_Username.Text == Donnees.Username &&
                txtBx_Password.Text == Donnees.Password)
            {
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username ou mot de passe incorrect !");
            }
        }


        private void btn_Login_Click(object sender, EventArgs e)
        {
            connexion();
        }

    }
}
