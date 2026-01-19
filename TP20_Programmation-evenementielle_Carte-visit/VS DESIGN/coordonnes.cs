using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Correction_TP20_EDI
{
    public partial class coordonnes : Form
    {
        public coordonnes()
        {
            InitializeComponent();
        }

        private void txtBx_Societe_TextChanged(object sender, EventArgs e)
        {

        }

        private void coordonnes_Load(object sender, EventArgs e)
        {

        }

        private void txtBx_Titre_TextChanged(object sender, EventArgs e)
        {

        }
        public bool formvalide()
        {
            if (txtBx_Societe.Text == "" ||
                txtBx_Titre.Text == "" ||
                txtBx_Description.Text == "" ||
                txtBx_Telephone.Text == "" ||
                txtbx_Adresse.Text == "" ||
                txtBx_Website.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void generateCard()
        {
            cardInfo = new Informations(
                txtBx_Societe: txtBx_Societe.Text,
                txtBx_Titre: txtBx_Titre.Text,
                txtBx_Description: txtBx_Description.Text,
                txtBx_Telephone: txtBx_Telephone.Text,
                txtBx_Adresse: txtbx_Adresse.Text,
                txtBx_Website: txtBx_Website.Text
            );
        }
    }
}
