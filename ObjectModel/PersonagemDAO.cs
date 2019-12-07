using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    public class PersonagemDAO
    {
        readonly Connection connection = new Connection();
        SqlCommand cmd = new SqlCommand();

        public void Register(string characterLifeTextBox, string characterManaTextBox, string characterWeightTextBox, string characterHeightTextBox, string characterXpTextBox,
                string characterNameTextBox, string characterLvlTextBox, string characterBackgroundRichTextBox)
        {
            cmd.CommandText = "INSERT INTO character (life ,mana ,weight,height,xp,name,lvl,history )values" +
                "(@characterLifeTextBox,@characterManaTextBox,@characterWeightTextBox,@characterHeightTextBox,@characterXpTextBox,@characterNameTextBox,@characterLvlTextBox,@characterBackgroundRichTextBox)";

            cmd.Parameters.AddWithValue("@characterLifeTextBox", characterLifeTextBox);
            cmd.Parameters.AddWithValue("@characterManaTextBox", characterManaTextBox);
            cmd.Parameters.AddWithValue("@characterWeightTextBox", characterWeightTextBox);
            cmd.Parameters.AddWithValue("@characterHeightTextBox", characterHeightTextBox);
            cmd.Parameters.AddWithValue("@characterXpTextBox", characterXpTextBox);
            cmd.Parameters.AddWithValue("@characterNameTextBox", characterNameTextBox);
            cmd.Parameters.AddWithValue("@characterLvlTextBox", characterLvlTextBox);
            cmd.Parameters.AddWithValue("@characterBackgroundRichTextBox", characterBackgroundRichTextBox);

            try
            {
                cmd.Connection = connection.Connect();
                cmd.ExecuteNonQuery();
                Usuario.life = Double.Parse(characterLifeTextBox);
                Usuario.mana = Double.Parse(characterManaTextBox);
                Usuario.weight = Double.Parse(characterWeightTextBox);
                Usuario.height = Double.Parse(characterHeightTextBox);
                Usuario.xp = Double.Parse(characterXpTextBox);
                Usuario.name = characterNameTextBox;
                Usuario.life = Double.Parse(characterLifeTextBox);

                connection.Disconnect();
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
