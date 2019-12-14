using ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Erripeg.ObjectModel
{
    public partial class CriaçãoPersonagem : Form
    {
        Connection connection = new Connection();
        SqlCommand cmd = new SqlCommand();
        public CriaçãoPersonagem()
        {
            
            InitializeComponent();
            if (Usuario.id != Usuario.mestre)
            {
                teste.Enabled = false;
                if (String.IsNullOrEmpty(Usuario.name) || !Usuario.name.Any())
                {
                    button2.Enabled = false;
                }


            }
            if (!String.IsNullOrEmpty(Usuario.name) && Usuario.name.Any())
            {
                characterCreateButton.Enabled = false;
                characterLifeTextBox.Text = Usuario.life.ToString();
                characterManaTextBox.Text = Usuario.mana.ToString();
                characterWeightTextBox.Text = Usuario.weight.ToString();
                characterHeightTextBox.Text = Usuario.height.ToString();
                characterXpTextBox.Text = Usuario.xp.ToString();
                characterNameTextBox.Text = Usuario.name;
                characterLvlTextBox.Text = Usuario.lvl.ToString();
                characterBackgroundRichTextBox.Text = Usuario.bk;
                if (Usuario.id != Usuario.mestre)
                {
                    characterSearchTextBox.Text = Usuario.id_cha.ToString();
                    characterSearchTextBox.Enabled = false;
                }
                else
                {
                    characterCreateButton.Enabled = true;
                }
            }
            else
            {
                
            }
        }

        private void CharacterCreateButton_Click(object sender, EventArgs e)
        {
            PersonagemDAO p = new PersonagemDAO();
            p.Register(characterLifeTextBox.Text, characterManaTextBox.Text, characterWeightTextBox.Text, characterHeightTextBox.Text, characterXpTextBox.Text,
                characterNameTextBox.Text, characterLvlTextBox.Text, characterBackgroundRichTextBox.Text);
            menu m = new menu();
            this.Dispose();
            m.Show();
        }

        private void CharacterLifeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CriaçãoPersonagem_Load(object sender, EventArgs e)
        {

        }

        private void characterCreateButton_Click(object sender, EventArgs e)
        {

        }

        private void CriaçãoPersonagem_Load_1(object sender, EventArgs e)
        {

        }

        private void characterLvlLabel_Click(object sender, EventArgs e)
        {

        }

        private void characterInfoLabel_Click(object sender, EventArgs e)
        {

        }

        private void characterIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void characterLifeLabel_Click(object sender, EventArgs e)
        {

        }

        private void characterIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void characterLvlTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void characterNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void characterManaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void characterManaLabel_Click(object sender, EventArgs e)
        {

        }

        private void characterNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void characterWeightLabel_Click(object sender, EventArgs e)
        {

        }

        private void characterWeightTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void characterHeightLabel_Click(object sender, EventArgs e)
        {

        }

        private void characterHeightTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void characterXpLabel_Click(object sender, EventArgs e)
        {

        }

        private void characterXpTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void characterSearchLabel_Click(object sender, EventArgs e)
        {

        }

        private void characterSearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void characterBackgroundRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void characterBackgroundLabel_Click(object sender, EventArgs e)
        {

        }

        private void CharacterLvlTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (!characterSearchTextBox.Text.Any())
            {
                MessageBox.Show("informe o id do usuario");
                return;
            }
            PersonagemDAO pp = new PersonagemDAO();
            pp.update(characterSearchTextBox.Text, characterLifeTextBox.Text, characterManaTextBox.Text, characterWeightTextBox.Text, characterHeightTextBox.Text, characterXpTextBox.Text,
                characterNameTextBox.Text, characterLvlTextBox.Text, characterBackgroundRichTextBox.Text);
            MessageBox.Show("Atualizado");
        }

        private void CharacterLifeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void CharacterManaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void CharacterXpTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void CharacterHeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void CharacterWeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void CharacterSearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public SqlDataReader GetSqlDataReader(string sql)
        {
            cmd.Connection = connection.Connect();
            cmd = new SqlCommand(sql, cmd.Connection);
            return cmd.ExecuteReader();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (!characterSearchTextBox.Text.Any())
            {
                MessageBox.Show("Passe um id");
                return;
            }

            string sql;
            SqlDataReader reader;

            sql = "select * from character where id = " + Int32.Parse(characterSearchTextBox.Text.ToString());
            try
            {
                reader = GetSqlDataReader(sql);
                if (reader.HasRows)
                {
                    reader.Read();

                    characterLifeTextBox.Text = reader.GetDouble(reader.GetOrdinal("life")).ToString();
                    characterManaTextBox.Text = reader.GetDouble(reader.GetOrdinal("mana")).ToString();
                    characterLvlTextBox.Text = reader.GetInt32(reader.GetOrdinal("lvl")).ToString();
                    characterWeightTextBox.Text = reader.GetInt32(reader.GetOrdinal("weight")).ToString();
                    characterHeightTextBox.Text = reader.GetInt32(reader.GetOrdinal("height")).ToString();
                    characterXpTextBox.Text = reader.GetDouble(reader.GetOrdinal("xp")).ToString();
                    characterNameTextBox.Text = reader.GetString(reader.GetOrdinal("name"));
                    characterBackgroundRichTextBox.Text = reader.GetString(reader.GetOrdinal("history"));
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
            catch (Exception se)
            {
                MessageBox.Show(se.Message);
            }
        }
    }
}
