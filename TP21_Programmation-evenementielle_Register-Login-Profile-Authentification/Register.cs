using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Correction_TP21_EDI
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        public bool Formvalide()
        {
            bool X = false;
            if (txtBx_Name.Text != "" && txtBx_Phone.Text != "" && txtBx_Email.Text != "" && txtBx_Username.Text != "" && txtBx_Password.Text != "" && cmbBx_Gender.SelectedIndex != -1 )
            {
                X = true; 
            }
            return X;
        }
        public bool register()
        {
            bool X = false;
            if (Formvalide())
            {
                Donnees.txtBx_Name = txtBx_Name.Text;
                Donnees.txtBx_Phone = txtBx_Phone.Text;
                Donnees.txtBx_Username = txtBx_Username.Text;
                Donnees.txtBx_Password = txtBx_Password.Text;
                Donnees.cmBx_Gender = cmbBx_Gender.Text;
                Donnees.txtBx_Email = txtBx_Email.Text;

                X = true;
            }
            return X;
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (register()) {
                this.Hide();
                login loginForm = new login();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
            
        }

        private void lkLbl_Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            login loginForm = new login();
            loginForm.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.MaximizeBox = true;
        }
    }
}
