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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void lkLbl_Deconnexion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Donnees.txtBx_Username = "";
            Donnees.txtBx_Name = "";
            Donnees.txtBx_Phone = "";
            Donnees.cmBx_Gender = "";
            Donnees.txtBx_Email = "";
            Donnees.txtBx_Password = "";
            this.Hide();
            login loginForm = new login();
            loginForm.Show();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            lbl_Username.Text = Donnees.txtBx_Username;
            lbl_Name.Text = Donnees.txtBx_Name;
            lbl_Phone.Text = Donnees.txtBx_Phone;
            lbl_Gender.Text = Donnees.cmBx_Gender;
            lbl_Email.Text = Donnees.txtBx_Email;
            lbl_Password.Text = Donnees.txtBx_Password;
        }
    }
}
