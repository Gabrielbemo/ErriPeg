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
    public partial class CriarSessão : Form
    {
        public CriarSessão()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ConnectionsQuerys c = new ConnectionsQuerys();
            //c.CreateSession(sessionStoryRichTextBox.Text.Trim(),sessionNameTextBox.Text.Trim(), sessionPasswordTextBox.Text.Trim());
        }

        private void CriarSessão_Load(object sender, EventArgs e)
        {

        }

        private void selectSessionButton_Click(object sender, EventArgs e)
        {
            SelectSession s = new SelectSession();
            s.Show();
        }
    }
}
