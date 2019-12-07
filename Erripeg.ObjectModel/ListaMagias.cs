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
    public partial class ListaMagias : Form
    {
        public ListaMagias()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectSpellDataGridView.Columns[0].HeaderText = "Name";
            selectSpellDataGridView.Columns[1].HeaderText = "Damage";
            selectSpellDataGridView.Columns[2].HeaderText = "Cost";
            selectSpellDataGridView.Columns[3].HeaderText = "Cooldown";
            selectSpellDataGridView.Columns[4].HeaderText = "Prefix";
        }

        private void ListaMagias_Load(object sender, EventArgs e)
        {

        }

        private void spellSearchButton_Click(object sender, EventArgs e)
        {

        }

        private void spellCreateButton_Click(object sender, EventArgs e)
        {
            CriaçãoMagias c = new CriaçãoMagias();
            c.Show();
        }

        private void updateTableButton_Click(object sender, EventArgs e)
        {

        }
    }
}
