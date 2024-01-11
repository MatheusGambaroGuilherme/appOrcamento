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
            btnExportar.Enabled = false;
        }

        ProdutoControl produtoControl = new ProdutoControl();

        public NovoOrcamento(string cliente, string numero, string data, int idOrcamento)
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
            btnSalvar.Text = "Alterar";
            atualizar = 1;
            id = idOrcamento;
        }

        int id;
        int atualizar = 0;
        List<Produto> listaCBox = new List<Produto>();
        List<Produto> listaProdutosCarrinho = new List<Produto>();
        int idProdutoSelecionado;
        OrcamentoControl orcamentoControl = new OrcamentoControl();

        public void atualizarPreco()
        {
            double totalVenda = 0;
            double totalCusto = 0;
            int i = 0;
            foreach (DataGridViewRow row in dgvProdutos.Rows)
            {
                totalVenda += (double)this.dgvProdutos.Rows[i].Cells[2].Value * (int)this.dgvProdutos.Rows[i].Cells[3].Value;
                totalCusto += (double)this.dgvProdutos.Rows[i].Cells[1].Value * (int)this.dgvProdutos.Rows[i].Cells[3].Value;
                i++;
            }
            lblValor.Text = totalVenda.ToString();
            lblCusto.Text = totalCusto.ToString();
        }

        public void adicionarProduto(int id, string nome, double valorVenda, double valorCompra, string codigo)
        {
            this.dgvProdutos.Rows.Add(nome, valorCompra, valorVenda, 1, valorVenda);
            Produto p = new Produto(nome, id, valorVenda, valorCompra, codigo);
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
                double valorVenda = (double)dt.Rows[i].Field<Decimal>("valorVenda");
                double valorCompra = (double)dt.Rows[i].Field<Decimal>("valorCompra");
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
            try
            {
                int linhaSelecionada = dgvProdutos.CurrentRow.Index;
                // Modify the value in the first cell of the second row.  
                this.dgvProdutos.Rows[linhaSelecionada].Cells[3].Value = (int)this.dgvProdutos.Rows[linhaSelecionada].Cells[3].Value + 1;
                alterarValorTabela(linhaSelecionada);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao aumentar produto");
            }

            atualizarPreco();
        }

        private void btnDiminuirProduto_Click(object sender, EventArgs e)
        {
            try
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao diminuir produto");
            }

            atualizarPreco();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                int linhaSelecionada = dgvProdutos.CurrentRow.Index;
                listaProdutosCarrinho.RemoveAt(linhaSelecionada);
                dgvProdutos.Rows.RemoveAt(linhaSelecionada);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir produto");
            }

            atualizarPreco();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (atualizar == 0)
            {
                try
                {
                    string cliente = txtCliente.Text;
                    string data = txtData.Text;
                    double valor = Double.Parse(lblValor.Text);
                    string numero = txtNumeroOrcamento.Text;
                    string dataTeste = data;
                    DateTime dataFormatada = DateTime.Parse(dataTeste);

                    if (cliente == null || valor == 0 || numero == null || data == null || (dgvProdutos.Rows.Count > 0 && cliente == null || valor == 0 || numero == null || data == null))
                    {
                        MessageBox.Show("Por favor, insira todas as informações para salvar!");
                    }
                    else
                    {
                        Orcamento orcamento = new Orcamento(cliente, data, numero, valor);
                        orcamentoControl.adicionarOrcamento(orcamento);
                        salvarProdutosTabela();
                        this.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Houve um erro ao salvar o orçamento. Tente novamente!");
                }
            }
            else
            {
                 try
                 {
                string cliente = txtCliente.Text;
                string data = txtData.Text;
                double valor = Double.Parse(lblValor.Text);
                string numero = txtNumeroOrcamento.Text;
                Orcamento orcamento = new Orcamento(cliente, data, numero, valor, id);
                orcamentoControl.atualizarOrcamento(orcamento);
                orcamentoControl.excluirItens(numero);
                salvarProdutosTabela();
                this.Close();
                 }
                 catch (Exception ex)
                {
                  MessageBox.Show("Houve um erro ao salvar o orçamento. Tente novamente!");
                 }
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
                    quantidade = (int)this.dgvProdutos.Rows[i].Cells[3].Value;
                    orcamentoControl.adicionarItens(idProduto, numeroOrcamento, quantidade);
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void carregarItensAnteriores()
        {
            try
            {
                DataTable dt = OrcamentoDAO.consultarItensAnteriores(txtNumeroOrcamento.Text);
                int i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    int numero = (int)dt.Rows[i].Field<Int64>("IDProduto");
                    int quantidade = (int)dt.Rows[i].Field<Int64>("Quantidade");

                    DataTable dtProduto = new DataTable();
                    dtProduto = produtoControl.consultarPorNumero(numero);
                    string nome = dtProduto.Rows[0].Field<string>("nome").ToString();
                    double valorVenda = (double)dtProduto.Rows[0].Field<Decimal>("valorVenda");
                    double valorCompra = (double)dtProduto.Rows[0].Field<Decimal>("valorCompra");
                    string codigo = dtProduto.Rows[0].Field<string>("codigo").ToString();

                    Produto p = new Produto(nome, numero, valorVenda, valorCompra, codigo);
                    listaProdutosCarrinho.Add(p);
                    this.dgvProdutos.Rows.Add(nome, valorCompra, valorVenda, quantidade);
                    alterarValorTabela(i);
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Arquivos de Texto|*.txt|Todos os Aquivos|*.*";
            saveFileDialog.Title = "Exportar Arquivo";
            saveFileDialog.FileName = txtNumeroOrcamento.Text + " - " + txtCliente.Text;

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoSalvar = saveFileDialog.FileName;

                using (StreamWriter writer = new StreamWriter(caminhoSalvar))
                {
                    writer.WriteLine("Cliente: " + txtCliente.Text);
                    writer.WriteLine("Número do Orçamento: " + txtNumeroOrcamento.Text.ToString());
                    writer.WriteLine("Data do Orçamento: " + txtData.Text.ToString());
                    writer.WriteLine("\n\n");
                    writer.WriteLine("Materiais");
                    writer.WriteLine("\n\n");
                    int i = 0;
                    foreach (DataGridViewRow row in dgvProdutos.Rows)
                    {
                        string totalProduto = this.dgvProdutos.Rows[i].Cells[4].Value.ToString();
                        string codigoProduto = listaProdutosCarrinho[i].Codigo;
                        string quantidade = this.dgvProdutos.Rows[i].Cells[3].Value.ToString();
                        string nomeProduto = listaProdutosCarrinho[i].Nome;

                        writer.WriteLine($"{nomeProduto} - {codigoProduto} - Quantidade {quantidade} - Total do Item: R${Math.Round(Double.Parse(totalProduto), 2)}");
                        i++;
                    }
                    writer.WriteLine("\n\n");
                    writer.WriteLine("-----------------------");
                    writer.WriteLine("\n\n");
                    writer.WriteLine("Total do Orçamento R$" + Math.Round(Double.Parse(lblValor.Text), 2));
                }
                
            }
        }
    }
}
