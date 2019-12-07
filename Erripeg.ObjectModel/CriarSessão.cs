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
            ConnectionsQuerys c = new ConnectionsQuerys();
            try { 
                c.CreateSession(sessionStoryRichTextBox.Text.Trim(),sessionNameTextBox.Text.Trim(), checkBox1.Text);
                MessageBox.Show("Sessão criada com sucesso");
                SelectSession sss = new SelectSession();
                sss.Show();
                this.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Não foi possível criar a sessão");
            }
        }

        private void CriarSessão_Load(object sender, EventArgs e)
        {

        }

        private void selectSessionButton_Click(object sender, EventArgs e)
        {
            SelectSession s = new SelectSession();
            MessageBox.Show("o"+Usuario.id + Usuario.login);
            s.Show();
            this.Dispose();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            SelectSession ss = new SelectSession();
            ss.Show();
            this.Dispose();
        }
    }
}
