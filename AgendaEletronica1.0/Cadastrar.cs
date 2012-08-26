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
        //SqlDataReader LerDados;
        
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
            }
            else
            {
                MessageBox.Show("Falha! \n Informações necessárias desconhecidas \nPreencha corretamente.\n Obrigado","Atenção!");
            }
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
    }
}
