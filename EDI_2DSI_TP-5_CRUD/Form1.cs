using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED_2DAI_TP_5_Correction
{
    public partial class Form1 : Form
    {
        DAO dao;
        public Form1()
        {
            InitializeComponent();
            dao = new DAO("Host=localhost;Database=BDD_BOOK;Username=postgres;Password=AYATON223");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (dao.connecter())
            {
                MessageBox.Show("Connected");
            }
            else{
                MessageBox.Show("diconnected");
            }
        }

        private void btn_Inserer_Click(object sender, EventArgs e)
        {
            String titre = txtBx_Titre.Text;
            String desc = rtxtBx_Description.Text;
            String auteur = txtBx_Auteur.Text;
            String prix = txtBx_Prix.Text;
            dao.inserer("insert into livre(titre,auteur,description,prix) values('" + titre + "','" + auteur + "','" + desc + "','" + prix + "')");
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBx_ID.Text);
            String titre = txtBx_Titre.Text;
            String desc = rtxtBx_Description.Text;
            String auteur = txtBx_Auteur.Text;
            String prix = txtBx_Prix.Text;
            dao.modifier("Update  livre set titre = '" + titre + "', auteur = '" + auteur + "', description = '" + desc + "',prix = '" + prix + "' where id ='"+id+"'");
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBx_ID.Text);
            dao.supprimer("DELETE FROM livre WHERE id = " + id);  
        }
    }
}
