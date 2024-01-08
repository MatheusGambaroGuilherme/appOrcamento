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
    public partial class ProdutoWindow : Form
    {
        public ProdutoWindow()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            NovoProduto form = new NovoProduto();
            form.Show();
        }

        private void btnGerenciar_Click(object sender, EventArgs e)
        {
            AlterarProduto form = new AlterarProduto();
            form.Show();
        }
    }
}
