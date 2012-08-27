using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgendaEletronica1._0
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text == "Marcos" || txtNome.Text == "Giovani" || txtNome.Text == "Joao") && (txtSenha.Text == "123"))
            {
                   Viabilidade abrir = new Viabilidade();
                   abrir.Show();
            }
            else
            {
                MessageBox.Show("Usuário não cadastrado", "Espertinho!!");
                txtNome.Focus();
                txtNome.Text = "";
                txtSenha.Text = "";
            }

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja fechar o Programa?","???",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == (DialogResult.Yes))
            Application.Exit();
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox CorFundo = (TextBox)sender;
                if (CorFundo.BackColor == SystemColors.Window)
                {
                    CorFundo.BackColor = SystemColors.ControlLight;
                }
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            TextBox CorFundo = (TextBox)sender;
            if(sender is TextBox)
            {
                CorFundo.BackColor = SystemColors.Window;
            }
        }

    }
}
