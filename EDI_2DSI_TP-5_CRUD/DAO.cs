using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED_2DAI_TP_5_Correction
{
    internal class DAO
    {
        public NpgsqlConnection conn;
        public NpgsqlCommand cmd;
        public DAO(String chaineconn)
        {
            conn = new NpgsqlConnection(chaineconn);
        }
        public bool connecter()
        {
            bool a = false;
            try
            {
                if (conn.State == 0)
                {
                    conn.Open();
                    a = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
            return a;
        }
        public void inserer(String command)
        {
            try
            {
                cmd = new NpgsqlCommand(command, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }
        public void modifier(String command)
        {
            try
            {
                cmd = new NpgsqlCommand(command, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }
        public void supprimer(String command)
        {
            try
            {
                cmd = new NpgsqlCommand(command, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }

    }
}
