using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED_2DAI_TP_9_Correction
{
    internal class FormationDAO
    {

        DBConnection db;
        public NpgsqlConnection conn;
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public FormationDAO(DBConnection db)
        {
            this.conn = db.conn;
        }
        public NpgsqlDataReader recupererTitreFormation()
        {
            try
            {
                cmd = new NpgsqlCommand("select titre from formation", conn);


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show(e.StackTrace);
            }
            return dr;
        }
        public void deleteFormwtion(int numero)
        {
            try
            {
                cmd = new NpgsqlCommand("delete  from formation where formation ='"+numero+"' ", conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show(e.StackTrace);
            }
        }


    }
}
