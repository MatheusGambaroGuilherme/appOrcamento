using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using Orcamento_RRG.model.DAO;
using Orcamento_RRG.model;

namespace Orcamento_RRG.control
{
    internal class ProdutoControl
    {

        public void cadastrarProduto(Produto produto)
        {
            try
            {
                ProdutoDAO.cadastrarProduto(produto);
            }catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        public void alterarProduto(Produto produto)
        {
            try
            {
                ProdutoDAO.alterarProduto(produto);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void excluirProduto(int id)
        {
            try
            {
                ProdutoDAO.excluirProduto(id);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
