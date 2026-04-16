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

namespace ED_2DAI_TP_6_Correction
{
    public partial class Form1 : Form
    {
        DAO x;
        NpgsqlDataReader reader;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x = new DAO("server = localhost;databas=BDD_BOOk;Password=");
            if (x.Connexion())
            {
                MessageBox.Show("Connected");
                reader = x.afficher("select auteur from livre");
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cmbBx_Auteur.Items.Add(reader[0]);


                    }

                }
            }
        }

        private void cmbBx_Auteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                reader = x.afficher("select * from livre where auteur ='"+cmbBx_Auteur.Text+"'");
                if (reader.HasRows)
                {
                    DGV_Livre.Rows.Clear();
                    while (reader.Read())
                    {
                        DGV_Livre.Rows.Add(reader[0], reader[1], reader[2], reader[3] ,reader[4], reader[5]);
                    }
                    reader.Close();
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
