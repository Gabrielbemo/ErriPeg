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
                creatureManaTextBox.Text, creatureLifeTextBox.Text, c.Text, creatureBackgroundRichTextBox.Text);
            MessageBox.Show("Besta criada");
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
            creatureBackgroundRichTextBox.Text = ce.bk.ToString();
        }

        private void Bestiario_Load(object sender, EventArgs e)
        {

        }

        private void CreatureDeleteButton_Click(object sender, EventArgs e)
        {
            if (!c.Text.Any())
            {
                MessageBox.Show("Passe um id para deletar");
                return;
            }
            BestiarioDAO bes = new BestiarioDAO();
            bes.delete(Int32.Parse(c.Text));
            MessageBox.Show("Besta deletada");
            this.Dispose();
        }

        private void CreatureLvlTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CreatureLifeTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CreatureXpTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CreatureManaTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CreatureWeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CreatureHeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CreatureUpdateButton_Click(object sender, EventArgs e)
        {
            BestiarioDAO bes = new BestiarioDAO();
            bes.update(creatureXpTextBox.Text, creatureLvlTextBox.Text, creatureNameTextBox.Text, creatureHeightTextBox.Text, creatureWeightTextBox.Text,
                creatureManaTextBox.Text, creatureLifeTextBox.Text, c.Text, creatureBackgroundRichTextBox.Text);
            MessageBox.Show("Besta editada");
            this.Dispose();
        }
    }
}
