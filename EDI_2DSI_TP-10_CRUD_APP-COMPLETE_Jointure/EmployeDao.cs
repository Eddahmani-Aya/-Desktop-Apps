using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ED_2DAI_TP_9_Correction
{
    internal class EmployeDao
    {

        DBConnection db;
        public NpgsqlConnection conn;
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public EmployeDao(DBConnection db)
        {
            this.conn = db.conn;
        }
        public NpgsqlDataReader recupererFullNameEmploye()
        {
            try
            {
                cmd = new NpgsqlCommand("select nom || || prenom from employe", conn);
                dr =cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show(e.StackTrace);
            }
            return dr;
        }

    }
}
