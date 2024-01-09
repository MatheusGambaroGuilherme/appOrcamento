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
    public partial class GerenciadorDeOrcamentos : Form
    {
        public GerenciadorDeOrcamentos()
        {
            InitializeComponent();
            carregarTabelaOrcamentos();
        }


        OrcamentoControl orcamentoControl = new OrcamentoControl();
        List<Orcamento> listaOrcamentos = new List<Orcamento>();

        public void carregarTabelaOrcamentos()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = orcamentoControl.consultarTodosOrcamentos();
                int i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    int id = (int)dt.Rows[i].Field<Int64>("id");
                    string cliente = dt.Rows[i].Field<string>("cliente");
                    string data = dt.Rows[i].Field<string>("data");
                    double valor = dt.Rows[i].Field<double>("valor");
                    string numero = dt.Rows[i].Field<string>("numero");

                    Orcamento orcamento = new Orcamento(cliente, data, numero, valor);
                    listaOrcamentos.Add(orcamento);
                    this.dgvOrcamentos.Rows.Add(numero, cliente, data);
                    i++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void dgvOrcamentos_DoubleClick(object sender, EventArgs e)
        {
            int linhaSelecionada = dgvOrcamentos.CurrentRow.Index;
            string numero = listaOrcamentos[linhaSelecionada].Numero;
            string data = listaOrcamentos[linhaSelecionada].Data;
            string cliente = listaOrcamentos[linhaSelecionada].Cliente;

            NovoOrcamento novoOrcamento = new NovoOrcamento(cliente, numero, data);
            novoOrcamento.Show();  
        }
    }
}
