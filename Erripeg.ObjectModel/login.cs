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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            /*ConnectionsQuerys con = new ConnectionsQuerys();
            if(con.CheckLogin(textBoxLogin.Text.Trim(), textBoxSenha.Text.Trim())== true)
            {
                MessageBox.Show("Sucesso");
            }
            else
            {
                MessageBox.Show("Login ou senha invalidos");            
            }*/
            Login l = new Login();
            CriarSessão c = new CriarSessão();
            l.Close();
            c.Show();
        }

        private void ButtonCadastro_Click(object sender, EventArgs e)
        {
            ConnectionsQuerys con = new ConnectionsQuerys();
            con.Register(textBoxLogin.Text, textBoxSenha.Text);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
