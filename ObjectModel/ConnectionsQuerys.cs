using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    public class ConnectionsQuerys
    {
        readonly Connection connection = new Connection();
        SqlCommand cmd = new SqlCommand();

        public void Register(String login, String senha)
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
            catch (SqlException)
            {
                throw;
            }
            

        }
        public Boolean CheckLogin(string login, string senha)
        {
            /* DataSet result = new DataSet();
             SqlDataAdapter adapter = new SqlDataAdapter
             {
                 SelectCommand = new SqlCommand(
                 'select * from Player where login = ' + login +
                 'and ' +
                 'password = ' + senha,
                 connection.Connect())
             };
             adapter.Fill(result);

             result.Tables().;
             */
            string sql;
            SqlDataReader reader;

            sql = "Select * from Player where login = \'" + login + "\' " + 
                " and password = \'" + senha + "\' ";
            try
            {
                cmd.Connection = connection.Connect();
                cmd = new SqlCommand(sql, cmd.Connection);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    //reader.Read();
                    var pawg = reader.GetString(0);
                    Usuario.id = int.Parse(pawg);
                    Usuario.login = reader.GetString(1);
                    Usuario.senha = reader.GetString(2);
                    reader.Close();
                    cmd.Dispose();
                    connection.Disconnect();
                    return true;
                    
                }
                else
                {
                    reader.Close();
                    cmd.Dispose();
                    connection.Disconnect();
                    return false;
                }
                
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
