using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED_2DAI_TP_6_Correction
{
    public partial class Form1 : Form
    {
        public DAO x;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x = new DAO();
            x.connexion("server=localhost;database=BDD_BOOKS;userid=postgres;password=AYATON223");
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtBx_ID.Text;
                string query = $"SELECT auteur FROM livre WHERE id = {id}";
                lbl_Auteur.Text = x.readData(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
