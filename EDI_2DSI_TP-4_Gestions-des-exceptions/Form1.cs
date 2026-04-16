using System;
using Npgsql;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ED_2DAI_TP_4_Correction
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Indice_Click(object sender, EventArgs e)
        {

            try
            {
                int[] T = { 1, 4567, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };
                int indice = int.Parse(txtBx_Indice.Text);
                MessageBox.Show("Nbr : " + T[indice]);

            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            
        }

        private void btn_BDD_Click(object sender, EventArgs e)
        {
            try
            {
                String db = txtBx_BDD.Text;
                NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;database=" + db+ ";Username=postgres;password=AYATON223");
                conn.Open();
                MessageBox.Show("Connexion réussie");

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            
        }

        private void btn_Octet_Click(object sender, EventArgs e)
        {
            try
            {
                byte x = byte.Parse(txtBx_Octet.Text);
                MessageBox.Show("la valeur de cette variable est"+x);
            }
            catch(OverflowException ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void btn_Nbr_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtBx_Nbr.Text);
                MessageBox.Show("la valeur de cette variable est" + x);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
