﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgendaEletronica1._0
{
    public partial class Viabilidade : Form
    {
        public Viabilidade()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o Programa?", "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (DialogResult.Yes))
                Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btPesquisa_Click_1(object sender, EventArgs e)
        {
            Pesquisa abrir = new Pesquisa();
            abrir.Show();
        }

        private void btNovoContato_Click(object sender, EventArgs e)
        {
            Cadastrar abrir = new Cadastrar();
            abrir.Show();
        }
    }
}
