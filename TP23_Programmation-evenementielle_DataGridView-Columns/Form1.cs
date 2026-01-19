using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Correction_TP23_EDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            if (txtBx_NomAjouter.Text == "" || txtBx_TexteAjouter.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs pour ajouter une colonne");
                return;
            }
            String NomAjouter = txtBx_NomAjouter.Text;
            String TexteAjouter = txtBx_TexteAjouter.Text;

            DGV.Columns.Add(NomAjouter, TexteAjouter);
            txtBx_NomAjouter.Clear();
            txtBx_TexteAjouter.Clear();
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            if (txtBx_IndiceModifier.Text == "" || txtBx_NouveauTexte.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs ");
                return;
            }
            if (!int.TryParse(txtBx_IndiceModifier.Text, out int indice))
            {
                MessageBox.Show("L'indice doit être un nombre valide");
                return;
            }

            // Vérifier que l'indice existe dans le DataGridView
            if (indice < 0 || indice >= DGV.Columns.Count)
            {
                MessageBox.Show("L'indice n'existe pas dans le DataGridView");
                return;
            }
            String nouveauTexte = txtBx_NouveauTexte.Text;
            DGV.Columns[indice].HeaderText = nouveauTexte;

            txtBx_IndiceModifier.Clear();
            txtBx_NouveauTexte.Clear();
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            if (txtBx_IndiceSupprimer.Text == "" )
            {
                MessageBox.Show("Veuillez entrer l'indice de la colonne à supprimer");
                return;
            }
            if (!int.TryParse(txtBx_IndiceSupprimer.Text, out int indice))
            {
                MessageBox.Show("L'indice doit être un nombre valide");
                return;
            }

            // Vérifier que l'indice existe dans le DataGridView
            if (indice < 0 || indice >= DGV.Columns.Count)
            {
                MessageBox.Show("L'indice n'existe pas dans le DataGridView");
                return;
            }
            DGV.Columns.RemoveAt(indice);

            txtBx_IndiceSupprimer.Clear();

        }

        private void btn_Operation_Click_Click(object sender, EventArgs e)
        {
            bool operationEffectuee = false;
            if (txtBx_NomAjouter.Text != "" && txtBx_TexteAjouter.Text != "")
            {
                btn_Ajouter_Click(sender, e);
                MessageBox.Show("Colonne ajoutée avec succès");
                operationEffectuee = true;
            }

            if (txtBx_IndiceModifier.Text != "" && txtBx_NouveauTexte.Text != "")
            {
                btn_Modifier_Click(sender, e);
                MessageBox.Show("Colonne modifiée avec succès");
                operationEffectuee = true;
            }

            if (txtBx_IndiceSupprimer.Text != "")
            {
                btn_Supprimer_Click(sender, e);
                MessageBox.Show("Colonne supprimée avec succès");
                operationEffectuee = true;
            }
            if (!operationEffectuee)
            {
                MessageBox.Show("3emer chi haja bach dir operation!");
            }

        }
    }
}
