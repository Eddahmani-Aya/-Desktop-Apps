using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passage_1dai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void selectionnerChanson()
        {
            if (DGV_Chansons.CurrentRow != null)
            {
                txtBx_ID.Text = DGV_Chansons.CurrentRow.Cells[0].Value.ToString();
                txtBx_Nom.Text = DGV_Chansons.CurrentRow.Cells[1].Value.ToString();
                txtBx_Chanteur.Text = DGV_Chansons.CurrentRow.Cells[2].Value.ToString();
                cmbBx_Type.Text = DGV_Chansons.CurrentRow.Cells[3].Value.ToString();
            }
        }
        private void DGV_Chansons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectionnerChanson();
        }
        public int genererId()
        {
            int max = 0;

            foreach (DataGridViewRow row in DGV_Chansons.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    int id = int.Parse(row.Cells[0].Value.ToString());
                    if (id > max)
                        max = id;
                }
            }
            return max + 1;
        }
        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            DGV_Chansons.Rows.Add(
                genererId(),
                txtBx_Nom.Text,
                txtBx_Chanteur.Text,
                cmbBx_Type.Text
            );
        }

        private void modifierChansons( int id , String nom , String type , String chanteur )
        {
            for (int i = 0; i <= DGV_Chansons.RowCount - 1; i++)
            {

                if (int.Parse(DGV_Chansons.Rows[i].Cells[0].Value.ToString()) == id)
                {

                    DGV_Chansons.Rows[i].Cells[1].Value = nom;
                    DGV_Chansons.Rows[i].Cells[2].Value = ;
                    DGV_Chansons.Rows[i].Cells[3].Value = cmbBx_Type.Text;

                }
            }

        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            for (int i = 0 ; i <= DGV_Chansons.RowCount - 1; i++ )
            {
                
                if (int.Parse(DGV_Chansons.Rows[i].Cells[0].Value.ToString() == id )
                {
                    
                    DGV_Chansons.Rows[i].Cells[1]. = nom;
                    DGV_Chansons.Rows[i].Cells[2].Value = ;
                    DGV_Chansons.Rows[i].Cells[3].Value = cmbBx_Type.Text;
                    
                }
            }
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGV_Chansons.Rows)
            {
                if (row.Cells[0].Value != null &&
                    row.Cells[0].Value.ToString() == txtBx_ID.Text)
                {
                    DGV_Chansons.Rows.Remove(row);
                    break;
                }
            }
        }




    }
}
