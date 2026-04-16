using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ED_2DAI_TP_9_Correction
{
    internal class DAO
    {
        public NpgsqlConnection con;
        public NpgsqlCommand cmd;
        public NpgsqlDataReader rd;
        public DAO(string connectionString)
        {
                con = new NpgsqlConnection(connectionString);
        }
        public bool connexion()
        {
            bool a = false;
            try
            {
                if (con.State == 0)
                {
                    con.Open();
                    a = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
            return a;
        }
        public NpgsqlDataReader lister(String query)
        {
            try
            {
                cmd = new NpgsqlCommand(query, con);
                rd = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
            return rd;
        }
        public int getId(String query)
        {
            int id = 0;
            try
            {
                cmd = new NpgsqlCommand(query, con);
                id = int.Parse(cmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
            return id;
        }
        public void executerRequete(String query)
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
