using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Correction_TP_17_EDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void cmbBx_Operation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form1_load(object sender, EventArgs e)
        {
            cmbBx_Operation.Items.AddRange(new string[]
            {
                "Addition",
                "Soustraction",
                "Multiplication",
                "Division"
            });
        }
        Double Calculer(float nbr1, float nbr2, string op)
        {
            double res = 0;
            switch (op.ToLower())
            {
                case "addition":
                    res = nbr1 + nbr2;
                    break;
                case "soustraction":
                    res = nbr1 - nbr2;
                    break;
                case "multiplication":
                    res = nbr1 * nbr2;
                    break;
                case "division":
                    if (nbr2 != 0)
                        res = nbr1 / nbr2;
                    else
                        MessageBox.Show("Erreur ");
                    break;
                default:
                    MessageBox.Show("Erreur operation");
                    break;
            }
            return res;
        }
        private void btn_Calculer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBx_Nbr1.Text) ||
                string.IsNullOrWhiteSpace(TxtBx_Nbr2.Text))
            {
                MessageBox.Show("Erreur entrer deux nembre");
                return;
            }
            if (!float.TryParse(txtBx_Nbr1.Text, out float nbr1) ||
        !       float.TryParse(TxtBx_Nbr2.Text, out float nbr2))
            {
                MessageBox.Show("Erreur entrer deux nembre reels");
                return;
            }

            if (cmbBx_Operation.SelectedItem == null)
            {
                MessageBox.Show("chose the operation");
                return;
            }
            string operation = cmbBx_Operation.SelectedItem.ToString();
            double resultat = Calculer(nbr1,nbr2, operation);

            lbl_Resultat.Text = resultat.ToString("F6");
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void TxtBx_Nbr2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBx_Nbr1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
