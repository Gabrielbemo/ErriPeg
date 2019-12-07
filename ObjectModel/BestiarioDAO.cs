using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System ;
using System.Threading.Tasks;

namespace ObjectModel
{
    public  class BestiarioDAO
    {
        readonly Connection connection = new Connection();
        SqlCommand cmd = new SqlCommand();

        public void delete(int id)
        {

        }

        public void Register( string creatureXpTextBox , string creatureLvlTextBox , string creatureNameTextBox , string creatureHeightTextBox , string creatureWeightTextBox ,
            string creatureManaTextBox , string creatureLifeTextBox , string creatureIdTextBox )
        {
            cmd.CommandText = "INSERT INTO Creatures (name,life,lvl,mana,weight,height,xp)values(@creatureNameTextBox,@creatureLifeTextBox,@creatureLvlTextBox,@creatureManaTextBox,@creatureWeightTextBox,@creatureHeightTextBox,@creatureXpTextBox)";

            cmd.Parameters.AddWithValue("@creatureNameTextBox", creatureNameTextBox);
            cmd.Parameters.AddWithValue("@creatureLifeTextBox", creatureLifeTextBox);
            cmd.Parameters.AddWithValue("@creatureLvlTextBox", creatureLvlTextBox);
            cmd.Parameters.AddWithValue("@creatureManaTextBox", creatureManaTextBox);
            cmd.Parameters.AddWithValue("@creatureWeightTextBox", creatureWeightTextBox);
            cmd.Parameters.AddWithValue("@creatureHeightTextBox", creatureHeightTextBox);
            cmd.Parameters.AddWithValue("@creatureXpTextBox", creatureXpTextBox);

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
        public creature Search(string id)
        {
            string sql;
            SqlDataReader reader;

            sql = "Select * from creatures where id = \'" + int.Parse(id) + "\' ";
            try
            {
                creature c = new creature();
                cmd.Connection = connection.Connect();
                cmd = new SqlCommand(sql, cmd.Connection);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    string name = reader.GetString(reader.GetOrdinal("name"));
                    
                    c.name = reader.GetString(reader.GetOrdinal("name"));
                    c.life = reader.GetDouble(reader.GetOrdinal("life"));
                    c.lvl = reader.GetDouble(reader.GetOrdinal("lvl"));
                    c.mana = reader.GetDouble(reader.GetOrdinal("mana"));
                    c.weight = reader.GetDouble(reader.GetOrdinal("weight"));
                    c.height = reader.GetDouble(reader.GetOrdinal("height"));
                    c.xp = reader.GetDouble(reader.GetOrdinal("xp"));
                    reader.Close();
                    cmd.Dispose();
                    connection.Disconnect();
                    return c;

                }
                else
                {
                    reader.Close();
                    cmd.Dispose();
                    connection.Disconnect();
                    return c;
                }

            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
