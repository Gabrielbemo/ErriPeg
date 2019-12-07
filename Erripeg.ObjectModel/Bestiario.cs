using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectModel;

namespace Erripeg.ObjectModel
{
    public partial class Bestiario : Form
    {
        public Bestiario()
        {
            InitializeComponent();
            if(Usuario.id != Usuario.mestre)
            {
                creatureCreateButton.Enabled = false;
                creatureDeleteButton.Enabled = false;
                creatureUpdateButton.Enabled = false;
            }
        }

        private void CreatureCreateButton_Click(object sender, EventArgs e)
        {
            BestiarioDAO bes = new BestiarioDAO();
            bes.Register(creatureXpTextBox.Text, creatureLvlTextBox.Text, creatureNameTextBox.Text, creatureHeightTextBox.Text, creatureWeightTextBox.Text,
                creatureManaTextBox.Text, creatureLifeTextBox.Text, creatureIdTextBox.Text);
        }

        private void CreatureSearchButton_Click(object sender, EventArgs e)
        {
            BestiarioDAO bes = new BestiarioDAO();
            creature ce = bes.Search(c.Text);
            creatureXpTextBox.Text = ce.xp.ToString();
            creatureLvlTextBox.Text = ce.lvl.ToString(); 
            creatureNameTextBox.Text = ce.name.ToString();
            creatureHeightTextBox.Text = ce.height.ToString();
            creatureWeightTextBox.Text = ce.weight.ToString();
            creatureManaTextBox.Text = ce.mana.ToString();
            creatureLifeTextBox.Text = ce.life.ToString();
        }

        private void Bestiario_Load(object sender, EventArgs e)
        {

        }

        private void CreatureDeleteButton_Click(object sender, EventArgs e)
        {
            BestiarioDAO bes = new BestiarioDAO();
            bes.delete(Int32.Parse(creatureIdTextBox.Text));
        }
    }
}
