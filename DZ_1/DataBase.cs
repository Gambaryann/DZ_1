using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DZ_1
{
    internal class DataBase
    {
        SqlConnection db_con = new SqlConnection(@"Data Source = GAMBARYAN\STP; Initial Catalog = DZ_1; Integrated Security = True");

        public void openConnection()
        {
            if (db_con.State == System.Data.ConnectionState.Closed)
            {
                db_con.Open();
            }
        }

        public void closeConnection()
        {
            if (db_con.State == System.Data.ConnectionState.Open)
            {
                db_con.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return db_con;
        }
    }
}
