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
        }

        private void CreatureCreateButton_Click(object sender, EventArgs e)
        {
            BestiarioDAO bes = new BestiarioDAO();
            bes.Register(creatureConstitutionTextBox.Text, creatureCharismaTextBox.Text, creatureWisdomTextBox.Text, creatureDexterityTextBox.Text, creatureIntelligenceTextBox.Text,
                creatureStrengthTextBox.Text, creatureXpTextBox.Text, creatureLvlTextBox.Text, creatureNameTextBox.Text, creatureHeightTextBox.Text, creatureWeightTextBox.Text,
                creatureManaTextBox.Text, creatureLifeTextBox.Text, creatureIdTextBox.Text);
        }

        private void CreatureSearchButton_Click(object sender, EventArgs e)
        {
            BestiarioDAO bes = new BestiarioDAO();
            creatureNameTextBox.Text = bes.Search(c.Text); 
        }
    }
}
