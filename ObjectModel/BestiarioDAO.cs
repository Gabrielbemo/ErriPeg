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

        public void Register(string creatureConstitutionTextBox, string creatureCharismaTextBox , string creatureWisdomTextBox , string creatureDexterityTextBox , string creatureIntelligenceTextBox ,
            string creatureStrengthTextBox , string creatureXpTextBox , string creatureLvlTextBox , string creatureNameTextBox , string creatureHeightTextBox , string creatureWeightTextBox ,
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
        public string Search(string id)
        {
            string sql;
            SqlDataReader reader;

            sql = "Select * from creatures where id = \'" + int.Parse(id) + "\' ";
            try
            {
                cmd.Connection = connection.Connect();
                cmd = new SqlCommand(sql, cmd.Connection);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    string name = reader.GetString(reader.GetOrdinal("name"));
                    reader.Close();
                    cmd.Dispose();
                    connection.Disconnect();
                    return name;

                }
                else
                {
                    reader.Close();
                    cmd.Dispose();
                    connection.Disconnect();
                    return "";
                }

            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
