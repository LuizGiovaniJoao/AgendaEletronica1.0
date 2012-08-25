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
    public partial class Viabilidade : Form
    {
        public Viabilidade()
        {
            InitializeComponent();
        }

        private void btPesquisa_Click(object sender, EventArgs e)
        {
            Pesquisa abrir = new Pesquisa();
            abrir.Show();
        }
    }
}
