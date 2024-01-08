using Orcamento_RRG.control;
using Orcamento_RRG.model;
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
    public partial class NovoProduto : Form
    {
        ProdutoControl pcontrol = new ProdutoControl();
        public NovoProduto()
        {
            InitializeComponent();
        }

        public NovoProduto(String nome, String valorVenda, String valorCompra, String codigo)
        {
            InitializeComponent();
            txtNome.Text = nome;
            txtValorVenda.Text = valorVenda;
            txtValorCompra.Text = valorCompra;
            txtCodigo.Text = codigo;
        }

        private void NovoProduto_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                String nome = txtNome.Text;
                Double valorVenda = Double.Parse(txtValorVenda.Text);
                Double valorCompra = Double.Parse(txtValorCompra.Text);
                String codigo;
                if(txtCodigo.Text == null)
                {
                    codigo = " ";
                }
                else
                {
                    codigo = txtCodigo.Text;
                }
                

                Produto produto = new Produto(nome, valorVenda, valorCompra, codigo);
                pcontrol.cadastrarProduto(produto);
            }catch(Exception ex)
            {
                MessageBox.Show("Houve um problema ao cadastrar o produto!");
            }
            

        }
    }
}
