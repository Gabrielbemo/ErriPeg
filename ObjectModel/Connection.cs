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
        readonly SqlConnection con = new SqlConnection();

        public Connection()
        {
            // hello world
            // banco pedro paulo // 
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\USERS\GABRI\DESKTOP\BANCO\ERRIPEG.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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