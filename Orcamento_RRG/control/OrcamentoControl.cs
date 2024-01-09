using Orcamento_RRG.model;
using Orcamento_RRG.model.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orcamento_RRG.control
{
    internal class OrcamentoControl
    {

        public void adicionarOrcamento(Orcamento orcamento)
        {
            try
            {
                OrcamentoDAO.adicionarOrcamento(orcamento);
            }catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public void adicionarItens(int idProduto, string idOrcamento, int quantidade)
        {
            try
            {
                OrcamentoDAO.adicionarItens(idProduto, idOrcamento, quantidade);
            }catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable consultarTodosOrcamentos()
        {
            try
            {
                return OrcamentoDAO.consultarTodosOrcamentos();
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public DataTable consultarItensAnteriores(string numero)
        {
            return OrcamentoDAO.consultarItensAnteriores(numero);
        }

        public void atualizarOrcamento(Orcamento orcamento)
        {
            OrcamentoDAO.alterarOrcamento(orcamento);
        }

        public void excluirItens(string numero)
        {
            OrcamentoDAO.excluirItens(numero);
        }
    }
}
