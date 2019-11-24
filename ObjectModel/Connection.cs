using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    public class Connection
    {
        SqlConnection con = new SqlConnection();

        public Connection()
        {
            // hello world
            // banco pedro paulo // con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\banco_visual\Erripeg.mdf;Integrated Security=True;Connect Timeout=30";
        }

        public SqlConnection Connect()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void Disconnect()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}