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
//

namespace AgendaEletronica1._0
{
    public partial class Cadastrar : Form
    {
        SqlConnection conexao = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\AgendaEletronica1.0\AgendaEletronica1.0\Database1.mdf;Integrated Security=True;User Instance=True");
        SqlCommand comando = new SqlCommand();
        SqlDataReader LerDados;
        
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" & txtNome.Text == "" & txttelefone1.Text == "")
            {
                this.Close();
            }
            else if (txtId.Text != "" || txtNome.Text != "" || txttelefone1.Text != "")
            {
                if (MessageBox.Show("Você realmente deseja cancelar o cadastro já iniciado?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Dispose();
                }
            }
        }

        // Método Form Cadastrar Load
        private void Cadastrar_Load(object sender, EventArgs e)
        {
            comando.Connection = conexao;
            loadlist();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" & txtNome.Text != "" & txttelefone1.Text != "" & txtTipo.Text != "")
            {
                conexao.Open();
                comando.CommandText = ("INSERT INTO Contatos (Id, Nome, Email, Telefone1, Telefone2, Celular, Tipo) VALUES('"+txtId.Text+"', '"+txtNome.Text+"', '"+txtemail.Text+"', '"+txttelefone1.Text+"', '"+txttelefone2.Text+"', '"+txtcelular.Text+"', '"+txtTipo.Text+"')");
                comando.ExecuteNonQuery();
                comando.Clone();

                MessageBox.Show("Contato salvo com sucesso!!", "Informação!", MessageBoxButtons.OK);
                conexao.Close();

                TiraValor();
                loadlist();

            }
            else
            {
                MessageBox.Show("Falha! \n Informações necessárias desconhecidas \nPreencha corretamente.\n Obrigado","Atenção!");
            }
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
            if(LerDados.HasRows)
            {
                while(LerDados.Read())
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

        public void TiraValor()
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtemail.Text = "";
            txttelefone1.Text = "";
            txttelefone2.Text = "";
            txtcelular.Text = "";
        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listar = sender as ListBox;
            if(listar.SelectedIndex != -1)
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
