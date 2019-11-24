using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    public class Class1
    {
        Connection connection = new Connection();
        SqlCommand cmd = new SqlCommand();

        public void register(String login, String senha)
        {
            cmd.CommandText = "INSERT INTO Player (login,password)values(@login,@senha)";

            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = connection.Connect();
                cmd.ExecuteNonQuery();
                connection.Disconnect();
            }
            catch (SqlException e)
            {
                throw;
            }
        }
    }
}
