using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// Provedor de dados do .NET Framework para SQL Server.
using System.Data.SqlClient;

namespace AgendaEletronica1._0
{
    public partial class Pesquisa : Form
    {
        SqlConnection conexao = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\AgendaEletronica1.0\AgendaEletronica1.0\Database1.mdf;Integrated Security=True;User Instance=True");
        SqlCommand comando = new SqlCommand();
        SqlDataReader LerDados;
        public Pesquisa()
        {
            InitializeComponent();
        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Pesquisa_Load(object sender, EventArgs e)
        {
            comando.Connection = conexao;
            loadlist();
        }

        public void loadlist()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();

            conexao.Open();
            comando.CommandText = "SELECT * FROM Contatos";
            LerDados = comando.ExecuteReader();
            if (LerDados.HasRows)
            {
                while (LerDados.Read())
                {
                    listBox1.Items.Add(LerDados[0].ToString());
                    listBox2.Items.Add(LerDados[1].ToString());
                    listBox3.Items.Add(LerDados[2].ToString());
                    listBox4.Items.Add(LerDados[3].ToString());
                    listBox5.Items.Add(LerDados[4].ToString());
                    listBox6.Items.Add(LerDados[5].ToString());
                    listBox7.Items.Add(LerDados[6].ToString());

                }
            }
            conexao.Close();
        }

        private void listBox7_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ListBox listar = sender as ListBox;
            if (listar.SelectedIndex != -1)
            {
                listBox1.SelectedIndex = listar.SelectedIndex;
                listBox2.SelectedIndex = listar.SelectedIndex;
                listBox3.SelectedIndex = listar.SelectedIndex;
                listBox4.SelectedIndex = listar.SelectedIndex;
                listBox5.SelectedIndex = listar.SelectedIndex;
                listBox6.SelectedIndex = listar.SelectedIndex;
                listBox7.SelectedIndex = listar.SelectedIndex;
            }
        }
    }
}
