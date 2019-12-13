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
    public partial class SelecionaPersonagem : Form
    {
        Connection connection = new Connection();
        SqlCommand cmd = new SqlCommand();
        public SelecionaPersonagem()
        {
            InitializeComponent();
            this.List("select id, name, lvl from character where id_user = "+ Usuario.id +" and id_session = " + Usuario.id_sessao);
            dataGridView1.Columns[2].HeaderText = "Level";
            dataGridView1.Columns[1].Width = 230;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CriaçãoPersonagem d = new CriaçãoPersonagem();
            d.Show();
            this.Dispose();
        }

        public void List(String sql)
        {
            try
            {
                cmd.Connection = connection.Connect();
                cmd = new SqlCommand(sql, cmd.Connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable ds = new DataTable();
                da.Fill(ds);
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = da.TableMappings[0].DataSetTable;

            }
            catch (Exception ex)
            {
                cmd.Dispose();
                connection.Disconnect();
            }
            finally
            {
                cmd.Dispose();
                connection.Disconnect();
            }
        }

        public SqlDataReader GetSqlDataReader(string sql)
        {
            cmd.Connection = connection.Connect();
            cmd = new SqlCommand(sql, cmd.Connection);
            return cmd.ExecuteReader();
        }

        private void DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //SelecionaPersonagem ss = new SelecionaPersonagem();
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            //ss.Show();
            //this.Dispose();
            //
            string sql;
            SqlDataReader reader;

            sql = "select * from character where id = " + Int32.Parse(selectedRow.Cells[0].Value.ToString());
            try
            {
                reader = GetSqlDataReader(sql);
                if (reader.HasRows)
                {
                    reader.Read();

                    Usuario.id_cha = reader.GetInt32(reader.GetOrdinal("id"));
                    Usuario.life = reader.GetDouble(reader.GetOrdinal("life"));
                    Usuario.mana = reader.GetDouble(reader.GetOrdinal("life"));
                    Usuario.weight = reader.GetDouble(reader.GetOrdinal("life"));
                    Usuario.height = reader.GetDouble(reader.GetOrdinal("life"));
                    Usuario.xp = reader.GetDouble(reader.GetOrdinal("life"));
                    Usuario.name = reader.GetString(reader.GetOrdinal("name"));
                    Usuario.bk = reader.GetString(reader.GetOrdinal("name"));
                    reader.Close();
                    cmd.Dispose();
                    connection.Disconnect();
                    menu mm = new menu();
                    mm.Show();
                    this.Dispose();
                }
                else
                {
                    reader.Close();
                    cmd.Dispose();
                    connection.Disconnect();
                }

            }
            catch (Exception)
            {

            }
        }
    }
}
