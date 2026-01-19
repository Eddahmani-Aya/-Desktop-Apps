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

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            if (cmbBx_Types.Text == "" || cmbBx_Producteurs.Text == "" || txtBx_Nom.Text == "" )
            {
                MessageBox.Show("Veuillez remplir tous les champs pour ajouter un film");
                return;
            }
            int nouvelID = DGV_Films.Rows.Count;
            DGV_Films.Rows.Add(nouvelID, txtBx_Nom.Text, cmbBx_Types.Text, cmbBx_Producteurs.Text);
            txtBx_Nom.Clear();
            cmbBx_Types.SelectedIndex = -1;
            cmbBx_Producteurs.SelectedIndex = -1;
            MessageBox.Show("Film ajouté avec succès !");

        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            if (DGV_Films.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un film à supprimer");
                return;
            }

            DataGridViewRow ligneSelectionnee = DGV_Films.SelectedRows[0];

            DialogResult result = MessageBox.Show(
                $"Voulez-vous vraiment supprimer le film '{ligneSelectionnee.Cells[1].Value}' ?",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                DGV_Films.Rows.Remove(ligneSelectionnee);
                MessageBox.Show("Film supprimé avec succès !");
            }
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            if (DGV_Films.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un film à modifier");
                return;
            }
            if (cmbBx_Types.Text == "" || cmbBx_Producteurs.Text == "" || txtBx_Nom.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs pour Modifier un film");
                return;
            }
            DataGridViewRow ligneSelectionnee = DGV_Films.SelectedRows[0];

            ligneSelectionnee.Cells[1].Value = txtBx_Nom.Text;        // Colonne NOM
            ligneSelectionnee.Cells[2].Value = cmbBx_Types.Text;      // Colonne TYPE
            ligneSelectionnee.Cells[3].Value = cmbBx_Producteurs.Text; // Colonne PRODUCTEUR

            txtBx_Nom.Clear();
            cmbBx_Types.SelectedIndex = -1;
            cmbBx_Producteurs.SelectedIndex = -1;

            MessageBox.Show("Film modifié avec succès !");
        }
    }
}
