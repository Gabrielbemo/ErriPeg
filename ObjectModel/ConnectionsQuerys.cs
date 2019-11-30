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
        public SqlDataReader GetSessions()
        {
            string sql = "Select * from Section";
            return GetSqlDataReader(sql);
        }
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
        public SqlDataReader GetSqlDataReader(string sql)
        {
            cmd.Connection = connection.Connect();
            cmd = new SqlCommand(sql, cmd.Connection);
            return cmd.ExecuteReader();
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
                reader = GetSqlDataReader(sql);
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
        public void SelectSpells()
        {
            //n ta pegando
            string sql;
            SqlDataReader reader;
            try
            {
                cmd.Connection = connection.Connect();
                cmd = new SqlCommand("select * from spells;", cmd.Connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    reader.Read();
                    var id = reader.GetOrdinal("id");
                    Spells.id = reader.GetInt32(id);
                    Spells.name = reader.GetString(reader.GetOrdinal("name"));
                    Spells.damage = reader.GetFloat(reader.GetOrdinal("damage"));
                    Spells.cost = reader.GetFloat(reader.GetOrdinal("cost"));
                    Spells.cooldown = reader.GetString(reader.GetOrdinal("cooldown"));
                    Spells.prefix = reader.GetString(reader.GetOrdinal("prefix"));
                    da.Fill(dt);
                    reader.Close();
                    cmd.Dispose();
                    connection.Disconnect();

                }
                else
                {
                    reader.Close();
                    cmd.Dispose();
                    connection.Disconnect();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteSpells(int id)
        {
            string sql = "delete from spells where id = " + id+ ";";
            SqlCommand s = new SqlCommand(sql);
            SqlDataReader reader;
            try
            {
                cmd.Connection = connection.Connect();
                reader = s.ExecuteReader();
                MessageBox.Show("Mágia deletada com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível deletar a mágia :(");
            }
        }
        public void UpdateSpells(int id)
        {
            string sql = "update spells set name = @name, damage = @damage, cost = @cost" +
                ", cooldown = @cooldown, prefix = @prefix where id =" + id + ";";
            SqlCommand s = new SqlCommand(sql);
            SqlDataReader reader;
            try
            {
                cmd.Connection = connection.Connect();
                reader = s.ExecuteReader();
                MessageBox.Show("Mágia Atualizada com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível atualizar a mágia :(");
            }
        }
        public void CreateCharacter(string characterConstitutionTextBox, string characterCharismaTextBox, string characterWisdomTextBox, string characterDexterityTextBox, string characterIntelligenceTextBox,
            string characterStrengthTextBox, string characterXpTextBox, string characterLvlTextBox, string characterNameTextBox, string characterHeightTextBox, string characterWeightTextBox,
            string characterManaTextBox, string characterLifeTextBox, string characterIdTextBox)
        {
            cmd.CommandText = "INSERT INTO characters (name,life,lvl,mana,weight,height,xp)values(@characterNameTextBox,@characterLifeTextBox,@characterLvlTextBox,@characterManaTextBox,@characterWeightTextBox,@characterHeightTextBox,@characterXpTextBox)";

            cmd.Parameters.AddWithValue("@characterNameTextBox", characterNameTextBox);
            cmd.Parameters.AddWithValue("@characterLifeTextBox", characterLifeTextBox);
            cmd.Parameters.AddWithValue("@characterLvlTextBox", characterLvlTextBox);
            cmd.Parameters.AddWithValue("@characterManaTextBox", characterManaTextBox);
            cmd.Parameters.AddWithValue("@characterWeightTextBox", characterWeightTextBox);
            cmd.Parameters.AddWithValue("@characterHeightTextBox", characterHeightTextBox);
            cmd.Parameters.AddWithValue("@characterXpTextBox", characterXpTextBox);

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
        public void DeleteCharacter(int id)
        {
            string sql = "delete from conditions_character where character_id = "+id+";" +
                "delete from inventory where character_id =" + id+ ";" +
                "delete from section_characters where character_id"+ id+";"+
                "delete from character where id = " + id + ";";
            SqlCommand s = new SqlCommand(sql);
            SqlDataReader reader;
            try
            {
                cmd.Connection = connection.Connect();
                reader = s.ExecuteReader();
                MessageBox.Show("Personagem deletado com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível deletar a Personagem :(");
            }
        }
        public void UpdateCharacter(string characterConstitutionTextBox, string characterCharismaTextBox, string characterWisdomTextBox, string characterDexterityTextBox, string characterIntelligenceTextBox,
            string characterStrengthTextBox, string characterXpTextBox, string characterLvlTextBox, string characterNameTextBox, string characterHeightTextBox, string characterWeightTextBox,
            string characterManaTextBox, string characterLifeTextBox, string characterIdTextBox)
        {

        }
    }
}
