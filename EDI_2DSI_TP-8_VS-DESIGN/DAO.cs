using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ED_2DAI_TP_6_Correction
{
    public class DAO
    {
        NpgsqlConnection con;
        NpgsqlCommand cmd;
        NpgsqlDataReader dr;

        public bool Connexion(String connetion)
        {
            bool a = false;
            try
            {
                con = new NpgsqlConnection(connetion);
                if (con.State == 0)
                {
                    con.Open();
                    a = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return a;
        }
        public NpgsqlDataReader recupererDonnse(String query)
        {
            try
            {
                cmd = new NpgsqlCommand(query, con);
                dr = cmd.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dr;
        }
        public void traiterDonnse(String query)
        {
            try
            {
                cmd = new NpgsqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

