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
    public partial class SelectSession : Form
    {
        public SelectSession()
        {
            InitializeComponent();
        }

        private void createSessionButton_Click(object sender, EventArgs e)
        {

            CriarSessão c = new CriarSessão();
            c.Show();
        }

        private void selectSessionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
