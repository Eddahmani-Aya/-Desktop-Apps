using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ED_2DAI_TP_6_Correction
{
    public partial class Form1 : Form
    {
        DAO x;
       
        public Form1()
        {
            InitializeComponent();
            x=new DAO();
            x.Connexion("Server=localhost;UserId=postgres;Password=AYATON223;Database=BDD_BOOKS");
        }
        public void afficherDonnses()
        {
            DGV_Livres.Rows.Clear();
            NpgsqlDataReader rdd = x.recupererDonnse("select * from livre");
            if (rdd.HasRows)
            {
                while (rdd.Read())
                {
                    DGV_Livres.Rows.Add(rdd[0], rdd[1], rdd[2], rdd[3], rdd[4]);
                }
            }
            rdd.Close();
            x.rd.Close();
        }
        public bool formValid() { 
            if (txtBx_ID.Text == "" || txtBx_Titre.Text == "" || txtBx_Auteur.Text == "" || txtBx_Auteur.Text == "" || txtBx_Prix.Text == "" rtxtBx_Desc.Text=="")
            {
                MessageBox.Show("Veuillez remplir tous les champs");
                return false;
            }
            return true;
        }
        public void selectionnerLivre()
        {
            if (DGV_Livres.CurrentRow != null)
            {
                txt_Id.Text = DGV_Livres.CurrentRow.Cells[0].Value.ToString();
                txt_Titre.Text = DGV_Livres.CurrentRow.Cells[1].Value.ToString();
                txt_Auteur.Text = DGV_Livres.CurrentRow.Cells[2].Value.ToString();
                txt_Editeur.Text = DGV_Livres.CurrentRow.Cells[3].Value.ToString();
                txt_Annee.Text = DGV_Livres.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           afficherDonnses();
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            if (!formValid()) {
                x.traiterDonnse("insert into livre  values (" + txt_Id.Text + ",'" + txt_Titre.Text + "','" + txt_Auteur.Text + "','" + txt_Editeur.Text + "'," + txt_Annee.Text + ")");
                afficherDonnses();
            }
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            x.traiterDonnse("delete from livre where id=" + txt_Id.Text);
            afficherDonnses();
        }

        private void txtBx_Titre_TextChanged(object sender, EventArgs e)
        {
            x.traiterDonnse("update livre set titre='" + txt_Titre.Text + "' where id=" + txt_Id.Text);
            afficherDonnses();

        }

        private void DGV_Livres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectionnerLivre();
        }
    }
}
