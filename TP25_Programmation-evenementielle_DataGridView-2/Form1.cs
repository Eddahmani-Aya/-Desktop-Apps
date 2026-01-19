using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Correction_TP24_EDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void chargerTypes()
        {
            cmbBx_Types.Items.Add("Action");
            cmbBx_Types.Items.Add("Horror");
            cmbBx_Types.Items.Add("Romance");
        }
        public void chargerProducteurs()
        {
            cmbBx_Producteurs.Items.Add("Prod1");
            cmbBx_Producteurs.Items.Add("Prod2");
            cmbBx_Producteurs.Items.Add("Prod3");
        }
        public void chargerFilms()
        {
            DGV_Films.Rows.Add("1", "Film1", "Horreur", "Prod2");
            DGV_Films.Rows.Add("2", "Film2", "Action", "Prod3");
            DGV_Films.Rows.Add("3", "Film3", "Romance", "Prod1");
        }
        public int getNextId()
        {
            int max = 0;
            for (int i = 0; i < DGV_Films.RowCount - 1; i++)
            {
                if (int.Parse(DGV_Films.Rows[i].Cells[0].Value.ToString()) > max)
                {
                    max = int.Parse(DGV_Films.Rows[i].Cells[0].Value.ToString());
                }
            }
            return max + 1;
        }
        public void selectionnerFilm()
        {
            txtBx_ID.Text = DGV_Films.CurrentRow.Cells[0].Value.ToString();
            txtBx_Nom.Text = DGV_Films.CurrentRow.Cells[1].Value.ToString();
            cmbBx_Types.Text= DGV_Films.CurrentRow.Cells[2].Value.ToString();
            cmbBx_Producteurs.Text= DGV_Films.CurrentRow.Cells[3].Value.ToString();
        }
        public void ajouterFilm(int id,String nom,String type,String producteur)
        {
            DGV_Films.Rows.Add(id, nom, type, producteur);
        }
        public void modifierFilm(int id, String nom, String type, String producteur)
        {
            for (int i = 0; i < DGV_Films.RowCount - 1; i++)
            {
                if (int.Parse(DGV_Films.Rows[i].Cells[0].Value.ToString()) ==id)
                {
                    DGV_Films.Rows[i].Cells[1].Value = nom;
                    DGV_Films.Rows[i].Cells[2].Value = type;
                    DGV_Films.Rows[i].Cells[3].Value = producteur;
                }
            }
        }
        public void supprimerFilm(int id)
        {
            for (int i = 0; i < DGV_Films.RowCount - 1; i++)
            {
                if (int.Parse(DGV_Films.Rows[i].Cells[0].Value.ToString()) == id)
                {
                    DGV_Films.Rows.RemoveAt(i);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            chargerTypes();
            chargerProducteurs();
            chargerFilms();
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            ajouterFilm(getNextId(), txtBx_Nom.Text, cmbBx_Types.Text, cmbBx_Producteurs.Text);
        }


        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            modifierFilm(int.Parse(txtBx_ID.Text),txtBx_Nom.Text,cmbBx_Types.Text,cmbBx_Producteurs.Text);
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            supprimerFilm(int.Parse(txtBx_ID.Text));
        }

        private void DGV_Films_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectionnerFilm();
        }
    }
}
