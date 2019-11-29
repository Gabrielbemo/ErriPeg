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
                    reader.Read();
                    var id = reader.GetOrdinal("id");
                    Usuario.id = reader.GetInt32(id);
                    Usuario.login = reader.GetString(reader.GetOrdinal("login"));
                    Usuario.senha = reader.GetString(reader.GetOrdinal("password"));
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
        public void CreateSession(String history, String nome, String password)
        {
            cmd.CommandText = "INSERT INTO section (history,nome,password)values(@history,@nome,@password)";

            cmd.Parameters.AddWithValue("@history", history);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@password", password);

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
        //spellNameTextBox.Text.Trim(), spellDamageTextBox.Text.Trim(),
        //spellCostTextBox.Text.Trim(), spellCooldownTextBox.Text.Trim(), spellCooldownPrefixTextBox.Text.Trim()
        public void CreateSpell(String spellName, String spellDamage, String spellCost, String spellCooldown,
            String spellCooldownPrefix )
        {
            cmd.CommandText = "insert into spells (name,damage,cost,cooldown,prefix) values " +
                "(@spellName,@spellDamage,@spellCost,@spellCooldown,@spellCooldownPrefix)";

            cmd.Parameters.AddWithValue("@spellName", spellName);
            cmd.Parameters.AddWithValue("@spellDamage", spellDamage);
            cmd.Parameters.AddWithValue("@spellCost", spellCost);
            cmd.Parameters.AddWithValue("@spellCooldown", spellCooldown);
            cmd.Parameters.AddWithValue("@spellCooldownPrefix", spellCooldownPrefix);

            try
            {
                cmd.Connection = connection.Connect();
                cmd.ExecuteNonQuery();
                connection.Disconnect();
            }
            catch(SqlException)
            {
                throw;
            }
        }
    }
}
