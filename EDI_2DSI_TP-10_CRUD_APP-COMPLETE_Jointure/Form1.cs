using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED_2DAI_TP_9_Correction
{
    public partial class Form1 : Form
    {
        DBConnection db;
        DemandeDAO demande;
        FormationDAO formation;
        EmployeDao employees;
        NpgsqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
            db = new DBConnection("Server=localhost;UserId=postgres;Password=AYATON223;Database=BDD_FOMATION");

            if (db.connexion())
            {
                demande = new DemandeDAO(db);
                formation = new FormationDAO(db);
                employees = new EmployeDao(db);
            }
            else
            {
                MessageBox.Show("Error connection");
            }

        }
        public void afficherFormation()
        {
            dr = formation.recupererTitreFormation();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    cmbBx_Titre.Items.Add[0];
                }
            }
        }

        private void btn_Generer_Click(object sender, EventArgs e)
        {
            txtBx_Demande.Text = demande.recupererMaxDemande().ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            afficherFormation();
            dr = employees.recupererFullNameEmploye();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    DGV_Employe.Rows.Add(dr[0]); 


                }
            }
        }
    }
}
