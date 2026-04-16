using System;
using Npgsql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED_2DAI_TP_6_Correction
{
    internal class DAO
    {
        public NpgsqlConnection conn;
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public DAO(String Connection)
        {
            conn = new NpgsqlConnection(Connection);
        }
        public bool Connexion()
        {
            bool a = false;
            try{
                conn.Open();
                if (conn.State != 0)
                {
                    a = true;
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return a;
        }
        public NpgsqlDataReader afficher(String req)
        {
            try
            {
                cmd = new NpgsqlCommand(req,conn);
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return dr;
        }

    }
}
