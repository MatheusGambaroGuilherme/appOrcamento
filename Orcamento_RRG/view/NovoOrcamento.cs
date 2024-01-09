using Orcamento_RRG.control;
using Orcamento_RRG.model;
using Orcamento_RRG.model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Orcamento_RRG.view
{
    public partial class NovoOrcamento : Form
    {
        public NovoOrcamento()
        {
            InitializeComponent();
            carregarProdutosComboBox();
            foreach (DataGridViewColumn column in dgvProdutos.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        ProdutoControl produtoControl = new ProdutoControl();

        public NovoOrcamento(string cliente, string numero, string data)
        {
            InitializeComponent();
            txtCliente.Text = cliente;

            //convertendo data pra caber no maskedtextbox
            DateTime dataFormatada = DateTime.Parse(data);
            txtData.Text = dataFormatada.ToString();

            txtNumeroOrcamento.Text = numero;

            carregarProdutosComboBox();
            foreach (DataGridViewColumn column in dgvProdutos.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            carregarItensAnteriores();
            atualizarPreco();
        }
        

        List<Produto> listaCBox = new List<Produto>();
        List<Produto> listaProdutosCarrinho = new List<Produto>();
        int idProdutoSelecionado;
        OrcamentoControl orcamentoControl = new OrcamentoControl();

        public void atualizarPreco()
        {
            double totalVenda = 0;
            double totalCusto = 0;
            int i = 0;
            foreach (DataGridViewRow row in dgvProdutos.Rows){
                totalVenda += (double)this.dgvProdutos.Rows[i].Cells[4].Value;
                totalCusto += (double) this.dgvProdutos.Rows[i].Cells[1].Value * (int)this.dgvProdutos.Rows[i].Cells[3].Value;
                i++;
            }
            lblValor.Text = totalVenda.ToString();
            lblCusto.Text = totalCusto.ToString();
        }

        public void adicionarProduto(int id, string nome, double valorVenda, double valorCompra, string codigo)
        {
            this.dgvProdutos.Rows.Add(nome, valorCompra, valorVenda, 1, valorVenda);
            Produto p = new Produto(nome, id, valorVenda, valorCompra, codigo);
            MessageBox.Show(p.Numero.ToString());
            listaProdutosCarrinho.Add(p);
        }

        public void carregarProdutosComboBox()
        {
            DataTable dt = new DataTable();
            dt = ProdutoDAO.obterProdutos(0);

            int i = 0;

            foreach (DataRow dr in dt.Rows)
            {
                cboxProduto.Items.Add(dt.Rows[i].Field<string>("nome").ToString());
                string nome = dt.Rows[i].Field<string>("nome").ToString();
                int numero = (int)dt.Rows[i].Field<Int64>("numero");
                double valorVenda = (double)dt.Rows[i].Field<double>("valorVenda");
                double valorCompra = (double)dt.Rows[i].Field<double>("valorCompra");
                string codigo = dt.Rows[i].Field<string>("codigo").ToString();

                Produto p = new Produto(nome, numero, valorVenda, valorCompra, codigo);
                listaCBox.Add(p);
                i++;
            }
        }

        private void cboxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaCBox[cboxProduto.SelectedIndex].Codigo == null)
            {
                listaCBox[cboxProduto.SelectedIndex].Codigo = " ";
            }
            adicionarProduto(listaCBox[cboxProduto.SelectedIndex].Numero, listaCBox[cboxProduto.SelectedIndex].Nome, listaCBox[cboxProduto.SelectedIndex].ValorVenda, listaCBox[cboxProduto.SelectedIndex].ValorCompra, listaCBox[cboxProduto.SelectedIndex].Codigo);
            atualizarPreco();
        }

        public void alterarValorTabela(int linhaSelecionada)
        {
            this.dgvProdutos.Rows[linhaSelecionada].Cells[4].Value = (int)this.dgvProdutos.Rows[linhaSelecionada].Cells[3].Value * listaProdutosCarrinho[linhaSelecionada].ValorVenda;
        }

        
        private void btnAumentarProduto_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = dgvProdutos.CurrentRow.Index;
            // Modify the value in the first cell of the second row.  
            this.dgvProdutos.Rows[linhaSelecionada].Cells[3].Value = (int)this.dgvProdutos.Rows[linhaSelecionada].Cells[3].Value + 1;
            alterarValorTabela(linhaSelecionada);
            atualizarPreco();
        }

        private void btnDiminuirProduto_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = dgvProdutos.CurrentRow.Index;
            // Modify the value in the first cell of the second row.  
            this.dgvProdutos.Rows[linhaSelecionada].Cells[3].Value = (int)this.dgvProdutos.Rows[linhaSelecionada].Cells[3].Value - 1;
            alterarValorTabela(linhaSelecionada);
            if ((int)this.dgvProdutos.Rows[linhaSelecionada].Cells[3].Value <= 0)
            {
                listaProdutosCarrinho.RemoveAt(linhaSelecionada);
                dgvProdutos.Rows.RemoveAt(linhaSelecionada);
            }
            atualizarPreco();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = dgvProdutos.CurrentRow.Index;
            listaProdutosCarrinho.RemoveAt(linhaSelecionada);
            dgvProdutos.Rows.RemoveAt(linhaSelecionada);
            atualizarPreco();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string cliente = txtCliente.Text;
                string data = txtData.Text;
                double valor = Double.Parse(lblValor.Text);
                string numero = txtNumeroOrcamento.Text;
                Orcamento orcamento = new Orcamento(cliente, data, numero, valor);
                orcamentoControl.adicionarOrcamento(orcamento);
                salvarProdutosTabela();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro ao salvar o orçamento. Tente novamente!");
            }
            
        }

        private void salvarProdutosTabela()
        {
            try
            {
                int idProduto = 0;
                int quantidade = 0;
                string numeroOrcamento = txtNumeroOrcamento.Text;
                int i = 0;
                foreach (DataGridViewRow row in dgvProdutos.Rows)
                {
                    idProduto = listaProdutosCarrinho[i].Numero;
                    MessageBox.Show(listaProdutosCarrinho[i].Numero.ToString());
                    quantidade = (int)this.dgvProdutos.Rows[i].Cells[3].Value;
                    orcamentoControl.adicionarItens(idProduto, numeroOrcamento, quantidade);
                    i++;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void carregarItensAnteriores()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = orcamentoControl.consultarItensAnteriores(txtNumeroOrcamento.Text);
                MessageBox.Show(dt.Rows[0].Field<string>("NumeroOrcamento"));
                int i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    MessageBox.Show("a");
                    int numero = (int) dt.Rows[i].Field<Int64>("IDProduto");
                    int quantidade = (int)dt.Rows[i].Field<Int64>("Quantidade");

                    DataTable dtProduto = new DataTable();
                    dtProduto = produtoControl.consultarPorNumero(numero);
                    MessageBox.Show("a");
                    MessageBox.Show(numero.ToString());
                    string nome = dtProduto.Rows[0].Field<string>("nome").ToString();
                    double valorVenda = (double)dtProduto.Rows[0].Field<double>("valorVenda");
                    double valorCompra = (double)dtProduto.Rows[0].Field<double>("valorCompra");
                    string codigo = dtProduto.Rows[0].Field<string>("codigo").ToString();

                    Produto p = new Produto(nome, numero, valorVenda, valorCompra, codigo);
                    this.dgvProdutos.Rows.Add(nome, precoCompra, precoVenda, quantidade);
                    i++;
                }

                MessageBox.Show(txtNumeroOrcamento.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
