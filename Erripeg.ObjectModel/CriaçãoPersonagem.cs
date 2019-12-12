using ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Erripeg.ObjectModel
{
    public partial class CriaçãoPersonagem : Form
    {
        public CriaçãoPersonagem()
        {
            InitializeComponent();
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
    }
}
