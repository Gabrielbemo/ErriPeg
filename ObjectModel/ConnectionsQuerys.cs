using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectModel
{
    public class ConnectionsQuerys
    {
        readonly Connection connection = new Connection();
        SqlCommand cmd = new SqlCommand();

        public void Register(String login, String senha)
        {   
            cmd.CommandText = "INSERT INTO Player (login,password) values (@login,@senha);";
            
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
        public Boolean CheckLogin(string login, string password)
        {
            bool usuarioExistente = false;
            try
            {
                connection.Connect();
                SqlCommand cmd = new SqlCommand("select * from player where login like '"+login.Trim()+"' and password like '"+password.Trim()+"';");
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    usuarioExistente = true;
                }
                connection.Disconnect();
            }
            catch (Exception ex)
            {
            }
            return usuarioExistente;

        }

        public void CreateSession(String history, String nome, String senha)
        {
            cmd.CommandText = "INSERT INTO Section (history,nome,password) values (@history,@nome,@senha);";

            cmd.Parameters.AddWithValue("@history", history);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = connection.Connect();
                cmd.ExecuteNonQuery();
                connection.Disconnect();
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Não foi possível criar a sessão");
            }
        }
    }
}
