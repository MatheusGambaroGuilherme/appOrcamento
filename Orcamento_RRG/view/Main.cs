using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orcamento_RRG.view
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            NovoOrcamento form = new NovoOrcamento();
            form.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            NovoProduto form = new NovoProduto();
            form.Show();
        }

        private void btnGerenciar_Click(object sender, EventArgs e)
        {
            GerenciadorDeOrcamentos form = new GerenciadorDeOrcamentos();
            form.Show();
        }

        private void btnOrcamentos_Click(object sender, EventArgs e)
        {
            AlterarProduto form = new AlterarProduto();
            form.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
