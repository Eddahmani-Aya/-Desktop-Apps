using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED_2DAI_TP_6_Correction
{
    public class DAO
    {
        public NpgsqlConnection cnx;
        public NpgsqlCommand cmd;
        public void connexion(String req)
        {
            try
            {
                cnx = new NpgsqlConnection(req);
                if (cnx.State==0)
                {
                    cnx.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        public String readData(String req)
        {
            String data = "";
            try
            {
                cmd = new NpgsqlCommand(req, cnx);
                NpgsqlDataReader dr =cmd.ExecuteReader();   
                while (dr.Read())
                {
                    data += dr[0].ToString() + "\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return data;
        }
    } 
}

