using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED_2DAI_TP_2
{
    public partial class Form1 : Form
    {
        DAO dao;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dao = new DAO();
        }

        private void btn_Connexion_Click(object sender, EventArgs e)
        {
            if (dao.connect())
            {
                lbl_Etat.Text = "Connected";
                this.lbl_Etat.ForeColor = Color.Green;
            }
        }

        private void btn_DeConnexion_Click(object sender, EventArgs e)
        {
            if (dao.disconnect())
            {
                lbl_Etat.Text = "DisConnected";
                this.lbl_Etat.ForeColor = Color.Red;
            }
        }
    }
}
