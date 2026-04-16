using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED_2DAI_TP_9_Correction
{
    internal class DemandeDAO
    {
        DBConnection db;
        public NpgsqlConnection conn;
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr; 
         public DemandeDAO(DBConnection db)
         {
            this.conn = db.conn;
         }
        public int recupererMaxDemande()
        {
            int max = 0;
            try
            {
                cmd = new NpgsqlCommand("select max(n_demande) from demanade",conn);
                

            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show(e.StackTrace);
            }
            return max;
        }


    }
}
