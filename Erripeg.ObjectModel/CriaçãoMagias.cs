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
    public partial class CriaçãoMagias : Form
    {
        public CriaçãoMagias()
        {
            InitializeComponent();
        }

        private void CriaçãoMagias_Load(object sender, EventArgs e)
        {

        }

        private void createSpellButton_Click(object sender, EventArgs e)
        {
            ConnectionsQuerys q = new ConnectionsQuerys();
            q.CreateSpell(spellNameTextBox.Text.Trim(), spellDamageTextBox.Text.Trim(),
                spellCostTextBox.Text.Trim(), spellCooldownTextBox.Text.Trim(), spellCooldownPrefixTextBox.Text.Trim());
        }
    }
}
