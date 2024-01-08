using Orcamento_RRG.control;
using Orcamento_RRG.model;
using Orcamento_RRG.model.DAO;
using System;
using System.Collections;
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
    public partial class AlterarProduto : Form
    {
        public AlterarProduto()
        {
            InitializeComponent();
            cboxPesquisa.SelectedIndex = 0;
            listProduto.Clear();
            DataTable table = new DataTable();
            table = ProdutoDAO.obterProdutos(0);
            int i = 0;
            foreach (DataRow dr in table.Rows)
            {
                String nome = table.Rows[i].Field<String>("nome").ToString();
                double valorVenda = table.Rows[i].Field<Double>("valorVenda");
                double valorCompra = table.Rows[i].Field<Double>("valorCompra");
                String codigo = table.Rows[i].Field<String>("codigo").ToString();
                int numero = (int)table.Rows[i].Field<Int64>("numero");

                Produto produto = new Produto(nome, numero, valorVenda, valorCompra, codigo);
                listProduto.Add(produto);

                i++;
            }
        }

        private List<Produto> listProduto = new List<Produto>();
        private int produtoIdAtual;
        ProdutoControl pcontrol = new ProdutoControl();
        private void btn_Novo_Click(object sender, EventArgs e)
        {
            NovoProduto form = new NovoProduto(txtNome.Text, txtValorVenda.Text, txtValorCompra.Text, txtCodigo.Text);
            form.ShowDialog();
        }

        private void AlterarProduto_Load(object sender, EventArgs e)
        {
            dgvProdutos.DataSource = ProdutoDAO.obterNomeProdutos();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            reiniciarTabela();
        }

        private void dgvProdutos_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                Produto p = listProduto[dgvProdutos.CurrentRow.Index];
                txtCodigo.Text = p.Codigo.ToString();
                txtNome.Text = p.Nome.ToString();
                txtValorCompra.Text = p.ValorCompra.ToString();
                txtValorVenda.Text = p.ValorVenda.ToString();
                produtoIdAtual = p.Numero;
            }
            catch (NullReferenceException ex)
            {
                dgvProdutos.Rows[0].Selected = true;
            }


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.CurrentRow.Index != null)
            {
                int linhaSelecionada = dgvProdutos.CurrentRow.Index;

                String nome = txtNome.Text;
                double valorVenda = Double.Parse(txtValorVenda.Text);
                double valorCompra = Double.Parse(txtValorCompra.Text);
                String codigo = txtCodigo.Text;
                int numero = produtoIdAtual;

                Produto p = new Produto(nome, numero, valorVenda, valorCompra, codigo);
                try
                {
                    pcontrol.alterarProduto(p);
                    reiniciarTabela();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public void reiniciarTabela()
        {
            if (cboxPesquisa.SelectedIndex == 0)
            {
                dgvProdutos.DataSource = ProdutoDAO.obterNomeProdutos();
                listProduto.Clear();
                DataTable table = new DataTable();
                table = ProdutoDAO.obterProdutos(0);
                int i = 0;
                foreach (DataRow dr in table.Rows)
                {
                    String nome = table.Rows[i].Field<String>("nome").ToString();
                    double valorVenda = table.Rows[i].Field<Double>("valorVenda");
                    double valorCompra = table.Rows[i].Field<Double>("valorCompra");
                    String codigo = table.Rows[i].Field<String>("codigo").ToString();
                    int numero = (int)table.Rows[i].Field<Int64>("numero");

                    Produto produto = new Produto(nome, numero, valorVenda, valorCompra, codigo);
                    listProduto.Add(produto);

                    i++;
                }
            }
            else if (cboxPesquisa.SelectedIndex == 1)
            {
                dgvProdutos.DataSource = ProdutoDAO.obterValorVendaProdutos();
                listProduto.Clear();
                DataTable table = new DataTable();
                table = ProdutoDAO.obterProdutos(1);
                int i = 0;
                foreach (DataRow dr in table.Rows)
                {
                    String nome = table.Rows[i].Field<String>("nome").ToString();
                    double valorVenda = table.Rows[i].Field<Double>("valorVenda");
                    double valorCompra = table.Rows[i].Field<Double>("valorCompra");
                    String codigo = table.Rows[i].Field<String>("codigo").ToString();
                    int numero = (int)table.Rows[i].Field<Int64>("numero");

                    Produto produto = new Produto(nome, numero, valorVenda, valorCompra, codigo);
                    listProduto.Add(produto);

                    i++;
                }
            }
            else if (cboxPesquisa.SelectedIndex == 2)
            {
                dgvProdutos.DataSource = ProdutoDAO.obterValoCompraProdutos();
                listProduto.Clear();
                DataTable table = new DataTable();
                table = ProdutoDAO.obterProdutos(2);
                int i = 0;
                foreach (DataRow dr in table.Rows)
                {
                    String nome = table.Rows[i].Field<String>("nome").ToString();
                    double valorVenda = table.Rows[i].Field<Double>("valorVenda");
                    double valorCompra = table.Rows[i].Field<Double>("valorCompra");
                    String codigo = table.Rows[i].Field<String>("codigo").ToString();
                    int numero = (int)table.Rows[i].Field<Int64>("numero");

                    Produto produto = new Produto(nome, numero, valorVenda, valorCompra, codigo);
                    listProduto.Add(produto);

                    i++;
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            pcontrol.excluirProduto(produtoIdAtual);
            reiniciarTabela();
        }
    }
}
