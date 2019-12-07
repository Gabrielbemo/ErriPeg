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

        private void CriaçãoPersonagem_Load(object sender, EventArgs e)
        {

        }

        private void characterCreateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
