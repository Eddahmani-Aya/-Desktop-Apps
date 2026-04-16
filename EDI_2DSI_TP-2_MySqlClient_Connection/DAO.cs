using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ED_2DAI_TP_2
{
    internal class DAO
    {
        private MySqlConnection conn;
        public DAO()
        {
            conn = new MySqlConnection("server=127.0.0.1;database=BDD_STORE-MYSQL;user=root;password=");
        }
        public bool connect()
        {
            bool x = false;
            if ((int)this.conn.State == 0)
            {
                this.conn.Open();
                x = true;
            }
            return x;
        }
        public bool disconnect()
        {
            bool x = false;
            if ((int)this.conn.State == 1)
            {
                this.conn.Close();
                x = true;
            }
            return x;
        }
    }
}
