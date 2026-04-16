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
        DAO x;
        NpgsqlDataReader rdd;
        public Form1()
        {
            InitializeComponent();
            x = new DAO("server=localhost;database=BDD_FILM;userid=postgres;password=AYATON223");
        }

        public void selectionnerFilm()
        {
            try
            {
                txtBx_ID.Text = DGV_FILMS.CurrentRow.Cells[0].Value.ToString();
                txtBx_Nom.Text = DGV_FILMS.CurrentRow.Cells[1].Value.ToString();
                cmbBx_Type.Text = DGV_FILMS.CurrentRow.Cells[2].Value.ToString();
                cmbBx_Producteur.Text = DGV_FILMS.CurrentRow.Cells[3].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void DGV_FILMS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectionnerFilm();
        }

        private void listerTypes()
        {
            try
            {
                //lister types
                rdd = x.lister("select nom from type");
                if (rdd.HasRows)
                {
                    while (rdd.Read())
                    {
                        cmbBx_Type.Items.Add(rdd[0]);
                    }
                }
                rdd.Close();
                x.rd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void listerProducteurs()
        {
            try
            {
                //lister producteurs
                rdd = x.lister("select nom from producteur");
                if (rdd.HasRows)
                {
                    while (rdd.Read())
                    {
                        cmbBx_Producteur.Items.Add(rdd[0]);
                    }
                }
                rdd.Close();
                x.rd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void listerFilms()
        {
            try
            {
                DGV_FILMS.Rows.Clear();
                rdd = x.lister("select film.id,film.nom,type.nom,producteur.nom from film,type,producteur where film.type = type.id and film.producteur=producteur.id");
                if (rdd.HasRows)
                {
                    while (rdd.Read())
                    {
                        DGV_FILMS.Rows.Add(rdd[0], rdd[1], rdd[2], rdd[3]);
                    }
                }
                rdd.Close();
                x.rd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private int getIdType()
        {
            int idType = 0;
            try
            {
                idType = x.getId("select id from type where nom ='" + cmbBx_Type.Text + "' ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return idType;
        }
        private int getIdProducteur()
        {
            int idProducteur = 0;
            try
            {
                idProducteur = x.getId("select id from producteur where nom ='" + cmbBx_Producteur.Text + "' ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return idProducteur;
        }

   

      

        private void Form1_Load_1(object sender, EventArgs e)
        {
            if (x.connexion())
            {
                listerFilms();
                listerTypes();
                listerProducteurs();
            }
            else
            {
                MessageBox.Show("erreur cnx");
            }
        }

        private void btn_Ajouter_Click_1(object sender, EventArgs e)
        {
            x.executerRequete("insert into film(nom,type,producteur) values('" + txtBx_Nom.Text + "','" + getIdType() + "','" + getIdProducteur() + "')");
            listerFilms();
        }

        private void btn_Modifier_Click_1(object sender, EventArgs e)
        {
            x.executerRequete("update film set nom='" + txtBx_Nom.Text + "',type='" + getIdType() + "',producteur='" + getIdProducteur() + "'");
            listerFilms();
        }

        private void btn_Supprimer_Click_1(object sender, EventArgs e)
        {
            x.executerRequete("delete from film where id='" + int.Parse(txtBx_ID.Text) + "'");
            listerFilms();
        }
    }
}
